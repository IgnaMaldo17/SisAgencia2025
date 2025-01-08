#Region "Imports"
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports Datos
Imports Entidades
Imports FastReport
#End Region

Public Class frmVentas

#Region "Declaraciones"
    Dim CodVenta As Integer = 0
    Dim VentasSP As New clsVenta
    Dim VentaDatos As New eVenta
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
        If dgvVentas IsNot Nothing AndAlso dgvVentas.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de venta", "DNI", "Apellido", "Nombre", "Monto total", "Moneda", "Medio de Pago", "Núm. Transferencia", "Cantidad de Serv. Vendidos", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvVentas.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvVentas.Columns(nombreColumna).Index
                    If columnIndex < dgvVentas.Columns.Count Then
                        dgvVentas.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
                    End If
                End If
            Next
        End If
    End Sub

    Public Sub Cancelar()
        Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una venta, por tanto, todos los servicios vendidos en dicha venta y los ingresos no se mostrarán en la caja, ¿Desea continuar?", "Cancelar Venta", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            VentaDatos.MotivoDes = MotivoDeshabilitar
            If VentasSP.BajaVentas(CodVenta, CodUsu, VentaDatos) Then
                HabilitarNo()
                Determinar()
                MensajeNotificacion("La venta ha sido cancelada.", "Éxito.")
            Else
                MensajeNotificacion("Hubo un error al intentar cancelar la venta.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar()
        If VentasSP.RecVentas(CodVenta) Then
            HabilitarNo()
            Determinar()
            MensajeNotificacion("La venta ha recuperada. Sus servicios deben ser restaurados manualmente.", "Éxito.")
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar la venta.", "Error.")
        End If
    End Sub

    Public Sub Cancelar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una venta, por tanto, todos los servicios vendidos en dicha venta y los ingresos no se mostrarán en la caja, ¿Desea continuar?", "Cancelar Venta", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            VentaDatos.MotivoDes = MotivoDeshabilitar
            If VentasSP.BajaVentas(CodVentTabla, CodUsu, VentaDatos) Then
                HabilitarNo()
                Determinar()
                MensajeNotificacion("La venta ha sido cancelada.", "Éxito.")
            Else
                MensajeNotificacion("Hubo un error al intentar cancelar la venta.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        If VentasSP.RecVentas(CodVentTabla) Then
            HabilitarNo()
            Determinar()
            MensajeNotificacion("La venta ha recuperada. Sus servicios deben ser restaurados manualmente.", "Éxito.")
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar la venta.", "Error.")
        End If
    End Sub



    Public Sub EliResVent()
        If btnResEli.Text = "Cancelar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por cancelar una venta, por tanto, todos los servicios vendidos en dicha venta y los ingresos no se mostrarán en la caja, ¿Desea continuar?", "Cancelar Venta", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                VentaDatos.MotivoDes = MotivoDeshabilitar
                If VentasSP.BajaVentas(CodVenta, CodUsu, VentaDatos) Then
                    HabilitarNo()
                    Determinar()
                    MensajeNotificacion("La venta ha sido cancelada.", "Éxito.")
                Else
                    MensajeNotificacion("Hubo un error al intentar cancelar la venta.", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            If VentasSP.RecVentas(CodVenta) Then
                HabilitarNo()
                Determinar()
                MensajeNotificacion("La venta ha recuperada. Sus servicios deben ser restaurados manualmente.", "Éxito.")
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar la venta.", "Error.")
            End If
        End If
        PermisoADMIN = False
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



    Private Sub GetVentAct()
        dgvVentas.DataSource = VentasSP.GetVentas()
    End Sub

    Private Sub GetVentCan()
        dgvVentas.DataSource = VentasSP.GetVentasCancel()
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtDNI)
        ControlFalse(txtNom)
    End Sub

    Public Sub Determinar()
        If rbVentAct.Checked = True Then
            GetVentAct()
            If dgvVentas IsNot Nothing AndAlso dgvVentas.Columns.Count > 0 Then
                'If dgvVentas.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvVentas.Columns("Motivo Deshabilitar").Visible = False
                'End If
                'If dgvVentas.Columns.Contains("Cantidad de Serv. Vendidos") Then
                '    dgvVentas.Columns("Cantidad de Serv. Vendidos").Visible = True
                'End If
            End If
        Else
            GetVentCan()
            If dgvVentas IsNot Nothing AndAlso dgvVentas.Columns.Count > 0 Then
                'If dgvVentas.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvVentas.Columns("Motivo Deshabilitar").Visible = True
                'End If
                'If dgvVentas.Columns.Contains("Cantidad de Serv. Vendidos") Then
                '    dgvVentas.Columns("Cantidad de Serv. Vendidos").Visible = False
                'End If
            End If
        End If

        If frmPrincipal.bMax = True Then
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub


    Private Sub Limpiar2()
        ClearText(txtDNI)
        ClearText(txtNom)
    End Sub

    Private Sub HabilitarMod()
        ep.Clear()
        txtDNI.Focus()
        ControlTrue(btnResEli)
        ControlTrue(btnModVent)
        ControlTrue(btnNuevo)
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        DisabledColor()
        Limpiar2()
        'frmVenCli.btnVenV.BackColor = Color.FromArgb(43, 88, 157)
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        txtDNI.Focus()
        ControlFalse(btnResEli)
        ControlFalse(btnModVent)
        ControlFalse(btnNuevo)
        Desactivar()
        Limpiar()
        DisabledColor()
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        'frmVenCli.btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        DefaultBusColor()
        txtBusVent.Text = "Buscar"
        txtBusVent.ForeColor = Color.Gray
        ClearInt(CodVenta)
        btnNuevo.Image = My.Resources.icons8_cancelar_nuevo_30
        Determinar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub





    Public Sub MinimizarVentasT()
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentas.RowHeadersWidth = 15
        PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarVentasF()
        dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentas.RowHeadersWidth = 15
        PictureBox1.Location = New Point(mini)
    End Sub
#End Region

#Region "Eventos"
    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmVenCli.btnVenV) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario
    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvVentas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvVentas)
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        If frmPrincipal.bMax = True Then
            MinimizarVentasT()
        Else
            MinimizarVentasF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        rbVentAct.Checked = True
        GetVentAct()
        HabilitarNo()
        Cargar()
        'frmVenCli.btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        AddHandler dgvVentas.CellFormatting, AddressOf DataGridView1_CellFormatting
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnModVent, 10)
        frmMenu.RoundButton(Label21, 10)
        frmMenu.RoundButton(Button1, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundCornersBtn(rbVentAct, 10)
        frmMenu.RoundCornersBtn2(rbVentCan, 10)
        frmMenu.RoundButton(btnBusxDia, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatVent_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatVent.Paint
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
        New Point(0, pnlDatVent.Height),                    ' Punto de inicio
        New Point(pnlDatVent.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatVent.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatVent_Resize(sender As Object, e As EventArgs) Handles pnlDatVent.Resize
        pnlDatVent.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Verifica si la celda pertenece a la columna que deseas formatear (por ejemplo, la columna 1)
        If e.ColumnIndex = 4 AndAlso e.Value IsNot Nothing Then
            ' Aplica el formato de moneda
            e.Value = String.Format("{0:C2}", e.Value)
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub rbVentAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Cancelar"
        ImprimirComprobanteToolStripMenuItem.Visible = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        HabilitarNo()
    End Sub

    Private Sub dgvVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvVentas.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarMod()
                If rbVentCan.Checked Then
                    RestaurarColor()
                    ControlFalse(btnModVent)
                Else
                    ControlTrue(btnModVent)
                    EliminarColor()
                End If
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvVentas.Rows.Count Then
                    Dim row As DataGridViewRow = dgvVentas.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodVentBus = CInt(row.Cells(0)?.Value)
                        CodVentaMod = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        CodVenta = CInt(row.Cells(0)?.Value)
                        txtNom.Text = row.Cells(2)?.Value?.ToString() & " " & row.Cells(3)?.Value?.ToString()
                        NomCli = row.Cells(3)?.Value?.ToString()
                        NomApeClienteDetVent = txtNom.Text
                        'frmVenCli.btnVenV.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rbCliVent_CheckedChanged(sender As Object, e As EventArgs) Handles rbVentCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
        ImprimirComprobanteToolStripMenuItem.Visible = False
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
            VarADMIN = 10
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResVent()
            Else
                VarADMIN = 10
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub



    Private Sub btnModVent_Click(sender As Object, e As EventArgs) Handles btnModVent.Click
        DetVentdesdeVent = True
        AbrirFormPanel(frmDetVentas, frmVenCli.pnlVenCli)
        VerPanel(frmVenCli.btnDetVent)
        ActualizarUltimosFormularios("frmDetVentas")
        frmDetVentas.HabilitarDesdeVent()
        HabilitarNo()
        frmDetVentas.IluminarFormulario()
    End Sub










#Region "Ocultar Panel"
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs)
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDatVent_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatVent.MouseDown
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

    Private Sub txtDNI_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDNI.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtNom_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNom.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnModVent_MouseDown(sender As Object, e As MouseEventArgs) Handles btnModVent.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label11_MouseDown(sender As Object, e As MouseEventArgs) Handles Label14.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label15.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label16.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label17.MouseDown
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

    Private Sub Label13_MouseDown(sender As Object, e As MouseEventArgs) Handles Label18.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub ckbActHasta_MouseDown(sender As Object, e As MouseEventArgs)
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label19.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label20.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label21.MouseDown
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

    Private Sub frmVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtBusVent_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusVent.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDGVVent_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVVent.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbVentAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbVentAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbVentCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbVentCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub dgvVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvVentas.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private filaSeleccionada As DataGridViewRow
    Dim CodVentTabla As Integer

    Private Sub dgvVentas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVentas.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvVentas.CurrentCell = dgvVentas.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvVentas.Rows(e.RowIndex)
                CodVentTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsVenta.Show(Cursor.Position)
            End If
        End If
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Cancelar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVentTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                    VarADMIN = 20
                Else
                    VarADMIN = 20
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodVentTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 21
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
        If dgvVentas.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvVentas.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvVentas, rowIndex)
        End If
    End Sub

    Public Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarMod()
                If rbVentCan.Checked Then
                    RestaurarColor()
                    ControlFalse(btnModVent)
                Else
                    ControlTrue(btnModVent)
                    EliminarColor()
                End If
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodVentBus = CInt(row.Cells(0)?.Value)
                        CodVentaMod = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        CodVenta = CInt(row.Cells(0)?.Value)
                        txtNom.Text = row.Cells(2)?.Value?.ToString() & " " & row.Cells(3)?.Value?.ToString()
                        NomCli = row.Cells(3)?.Value?.ToString()
                        NomApeClienteDetVent = txtNom.Text
                        'frmVenCli.btnVenV.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ImprimirComprobanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirComprobanteToolStripMenuItem.Click
        If filaSeleccionada IsNot Nothing Then
            CodVentTabla = CInt(filaSeleccionada.Cells(0)?.Value)
            Dim reporte As New Report()
            Dim conexion As New clsConexion()
            Dim reportStream As IO.MemoryStream = Nothing
            Dim conexionData As String = conexion.GetConnectionString
            Try
                If rbVentAct.Checked = True Then
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

    Private Sub frmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmVenCli.btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        'VerPanel(frmVenCli.btnDetVent)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            ActualizarUltimosFormularios("frmAgrVent")
            AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
            frmAgrVent.IluminarFormulario()
            Return
        End If

        VenderConVenCliAbierto = True

        Dim resultado As DialogResult = MessageBox.Show("Está por iniciar una venta a un cliente ya registrado, sin embargo, puede simular una venta sin cliente ¿Desea iniciar una simulación de venta en vez de seleccionar un cliente?", "Iniciar venta.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            AgrSimulacion = True
            frmAgrVent.txtCli.Text = "Simulación sin Cliente."
            CodCliVender = 0
            AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
            ActualizarUltimosFormularios("frmAgrVent")
        ElseIf resultado = DialogResult.No Then
            VendesdeVent = True
            Dim frmSelCli As New frmSelCli()
            frmSelCli.ShowDialog()
            frmSelCli.TopMost = True
        End If
        ActualizarUltimosFormularios("frmAgrVent")
        frmVenCli.tVent.Stop()
        frmAgrVent.IluminarFormulario()
    End Sub

    Private Sub dgvVentas_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvVentas.DataBindingComplete
        If dgvVentas.Columns.Count > 0 Then
            dgvVentas.Columns(dgvVentas.Columns.Count - 1).Visible = False
            dgvVentas.Columns(dgvVentas.Columns.Count - 2).Visible = False
            dgvVentas.Columns(dgvVentas.Columns.Count - 3).Visible = False
            dgvVentas.Columns(dgvVentas.Columns.Count - 4).Visible = False
            dgvVentas.Columns(dgvVentas.Columns.Count - 11).Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Image = My.Resources.icons8_tickc_24
            FiltrarVentasPorFecha()
        Else
            CheckBox1.Image = My.Resources.icons8_tickc_no_24
            MostrarTodasLasVentas()
        End If
    End Sub

    Private Sub FiltrarVentasPorFecha()
        Dim dt As DataTable
        If rbVentAct.Checked Then
            dt = VentasSP.GetVentas() ' Obtener todas las operaciones
        Else
            dt = VentasSP.GetVentasCancel() ' Obtener todas las operaciones
        End If
        Dim fechaActual As DateTime = DateTime.Now.Date ' Obtener la fecha actual (solo parte de la fecha)
        ' Filtrar la tabla por fecha >= hoy
        Dim filasFiltradas = From row As DataRow In dt.AsEnumerable()
                             Where Convert.ToDateTime(row("Fecha de creación")) >= fechaActual
                             Select row
        ' Crear un nuevo DataTable con las filas filtradas
        If filasFiltradas.Any() Then
            Dim dtFiltrado As DataTable = filasFiltradas.CopyToDataTable()
            dgvVentas.DataSource = dtFiltrado
        Else
            dgvVentas.DataSource = Nothing ' Si no hay filas, vaciar el DataGridView
        End If
    End Sub

    Private Sub MostrarTodasLasVentas()
        Determinar()
        Cargar()
    End Sub

    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbVentAct.Checked = True Then
                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpVentHCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetVentasCD()
                    reporte.RegisterData(dataTable, "MosVentCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpVentH)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetVentas()
                    reporte.RegisterData(dataTable, "MosVent")
                End If
                reporte.Prepare()
                reporte.Show()
            Else
                If CheckBox1.Checked Then
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpVentDCD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetVentasCancelCD()
                    reporte.RegisterData(dataTable, "MosBajVentCD")
                Else
                    If conexionData.Contains("SISAGENCIA") Then
                        reportStream = New IO.MemoryStream(My.Resources.rpVentD)
                    Else
                        MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    End If
                    reporte.Load(reportStream)
                    Dim dataTable As DataTable = VentasSP.GetVentasCancel()
                    reporte.RegisterData(dataTable, "MosBajVent")
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

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

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
        ControlTrue(txtBusVent)
        ventasFiltradas = Nothing
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ventasFiltradas = Me.dgvVentas.DataSource
        'ControlFalse(txtBusVent)
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
                    If rbVentAct.Checked Then
                        Me.dgvVentas.DataSource = VentasSP.BuscarVentaFechaHasta(desde, hasta)
                    Else
                        Me.dgvVentas.DataSource = VentasSP.BuscarVentaDesFechaHasta(desde, hasta)
                    End If
                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbVentAct.Checked Then
                            Me.dgvVentas.DataSource = VentasSP.BuscarVentaFechaHasta(desde, hasta)
                        Else
                            Me.dgvVentas.DataSource = VentasSP.BuscarVentaDesFechaHasta(desde, hasta)
                        End If
                    Else
                        DesdeDate()
                        If rbVentAct.Checked Then
                            Me.dgvVentas.DataSource = VentasSP.BuscarVentaFecha(desde)
                        Else
                            Me.dgvVentas.DataSource = VentasSP.BuscarVentaDesFecha(desde)
                        End If
                    End If
                End If
                CancelarBusColor()
                OcultarFecha(pnlBusxFecha, btnBusxFecha)
            End If
        Else
            DefaultBusColor()
            Determinar()
            Cargar()
        End If
    End Sub

    Private Sub txtBusVent_Enter(sender As Object, e As EventArgs) Handles txtBusVent.Enter
        If txtBusVent.Text = "Buscar" Then
            ClearText(txtBusVent)
            txtBusVent.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusVent_Leave(sender As Object, e As EventArgs) Handles txtBusVent.Leave
        If ventasFiltradas IsNot Nothing AndAlso ventasFiltradas.Rows.Count > 0 Then
            If String.IsNullOrWhiteSpace(txtBusVent.Text) Then
                txtBusVent.Text = "Buscar"
                txtBusVent.ForeColor = Color.Gray
                dgvVentas.DataSource = ventasFiltradas
            End If
        Else
            If String.IsNullOrWhiteSpace(txtBusVent.Text) Then
                txtBusVent.Text = "Buscar"
                txtBusVent.ForeColor = Color.Gray
                Determinar()
            End If
        End If
    End Sub

    Private Sub txtBusVent_TextChanged(sender As Object, e As EventArgs) Handles txtBusVent.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusVent_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusVent.MouseClick
        If txtBusVent.Text = "Buscar" Then
            ClearText(txtBusVent)
            txtBusVent.ForeColor = Color.Black
        Else
            Cargar()
        End If
    End Sub

    Public Sub Cargar()
        If ventasFiltradas IsNot Nothing AndAlso ventasFiltradas.Rows.Count > 0 Then
            Dim filtroTexto As String = txtBusVent.Text.ToLower()
            Dim tablaFiltrada As DataTable = ventasFiltradas.Clone() ' Clona la estructura de la tabla
            For Each fila As DataRow In ventasFiltradas.Rows
                Dim coincide As Boolean = fila("Número de venta").ToString().Contains(filtroTexto) OrElse
                                  fila("DNI").ToString().Contains(filtroTexto) OrElse
                                  fila("Apellido").ToString().ToLower().Contains(filtroTexto) OrElse
                                  fila("Nombre").ToString().ToLower().Contains(filtroTexto) OrElse
                                  fila("Monto total").ToString().Contains(filtroTexto) OrElse
                                  fila("Moneda").ToString().Contains(filtroTexto) OrElse
                                  fila("Medio de Pago").ToString().Contains(filtroTexto) OrElse
                                  fila("Fecha de creación").ToString().Contains(filtroTexto) OrElse
                                  fila("Motivo Deshabilitar").ToString().ToLower().Contains(filtroTexto) OrElse
                                  fila("Cantidad de Serv. Vendidos").ToString().Contains(filtroTexto)
                If coincide Then
                    tablaFiltrada.ImportRow(fila)
                End If
            Next
            dgvVentas.DataSource = tablaFiltrada
        Else
            If txtBusVent.Text.Length = 0 Or txtBusVent.ForeColor = Color.Gray Then
                Determinar()
            Else
                ' Realiza la búsqueda original
                If rbVentAct.Checked Then
                    Me.dgvVentas.DataSource = VentasSP.BuscarVenta(txtBusVent.Text)
                Else
                    Me.dgvVentas.DataSource = VentasSP.BuscarVentaBaja(txtBusVent.Text)
                End If
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Private ventasFiltradas As DataTable


    Private Sub AjustarTamanoPanelYDataGrid()
        ' Ajustar la altura del DataGridView en función de la cantidad de filas y el alto de cada fila
        Dim totalAltoFilas As Integer = dgvPanelDesp.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        Dim altoHeader As Integer = dgvPanelDesp.ColumnHeadersHeight
        Dim nuevoAlto As Integer = totalAltoFilas + altoHeader

        ' Asignar el nuevo alto al DataGridView
        dgvPanelDesp.Height = nuevoAlto

        pnlDespDGV.Height = dgvPanelDesp.Height + 6 ' Reducir margen vertical

        ' Obtener la posición de la fila seleccionada en el DataGridView
        Dim rectFila As Rectangle = dgvVentas.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvVentas.Top + rectFila.Top + dgvVentas.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvVentas.Left, dgvVentas.Top + rectFila.Top + dgvVentas.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvVentas.Left, dgvVentas.Top + rectFila.Top - pnlDespDGV.Height)
        End If

        ' Asegurarse de que el Panel y el DataGridView se muestren
        pnlDespDGV.Visible = True
        dgvPanelDesp.Visible = True
    End Sub

    Private Sub DetalleFuncion()
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

        If rbVentCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(8)?.Value.ToString)
        End If



        If rbVentAct.Checked Then
            dgvPanelDesp.Rows.Add("Cant. de Serv. Vendidos", filaSeleccionada.Cells(9)?.Value.ToString())
        End If

        If filaSeleccionada.Cells(6)?.Value.ToString() = "Mercado Pago" Then
            dgvPanelDesp.Rows.Add("Núm. Transferencia", filaSeleccionada.Cells(7)?.Value.ToString())
        End If

        dgvPanelDesp.Rows.Add("Fecha de creación", filaSeleccionada.Cells(10)?.Value.ToString())

        AjustarTamanoPanelYDataGrid()

        ' Traer el panel al frente
        pnlDespDGV.BringToFront()
    End Sub

    Private Sub DetalleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleToolStripMenuItem.Click
        DetalleFuncion()
    End Sub

    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Private Sub btnBusxFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBusxFecha.MouseDown
        OcultarPanel()
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

    Private Sub pnlDespDGV_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDespDGV.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvPanelDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvPanelDesp.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    'Private Sub dgvVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvVentas.KeyDown
    '    If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
    '        ' Forzar el foco al DataGridView
    '        dgvVentas.Focus()

    '        ' Evitar comportamiento por defecto de otros controles
    '        e.Handled = True
    '    End If
    'End Sub


    Private Sub dgvVentas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentas.SelectionChanged
        ' Verificar si hay una fila actualmente seleccionada
        dgvVentas.Focus()
        If dgvVentas.CurrentRow IsNot Nothing Then
            ' Actualizar la variable filaSeleccionada
            filaSeleccionada = dgvVentas.CurrentRow

            ' Puedes acceder a sus valores si es necesario
            CodVentTabla = CInt(filaSeleccionada.Cells(0)?.Value)

            ' Mostrar un mensaje (opcional, para pruebas)

        End If

        If pnlDespDGV.Visible = True Then
            DetalleFuncion()
        End If

        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    'Private Sub dgvVentas_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles dgvVentas.PreviewKeyDown
    '    ' Intercepta las teclas de flecha para garantizar que naveguen entre filas
    '    If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Then
    '        e.IsInputKey = True ' Evita que otros controles manejen estas teclas
    '    End If
    'End Sub



#End Region

#End Region

#End Region

End Class