#Region "Imports"
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport

#End Region

Public Class frmProv

#Region "Declaraciones"
    Public CodProv As Integer = 0
    Public NomProv As String
    Dim ProveedoresSP As New clsProv
    Dim ProveedoresDatos As New eProv
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
        If dgvProveedores IsNot Nothing AndAlso dgvProveedores.Columns.Count > 0 Then
            Dim ordenColumnas As New List(Of String) From {"Número de proveedor", "CUIT", "Razón social", "Nick", "Correo", "Teléfono", "Motivo Deshabilitar", "Fecha de creación"}
            For Each nombreColumna As String In ordenColumnas
                If dgvProveedores.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvProveedores.Columns(nombreColumna).Index
                    If columnIndex < dgvProveedores.Columns.Count Then
                        dgvProveedores.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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

    Private Sub GetProvAct()
        dgvProveedores.DataSource = ProveedoresSP.GetProveedores()
    End Sub

    Private Sub GetProvCan()
        dgvProveedores.DataSource = ProveedoresSP.GetProveedoresCancel()
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtCUIT)
        ControlFalse(txtRazSoc)
        ControlFalse(txtNick)
        ControlFalse(txtMail)
        ControlFalse(txtTel)
        ControlFalse(btnGuaMod)
    End Sub

    Public Sub Determinar()
        If rbProvAct.Checked = True Then
            GetProvAct()
            If dgvProveedores IsNot Nothing AndAlso dgvProveedores.Columns.Count > 0 Then
                'If dgvProveedores.Columns.Contains("Motivo Deshabilitar") Then
                '    dgvProveedores.Columns("Motivo Deshabilitar").Visible = False
                '    'If frmPrincipal.bMax = True Then
                '    '    dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                '    'Else
                '    '    dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                '    'End If
                'End If
            End If
        Else
            GetProvCan()
            'If dgvProveedores IsNot Nothing AndAlso dgvProveedores.Columns.Count > 0 Then
            '    If dgvProveedores.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvProveedores.Columns("Motivo Deshabilitar").Visible = True
            '        'dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '    End If
            'End If
        End If

        If frmPrincipal.bMax = True Then
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Public Sub Limpiar2()
        ClearText(txtCUIT)
        ClearText(txtRazSoc)
        ClearText(txtNick)
        ClearText(txtMail)
        ClearText(txtTel)
    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtCUIT.Focus()
        'frmServProv.btnProv.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtCUIT)
        ControlTrue(txtRazSoc)
        ControlTrue(txtNick)
        ControlTrue(txtMail)
        ControlTrue(txtTel)
        VerPanel(txtTel)
        VerPanel(btnGuaMod)
        ControlTrue(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        ControlFalse(btnResEli)
        ControlFalse(btnAgrServ)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnNuevo)
        DisabledColor()
        Limpiar()
    End Sub

    Public Sub HabilitarNo()
        ep.Clear()
        txtCUIT.Focus()
        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        MinimizarPanel(btnAgrServ)
        ControlFalse(btnAgrServ)
        VerPanel(txtTel)
        Desactivar()
        Limpiar()
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodProv)
        'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
        txtBusProv.Text = "Buscar"
        txtBusProv.ForeColor = Color.Gray
        Determinar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un proveedor, junto con sus servicios ¿Desea continuar?", "Deshabilitar proveedor.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            ProveedoresDatos.MotivoDes = MotivoDeshabilitar
            If ProveedoresSP.BajaProveedores(CodProvTabla, CodUsu, ProveedoresDatos) Then
                MensajeNotificacion("Proveedor deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al proveedor.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        If ProveedoresSP.RecProveedores(CodProvTabla) Then
            MensajeNotificacion("Proveedor restaurado exitosamente, deberá restaurar sus servicios manualmente.", "Éxito.")
            HabilitarNo()
            Determinar()
            'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar el proveedor.", "Error.")
        End If
    End Sub

    Public Sub EliResProv()
        If btnResEli.Text = "Deshabilitar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un proveedor, junto con sus servicios ¿Desea continuar?", "Deshabilitar proveedor " & txtRazSoc.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                ProveedoresDatos.MotivoDes = MotivoDeshabilitar
                If ProveedoresSP.BajaProveedores(CodProv, CodUsu, ProveedoresDatos) Then
                    MensajeNotificacion("Proveedor deshabilitado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar deshabilitar al proveedor " & txtRazSoc.Text & ".", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            If ProveedoresSP.RecProveedores(CodProv) Then
                MensajeNotificacion("Proveedor restaurado exitosamente, deberá restaurar sus servicios manualmente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el proveedor " & txtRazSoc.Text & ".", "Error.")
            End If
        End If
        PermisoADMIN = False
    End Sub

    Public Sub Cargar()
        If txtBusProv.Text.Length = 0 Or txtBusProv.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbProvAct.Checked Then
                Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedores(txtBusProv.Text)
            Else
                Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedoresBaja(txtBusProv.Text)
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarProveedorT()
        Me.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarProveedorF()
        Me.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedores.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub
#End Region

#Region "Eventos"
    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmServProv.btnProv) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario()
    End Sub

    Private Sub frmProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbProvAct.Checked = True
        GetProvAct()
        HabilitarNo()
        Cargar()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        If frmPrincipal.bMax = True Then
            MinimizarProveedorT()
        Else
            MinimizarProveedorF()
        End If
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvProveedores)
        dgvProveedores.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvProveedores.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        If frmPrincipal.bMax = True Then
            MinimizarProveedorT()
        Else
            MinimizarProveedorF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnAgrServ, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundCornersBtn(rbProvAct, 10)
        frmMenu.RoundCornersBtn2(rbProvCan, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatProv_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatProv.Paint
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
        New Point(0, pnlDatProv.Height),                    ' Punto de inicio
        New Point(pnlDatProv.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatProv.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatProv_Resize(sender As Object, e As EventArgs) Handles pnlDatProv.Resize
        pnlDatProv.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbProvAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbProvAct.CheckedChanged
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

    Private Sub dgvProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvProveedores.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                HabilitarNuevo()
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProveedores.Rows.Count Then
                    Dim row As DataGridViewRow = dgvProveedores.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                        HabilitarNo()
                    Else
                        CodProv = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtCUIT.Text = row.Cells(1)?.Value?.ToString()
                        txtNick.Text = row.Cells(3)?.Value?.ToString()
                        txtRazSoc.Text = row.Cells(2)?.Value?.ToString()
                        NomProv = row.Cells(2)?.Value?.ToString()
                        txtMail.Text = row.Cells(4)?.Value?.ToString()
                        'frmServProv.btnProv.BackColor = Color.FromArgb(43, 88, 157)
                        txtTel.Text = row.Cells(5)?.Value?.ToString()
                    End If
                End If
                bandera = False 'si es mod es false
                VerPanel(btnAgrServ)
                If rbProvCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                    VerPanel(txtTel)
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    EliminarColor()
                    VerPanel(txtTel)
                End If
                If rbProvCan.Checked = True Then
                    VerPanel(btnAgrServ)
                Else
                    VerPanel(btnAgrServ)
                    ControlTrue(btnAgrServ)
                End If
            End If
        End If
    End Sub

    Private Sub rbProvCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbProvCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
    End Sub

    Private Sub txtCUIT_TextChanged(sender As Object, e As EventArgs) Handles txtCUIT.TextChanged
        FiltrarNoIntCUIT(sender, e)
    End Sub

    Private Sub txtCUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCUIT.KeyPress
        SoloIntCUIT(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 4
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResProv()
            Else
                VarADMIN = 4
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatProv, ep)
        Dim proveedor As New clsProv
        Dim cliente As New clsCli
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        If banbl = True Then
            ProveedoresDatos.CodProv = CodProv
            ProveedoresDatos.CUIT = txtCUIT.Text
            ProveedoresDatos.RazonSocial = txtRazSoc.Text
            ProveedoresDatos.Nick = txtNick.Text
            ProveedoresDatos.Correo = txtMail.Text
            ProveedoresDatos.Telefono = txtTel.Text
            ProveedoresDatos.IdAlta = CodUsu
            tabla2 = proveedor.VerificarCUITProvNuevo(txtCUIT.Text)
            tabla3 = proveedor.VerificarCUITProvMod(txtCUIT.Text, ProveedoresDatos)
            If bandera = True Then
                If tabla2(0)(0) = 0 Then
                    If ProveedoresSP.InsProv(ProveedoresDatos) Then
                        MensajeNotificacion("Proveedor grabado exitosamente.", "Éxito.")
                        'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
                        MinimizarPanel(btnAgrServ)
                        HabilitarNo()
                        Determinar()
                    Else
                        MensajeNotificacion("Sucedió un error al intentar grabar el proveedor.", "Error.")
                    End If
                Else
                    ep.SetError(txtCUIT, "El CUIT ya está asignado a un proveedor.")
                End If
            Else
                If tabla3(0)(0) = 0 Then
                    If ProveedoresSP.ModProv(ProveedoresDatos) Then
                        If CodProv = 0 Then
                            MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                        Else
                            ProveedoresDatos.CodProv = CodProv
                            MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                            'frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
                            HabilitarNo()
                            Determinar()
                        End If
                    Else
                        MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                    End If
                Else
                    ep.SetError(txtCUIT, "El CUIT ya está asignado a un proveedor.")
                End If
            End If
            MinimizarPanel(btnAgrServ)
        ElseIf banbl = False Then
            CampoBlanco2(Me.pnlDatProv, ep)
        End If
    End Sub

    Private Sub btnAgrServ_Click(sender As Object, e As EventArgs) Handles btnAgrServ.Click
        ServdesdeProv = True
        CodProvSelProv = CodProv
        RazonSocialSelProv = NomProv
        AbrirFormPanel(frmServ, frmServProv.pnlServProv)
        frmServ.rbServAct.Checked = True
        ActualizarUltimosFormularios("frmServ")
        frmServ.IluminarFormulario()





    End Sub

    Private Sub frmProv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmServProv.btnProv.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#Region "Ocultar Panel"
    Private Sub frmProv_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
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

    Private Sub pnlDatProv_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatProv.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVProv_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVProv.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbProvAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbProvAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbProvCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbProvCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusProv_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusProv.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvProveedores_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvProveedores.MouseDown
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

    Private Sub txtCUIT_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCUIT.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtRazSoc_MouseDown(sender As Object, e As MouseEventArgs) Handles txtRazSoc.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtNick_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNick.MouseDown
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

    Private Sub btnAgrServ_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAgrServ.MouseDown
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
            If rbProvAct.Checked = True Then
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpProvH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ProveedoresSP.GetProveedores()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosProv")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpProvD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ProveedoresSP.GetProveedoresCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajProv")
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

    Dim CodProvTabla As Integer
    Private filaSeleccionada As DataGridViewRow

    Private Sub dgvProveedores_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvProveedores.CurrentCell = dgvProveedores.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvProveedores.Rows(e.RowIndex)
                CodProvTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsProv.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvProveedores.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvProveedores.SelectedCells(0).RowIndex
            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvProveedores, rowIndex)
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
                        CodProv = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        txtCUIT.Text = row.Cells(1)?.Value?.ToString()
                        txtNick.Text = row.Cells(3)?.Value?.ToString()
                        txtRazSoc.Text = row.Cells(2)?.Value?.ToString()
                        NomProv = row.Cells(2)?.Value?.ToString()
                        txtMail.Text = row.Cells(4)?.Value?.ToString()
                        frmServProv.btnProv.BackColor = Color.FromArgb(43, 88, 157)
                        txtTel.Text = row.Cells(5)?.Value?.ToString()
                    End If
                End If
                bandera = False 'si es mod es false
                VerPanel(btnAgrServ)
                If rbProvCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                    VerPanel(txtTel)
                Else
                    btnGuaMod.Text = "Modificar"
                    EliminarColor()
                    VerPanel(txtTel)
                End If
                If rbProvCan.Checked = True Then
                    VerPanel(btnAgrServ)
                Else
                    VerPanel(btnAgrServ)
                    ControlTrue(btnAgrServ)
                End If
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodProvTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 24
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 24
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodProvTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 25
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

    Private Sub dgvProveedores_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProveedores.DataBindingComplete
        If dgvProveedores.Columns.Count > 0 Then
            dgvProveedores.Columns(dgvProveedores.Columns.Count - 2).Visible = False
            dgvProveedores.Columns(dgvProveedores.Columns.Count - 8).Visible = False
        End If
    End Sub

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusProv_Enter(sender As Object, e As EventArgs) Handles txtBusProv.Enter
        If txtBusProv.Text = "Buscar" Then
            ClearText(txtBusProv)
            txtBusProv.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusProv_Leave(sender As Object, e As EventArgs) Handles txtBusProv.Leave
        If String.IsNullOrWhiteSpace(txtBusProv.Text) Then
            txtBusProv.Text = "Buscar"
            txtBusProv.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusProv_TextChanged(sender As Object, e As EventArgs) Handles txtBusProv.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusProv_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusProv.MouseClick
        If txtBusProv.Text = "Buscar" Then
            ClearText(txtBusProv)
            txtBusProv.ForeColor = Color.Black
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
        ControlTrue(txtBusProv)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusProv)
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

                    If rbProvAct.Checked Then
                        Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorFechaHasta(desde, hasta)
                    Else
                        Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorDesFechaHasta(desde, hasta)
                    End If


                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbProvAct.Checked Then
                            Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorFechaHasta(desde, hasta)
                        Else
                            Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorDesFechaHasta(desde, hasta)
                        End If

                    Else
                        DesdeDate()
                        If rbProvAct.Checked Then
                            Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorFecha(desde)
                        Else
                            Me.dgvProveedores.DataSource = ProveedoresSP.BuscarProveedorDesFecha(desde)
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
        Dim rectFila As Rectangle = dgvProveedores.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvProveedores.Top + rectFila.Top + dgvProveedores.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvProveedores.Left, dgvProveedores.Top + rectFila.Top + dgvProveedores.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvProveedores.Left, dgvProveedores.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Número de proveedor", CInt(filaSeleccionada.Cells(0)?.Value))

        If rbProvCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(6)?.Value.ToString)
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