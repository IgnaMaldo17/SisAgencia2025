Imports System.Net.Security
Imports System.Reflection
Imports System.Runtime.InteropServices

Imports Datos
Imports Entidades



Public Class frmTelefonos
    Dim TelefonosSP As New clsTel
    Dim clientes As New frmClientes
    Dim BanderaMod As Boolean = False
    Dim BanderaRes As Boolean = False
    Dim CodNum As Integer = 0

    'Private Sub frmClientes_Load(sender As Object, e As EventArgs)
    '    dgvTelefonos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
    '    dgvTelefonos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
    '    Inicio()
    '    gbDatoTel.Text = "Cliente: " + ApeCli + " " + NomCli
    '    CentrarForm(Me)
    '    GetTel()
    '    MaximumSize = Screen.FromControl(Me).WorkingArea.Size
    '    dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '    dgvTelefonos.RowHeadersWidth = 15
    'End Sub


    Private Sub GetTel()
        dgvTelefonos.DataSource = TelefonosSP.MostrarTelefono(dnibus)
    End Sub




    Private Sub dgvTelefonos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellDoubleClick
        If dgvTelefonos.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas



            If e.RowIndex >= 0 AndAlso e.RowIndex < dgvTelefonos.Rows.Count Then
                Dim row = dgvTelefonos.Rows(e.RowIndex)
                If Not row.Cells.Cast(Of DataGridViewCell).Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then


                Else
                    CodNum = row.Cells(0)?.Value?.ToString
                    btnAgrMod.Text = "    Modificar"
                    btnAgrMod.Image = My.Resources.icons8_más_b_24
                    If row.Cells(6)?.Value?.ToString = "Activo" Then
                        btnEliRes.Enabled = True
                        btnEliRes.Text = "    Eliminar"
                        txtAgrTel.Enabled = True
                        BanderaMod = True
                        BanderaRes = False
                        btnAgrMod.Enabled = True
                        btnEliRes.Image = My.Resources.icons8_menos_25
                        txtAgrTel.Text = row.Cells(3)?.Value?.ToString
                    ElseIf row.Cells(6)?.Value?.ToString = "Eliminado" Then
                        btnEliRes.Text = "    Restaurar"
                        BanderaMod = True
                        BanderaRes = True
                        txtAgrTel.Text = row.Cells(3)?.Value?.ToString
                        btnAgrMod.Enabled = False
                        btnEliRes.Enabled = True
                        txtAgrTel.Enabled = False
                        btnEliRes.Image = My.Resources.icons8_cita_recurrente_24
                    End If
                End If


            End If
        End If
    End Sub


    Private Sub txtAgrTel_TextChanged(sender As Object, e As EventArgs) Handles txtAgrTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtAgrTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgrTel.KeyPress
        SoloIntTel(sender, e)
    End Sub


    Private Sub btnAgrMod_Click(sender As Object, e As EventArgs) Handles btnAgrMod.Click

        ep.Clear()
        CampoBlanco(gbDatoTel, ep)

        Dim Usuario As New clsCli
        Dim tabla As New DataTable

        Dim ClienteDatos As New eCli



        'crear bandera de mod o cre
        If banbl = True Then

            ClienteDatos.CodNum = CodNum
            ClienteDatos.CodCli = frmBase.CodCli
            ClienteDatos.Telefono = txtAgrTel.Text
            ClienteDatos.IdAlta = CodUsu


            If frmBase.CodCli = 0 Then
                MensajeError("Ocurrio un error al intentar guardar los cambios (ID 0)")
            Else
                If BanderaMod = False Then
                    If TelefonosSP.InsTel(ClienteDatos) Then
                        MensajeError("Teléfono grabado exitosamente.")
                        frmBase.Determinar()
                        Inicio()
                        GetTel()
                    Else
                        MensajeError("Sucedio un error al intentar grabar el Teléfono.")
                    End If
                Else

                    If TelefonosSP.ModTel(ClienteDatos) Then
                        ClienteDatos.CodCli = frmClientes.CodCli
                        MensajeError("Registro actualizado exitosamente.")
                        frmBase.Determinar()
                        Inicio()
                        GetTel()
                    Else
                        MensajeError("Ocurrio un error al intentar guardar los cambios")
                    End If
                End If
            End If


        ElseIf banbl = False Then
            CampoBlanco(gbDatoTel, ep)

        End If








        Inicio()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Inicio()
    End Sub

    Private Sub btnEliRes_Click(sender As Object, e As EventArgs) Handles btnEliRes.Click
        If BanderaRes = True Then
            'restaurar
            CampoBlanco(gbDatoTel, ep)
            If banbl = True Then
                If TelefonosSP.AltaTelefono(CodNum) Then
                    frmBase.Determinar()

                Else
                    MensajeError("Hubo un error al intentar recuperar el número.")
                End If
            ElseIf banbl = False Then
                CampoBlanco(gbDatoTel, ep)

            End If
        Else
            'eliminar
            Dim resultado = MessageBox.Show("Esta por dar de baja un número de cliente ¿Desea continuar?", "Eliminar número.", MessageBoxButtons.YesNoCancel)
            If resultado = DialogResult.Yes Then
                If TelefonosSP.BajaTelefono(CodNum, CodUsu) Then
                    frmBase.Determinar()

                Else
                    MensajeError("Hubo un error al intentar dar de baja el número.")

                End If
            End If
        End If
        GetTel()
        Inicio()
    End Sub

    Private Sub Inicio()
        btnAgrMod.Enabled = True
        BanderaRes = False
        txtAgrTel.Text = ""
        BanderaMod = False
        btnAgrMod.Text = "    Agregar"
        btnEliRes.Text = "    Eliminar"
        txtAgrTel.Enabled = True
        btnEliRes.Enabled = False
        btnAgrMod.Image = My.Resources.icons8_más_24
        btnEliRes.Image = My.Resources.icons8_menos_25
        btnCancelar.Image = My.Resources.icons8_cancelar_25
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If txtAgrTel.Text = "" And btnAgrMod.Text = "    Modificar" Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                Me.Close()
                frmClientes.Determinar()
            End If
        Else
            Me.Close()
            frmClientes.Determinar()
        End If

    End Sub
    Dim bMaxTel As Boolean = False
    Private Sub btnMiniMax_Click(sender As Object, e As EventArgs) Handles btnMiniMax.Click
        If bMaxTel = False Then



            WindowState = FormWindowState.Maximized
            bMaxTel = True
            Me.btnMiniMax.Image = My.Resources.icons8_comprimir_25
            dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill





        Else


            bMaxTel = False
            Me.btnMiniMax.Image = My.Resources.icons8_agrandar_25
            WindowState = FormWindowState.Normal
            dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmTelefonos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Normal Then
            bMaxTel = False
            btnMiniMax.Image = My.Resources.icons8_agrandar_25
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            bMaxTel = True
            btnMiniMax.Image = My.Resources.icons8_comprimir_25
        End If
    End Sub




    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub btnMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMnuDesp.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub











    '-------------------EXPERIMENTO---------------------------------------------------------------------------------------------------EXPERIMENTO------------------------------------------------------------------------------------EXPERIMENTO***************************
    Private Const WM_MOUSEACTIVATE As Integer = &H21
    Private Const WM_NCACTIVATE As Integer = &H86

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.SteelBlue Then
                    pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
                    btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
                    btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
                    btnMini.BackColor = Color.FromArgb(60, 113, 155)
                    btnExit.BackColor = Color.FromArgb(60, 113, 155)
                Else
                    pnlMnuTool.BackColor = Color.SteelBlue
                    btnMnuDesp.BackColor = Color.SteelBlue
                    btnMiniMax.BackColor = Color.SteelBlue
                    btnMini.BackColor = Color.SteelBlue
                    btnExit.BackColor = Color.SteelBlue
                End If
            End If
        End If
    End Sub
    ''    End IfPrivate currentColor As Color = Color.SteelBlue
    'Private Const WM_MOUSEACTIVATE As Integer = &H21
    'Private Const WM_NCACTIVATE As Integer = &H86
    'Private clickCount As Integer = 0

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Incrementar el contador de clics
    '            clickCount += 1

    '            ' Cambiar el color del formulario
    '            If clickCount Mod 2 = 1 Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If

    '            ' Si el contador de clics es impar, forzar el color a SteelBlue
    '            If clickCount Mod 2 = 1 Then
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If
    '        End If
    '    End If
    'End Sub
    ''Private clickCount As Integer = 0

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If (m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE) Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Incrementar el contador de clics
    '            clickCount += 1

    '            ' Cambiar el color del formulario
    '            If clickCount Mod 2 = 1 Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private currentColor As Color = Color.SteelBlue

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If (m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE) Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Alternar el color del formulario
    '            If currentColor = Color.SteelBlue Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '                currentColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '                currentColor = Color.SteelBlue
    '            End If
    '        End If
    '    End If
    'End Sub
    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If (m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE) Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Alternar el color del formulario
    '            If currentColor = Color.SteelBlue Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '                currentColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '                currentColor = Color.SteelBlue
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private clickCounter As Integer = 0

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If (m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE) Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Incrementa el contador de clics
    '            clickCounter += 1

    '            ' Alterna el color en función del contador
    '            If clickCounter Mod 2 = 0 Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If
    '        End If
    '    End If
    'End Sub

    'End Sub
    'Private isProcessingClick As Boolean = False

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If Not isProcessingClick AndAlso (m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE) Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside Then
    '            ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
    '            If pnlMnuTool.BackColor = Color.SteelBlue Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If
    '            isProcessingClick = True
    '        End If
    '    End If
    'End Sub

    'Private clickedOutsideOnce As Boolean = False

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    MyBase.WndProc(m)

    '    If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
    '        Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
    '        If clickedOutside AndAlso Not clickedOutsideOnce Then
    '            ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
    '            If pnlMnuTool.BackColor = Color.SteelBlue Then
    '                pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '                btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '                btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '            Else
    '                pnlMnuTool.BackColor = Color.SteelBlue
    '                btnMnuDesp.BackColor = Color.SteelBlue
    '                btnMiniMax.BackColor = Color.SteelBlue
    '                btnMini.BackColor = Color.SteelBlue
    '                btnExit.BackColor = Color.SteelBlue
    '            End If
    '            clickedOutsideOnce = True
    '        End If
    '    ElseIf m.Msg = WM_MOUSEMOVE Then
    '        clickedOutsideOnce = False ' Restablecer el estado si se mueve el ratón dentro del formulario
    '    End If
    'End Sub
    Private Sub VerificarNombreSize()
        If gbDatoTel.Text IsNot Nothing Then
            If gbDatoTel.Text.Length <= 33 Then
            Else
                If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 10)



                ElseIf gbDatoTel.Text.Length > 39 Then




                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 12)
                    gbDatoTel.Text = "Cliente: " + ApeCli

                    If gbDatoTel.Text.Length <= 33 Then
                    Else
                        If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                            gbDatoTel.Font = New Font("Microsoft Sans Serif", 10)

                        ElseIf gbDatoTel.Text.Length > 39 Then
                            gbDatoTel.Font = New Font("Microsoft Sans Serif", 12)

                            gbDatoTel.Text = ApeCli

                            If gbDatoTel.Text.Length <= 33 Then
                                gbDatoTel.Font = New Font("Microsoft Sans Serif", 11)
                            Else
                                If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 9)

                                ElseIf gbDatoTel.Text.Length > 39 AndAlso gbDatoTel.Text.Length <= 47 Then
                                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 8)

                                Else
                                    gbDatoTel.Text = "Ingrese el teléfono:"

                                End If
                            End If

                        End If
                    End If

                End If

            End If
        End If
    End Sub
    Dim iteraciones As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 200 ' Establece el intervalo del temporizador (en milisegundos)

        dgvTelefonos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvTelefonos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        Inicio()
        gbDatoTel.Text = "Cliente: " + ApeCli + " " + NomCli
        VerificarNombreSize()
        CentrarForm(Me)
        GetTel()
        MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvTelefonos.RowHeadersWidth = 15
    End Sub

    Private Sub frmTelefonos_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue
        btnMiniMax.BackColor = Color.SteelBlue
        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue 'hacer funcion, se repite mucho
    End Sub

    Private Sub btnMnuDesp_MouseEnter(sender As Object, e As EventArgs) Handles btnMnuDesp.MouseEnter
        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue
        btnMiniMax.BackColor = Color.SteelBlue
        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub



    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    If pnlMnuTool.BackColor = Color.SteelBlue Then
    '        pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155) ' Cambia el color de fondo a amarillo
    '        btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)
    '        btnMiniMax.BackColor = Color.FromArgb(60, 113, 155)
    '        btnMini.BackColor = Color.FromArgb(60, 113, 155)
    '        btnExit.BackColor = Color.FromArgb(60, 113, 155)
    '    Else
    '        pnlMnuTool.BackColor = Color.SteelBlue ' Cambia el color de fondo a amarillo
    '        btnMnuDesp.BackColor = Color.SteelBlue
    '        btnMiniMax.BackColor = Color.SteelBlue
    '        btnMini.BackColor = Color.SteelBlue
    '        btnExit.BackColor = Color.SteelBlue
    '    End If

    '    ' Incrementa el número de iteraciones
    '    iteraciones += 1

    '    ' Detiene el temporizador después de cinco iteraciones
    '    If iteraciones >= 4 Then
    '        Timer1.Stop()
    '    End If
    'End Sub
End Class