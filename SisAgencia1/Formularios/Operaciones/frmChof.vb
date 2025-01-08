#Region "Imports"
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization
Imports System.Windows.Ink
Imports Datos
Imports Entidades
Imports FastReport
Imports FastReport.DevComponents.DotNetBar.Controls


#End Region

Public Class frmChof

#Region "Declaraciones"
    Dim ChoferesSP As New clsChof
    Dim ChoferesDatos As New eChof
    Dim bandera As Boolean
    Public NomChof As String = ""
    Dim full As Point
    Dim mini As Point
    Dim miniinicio As Point
    Dim CodChof As Integer = 0
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
        If dgvChoferes IsNot Nothing AndAlso dgvChoferes.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de chofer", "DNI", "Apellido", "Nombre", "Correo", "Teléfono", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvChoferes.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvChoferes.Columns(nombreColumna).Index
                    If columnIndex < dgvChoferes.Columns.Count Then
                        dgvChoferes.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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

    Private Sub GetChofAct()
        dgvChoferes.DataSource = ChoferesSP.GetChoferes()
    End Sub

    Private Sub GetChofCan()
        dgvChoferes.DataSource = ChoferesSP.GetChoferesCancel()
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtDNI)
        ControlFalse(txtApe)
        ControlFalse(txtNom)
        ControlFalse(txtMail)
        ControlFalse(txtTel)
        ControlFalse(btnGuaMod)
    End Sub

    Public Sub Determinar()
        If rbChofAct.Checked = True Then
            DeshabilitarToolStripMenuItem.Text = "Deshabilitar"
            GetChofAct()
            If dgvChoferes IsNot Nothing AndAlso dgvChoferes.Columns.Count > 0 Then
                'If dgvChoferes.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvChoferes.Columns("Motivo Deshabilitar").Visible = False
                '    'If frmPrincipal.bMax = True Then
                '    '    dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                '    'Else
                '    '    dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '    'End If
                'End If
            End If
        Else
            DeshabilitarToolStripMenuItem.Text = "Restaurar"
            GetChofCan()
            If dgvChoferes IsNot Nothing AndAlso dgvChoferes.Columns.Count > 0 Then
                'If dgvChoferes.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvChoferes.Columns("Motivo Deshabilitar").Visible = True
                '    'dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                'End If
            End If
        End If

        If frmPrincipal.bMax = True Then
            dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub pnlDatChof_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatChof.Paint
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
        New Point(0, pnlDatChof.Height),                    ' Punto de inicio
        New Point(pnlDatChof.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatChof.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatChof_Resize(sender As Object, e As EventArgs) Handles pnlDatChof.Resize
        pnlDatChof.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub Limpiar2()
        ClearText(txtDNI)
        ClearText(txtApe)
        ClearText(txtNom)
        ClearText(txtMail)
        ClearText(txtTel)
    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtDNI.Focus()
        'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtDNI)
        ControlTrue(txtApe)
        ControlTrue(txtNom)
        ControlTrue(txtMail)
        ControlTrue(txtTel)
        VerPanel(txtTel)
        VerPanel(btnGuaMod)
        ControlTrue(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        ControlFalse(btnResEli)
        ControlFalse(btnAgrVeh)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        DisabledColor()
        Limpiar()
    End Sub

    Public Sub HabilitarNo()
        ClearString(MotivoDeshabilitar)
        ep.Clear()
        txtDNI.Focus()
        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        MinimizarPanel(btnAgrVeh)
        ControlFalse(btnAgrVeh)
        Desactivar()
        VerPanel(txtTel)
        Limpiar()
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodChof)
        'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
        txtBusChof.Text = "Buscar"
        txtBusChof.ForeColor = Color.Gray
        Determinar()
        DefaultBusColor()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub



    Public Sub MinimizarChoferT()
        Me.dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChoferes.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarChoferF()
        Me.dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvChoferes.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub
#End Region

#Region "Eventos"

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmOpChofVeh.btnChof) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario()
    End Sub

    Private Sub frmChof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbChofAct.Checked = True
        GetChofAct()
        HabilitarNo()
        Cargar()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvChoferes)
        SetDoubleBuffered(pnlBusxFecha)
        SetDoubleBuffered(Panel1)
        dgvChoferes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvChoferes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        If frmPrincipal.bMax = True Then
            MinimizarChoferT()
        Else
            MinimizarChoferF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        Dim BackgroundImage As Image = My.Resources.LOGO_Footer_Conquista_tu_Mundo_1
        dgvChoferes.BackgroundImage = BackgroundImage
        frmMenu.RoundCornersBtn(rbChofAct, 10)
        frmMenu.RoundCornersBtn2(rbChofCan, 10)
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnAgrVeh, 10)
        frmMenu.RoundButton(btnImpr, 10)
        RoundTopCornersBtn(btnBusxFecha, 10)
        'RoundCornersExceptTopRightBtn(pnlBusxFecha, 20)
        IluminarFormulario()
    End Sub

    Public Sub RoundTopCornersBtn(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()

        ' Redondear esquina superior izquierda
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)

        ' Línea recta a la esquina superior derecha y redondeo
        path.AddArc(bounds.Width - radius, bounds.Y, radius, radius, 270, 90)

        ' Línea recta hacia abajo
        path.AddLine(bounds.Width, bounds.Y + radius, bounds.Width, bounds.Height)

        ' Línea recta a la esquina inferior izquierda
        path.AddLine(bounds.Width, bounds.Height, bounds.X, bounds.Height)

        ' Línea recta hacia arriba para cerrar la forma
        path.AddLine(bounds.X, bounds.Height, bounds.X, bounds.Y + radius)

        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

    ' Función para redondear todas las esquinas excepto la superior derecha
    Public Sub RoundCornersExceptTopRightBtn(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()

        ' Redondear esquina superior izquierda
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)

        ' Línea recta hacia la esquina superior derecha (sin redondeo)
        path.AddLine(bounds.X + radius, bounds.Y, bounds.Width, bounds.Y)

        ' Línea recta hacia abajo hasta la esquina inferior derecha
        path.AddLine(bounds.Width, bounds.Y, bounds.Width, bounds.Height - radius)

        ' Redondear esquina inferior derecha
        path.AddArc(bounds.Width - radius, bounds.Height - radius, radius, radius, 0, 90)

        ' Redondear esquina inferior izquierda
        path.AddArc(bounds.X, bounds.Height - radius, radius, radius, 90, 90)

        ' Línea recta hacia arriba para cerrar la forma
        path.AddLine(bounds.X, bounds.Height - radius, bounds.X, bounds.Y + radius)

        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub


    Private Sub rbChofAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbChofAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "   Nuevo" Then
            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            HabilitarNo()
        End If
    End Sub

    Private Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si el índice de fila es válido
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()

                Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                    ' Verifica si todas las celdas de la fila no son nulas
                    HabilitarNo()
                Else
                    CodChof = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                    NomChof = row.Cells(3)?.Value?.ToString() & " " & row.Cells(2)?.Value?.ToString()
                    txtDNI.Text = row.Cells(1)?.Value?.ToString()
                    txtNom.Text = row.Cells(3)?.Value?.ToString()
                    txtApe.Text = row.Cells(2)?.Value?.ToString()
                    txtMail.Text = row.Cells(4)?.Value?.ToString()
                    'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(43, 88, 157)
                    txtTel.Text = row.Cells(5)?.Value?.ToString()
                End If

                bandera = False ' Si es mod, es false
                VerPanel(btnAgrVeh)

                If rbChofCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                    VerPanel(txtTel)
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                    VerPanel(txtTel)
                End If

                If rbChofCan.Checked = True Then
                    MinimizarPanel(btnAgrVeh)
                Else
                    VerPanel(btnAgrVeh)
                    ControlTrue(btnAgrVeh)
                End If
            End If
        End If
    End Sub

    Private Sub dgvChoferes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvChoferes.CellDoubleClick
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvChoferes.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvChoferes.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvChoferes, rowIndex)
        End If
    End Sub

    Private Sub rbChofCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbChofCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
    End Sub

    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub






    Public Sub EliResChof()
        If btnResEli.Text = "Deshabilitar" Then
            Deshabilitar()
        ElseIf btnResEli.Text = "Restaurar" Then
            Restaurar()
        End If
        PermisoADMIN = False
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 1
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResChof()
            Else
                VarADMIN = 1
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub



    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatChof, ep)
        Dim chofer As New clsChof
        Dim cliente As New clsCli
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        If banbl = True Then
            ChoferesDatos.CodChof = CodChof
            ChoferesDatos.DNI = txtDNI.Text
            ChoferesDatos.Nombre = txtNom.Text
            ChoferesDatos.Apellido = txtApe.Text
            ChoferesDatos.Correo = txtMail.Text
            ChoferesDatos.Telefono = txtTel.Text
            ChoferesDatos.IdAlta = CodUsu
            tabla2 = chofer.VerificarDNIChofNuevo(txtDNI.Text)
            If bandera = True Then
                If tabla2(0)(0) = 0 Then
                    If ChoferesSP.InsChof(ChoferesDatos) Then
                        MensajeNotificacion("Chofer grabado exitosamente.", "Éxito.")
                        'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
                        MinimizarPanel(btnAgrVeh)
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Sucedió un error al intentar grabar el chofer.", "Error.")
                    End If
                Else
                    ep.SetError(txtDNI, "El DNI ya está asignado a un chofer.")
                End If
            Else
                If CodTpUsu = 2 Then
                    VarADMIN = 11
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    ModChof()
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco2(Me.pnlDatChof, ep)
        End If
    End Sub

    Public Sub ModChof()
        Dim chofer As New clsChof
        Dim tabla3 As New DataTable
        tabla3 = chofer.VerificarDNIChofMod(txtDNI.Text, ChoferesDatos)
        If tabla3(0)(0) = 0 Then
            If ChoferesSP.ModChof(ChoferesDatos) Then
                If CodChof = 0 Then
                    MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                Else
                    ChoferesDatos.CodChof = CodChof
                    MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                    'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
                    HabilitarNo()
                    Determinar()
                End If
            Else
                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
            End If
        Else
            ep.SetError(txtDNI, "El DNI ya está asignado a un chofer.")
        End If
    End Sub

    Private Sub btnAgrVeh_Click(sender As Object, e As EventArgs) Handles btnAgrVeh.Click
        VehdesdeChof = True
        CodChofAgrVeh = CodChof
        NomApeChofAgrVeh = NomChof
        AbrirFormPanel(frmVeh, frmOpChofVeh.pnlOpChofVeh)
        frmVeh.rbVehAct.Checked = True
        ActualizarUltimosFormularios("frmVeh")
        frmVeh.IluminarFormulario()
    End Sub

    Private Sub frmChof_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbChofAct.Checked = True Then
                ' Cargar el reporte desde los recursos
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpChofH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If
                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ChoferesSP.GetChoferes()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosChof")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpChofD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If
                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ChoferesSP.GetChoferesCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajChof")
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
#Region "Ocultar Panel"
    Private Sub frmChof_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDatChof_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatChof.MouseDown
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

    Private Sub txtDNI_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDNI.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtNom_MouseDown(sender As Object, e As MouseEventArgs) Handles txtApe.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtApe_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNom.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtMail_MouseDown(sender As Object, e As MouseEventArgs) Handles txtMail.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtTel_MouseDown(sender As Object, e As MouseEventArgs) Handles txtTel.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVChof_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVChof.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbChofAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbChofAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbChofCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbChofCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusChof_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusChof.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvChoferes_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvChoferes.MouseDown
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

    Private Sub btnAgrVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAgrVeh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub
#Region "Context Menu Strip"
    Public Sub Deshabilitar()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un chofer, junto con sus vehículos y operaciones asignadas ¿Desea continuar?", "Deshabilitar chofer " & txtNom.Text & " " & txtApe.Text & ".", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            ChoferesDatos.MotivoDes = MotivoDeshabilitar
            If ChoferesSP.BajaChoferes(CodChof, CodUsu, ChoferesDatos) Then
                MensajeNotificacion("Chofer deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al chofer " & txtNom.Text & " " & txtApe.Text & ".", "Error.")
            End If
        End If
    End Sub

    Dim CodChofTabla As Integer

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un chofer, junto con sus vehículos y operaciones asignadas ¿Desea continuar?", "Deshabilitar chofer " & txtNom.Text & " " & txtApe.Text & ".", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            ChoferesDatos.MotivoDes = MotivoDeshabilitar
            If ChoferesSP.BajaChoferes(CodChofTabla, CodUsu, ChoferesDatos) Then
                MensajeNotificacion("Chofer deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al chofer " & txtNom.Text & " " & txtApe.Text & ".", "Error.")
            End If
        End If
    End Sub


    Public Sub Restaurar2()
        If ChoferesSP.RecChoferes(CodChofTabla) Then
            MensajeNotificacion("Chofer restaurado exitosamente, sus vehículos y operaciones deberán restaurarse manualmente.", "Éxito.")
            HabilitarNo()
            Determinar()
            'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar el chofer " & txtNom.Text & " " & txtApe.Text & ".", "Error.")
        End If
    End Sub

    Public Sub Restaurar()
        If ChoferesSP.RecChoferes(CodChof) Then
            MensajeNotificacion("Chofer restaurado exitosamente, sus vehículos y operaciones deberán restaurarse manualmente.", "Éxito.")
            HabilitarNo()
            Determinar()
            'frmOpChofVeh.btnChof.BackColor = Color.FromArgb(30, 63, 111)
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar el chofer " & txtNom.Text & " " & txtApe.Text & ".", "Error.")
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodChofTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 14
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 14
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodChofTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 15
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
        If dgvChoferes.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvChoferes.SelectedCells(0).RowIndex

            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvChoferes, rowIndex)
        End If
    End Sub

    Private filaSeleccionada As DataGridViewRow
    Dim MotivoDesCol As String
    Dim CodChofCol As Integer

    Private Sub AjustarTamanoPanelYDataGrid()
        ' Ajustar la altura del DataGridView en función de la cantidad de filas y el alto de cada fila
        Dim totalAltoFilas As Integer = dgvPanelDesp.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
        Dim altoHeader As Integer = dgvPanelDesp.ColumnHeadersHeight
        Dim nuevoAlto As Integer = totalAltoFilas + altoHeader

        ' Asignar el nuevo alto al DataGridView
        dgvPanelDesp.Height = nuevoAlto

        pnlDespDGV.Height = dgvPanelDesp.Height + 6 ' Reducir margen vertical

        ' Obtener la posición de la fila seleccionada en el DataGridView
        Dim rectFila As Rectangle = dgvChoferes.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvChoferes.Top + rectFila.Top + dgvChoferes.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvChoferes.Left, dgvChoferes.Top + rectFila.Top + dgvChoferes.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvChoferes.Left, dgvChoferes.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Número de Chofer", CodChofCol.ToString())

        If rbChofCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", MotivoDesCol)
        End If



        AjustarTamanoPanelYDataGrid()

        ' Traer el panel al frente
        pnlDespDGV.BringToFront()
    End Sub



    Private Sub dgvChoferes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvChoferes.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvChoferes.CurrentCell = dgvChoferes.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvChoferes.Rows(e.RowIndex)
                MotivoDesCol = filaSeleccionada.Cells(6)?.Value.ToString
                CodChofCol = CInt(filaSeleccionada.Cells(0)?.Value)
                CodChofTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsChof.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgvChoferes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvChoferes.DataBindingComplete
        If dgvChoferes.Columns.Count > 0 Then
            dgvChoferes.Columns(dgvChoferes.Columns.Count - 2).Visible = False
            dgvChoferes.Columns(dgvChoferes.Columns.Count - 8).Visible = False
        End If
    End Sub

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusChof_Enter(sender As Object, e As EventArgs) Handles txtBusChof.Enter
        If txtBusChof.Text = "Buscar" Then
            ClearText(txtBusChof)
            txtBusChof.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusChof_Leave(sender As Object, e As EventArgs) Handles txtBusChof.Leave
        If String.IsNullOrWhiteSpace(txtBusChof.Text) Then
            txtBusChof.Text = "Buscar"
            txtBusChof.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Public Sub Cargar()
        If txtBusChof.Text.Length = 0 Or txtBusChof.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbChofAct.Checked Then
                Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferes(txtBusChof.Text)
            Else
                Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferesBaja(txtBusChof.Text)
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Private Sub txtBusChof_TextChanged(sender As Object, e As EventArgs) Handles txtBusChof.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusChof_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusChof.MouseClick
        If txtBusChof.Text = "Buscar" Then
            ClearText(txtBusChof)
            txtBusChof.ForeColor = Color.Black
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
        ControlTrue(txtBusChof)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusChof)
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

                    If rbChofAct.Checked Then
                        Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferFechaHasta(desde, hasta)
                    Else
                        Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferDesFechaHasta(desde, hasta)
                    End If




                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)


                        If rbChofAct.Checked Then
                            Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferFechaHasta(desde, hasta)
                        Else
                            Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferDesFechaHasta(desde, hasta)
                        End If

                    Else
                        DesdeDate()
                        If rbChofAct.Checked Then
                            Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferFecha(desde)
                        Else
                            Me.dgvChoferes.DataSource = ChoferesSP.BuscarChoferDesFecha(desde)
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

    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
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

    End Sub


#End Region


#End Region

#End Region

#End Region

End Class