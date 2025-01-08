#Region "Imports"
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
#End Region

Public Class frmContraseña

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

#Region "Declaraciones"
    Dim HayError As Boolean = False
    Dim UsuariosSP As New clsUsu
    Dim UsuariosDatos As New eUsu
#End Region

#Region "Subrutina"
    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Login()
        ep.Clear()
        ' Crear un diccionario para almacenar los errores
        Dim errores As New Dictionary(Of Control, String)()
        ' Verificar si las contraseñas coinciden
        If txtConNew.Text <> txtReConNew.Text Then
            errores(txtConNew) = "Las contraseñas no coinciden."
            errores(txtReConNew) = "Las contraseñas no coinciden."
        End If
        ' Verificar campos vacíos y longitud mínima del usuario
        If CodTpUsu = 2 Then
            Dim tabla As New DataTable
            Dim Usuario As New clsUsu
            tabla = Usuario.VerificarContraseña(NomUsuCamCon, txtCon.Text)
            If txtCon.Text = "" Then
                errores(txtCon) = "Debe ingresar su contraseña original."
            ElseIf tabla(0)(0) = 0 Then
                errores(txtCon) = "Esta no es su contraseña original."
            End If
        End If
        ' Verificar campos vacíos y longitud mínima de la contraseña
        If txtConNew.Text = "" Then
            errores(txtConNew) = "Debe ingresar una contraseña."
        ElseIf txtConNew.Text.Length < 8 Then
            errores(txtConNew) = "La contraseña debe tener 8 caracteres o más."
        ElseIf Not ContieneLetra(txtConNew.Text) Then
            errores(txtConNew) = "La contraseña debe contener al menos una letra."
        ElseIf Not ContieneNumero(txtConNew.Text) Then
            errores(txtConNew) = "La contraseña debe contener al menos un número."
        End If
        ' Mostrar todos los errores con ErrorProvider
        For Each kvp In errores
            Dim control As Control = kvp.Key
            Dim mensaje As String = kvp.Value
            ' Si ya se estableció un mensaje de error para este control, no se establece de nuevo.
            If String.IsNullOrEmpty(ep.GetError(control)) Then
                ep.SetError(control, mensaje)
                HayError = True
            End If
        Next
        If HayError = False Then
            'UsuariosDatos.CodEmp = CodEmpCreUsu
            UsuariosDatos.NomUsu = NomUsuCamCon
            UsuariosDatos.Password = txtConNew.Text
            'UsuariosDatos.IdAlta = CodUsu
            If CodTpUsu = 1 Then
                If UsuariosSP.ModConADMIN(UsuariosDatos) Then
                    MensajeNotificacion("Contraseña cambiada exitosamente.", "Éxito.")
                    Me.Close()
                    frmUsuarios.Determinar()
                    frmUsuarios.HabilitarNo()
                Else
                    MensajeNotificacion("Sucedió un error al intentar cambiar la contraseña.", "Error.")
                End If
            Else
                If UsuariosSP.ModCon(UsuariosDatos, txtCon.Text) Then
                    MensajeNotificacion("Contraseña cambiada exitosamente.", "Éxito.")
                    Me.Close()
                    frmUsuarios.Determinar()
                    frmUsuarios.HabilitarNo()
                Else
                    MensajeNotificacion("Sucedió un error al intentar cambiar la contraseña.", "Error.")
                End If
            End If
            ClearString(UsuariosDatos.NomUsu)
            ClearString(UsuariosDatos.Password)
            ClearString(NomUsuCamCon)
        Else
        End If
        HayError = False
    End Sub

    Private Sub InicioADMIN()
        ControlFalse(txtCon)
        MinimizarPanel(txtCon)
        MinimizarPanel(Label3)
        txtConNew.Focus()
    End Sub

    Private Sub InicioEmpleado()
        ControlTrue(txtCon)
        VerPanel(txtCon)
        VerPanel(Label3)
        txtCon.Focus()
    End Sub

    Private Sub Limpiar()
        txtCon.Clear()
        txtConNew.Clear()
        txtReConNew.Clear()
    End Sub

    Private Sub VerificarNombreSize()
        If Label1.Text IsNot Nothing Then
            If Label1.Text.Length <= 33 Then
            Else
                If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                    Label1.Font = New Font("Microsoft Sans Serif", 9)
                    Label1.Image = My.Resources.icons8_barato_2_60
                ElseIf Label1.Text.Length > 39 AndAlso Label1.Text.Length <= 47 Then
                    Label1.Font = New Font("Microsoft Sans Serif", 8)
                    Label1.Image = My.Resources.icons8_barato_2_60
                Else
                    Label1.Text = "      Ingrese los datos:"
                    Label1.Image = My.Resources.icons8_empleado_nuevo_25
                End If
            End If
        End If
    End Sub

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
#End Region

#Region "Eventos"
    Private Sub frmContraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        VerificarNombreSize()
        Limpiar()
        If CodTpUsu = 1 Then
            InicioADMIN()
        Else
            InicioEmpleado()
        End If
        Label1.Image = My.Resources.icons8_empleado_nuevo_25
        Label1.Font = New Font("Microsoft Sans Serif", 12)
        Label1.Text = "       " & NomUsuCamCon
        ckbMostrar.Checked = False
        ckbMostrar.Image = My.Resources.icons8_invisible_nuevo_24
        btnCamCon.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0)
        btnCamCon.FlatAppearance.MouseDownBackColor = Color.ForestGreen
        btnCamCon.FlatAppearance.MouseOverBackColor = Color.DarkGreen
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(ckbMostrar, 10)
        frmMenu.RoundButton(btnCamCon, 10)
        frmMenu.RoundButton(btnExit, 10)
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

    Private Sub ckbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMostrar.CheckedChanged
        If ckbMostrar.Checked = True Then
            txtCon.PasswordChar = ""
            txtConNew.PasswordChar = ""
            txtReConNew.PasswordChar = ""
            ckbMostrar.Image = My.Resources.icons8_visible_nuevo_24
        Else
            txtConNew.PasswordChar = "*"
            txtReConNew.PasswordChar = "*"
            txtCon.PasswordChar = "*"
            ckbMostrar.Image = My.Resources.icons8_invisible_nuevo_24
        End If
    End Sub

    Private Sub btnCamCon_Click(sender As Object, e As EventArgs) Handles btnCamCon.Click
        Login()
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

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtCon, e)
    End Sub

    Private Sub txtConNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConNew.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtConNew, e)
    End Sub

    Private Sub txtReConNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReConNew.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtReConNew, e)
    End Sub

    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        TextChangedCon(txtCon, txtCon, e)
    End Sub

    Private Sub txtConNew_TextChanged(sender As Object, e As EventArgs) Handles txtConNew.TextChanged
        TextChangedCon(txtConNew, txtConNew, e)
    End Sub

    Private Sub txtReConNew_TextChanged(sender As Object, e As EventArgs) Handles txtReConNew.TextChanged
        TextChangedCon(txtReConNew, txtReConNew, e)
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
#End Region

#End Region

End Class