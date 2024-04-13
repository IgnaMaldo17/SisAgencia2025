Imports Datos
Imports Entidades





Public Class frmEmp
#Region "Variables"
    Public CodEmp As Integer = 0
    Public VerNomUsu As String
    Dim EmpleadosSP As New clsEmp
    Dim ClientesSP As New clsCli
    Dim EmpleadosDatos As New eEmp
    Dim UsuarioDatos As New eUsu
    Dim bandera As Boolean
#End Region
#Region "Funciones"

    Private Sub EstablecerOrdenColumnasAct()
        If dgvEmpleados IsNot Nothing AndAlso dgvEmpleados.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de empleado", "DNI", "Apellido", "Nombre", "País", "Domicilio", "Teléfono", "Correo", "Usuario", "Estado del Usuario", "Fecha de creación"}

            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvEmpleados.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvEmpleados.Columns(nombreColumna).Index
                    If columnIndex < dgvEmpleados.Columns.Count Then
                        dgvEmpleados.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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
        dgvEmpleados.DataSource = EmpleadosSP.GetEmpleados()
    End Sub

    Private Sub GetCliCan()
        dgvEmpleados.DataSource = EmpleadosSP.GetEmpleadosCancel()
    End Sub

    Private Sub CargaCmbPais()
        cmbPais.DataSource = ClientesSP.GetPaises()
        cmbPais.ValueMember = "ID"
        cmbPais.DisplayMember = "NOMBRE"
    End Sub

    Private Sub Desactivar()
        txtDom.Enabled = False
        txtDNI.Enabled = False
        txtNom.Enabled = False
        txtApe.Enabled = False
        cmbPais.Enabled = False
        txtMail.Enabled = False
        txtTel.Enabled = False
        btnGuaMod.Enabled = False
    End Sub


    Public Sub Determinar()
        If rbEmpAct.Checked = True Then
            GetCliAct()
            If dgvEmpleados IsNot Nothing AndAlso dgvEmpleados.Columns.Count > 0 Then
                If dgvEmpleados.Columns.Contains("Usuario") Then
                    dgvEmpleados.Columns("Usuario").Visible = True
                End If
                If dgvEmpleados.Columns.Contains("Estado del Usuario") Then
                    dgvEmpleados.Columns("Estado del Usuario").Visible = True
                End If
            End If

        Else
            GetCliCan()
            If dgvEmpleados IsNot Nothing AndAlso dgvEmpleados.Columns.Count > 0 Then
                If dgvEmpleados.Columns.Contains("Usuario") Then
                    dgvEmpleados.Columns("Usuario").Visible = False
                End If
                If dgvEmpleados.Columns.Contains("Estado del Usuario") Then
                    dgvEmpleados.Columns("Estado del Usuario").Visible = False
                End If
            End If

        End If

    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtDNI.Focus()

        frmEmpUsu.btnEmp.BackColor = Color.FromArgb(60, 113, 155)
        txtDom.Enabled = True
        txtDNI.Enabled = True
        txtNom.Enabled = True
        txtApe.Enabled = True
        cmbPais.Enabled = True
        txtMail.Enabled = True
        txtTel.Enabled = True
        txtTel.Visible = True

        btnGuaMod.Visible = True
        btnGuaMod.Enabled = True
        btnGuaMod.Text = "Guardar"
        btnResEli.Enabled = False
        btnCreUsu.Enabled = False
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        btnNuevo.Height = 34
        btnNuevo.Width = 114
        DisabledColor()
        ClearText(txtDNI)
        ClearText(txtNom)
        ClearText(txtDom)
        ClearText(txtApe)
        ClearText(txtMail)
        ClearText(txtTel) 'crear comando limpiar para ahorrar xd
        'txtBusCli.Text = "Buscar"
        'txtBusCli.ForeColor = Color.Gray
        'Determinar()
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        txtDNI.Focus()
        btnResEli.Enabled = False
        btnGuaMod.Enabled = False
        btnGuaMod.Text = "Guardar"
        btnCreUsu.Visible = False
        btnCreUsu.Enabled = False
        txtDom.Enabled = False
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
        ClearText(txtDom)
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
        CodEmp = 0
        frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
        txtBusEmp.Text = "Buscar"
        txtBusEmp.ForeColor = Color.Gray
        Determinar()


    End Sub

    Private Sub Cargar()

        If txtBusEmp.Text.Length = 0 Or txtBusEmp.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbEmpAct.Checked Then
                Me.dgvEmpleados.DataSource = EmpleadosSP.BuscarEmpleados(txtBusEmp.Text)
                If dgvEmpleados IsNot Nothing AndAlso dgvEmpleados.Columns.Count > 0 Then
                    If dgvEmpleados.Columns.Contains("Usuario") Then
                        dgvEmpleados.Columns("Usuario").Visible = True
                    End If
                    If dgvEmpleados.Columns.Contains("Estado del Usuario") Then
                        dgvEmpleados.Columns("Estado del Usuario").Visible = True
                    End If
                End If
            Else
                        Me.dgvEmpleados.DataSource = EmpleadosSP.BuscarEmpleadoBaja(txtBusEmp.Text)
                If dgvEmpleados IsNot Nothing AndAlso dgvEmpleados.Columns.Count > 0 Then
                    If dgvEmpleados.Columns.Contains("Usuario") Then
                        dgvEmpleados.Columns("Usuario").Visible = False
                    End If
                    If dgvEmpleados.Columns.Contains("Estado del Usuario") Then
                        dgvEmpleados.Columns("Estado del Usuario").Visible = False
                    End If
                End If
            End If
                End If

        ' Restablecer el orden de las columnas
        EstablecerOrdenColumnasAct()
    End Sub

#End Region
#Region "Eventos"
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvEmpleados.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        rbEmpAct.Checked = True
        GetCliAct()
        CargaCmbPais()
        HabilitarNo()
        Cargar()

        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvEmpleados.RowHeadersWidth = 15

    End Sub

    Private Sub rbCliAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpAct.CheckedChanged
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

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellDoubleClick



        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvEmpleados.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                bandera = False 'si es mod es false




                btnCreUsu.Visible = True

                If rbEmpCan.Checked Then
                    'tbsEliminar.Enabled = False------------------------------------------------???????---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    ' tbsRestaurar.Enabled = True
                    Desactivar()
                    RestaurarColor()
                    btnCreUsu.Visible = False

                    txtTel.Visible = True
                Else
                    btnGuaMod.Text = "Modificar"

                    ' tbsEliminar.Enabled = True
                    EliminarColor()
                    txtTel.Visible = True

                End If



                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvEmpleados.Rows.Count Then
                    Dim row As DataGridViewRow = dgvEmpleados.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodEmp = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        CodEmpCreUsu = CInt(row.Cells(0)?.Value)
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        dnibus = row.Cells(1)?.Value?.ToString()
                        txtNom.Text = row.Cells(3)?.Value?.ToString()
                        NomEmpCreUsu = row.Cells(3)?.Value?.ToString()
                        txtApe.Text = row.Cells(2)?.Value?.ToString()
                        ApeEmpCreUsu = row.Cells(2)?.Value?.ToString()
                        cmbPais.SelectedValue = row.Cells(11)?.Value?.ToString() ' Suponiendo que la columna 8 contiene el código del país
                        txtMail.Text = row.Cells(7)?.Value?.ToString()
                        txtDom.Text = row.Cells(5)?.Value?.ToString()
                        frmEmpUsu.btnEmp.BackColor = Color.FromArgb(60, 113, 155)
                        txtTel.Text = row.Cells(6)?.Value?.ToString()
                        VerNomUsu = row.Cells(8)?.Value?.ToString()
                        'dtpFecNac.Value = If(row.Cells(6)?.Value IsNot Nothing, Convert.ToDateTime(row.Cells(6).Value), DateTime.MinValue)
                    End If
                End If

                If rbEmpCan.Checked = True Then
                    btnCreUsu.Visible = False
                Else
                    If VerNomUsu = "" Then
                        btnCreUsu.Visible = True
                        btnCreUsu.Enabled = True
                    Else
                        btnCreUsu.Visible = False
                    End If

                End If


            End If
            End If

    End Sub

    Private Sub rbCliCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpCan.CheckedChanged
        Determinar()
        Cargar()

    End Sub



    Private Sub dgvClientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvEmpleados.DataBindingComplete
        If dgvEmpleados.Columns.Count > 0 Then
            dgvEmpleados.Columns(dgvEmpleados.Columns.Count - 1).Visible = False
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
            Dim resultado As DialogResult = MessageBox.Show("Esta por dar de baja un empleado ¿Desea continuar?", "Eliminar empleado " & txtApe.Text & ", " & txtNom.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                If NomUsu = VerNomUsu Then
                    MensajeError("No puedes auto-eliminarte, " & txtApe.Text & ".")
                Else
                    If EmpleadosSP.BajaEmpleados(CodEmp, CodUsu) Then
                        HabilitarNo()
                        Determinar()

                        frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
                    Else
                        MensajeError("Hubo un error al intentar dar de baja al empleado " & txtApe.Text & ".")
                    End If
                End If

            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            'CampoBlanco2(Me.pnlDatCli, ep)
            'If banbl = True Then
            If EmpleadosSP.RecEmpleados(CodEmp) Then
                HabilitarNo()
                Determinar()
                frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
            Else
                MensajeError("Hubo un error al intentar recuperar el empleado " & txtApe.Text & ".")
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
        CampoBlanco2(Me.pnlDatEmp, ep)

        Dim empleado As New clsEmp
        Dim cliente As New clsCli
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        tabla = cliente.VerificarCombo(cmbPais.SelectedValue)

        'If tabla2(0)(0) = 0 Then
        If tabla(0)(0) = 2 Then


            If banbl = True Then

                EmpleadosDatos.CodEmp = CodEmp
                EmpleadosDatos.DNI = txtDNI.Text
                EmpleadosDatos.Apellido = txtApe.Text
                EmpleadosDatos.Nombre = txtNom.Text
                EmpleadosDatos.Correo = txtMail.Text
                EmpleadosDatos.CodPais = cmbPais.SelectedValue
                EmpleadosDatos.Telefono = txtTel.Text
                EmpleadosDatos.Domicilio = txtDom.Text
                EmpleadosDatos.IdAlta = CodUsu
                tabla2 = empleado.VerificarDNIEmpNuevo(txtDNI.Text)
                tabla3 = empleado.VerificarDNIEmpMod(txtDNI.Text, EmpleadosDatos)

                If bandera = True Then
                    If tabla2(0)(0) = 0 Then
                        If EmpleadosSP.InsEmp(EmpleadosDatos) Then
                            MensajeError("Empleado grabado exitosamente.")
                            frmVenCli.btnCliV.BackColor = Color.SteelBlue
                            btnCreUsu.Visible = False
                            HabilitarNo()
                            Determinar()
                        Else
                            MensajeError("Sucedio un error al intentar grabar el empleado.")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un empleado.")
                    End If


                Else
                    If tabla3(0)(0) = 0 Then
                        If EmpleadosSP.ModEmp(EmpleadosDatos) Then
                            If CodEmp = 0 Then
                                MensajeError("Ocurrio un error al intentar guardar los cambios (ID 0)")
                            Else

                                EmpleadosDatos.CodEmp = CodEmp
                                MensajeError("Registro actualizado exitosamente.")
                                frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
                                HabilitarNo()
                                Determinar()
                            End If

                        Else
                            MensajeError("Ocurrio un error al intentar guardar los cambios")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un empleado.")
                    End If

                End If
                btnCreUsu.Visible = False


            ElseIf banbl = False Then
                CampoBlanco2(Me.pnlDatEmp, ep)

            End If



        Else
            'MensajeError("Contraseña incorrecta")
            ep.SetError(cmbPais, "El país es incorrecto.")
        End If

        'Else
        '    ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
        'End If


    End Sub

    Private Sub txtBusCli_Enter(sender As Object, e As EventArgs) Handles txtBusEmp.Enter
        If txtBusEmp.Text = "Buscar" Then
            txtBusEmp.Text = ""
            txtBusEmp.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusCli_Leave(sender As Object, e As EventArgs) Handles txtBusEmp.Leave
        If String.IsNullOrWhiteSpace(txtBusEmp.Text) Then
            txtBusEmp.Text = "Buscar"
            txtBusEmp.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusCli_TextChanged(sender As Object, e As EventArgs) Handles txtBusEmp.TextChanged

        Cargar()
    End Sub

    Private Sub txtBusCli_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusEmp.MouseClick
        If txtBusEmp.Text = "Buscar" Then
            txtBusEmp.Text = ""
            txtBusEmp.ForeColor = Color.Black
        Else
            Cargar()
        End If

    End Sub

    Private Sub btnCreUsu_Click(sender As Object, e As EventArgs) Handles btnCreUsu.Click
        Dim frmAgrUsu As New frmAgrUsu()
        AddHandler frmAgrUsu.FormClosed, AddressOf frmAgrUsu_FormClosed
        'Me.Enabled = False ' Deshabilitar Formulario 1
        'frmVenCli.Enabled = False
        'frmMenu.Enabled = False
        'frmPrincipal.Enabled = False
        frmAgrUsu.ShowDialog()
        frmAgrUsu.TopMost = True



    End Sub

    Private Sub frmAgrUsu_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Me.Enabled = True ' Volver a habilitar Formulario 1 cuando Formulario 2 se cierre
        'frmVenCli.Enabled = True
        'frmMenu.Enabled = True
        'frmPrincipal.Enabled = True


    End Sub










#End Region
End Class