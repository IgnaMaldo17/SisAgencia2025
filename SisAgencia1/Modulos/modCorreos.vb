Imports System.Net
Imports System.Net.Mail
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Configuration

Module modCorreos

    Sub EnviarCorreoAutomatizado(nombreCliente As String, correoCliente As String, servicio As String, fechaServicio As String)
        Try
            ' Crear el mensaje de correo
            Dim correo As New MailMessage()
            correo.From = New MailAddress("marylashing@gmail.com")
            correo.To.Add(correoCliente)
            correo.Subject = "¡Gracias por su compra!"

            ' Cuerpo del correo con fecha y hora del servicio
            Dim cuerpoCorreo As String = $"¡Hola {nombreCliente}!" & vbCrLf & vbCrLf &
                                     "Muchas gracias por confiar en Conquista tu Mundo para ayudarte a experimentar Puerto Iguazú al máximo." & vbCrLf & vbCrLf &
                                     $"Has adquirido nuestro/s servicio/s: {servicio}, programado para el/los día/s {fechaServicio}." & vbCrLf & vbCrLf &
                                     "Te enviaremos un correo recordatorio cuando se acerque la fecha de tu servicio." & vbCrLf & vbCrLf &
                                     "Si tienes alguna duda, no dudes en contactarnos." & vbCrLf & vbCrLf &
                                     "¡Gracias de nuevo por elegirnos!" & vbCrLf & vbCrLf &
                                     "Saludos cordiales," & vbCrLf &
                                     "Agencia Conquista tu Mundo"

            correo.Body = cuerpoCorreo
            correo.IsBodyHtml = False ' Desactivar HTML

            ' Configuración del servidor SMTP
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587 ' Puerto para Gmail
            smtp.Credentials = New NetworkCredential("marylashing@gmail.com", "hicm bsqb wsfq fjib")
            smtp.EnableSsl = True ' Gmail requiere SSL

            ' Enviar el correo
            smtp.Send(correo)

        Catch ex As Exception
            ' Manejo de errores
        End Try
    End Sub

    Sub EnviarCorreoAutomatizadoCerca(nombreCliente As String, correoCliente As String, servicio As String, fechaServicio As String)
        Try
            ' Crear el mensaje de correo
            Dim correo As New MailMessage()
            correo.From = New MailAddress("marylashing@gmail.com")
            correo.To.Add(correoCliente)
            correo.Subject = "¡Mañana es la fecha de su servicio!"

            ' Cuerpo del correo con fecha y hora del servicio
            Dim cuerpoCorreo As String = $"¡Hola {nombreCliente}!" & vbCrLf & vbCrLf &
                                     $"Nos comunicamos con usted para recordarle que mañana tiene su servicio: {servicio}." & vbCrLf & vbCrLf &
                                     "No olvide la fecha pues no se harán devoluciones si pierde el servicio y/o voucher." & vbCrLf & vbCrLf &
                                     "Si tienes alguna duda, no dudes en contactarnos." & vbCrLf & vbCrLf &
                                     "¡Gracias de nuevo por elegirnos!" & vbCrLf & vbCrLf &
                                     "Saludos cordiales," & vbCrLf &
                                     "Agencia Conquista tu Mundo"
            correo.Body = cuerpoCorreo
            correo.IsBodyHtml = False ' Desactivar HTML
            ' Configuración del servidor SMTP
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587 ' Puerto para Gmail
            smtp.Credentials = New NetworkCredential("marylashing@gmail.com", "hicm bsqb wsfq fjib")
            smtp.EnableSsl = True ' Gmail requiere SSL
            ' Enviar el correo
            smtp.Send(correo)
        Catch ex As Exception
        End Try
    End Sub

    Sub EnviarCorreosAutomatizados()

        ' Verificar si es un nuevo día y limpiar registros si es necesario
        VerificarYLimpiarCorreosDiarios()

        Dim connString As String = ConfigurationManager.ConnectionStrings("SisAgencia").ConnectionString
        Dim query As String = "EXEC [dbo].[MosDetVentCDHoy]"

        Using conn As New SqlConnection(connString)
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()

                    Dim codVentaActual As String = ""
                    Dim servicios As New List(Of String)
                    Dim nombreCliente As String = ""
                    Dim correoCliente As String = ""

                    While reader.Read()
                        Dim codVenta As String = reader("Número Venta").ToString()
                        Dim servicio As String = reader("Servicio").ToString()
                        Dim fechaServicio As String = reader("Fecha").ToString()
                        Dim nombre As String = reader("Nombre").ToString() & " " & reader("Apellido").ToString()
                        Dim correo As String = reader("Correo").ToString()

                        ' Verificar si ya se envió el correo hoy
                        If CorreoYaEnviadoHoy(correo) Then
                            Continue While ' Saltar este cliente si ya se envió el correo hoy
                        End If

                        If codVentaActual <> codVenta Then
                            If codVentaActual <> "" Then
                                EnviarCorreoAutomatizadoCerca(nombreCliente, correoCliente, String.Join(", ", servicios), "")
                                RegistrarEnvioCorreoDiario(correoCliente)
                            End If

                            codVentaActual = codVenta
                            nombreCliente = nombre
                            correoCliente = correo
                            servicios.Clear()
                        End If

                        servicios.Add(servicio & " el " & fechaServicio)
                    End While

                    If codVentaActual <> "" Then
                        EnviarCorreoAutomatizadoCerca(nombreCliente, correoCliente, String.Join(", ", servicios), "")
                        RegistrarEnvioCorreoDiario(correoCliente)
                    End If
                End Using
            End Using
        End Using
    End Sub


    Sub RegistrarEnvioEnAppConfig(correo As String, codVenta As String)
        ' Cargar el archivo de configuración
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Componer una clave única por correo y CodVenta
        Dim key As String = correo & "-" & codVenta

        ' Si la clave no existe, agregarla
        If config.AppSettings.Settings(key) Is Nothing Then
            config.AppSettings.Settings.Add(key, DateTime.Now.ToString())
        Else
            ' Si ya existe, puedes actualizarla si lo deseas
            config.AppSettings.Settings(key).Value = DateTime.Now.ToString()
        End If

        ' Guardar los cambios en el archivo de configuración
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    Public Function CorreoYaEnviadoEnAppConfig(correo As String, codVenta As String) As Boolean
        Dim key As String = correo & "-" & codVenta
        Return ConfigurationManager.AppSettings(key) IsNot Nothing
    End Function

    Sub VerificarYLimpiarCorreosDiarios()
        Dim fechaUltimoEnvio As String = ConfigurationManager.AppSettings("FechaUltimoEnvio")
        Dim fechaActual As String = DateTime.Now.ToString("yyyy-MM-dd")

        If fechaUltimoEnvio <> fechaActual Then
            ' Es un nuevo día, limpiar los registros de correos enviados
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config.AppSettings.Settings("FechaUltimoEnvio").Value = fechaActual
            config.AppSettings.Settings("CorreosEnviadosHoy").Value = ""
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
        End If
    End Sub

    Sub RegistrarEnvioCorreoDiario(correo As String)
        ' Cargar la configuración actual
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim correosEnviadosHoy As String = ConfigurationManager.AppSettings("CorreosEnviadosHoy")

        ' Agregar el correo si no está en la lista
        If Not correosEnviadosHoy.Contains(correo) Then
            correosEnviadosHoy &= correo & ";"
            config.AppSettings.Settings("CorreosEnviadosHoy").Value = correosEnviadosHoy
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
        End If
    End Sub

    Function CorreoYaEnviadoHoy(correo As String) As Boolean
        Dim correosEnviadosHoy As String = ConfigurationManager.AppSettings("CorreosEnviadosHoy")
        Return correosEnviadosHoy.Contains(correo)
    End Function

End Module