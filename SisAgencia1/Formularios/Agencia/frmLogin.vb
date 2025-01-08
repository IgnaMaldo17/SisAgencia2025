#Region "Imports"
Imports Datos
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Text
#End Region

Public Class frmLogin

#Region "Shared Function"
    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function GetClassLong(hWnd As IntPtr, nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Public Shared Function SetClassLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    End Function

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

#Region "Variables"
    Dim VersiCerro As Boolean = False
    Private Shared instancia As frmLogin = Nothing
    Dim VerificarSize As String
#End Region

#Region "Subrutinas"
    Private Sub VerificarNombreSize()
        VerificarSize = "Bienvenido " & ApeEmp & " " & NomEmp & "."
        If VerificarSize IsNot Nothing Then
            If VerificarSize.Length <= 50 Then
            Else
                If VerificarSize.Length > 50 Then
                    VerificarSize = "Bienvenido " & ApeEmp & "."
                Else
                End If
            End If
        End If
        MensajeNotificacion(VerificarSize, "Inicio de Sesión.")
    End Sub

    Private Sub Login()
        Dim Usuario As New clsUsu
        Dim tabla As New DataTable
        tabla = Usuario.GetLogin(txtUsuario.Text, txtContrasena.Text)
        If tabla.Rows.Count > 0 Then
            NomEmp = tabla(0)(0)
            ApeEmp = tabla(0)(1)
            NomUsu = tabla(0)(2)
            CodUsu = tabla(0)(3)
            PasUsu = tabla(0)(4)
            CodTpUsu = tabla(0)(5)
            Me.Hide()
            ClearText(txtUsuario)
            ClearText(txtContrasena)
            frmPrincipal.Show()
            If elprogramadebecerrarse = True Then
                frmPrincipal.Close()
                Return
            End If
            'frmPrincipal.AbrirFormularioRe(frmVisorReportes)
            'CargaMin()
            frmPrincipal.AbrirFormulario(frmMenu)
            VerificarNombreSize()
        Else
            MensajeNotificacion("Credenciales incorrectas.", "Error.")
        End If
    End Sub

    Public Shared Function ObtenerInstancia() As frmLogin
        ' Si no hay una instancia existente, crear una nueva
        If instancia Is Nothing Then
            instancia = New frmLogin()
        End If
        Return instancia
    End Function

    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub
#End Region

#Region "Eventos"
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        EstablecerEsquinasRedondeadas()
    End Sub

    Private Sub EstablecerEsquinasRedondeadas()
        Dim radius As Integer = 31 ' Cambia el radio según sea necesario
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()

        ' Agregar esquinas redondeadas
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90) ' Esquina superior izquierda
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90) ' Esquina superior derecha
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90) ' Esquina inferior derecha
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90) ' Esquina inferior izquierda

        path.CloseFigure()

        ' Establecer la región del formulario
        Me.Region = New Region(path)
    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Establecer la instancia en Nothing para permitir la apertura de una nueva instancia si es necesario
        instancia = Nothing
        If VersiCerro = False Then
            Application.Exit()
        ElseIf VersiCerro = True Then
        End If
    End Sub

    Private Sub btnMiniLog_Click(sender As Object, e As EventArgs) Handles btnMiniLog.Click
        MinimizarMini(Me)
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            txtContrasena.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalirLog.Click
        Application.Exit()
        VersiCerro = True
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnviarCorreosAutomatizados()
        CentrarForm(Me)
        txtUsuario.Select()
        frmMenu.RoundButton(btnIngresar, 10)
        frmMenu.RoundButton(btnSalirLog, 31)
        frmMenu.RoundButton(btnMiniLog, 31)
        frmMenu.RoundButton(ckbMosCon, 21)
        btnMiniLog.BackColor = Color.Transparent
        btnSalirLog.BackColor = Color.Transparent
        ckbMosCon.BackColor = Color.Transparent
        lblUsuario.BackColor = Color.Transparent
        lblContraseña.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        SetWindowLong(Handle, -8, CInt(GetDesktopWindow()))

        SetClassLong(Handle, -26, GetClassLong(Handle, -26) Or CS_DROPSHADOW)
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        EstablecerEsquinasRedondeadas()
        Me.Invalidate()
        Me.Update()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        MoverFrm(Panel1, e)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        MoverFrm(PictureBox1, e)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrm(PictureBox2, e)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        epLogin.Clear()
        If txtUsuario.Text = "" Then
            epLogin.SetError(txtUsuario, "Debe ingresar un usuario.")
            Return
        ElseIf txtContrasena.Text = "" Then
            epLogin.SetError(txtContrasena, "Debe ingresar una contraseña.")
            Return
        End If
        Login()

    End Sub

    Private Sub txtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            epLogin.Clear()
            If txtUsuario.Text = "" Then
                epLogin.SetError(txtUsuario, "Debe ingresar un usuario.")
                Return
            ElseIf txtContrasena.Text = "" Then
                epLogin.SetError(txtContrasena, "Debe ingresar una contraseña.")
                Return
            End If
            Login()
        End If
    End Sub

    Private Sub ckbMosCon_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMosCon.CheckedChanged
        If ckbMosCon.Checked = True Then
            txtContrasena.PasswordChar = ""
            ckbMosCon.Image = My.Resources.icons8_visible_nuevo_24
        Else
            txtContrasena.PasswordChar = "*"
            ckbMosCon.Image = My.Resources.icons8_invisible_nuevo_24
        End If
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EstablecerEsquinasRedondeadas()
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    '    ' Define los colores de inicio y fin del degradado
    '    Dim colorInicio As Color = Color.FromArgb(217, 227, 244)  ' Color inicial en la esquina inferior izquierda
    '    Dim colorFin As Color = Color.FromArgb(243, 247, 252)    ' Color final en la esquina superior derecha

    '    ' Ajusta los puntos de inicio y fin para que el degradado sea diagonal y cubra todo el panel
    '    'Using brush As New Drawing2D.LinearGradientBrush(
    '    'New Point(0, Panel1.Height),       ' Esquina inferior izquierda
    '    'New Point(Panel1.Width, 0),        ' Esquina superior derecha
    '    'colorInicio, colorFin)

    '    '    ' Rellena el área del panel con el degradado
    '    '    e.Graphics.FillRectangle(brush, Panel1.ClientRectangle)
    '    'End Using

    '    ' Crea un pincel de degradado lineal que va desde la esquina inferior izquierda hasta la superior derecha
    '    ' Ajusta los puntos para que el color de inicio ocupe menos espacio
    '    Using brush As New Drawing2D.LinearGradientBrush(
    '        New Point(0, Panel1.Height),       ' Punto de inicio (esquina inferior izquierda)
    '        New Point(Panel1.Width / 4, Panel1.Height / 2),  ' Punto final más cercano (mitad del panel)
    '        colorInicio, colorFin)

    '        ' Rellena el área del panel con el degradado
    '        e.Graphics.FillRectangle(brush, Panel1.ClientRectangle)
    '    End Using
    'End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Define los colores de inicio y fin del degradado
        Dim colorInicio As Color = Color.FromArgb(200, 173, 197, 231)  ' Color inicial en la esquina inferior izquierda
        Dim colorFin As Color = Color.FromArgb(200, 253, 254, 255)    ' Color final en la esquina superior derecha

        ' Ajusta los puntos del gradiente para que el color final no se salga del panel
        Using brush As New Drawing2D.LinearGradientBrush(
            New Point(0, Panel1.Height),                   ' Punto de inicio (esquina inferior izquierda)
            New Point(Panel1.Width - 1, 1),                ' Ajusta el punto final para que quede dentro del panel
            colorInicio, colorFin)

            ' Rellena el área del panel con el degradado
            e.Graphics.FillRectangle(brush, Panel1.ClientRectangle)
        End Using
    End Sub

    'Private Sub btnIngresar_Paint(sender As Object, e As PaintEventArgs) Handles btnIngresar.Paint
    '    ' Definir los colores de inicio y fin del degradado
    '    Dim colorInicio As Color = Color.FromArgb(170, 30, 63, 111)  ' Color inicial a la izquierda
    '    Dim colorFin As Color = Color.FromArgb(170, 60, 117, 202)   ' Color final a la derecha

    '    ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
    '    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
    '    e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    '    e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
    '    e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

    '    ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del botón
    '    Using brush As New Drawing2D.LinearGradientBrush(
    '    New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
    '    New Point(btnIngresar.Width, 0),       ' Punto final (lado derecho)
    '    colorInicio, colorFin)

    '        ' Rellenar el área del botón con el degradado
    '        e.Graphics.FillRectangle(brush, btnIngresar.ClientRectangle)
    '    End Using

    '    ' Configura el estilo de fuente y color para el texto
    '    Dim fuente As New Font(btnIngresar.Font.FontFamily, btnIngresar.Font.Size, FontStyle.Bold)
    '    Dim colorTexto As Color = Color.White

    '    ' Desactivar el dibujo automático del texto
    '    btnIngresar.Text = ""

    '    ' Calcular la posición del texto para centrarlo
    '    Dim textSize As Size = TextRenderer.MeasureText("Iniciar Sesión", fuente)
    '    Dim textX As Single = (btnIngresar.Width - textSize.Width) / 2
    '    Dim textY As Single = (btnIngresar.Height - textSize.Height) / 2

    '    ' Dibujar el texto usando TextRenderer
    '    TextRenderer.DrawText(e.Graphics, "Iniciar Sesión", fuente, New Point(textX, textY), colorTexto)
    'End Sub



#End Region

End Class