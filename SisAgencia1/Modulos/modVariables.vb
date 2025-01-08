Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports Datos
Imports Entidades
Module modVariables
    Public NomEmp As String
    Public CodEmpCreUsu As String
    Public NomEmpCreUsu As String
    Public ApeEmpCreUsu As String
    Public NomCli As String
    Public ApeCli As String
    Public ApeEmp As String
    Public NomUsu As String
    Public CodUsu As Integer
    Public PasUsu As String
    Public titulo As String = "Conquista tu Mundo"
    Public banbl As Boolean
    Public UsuExiste As Boolean = False
    Public dnibus As Integer


    Public Sub MensajeError(mensaje As String)
        frmPrincipal.niPpal.Text = "Conquista tu Mundo"
        frmPrincipal.niPpal.BalloonTipTitle = "Conquista tu Mundo"
        frmPrincipal.niPpal.BalloonTipText = mensaje
        frmPrincipal.Text = titulo
        frmPrincipal.niPpal.ShowBalloonTip(1000)

    End Sub

    Public Sub ClearLabel(labell As Label)
        labell.Text = ""
    End Sub



    Public UltimosFormularios As New List(Of String)

    ' Método para actualizar la lista de últimos formularios visitados
    Public Sub ActualizarUltimosFormularios(nombreFormulario As String)
        If UltimosFormularios.Contains(nombreFormulario) Then
            UltimosFormularios.Remove(nombreFormulario)
        End If

        UltimosFormularios.Insert(0, nombreFormulario)

        ' Mantener solo los últimos 4 formularios visitados
        If UltimosFormularios.Count > 4 Then
            UltimosFormularios.RemoveAt(UltimosFormularios.Count - 1)
        End If

        ' Actualizar los botones en el panel

    End Sub

    Public Sub AbrirFormPanel(f As Form, p As Panel)
        'Limpio los controles existentes en el panel
        'p.Controls.Clear()
        'Establezco la propiedad toplevel del formualrio en falso para poder agregar un formulario dentro de otro
        f.TopLevel = False
        'Quito los bordes del formulario a abrir dentro del panel
        f.FormBorderStyle = FormBorderStyle.None
        'Agrego el control al panel
        p.Controls.Add(f)
        'Muestro el formulario en pantalla
        f.Show()
        f.Dock = DockStyle.Fill
        f.BringToFront()
    End Sub

    Public Sub FormularioAbierto(Of T As {Form})(ByVal form As T, b As Button)
        ' Dim exclamacion As String
        'exclamacion = b.Text
        If Application.OpenForms().OfType(Of T)().Any(Function(f) f.Name = form.Name) Then
            ' Console.WriteLine("El formulario " & form.Name & " está abierto.")


            b.BackColor = Color.Firebrick
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(134, 26, 26)
            b.FlatAppearance.MouseDownBackColor = Color.Firebrick
            'b.Text = exclamacion

        Else
            'Console.WriteLine("El formulario " & form.Name & " no está abierto.")
            b.BackColor = Color.SteelBlue
            b.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 113, 155)
            b.FlatAppearance.MouseDownBackColor = Color.SteelBlue

        End If
    End Sub



    Public Sub CerrarFormularioSuperiorEnPanel(panel As Panel)
        ' Verificar si hay algún formulario abierto en el panel
        Dim formToClose As Form = Nothing
        For Each control As Control In panel.Controls
            If TypeOf control Is Form AndAlso control.Visible Then
                formToClose = DirectCast(control, Form)
                Exit For
            End If
        Next

        ' Cerrar el formulario encontrado
        If formToClose IsNot Nothing Then
            formToClose.Close()
        End If
    End Sub

    Public Sub CerrarFormularioSuperiorEnPanelConConfirmacion(panel As Panel)
        ' Verificar si hay algún formulario abierto en el panel
        Dim formToClose As Form = Nothing
        For Each control As Control In panel.Controls
            If TypeOf control Is Form AndAlso control.Visible Then
                formToClose = DirectCast(control, Form)
                Exit For
            End If
        Next

        ' Verificar si se encontró un formulario para cerrar
        If formToClose IsNot Nothing Then
            ' Preguntar al usuario si está seguro de cerrar el formulario
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario " & formToClose.Text & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                formToClose.Close()

            End If
        End If
    End Sub

    Public Sub CambiarFormularioSuperiorEnPanelConConfirmacion(panel As Panel)
        ' Verificar si hay algún formulario abierto en el panel
        Dim formToClose As Form = Nothing
        For Each control As Control In panel.Controls
            If TypeOf control Is Form AndAlso control.Visible Then
                formToClose = DirectCast(control, Form)
                Exit For
            End If
        Next

        ' Verificar si se encontró un formulario para cerrar
        If formToClose IsNot Nothing Then
            ' Preguntar al usuario si está seguro de cerrar el formulario
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario " & formToClose.Text & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                formToClose.Close()

            End If
        End If
    End Sub



    Public Sub CentrarForm(form As Form)
        Dim xPos As Integer = (Screen.PrimaryScreen.Bounds.Width - form.Width) \ 2
        Dim yPos As Integer = (Screen.PrimaryScreen.Bounds.Height - form.Height) \ 2
        form.Location = New Point(xPos, yPos)
    End Sub


    Public Sub CerrarFormularios(formularios As Form())
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub

    Public Sub CloseAllFormsExceptOne(exceptForm As Form)
        Dim formsToClose As New List(Of Form)

        ' Itera sobre todos los formularios abiertos en la aplicación.
        For Each frm As Form In Application.OpenForms
            ' Verifica si el formulario actual no es el formulario que no deseas cerrar.
            If frm IsNot exceptForm Then
                ' Agrega el formulario a la lista de formularios que se cerrarán.
                formsToClose.Add(frm)
            End If
        Next

        ' Cierra los formularios almacenados en la lista.
        For Each frmToClose As Form In formsToClose
            frmToClose.Close()
        Next
    End Sub


    Public Sub ClearText(text As TextBox)
        text.Text = ""

    End Sub

    Public Sub SoloInt(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub SoloInt1(e As KeyPressEventArgs, err As ErrorProvider, texto As TextBox)

        err.Clear()

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'MensajeError("Solo se puede escribir números.")
            err.SetError(texto, "Solo se puede escribir números.")
        End If


    End Sub

    Public Sub FiltrarNoInt(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text

            ' Elimina cualquier carácter no numérico del texto
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsDigit(c) Then
                    nuevoTexto &= c
                End If
            Next

            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub


    Public Sub SoloIntTel(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito, +, -, espacio ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "+"c AndAlso Not e.KeyChar = "-"c AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito, +, -, espacio ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub FiltrarNoIntTel(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text

            ' Elimina cualquier carácter que no sea un dígito, +, -, o espacio
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsDigit(c) OrElse c = "+"c OrElse c = "-"c Then
                    nuevoTexto &= c
                End If
            Next

            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub CampoBlanco(group As GroupBox, err As ErrorProvider)
        For Each texto In group.Controls

            If TypeOf texto Is TextBox Then
                If texto.text = "" And texto.name.ToString <> "txtMail" And texto.name.ToString <> "txtTel" Then
                    err.SetError(texto, $"El campo '{texto.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If


        Next

        banbl = True

    End Sub
    Public Sub CampoBlancoCliente(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" AndAlso textBox.Name <> "txtTel" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next

        banbl = True
    End Sub

    Public Sub CampoBlanco2(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next

        banbl = True
    End Sub

    Public Sub TamañoVer(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)

                If Not ContieneNumero(textBox.Text) AndAlso textBox.Name = "txtCon" Then
                    err.SetError(textBox, $"La contraseña debe contener al menos un carácter numérico.")
                    banbl = False
                    Return

                ElseIf Not ContieneNumero(textBox.Text) AndAlso textBox.Name = "txtUsr" Then
                    err.SetError(textBox, $"El usuario debe contener al menos un carácter numérico.")
                    banbl = False
                    Return
                End If


            End If

        Next

        banbl = True
    End Sub

    Public Function ContieneLetra(texto As String) As Boolean
        For Each caracter As Char In texto
            If Char.IsLetter(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ContieneNumero(texto As String) As Boolean
        For Each caracter As Char In texto
            If Char.IsDigit(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub CampoBlancoRestaurar(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" AndAlso textBox.Name <> "txtTel" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next

        banbl = True
    End Sub
End Module
