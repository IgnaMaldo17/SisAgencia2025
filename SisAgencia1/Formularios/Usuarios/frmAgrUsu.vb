#Region "Imports"
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Datos
Imports Entidades
#End Region

Public Class frmAgrUsu

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
    Dim ClientesSP As New clsCli
    Dim UsuariosDatos As New eUsu
    Dim frmlog As New frmLogin
#End Region

#Region "Subrutinas"
    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                If pnlMnuTool.BackColor = Color.FromArgb(30, 63, 111) Then
                    ColorParpadeo(pnlMnuTool, PictureBox2, btnMini, btnExit)
                Else
                    ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
                End If
            End If
        End If
    End Sub

    Public Event RestoreShadow()

    Private Sub Inicio()
        Label1.Image = My.Resources.icons8_empleado_nuevo_25
        Label1.Font = New Font("Microsoft Sans Serif", 12)
        Label1.Text = "       " & ApeEmpCreUsu & " " & NomEmpCreUsu
        ckbMostrar.Checked = False
        ckbMostrar.Image = My.Resources.icons8_invisible_nuevo_24
        btnAgrUsu.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0)
        btnAgrUsu.FlatAppearance.MouseDownBackColor = Color.ForestGreen
        btnAgrUsu.FlatAppearance.MouseOverBackColor = Color.DarkGreen
    End Sub

    Private Sub VerificarNombreSize()
        If Label1.Text IsNot Nothing Then
            If Label1.Text.Length <= 33 Then
            Else
                If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                    Label1.Font = New Font("Microsoft Sans Serif", 10)
                    Label1.Image = My.Resources.icons8_empleado_nuevo_20
                ElseIf Label1.Text.Length > 39 Then
                    Label1.Image = My.Resources.icons8_empleadoazul_25
                    Label1.Font = New Font("Microsoft Sans Serif", 12)
                    Label1.Text = "       " & ApeEmpCreUsu
                    If Label1.Text.Length <= 33 Then
                    Else
                        If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                            Label1.Font = New Font("Microsoft Sans Serif", 10)
                            Label1.Image = My.Resources.icons8_empleado_nuevo_20
                        ElseIf Label1.Text.Length > 39 Then
                            Label1.Font = New Font("Microsoft Sans Serif", 12)
                            Label1.Image = My.Resources.icons8_barato_2_60
                            Label1.Text = ApeEmpCreUsu
                            If Label1.Text.Length <= 33 Then
                                Label1.Font = New Font("Microsoft Sans Serif", 11)
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
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CargaCmbTpUsuario()
        cmbTpUsu.DataSource = UsuariosSP.GetTpUsuarios()
        cmbTpUsu.ValueMember = "ID"
        cmbTpUsu.DisplayMember = "NOMBRE"
    End Sub

    Private Sub Login()
        ep.Clear()
        Dim tabla As New DataTable
        Dim Usuario As New clsUsu
        tabla = Usuario.VerificarUsuario(txtUsr.Text)
        Dim tabla2 As New DataTable
        tabla2 = Usuario.VerificarComboTpUsu(cmbTpUsu.SelectedValue)
        ' Crear un diccionario para almacenar los errores
        Dim errores As New Dictionary(Of Control, String)()
        ' Verificar campos vacíos y longitud mínima del usuario
        If tabla2(0)(0) = 0 Then
            errores(cmbTpUsu) = "El tipo de usuario es incorrecto."
        End If
        If txtUsr.Text = "" Then
            errores(txtUsr) = "Debe ingresar un usuario."
        ElseIf txtUsr.Text.Length < 8 Then
            errores(txtUsr) = "El usuario debe tener 8 caracteres o más."
        ElseIf Not ContieneLetra(txtUsr.Text) Then
            errores(txtUsr) = "El usuario debe contener al menos una letra."
        ElseIf Not ContieneNumero(txtUsr.Text) Then
            errores(txtUsr) = "El usuario debe contener al menos un número."
        ElseIf tabla(0)(0) = 2 Then
            errores(txtUsr) = "El usuario ya existe."
        End If
        ' Verificar campos vacíos y longitud mínima de la contraseña
        If txtCon.Text = "" Then
            errores(txtCon) = "Debe ingresar una contraseña."
        ElseIf txtCon.Text.Length < 8 Then
            errores(txtCon) = "La contraseña debe tener 8 caracteres o más."
        ElseIf Not ContieneLetra(txtCon.Text) Then
            errores(txtCon) = "La contraseña debe contener al menos una letra."
        ElseIf Not ContieneNumero(txtCon.Text) Then
            errores(txtCon) = "La contraseña debe contener al menos un número."
        End If
        ' Verificar si las contraseñas coinciden
        If txtCon.Text <> txtReCon.Text Then
            errores(txtCon) = "Las contraseñas no coinciden."
            errores(txtReCon) = "Las contraseñas no coinciden."
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
            UsuariosDatos.CodEmp = CodEmpCreUsu
            UsuariosDatos.NomUsu = txtUsr.Text
            UsuariosDatos.Password = txtCon.Text
            UsuariosDatos.IdAlta = CodUsu
            UsuariosDatos.CodTpUsu = cmbTpUsu.SelectedValue
            If UsuariosSP.InsUsu(UsuariosDatos) Then
                MensajeNotificacion("Usuario creado exitosamente.", "Éxito.")
                Me.Close()
                frmEmpleados.Determinar()
                frmEmpleados.HabilitarNo()
            Else
                MensajeNotificacion("Sucedió un error al intentar crear el usuario.", "Error.")
            End If
            ClearString(UsuariosDatos.NomUsu)
            ClearString(UsuariosDatos.Password)
            ClearString(CodEmpCreUsu)
        Else
        End If
        HayError = False
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
    Private Sub frmAgrUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        Inicio()
        VerificarNombreSize()
        CargaCmbTpUsuario()
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnAgrUsu, 10)
        frmMenu.RoundButton(ckbMostrar, 10)
        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub frmAgrUsu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
            txtReCon.PasswordChar = ""
            ckbMostrar.Image = My.Resources.icons8_visible_nuevo_24
        Else
            txtReCon.PasswordChar = "*"
            txtCon.PasswordChar = "*"
            ckbMostrar.Image = My.Resources.icons8_invisible_nuevo_24
        End If
    End Sub

    Private Sub btnAgrUsu_Click(sender As Object, e As EventArgs) Handles btnAgrUsu.Click
        Login()
    End Sub
#Region "Texto"
    Private Sub txtReCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtReCon, e)
    End Sub

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtCon, e)
    End Sub

    Private Sub txtUsr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Login()
        End If
        KeyPressCon(txtUsr, e)
    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs) Handles txtUsr.TextChanged
        TextChangedCon(txtUsr, txtUsr, e)
    End Sub

    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        TextChangedCon(txtCon, txtCon, e)
    End Sub

    Private Sub txtReCon_TextChanged(sender As Object, e As EventArgs) Handles txtReCon.TextChanged
        TextChangedCon(txtReCon, txtReCon, e)
    End Sub
#End Region

#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrm(pnlMnuTool, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrm(tsslNomUsu, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrm(PictureBox2, e)
    End Sub

    Private Sub frmAgrUsu_MouseEnter(sender As Object, e As MouseEventArgs)
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