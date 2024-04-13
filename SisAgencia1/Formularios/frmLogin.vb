Imports Datos
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Runtime.InteropServices
Imports System.Text
Public Class frmLogin
#Region "Botones"

    Dim VerificarSize As String

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Sub frmLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub



    Dim VersiCerro As Boolean = False




    Private Sub ckbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMostrar.CheckedChanged
        If ckbMostrar.Checked = True Then
            txtContrasena.PasswordChar = ""
        Else
            txtContrasena.PasswordChar = "*"
        End If
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
#End Region
#Region "Eventos"
    Private Sub VerificarNombreSize()
        VerificarSize = "Bienvenido " & ApeEmp & " " & NomEmp
        If VerificarSize IsNot Nothing Then
            If VerificarSize.Length <= 50 Then
            Else
                If VerificarSize.Length > 50 Then
                    VerificarSize = "Bienvenido " & ApeEmp



                Else


                End If
            End If
        End If

        MensajeError(VerificarSize)
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

            Me.Hide()
            txtUsuario.Text = ""
            txtContrasena.Text = ""
            frmPrincipal.Show()
            frmPrincipal.Text = titulo
            frmPrincipal.tsslNomUsu.Text = "Conquista tu Mundo - ¡Bienvenido " + NomUsu + "!"
            frmPrincipal.tsslNomUsu.Visible = True

            frmPrincipal.AbrirFormulario(frmMenu)



            VerificarNombreSize()


        Else
            MensajeError("Credenciales incorrectas.")
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalirLog.Click
        Application.Exit()
        VersiCerro = True
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        txtUsuario.Select()
        SetWindowLong(Handle, -8, CInt(GetDesktopWindow()))
        SetClassLong(Handle, -26, GetClassLong(Handle, -26) Or CS_DROPSHADOW)
    End Sub

    ' Declarar una instancia privada compartida para garantizar que solo haya una instancia de frmLogin
    Private Shared instancia As frmLogin = Nothing

    ' Método público estático para obtener la instancia de frmLogin
    Public Shared Function ObtenerInstancia() As frmLogin
        ' Si no hay una instancia existente, crear una nueva
        If instancia Is Nothing Then
            instancia = New frmLogin()
        End If

        Return instancia
    End Function

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Establecer la instancia en Nothing para permitir la apertura de una nueva instancia si es necesario
        instancia = Nothing

        If VersiCerro = False Then
            Application.Exit()
        ElseIf VersiCerro = True Then

        End If


    End Sub

    Private Sub btnMiniLog_Click(sender As Object, e As EventArgs) Handles btnMiniLog.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            txtContrasena.Focus()
        End If
    End Sub








    'para hashear la contraseña
    ''   Imports System.Security.Cryptography

    '  Private Function HashPassword(password As String) As String
    '      Using sha256 As SHA256 = sha256.Create()
    '          Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
    '          Dim builder As New StringBuilder()
    '          For Each b As Byte In hashedBytes
    '              builder.Append(b.ToString("x2"))
    '          Next
    '          Return builder.ToString()
    '      End Using
    '  End Function

    Public Const CS_DROPSHADOW As Integer = &H20000

    ' Importar funciones nativas de Windows
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

    Public Sub New()
        InitializeComponent()
    End Sub


    '  Private Sub Login()
    '      Dim Usuario As New clsUsu
    '      Dim tabla As New DataTable
    '      tabla = Usuario.GetLogin(txtUsuario.Text, HashPassword(txtContrasena.Text))

    '      If tabla.Rows.Count > 0 Then
    '          ' Resto del código como está...
    '      Else
    '          MensajeError("Credenciales incorrectas.")
    '      End If
    '  End Sub



#End Region
End Class