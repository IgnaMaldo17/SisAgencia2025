Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Datos
Imports Entidades

Public Class frmAgrUsu

#Region "Variables"
    Dim HayError As Boolean = False
    Dim UsuariosSP As New clsUsu
    Dim ClientesSP As New clsCli
    Dim UsuariosDatos As New eUsu
    Dim frmlog As New frmLogin
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Const WM_MOUSEACTIVATE As Integer = &H21
    Private Const WM_NCACTIVATE As Integer = &H86


#End Region
#Region "Funciones"

    Public Event RestoreShadow()

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.SteelBlue Then
                    pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
                    btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
                    btnMini.BackColor = Color.FromArgb(60, 113, 155)
                    btnExit.BackColor = Color.FromArgb(60, 113, 155)
                Else
                    pnlMnuTool.BackColor = Color.SteelBlue
                    btnMnuDesp.BackColor = Color.SteelBlue
                    btnMini.BackColor = Color.SteelBlue
                    btnExit.BackColor = Color.SteelBlue
                End If

                ' Restaurar la sombra

            End If
        End If
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function
    Private Sub Inicio()
        Label1.Image = My.Resources.icons8_empleadoazul_25
        Label1.Font = New Font("Microsoft Sans Serif", 12)
        Label1.Text = "       " & ApeEmpCreUsu & " " & NomEmpCreUsu
        ckbMostrar.Checked = False
        ckbMostrar.Image = My.Resources.icons8_invisible_24
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
                    Label1.Image = My.Resources.icons8_empleado_20


                ElseIf Label1.Text.Length > 39 Then



                    Label1.Image = My.Resources.icons8_empleadoazul_25
                    Label1.Font = New Font("Microsoft Sans Serif", 12)
                    Label1.Text = "       " & ApeEmpCreUsu

                    If Label1.Text.Length <= 33 Then
                    Else
                        If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                            Label1.Font = New Font("Microsoft Sans Serif", 10)
                            Label1.Image = My.Resources.icons8_empleado_20
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
                                    Label1.Image = My.Resources.icons8_empleadoazul_25
                                End If
                            End If

                        End If
                    End If

                End If

            End If
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmAgrUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        Inicio()
        VerificarNombreSize()


    End Sub

    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMnuDesp.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub frmAgrUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ckbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMostrar.CheckedChanged
        If ckbMostrar.Checked = True Then
            txtCon.PasswordChar = ""
            txtReCon.PasswordChar = ""
            ckbMostrar.Image = My.Resources.icons8_visible_24

        Else
            txtReCon.PasswordChar = "*"
            txtCon.PasswordChar = "*"
            ckbMostrar.Image = My.Resources.icons8_invisible_24
        End If
    End Sub




    Private Sub Login()
        ep.Clear()
        Dim tabla As New DataTable
        Dim Usuario As New clsUsu
        tabla = Usuario.VerificarUsuario(txtUsr.Text)
        ' Crear un diccionario para almacenar los errores
        Dim errores As New Dictionary(Of Control, String)()

        ' Verificar campos vacíos y longitud mínima del usuario
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

            If UsuariosSP.InsUsu(UsuariosDatos) Then
                MensajeError("Usuario creado exitosamente.")

                Me.Close()
                frmEmp.Determinar()
                frmEmp.HabilitarNo()
            Else
                MensajeError("Sucedio un error al intentar crear el usuario.")
            End If
            UsuariosDatos.NomUsu = ""
            UsuariosDatos.Password = ""
            CodEmpCreUsu = ""
        Else
            Return
        End If
        HayError = False


    End Sub



    Private Sub btnAgrUsu_Click(sender As Object, e As EventArgs) Handles btnAgrUsu.Click
        Login()



    End Sub

    Private Sub txtReCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then



            Login()
        End If
        ' Verifica si el carácter presionado es un carácter prohibido
        If Char.IsLetter(e.KeyChar) Then
            ' Verifica si el carácter tiene tilde
            If e.KeyChar = "á" Or e.KeyChar = "é" Or e.KeyChar = "í" Or e.KeyChar = "ó" Or e.KeyChar = "ú" Or
           e.KeyChar = "Á" Or e.KeyChar = "É" Or e.KeyChar = "Í" Or e.KeyChar = "Ó" Or e.KeyChar = "Ú" Then
                ' Si el carácter tiene tilde, lo ignoramos
                e.Handled = True
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' Si es un número, permitimos su ingreso
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Si es una tecla de control (por ejemplo, retroceso), permitimos su ingreso
        Else
            ' Si no es una letra ni un número ni una tecla de control, lo prohibimos
            e.Handled = True
        End If
    End Sub

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then



            Login()
        End If
        ' Verifica si el carácter presionado es un carácter prohibido
        If Char.IsLetter(e.KeyChar) Then
            ' Verifica si el carácter tiene tilde
            If e.KeyChar = "á" Or e.KeyChar = "é" Or e.KeyChar = "í" Or e.KeyChar = "ó" Or e.KeyChar = "ú" Or
           e.KeyChar = "Á" Or e.KeyChar = "É" Or e.KeyChar = "Í" Or e.KeyChar = "Ó" Or e.KeyChar = "Ú" Then
                ' Si el carácter tiene tilde, lo ignoramos
                e.Handled = True
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' Si es un número, permitimos su ingreso
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Si es una tecla de control (por ejemplo, retroceso), permitimos su ingreso
        Else
            ' Si no es una letra ni un número ni una tecla de control, lo prohibimos
            e.Handled = True
        End If
    End Sub







    Private Sub txtUsr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsr.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then



            Login()
        End If

        ' Verifica si el carácter presionado es un carácter prohibido
        If Char.IsLetter(e.KeyChar) Then
            ' Verifica si el carácter tiene tilde
            If e.KeyChar = "á" Or e.KeyChar = "é" Or e.KeyChar = "í" Or e.KeyChar = "ó" Or e.KeyChar = "ú" Or
           e.KeyChar = "Á" Or e.KeyChar = "É" Or e.KeyChar = "Í" Or e.KeyChar = "Ó" Or e.KeyChar = "Ú" Then
                ' Si el carácter tiene tilde, lo ignoramos
                e.Handled = True
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' Si es un número, permitimos su ingreso
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Si es una tecla de control (por ejemplo, retroceso), permitimos su ingreso
        Else
            ' Si no es una letra ni un número ni una tecla de control, lo prohibimos
            e.Handled = True
        End If
    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs) Handles txtUsr.TextChanged
        ' Verifica si el texto del TextBox contiene caracteres no permitidos y los elimina
        Dim textoValido As String = ""
        For Each c As Char In txtUsr.Text
            If Char.IsLetter(c) Then
                ' Verifica si el carácter tiene tilde
                If c = "á" Or c = "é" Or c = "í" Or c = "ó" Or c = "ú" Or
               c = "Á" Or c = "É" Or c = "Í" Or c = "Ó" Or c = "Ú" Then
                    ' Si el carácter tiene tilde, lo ignoramos
                    Continue For
                End If
            End If
            If Char.IsLetterOrDigit(c) Or Char.IsControl(c) Then
                ' Permitir letras, números y teclas de control
                textoValido &= c
            End If
        Next
        ' Establecer el texto validado en el TextBox
        txtUsr.Text = textoValido
        ' Posicionar el cursor al final del texto
        txtUsr.SelectionStart = txtUsr.Text.Length
    End Sub

    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        ' Verifica si el texto del TextBox contiene caracteres no permitidos y los elimina
        Dim textoValido As String = ""
        For Each c As Char In txtCon.Text
            If Char.IsLetter(c) Then
                ' Verifica si el carácter tiene tilde
                If c = "á" Or c = "é" Or c = "í" Or c = "ó" Or c = "ú" Or
               c = "Á" Or c = "É" Or c = "Í" Or c = "Ó" Or c = "Ú" Then
                    ' Si el carácter tiene tilde, lo ignoramos
                    Continue For
                End If
            End If
            If Char.IsLetterOrDigit(c) Or Char.IsControl(c) Then
                ' Permitir letras, números y teclas de control
                textoValido &= c
            End If
        Next
        ' Establecer el texto validado en el TextBox
        txtCon.Text = textoValido
        ' Posicionar el cursor al final del texto
        txtCon.SelectionStart = txtCon.Text.Length
    End Sub

    Private Sub txtReCon_TextChanged(sender As Object, e As EventArgs) Handles txtReCon.TextChanged
        ' Verifica si el texto del TextBox contiene caracteres no permitidos y los elimina
        Dim textoValido As String = ""
        For Each c As Char In txtReCon.Text
            If Char.IsLetter(c) Then
                ' Verifica si el carácter tiene tilde
                If c = "á" Or c = "é" Or c = "í" Or c = "ó" Or c = "ú" Or
               c = "Á" Or c = "É" Or c = "Í" Or c = "Ó" Or c = "Ú" Then
                    ' Si el carácter tiene tilde, lo ignoramos
                    Continue For
                End If
            End If
            If Char.IsLetterOrDigit(c) Or Char.IsControl(c) Then
                ' Permitir letras, números y teclas de control
                textoValido &= c
            End If
        Next
        ' Establecer el texto validado en el TextBox
        txtReCon.Text = textoValido
        ' Posicionar el cursor al final del texto
        txtReCon.SelectionStart = txtReCon.Text.Length
    End Sub


#End Region

End Class