#Region "Imports"
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport
Imports FastReport.Design.PageDesigners


#End Region

Public Class frmClientes

#Region "Declaraciones"
    Public CodCli As Integer = 0
    Dim ClientesSP As New clsCli
    Dim ClienteDatos As New eCli
    Dim bandera As Boolean
    Dim full As Point
    Dim mini As Point
    Dim miniinicio As Point
    Dim tabla As Boolean = False
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
        If dgvClientes IsNot Nothing AndAlso dgvClientes.Columns.Count > 0 Then
            Dim ordenColumnas As New List(Of String) From {"Número de cliente", "DNI", "Apellido", "Nombre", "País", "Correo", "Teléfonos", "Fecha de creación"}
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
        ControlFalse(txtDNI)
        ControlFalse(txtNom)
        ControlFalse(txtApe)
        ControlFalse(cmbPais)
        ControlFalse(txtMail)
        ControlFalse(txtTel)
        ControlFalse(btnGuaMod)
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

    Private Sub Limpiar2()
        ClearText(txtDNI)
        ClearText(txtNom)
        ClearText(txtApe)
        ClearText(txtMail)
        ClearText(txtTel)
    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        txtDNI.Focus()
        'frmVenCli.btnCliV.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtDNI)
        ControlTrue(txtNom)
        ControlTrue(txtApe)
        ControlTrue(cmbPais)
        ControlTrue(txtMail)
        ControlTrue(txtTel)
        VerPanel(txtTel)
        MinimizarPanel(btnAgrTel)
        VerPanel(btnGuaMod)
        ControlTrue(btnGuaMod)
        btnGuaMod.Text = "Guardar"
        ControlFalse(btnResEli)
        ControlFalse(btnAgrCom)
        btnNuevo.Text = "Cancelar"
        btnNuevo.ForeColor = Color.Firebrick
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        DisabledColor()
        Limpiar()
    End Sub

    Private Sub HabilitarNo()
        ep.Clear()
        txtDNI.Focus()

        ControlFalse(btnResEli)
        btnGuaMod.Text = "Guardar"
        MinimizarPanel(btnAgrCom)
        ControlFalse(btnAgrCom)
        MinimizarPanel(btnAgrTel)
        Desactivar()
        VerPanel(txtTel)
        VerPanel(Label1)
        Limpiar()
        cmbPais.Text = ""
        cmbPais.SelectedIndex = -1
        DisabledColor()
        btnNuevo.Text = "   Nuevo"
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
        btnNuevo.Image = My.Resources.icons8_más_nuevo_24
        ClearInt(CodCli)
        'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
        txtBusCli.Text = "Buscar"
        txtBusCli.ForeColor = Color.Gray
        Determinar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
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
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarFotoCliT()
        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub
    Public Sub MinimizarFotoCliF()
        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un cliente y con ello, su teléfono, ¿Desea continuar?", "Deshabilitar cliente.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            If ClientesSP.BajaClientes(CodCliTabla, CodUsu) Then
                MensajeNotificacion("Cliente deshabilitado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                MinimizarPanel(btnAgrCom)
                'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar deshabilitar al cliente.", "Error.")
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        If ClientesSP.RecClientes(CodCliTabla) Then
            MensajeNotificacion("Cliente recuperado exitosamente, sus teléfonos deberán restaurarse manualmente.", "Éxito.")
            HabilitarNo()
            Determinar()
            'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
        Else
            MensajeNotificacion("Hubo un error al intentar recuperar el cliente.", "Error.")
        End If
    End Sub

    Public Sub EliResCli()
        If btnResEli.Text = "Deshabilitar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un cliente y con ello, su teléfono, ¿Desea continuar?", "Deshabilitar cliente " & txtApe.Text & "," & txtNom.Text, MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                If ClientesSP.BajaClientes(CodCli, CodUsu) Then
                    MensajeNotificacion("Cliente deshabilitado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    MinimizarPanel(btnAgrCom)
                    'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar deshabilitar al cliente " & txtApe.Text & ".", "Error.")
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            If ClientesSP.RecClientes(CodCli) Then
                MensajeNotificacion("Cliente recuperado exitosamente, sus teléfonos deberán restaurarse manualmente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el cliente " & txtApe.Text & ".", "Error.")
            End If
        End If
        PermisoADMIN = False
    End Sub
#End Region

#Region "Eventos"
    Private Sub dgvPanelDesp_Click(sender As Object, e As EventArgs) Handles dgvPanelDesp.Click
        Return
    End Sub

    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmVenCli.btnCliV) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        dgvClientes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvClientes)
        SetDoubleBuffered(cmbPais)
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        If frmPrincipal.bMax = True Then
            MinimizarFotoCliT()
        Else
            MinimizarFotoCliF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        GetCliAct()
        CargaCmbPais()
        HabilitarNo()
        Cargar()
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(btnAgrTel, 10)
        frmMenu.RoundButton(btnGuaMod, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnAgrCom, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundCornersBtn(rbCliAct, 10)
        frmMenu.RoundCornersBtn2(rbCliCan, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
        'frmVisorReportes.HideWithAnimation()

    End Sub

    Private Sub frmClientes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatCli_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatCli.Paint
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
        New Point(0, pnlDatCli.Height),                    ' Punto de inicio
        New Point(pnlDatCli.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatCli.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatCli_Resize(sender As Object, e As EventArgs) Handles pnlDatCli.Resize
        pnlDatCli.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbCliAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Deshabilitar"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If btnNuevo.Text = "   Nuevo" Then
            HabilitarNuevo()
        ElseIf btnNuevo.Text = "Cancelar" Then
            HabilitarNo()
        End If
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgvClientes.SelectedCells.Count > 0 Then
                HabilitarNuevo()
                bandera = False
                ControlTrue(btnAgrCom)
                ControlFalse(txtTel)
                VerPanel(btnAgrCom)
                If rbCliCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                    MinimizarPanel(btnAgrCom)
                    MinimizarPanel(btnAgrTel)
                    MinimizarPanel(txtTel)
                    MinimizarPanel(txtTel)
                    MinimizarPanel(Label1)
                Else
                    btnGuaMod.Text = "Guardar Cambios"
                    VerPanel(btnAgrCom)
                    EliminarColor()
                    MinimizarPanel(txtTel)
                    VerPanel(btnAgrTel)
                    VerPanel(Label1)
                End If
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvClientes.Rows.Count Then
                    Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CorreoCli = row.Cells(5)?.Value?.ToString()
                        CodCli = CInt(row.Cells(0)?.Value)
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        dnibus = row.Cells(1)?.Value?.ToString()
                        txtNom.Text = row.Cells(3)?.Value?.ToString()
                        NomApeClienteVen = row.Cells(2)?.Value?.ToString() & " " & row.Cells(3)?.Value?.ToString()
                        NomCli = row.Cells(3)?.Value?.ToString()
                        txtApe.Text = row.Cells(2)?.Value?.ToString()
                        ApeCli = row.Cells(2)?.Value?.ToString()
                        cmbPais.SelectedValue = row.Cells(8)?.Value?.ToString()
                        txtMail.Text = row.Cells(5)?.Value?.ToString()
                        'frmVenCli.btnCliV.BackColor = Color.FromArgb(43, 88, 157)
                        TelClienteVen = row.Cells(6)?.Value?.ToString()
                        DNIClienteVen = row.Cells(1)?.Value?.ToString()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rbCliCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
    End Sub

    Private Sub dgvClientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvClientes.DataBindingComplete
        If dgvClientes.Columns.Count > 0 Then
            dgvClientes.Columns(dgvClientes.Columns.Count - 1).Visible = False
            dgvClientes.Columns(dgvClientes.Columns.Count - 4).Visible = False
            dgvClientes.Columns(dgvClientes.Columns.Count - 9).Visible = False
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloIntDNI(sender, e)
    End Sub

    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        FiltrarNoIntDNI(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
            VarADMIN = 8
        Else
            EliResCli()
        End If
    End Sub

    Private Sub btnGuaMod_Click(sender As Object, e As EventArgs) Handles btnGuaMod.Click
        ep.Clear()
        CampoBlancoCliente(Me.pnlDatCli, ep)
        Dim Usuario As New clsCli
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Dim tabla3 As New DataTable
        tabla = Usuario.VerificarCombo(cmbPais.SelectedValue)
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
                            MensajeNotificacion("Cliente grabado exitosamente.", "Éxito.")
                            'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
                            MinimizarPanel(btnAgrCom)
                            HabilitarNo()
                            Determinar()
                        Else
                            MensajeNotificacion("Sucedió un error al intentar grabar el cliente.", "Error.")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
                    End If
                Else
                    If tabla3(0)(0) = 0 Then
                        If ClientesSP.ModCli(ClienteDatos) Then
                            If CodCli = 0 Then
                                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                            Else
                                ClienteDatos.CodCli = CodCli
                                MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                                'frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
                                HabilitarNo()
                                Determinar()
                            End If
                        Else
                            MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                        End If
                    Else
                        ep.SetError(txtDNI, "El DNI ya está asignado a un cliente.")
                    End If
                End If
                MinimizarPanel(btnAgrCom)
            ElseIf banbl = False Then
                CampoBlancoCliente(Me.pnlDatCli, ep)
            End If
        Else
            ep.SetError(cmbPais, "El país es incorrecto.")
        End If
    End Sub

    Private Sub btnAgrTel_Click(sender As Object, e As EventArgs) Handles btnAgrTel.Click
        Dim frmTelefonos As New frmTelefonos()
        frmTelefonos.ShowDialog()
        frmTelefonos.TopMost = True
    End Sub

    Private Sub btnAgrCom_Click(sender As Object, e As EventArgs) Handles btnAgrCom.Click
        If Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            ActualizarUltimosFormularios("frmAgrVent")
            AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
            frmAgrVent.IluminarFormulario()
            Return
        End If

        AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
        CodCliVender = CodCli
        ActualizarUltimosFormularios("frmAgrVent")
        frmVenCli.tVent.Stop()
        frmAgrVent.IluminarFormulario()
    End Sub

    Private Sub frmClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmVenCli.btnCliV.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#Region "Ocultar Panel"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub frmClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
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

    Private Sub pnlDatCli_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatCli.MouseDown
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

    Private Sub label11_MouseDown(sender As Object, e As MouseEventArgs) Handles label11.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtApe_MouseDown(sender As Object, e As MouseEventArgs) Handles txtApe.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub cmbPais_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbPais.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtMail_MouseDown(sender As Object, e As MouseEventArgs) Handles txtMail.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtTel_MouseDown(sender As Object, e As MouseEventArgs) Handles txtTel.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnAgrTel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAgrTel.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnGuaMod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnGuaMod.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnAgrCom_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAgrCom.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub pnlDGVCli_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVCli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbCliAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbCliAct.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub rbCliCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbCliCan.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub txtBusCli_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusCli.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub dgvClientes_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvClientes.MouseDown
        OcultarPanel()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        MinimizarPanel(pnlDespDGV)
    End Sub

    Private Sub btnImpr_Click(sender As Object, e As EventArgs) Handles btnImpr.Click
        Dim reporte As New Report()
        Dim conexion As New clsConexion() ' Instancia de la clase de conexión
        Dim reportStream As IO.MemoryStream = Nothing
        Dim conexionData As String = conexion.GetConnectionString
        Try
            If rbCliAct.Checked = True Then
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpCliH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ClientesSP.GetClientes()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosCli")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpCliD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = ClientesSP.GetClientesCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajCli")
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
    Dim CodCliTabla As Integer
    Dim NomApeCliTabla As String
    Dim TelCliTabla As String
    Dim DNICliTabla As Integer

    Private Sub dgvClientes_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvClientes.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvClientes.CurrentCell = dgvClientes.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvClientes.Rows(e.RowIndex)
                CodCliTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                NomApeCliTabla = filaSeleccionada.Cells(2)?.Value?.ToString() & " " & filaSeleccionada.Cells(3)?.Value?.ToString()
                TelCliTabla = filaSeleccionada.Cells(6)?.Value?.ToString()
                DNICliTabla = filaSeleccionada.Cells(1)?.Value?.ToString()
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsCli.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvClientes.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvClientes.SelectedCells(0).RowIndex
            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvClientes, rowIndex)
        End If
    End Sub

    Private Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then
                HabilitarNuevo()
                bandera = False
                ControlTrue(btnAgrCom)
                ControlFalse(txtTel)
                VerPanel(btnAgrCom)
                If rbCliCan.Checked Then
                    Desactivar()
                    RestaurarColor()
                    MinimizarPanel(btnAgrCom)
                    MinimizarPanel(btnAgrTel)
                    MinimizarPanel(txtTel)
                    MinimizarPanel(txtTel)
                    MinimizarPanel(Label1)
                Else
                    btnGuaMod.Text = "Modificar"
                    VerPanel(btnAgrCom)
                    EliminarColor()
                    MinimizarPanel(txtTel)
                    VerPanel(btnAgrTel)
                    VerPanel(Label1)
                End If
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CorreoCli = row.Cells(5)?.Value?.ToString()
                        CodCli = CInt(row.Cells(0)?.Value)
                        NomApeClienteVen = row.Cells(2)?.Value?.ToString() & " " & row.Cells(3)?.Value?.ToString()
                        TelClienteVen = row.Cells(6)?.Value?.ToString()
                        DNIClienteVen = row.Cells(1)?.Value?.ToString()
                        txtDNI.Text = row.Cells(1)?.Value?.ToString()
                        dnibus = row.Cells(1)?.Value?.ToString()
                        txtNom.Text = row.Cells(3)?.Value?.ToString()
                        NomCli = row.Cells(3)?.Value?.ToString()
                        txtApe.Text = row.Cells(2)?.Value?.ToString()
                        ApeCli = row.Cells(2)?.Value?.ToString()
                        cmbPais.SelectedValue = row.Cells(8)?.Value?.ToString()
                        txtMail.Text = row.Cells(5)?.Value?.ToString()
                        'frmVenCli.btnCliV.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodCliTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 32
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 32
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodCliTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 33
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

    Private Sub VenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderToolStripMenuItem.Click
        CodCli = CodCliTabla
        NomApeClienteVen = NomApeCliTabla
        TelClienteVen = TelCliTabla
        DNIClienteVen = DNICliTabla
        AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
        CodCliVender = CodCli
        ActualizarUltimosFormularios("frmAgrVent")
    End Sub
#End Region

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusCli_Enter(sender As Object, e As EventArgs) Handles txtBusCli.Enter
        If txtBusCli.Text = "Buscar" Then
            ClearText(txtBusCli)
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
            ClearText(txtBusCli)
            txtBusCli.ForeColor = Color.Black
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
        ControlTrue(txtBusCli)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusCli)
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
                    If rbCliAct.Checked Then
                        Me.dgvClientes.DataSource = ClientesSP.BuscarClienteFechaHasta(desde, hasta)
                    Else
                        Me.dgvClientes.DataSource = ClientesSP.BuscarClienteDesFechaHasta(desde, hasta)
                    End If
                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbCliAct.Checked Then
                            Me.dgvClientes.DataSource = ClientesSP.BuscarClienteFechaHasta(desde, hasta)
                        Else
                            Me.dgvClientes.DataSource = ClientesSP.BuscarClienteDesFechaHasta(desde, hasta)
                        End If
                    Else
                        DesdeDate()
                        If rbCliAct.Checked Then
                            Me.dgvClientes.DataSource = ClientesSP.BuscarClienteFecha(desde)
                        Else
                            Me.dgvClientes.DataSource = ClientesSP.BuscarClienteDesFecha(desde)
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
        Dim rectFila As Rectangle = dgvClientes.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvClientes.Top + rectFila.Top + dgvClientes.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvClientes.Left, dgvClientes.Top + rectFila.Top + dgvClientes.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvClientes.Left, dgvClientes.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Número de cliente", CInt(filaSeleccionada.Cells(0)?.Value))
        dgvPanelDesp.Rows.Add("Correo", filaSeleccionada.Cells(5)?.Value.ToString())

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

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown
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