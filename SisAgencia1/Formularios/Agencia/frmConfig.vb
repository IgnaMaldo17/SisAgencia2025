Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Datos
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Text
Imports FastReport.Editor
Imports System.Runtime.InteropServices


Public Class frmConfig
    Dim UsuariosSP As New clsUsu
    Dim Monedas As DataTable

#Region "Shared Function"
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function
#End Region

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.FromArgb(30, 63, 111) Then
                    ColorParpadeo(pnlMnuTool, PictureBox2, btnMini, btnExit)
                Else
                    ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
                End If
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub FormatearComoMoneda(ByRef lbl As String)
        Dim valorDecimal As Decimal
        If Decimal.TryParse(lbl, valorDecimal) Then
            lbl = String.Format("{0:C2}", valorDecimal)
        Else
            lbl = "$0.00" ' O un valor predeterminado si no se puede convertir
        End If
    End Sub

    Private Sub FormatearLabelsComoMoneda()
        FormatearComoMoneda(ValorDolar)
        FormatearComoMoneda(ValorEuro)
        FormatearComoMoneda(ValorReal)
    End Sub

    Private Sub GetMonedas()
        Monedas = UsuariosSP.GetCotizacion()

        If Monedas.Rows.Count > 0 Then
            ValorDolar = Monedas.Rows(0)(2).ToString() ' Valor de la moneda
        End If

        If Monedas.Rows.Count > 1 Then
            ValorEuro = Monedas.Rows(1)(2).ToString() ' Valor de la segunda moneda
        End If

        If Monedas.Rows.Count > 2 Then
            ValorReal = Monedas.Rows(2)(2).ToString() ' Valor de la tercera moneda
        End If
    End Sub

    Private Sub CargaCmbPais()
        cmbCot.DataSource = UsuariosSP.GetCotizacion()
        cmbCot.ValueMember = "ID"
        cmbCot.DisplayMember = "NOMBRE"
    End Sub

    Dim NombreMoneda As String
    Dim ValorDolar As String
    Dim ValorEuro As String
    Dim ValorReal As String
    Dim ValorMoneda As String
    Dim IDMoneda As Integer

    Private Sub SeleccionCmb()
        Label2.Visible = True
        Label1.Visible = True
        Label1.Text = ValorMoneda
        Label5.Text = NombreMoneda
    End Sub

    Dim iniciocon As Boolean = True

    Private Sub Inicio()
        iniciocon = True
        ClearText(txtCon)
        PictureBox1.Image = My.Resources.icons8_circular_argentina_48
        Label2.Visible = False
        Label1.Visible = False
        Label1.Text = ""
        Label5.Text = "Seleccioné una moneda."
        txtCon.Enabled = True
        btnCamCon.Enabled = True
        cmbCot.SelectedIndex = -1
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
        CentrarForm(Me)
        GetMonedas()
        CargaCmbPais()
        FormatearLabelsComoMoneda()
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnExit, 10)
        frmMenu.RoundButton(btnCamCon, 10)
    End Sub

    Private Sub frmContraseña_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
    End Sub

    Private Sub cmbCot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCot.SelectedIndexChanged
        If cmbCot.Text = "Dólar USA" Then
            If InicioCon = False Then
                PictureBox1.Image = My.Resources.icons8_circular_de_ee_uu_48
                NombreMoneda = cmbCot.Text
                IDMoneda = cmbCot.SelectedValue
                ValorMoneda = ValorDolar
                SeleccionCmb()
            Else
                Return
            End If
        ElseIf cmbCot.Text = "EURO" Then
            PictureBox1.Image = My.Resources.icons8_bandera_circular_de_union_europea_48
            NombreMoneda = cmbCot.Text
            IDMoneda = cmbCot.SelectedValue
            ValorMoneda = ValorEuro
            SeleccionCmb()
        ElseIf cmbCot.Text = "Real BRA" Then
            PictureBox1.Image = My.Resources.icons8_circular_brasil_48
            NombreMoneda = cmbCot.Text
            IDMoneda = cmbCot.SelectedValue
            ValorMoneda = ValorReal
            SeleccionCmb()
        Else
            'Me.Close()
            'MensajeNotificacion("El nombre de la moneda no existe.", "Error.")
            Return
        End If
        txtCon.Enabled = True
        btnCamCon.Enabled = True
    End Sub

    Private Sub Modificar()
        If iniciocon = True Then
            MensajeNotificacion("Debe seleccionar una moneda.", "Aviso.")
            Return
        End If

        If txtCon.Text = "" Then
            MensajeNotificacion("El campo de valor no puede estar vacío.", "Aviso.")
        Else
            Dim resultado As DialogResult = MessageBox.Show("¿Desea continuar con el cambio de valor en la cotización?", "Cambiar valor de " & NombreMoneda & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                ReemplazarComaPorPunto(txtCon.Text)
                If txtCon.Text.StartsWith(".") OrElse txtCon.Text.StartsWith(",") Then
                    MensajeNotificacion("Ingresa un número antes del decimal.", "Aviso.")
                    Return
                End If
                If UsuariosSP.ModCotizacion(IDMoneda, textosincoma) Then
                    MensajeNotificacion("Valor de la moneda modificado correctamente.", "Éxito.")
                    frmMenu.GetCotizaciones()
                    Inicio()
                Else
                    MensajeNotificacion("Hubo un error al modificar el valor la moneda.", "Error.")
                End If
            End If
        End If
    End Sub

    Private Sub btnCamCon_Click(sender As Object, e As EventArgs) Handles btnCamCon.Click
        Modificar()
    End Sub

    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        FiltrarNoIntMonto(sender, e)
    End Sub

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Modificar()
        Else
            SoloIntMonto(sender, e)
        End If
    End Sub

#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrm(pnlMnuTool, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrm(PictureBox2, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrm(tsslNomUsu, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub frmContraseña_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub pnlCreUsu_MouseEnter(sender As Object, e As EventArgs) Handles pnlCreUsu.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub pnlMnuTool_MouseEnter(sender As Object, e As EventArgs) Handles pnlMnuTool.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub btnMini_MouseEnter(sender As Object, e As EventArgs) Handles btnMini.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnExit.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnMini.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub cmbCot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCot.KeyPress

    End Sub

    Private Sub cmbCot_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbCot.MouseClick
        iniciocon = False
    End Sub

    'Private Sub pnlMnuTool_Paint(sender As Object, e As PaintEventArgs) Handles pnlMnuTool.Paint
    '    ' Definir los colores de inicio y fin del degradado
    '    Dim colorInicio As Color = Color.FromArgb(200, 30, 63, 111)  ' Color inicial a la izquierda
    '    Dim colorFin As Color = Color.FromArgb(200, 60, 117, 202)   ' Color final a la derecha

    '    ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
    '    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
    '    e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    '    e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '    e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

    '    ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
    '    Using brush As New Drawing2D.LinearGradientBrush(
    '    New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
    '    New Point(pnlMnuTool.Width, 0),       ' Punto final (lado derecho)
    '    colorInicio, colorFin)

    '        ' Rellenar el área del panel con el degradado
    '        e.Graphics.FillRectangle(brush, pnlMnuTool.ClientRectangle)
    '    End Using
    'End Sub


    'Private Sub pnlMnuTool_Resize(sender As Object, e As EventArgs) Handles pnlMnuTool.Resize
    '    pnlMnuTool.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    'End Sub
#End Region
End Class