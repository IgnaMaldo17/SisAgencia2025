#Region "Imports"
Imports System.Net.Security
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport
Imports FastReport.Design.PageDesigners


#End Region

Public Class frmServ

#Region "Declaraciones"
    Public CodServ As Integer = 0
    Public CodProv As Integer = 0
    Dim ServiciosSP As New clsServ
    Dim ServiciosDatos As New eServ
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
        If dgvServicios IsNot Nothing AndAlso dgvServicios.Columns.Count > 0 Then
            Dim ordenColumnas As New List(Of String) From {"Número de servicio", "CUIT", "Razón social del proveedor", "Nick del proveedor", "Servicio", "Tipo de servicio", "Monto", "Descipción", "Motivo Deshabilitar", "Fecha de creación"}
            For Each nombreColumna As String In ordenColumnas
                If dgvServicios.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvServicios.Columns(nombreColumna).Index
                    If columnIndex < dgvServicios.Columns.Count Then
                        dgvServicios.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un servicio ¿Desea continuar?", "Deshabilitar servicio.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            ServiciosDatos.MotivoDes = MotivoDeshabilitar
            If ServiciosSP.BajaServicios(CodServTabla, CodUsu, ServiciosDatos) Then
                MensajeNotificacion("Servicio deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al servicio.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        Dim servicio As New clsServ
        Dim tabla As New DataTable
        tabla = servicio.VerificarProvServ(CodServTabla)
        If tabla(0)(0) = 2 Then
            If ServiciosSP.RecServicios(CodServTabla) Then
                MensajeNotificacion("Servicio recuperado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el servicio.", "Error.")
            End If
        Else
            MensajeNotificacion("El servicio pertenece a un proveedor eliminado, por lo que el proveedor debe ser restaurado primero.", "Error.")
        End If
    End Sub

    Public Sub EliResServ()
        If btnResEli.Text = "Deshabilitar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un servicio ¿Desea continuar?", "Deshabilitar servicio " & txtNomServ.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                ServiciosDatos.MotivoDes = MotivoDeshabilitar
                If ServiciosSP.BajaServicios(CodServ, CodUsu, ServiciosDatos) Then
                    MensajeNotificacion("Servicio deshabilitado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar deshabilitar al servicio " & txtNomServ.Text & ".", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            Dim servicio As New clsServ
            Dim tabla As New DataTable
            tabla = servicio.VerificarProvServ(CodServ)
            If tabla(0)(0) = 2 Then
                If ServiciosSP.RecServicios(CodServ) Then
                    MensajeNotificacion("Servicio recuperado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar recuperar el servicio " & txtNomServ.Text & ".", "Error.")
                End If
            Else
                MensajeNotificacion("El servicio pertenece a un proveedor eliminado, por lo que el proveedor debe ser restaurado primero.", "Error.")
            End If
        End If
        PermisoADMIN = False
    End Sub

    Public Sub CargaCmbTpServ()
        cmbTpServ.DataSource = ServiciosSP.GetTpServicios()
        cmbTpServ.ValueMember = "ID"
        cmbTpServ.DisplayMember = "NOMBRE"
        cmbTpServ.SelectedIndex = -1
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

    Private Sub GetServAct()
        dgvServicios.DataSource = ServiciosSP.GetServicios()

    End Sub

    Private Sub GetServCan()
        dgvServicios.DataSource = ServiciosSP.GetServiciosCancel()
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtProv)
        ControlFalse(txtNomServ)
        ControlFalse(cmbTpServ)
        ControlFalse(txtPrecio)
        ControlFalse(txtDes)
        ControlFalse(btnGuaMod)
    End Sub

    Public Sub Determinar()
        If rbServAct.Checked = True Then
            GetServAct()
            If dgvServicios IsNot Nothing AndAlso dgvServicios.Columns.Count > 0 Then
                'If dgvServicios.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvServicios.Columns("Motivo Deshabilitar").Visible = False
                '    'If frmPrincipal.bMax = True Then
                '    '    dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                '    'Else
                '    '    dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '    'End If
                'End If
            End If
        Else
            GetServCan()
            If dgvServicios IsNot Nothing AndAlso dgvServicios.Columns.Count > 0 Then
                'If dgvServicios.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvServicios.Columns("Motivo Deshabilitar").Visible = True
                '    'dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'End If
            End If
        End If

        If frmPrincipal.bMax = True Then
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Public Sub Limpiar2()
        ClearText(txtProv)
        ClearText(txtNomServ)
        ClearText(txtPrecio)
        ClearText(txtDes)
    End Sub

    Private Sub HabilitarbBase()
        ep.Clear()
        bandera = True
        txtNomServ.Focus()
        'frmServProv.btnServ.BackColor = Color.FromArgb(43, 88, 157)
        ControlFalse(btnResEli)
        VerPanel(btnGuaMod)
        ControlTrue(btnGuaMod)
        ControlFalse(txtProv)
        btnGuaMod.Text = "Guardar"
        ControlTrue(cmbTpServ)
        ControlTrue(txtPrecio)
        ControlTrue(txtDes)
        ControlTrue(btnSelProv)
        ControlTrue(btnSelProv)
        VerPanel(btnSelProv)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        Limpiar()
        cmbTpServ.SelectedIndex = -1
    End Sub

    Private Sub HabilitarNuevo()
        HabilitarbBase()
        ServdesdeProv = False
        ControlTrue(txtNomServ)
        DisabledColor()
        txtProv.Text = "Seleccione un proveedor."
    End Sub

    Public Sub HabilitarDesdeProv()
        HabilitarbBase()
        EliminarColor()
        txtProv.Text = RazonSocialSelProv
        CodProv = CodProvSelProv
        txtBusServ.Text = "Buscar"
        txtBusServ.ForeColor = Color.Gray
        Determinar()
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        txtNomServ.Focus()
        ControlFalse(btnResEli)
        ControlFalse(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        MinimizarPanel(btnSelProv)
        ControlFalse(btnSelProv)
        ControlFalse(txtNomServ)
        ControlFalse(cmbTpServ)
        cmbTpServ.SelectedIndex = -1
        ControlFalse(txtPrecio)
        ControlFalse(txtDes)
        ControlFalse(cmbTpServ)
        VerPanel(txtProv)
        Limpiar()
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearString(RazonSocialSelProv)
        ClearInt(CodProvSelProv)
        ClearString(textosincoma)
        ServdesdeProv = False
        ClearInt(CodServ)
        ClearInt(CodProv)
        'frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
        txtBusServ.Text = "Buscar"
        txtBusServ.ForeColor = Color.Gray
        Determinar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub

    Public Sub Cargar()
        If txtBusServ.Text.Length = 0 Or txtBusServ.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbServAct.Checked Then
                Me.dgvServicios.DataSource = ServiciosSP.BuscarServicios(txtBusServ.Text)
            Else
                Me.dgvServicios.DataSource = ServiciosSP.BuscarServiciosBaja(txtBusServ.Text)
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarServicioT()
        Me.dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServicios.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub
    Public Sub MinimizarServicioF()
        Me.dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServicios.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Verifica si la celda pertenece a la columna que deseas formatear (por ejemplo, la columna 1)
        If e.ColumnIndex = 6 AndAlso e.Value IsNot Nothing Then
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
        frmPrincipal.IluminarBoton(frmServProv.btnServ) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario()
    End Sub

    Private Sub frmServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvServicios.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvServicios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        rbServAct.Checked = True
        GetServAct()
        Cargar()
        CargaCmbTpServ()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        If ServdesdeProv = True Then
            HabilitarDesdeProv()
        Else
            HabilitarNo()
        End If
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvServicios)
        If frmPrincipal.bMax = True Then
            MinimizarServicioT()
        Else
            MinimizarServicioF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        'frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
        AddHandler dgvServicios.CellFormatting, AddressOf DataGridView1_CellFormatting
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnSelProv, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundButton(Button1, 10)
        frmMenu.RoundCornersBtn(rbServAct, 10)
        frmMenu.RoundCornersBtn2(rbServCan, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatServ_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatServ.Paint
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
        New Point(0, pnlDatServ.Height),                    ' Punto de inicio
        New Point(pnlDatServ.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatServ.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatServ_Resize(sender As Object, e As EventArgs) Handles pnlDatServ.Resize
        pnlDatServ.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbServAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbServAct.CheckedChanged
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

    Private Sub dgvServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicios.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgvServicios.SelectedCells.Count > 0 Then
                HabilitarNuevo()
                ControlFalse(txtProv)
                VerPanel(txtProv)
                MinimizarPanel(btnSelProv)
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvServicios.Rows.Count Then
                    Dim row As DataGridViewRow = dgvServicios.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodServ = CInt(row.Cells(0)?.Value)
                        txtProv.Text = row.Cells(2)?.Value?.ToString()
                        txtNomServ.Text = row.Cells(4)?.Value?.ToString()
                        cmbTpServ.SelectedValue = row.Cells(10)?.Value?.ToString()
                        txtPrecio.Text = row.Cells(6)?.Value?.ToString()
                        'frmServProv.btnServ.BackColor = Color.FromArgb(43, 88, 157)
                        txtDes.Text = row.Cells(7)?.Value?.ToString()
                        CodProv = CInt(row.Cells(11)?.Value)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbServCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                End If
                If rbServCan.Checked = True Then
                    MinimizarPanel(btnSelProv)
                Else
                    VerPanel(btnSelProv)
                    ControlTrue(btnSelProv)
                End If
            End If
        End If
    End Sub

    Private Sub rbServCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbServCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
    End Sub

    Private Sub dgvServicios_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvServicios.DataBindingComplete
        If dgvServicios.Columns.Count > 0 Then
            dgvServicios.Columns(dgvServicios.Columns.Count - 1).Visible = False
            dgvServicios.Columns(dgvServicios.Columns.Count - 2).Visible = False
            dgvServicios.Columns(dgvServicios.Columns.Count - 4).Visible = False
            dgvServicios.Columns(dgvServicios.Columns.Count - 5).Visible = False
            dgvServicios.Columns(dgvServicios.Columns.Count - 12).Visible = False
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        FiltrarNoIntMonto(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        SoloIntMonto(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 5
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResServ()
            Else
                VarADMIN = 5
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatServ, ep)
        Dim servicio As New clsServ
        Dim cliente As New clsCli
        Dim tabla As New DataTable
        tabla = servicio.VerificarCombo(cmbTpServ.SelectedValue)
        If tabla(0)(0) = 2 Then
            If banbl = True Then
                ReemplazarComaPorPunto(txtPrecio.Text)
                ServiciosDatos.CodServ = CodServ
                ServiciosDatos.CodProv = CodProv
                ServiciosDatos.RSProveedor = txtProv.Text
                ServiciosDatos.NomServ = txtNomServ.Text
                ServiciosDatos.CodTpServ = cmbTpServ.SelectedValue
                ServiciosDatos.Monto = textosincoma
                ServiciosDatos.Descripcion = txtDes.Text
                ServiciosDatos.IdAlta = CodUsu
                If txtPrecio.Text.StartsWith(".") OrElse txtPrecio.Text.StartsWith(",") Then
                    ep.SetError(txtPrecio, "Ingresa un número antes del decimal.")
                    Return
                End If
                If bandera = True Then
                    If txtProv.Text = "Seleccione un proveedor." Then
                        ep.SetError(txtProv, "Debe seleccionar un proveedor.")
                        Return
                    End If
                    If ServiciosSP.InsServ(ServiciosDatos) Then
                        MensajeNotificacion("Servicio grabado exitosamente.", "Éxito.")
                        'frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Sucedió un error al intentar grabar el servicio.", "Error.")
                    End If
                Else
                    If ServiciosSP.ModServ(ServiciosDatos) Then
                        If CodServ = 0 Then
                            MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                        Else
                            ServiciosDatos.CodServ = CodServ
                            MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                            'frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
                            HabilitarNo()
                            Determinar()
                        End If
                    Else
                        MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                    End If
                End If
            ElseIf banbl = False Then
                CampoBlanco2(Me.pnlDatServ, ep)
            End If
        Else
            ep.SetError(cmbTpServ, "El tipo de servicio es incorrecto.")
        End If
    End Sub

    Private Sub btnSelProv_Click(sender As Object, e As EventArgs) Handles btnSelProv.Click
        Dim frmSelProv As New frmSelProv()
        frmSelProv.ShowDialog()
        frmSelProv.TopMost = True
    End Sub

    Private Sub frmServ_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#Region "Ocultar Panel"
    Private Sub frmServ_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDatServ_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatServ.MouseDown
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

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtProv_MouseDown(sender As Object, e As MouseEventArgs) Handles txtProv.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtNomServ_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNomServ.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub cmbTpServ_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbTpServ.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtPrecio_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPrecio.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtDes_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDes.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVServ_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVServ.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbServAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbServAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbServCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbServCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusServ_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusServ.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvServicios_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvServicios.MouseDown
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

    Private Sub btnSelProv_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSelProv.MouseDown
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
            If rbServAct.Checked = True Then
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpServH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ServiciosSP.GetServicios()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosServ")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpServD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ServiciosSP.GetServiciosCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajServ")
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
    Dim CodServTabla As Integer


    Private Sub dgvServicios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvServicios.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvServicios.CurrentCell = dgvServicios.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvServicios.Rows(e.RowIndex)
                CodServTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsServ.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodServTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 26
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 26
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodServTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 27
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
        If dgvServicios.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvServicios.SelectedCells(0).RowIndex
            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvServicios, rowIndex)
        End If
    End Sub

    Private Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                ControlFalse(txtProv)
                VerPanel(txtProv)
                MinimizarPanel(btnSelProv)
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodServ = CInt(row.Cells(0)?.Value)
                        txtProv.Text = row.Cells(2)?.Value?.ToString()
                        txtNomServ.Text = row.Cells(4)?.Value?.ToString()
                        cmbTpServ.SelectedValue = row.Cells(10)?.Value?.ToString()
                        txtPrecio.Text = row.Cells(6)?.Value?.ToString()
                        'frmServProv.btnServ.BackColor = Color.FromArgb(43, 88, 157)
                        txtDes.Text = row.Cells(7)?.Value?.ToString()
                        CodProv = CInt(row.Cells(11)?.Value)
                    End If
                End If
                bandera = False 'si es mod es false
                If rbServCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                Else
                    btnGuaMod.Text = "Modificar"
                    EliminarColor()
                End If
                If rbServCan.Checked = True Then
                    MinimizarPanel(btnSelProv)
                Else
                    VerPanel(btnSelProv)
                    ControlTrue(btnSelProv)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CodTpUsu = 2 Then
            VarADMIN = 51
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            Dim frmContraseña As New frmAgrTpServ()
            frmContraseña.ShowDialog()
            frmContraseña.TopMost = True
        End If
    End Sub


#End Region
#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusServ_Enter(sender As Object, e As EventArgs) Handles txtBusServ.Enter
        If txtBusServ.Text = "Buscar" Then
            ClearText(txtBusServ)
            txtBusServ.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusServ_Leave(sender As Object, e As EventArgs) Handles txtBusServ.Leave
        If String.IsNullOrWhiteSpace(txtBusServ.Text) Then
            txtBusServ.Text = "Buscar"
            txtBusServ.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusServ_TextChanged(sender As Object, e As EventArgs) Handles txtBusServ.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusServ_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusServ.MouseClick
        If txtBusServ.Text = "Buscar" Then
            ClearText(txtBusServ)
            txtBusServ.ForeColor = Color.Black
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
        ControlTrue(txtBusServ)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusServ)
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
                    If rbServAct.Checked Then
                        Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioFechaHasta(desde, hasta)
                    Else
                        Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioDesFechaHasta(desde, hasta)
                    End If
                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbServAct.Checked Then
                            Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioFechaHasta(desde, hasta)
                        Else
                            Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioDesFechaHasta(desde, hasta)
                        End If
                    Else
                        DesdeDate()
                        If rbServAct.Checked Then
                            Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioFecha(desde)
                        Else
                            Me.dgvServicios.DataSource = ServiciosSP.BuscarServicioDesFecha(desde)
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
        Dim rectFila As Rectangle = dgvServicios.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvServicios.Top + rectFila.Top + dgvServicios.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvServicios.Left, dgvServicios.Top + rectFila.Top + dgvServicios.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvServicios.Left, dgvServicios.Top + rectFila.Top - pnlDespDGV.Height)
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

        dgvPanelDesp.Rows.Add("Número de servicio", CInt(filaSeleccionada.Cells(0)?.Value))
        dgvPanelDesp.Rows.Add("Descripción", filaSeleccionada.Cells(7)?.Value.ToString())

        If rbServCan.Checked = True Then
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

End Class