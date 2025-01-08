#Region "Imports"
Imports System.Runtime.InteropServices
Imports Datos
#End Region

Public Class frmAdmin

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

#Region "Subrutinas"
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

    Private Sub Limpiar()
        txtCon.Clear()
        txtUsu.Clear()
    End Sub

    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub IgrUsu()
        ep.Clear()
        If txtUsu.Text = "" Then
            ep.SetError(txtUsu, "Debe ingresar un usuario.")
            Return
        ElseIf txtCon.Text = "" Then
            ep.SetError(txtCon, "Debe ingresar una contraseña.")
            Return
        End If
        Login()
    End Sub

    Private Sub Login()
        Dim Usuario As New clsUsu
        Dim tabla As New DataTable
        tabla = Usuario.GetLogin(txtUsu.Text, txtCon.Text)
        If tabla.Rows.Count > 0 Then
            If tabla(0)(5) = 1 Then
                PermisoADMIN = True
                MensajeNotificacion("Permiso de administrador concedido.", "Permiso concedido.")
                Me.Hide()
                ClearText(txtUsu)
                ClearText(txtCon)
            Else
                MensajeNotificacion("El usuario ingresado no es un administrador.", "Permiso rechazado.")
            End If
        Else
            MensajeNotificacion("Credenciales incorrectas.", "Error.")
        End If
    End Sub

    Private Sub DesMotivo()
        Dim frmDesMotivo As New frmDesMotivo()
        frmDesMotivo.ShowDialog()
        frmDesMotivo.TopMost = True
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
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        Limpiar()
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnExit, 10)
        frmMenu.RoundButton(btnAgrUsu, 10)
        frmMenu.RoundButton(ckbMosCon, 10)
    End Sub

    Private Sub btnAgrUsu_Click(sender As Object, e As EventArgs) Handles btnAgrUsu.Click
        IgrUsu()
    End Sub

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            IgrUsu()
        End If
    End Sub

    Private Sub txtUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsu.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            txtCon.Focus()
        End If
    End Sub

    Private Sub ckbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMosCon.CheckedChanged
        If ckbMosCon.Checked = True Then
            txtCon.PasswordChar = ""
            ckbMosCon.Image = My.Resources.icons8_visible_nuevo_24
        Else
            txtCon.PasswordChar = "*"
            ckbMosCon.Image = My.Resources.icons8_invisible_nuevo_24
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
    End Sub

    Private Sub frmAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing 'se puede acortar
        If PermisoADMIN = True Then
            Select Case VarADMIN
                Case 1
                    DesMotivo()
                    Return
                Case 2
                    DesMotivo()
                    Return
                Case 3
                    DesMotivo()
                    Return
                Case 4
                    DesMotivo()
                    Return
                Case 5
                    DesMotivo()
                    Return
                Case 6
                    DesMotivo()
                    Return
                Case 7
                    DesMotivo()
                    Return
                Case 8
                    frmClientes.EliResCli()
                Case 9
                    DesMotivo()
                    Return
                Case 10
                    DesMotivo()
                    Return
                Case 11
                    frmChof.ModChof()
                Case 12
                    frmOp.ModOp()
                Case 13
                    frmVeh.ModVeh()
                Case 14
                    DesMotivo()
                    Return
                Case 15
                    frmChof.Restaurar2()
                Case 16
                    DesMotivo()
                    Return
                Case 17
                    frmDetVentas.Restaurar2()
                Case 18
                    DesMotivo()
                    Return
                Case 19
                    frmOp.Restaurar2()
                Case 20
                    DesMotivo()
                    Return
                Case 21
                    frmVentas.Restaurar2()
                Case 22
                    DesMotivo()
                    Return
                Case 23
                    frmVeh.Restaurar2()
                Case 24
                    DesMotivo()
                    Return
                Case 25
                    frmProv.Restaurar2()
                Case 26
                    DesMotivo()
                    Return
                Case 27
                    frmServ.Restaurar2()
                Case 28
                    DesMotivo()
                    Return
                Case 29
                    frmEmpleados.Restaurar2()
                Case 30
                    DesMotivo()
                    Return
                Case 31
                    frmUsuarios.Restaurar2()
                Case 32
                    DesMotivo()
                    Return
                Case 33
                    frmClientes.Restaurar2()
                Case 50
                    Dim frmContraseña As New frmConfig()
                    frmContraseña.ShowDialog()
                    frmContraseña.TopMost = True
                Case 51
                    Dim frmContraseña As New frmAgrTpServ()
                    frmContraseña.ShowDialog()
                    frmContraseña.TopMost = True
                Case Else
                    MensajeNotificacion("No se otorgó el permiso de administrador.", "Permiso rechazado.") 'ERROR
            End Select
            VarADMIN = 0
        End If
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrm(PictureBox2, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrm(PictureBox2, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrm(PictureBox2, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub frmAdmin_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
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

    Private Sub btnMini_MouseEnter(sender As Object, e As EventArgs) Handles btnMini.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnExit.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnMini.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
    End Sub
#End Region

#End Region

End Class