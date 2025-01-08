#Region "Imports"
Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport
Imports FastReport.Data

#End Region

Public Class frmOp

#Region "Declaraciones"
    Public CodOp As Integer = 0
    Public CodDetOp As Integer = 0
    Public CodDetVent As Integer = 0
    Public CodVeh As Integer = 0
    Public CodChof As Integer = 0
    Dim VentasSP As New clsVenta
    Dim VentasDatos As New eVenta
    Dim OperacionesSP As New clsOp
    Dim OperacionesDatos As New eOp
    Dim bandera As Boolean
    Dim minDate As DateTime = New DateTime(1753, 12, 12)
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
        If dgvOperaciones IsNot Nothing AndAlso dgvOperaciones.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Núm. de operación", "Núm. Detalle Venta", "Fecha", "Hora", "Destino", "Aclaración", "DNI Cliente", "Ape. Cliente", "Nom. Cliente", "Cant. Pasajeros", "Precio Operación", "DNI Chofer", "Ape. Chofer", "Nom. Chofer", "Vehiculo", "Matricula", "Capacidad Veh.", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvOperaciones.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvOperaciones.Columns(nombreColumna).Index
                    If columnIndex < dgvOperaciones.Columns.Count Then
                        dgvOperaciones.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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
        ColorCambio(btnResEli, "Cancelar", My.Resources.icons8_eliminar_24, Color.FromArgb(30, 63, 111), Color.FromArgb(15, 31, 55), Color.FromArgb(43, 88, 157))
    End Sub

    Private Sub EliminarColor()
        ControlTrue(btnResEli)
        ColorCambio(btnResEli, "Cancelar", My.Resources.icons8_eliminar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
    End Sub

    Private Sub GetOpAct()
        If CheckBox1.Checked Then
            FiltrarOperacionesPorFecha()
        Else
            dgvOperaciones.DataSource = OperacionesSP.GetOperaciones()
        End If
    End Sub

    Private Sub GetOpCan()
        If CheckBox1.Checked Then
            FiltrarOperacionesPorFecha()
        Else
            dgvOperaciones.DataSource = OperacionesSP.GetOperacionesCancel()
        End If
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtDetVent)
        ControlFalse(txtAcla)
        ControlFalse(txtPrecio)
        ControlFalse(txtCantPasaj)
        ControlFalse(txtChof)
        ControlFalse(txtVeh)
        'ControlFalse(ckbActFecha)
        ControlFalse(dtpFecha)
        ControlFalse(ckbActHora)
        ControlFalse(dtpHora)
        ControlFalse(btnGuaMod)
        ckbActHora.Checked = False
        'ckbActFecha.Checked = False
    End Sub

    Public Sub Determinar()
        If rbOpAct.Checked = True Then
            GetOpAct()
            'If dgvOperaciones IsNot Nothing AndAlso dgvOperaciones.Columns.Count > 0 Then
            '    If dgvOperaciones.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvOperaciones.Columns("Motivo Deshabilitar").Visible = False
            '    End If
            'End If
        Else
            GetOpCan()
            'If dgvOperaciones IsNot Nothing AndAlso dgvOperaciones.Columns.Count > 0 Then
            '    If dgvOperaciones.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvOperaciones.Columns("Motivo Deshabilitar").Visible = True
            '    End If
            'End If
        End If
    End Sub

    Public Sub Limpiar2()
        txtDetVent.Text = "Seleccione un servicio vendido."
        txtChof.Text = "Seleccione un vehículo."
        txtVeh.Text = "Seleccione un vehículo."
        ClearText(txtAcla)
        ClearText(txtPrecio)
        ClearText(txtCantPasaj)
        dtpFecha.Value = Now
        dtpHora.Value = Today
        dtpHora.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = "HH:mm"
        dtpHora.ShowUpDown = True
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtAcla.Focus()
        ControlTrue(txtAcla)
        ControlTrue(txtPrecio)
        ControlTrue(txtCantPasaj)
        ControlTrue(btnEleDetVent)
        ControlTrue(btnGuaMod)
        'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(ckbActFecha)
        ControlTrue(ckbActHora)
        ControlTrue(dtpFecha)
        ControlTrue(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        ControlFalse(btnResEli)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        DisabledColor()
        Limpiar()
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        Desactivar()
        ControlFalse(btnEleVeh)
        ControlFalse(btnEleDetVent)
        ControlFalse(btnGuaMod)
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodDetVent)
        ClearInt(CodOp)
        ClearInt(CodDetOp)
        ClearInt(CodDetVentSel)
        ClearString(NomServSelDetVent)
        ClearInt(CodVehSelVeh)
        ClearInt(CodChofSelVeh)
        ClearString(NomVehSelVeh)
        ClearString(NomApeChofSelVeh)
        'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(30, 63, 111)
        txtBusOp.Text = "Buscar"
        txtBusOp.ForeColor = Color.Gray
        Determinar()
        Limpiar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub

    Public Sub EliResOp()
        If btnResEli.Text = "Cancelar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una operación ¿Desea continuar?", "Cancelar operación número " & CodOp & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                OperacionesDatos.MotivoDes = MotivoDeshabilitar
                If OperacionesSP.BajaOperaciones(CodOp, CodUsu, OperacionesDatos) Then
                    MensajeNotificacion("Operación cancelada exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar la operación número " & CodOp & ".", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            Dim operacion As New clsOp
            Dim tabla As New DataTable
            tabla = operacion.VerificarOpDetVent(CodOp)
            If tabla(0)(0) = 2 Then
                If OperacionesSP.RecOperaciones(CodOp) Then
                    MensajeNotificacion("Operación restaurada exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar recuperar la operación número " & CodOp & ".", "Error.")
                End If
            Else
                MensajeNotificacion("La operación pertenece a un servicio vendido cancelado, por lo que el servicio vendido debe ser restaurado primero.", "Error.")
            End If
        End If
        PermisoADMIN = False
    End Sub

    Public Sub ModOp()
        If OperacionesSP.ModOp(OperacionesDatos) Then
            If CodOp = 0 Then
                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
            Else
                OperacionesDatos.CodOp = CodOp
                MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
            End If
        Else
            MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
        End If
    End Sub



    Public Sub MinimizarOperacionesT()
        Me.dgvOperaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOperaciones.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarOperacionesF()
        Me.dgvOperaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOperaciones.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Verifica si la celda pertenece a la columna que deseas formatear (por ejemplo, la columna 1)
        If e.ColumnIndex = 10 AndAlso e.Value IsNot Nothing Then
            ' Aplica el formato de moneda
            e.Value = String.Format("{0:C2}", e.Value)
            e.FormattingApplied = True
        End If
    End Sub
#End Region

#Region "Eventos"
    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmOpChofVeh.btnOp) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario()
    End Sub

    Private Sub pnlDatOp_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatOp.Paint
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
        New Point(0, pnlDatOp.Height),                    ' Punto de inicio
        New Point(pnlDatOp.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatOp.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatOp_Resize(sender As Object, e As EventArgs) Handles pnlDatOp.Resize
        pnlDatOp.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub frmOperaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Invalidate()
        Me.Update()
        rbOpAct.Checked = True
        GetOpAct()
        Cargar()
        HabilitarNo()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        dgvOperaciones.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvOperaciones.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        SetDoubleBuffered(dgvOperaciones)
        If frmPrincipal.bMax = True Then
            MinimizarOperacionesT()
        Else
            MinimizarOperacionesF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(30, 63, 111)
        AddHandler dgvOperaciones.CellFormatting, AddressOf DataGridView1_CellFormatting
        Me.Invalidate()
        Me.Update()
        frmMenu.RoundCornersBtn(rbOpAct, 10)
        frmMenu.RoundCornersBtn2(rbOpCan, 10)
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnEleVeh, 10)
        frmMenu.RoundButton(btnEleDetVent, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundButton(ckbActHora, 10)
        frmMenu.RoundButton(CheckBox1, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub rbOpAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Cancelar"
        ImprimirComprobanteToolStripMenuItem.Visible = True
    End Sub

    Private Sub dgvOperacionesDataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvOperaciones.DataBindingComplete
        If dgvOperaciones.Columns.Count > 0 Then
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 1).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 2).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 3).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 4).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 5).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 6).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 7).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 8).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 10).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 15).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 19).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 23).Visible = False
            dgvOperaciones.Columns(dgvOperaciones.Columns.Count - 24).Visible = False
        End If

        If rbOpAct.Checked Then
            For Each row As DataGridViewRow In dgvOperaciones.Rows
                If row.Cells("Fecha").Value IsNot Nothing AndAlso IsDate(row.Cells("Fecha").Value) Then
                    Dim fecha As DateTime = Convert.ToDateTime(row.Cells("Fecha").Value).Date ' Solo la parte de la fecha
                    Dim fechaActual As DateTime = DateTime.Now.Date ' Solo la parte de la fecha actual (sin horas)
                    Dim diasHastaFecha As Integer = (fecha - fechaActual).Days

                    ' Si es hoy o mañana (dentro de los próximos 1 días contando el actual)
                    If diasHastaFecha >= 0 AndAlso diasHastaFecha <= 1 Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(226, 80, 76)
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 54, 55) ' Cambiar color de selección
                        row.DefaultCellStyle.SelectionForeColor = Color.White
                        ' Si es entre 2 y 3 días (próximos días sin contar el primero)
                    ElseIf diasHastaFecha >= 2 AndAlso diasHastaFecha <= 3 Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 105, 97)
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 54, 55) ' Cambiar color de selección
                        row.DefaultCellStyle.SelectionForeColor = Color.White
                        ' Para los últimos días restantes (4 a 7 días)
                    ElseIf diasHastaFecha >= 4 AndAlso diasHastaFecha <= 7 Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 150, 136)
                        row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(198, 54, 55) ' Cambiar color de selección
                        row.DefaultCellStyle.SelectionForeColor = Color.White
                    End If
                End If
            Next
        End If



    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "   Nuevo" Then
            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            HabilitarNo()
        End If
    End Sub

    Private Sub dgvOperaciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOperaciones.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvOperaciones.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvOperaciones.Rows.Count Then
                    Dim row As DataGridViewRow = dgvOperaciones.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodOp = CInt(row.Cells(0)?.Value)
                        CodDetVent = CInt(row.Cells(1)?.Value) ' Actualiza el código del cliente seleccionado
                        txtDetVent.Text = row.Cells(4)?.Value?.ToString()
                        txtAcla.Text = row.Cells(5)?.Value?.ToString()
                        txtPrecio.Text = row.Cells(10)?.Value?.ToString()
                        txtCantPasaj.Text = row.Cells(9)?.Value?.ToString()
                        If row.Cells(12)?.Value?.ToString() = "" Or row.Cells(13)?.Value?.ToString() = "" Then
                            txtChof.Text = "Seleccione un vehículo."
                        Else
                            txtChof.Text = row.Cells(12)?.Value?.ToString() & " " & row.Cells(13)?.Value?.ToString()
                        End If
                        If row.Cells(14)?.Value?.ToString() = "" Then
                            txtVeh.Text = "Seleccione un vehículo."
                        Else
                            txtVeh.Text = row.Cells(14)?.Value?.ToString()
                        End If
                        If IsDBNull(row.Cells(21)?.Value) Then
                            ClearInt(CodChof)
                        Else
                            CodChof = CInt(row.Cells(21)?.Value)
                        End If
                        If IsDBNull(row.Cells(22)?.Value) Then
                            ClearInt(CodVeh)
                        Else
                            CodVeh = CInt(row.Cells(22)?.Value)
                        End If
                        If row.Cells(3)?.Value?.ToString() <> "" Then
                            ckbActHora.Checked = True
                            ControlTrue(dtpHora)
                            If dtpHora.Enabled Then
                                Dim horaString As String = row.Cells(3)?.Value?.ToString()
                                Dim hora As TimeSpan
                                If TimeSpan.TryParse(horaString, hora) Then
                                    dtpHora.Value = DateTime.Today.Add(hora)
                                Else
                                    dtpHora.Value = DateTime.Today
                                End If
                            End If
                        Else
                            ckbActHora.Checked = False
                            ControlFalse(dtpHora)
                        End If
                        If row.Cells(2)?.Value?.ToString() <> "" Then
                            ckbActFecha.Checked = True
                            If dtpFecha.Enabled Then
                                dtpFecha.Value = row.Cells(2)?.Value?.ToString()
                                If dtpFecha.Value.Year <= 2020 Then
                                    dtpFecha.Value = Today
                                End If
                            End If
                        Else
                            'ckbActFecha.Checked = False
                            ckbActHora.Checked = False
                            ControlFalse(dtpHora)
                            'ControlFalse(dtpFecha)
                        End If
                        ControlTrue(btnEleVeh)
                        ControlFalse(btnEleDetVent)
                        'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbOpCan.Checked Then
                    Desactivar()
                    ControlFalse(btnEleVeh)
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                End If
            End If
        End If
    End Sub

    Private Sub rbOpCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
        ImprimirComprobanteToolStripMenuItem.Visible = False
    End Sub

    Private Sub txtCantPasaj_TextChanged(sender As Object, e As EventArgs) Handles txtCantPasaj.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtCantPasaj_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantPasaj.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 2
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResOp()
            Else
                VarADMIN = 2
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatOp, ep)
        If banbl = True Then
            ReemplazarComaPorPunto(txtPrecio.Text)
            OperacionesDatos.CodOp = CodOp
            OperacionesDatos.CodDetVenta = CodDetVent
            OperacionesDatos.Aclaracion = txtAcla.Text
            If dtpFecha.Enabled = True Then
                OperacionesDatos.FechaOp = dtpFecha.Value.ToString("dd/MM/yyyy")
                If dtpHora.Enabled = True Then
                    OperacionesDatos.HoraOp = dtpHora.Value.ToString("HH:mm")
                Else
                    OperacionesDatos.HoraOp = ""
                End If
            Else
                OperacionesDatos.FechaOp = ""
                OperacionesDatos.HoraOp = ""
            End If
            OperacionesDatos.Valor = txtPrecio.Text
            OperacionesDatos.Pasajeros = txtCantPasaj.Text
            OperacionesDatos.CodChof = CodChof
            OperacionesDatos.CodVehiculo = CodVeh
            If txtPrecio.Text.StartsWith(".") OrElse txtPrecio.Text.StartsWith(",") Then
                ep.SetError(txtPrecio, "Ingresa un número antes del decimal.")
                Return
            End If
            If bandera = True Then
                If txtDetVent.Text = "Seleccione un servicio vendido." Then
                    ep.SetError(txtDetVent, "Debe seleccionar un servicio vendido.") 'no deberia salir en teoria, a menos que sea nuevo
                    Return
                End If
                If txtVeh.Text = "Seleccione un vehículo." Then
                    ep.SetError(txtVeh, "Debe seleccionar un vehículo.")
                    Return
                End If
                If txtChof.Text = "Seleccione un vehículo." Then
                    ep.SetError(txtChof, "Debe seleccionar un vehículo.")
                    Return
                End If
                If OperacionesSP.InsOp2(OperacionesDatos) Then
                    MensajeNotificacion("Operación grabado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Sucedio un error al intentar grabar la operación.", "Error.")
                End If
            Else
                If txtDetVent.Text = "Seleccione un servicio vendido." Then
                    ep.SetError(txtDetVent, "Debe seleccionar un servicio vendido.") 'no deberia salir en teoria, a menos que sea nuevo
                    Return
                End If
                If txtVeh.Text = "Seleccione un vehículo." Then
                    ep.SetError(txtVeh, "Debe seleccionar un vehículo.")
                    Return
                End If
                If txtChof.Text = "Seleccione un vehículo." Then
                    ep.SetError(txtChof, "Debe seleccionar un vehículo.")
                    Return
                End If
                If CodTpUsu = 2 Then
                    VarADMIN = 12
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    ModOp()
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco2(Me.pnlDatOp, ep)
        End If
    End Sub

    Private Sub btnEleVeh_Click(sender As Object, e As EventArgs) Handles btnEleVeh.Click
        Dim frmSelVeh As New frmSelVeh()
        frmSelVeh.ShowDialog()
        frmSelVeh.TopMost = True
    End Sub

    Private Sub btnEleDetVent_Click(sender As Object, e As EventArgs) Handles btnEleDetVent.Click
        Dim frmSelDetVent As New frmSelDetVent()
        frmSelDetVent.ShowDialog()
        frmSelDetVent.TopMost = True
    End Sub

    Private Sub ckbActFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActFecha.CheckedChanged

    End Sub

    Private Sub ckbActHora_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActHora.CheckedChanged
        If ckbActHora.Checked Then
            ckbActHora.Image = My.Resources.icons8_tickc_24
            ControlTrue(dtpHora)
        Else
            ckbActHora.Image = My.Resources.icons8_tickc_no_24
            ControlFalse(dtpHora)
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        FiltrarNoIntMonto(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        SoloIntMonto(sender, e)
    End Sub
#Region "Ocultar Panel"
    Private Sub frmOp_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDatOp_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatOp.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
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

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVOp_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVOp.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbOpAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbOpAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbOpCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbOpCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusOp_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusOp.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvOperaciones_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvOperaciones.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDetVent.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtAcla_MouseDown(sender As Object, e As MouseEventArgs) Handles txtAcla.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtPrecio_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPrecio.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtCantPasaj_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCantPasaj.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtChof_MouseDown(sender As Object, e As MouseEventArgs) Handles txtChof.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles txtVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub ckbActFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dtpFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub ckbActHora_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActHora.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dtpHora_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpHora.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnGuaMod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGuaMod.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnEleVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEleVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnEleDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEleDetVent.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub CheckBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles CheckBox2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub CheckBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles CheckBox3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label17_MouseDown(sender As Object, e As MouseEventArgs) Handles Label17.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label18_MouseDown(sender As Object, e As MouseEventArgs) Handles Label18.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub



    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbOpAct.Checked = True Then
                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpOpHCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = OperacionesSP.GetOperacionesCD()
                    reporte.RegisterData(dataTable, "MosOpCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpOpH)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = OperacionesSP.GetOperaciones()
                    reporte.RegisterData(dataTable, "MosOp")
                End If
                reporte.Prepare()
                reporte.Show()
            Else
                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpOpDCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = OperacionesSP.GetOperacionesCancelCD()
                    reporte.RegisterData(dataTable, "MosBajOpCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpOpD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = OperacionesSP.GetOperacionesCancel()
                    reporte.RegisterData(dataTable, "MosBajOp")
                End If
                reporte.Prepare()
                reporte.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al imprimir el reporte: " & ex.Message)
        Finally
            reporte.Dispose()
        End Try
    End Sub

    Private Sub FiltrarOperacionesPorFecha()
        Dim dt As DataTable
        If rbOpAct.Checked Then
            dt = OperacionesSP.GetOperaciones() ' Obtener todas las operaciones
        Else
            dt = OperacionesSP.GetOperacionesCancel() ' Obtener todas las operaciones
        End If
        Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
        ' Filtrar la tabla por fecha >= hoy
        Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                             Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                             Select row
        ' Crear un nuevo DataTable con las filas filtradas
        If filasFiltradas.Any() Then
            Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
            dgvOperaciones.DataSource = dtFiltrado
        Else
            dgvOperaciones.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
        End If
    End Sub

    Private Sub MostrarTodasLasOperaciones()
        Determinar()
        Cargar()
    End Sub

    Private Sub ImprimirComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirComprobanteToolStripMenuItem.Click
        If filaSeleccionada IsNot Nothing Then
            CodVentTabla = CInt(filaSeleccionada.Cells(23)?.Value)
            Dim reporte As New Report()
            Dim conexion As New clsConexion()
            Dim reportStream As IO.MemoryStream = Nothing
            Dim conexionData As String = conexion.GetConnectionString

            Try
                If rbOpAct.Checked = True Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.Comprobante)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS.", "Error.")
                        Return
                    End If

                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.Comprobante(CodVentTabla)
                    reporte.RegisterData(dataTable, "MosComprobante")
                    reporte.GetDataSource("MosComprobante").Enabled = True

                    Dim dataSource As FastReport.Data.DataSourceBase = reporte.GetDataSource("MosComprobante")
                    If dataSource IsNot Nothing Then
                        Debug.WriteLine("DataSource registrado correctamente")
                    Else
                        Debug.WriteLine("Error al registrar DataSource")
                    End If

                    Dim dataBand As FastReport.DataBand = CType(reporte.FindObject("dbd1"), FastReport.DataBand)
                    If dataBand IsNot Nothing Then
                        dataBand.DataSource = reporte.GetDataSource("MosComprobante")
                        Debug.WriteLine("DataSource asignado correctamente al DataBand")
                    Else
                        Debug.WriteLine("No se encontró el DataBand")
                    End If

                    reporte.Prepare()
                    reporte.Show()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al imprimir el reporte: " & ex.Message)
            Finally
                reporte.Dispose()
            End Try
        End If
    End Sub

    Private filaSeleccionada As DataGridViewRow

    Dim CodVentTabla As Integer

    Private Sub dgvOperaciones_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOperaciones.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvOperaciones.CurrentCell = dgvOperaciones.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvOperaciones.Rows(e.RowIndex)
                CodOpTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsOp.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Cancelar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVentTabla = filaSeleccionada.Cells(23).Value.ToString()
                If CodTpUsu = 2 Then
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                    VarADMIN = 18
                Else
                    VarADMIN = 18
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVentTabla = filaSeleccionada.Cells(23).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 19
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

    Public Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodOp = CInt(row.Cells(0)?.Value)
                        CodDetVent = CInt(row.Cells(1)?.Value) ' Actualiza el código del cliente seleccionado
                        txtDetVent.Text = row.Cells(4)?.Value?.ToString()
                        txtAcla.Text = row.Cells(5)?.Value?.ToString()
                        txtPrecio.Text = row.Cells(10)?.Value?.ToString()
                        txtCantPasaj.Text = row.Cells(9)?.Value?.ToString()
                        If row.Cells(12)?.Value?.ToString() = "" Or row.Cells(13)?.Value?.ToString() = "" Then
                            txtChof.Text = "Seleccione un vehículo."
                        Else
                            txtChof.Text = row.Cells(12)?.Value?.ToString() & " " & row.Cells(13)?.Value?.ToString()
                        End If
                        If row.Cells(14)?.Value?.ToString() = "" Then
                            txtVeh.Text = "Seleccione un vehículo."
                        Else
                            txtVeh.Text = row.Cells(14)?.Value?.ToString()
                        End If
                        If IsDBNull(row.Cells(21)?.Value) Then
                            ClearInt(CodChof)
                        Else
                            CodChof = CInt(row.Cells(21)?.Value)
                        End If
                        If IsDBNull(row.Cells(22)?.Value) Then
                            ClearInt(CodVeh)
                        Else
                            CodVeh = CInt(row.Cells(22)?.Value)
                        End If
                        If row.Cells(3)?.Value?.ToString() <> "" Then
                            ckbActHora.Checked = True
                            ControlTrue(dtpHora)
                            If dtpHora.Enabled Then
                                Dim horaString As String = row.Cells(3)?.Value?.ToString()
                                Dim hora As TimeSpan
                                If TimeSpan.TryParse(horaString, hora) Then
                                    dtpHora.Value = DateTime.Today.Add(hora)
                                Else
                                    dtpHora.Value = DateTime.Today
                                End If
                            End If
                        Else
                            ckbActHora.Checked = False
                            ControlFalse(dtpHora)
                        End If
                        If row.Cells(2)?.Value?.ToString() <> "" Then
                            ckbActFecha.Checked = True
                            If dtpFecha.Enabled Then
                                dtpFecha.Value = row.Cells(2)?.Value?.ToString()
                                If dtpFecha.Value.Year <= 2020 Then
                                    dtpFecha.Value = Today
                                End If
                            End If
                        Else
                            'ckbActFecha.Checked = False
                            ckbActHora.Checked = False
                            ControlFalse(dtpHora)
                            'ControlFalse(dtpFecha)
                        End If
                        ControlTrue(btnEleVeh)
                        ControlFalse(btnEleDetVent)
                        'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbOpCan.Checked Then
                    Desactivar()
                    ControlFalse(btnEleVeh)
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Modificar"
                    EliminarColor()
                End If
            End If
        End If
    End Sub

    Dim CodOpTabla As Integer

    Public Sub Cancelar()
        Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una operación ¿Desea continuar?", "Cancelar operación número " & CodOp & ".", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            OperacionesDatos.MotivoDes = MotivoDeshabilitar
            If OperacionesSP.BajaOperaciones(CodOp, CodUsu, OperacionesDatos) Then
                MensajeNotificacion("Operación cancelada exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar cancelar la operación número " & CodOp & ".", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar()
        Dim operacion As New clsOp
        Dim tabla As New DataTable
        tabla = operacion.VerificarOpDetVent(CodOp)
        If tabla(0)(0) = 2 Then
            If OperacionesSP.RecOperaciones(CodOp) Then
                MensajeNotificacion("Operación restaurada exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar la operación número " & CodOp & ".", "Error.")
            End If
        Else
            MensajeNotificacion("La operación pertenece a un servicio vendido cancelado, por lo que el servicio vendido debe ser restaurado primero.", "Error.")
        End If
    End Sub

    Public Sub Cancelar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una operación ¿Desea continuar?", "Cancelar operación número " & CodOpTabla & ".", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            OperacionesDatos.MotivoDes = MotivoDeshabilitar
            If OperacionesSP.BajaOperaciones(CodOpTabla, CodUsu, OperacionesDatos) Then
                MensajeNotificacion("Operación cancelada exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar cancelar la operación número " & CodOpTabla & ".", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        Dim operacion As New clsOp
        Dim tabla As New DataTable
        tabla = operacion.VerificarOpDetVent(CodOpTabla)
        If tabla(0)(0) = 2 Then
            If OperacionesSP.RecOperaciones(CodOpTabla) Then
                MensajeNotificacion("Operación restaurada exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar la operación número " & CodOpTabla & ".", "Error.")
            End If
        Else
            MensajeNotificacion("La operación pertenece a un servicio vendido cancelado, por lo que el servicio vendido debe ser restaurado primero.", "Error.")
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvOperaciones.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvOperaciones.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvOperaciones, rowIndex)
        End If
    End Sub

    Private Sub CheckBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckBox1.MouseClick
        OcultarPanel()
    End Sub

    Private Sub frmOp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmOpChofVeh.btnOp.BackColor = Color.FromArgb(30, 63, 111)
    End Sub




#Region "Buscar x Fecha"
    Public Sub Cargar()
        If txtBusOp.Text.Length = 0 Or txtBusOp.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbOpAct.Checked Then
                Dim dt As DataTable
                dt = OperacionesSP.BuscarOp(txtBusOp.Text) ' Obtener todas las operaciones
                If CheckBox1.Checked Then
                    Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
                    ' Filtrar la tabla por fecha >= hoy
                    Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                                         Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                                         Select row
                    ' Crear un nuevo DataTable con las filas filtradas
                    If filasFiltradas.Any() Then
                        Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
                        dgvOperaciones.DataSource = dtFiltrado
                    Else
                        dgvOperaciones.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
                    End If
                Else
                    Me.dgvOperaciones.DataSource = dt
                End If
            Else
                Dim dt As DataTable
                dt = OperacionesSP.BuscarOpBaja(txtBusOp.Text)
                If CheckBox1.Checked Then
                    Dim fechaActual As DateTime = DateTime.Now.Date
                    Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                                         Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                                         Select row
                    If filasFiltradas.Any() Then
                        Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
                        dgvOperaciones.DataSource = dtFiltrado
                    Else
                        dgvOperaciones.DataSource = Nothing
                    End If
                Else
                    Me.dgvOperaciones.DataSource = dt
                End If
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusOp_Enter(sender As Object, e As EventArgs) Handles txtBusOp.Enter
        If txtBusOp.Text = "Buscar" Then
            ClearText(txtBusOp)
            txtBusOp.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusOp_Leave(sender As Object, e As EventArgs) Handles txtBusOp.Leave
        If String.IsNullOrWhiteSpace(txtBusOp.Text) Then
            txtBusOp.Text = "Buscar"
            txtBusOp.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusOp_TextChanged(sender As Object, e As EventArgs) Handles txtBusOp.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusOp_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusOp.MouseClick
        If txtBusOp.Text = "Buscar" Then
            ClearText(txtBusOp)
            txtBusOp.ForeColor = Color.Black
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
        ControlTrue(txtBusOp)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusOp)
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

                    If PorCreacion = True Then
                        If rbOpAct.Checked Then
                            Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionFechaHasta(desde, hasta)
                        Else
                            Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionDesFechaHasta(desde, hasta)
                        End If

                    Else
                        If rbOpAct.Checked Then
                            Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServFechaHasta(desde, hasta)
                        Else
                            Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServDesFechaHasta(desde, hasta)
                        End If

                    End If


                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If PorCreacion = True Then
                            If rbOpAct.Checked Then
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionFechaHasta(desde, hasta)
                            Else
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionDesFechaHasta(desde, hasta)
                            End If

                        Else
                            If rbOpAct.Checked Then
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServFechaHasta(desde, hasta)
                            Else
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServDesFechaHasta(desde, hasta)
                            End If

                        End If
                    Else
                        DesdeDate()
                        If PorCreacion = True Then
                            If rbOpAct.Checked Then
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionFecha(desde)
                            Else
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionDesFecha(desde)
                            End If

                        Else
                            If rbOpAct.Checked Then
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServFecha(desde)
                            Else
                                Me.dgvOperaciones.DataSource = OperacionesSP.BuscarOperacionServDesFecha(desde)
                            End If

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

    Dim PorCreacion As Boolean = True

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox3.Checked = True Then
            PorCreacion = True
            CheckBox2.Image = My.Resources.icons8_tickc_24
            CheckBox3.Image = My.Resources.icons8_tickc_no_24
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.Click
        If CheckBox2.Checked = True Then
            PorCreacion = False
            CheckBox2.Checked = False
            CheckBox3.Image = My.Resources.icons8_tickc_24
            CheckBox2.Image = My.Resources.icons8_tickc_no_24
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Image = My.Resources.icons8_tickc_24
            FiltrarOperacionesPorFecha()
            DesactivarDate()
        Else
            CheckBox1.Image = My.Resources.icons8_tickc_no_24
            MostrarTodasLasOperaciones()
            ActivarDate()
        End If
    End Sub

    Public Sub ActivarDate()
        ControlTrue(btnBusxDia)
    End Sub

    Public Sub DesactivarDate()
        ControlFalse(btnBusxDia)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
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
        Dim rectFila As Rectangle = dgvOperaciones.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvOperaciones.Top + rectFila.Top + dgvOperaciones.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvOperaciones.Left, dgvOperaciones.Top + rectFila.Top + dgvOperaciones.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvOperaciones.Left, dgvOperaciones.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Num. de operación", CInt(filaSeleccionada.Cells(0)?.Value))
        dgvPanelDesp.Rows.Add("Num. Detalle Venta", CInt(filaSeleccionada.Cells(1)?.Value))
        dgvPanelDesp.Rows.Add("Aclaración", filaSeleccionada.Cells(5)?.Value.ToString())
        dgvPanelDesp.Rows.Add("Cant. Pasajeros", CInt(filaSeleccionada.Cells(9)?.Value))
        dgvPanelDesp.Rows.Add("Vehiculo", filaSeleccionada.Cells(14)?.Value.ToString())

        If filaSeleccionada.Cells(16).Value Is Nothing OrElse IsDBNull(filaSeleccionada.Cells(16).Value) Then
            dgvPanelDesp.Rows.Add("Capacidad Veh.", "")
        Else
            dgvPanelDesp.Rows.Add("Capacidad Veh.", CInt(filaSeleccionada.Cells(16).Value))
        End If






        If rbOpCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(17)?.Value.ToString)
        End If

        dgvPanelDesp.Rows.Add("Fecha de creación", filaSeleccionada.Cells(18)?.Value.ToString())

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