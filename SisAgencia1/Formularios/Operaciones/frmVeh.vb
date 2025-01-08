#Region "Imports"
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport

#End Region

Public Class frmVeh

#Region "Declaraciones"
    Public CodVeh As Integer = 0
    Public CodChof As Integer = 0
    Dim VehiculosSP As New clsVeh
    Dim VehiculosDatos As New eVeh
    Dim bandera As Boolean
    Dim full As Point
    Dim mini As Point
    Dim miniinicio As Point
#End Region

#Region "Subrutinas"
    Public Sub New()
        OpacidadNo(Me)
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub EstablecerOrdenColumnasAct()
        If dgvVehiculos IsNot Nothing AndAlso dgvVehiculos.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de vehiculo", "Matrícula", "Modelo", "Capacidad", "DNI", "Apellido", "Nombre", "Teléfono", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvVehiculos.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvVehiculos.Columns(nombreColumna).Index
                    If columnIndex < dgvVehiculos.Columns.Count Then
                        dgvVehiculos.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ColorCambio(b As Button, s As String, im As Image, cl As Color, cl2 As Color, cl3 As Color)
        b.Text = s
        b.Image = im
        b.BackColor = cl
        b.FlatAppearance.BorderColor = cl2
        b.FlatAppearance.MouseDownBackColor = cl
        b.FlatAppearance.MouseOverBackColor = cl3
    End Sub

    Private Sub RestaurarColor()
        ControlTrue(btnResEli)
        ColorCambio(btnResEli, "Restaurar", My.Resources.icons8_restaurar_24, Color.ForestGreen, Color.FromArgb(0, 64, 0), Color.DarkGreen)
    End Sub

    Private Sub DisabledColor()
        ControlFalse(btnResEli)
        ColorCambio(btnResEli, "Deshabilitar", My.Resources.icons8_eliminar_24, Color.FromArgb(30, 63, 111), Color.FromArgb(15, 31, 55), Color.FromArgb(43, 88, 157))
    End Sub

    Private Sub EliminarColor()
        ControlTrue(btnResEli)
        ColorCambio(btnResEli, "Deshabilitar", My.Resources.icons8_eliminar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
    End Sub
    Private Sub GetVehAct()
        dgvVehiculos.DataSource = VehiculosSP.GetVehiculos()
    End Sub

    Private Sub GetVehCan()
        dgvVehiculos.DataSource = VehiculosSP.GetVehiculosCancel()
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtMatricula)
        ControlFalse(txtModel)
        ControlFalse(txtCapPasj)
        ControlFalse(txtChof)
        ControlFalse(btnGuaMod)
        MinimizarPanel(btnSelChof)
    End Sub

    Public Sub Determinar()
        If rbVehAct.Checked = True Then
            GetVehAct()
            If dgvVehiculos IsNot Nothing AndAlso dgvVehiculos.Columns.Count > 0 Then
                'If dgvVehiculos.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvVehiculos.Columns("Motivo Deshabilitar").Visible = False '''
                '    'If frmPrincipal.bMax = True Then
                '    '    dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                '    'Else
                '    '    dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '    'End If
                'End If
            End If
        Else
            GetVehCan()
            'If dgvVehiculos IsNot Nothing AndAlso dgvVehiculos.Columns.Count > 0 Then
            '    If dgvVehiculos.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvVehiculos.Columns("Motivo Deshabilitar").Visible = True
            '        'dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '    End If
            'End If
        End If

        If frmPrincipal.bMax = True Then
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Public Sub Limpiar2()
        ClearText(txtMatricula)
        ClearText(txtModel)
        ClearText(txtCapPasj)
        ClearText(txtChof)
    End Sub

    Private Sub HabilitarNuevo()
        HabilitarBase()
        txtChof.Text = "Seleccione un chofer."
    End Sub

    Private Sub HabilitarBase()
        ep.Clear()
        bandera = True
        txtMatricula.Focus()
        ControlFalse(txtChof)
        'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtMatricula)
        ControlTrue(txtModel)
        ControlTrue(txtCapPasj)
        VerPanel(btnGuaMod)
        ControlTrue(btnGuaMod)
        VerPanel(btnSelChof)
        btnGuaMod.Text = "Guardar"
        ControlFalse(btnResEli)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        DisabledColor()
        Limpiar()
        txtChof.Text = "Seleccione un chofer."
    End Sub

    Public Sub HabilitarDesdeChof()
        HabilitarBase()
        txtChof.Text = NomApeChofAgrVeh
        CodChof = CodChofAgrVeh
        txtBusVeh.Text = "Buscar"
        txtBusVeh.ForeColor = Color.Gray
        Determinar()
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        txtMatricula.Focus()
        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        ClearInt(CodChofAgrVeh)
        Desactivar()
        MinimizarPanel(btnSelChof)
        VehdesdeChof = False
        ClearString(NomApeChofAgrVeh)
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodVeh)
        ClearInt(CodChof)
        'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
        txtBusVeh.Text = "Buscar"
        txtBusVeh.ForeColor = Color.Gray
        Determinar()
        bandera = False
        Limpiar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub

    Public Sub EliResVeh()
        If btnResEli.Text = "Deshabilitar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un vehículo junto con sus operaciones asignadas ¿Desea continuar?", "Deshabilitar vehiculo " & txtModel.Text & " de " & txtChof.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                VehiculosDatos.MotivoDes = MotivoDeshabilitar
                If VehiculosSP.BajaVehiculos(CodVeh, CodUsu, VehiculosDatos) Then
                    MensajeNotificacion("Vehículo deshabilitado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar deshabilitar al vehículo " & txtModel.Text & " de " & txtChof.Text & ".", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            Dim vehiculo As New clsVeh
            Dim tabla As New DataTable
            tabla = vehiculo.VerificarChofVeh(CodVeh)
            If tabla(0)(0) = 2 Then
                If VehiculosSP.RecVehiculos(CodVeh) Then
                    MensajeNotificacion("Vehículo restaurado exitosamente, deberá restaurar sus operaciones manualmente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar recuperar el vehículo " & txtModel.Text & " de " & txtChof.Text & ".", "Error.")
                End If
            Else
                MensajeNotificacion("El vehículo pertenece a un chofer eliminado, por lo que el chofer debe ser restaurado primero.", "Error.")
            End If
        End If
        PermisoADMIN = False
    End Sub

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un vehículo junto con sus operaciones asignadas ¿Desea continuar?", "Deshabilitar vehiculo.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            VehiculosDatos.MotivoDes = MotivoDeshabilitar
            If VehiculosSP.BajaVehiculos(CodVehTabla, CodUsu, VehiculosDatos) Then
                MensajeNotificacion("Vehículo deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al vehículo.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        Dim vehiculo As New clsVeh
        Dim tabla As New DataTable
        tabla = vehiculo.VerificarChofVeh(CodVehTabla)
        If tabla(0)(0) = 2 Then
            If VehiculosSP.RecVehiculos(CodVehTabla) Then
                MensajeNotificacion("Vehículo restaurado exitosamente, deberá restaurar sus operaciones manualmente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el vehículo.", "Error.")
            End If
        Else
            MensajeNotificacion("El vehículo pertenece a un chofer eliminado, por lo que el chofer debe ser restaurado primero.", "Error.")
        End If
    End Sub

    Public Sub Cargar()
        If txtBusVeh.Text.Length = 0 Or txtBusVeh.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbVehAct.Checked Then
                Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculos(txtBusVeh.Text)
            Else
                Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculosBaja(txtBusVeh.Text)
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarVehiculoT()
        Me.dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVehiculos.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarVehiculoF()
        Me.dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVehiculos.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub
#End Region

#Region "Eventos"
    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmOpChofVeh.btnVeh) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario
    End Sub

    Private Sub frmVeh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbVehAct.Checked = True
        GetVehAct()
        Cargar()
        HabilitarNo()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvVehiculos)
        dgvVehiculos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvVehiculos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        If frmPrincipal.bMax = True Then
            MinimizarVehiculoT()
        Else
            MinimizarVehiculoF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If

        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnSelChof, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundCornersBtn(rbVehAct, 10)
        frmMenu.RoundCornersBtn2(rbVehCan, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatVeh_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatVeh.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio As Color = Color.FromArgb(173, 197, 231)  ' Color inicial con transparencia
        Dim colorFin As Color = Color.FromArgb(253, 254, 255)  ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, pnlDatVeh.Height),                    ' Punto de inicio
        New Point(pnlDatVeh.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatVeh.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatVeh_Resize(sender As Object, e As EventArgs) Handles pnlDatVeh.Resize
        pnlDatVeh.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbVehAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbVehAct.CheckedChanged
        Determinar()
        Cargar()
        DeshabilitarToolStripMenuItem.Text = "Deshabilitar"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "   Nuevo" Then
            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            HabilitarNo()
        End If
    End Sub

    Private Sub dgvVehiculos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehiculos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvVehiculos.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvVehiculos.Rows.Count Then
                    Dim row As DataGridViewRow = dgvVehiculos.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodVeh = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtMatricula.Text = row.Cells(1)?.Value?.ToString()
                        txtCapPasj.Text = row.Cells(3)?.Value?.ToString()
                        txtModel.Text = row.Cells(2)?.Value?.ToString()
                        txtChof.Text = row.Cells(5)?.Value?.ToString() & " " & row.Cells(6)?.Value?.ToString()
                        'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(43, 88, 157)
                        CodChof = CInt(row.Cells(10)?.Value)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbVehCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                End If
            End If
        End If
    End Sub
    Private Sub rbVehCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbVehCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
    End Sub

    Private Sub dgvVehiculosDataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvVehiculos.DataBindingComplete
        If dgvVehiculos.Columns.Count > 0 Then
            dgvVehiculos.Columns(dgvVehiculos.Columns.Count - 1).Visible = False
            dgvVehiculos.Columns(dgvVehiculos.Columns.Count - 3).Visible = False
            dgvVehiculos.Columns(dgvVehiculos.Columns.Count - 11).Visible = False
        End If
    End Sub

    Private Sub txtCapPasj_TextChanged(sender As Object, e As EventArgs) Handles txtCapPasj.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtCapPasj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapPasj.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtMatricula_TextChanged(sender As Object, e As EventArgs) Handles txtMatricula.TextChanged
        FiltrarNoSimbolo(sender, e)
    End Sub

    Private Sub txtMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMatricula.KeyPress
        SoloIntString(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 3
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResVeh()
            Else
                VarADMIN = 3
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatVeh, ep)
        Dim vehiculo As New clsVeh
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        If banbl = True Then
            VehiculosDatos.CodVeh = CodVeh
            VehiculosDatos.Matricula = txtMatricula.Text
            VehiculosDatos.Modelo = txtModel.Text
            VehiculosDatos.Capacidad = txtCapPasj.Text
            VehiculosDatos.CodChof = CodChof
            VehiculosDatos.IdAlta = CodUsu
            tabla2 = vehiculo.VerificarMatriculaNuevo(txtMatricula.Text)
            If bandera = True Then
                If txtChof.Text = "Seleccione un chofer." Then
                    ep.SetError(txtChof, "Debe seleccionar un chofer.")
                    Return
                End If
                If tabla2(0)(0) = 0 Then
                    If VehiculosSP.InsVeh(VehiculosDatos) Then
                        MensajeNotificacion("Vehículo grabado exitosamente.", "Éxito.")
                        'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Sucedió un error al intentar grabar el vehículo.", "Error.")
                    End If
                Else
                    ep.SetError(txtMatricula, "La matrícula ya está asignado a un vehículo.")
                End If
            Else
                If CodTpUsu = 2 Then
                    VarADMIN = 13
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    ModVeh()
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco2(Me.pnlDatVeh, ep)
        End If
    End Sub

    Public Sub ModVeh()
        Dim vehiculo As New clsVeh
        Dim tabla3 As New DataTable
        tabla3 = vehiculo.VerificarMatriculaMod(txtMatricula.Text, VehiculosDatos)
        If tabla3(0)(0) = 0 Then
            If VehiculosSP.ModVeh(VehiculosDatos) Then
                If CodVeh = 0 Then
                    MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                Else
                    VehiculosDatos.CodVeh = CodVeh
                    MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                    'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
                    HabilitarNo()
                    Determinar()
                End If
            Else
                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
            End If
        Else
            ep.SetError(txtMatricula, "La matrícula ya está asignado a un vehículo.")
        End If
    End Sub

    Private Sub btnSelChof_Click(sender As Object, e As EventArgs) Handles btnSelChof.Click
        Dim frmSelChof As New frmSelChof()
        frmSelChof.ShowDialog()
        frmSelChof.TopMost = True
    End Sub

    Private Sub frmVeh_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#Region "Ocultar Panel"
    Private Sub frmVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDatVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnNuevo_MouseDown(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtMatricula_MouseDown(sender As Object, e As MouseEventArgs) Handles txtMatricula.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtModel_MouseDown(sender As Object, e As MouseEventArgs) Handles txtModel.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtCapPasj_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCapPasj.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtChof_MouseDown(sender As Object, e As MouseEventArgs) Handles txtChof.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbVehAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbVehAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbVehCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbVehCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvVehiculos_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvVehiculos.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnGuaMod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGuaMod.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnSelChof_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSelChof.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbVehAct.Checked = True Then
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpVehH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If
                ' Cargar el reporte desde los recursos

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = VehiculosSP.GetVehiculos()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosVeh")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else

                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpVehD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = VehiculosSP.GetVehiculosCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajVeh")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al imprimir el reporte: " & ex.Message)
        Finally
            reporte.Dispose()
        End Try
    End Sub

    Private filaSeleccionada As DataGridViewRow
    Dim CodVehTabla As Integer

    Private Sub dgvVehiculos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVehiculos.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvVehiculos.CurrentCell = dgvVehiculos.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvVehiculos.Rows(e.RowIndex)
                CodVehTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsVeh.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVehTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 22
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 22
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVehTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 23
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    Restaurar2()
                End If
            End If
        Else
            MensajeNotificacion("Hubo un error al deshabilitar/restaurar desde la tabla, hacerlo manualmente.", "Error.")
        End If
        PermisoADMIN = False
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvVehiculos.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvVehiculos.SelectedCells(0).RowIndex
            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvVehiculos, rowIndex)
        End If
    End Sub

    Private Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodVeh = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtMatricula.Text = row.Cells(1)?.Value?.ToString()
                        txtCapPasj.Text = row.Cells(3)?.Value?.ToString()
                        txtModel.Text = row.Cells(2)?.Value?.ToString()
                        txtChof.Text = row.Cells(5)?.Value?.ToString() & " " & row.Cells(6)?.Value?.ToString()
                        'frmOpChofVeh.btnVeh.BackColor = Color.FromArgb(43, 88, 157)
                        CodChof = CInt(row.Cells(10)?.Value)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbVehCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Modificar"
                    EliminarColor()
                End If
            End If
        End If
    End Sub

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusVeh_Enter(sender As Object, e As EventArgs) Handles txtBusVeh.Enter
        If txtBusVeh.Text = "Buscar" Then
            ClearText(txtBusVeh)
            txtBusVeh.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusVeh_Leave(sender As Object, e As EventArgs) Handles txtBusVeh.Leave
        If String.IsNullOrWhiteSpace(txtBusVeh.Text) Then
            txtBusVeh.Text = "Buscar"
            txtBusVeh.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusVeh_TextChanged(sender As Object, e As EventArgs) Handles txtBusVeh.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusVeh_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusVeh.MouseClick
        If txtBusVeh.Text = "Buscar" Then
            ClearText(txtBusVeh)
            txtBusVeh.ForeColor = Color.Black
        Else
            Cargar()
        End If
    End Sub

    Private Sub TogglePanel()
        If pnlBusxFecha.Visible Then
            ' Ocultar con animación
            AnimateWindow(pnlBusxFecha.Handle, 150, AW_VER_NEGATIVE Or AW_SLIDE Or AW_HIDE)
            pnlBusxFecha.Visible = False
            btnBusxFecha.Image = My.Resources.icons8_chevron_abajo_en_círculo_24
        Else
            ' Mostrar con animación
            AnimateWindow(pnlBusxFecha.Handle, 150, AW_VER_POSITIVE Or AW_SLIDE)
            pnlBusxFecha.Visible = True
            btnBusxFecha.Image = My.Resources.icons8_flecha_arriba_24
        End If
    End Sub

    Private Sub btnBusxFecha_Click(sender As Object, e As EventArgs) Handles btnBusxFecha.Click
        TogglePanel()
    End Sub

    Dim desde As String
    Dim hasta As String

    Private Sub DefaultBusColor()
        ColorCambio(btnBusxDia, "   Búsqueda Avanzada", My.Resources.icons8_buscar_24, Color.FromArgb(30, 63, 111), Color.FromArgb(15, 31, 55), Color.FromArgb(43, 88, 157))
        ControlTrue(txtBusVeh)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusVeh)
    End Sub

    Private Sub Limpiar()
        ComboSelIdx(cmbAnho)
        ComboSelIdx(cmbMes)
        ComboSelIdx(cmbDia)
        ComboSelIdx(cmbAnhoH)
        ComboSelIdx(cmbMesH)
        ComboSelIdx(cmbDiaH)
        Limpiar2()
    End Sub

    Private Sub LimpiarHasta()
        ComboSelIdx(cmbAnhoH)
        ComboSelIdx(cmbMesH)
        ComboSelIdx(cmbDiaH)
    End Sub

    Private Sub cmbDate(anho As ComboBox, mes As ComboBox, dia As ComboBox)
        If anho.SelectedItem = "----" Or anho.SelectedItem = Nothing Then
            ControlFalse(mes)
            ComboSelIdx(mes)
            ControlFalse(dia)
            ComboSelIdx(dia)
        Else
            ControlTrue(mes)
            If mes.SelectedItem = "--" Or mes.SelectedItem = Nothing Then
                ControlFalse(dia)
                ComboSelIdx(dia)
            Else
                ControlTrue(dia)
            End If
        End If
    End Sub

    Private Sub HastaDate()
        If cmbDiaH.SelectedIndex <> 0 Then
            hasta = cmbDiaH.SelectedItem & "/" & cmbMesH.SelectedItem & "/" & cmbAnhoH.SelectedItem
        Else
            If cmbMesH.SelectedIndex <> 0 Then
                hasta = cmbMesH.SelectedItem & "/" & cmbAnhoH.SelectedItem
            Else
                hasta = "31/" & "12/" & cmbAnhoH.SelectedItem
            End If
        End If
    End Sub

    Private Sub DesdeDate()
        If cmbDia.SelectedIndex <> 0 Then
            desde = cmbDia.SelectedItem & "/" & cmbMes.SelectedItem & "/" & cmbAnho.SelectedItem
        Else
            If cmbMes.SelectedIndex <> 0 Then
                desde = cmbMes.SelectedItem & "/" & cmbAnho.SelectedItem
            Else
                desde = cmbAnho.SelectedItem
            End If
        End If
    End Sub

    Private Sub ckbActOp_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActHasta.CheckedChanged
        If ckbActHasta.Checked = True Then
            ckbActHasta.Image = My.Resources.icons8_tickc_24
            ControlTrue(cmbAnhoH)
            cmbDate(cmbAnhoH, cmbMesH, cmbDiaH)
        Else
            ckbActHasta.Image = My.Resources.icons8_tickc_no_24
            ControlFalse(cmbDiaH)
            ControlFalse(cmbMesH)
            ControlFalse(cmbAnhoH)
        End If
    End Sub

    Private Sub cmbAnho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnho.SelectedIndexChanged
        If cmbAnho.SelectedItem = "----" Or cmbAnho.SelectedItem = Nothing Then
            ControlFalse(ckbActHasta)
            ckbActHasta.Checked = False
        Else
            ControlTrue(ckbActHasta)
        End If
        cmbDate(cmbAnho, cmbMes, cmbDia)
        If cmbAnho.SelectedIndex = 0 Or cmbMes.SelectedIndex = 0 Then
        Else
            FechasCmb(cmbAnho, cmbMes, cmbDia)
        End If
    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        cmbDate(cmbAnho, cmbMes, cmbDia)
        If cmbAnho.SelectedIndex = 0 Or cmbMes.SelectedIndex = 0 Then
        Else
            FechasCmb(cmbAnho, cmbMes, cmbDia)
        End If
    End Sub

    Private Sub cmbDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDia.SelectedIndexChanged
        cmbDate(cmbAnho, cmbMes, cmbDia)
    End Sub

    Private Sub cmbAnhoH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnhoH.SelectedIndexChanged
        cmbDate(cmbAnhoH, cmbMesH, cmbDiaH)
        If cmbAnhoH.SelectedIndex = 0 Or cmbMesH.SelectedIndex = 0 Then
        Else
            FechasCmb(cmbAnhoH, cmbMesH, cmbDiaH)
        End If
    End Sub

    Private Sub cmbMesH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMesH.SelectedIndexChanged
        cmbDate(cmbAnhoH, cmbMesH, cmbDiaH)
        If cmbAnhoH.SelectedIndex = 0 Or cmbMesH.SelectedIndex = 0 Then
        Else
            FechasCmb(cmbAnhoH, cmbMesH, cmbDiaH)
        End If
    End Sub

    Private Sub cmbDiaH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiaH.SelectedIndexChanged
        cmbDate(cmbAnhoH, cmbMesH, cmbDiaH)
    End Sub

    Private Sub btnBusxDia_Click(sender As Object, e As EventArgs) Handles btnBusxDia.Click
        If btnBusxDia.Text = "   Búsqueda Avanzada" Then
            If cmbAnho.SelectedIndex = 0 Then
                ep.SetError(btnBusxDia, "No hay un año seleccionado")
            Else
                If ckbActHasta.Checked = True And cmbAnhoH.SelectedIndex <> 0 Then
                    If cmbAnho.SelectedIndex > cmbAnhoH.SelectedIndex And cmbAnhoH.SelectedIndex <> 0 Then
                        ep.SetError(cmbAnhoH, "El año de hasta no puede ser menor al desde.")
                        Return
                    Else
                        If cmbMes.SelectedIndex > cmbMesH.SelectedIndex And cmbMesH.SelectedIndex <> 0 Then
                            If cmbAnho.SelectedIndex = cmbAnhoH.SelectedIndex And cmbAnho.SelectedIndex <> 0 Then
                                ep.SetError(cmbMesH, "El mes de hasta no puede ser menor al desde.")
                                Return
                            End If
                        Else
                            If cmbDia.SelectedIndex > cmbDiaH.SelectedIndex And cmbDiaH.SelectedIndex <> 0 Then
                                If cmbMes.SelectedIndex = cmbMesH.SelectedIndex And cmbMes.SelectedIndex <> 0 Then
                                    ep.SetError(cmbDiaH, "El día de hasta no puede ser menor al desde.")
                                    Return
                                End If
                            End If
                        End If
                        ep.Clear()
                    End If
                    If cmbDia.SelectedIndex <> 0 And cmbDiaH.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 And cmbMesH.SelectedIndex <> 0 Then
                        FechasCmbConDiaenD(cmbAnhoH, cmbMesH, hasta)
                        DesdeDate()
                    ElseIf cmbDia.SelectedIndex = 0 And cmbDiaH.SelectedIndex <> 0 And cmbMes.SelectedIndex <> 0 And cmbMesH.SelectedIndex <> 0 Then
                        FechasCmbConDiaenH(cmbAnho, cmbMes, desde)
                        HastaDate()
                    ElseIf cmbDiaH.SelectedIndex = 0 And cmbMesH.SelectedIndex <> 0 And cmbMes.SelectedIndex = 0 Then
                        FechasCmbConDiaenD(cmbAnhoH, cmbMesH, hasta)
                        DesdeDate()
                    ElseIf cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 And cmbMesH.SelectedIndex = 0 Then
                        FechasCmbConDiaenH(cmbAnhoH, cmbMesH, desde)
                        HastaDate()
                    Else
                        If cmbDia.SelectedIndex = 0 And cmbDiaH.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 And cmbMesH.SelectedIndex <> 0 Then
                            FechasCmbSinDia(cmbAnho, cmbMes, cmbAnhoH, cmbMesH, desde, hasta)
                        Else
                            DesdeDate()
                            HastaDate()
                        End If
                    End If
                    If desde = hasta Then
                        ep.SetError(btnBusxDia, "Las fechas no pueden ser iguales.")
                        Return
                    End If

                    If rbVehAct.Checked Then
                        Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoFechaHasta(desde, hasta)
                    Else
                        Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoDesFechaHasta(desde, hasta)
                    End If

                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbVehAct.Checked Then
                            Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoFechaHasta(desde, hasta)
                        Else
                            Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoDesFechaHasta(desde, hasta)
                        End If
                    Else
                        DesdeDate()
                        If rbVehAct.Checked Then
                            Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoFecha(desde)
                        Else
                            Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculoDesFecha(desde)
                        End If
                    End If
                End If
                CancelarBusColor()
                OcultarFecha(pnlBusxFecha, btnBusxFecha)
            End If
        Else
            Determinar()
            Cargar()
            DefaultBusColor()
        End If
    End Sub


    Private Sub AjustarTamanoPanelYDataGrid()
        ' Ajustar la altura del DataGridView en función de la cantidad de filas y el alto de cada fila
        Dim totalAltoFilas As Integer = dgvPanelDesp.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        Dim altoHeader As Integer = dgvPanelDesp.ColumnHeadersHeight
        Dim nuevoAlto As Integer = totalAltoFilas + altoHeader

        ' Asignar el nuevo alto al DataGridView
        dgvPanelDesp.Height = nuevoAlto

        pnlDespDGV.Height = dgvPanelDesp.Height + 6 ' Reducir margen vertical

        ' Obtener la posición de la fila seleccionada en el DataGridView
        Dim rectFila As Rectangle = dgvVehiculos.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvVehiculos.Top + rectFila.Top + dgvVehiculos.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvVehiculos.Left, dgvVehiculos.Top + rectFila.Top + dgvVehiculos.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvVehiculos.Left, dgvVehiculos.Top + rectFila.Top - pnlDespDGV.Height)
        End If

        ' Asegurarse de que el Panel y el DataGridView se muestren
        pnlDespDGV.Visible = True
        dgvPanelDesp.Visible = True
    End Sub

    Private Sub DetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleToolStripMenuItem.Click
        ' Limpiar el panel y mostrarlo
        pnlDespDGV.Controls.Clear()
        pnlDespDGV.Visible = True
        dgvPanelDesp.Visible = True

        ' Configurar el tamaño y la posición del DataGridView dentro del panel
        dgvPanelDesp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Cambiado a Fill
        'dgvPanelDesp.Location = New Point(10, 10) ' Ajustar la posición dentro del panel

        ' Agregar el DataGridView al Panel si no está agregado
        If Not pnlDespDGV.Controls.Contains(dgvPanelDesp) Then
            pnlDespDGV.Controls.Add(dgvPanelDesp)
        End If

        ' Mostrar los datos en la DataGridView transpuesta (dgvPanelDesp)
        dgvPanelDesp.Columns.Clear()
        dgvPanelDesp.Rows.Clear()

        ' Configurar las columnas de dgvPanelDesp para mostrar como filas
        Dim colCampo As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        colCampo.HeaderText = "Campo"
        colCampo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells ' Ajustar a contenido
        dgvPanelDesp.Columns.Add(colCampo)

        Dim colDetalle As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        colDetalle.HeaderText = "Detalle"
        colDetalle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' Ocupa el resto del espacio
        dgvPanelDesp.Columns.Add(colDetalle)

        ' Agregar los datos transpuestos
        dgvPanelDesp.Rows.Add("Número de vehículo", CInt(filaSeleccionada.Cells(0)?.Value))

        If rbVehCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(8)?.Value.ToString)
        End If

        AjustarTamanoPanelYDataGrid()

        ' Traer el panel al frente
        pnlDespDGV.BringToFront()
    End Sub

    Private Sub btnBusxFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBusxFecha.MouseDown
        OcultarPanel()
        'MinimizarPanel(pnlBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlBusxFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBusxFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label14_MouseDown(sender As Object, e As MouseEventArgs) Handles Label14.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label15_MouseDown(sender As Object, e As MouseEventArgs) Handles Label15.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label16_MouseDown(sender As Object, e As MouseEventArgs) Handles Label16.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbAnho_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbAnho.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbMes_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbMes.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbDia_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbDia.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub ckbActHasta_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActHasta.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label13_MouseDown(sender As Object, e As MouseEventArgs) Handles Label13.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label10.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label12_MouseDown(sender As Object, e As MouseEventArgs) Handles Label12.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbAnhoH_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbAnhoH.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbMesH_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbMesH.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbDiaH_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbDiaH.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnBusxDia_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBusxDia.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDespDGV_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDespDGV.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvPanelDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPanelDesp.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub
#End Region
#End Region

#End Region

End Class