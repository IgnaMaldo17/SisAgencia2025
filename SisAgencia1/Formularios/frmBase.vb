Imports Datos
Imports Entidades





Public Class frmBase
#Region "Variables"
    Public CodCli As Integer = 0
    Dim ClientesSP As New clsCli
    Dim ClienteDatos As New eCli
    Dim bandera As Boolean
#End Region
#Region "Funciones"

    Private Sub EstablecerOrdenColumnasAct()
        If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de cliente", "DNI", "Apellido", "Nombre", "País", "Correo", "Teléfonos", "Fecha de creación"}

            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvClientes.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvClientes.Columns(nombreColumna).Index
                    If columnIndex < dgvClientes.Columns.Count Then
                        dgvClientes.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
                    End If
                End If
            Next
        End If
    End Sub



    Private Sub RestaurarColor()
        btnResEli.Enabled = True
        btnResEli.Text = "Restaurar"
        btnResEli.Image = My.Resources.icons8_restaurar_24
        btnResEli.BackColor = Color.ForestGreen
        btnResEli.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0)
        btnResEli.FlatAppearance.MouseDownBackColor = Color.ForestGreen
        btnResEli.FlatAppearance.MouseOverBackColor = Color.DarkGreen

    End Sub

    Private Sub DisabledColor()
        btnResEli.Enabled = False
        btnResEli.Text = "Eliminar"
        btnResEli.Image = My.Resources.icons8_eliminar_24
        btnResEli.BackColor = Color.SteelBlue
        btnResEli.FlatAppearance.BorderColor = Color.SlateGray
        btnResEli.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnResEli.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 113, 155)

    End Sub

    Private Sub EliminarColor()
        btnResEli.Enabled = True
        btnResEli.Text = "Eliminar"
        btnResEli.Image = My.Resources.icons8_eliminar_24
        btnResEli.BackColor = Color.Firebrick
        btnResEli.FlatAppearance.BorderColor = Color.Maroon
        btnResEli.FlatAppearance.MouseDownBackColor = Color.Firebrick
        btnResEli.FlatAppearance.MouseOverBackColor = Color.DarkRed

    End Sub


    Private Sub GetCliAct()
        dgvClientes.DataSource = ClientesSP.GetClientes()
    End Sub

    Private Sub GetCliCan()
        dgvClientes.DataSource = ClientesSP.GetClientesCancel()
    End Sub

    Private Sub CargaCmbPais()
        cmbPais.DataSource = ClientesSP.GetPaises()
        cmbPais.ValueMember = "ID"
        cmbPais.DisplayMember = "NOMBRE"
    End Sub

    Private Sub Desactivar()
        txtDNI.Enabled = False
        txtNom.Enabled = False
        txtApe.Enabled = False
        cmbPais.Enabled = False
        txtMail.Enabled = False
        txtTel.Enabled = False
        btnGuaMod.Enabled = False
    End Sub


    Public Sub Determinar()
        If rbCliAct.Checked = True Then
            GetCliAct()
            If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
                If dgvClientes.Columns.Contains("Teléfonos") Then
                    dgvClientes.Columns("Teléfonos").Visible = True
                End If
            End If

        Else
            GetCliCan()
            If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
                If dgvClientes.Columns.Contains("Teléfonos") Then
                    dgvClientes.Columns("Teléfonos").Visible = False
                End If
            End If

        End If

    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtDNI.Focus()

        frmVenCli.btnCliV.BackColor = Color.FromArgb(60, 113, 155)

        txtDNI.Enabled = True
        txtNom.Enabled = True
        txtApe.Enabled = True
        cmbPais.Enabled = True
        txtMail.Enabled = True
        txtTel.Enabled = True
        txtTel.Visible = True
        btnAgrTel.Visible = False
        btnGuaMod.Visible = True
        btnGuaMod.Enabled = True
        btnGuaMod.Text = "Guardar"
        btnResEli.Enabled = False
        btnAgrCom.Enabled = False
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        btnNuevo.Height = 34
        btnNuevo.Width = 114
        DisabledColor()
        ClearText(txtDNI)
        ClearText(txtNom)
        ClearText(txtApe)
        ClearText(txtMail)
        ClearText(txtTel) 'crear comando limpiar para ahorrar xd
        'txtBusCli.Text = "Buscar"
        'txtBusCli.ForeColor = Color.Gray
        'Determinar()
    End Sub

    Private Sub HabilitarNo()
        ep.Clear()
        txtDNI.Focus()
        btnResEli.Enabled = False
        btnGuaMod.Enabled = False
        btnGuaMod.Text = "Guardar"
        btnAgrCom.Visible = False
        btnAgrCom.Enabled = False
        btnAgrTel.Visible = False
        txtDNI.Enabled = False
        txtNom.Enabled = False
        txtApe.Enabled = False
        cmbPais.Enabled = False
        txtMail.Enabled = False
        txtTel.Enabled = False
        txtTel.Visible = True
        ClearText(txtDNI)
        ClearText(txtNom)
        ClearText(txtApe)
        ClearText(txtMail)
        ClearText(txtTel)
        cmbPais.Text = ""
        cmbPais.SelectedIndex = -1 ' Establece el ComboBox como vacío
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.SteelBlue
        btnNuevo.Image = My.Resources.icons8_más_30
        'btnNuevo.Height = 34
        'btnNuevo.Width = 95
        'btnNuevo.Location = New Point(159, 298)
        CodCli = 0
        frmVenCli.btnCliV.BackColor = Color.SteelBlue
        txtBusCli.Text = "Buscar"
        txtBusCli.ForeColor = Color.Gray
        Determinar()


    End Sub

    Private Sub Cargar()

        If txtBusCli.Text.Length = 0 Or txtBusCli.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbCliAct.Checked Then
                Me.dgvClientes.DataSource = ClientesSP.BuscarCliente(txtBusCli.Text)
                If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
                    If dgvClientes.Columns.Contains("Teléfonos") Then
                        dgvClientes.Columns("Teléfonos").Visible = True
                    End If
                End If
            Else
                Me.dgvClientes.DataSource = ClientesSP.BuscarClienteBaja(txtBusCli.Text)
                If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
                    If dgvClientes.Columns.Contains("Teléfonos") Then
                        dgvClientes.Columns("Teléfonos").Visible = False
                    End If
                End If
            End If
        End If

        ' Restablecer el orden de las columnas
        EstablecerOrdenColumnasAct()
    End Sub

#End Region
#Region "Eventos"
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvClientes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)

        GetCliAct()
        CargaCmbPais()
        HabilitarNo()
        Cargar()

        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvClientes.RowHeadersWidth = 15

    End Sub

    Private Sub rbCliAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliAct.CheckedChanged
        Determinar()
        Cargar()


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ' Restablecer el texto y el color de txtBusCli
        If btnNuevo.Text = "   Nuevo" Then


            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            ' Restablecer el texto y el color de txtBusCli

            HabilitarNo()

        End If

        'btnAgrCom.Text = "Agregar Cliente"
        'btnAgrCom.Visible = True
        'btnAgrTel.Visible = False
        'txtTel.Visible = True
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick



        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvClientes.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                bandera = False 'si es mod es false
                btnAgrCom.Enabled = True
                txtTel.Enabled = False


                btnAgrCom.Visible = True

                If rbCliCan.Checked Then
                    'tbsEliminar.Enabled = False---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    ' tbsRestaurar.Enabled = True
                    Desactivar()
                    RestaurarColor()
                    btnAgrCom.Visible = False
                    btnAgrTel.Visible = False
                    txtTel.Visible = True
                Else
                    btnGuaMod.Text = "Modificar"
                    btnAgrCom.Visible = True
                    ' tbsEliminar.Enabled = True
                    EliminarColor()
                    txtTel.Visible = False
                    btnAgrTel.Visible = True
                End If



                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvClientes.Rows.Count Then
                    Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodCli = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        dnibus = row.Cells(1)?.Value?.ToString()
                        txtNom.Text = row.Cells(3)?.Value?.ToString()
                        NomCli = row.Cells(3)?.Value?.ToString()
                        txtApe.Text = row.Cells(2)?.Value?.ToString()
                        ApeCli = row.Cells(2)?.Value?.ToString()
                        cmbPais.SelectedValue = row.Cells(8)?.Value?.ToString() ' Suponiendo que la columna 8 contiene el código del país
                        txtMail.Text = row.Cells(5)?.Value?.ToString()
                        frmVenCli.btnCliV.BackColor = Color.FromArgb(60, 113, 155)
                        'txtTel.Text = row.Cells(6)?.Value?.ToString()
                        'dtpFecNac.Value = If(row.Cells(6)?.Value IsNot Nothing, Convert.ToDateTime(row.Cells(6).Value), DateTime.MinValue)
                    End If
                End If


            End If
        End If

    End Sub

    Private Sub rbCliCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliCan.CheckedChanged
        Determinar()
        Cargar()

    End Sub



    Private Sub dgvClientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvClientes.DataBindingComplete
        If dgvClientes.Columns.Count > 0 Then
            dgvClientes.Columns(dgvClientes.Columns.Count - 1).Visible = False
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If btnResEli.Text = "Eliminar" Then
            Dim resultado As DialogResult = MessageBox.Show("Esta por dar de baja un cliente, ¿Desea continuar?", "Eliminar cliente " & txtApe.Text & "," & txtNom.Text, MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                If ClientesSP.BajaClientes(CodCli, CodUsu) Then
                    HabilitarNo()
                    Determinar()
                    btnAgrCom.Visible = False
                    frmVenCli.btnCliV.BackColor = Color.SteelBlue
                Else
                    MensajeError("Hubo un error al intentar dar de baja al cliente " & txtApe.Text)
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            'CampoBlanco2(Me.pnlDatCli, ep)
            'If banbl = True Then
            If ClientesSP.RecClientes(CodCli) Then
                    HabilitarNo()
                    Determinar()
                    frmVenCli.btnCliV.BackColor = Color.SteelBlue
                Else
                    MensajeError("Hubo un error al intentar recuperar el cliente " & txtApe.Text)
                End If
            'ElseIf banbl = False Then
            '    MensajeError("Hay uno o mas campos vacios")
            '    ep.Clear()
            'End If
        End If



        'CampoBlanco(Me.gbCliente, ep)
        'If banbl = True Then
        '    If ClientesSP.RecClientes(CodCli) Then
        '        HabilitarNo()
        '        Determinar()
        '        frmVenCli.btnCliV.BackColor = Color.SteelBlue
        '    Else
        '        MensajeError("Hubo un error al intentar recuperar el cliente " & txtApe.Text)
        '    End If
        'ElseIf banbl = False Then
        '    MensajeError("Hay uno o mas campos vacios")
        '    ep.Clear()
        'End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlancoCliente(Me.pnlDatCli, ep)

        Dim Usuario As New clsCli
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        tabla = Usuario.VerificarCombo(cmbPais.SelectedValue)

        'If tabla2(0)(0) = 0 Then
        If tabla(0)(0) = 2 Then


            If banbl = True Then

                ClienteDatos.CodCli = CodCli
                ClienteDatos.DNI = txtDNI.Text
                ClienteDatos.Apellido = txtApe.Text
                ClienteDatos.Nombre = txtNom.Text
                ClienteDatos.Correo = txtMail.Text
                ClienteDatos.CodPais = cmbPais.SelectedValue
                ClienteDatos.Telefono = txtTel.Text
                ClienteDatos.IdAlta = CodUsu
                tabla2 = Usuario.VerificarDNINuevo(txtDNI.Text)
                tabla3 = Usuario.VerificarDNIMod(txtDNI.Text, ClienteDatos)

                If bandera = True Then
                    If tabla2(0)(0) = 0 Then
                        If ClientesSP.InsCli(ClienteDatos) Then
                            MensajeError("Cliente grabado exitosamente.")
                            frmVenCli.btnCliV.BackColor = Color.SteelBlue
                            btnAgrCom.Visible = False
                            HabilitarNo()
                            Determinar()
                        Else
                            MensajeError("Sucedio un error al intentar grabar el Cliente.")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
                    End If


                Else
                    If tabla3(0)(0) = 0 Then
                        If ClientesSP.ModCli(ClienteDatos) Then
                            If CodCli = 0 Then
                                MensajeError("Ocurrio un error al intentar guardar los cambios (ID 0)")
                            Else

                                ClienteDatos.CodCli = CodCli
                                MensajeError("Registro actualizado exitosamente.")
                                frmVenCli.btnCliV.BackColor = Color.SteelBlue
                                HabilitarNo()
                                Determinar()
                            End If

                        Else
                            MensajeError("Ocurrio un error al intentar guardar los cambios")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
                    End If

                End If
                btnAgrCom.Visible = False


            ElseIf banbl = False Then
                CampoBlancoCliente(Me.pnlDatCli, ep)
                ep.Clear()
            End If



        Else
                'MensajeError("Contraseña incorrecta")
                ep.SetError(cmbPais, "El país es incorrecto.")
            End If

        'Else
        '    ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
        'End If


    End Sub

    Private Sub txtBusCli_Enter(sender As Object, e As EventArgs) Handles txtBusCli.Enter
        If txtBusCli.Text = "Buscar" Then
            txtBusCli.Text = ""
            txtBusCli.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusCli_Leave(sender As Object, e As EventArgs) Handles txtBusCli.Leave
        If String.IsNullOrWhiteSpace(txtBusCli.Text) Then
            txtBusCli.Text = "Buscar"
            txtBusCli.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusCli_TextChanged(sender As Object, e As EventArgs) Handles txtBusCli.TextChanged

        Cargar()
    End Sub

    Private Sub txtBusCli_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusCli.MouseClick
        If txtBusCli.Text = "Buscar" Then
            txtBusCli.Text = ""
            txtBusCli.ForeColor = Color.Black
        Else
            Cargar()
        End If

    End Sub

    Private Sub btnAgrTel_Click(sender As Object, e As EventArgs) Handles btnAgrTel.Click
        Dim frmTelefonos As New frmTelefonos()
        AddHandler frmTelefonos.FormClosed, AddressOf frmTelefonos_FormClosed
        'Me.Enabled = False ' Deshabilitar Formulario 1
        'frmVenCli.Enabled = False
        'frmMenu.Enabled = False
        'frmPrincipal.Enabled = False
        frmTelefonos.ShowDialog()
        frmTelefonos.TopMost = True



    End Sub

    Private Sub frmTelefonos_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Me.Enabled = True ' Volver a habilitar Formulario 1 cuando Formulario 2 se cierre
        'frmVenCli.Enabled = True
        'frmMenu.Enabled = True
        'frmPrincipal.Enabled = True


    End Sub










#End Region
End Class