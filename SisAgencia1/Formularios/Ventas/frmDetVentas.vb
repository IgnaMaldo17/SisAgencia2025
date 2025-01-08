#Region "Imports"
Imports System.Net.Security
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport

#End Region

Public Class frmDetVentas

#Region "Declaraciones"
    Public CodDetVent As Integer = 0
    Public CodVenta As Integer = 0
    Dim VentasSP As New clsVenta
    Dim VentasDatos As New eVenta
    Dim bandera As Boolean
    Dim BusxCod As Boolean
    Dim minDate As DateTime = New DateTime(1753, 12, 12)
    Public CodServ As Integer = 0
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
        If dgvDetVentas IsNot Nothing AndAlso dgvDetVentas.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número Venta", "Número Detalle", "DNI Cliente", "Apellido", "Nombre", "Teléfonos Cliente", "Proveedor", "Servicio", "Tipo", "Cantidad de personas", "Precio Unitario", "Precio", "Fecha", "Hora", "Observaciones", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvDetVentas.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvDetVentas.Columns(nombreColumna).Index
                    If columnIndex < dgvDetVentas.Columns.Count Then
                        dgvDetVentas.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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

    Private Sub DisabledBusColor()
        ColorCambio(btnBusxVent, "Buscar por Venta", My.Resources.icons8_buscar_24, Color.FromArgb(30, 63, 111), Color.FromArgb(15, 31, 55), Color.FromArgb(43, 88, 157))
        ControlTrue(txtBusDetVent)
    End Sub

    Private Sub EliminarBusColor()
        ColorCambio(btnBusxVent, "Cancelar Busca", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusDetVent)
    End Sub

    Private Sub GetDetVentAct()
        If CheckBox1.Checked Then
            FiltrarOperacionesPorFecha()
        Else
            dgvDetVentas.DataSource = VentasSP.GetDetVentas()
        End If

    End Sub

    Private Sub GetDetVentCan()
        If CheckBox1.Checked Then
            FiltrarOperacionesPorFecha()
        Else
            dgvDetVentas.DataSource = VentasSP.GetDetVentasCancel()
        End If

    End Sub

    Private Sub Desactivar()
        ControlFalse(txtCodVent)
        ControlFalse(txtNomServ)
        ControlFalse(txtNomCli)
        ControlFalse(txtCantPer)
        ControlFalse(txtNotas)
        ControlFalse(ckbActFecha)
        ControlFalse(dtpFecha)
        ControlFalse(ckbActHora)
        ControlFalse(dtpHora)
        ControlFalse(btnGuaMod)
        ckbActHora.Checked = False
        'ckbActFecha.Checked = False
    End Sub

    Public Sub Determinar()
        If rbDetVentAct.Checked = True Then
            GetDetVentAct()
            'If dgvDetVentas IsNot Nothing AndAlso dgvDetVentas.Columns.Count > 0 Then
            '    If dgvDetVentas.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvDetVentas.Columns("Motivo Deshabilitar").Visible = False
            '    End If
            'End If
        Else
            GetDetVentCan()
            'If dgvDetVentas IsNot Nothing AndAlso dgvDetVentas.Columns.Count > 0 Then
            '    If dgvDetVentas.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvDetVentas.Columns("Motivo Deshabilitar").Visible = True
            '    End If
            'End If
        End If



    End Sub

    Public Sub Limpiar2()
        txtCodVent.Text = "Seleccione una venta."
        txtNomServ.Text = "Seleccione un servicio."
        txtNomCli.Text = "Seleccione una venta."
        ClearText(txtCantPer)
        ClearText(txtNotas)
        dtpFecha.Value = Now
        dtpHora.Value = Today
        dtpHora.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = "HH:mm"
        dtpHora.ShowUpDown = True
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "dd/MM/yyyy"
    End Sub

    Public Sub HabilitarNuevoBase()
        ep.Clear()
        bandera = True
        txtCantPer.Focus()
        ControlFalse(btnResEli)
        ControlTrue(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        'frmVenCli.btnDetVent.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtCantPer)
        ControlTrue(txtNotas)
        ControlTrue(dtpFecha)
        ControlTrue(ckbActHora)
        'ControlFalse(ckbActHora)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        Limpiar()
    End Sub

    Private Sub HabilitarNuevo()
        HabilitarNuevoBase()
        ControlTrue(btnEleVent)
        ControlFalse(btnEleServ)
    End Sub

    Public Sub HabilitarDesdeVent()
        txtNomCli.Focus()
        HabilitarNuevoBase()
        BusxCod = True
        ControlFalse(btnEleVent)
        ControlTrue(btnEleServ)
        ControlFalse(txtCodVent)
        ControlFalse(txtNomServ)
        ControlFalse(txtNomCli)
        BusxCod = True
        txtNomCli.Text = NomApeClienteDetVent
        EliminarColor()
        BuscarxCod()
        txtBusDetVent.Text = CodVentBus
        CodVenta = CodVentaMod
        txtCodVent.Text = CodVenta
        txtBusDetVent.Text = CodVentBus
        txtBusDetVent.ForeColor = Color.Black
    End Sub

    Public Sub HabilitarNoBase()
        ActivarDate()
        ControlTrue(btnBusxVent)
        CheckBox1.Enabled = True
        ep.Clear()
        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        Desactivar()
        ControlFalse(btnEleServ)
        ControlFalse(btnEleVent)
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodVenta)
        'frmVenCli.btnDetVent.BackColor = Color.FromArgb(30, 63, 111)
        txtBusDetVent.Text = "Buscar"
        txtBusDetVent.ForeColor = Color.Gray
        Determinar()
        bandera = False
        ClearInt(CodServ)
        ClearInt(CodServSelServ)
        ClearString(NomServSelServ)
        Limpiar()
        DefaultBusColor()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Public Sub HabilitarNo()
        HabilitarNoBase()
        DisabledBusColor()
    End Sub

    Public Sub HabilitarNo2()
        HabilitarNoBase()
        DisabledBusColor()
        ClearInt(CodVentaMod)
        ClearString(NomApeClienteDetVent)
        BusxCod = False
        DetVentdesdeVent = False
    End Sub

    Public Sub BuscarxCod()
        CheckBox1.Enabled = False
        CheckBox1.Checked = False
        ControlFalse(txtBusDetVent)
        EliminarBusColor()
        DesactivarDate()
    End Sub




    Public Sub BuscarxCodDes()
        CheckBox1.Enabled = True

        'frmVenCli.btnDetVent.BackColor = Color.FromArgb(30, 63, 111)
        ControlTrue(txtBusDetVent)
        DisabledBusColor()
        BusxCod = False
        ClearInt(CodVentBus)
        ActivarDate()
    End Sub

    Public Sub Cargar()
        If BusxCod = True Then
            If rbDetVentAct.Checked Then
                Me.dgvDetVentas.DataSource = VentasSP.BuscarCodVenta(CodVentBus)
            Else
                Me.dgvDetVentas.DataSource = VentasSP.BuscarCodVentaBaja(CodVentBus)
            End If
            BuscarxCod()
        Else
            If txtBusDetVent.Text.Length = 0 Or txtBusDetVent.ForeColor = Color.Gray Then
                Determinar()
            Else
                If rbDetVentAct.Checked Then
                    Dim dt As DataTable
                    dt = VentasSP.BuscarDetVenta(txtBusDetVent.Text)
                    If CheckBox1.Checked Then
                        Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
                        ' Filtrar la tabla por fecha >= hoy
                        Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                                             Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                                             Select row
                        ' Crear un nuevo DataTable con las filas filtradas
                        If filasFiltradas.Any() Then
                            Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
                            dgvDetVentas.DataSource = dtFiltrado
                        Else
                            dgvDetVentas.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
                        End If
                    Else
                        Me.dgvDetVentas.DataSource = dt
                    End If
                Else
                    Dim dt As DataTable
                    dt = VentasSP.BuscarDetVentaBaja(txtBusDetVent.Text)
                    If CheckBox1.Checked Then
                        Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
                        ' Filtrar la tabla por fecha >= hoy
                        Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                                             Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                                             Select row
                        ' Crear un nuevo DataTable con las filas filtradas
                        If filasFiltradas.Any() Then
                            Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
                            dgvDetVentas.DataSource = dtFiltrado
                        Else
                            dgvDetVentas.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
                        End If
                    Else
                        Me.dgvDetVentas.DataSource = dt
                    End If
                End If
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarDetVentasT()
        Me.dgvDetVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetVentas.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarDetVentasF()
        Me.dgvDetVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetVentas.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub
#End Region

#Region "Eventos"
    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmVenCli.btnDetVent) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario
    End Sub

    Private Sub frmDetVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Enabled = True
        rbDetVentAct.Checked = True
        GetDetVentAct()
        If DetVentdesdeVent = True Then
            HabilitarDesdeVent()
        Else
            HabilitarNo()
        End If
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        Cargar()
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvDetVentas)
        SetDoubleBuffered(Me)
        dgvDetVentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvDetVentas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        If frmPrincipal.bMax = True Then
            MinimizarDetVentasT()
        Else
            MinimizarDetVentasF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        AddHandler dgvDetVentas.CellFormatting, AddressOf DataGridView1_CellFormatting
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnEleServ, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnEleVent, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundButton(ckbActHora, 10)
        frmMenu.RoundCornersBtn(rbDetVentAct, 10)
        frmMenu.RoundCornersBtn2(rbDetVentCan, 10)
        frmMenu.RoundButton(btnBusxVent, 10)
        frmMenu.RoundButton(CheckBox1, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
        ActivarDate()
        ControlTrue(btnBusxVent)
    End Sub

    Private Sub frmDetVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatDetVent_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatDetVent.Paint
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
        New Point(0, pnlDatDetVent.Height),                    ' Punto de inicio
        New Point(pnlDatDetVent.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatDetVent.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatDetVent_Resize(sender As Object, e As EventArgs) Handles pnlDatDetVent.Resize
        pnlDatDetVent.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbDetVentAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbDetVentAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Cancelar"
        ImprimirComprobanteToolStripMenuItem.Visible = True
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Verifica si la celda pertenece a la columna que deseas formatear (por ejemplo, la columna 1)
        If e.ColumnIndex = 11 AndAlso e.Value IsNot Nothing Then
            ' Aplica el formato de moneda
            e.Value = String.Format("{0:C2}", e.Value)
            e.FormattingApplied = True
        End If
        If e.ColumnIndex = 10 AndAlso e.Value IsNot Nothing Then
            ' Aplica el formato de moneda
            e.Value = String.Format("{0:C2}", e.Value)
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub dgvDetVentas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        If dgvDetVentas.Columns.Count > 0 Then
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 1).Visible = False
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "   Nuevo" Then
            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            HabilitarNo()
        End If
        BusxCod = False
    End Sub

    Public Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodVenta = CInt(row.Cells(0)?.Value)
                        CodDetVent = CInt(row.Cells(1)?.Value) ' Actualiza el código del cliente seleccionado
                        txtCodVent.Text = CInt(row.Cells(0)?.Value)
                        CodServ = CInt(row.Cells(18)?.Value)
                        txtCantPer.Text = row.Cells(9)?.Value?.ToString()
                        txtNotas.Text = row.Cells(14)?.Value?.ToString()
                        txtNomCli.Text = row.Cells(3)?.Value?.ToString() & " " & row.Cells(4)?.Value?.ToString()
                        txtNomServ.Text = row.Cells(7)?.Value?.ToString()
                        If row.Cells(13)?.Value?.ToString() <> "" Then
                            ckbActHora.Checked = True
                            ControlTrue(dtpHora)
                            If dtpHora.Enabled Then
                                Dim horaString As String = row.Cells(13)?.Value?.ToString()
                                Dim hora As TimeSpan
                                If TimeSpan.TryParse(horaString, hora) Then
                                    ' Combina la hora con la fecha de hoy
                                    dtpHora.Value = DateTime.Today.Add(hora)
                                Else
                                    dtpHora.Value = DateTime.Today ' O maneja el error de otra manera
                                End If
                            End If
                        Else
                            'ckbActHora.Checked = False
                            'ControlFalse(dtpHora)
                        End If
                        If row.Cells(12)?.Value?.ToString() <> "" Then
                            ckbActFecha.Checked = True
                            If dtpFecha.Enabled Then
                                dtpFecha.Value = row.Cells(12)?.Value?.ToString()
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
                        ControlTrue(btnEleServ)
                        ControlFalse(btnEleVent)
                        'frmVenCli.btnDetVent.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbDetVentCan.Checked Then
                    Desactivar()
                    ControlFalse(btnEleServ)
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                End If
            End If
        End If
    End Sub

    Private Sub dgvDetVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetVentas.CellDoubleClick
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvDetVentas.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvDetVentas.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvDetVentas, rowIndex)
        End If
    End Sub

    Private Sub rbDetVentCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbDetVentCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
        ImprimirComprobanteToolStripMenuItem.Visible = False
    End Sub

    Private Sub dgvDetVentasDataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDetVentas.DataBindingComplete
        If dgvDetVentas.Columns.Count > 0 Then
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 1).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 2).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 19).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 5).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 13).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 11).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 14).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 4).Visible = False
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 10).Visible = False
        End If
        If rbDetVentAct.Checked Then
            For Each row As DataGridViewRow In dgvDetVentas.Rows
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

    Private Sub txtCantPer_TextChanged(sender As Object, e As EventArgs) Handles txtCantPer.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtCantPer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantPer.KeyPress
        SoloInt(sender, e)
    End Sub


    Public Sub Cancelar2()
        Dim venta As New clsVenta
        Dim tabla As New DataTable
        tabla = venta.CantidadDetVent(CodVentTabla)
        If tabla(0)(0) = 1 Then
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar el único servicio vendido (y su posible operación) de la venta número " & CodVentTabla & ". Si lo cancela, la venta también será cancelada.", "Cancelar servicio vendido y la venta número " & CodVentTabla & ".", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultado = DialogResult.Yes Then
                VentasDatos.MotivoDes = MotivoDeshabilitar
                If VentasSP.BajaDetVentas(CodDetVentTabla, CodUsu, VentasDatos) Then
                    If VentasSP.BajaVentas(CodVentTabla, CodUsu, VentasDatos) Then
                        MensajeNotificacion("Servicio vendido cancelado exitosamente.", "Éxito.")
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Hubo un error al intentar cancelar la venta número " & CodVentTabla & ".", "Error.")
                    End If
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar el servicio vendido de la venta número " & CodVentTabla & ".", "Error.")
                End If
            End If
        Else
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar un servicio vendido y sus posibles operaciones activas ¿Desea continuar?", "Cancelar servicio vendido de la venta número " & CodVentTabla & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                VentasDatos.MotivoDes = MotivoDeshabilitar
                If VentasSP.BajaDetVentas(CodDetVentTabla, CodUsu, VentasDatos) Then
                    MensajeNotificacion("Servicio vendido cancelado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar el servicio vendido de la venta número " & CodVentTabla & ".", "Error.")
                End If
            End If
        End If
    End Sub

    Public Sub Cancelar()
        Dim venta As New clsVenta
        Dim tabla As New DataTable
        tabla = venta.CantidadDetVent(CodVenta)
        If tabla(0)(0) = 1 Then
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar el único servicio vendido (y su posible operación) de la venta número " & txtCodVent.Text & ". Si lo cancela, la venta también será cancelada.", "Cancelar servicio vendido " & txtNomServ.Text & " y la venta número " & txtCodVent.Text & ".", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultado = DialogResult.Yes Then
                VentasDatos.MotivoDes = MotivoDeshabilitar
                If VentasSP.BajaDetVentas(CodDetVent, CodUsu, VentasDatos) Then
                    If VentasSP.BajaVentas(CodVenta, CodUsu, VentasDatos) Then
                        MensajeNotificacion("Servicio vendido cancelado exitosamente.", "Éxito.")
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Hubo un error al intentar cancelar la venta número " & txtCodVent.Text & ".", "Error.")
                    End If
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar el servicio vendido " & txtNomServ.Text & " de la venta número " & txtCodVent.Text & ".", "Error.")
                End If
            End If
        Else
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar un servicio vendido y sus posibles operaciones activas ¿Desea continuar?", "Cancelar servicio vendido " & txtNomServ.Text & " de la venta número " & txtCodVent.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                VentasDatos.MotivoDes = MotivoDeshabilitar
                If VentasSP.BajaDetVentas(CodDetVent, CodUsu, VentasDatos) Then
                    MensajeNotificacion("Servicio vendido cancelado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar el servicio vendido " & txtNomServ.Text & " de la venta número " & txtCodVent.Text & ".", "Error.")
                End If
            End If
        End If
    End Sub

    Public Sub Restaurar()
        Dim venta As New clsVenta
        Dim tabla As New DataTable
        tabla = venta.VerificarVentDetVent(CodDetVent)
        If tabla(0)(0) = 2 Then
            If VentasSP.RecDetVentas(CodDetVent) Then
                MensajeNotificacion("Servicio vendido restaurado exitosamente, sus operaciones deberán restaurarse manualmente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el servicio vendido de la venta número " & CodVentTabla & ".", "Error.")
            End If
        Else
            MensajeNotificacion("El servicio vendido pertenece a una venta cancelada, por lo que la venta debe ser restaurada primero.", "Error.")
        End If
    End Sub

    Public Sub Restaurar2()
        Dim venta As New clsVenta
        Dim tabla As New DataTable
        tabla = venta.VerificarVentDetVent(CodDetVentTabla)
        If tabla(0)(0) = 2 Then
            If VentasSP.RecDetVentas(CodDetVentTabla) Then
                MensajeNotificacion("Servicio vendido restaurado exitosamente, sus operaciones deberán restaurarse manualmente.", "Éxito.")
                HabilitarNo()
                Determinar()
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el servicio vendido de la venta número " & CodVentTabla & ".", "Error.")
            End If
        Else
            MensajeNotificacion("El servicio vendido pertenece a una venta cancelada, por lo que la venta debe ser restaurada primero.", "Error.")
        End If
    End Sub

    Public Sub EliResDetVent()
        If btnResEli.Text = "Cancelar" Then
            Cancelar()
        ElseIf btnResEli.Text = "Restaurar" Then
            Restaurar()
        End If
        PermisoADMIN = False
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
            VarADMIN = 9
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResDetVent()
            Else
                VarADMIN = 9
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatDetVent, ep)
        If banbl = True Then
            VentasDatos.CodDetVent = CodDetVent
            VentasDatos.CodVenta = CodVenta
            VentasDatos.CodServ = CodServ
            'If dtpFecha.Enabled = True Then
            VentasDatos.FechaServ = dtpFecha.Value.ToString("dd/MM/yyyy")
            If dtpHora.Enabled = True Then
                VentasDatos.Hora = dtpHora.Value.ToString("HH:mm")
            Else
                VentasDatos.Hora = ""
            End If
            'Else
            '    VentasDatos.FechaServIns = minDate
            '    VentasDatos.HoraIns = minDate
            'End If
            VentasDatos.Observaciones = txtNotas.Text
            VentasDatos.CanPersonas = txtCantPer.Text
            If bandera = True Then
                If txtCodVent.Text = "Seleccione una venta." Then
                    ep.SetError(txtNomServ, "Debe seleccionar una venta.") 'no deberia salir en teoria, a menos que sea nuevo
                    Return
                End If
                If txtNomServ.Text = "Seleccione un servicio." Then
                    ep.SetError(txtNomServ, "Debe seleccionar un servicio.")
                    Return
                End If
                If VentasSP.InsDetVent2(VentasDatos) Then
                    MensajeNotificacion("Servicio vendido grabado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                Else
                    MensajeNotificacion("Sucedió un error al intentar grabar el servicio vendido.", "Error.")
                End If
            Else
                If VentasSP.ModDetVent(VentasDatos) Then
                    If CodDetVent = 0 Then
                        MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                    Else
                        VentasDatos.CodDetVent = CodDetVent
                        MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                        HabilitarNo2()
                        Determinar()
                    End If
                Else
                    MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco2(Me.pnlDatDetVent, ep)
        End If
    End Sub

    Private Sub btnEleVent_Click(sender As Object, e As EventArgs) Handles btnEleVent.Click
        SelVentdesdeBtnEle = True
        Dim frmSelVent As New frmSelVent()
        frmSelVent.ShowDialog()
        frmSelVent.TopMost = True
    End Sub

    Private Sub btnEleServ_Click(sender As Object, e As EventArgs) Handles btnEleServ.Click
        Dim frmSelServ As New frmSelServ()
        frmSelServ.ShowDialog()
        frmSelServ.TopMost = True
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

    Private Sub btnBusxVent_Click(sender As Object, e As EventArgs) Handles btnBusxVent.Click
        If CodVentBus = 0 Or btnBusxVent.BackColor = Color.FromArgb(30, 63, 111) Then
            BusxCod = True
            Dim frmSelVent As New frmSelVent()
            frmSelVent.ShowDialog()
            frmSelVent.TopMost = True
        Else
            BuscarxCodDes()
            BusxCod = False
            ClearInt(CodVentBus)
            ClearInt(CodVentaMod)
            DetVentdesdeVent = False
            txtBusDetVent.Text = "Buscar"
            txtBusDetVent.ForeColor = Color.Gray
            Cargar()
        End If
    End Sub

    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbDetVentAct.Checked = True Then

                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpDetVentHCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                        Return
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetDetVentasCD()
                    reporte.RegisterData(dataTable, "MosDetVentCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpDetVentH)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                        Return
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetDetVentas()
                    reporte.RegisterData(dataTable, "MosDetVent")
                End If
                reporte.Prepare()
                reporte.Show()
            Else
                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpDetVentDCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                        Return
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetDetVentasCancelCD()
                    reporte.RegisterData(dataTable, "MosBajDetVentCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpDetVentD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                        Return
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetDetVentasCancel()
                    reporte.RegisterData(dataTable, "MosBajDetVent")
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
#Region "Ocultar Panel"
    Private Sub frmDetVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDatDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatDetVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDGVDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVDetVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbDetVentAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbDetVentAct.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbDetVentCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbDetVentCan.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnBusxVent_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBusxVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtBusDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusDetVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub dgvDetVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvDetVentas.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnNuevo_MouseDown(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtCodVent_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCodVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtNomServ_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNomServ.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtNomCli_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNomCli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtCantPer_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCantPer.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub ckbActFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActFecha.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub dtpFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFecha.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub ckbActHora_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActHora.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub dtpHora_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpHora.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtNotas_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNotas.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnGuaMod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGuaMod.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnEleServ_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEleServ.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnEleVent_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEleVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub FiltrarOperacionesPorFecha()
        Dim dt As DataTable
        If rbDetVentAct.Checked Then
            dt = VentasSP.GetDetVentas() ' Obtener todas las operaciones
        Else
            dt = VentasSP.GetDetVentasCancel() ' Obtener todas las operaciones
        End If
        Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
        ' Filtrar la tabla por fecha >= hoy
        Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                             Where Convert.ToDateTime(row("Fecha")) >= fechaActual
                             Select row
        ' Crear un nuevo DataTable con las filas filtradas
        If filasFiltradas.Any() Then
            Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
            dgvDetVentas.DataSource = dtFiltrado
        Else
            dgvDetVentas.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
        End If
    End Sub

    Private Sub MostrarTodasLasOperaciones()
        Determinar()
        Cargar()
    End Sub



    Private filaSeleccionada As DataGridViewRow
    Dim CodVentTabla As Integer
    Dim CodDetVentTabla As Integer

    Private Sub dgvDetVentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDetVentas.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvDetVentas.CurrentCell = dgvDetVentas.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvDetVentas.Rows(e.RowIndex)
                CodVentTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                CodDetVentTabla = CInt(filaSeleccionada.Cells(1)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsDetVent.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmVenCli.btnDetVent.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvDetVentas.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvDetVentas.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvDetVentas, rowIndex)
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Cancelar" Then
            If filaSeleccionada IsNot Nothing Then
                CodDetVentTabla = filaSeleccionada.Cells(1).Value.ToString()
                If CodTpUsu = 2 Then
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                    VarADMIN = 16
                Else
                    VarADMIN = 16
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodDetVentTabla = filaSeleccionada.Cells(1).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 17
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

    Private Sub ImprimirComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirComprobanteToolStripMenuItem.Click
        If filaSeleccionada IsNot Nothing Then
            CodVentTabla = CInt(filaSeleccionada.Cells(0)?.Value)
            Dim reporte As New Report()
            Dim conexion As New clsConexion()
            Dim reportStream As IO.MemoryStream = Nothing
            Dim conexionData As String = conexion.GetConnectionString

            Try
                If rbDetVentAct.Checked = True Then
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

                    'Dim textObject12 As FastReport.TextObject = DirectCast(reporte.FindObject("Text29"), FastReport.TextObject)
                    'If textObject12 IsNot Nothing Then
                    '    textObject12.Text = "XD"
                    'End If
                    ' Establecer el valor del parámetro antes de preparar el reporte

                    ' Preparar y mostrar el reporte
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

    Private Sub CheckBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckBox1.MouseClick
        OcultarPanel()
    End Sub
#End Region

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusDetVent_Enter(sender As Object, e As EventArgs) Handles txtBusDetVent.Enter
        If txtBusDetVent.Text = "Buscar" Then
            ClearText(txtBusDetVent)
            txtBusDetVent.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusDetVent_Leave(sender As Object, e As EventArgs) Handles txtBusDetVent.Leave
        If String.IsNullOrWhiteSpace(txtBusDetVent.Text) Then
            txtBusDetVent.Text = "Buscar"
            txtBusDetVent.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusDetVent_TextChanged(sender As Object, e As EventArgs) Handles txtBusDetVent.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusDetVent_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusDetVent.MouseClick
        If txtBusDetVent.Text = "Buscar" Then
            ClearText(txtBusDetVent)
            txtBusDetVent.ForeColor = Color.Black
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
        ControlTrue(txtBusDetVent)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusDetVent)
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
                        If rbDetVentAct.Checked Then
                            Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaFechaHasta(desde, hasta)
                        Else
                            Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaDesFechaHasta(desde, hasta)
                        End If
                    Else
                        If rbDetVentAct.Checked Then
                            Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServFechaHasta(desde, hasta)
                        Else
                            Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServDesFechaHasta(desde, hasta)
                        End If
                    End If


                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If PorCreacion = True Then
                            If rbDetVentAct.Checked Then
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaFechaHasta(desde, hasta)
                            Else
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaDesFechaHasta(desde, hasta)
                            End If
                        Else
                            If rbDetVentAct.Checked Then
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServFechaHasta(desde, hasta)
                            Else
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServDesFechaHasta(desde, hasta)
                            End If
                        End If
                    Else
                        DesdeDate()
                        If PorCreacion = True Then
                            If rbDetVentAct.Checked Then
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaFecha(desde)
                            Else
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaDesFecha(desde)
                            End If
                        Else
                            If rbDetVentAct.Checked Then
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServFecha(desde)
                            Else
                                Me.dgvDetVentas.DataSource = VentasSP.BuscarDetVentaServDesFecha(desde)
                            End If
                        End If
                    End If
                End If
                CancelarBusColor()
                OcultarFecha(pnlBusxFecha, btnBusxFecha)
                BuscarxCodDes()
                ControlFalse(btnBusxVent)
            End If
        Else
            Determinar()
            Cargar()
            DefaultBusColor()
            ControlTrue(btnBusxVent)
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
            btnBusxVent.Enabled = False
            DesactivarDate()
        Else
            CheckBox1.Image = My.Resources.icons8_tickc_no_24
            MostrarTodasLasOperaciones()
            btnBusxVent.Enabled = True
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

    Private Sub pnlBusxFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBusxFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub CheckBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles CheckBox3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnBusxFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBusxFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub CheckBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles CheckBox2.MouseDown
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

    Private Sub Label17_MouseDown(sender As Object, e As MouseEventArgs) Handles Label17.MouseDown
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


    Private Sub AjustarTamanoPanelYDataGrid()
        ' Ajustar la altura del DataGridView en función de la cantidad de filas y el alto de cada fila
        Dim totalAltoFilas As Integer = dgvPanelDesp.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        Dim altoHeader As Integer = dgvPanelDesp.ColumnHeadersHeight
        Dim nuevoAlto As Integer = totalAltoFilas + altoHeader

        ' Asignar el nuevo alto al DataGridView
        dgvPanelDesp.Height = nuevoAlto

        pnlDespDGV.Height = dgvPanelDesp.Height + 6 ' Reducir margen vertical

        ' Obtener la posición de la fila seleccionada en el DataGridView
        Dim rectFila As Rectangle = dgvDetVentas.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvDetVentas.Top + rectFila.Top + dgvDetVentas.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvDetVentas.Left, dgvDetVentas.Top + rectFila.Top + dgvDetVentas.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvDetVentas.Left, dgvDetVentas.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Número de venta", CInt(filaSeleccionada.Cells(0)?.Value))
        dgvPanelDesp.Rows.Add("Teléfonos del cliente", filaSeleccionada.Cells(5)?.Value.ToString())
        dgvPanelDesp.Rows.Add("Proveedor", filaSeleccionada.Cells(6)?.Value.ToString())
        dgvPanelDesp.Rows.Add("Tipo de servicio", filaSeleccionada.Cells(8)?.Value.ToString())
        dgvPanelDesp.Rows.Add("Cantidad de personas", CInt(filaSeleccionada.Cells(9)?.Value))
        dgvPanelDesp.Rows.Add("Observaciones", filaSeleccionada.Cells(14)?.Value.ToString())

        If rbDetVentCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(15)?.Value.ToString)
        End If

        dgvPanelDesp.Rows.Add("Cuenta con operación", filaSeleccionada.Cells(17)?.Value.ToString())

        AjustarTamanoPanelYDataGrid()

        ' Traer el panel al frente
        pnlDespDGV.BringToFront()
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

End Class