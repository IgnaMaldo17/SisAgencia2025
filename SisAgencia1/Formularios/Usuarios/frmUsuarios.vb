#Region "Imports"
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
Imports FastReport
Imports FastReport.Design.PageDesigners

#End Region

Public Class frmUsuarios

#Region "Declaraciones"
    Public CodUsu As Integer = 0
    Public VerNomUsu As String
    Dim HayError As Boolean = False
    Dim UsuariosSP As New clsUsu
    Dim UsuarioDatos As New eUsu
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
        If dgvUsuarios IsNot Nothing AndAlso dgvUsuarios.Columns.Count > 0 Then
            ' Definir el orden deseado de las columnas
            Dim ordenColumnas As New List(Of String) From {"Número de usuario", "Apellido", "Nombre", "Usuario", "Rol", "Motivo Deshabilitar", "Fecha de creación"}
            ' Verificar si el DataGridView contiene las columnas antes de intentar establecer su orden
            For Each nombreColumna As String In ordenColumnas
                If dgvUsuarios.Columns.Contains(nombreColumna) Then
                    Dim columnIndex As Integer = dgvUsuarios.Columns(nombreColumna).Index
                    If columnIndex < dgvUsuarios.Columns.Count Then
                        dgvUsuarios.Columns(nombreColumna).DisplayIndex = ordenColumnas.IndexOf(nombreColumna)
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

    Private Sub GetUsuAct()
        dgvUsuarios.DataSource = UsuariosSP.GetUsuarios()
    End Sub

    Private Sub GetUsuCan()
        dgvUsuarios.DataSource = UsuariosSP.GetUsuariosCancel()
    End Sub

    Private Sub CargaCmbTpUsuario()
        cmbTpUsu.DataSource = UsuariosSP.GetTpUsuarios()
        cmbTpUsu.ValueMember = "ID"
        cmbTpUsu.DisplayMember = "NOMBRE"
    End Sub

    Private Sub Desactivar()
        ControlFalse(txtUsu)
        ControlFalse(cmbTpUsu)
        ControlFalse(btnMod)
        ControlFalse(btnModCon)
    End Sub

    Public Sub Determinar()
        If rbUsuAct.Checked = True Then
            GetUsuAct()
            'If dgvUsuarios IsNot Nothing AndAlso dgvUsuarios.Columns.Count > 0 Then
            '    If dgvUsuarios.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvUsuarios.Columns("Motivo Deshabilitar").Visible = False
            '        'If frmPrincipal.bMax = True Then
            '        '    dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '        'Else
            '        '    dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '        'End If
            '    End If
            'End If
        Else
            GetUsuCan()
            'If dgvUsuarios IsNot Nothing AndAlso dgvUsuarios.Columns.Count > 0 Then
            '    If dgvUsuarios.Columns.Contains("Motivo Deshabilitar") Then
            '        dgvUsuarios.Columns("Motivo Deshabilitar").Visible = True
            '        'dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            '    End If
            'End If
        End If

        If frmPrincipal.bMax = True Then
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub HabilitarBase()
        txtUsu.Focus()
        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(43, 88, 157)
        ControlTrue(txtUsu)
        ControlTrue(btnModCon)
        VerPanel(btnMod)
        ControlTrue(btnMod)
    End Sub

    Private Sub HabilitarMod()
        ep.Clear()
        btnCancelar.ForeColor = Color.Firebrick
        btnCancelar.Image = My.Resources.icons8_cancelar_rojo_30
        ControlTrue(btnCancelar)
        If CodTpUsu = 1 Then
            HabilitarBase()
            ControlTrue(cmbTpUsu)
            ControlTrue(btnResEli)
        Else
            If NomUsuCamCon = NomUsu Then
                HabilitarBase()
                ControlFalse(cmbTpUsu)
            Else
                VerPanel(btnMod)
                Desactivar()
                ControlFalse(btnResEli)
                DisabledColor()
            End If
        End If

    End Sub

    Public Sub HabilitarNo()
        Limpiar()
        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
        ControlFalse(btnCancelar)
        ep.Clear()
        ControlFalse(btnResEli)
        Desactivar()
        ClearText(txtUsu)
        cmbTpUsu.Text = ""
        cmbTpUsu.SelectedIndex = -1
        DisabledColor()
        btnCancelar.ForeColor = Color.FromArgb(30, 63, 111)
        btnCancelar.Image = My.Resources.icons8_cancelar_nuevo_30
        ClearInt(CodUsu)
        txtBusUsu.Text = "Buscar"
        txtBusUsu.ForeColor = Color.Gray
        Determinar()
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
        DefaultBusColor()
    End Sub

    Public Sub Cargar()
        If txtBusUsu.Text.Length = 0 Or txtBusUsu.ForeColor = Color.Gray Then
            Determinar()
        Else
            If rbUsuAct.Checked Then
                Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarios(txtBusUsu.Text)
            Else
                Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioBaja(txtBusUsu.Text)
            End If
        End If
        EstablecerOrdenColumnasAct()
    End Sub

    Public Sub MinimizarUsuarioT()
        Me.dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarUsuarioF()
        Me.dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub

    Public Sub Deshabilitar2()
        Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un usuario ¿Desea continuar?", "Deshabilitar usuario.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            UsuarioDatos.MotivoDes = MotivoDeshabilitar
            If NomUsu = VerNomUsuTabla Then
                MensajeNotificacion("No puedes auto-deshabilitarte.", "Error.")
            Else
                If UsuariosSP.BajaUsuario(CodUsuTabla, modVariables.CodUsu, UsuarioDatos) Then
                    MensajeNotificacion("Usuario deshabilitado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar deshabilitar al usuario.", "Error.")
                End If
            End If
        End If
    End Sub

    Public Sub Restaurar2()
        Dim usuario As New clsUsu
        Dim tabla As New DataTable
        tabla = usuario.VerificarEmpUsu(CodUsuTabla)
        If tabla(0)(0) = 2 Then
            If UsuariosSP.RecUsuarios(CodUsuTabla) Then
                MensajeNotificacion("Usuario recuperado exitosamente.", "Éxito.")
                HabilitarNo()
                Determinar()
                'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
            Else
                MensajeNotificacion("Hubo un error al intentar recuperar el usuario.", "Error.")
            End If
        Else
            MensajeNotificacion("El usuario pertenece a un empleado eliminado, por lo que el empleado debe ser restaurado primero.", "Error.")
        End If
    End Sub

    Public Sub EliResUsu()
        If btnResEli.Text = "Deshabilitar" Then
            Dim resultado As DialogResult = MessageBox.Show("Está por deshabilitar un usuario ¿Desea continuar?", "Deshabilitar usuario " & txtUsu.Text & ".", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then
                UsuarioDatos.MotivoDes = MotivoDeshabilitar
                If NomUsu = VerNomUsu Then
                    MensajeNotificacion("No puedes auto-deshabilitarte, " & txtUsu.Text & ".", "Error.")
                Else
                    If UsuariosSP.BajaUsuario(CodUsu, modVariables.CodUsu, UsuarioDatos) Then
                        MensajeNotificacion("Usuario deshabilitado exitosamente.", "Éxito.")
                        HabilitarNo()
                        Determinar()
                        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
                    Else
                        MensajeNotificacion("Hubo un error al intentar deshabilitar al usuario " & txtUsu.Text & ".", "Error.")
                    End If
                End If
            End If
        ElseIf btnResEli.Text = "Restaurar" Then
            Dim usuario As New clsUsu
            Dim tabla As New DataTable
            tabla = usuario.VerificarEmpUsu(CodUsu)
            If tabla(0)(0) = 2 Then
                If UsuariosSP.RecUsuarios(CodUsu) Then
                    MensajeNotificacion("Usuario recuperado exitosamente.", "Éxito.")
                    HabilitarNo()
                    Determinar()
                    'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
                Else
                    MensajeNotificacion("Hubo un error al intentar recuperar el usuario " & txtUsu.Text & ".", "Error.")
                End If
            Else
                MensajeNotificacion("El usuario pertenece a un empleado eliminado, por lo que el empleado debe ser restaurado primero.", "Error.")
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
        frmPrincipal.IluminarBoton(frmEmpUsu.btnUsu) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        rbUsuAct.Checked = True
        CargaCmbTpUsuario()
        HabilitarNo()
        Cargar()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvUsuarios)
        If frmPrincipal.bMax = True Then
            MinimizarUsuarioT()
        Else
            MinimizarUsuarioF()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
        frmMenu.RoundButton(btnCancelar, 10)
        frmMenu.RoundButton(btnModCon, 10)
        frmMenu.RoundButton(btnResEli, 10)
        frmMenu.RoundButton(btnImpr, 10)
        frmMenu.RoundCornersBtn(rbUsuAct, 10)
        frmMenu.RoundCornersBtn2(rbUsuCan, 10)
        frmMenu.RoundButton(btnMod, 10)
        frmChof.RoundTopCornersBtn(btnBusxFecha, 10)
        IluminarFormulario()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub pnlDatUsu_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatUsu.Paint
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
        New Point(0, pnlDatUsu.Height),                    ' Punto de inicio
        New Point(pnlDatUsu.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatUsu.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatUsu_Resize(sender As Object, e As EventArgs) Handles pnlDatUsu.Resize
        pnlDatUsu.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub rbUsuAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsuAct.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Deshabilitar"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        HabilitarNo()
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvUsuarios.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvUsuarios.Rows.Count Then
                    Dim row As DataGridViewRow = dgvUsuarios.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodUsu = CInt(row.Cells(0)?.Value)
                        NomUsuCamCon = row.Cells(3)?.Value?.ToString()
                        txtUsu.Text = row.Cells(3)?.Value?.ToString()
                        cmbTpUsu.SelectedValue = row.Cells(7)?.Value?.ToString()
                        VerNomUsu = row.Cells(3)?.Value?.ToString()
                        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
                If CodTpUsu = 1 Then
                    HabilitarMod()
                    If rbUsuCan.Checked Then
                        Desactivar()
                        RestaurarColor()
                    Else
                        EliminarColor()
                    End If
                Else
                    HabilitarMod()
                End If
            End If
        End If
    End Sub

    Private Sub rbUsuCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsuCan.CheckedChanged
        Determinar()
        Cargar()
        HabilitarNo()
        DeshabilitarToolStripMenuItem.Text = "Restaurar"
    End Sub

    Private Sub dgvUsuarios_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvUsuarios.DataBindingComplete
        If dgvUsuarios.Columns.Count > 0 Then
            dgvUsuarios.Columns(dgvUsuarios.Columns.Count - 1).Visible = False
            dgvUsuarios.Columns(dgvUsuarios.Columns.Count - 3).Visible = False
            dgvUsuarios.Columns(dgvUsuarios.Columns.Count - 8).Visible = False
        End If
    End Sub

    Private Sub btnResEli_Click(sender As Object, e As EventArgs) Handles btnResEli.Click
        If CodTpUsu = 2 Then
            VarADMIN = 7
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            If btnResEli.Text = "Restaurar" Then
                EliResUsu()
            Else
                VarADMIN = 7
                Dim frmDesMotivo As New frmDesMotivo()
                frmDesMotivo.ShowDialog()
                frmDesMotivo.TopMost = True
            End If
        End If
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        ep.Clear()
        CampoBlanco2(Me.pnlDatUsu, ep)
        Dim usuario As New clsUsu
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        tabla = usuario.VerificarComboTpUsu(cmbTpUsu.SelectedValue)
        If tabla(0)(0) = 2 Then
            If banbl = True Then
                Dim errores As New Dictionary(Of Control, String)()
                ' Verificar campos vacíos y longitud mínima del usuario
                If txtUsu.Text = "" Then
                    errores(txtUsu) = "Debe ingresar un usuario."
                ElseIf txtUsu.Text.Length < 8 Then
                    errores(txtUsu) = "El usuario debe tener 8 caracteres o más."
                ElseIf Not ContieneLetra(txtUsu.Text) Then
                    errores(txtUsu) = "El usuario debe contener al menos una letra."
                ElseIf Not ContieneNumero(txtUsu.Text) Then
                    errores(txtUsu) = "El usuario debe contener al menos un número."
                End If
                ' Mostrar todos los errores con ErrorProvider
                For Each kvp In errores
                    Dim control As Control = kvp.Key
                    Dim mensaje As String = kvp.Value
                    ' Si ya se estableció un mensaje de error para este control, no se establece de nuevo.
                    If String.IsNullOrEmpty(ep.GetError(control)) Then
                        ep.SetError(control, mensaje)
                        HayError = True
                    End If
                Next
                If HayError = False Then
                    UsuarioDatos.CodUsu = CodUsu
                    UsuarioDatos.NomUsu = txtUsu.Text
                    UsuarioDatos.CodTpUsu = cmbTpUsu.SelectedValue
                    tabla2 = usuario.VerificarUsuMod(txtUsu.Text, UsuarioDatos)
                    If tabla2(0)(0) = 0 Then
                        If UsuariosSP.ModUsu(UsuarioDatos) Then
                            If CodUsu = 0 Then
                                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
                            Else
                                UsuarioDatos.CodUsu = CodUsu
                                MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                                'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
                                HabilitarNo()
                                Determinar()
                            End If
                        Else
                            MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                        End If
                    Else
                        ep.SetError(txtUsu, "El usuario ya está registrado.")
                    End If
                End If
                HayError = False
            ElseIf banbl = False Then
                CampoBlanco2(Me.pnlDatUsu, ep)
            End If
        Else
            ep.SetError(cmbTpUsu, "El tipo de usuario es incorrecto.")
        End If
    End Sub

    Private Sub btnModCon_Click(sender As Object, e As EventArgs) Handles btnModCon.Click
        Dim frmContraseña As New frmContraseña()
        frmContraseña.ShowDialog()
        frmContraseña.TopMost = True
    End Sub

    Private Sub frmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#Region "Ocultar Panel"
    Private Sub frmUsuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
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

    Private Sub pnlDatUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatUsu.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnCancelar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancelar.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles txtUsu.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub cmbTpUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbTpUsu.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnModCon_MouseDown(sender As Object, e As MouseEventArgs) Handles btnModCon.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnMod_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMod.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub btnResEli_MouseDown(sender As Object, e As MouseEventArgs) Handles btnResEli.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub pnlDGVUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVUsu.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbUsuAct_MouseDown(sender As Object, e As MouseEventArgs) Handles rbUsuAct.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub rbUsuCan_MouseDown(sender As Object, e As MouseEventArgs) Handles rbUsuCan.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub dgvUsuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvUsuarios.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlDespDGV)
        OcultarFecha(pnlBusxFecha, btnBusxFecha)
    End Sub

    Private Sub txtBusUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusUsu.MouseDown
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
            If rbUsuAct.Checked = True Then
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpUsuH)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = UsuariosSP.GetUsuarios()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosUsu")
                ' Preparar el reporte
                reporte.Prepare()
                ' Imprimir el reporte
                reporte.Show()
            Else
                If conexionData.Contains("SISAGENCIA") Then
                    ' Cargar el recurso rpVentH si la conexión es a SQLEXPRESS01
                    reportStream = New IO.MemoryStream(My.Resources.rpUsuD)
                Else
                    MensajeNotificacion("La base de datos utilizada no está en el servidor SISVENTAS, para poder imprimir los formularios debe estar conectado a dicho servidor.", "Error.")
                    Return
                End If

                reporte.Load(reportStream) ' Cargar el flujo en el reporte
                ' Obtener el DataTable de tu procedimiento
                Dim dataTable As DataTable = UsuariosSP.GetUsuariosCancel()
                ' Registrar el DataTable en el reporte
                reporte.RegisterData(dataTable, "MosBajUsu")
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
    Dim CodUsuTabla As Integer
    Dim VerNomUsuTabla As String

    Private Sub dgvUsuarios_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUsuarios.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ' Asegúrate de que el clic fue en una celda válida
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Selecciona la celda donde se hizo clic
                dgvUsuarios.CurrentCell = dgvUsuarios.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ' Almacena la fila seleccionada
                filaSeleccionada = dgvUsuarios.Rows(e.RowIndex)
                CodUsuTabla = CInt(filaSeleccionada.Cells(0)?.Value)
                VerNomUsuTabla = filaSeleccionada.Cells(3)?.Value?.ToString()
                ' Muestra el ContextMenuStrip en la posición del mouse
                cmsUsu.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ' Verifica si hay una celda seleccionada en el DataGridView
        If dgvUsuarios.SelectedCells.Count > 0 Then
            ' Obtiene el índice de la fila seleccionada
            Dim rowIndex As Integer = dgvUsuarios.SelectedCells(0).RowIndex
            ' Llama al método Modificar con el DataGridView y el índice de la fila
            Modificar(dgvUsuarios, rowIndex)
        End If
    End Sub

    Private Sub Modificar(ByVal dgv As DataGridView, ByVal rowIndex As Integer)
        If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then ' Verifica si se hizo clic en una celda válida
            If dgv.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If rowIndex >= 0 AndAlso rowIndex < dgv.Rows.Count Then
                    Dim row As DataGridViewRow = dgv.Rows(rowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        HabilitarNo()
                    Else
                        CodUsu = CInt(row.Cells(0)?.Value)
                        NomUsuCamCon = row.Cells(3)?.Value?.ToString()
                        txtUsu.Text = row.Cells(3)?.Value?.ToString()
                        cmbTpUsu.SelectedValue = row.Cells(7)?.Value?.ToString()
                        VerNomUsu = row.Cells(3)?.Value?.ToString()
                        'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(43, 88, 157)
                    End If
                End If
                If CodTpUsu = 1 Then
                    HabilitarMod()
                    If rbUsuCan.Checked Then
                        Desactivar()
                        RestaurarColor()
                    Else
                        EliminarColor()
                    End If
                Else
                    HabilitarMod()
                End If
            End If
        End If
    End Sub

    Private Sub DeshabilitarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshabilitarToolStripMenuItem.Click
        If DeshabilitarToolStripMenuItem.Text = "Deshabilitar" Then
            If filaSeleccionada IsNot Nothing Then
                CodUsuTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 30
                    Dim frmAdmin As New frmAdmin()
                    frmAdmin.ShowDialog()
                    frmAdmin.TopMost = True
                Else
                    VarADMIN = 30
                    Dim frmDesMotivo As New frmDesMotivo()
                    frmDesMotivo.ShowDialog()
                    frmDesMotivo.TopMost = True
                End If
            End If
        ElseIf DeshabilitarToolStripMenuItem.Text = "Restaurar" Then
            If filaSeleccionada IsNot Nothing Then
                CodUsuTabla = filaSeleccionada.Cells(0).Value.ToString()
                If CodTpUsu = 2 Then
                    VarADMIN = 31
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
#End Region

#Region "Buscar x Fecha"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub txtBusUsu_Enter(sender As Object, e As EventArgs) Handles txtBusUsu.Enter
        If txtBusUsu.Text = "Buscar" Then
            ClearText(txtBusUsu)
            txtBusUsu.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusUsu_Leave(sender As Object, e As EventArgs) Handles txtBusUsu.Leave
        If String.IsNullOrWhiteSpace(txtBusUsu.Text) Then
            txtBusUsu.Text = "Buscar"
            txtBusUsu.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub txtBusUsu_TextChanged(sender As Object, e As EventArgs) Handles txtBusUsu.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusUsu_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusUsu.MouseClick
        If txtBusUsu.Text = "Buscar" Then
            ClearText(txtBusUsu)
            txtBusUsu.ForeColor = Color.Black
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
        ControlTrue(txtBusUsu)
    End Sub

    Private Sub CancelarBusColor()
        ColorCambio(btnBusxDia, "   Cancelar Búsqueda", My.Resources.icons8_cancelar_24, Color.Firebrick, Color.Maroon, Color.Firebrick)
        ControlFalse(txtBusUsu)
    End Sub

    Private Sub Limpiar()
        ComboSelIdx(cmbAnho)
        ComboSelIdx(cmbMes)
        ComboSelIdx(cmbDia)
        ComboSelIdx(cmbAnhoH)
        ComboSelIdx(cmbMesH)
        ComboSelIdx(cmbDiaH)
        'Limpiar2()
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
                    If rbUsuAct.Checked Then
                        Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioFechaHasta(desde, hasta)
                    Else
                        Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioDesFechaHasta(desde, hasta)
                    End If
                Else
                    If cmbDia.SelectedIndex = 0 And cmbMes.SelectedIndex <> 0 Then
                        FechasCmbSinDiaDesde(cmbAnho, cmbMes, desde, hasta)
                        If rbUsuAct.Checked Then
                            Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioFechaHasta(desde, hasta)
                        Else
                            Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioDesFechaHasta(desde, hasta)
                        End If
                    Else
                        DesdeDate()
                        If rbUsuAct.Checked Then
                            Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioFecha(desde)
                        Else
                            Me.dgvUsuarios.DataSource = UsuariosSP.BuscarUsuarioDesFecha(desde)
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
        Dim rectFila As Rectangle = dgvUsuarios.GetRowDisplayRectangle(filaSeleccionada.Index, False)

        ' Verificar el espacio disponible debajo del DataGridView
        Dim espacioDisponibleAbajo As Integer = Me.ClientSize.Height - (dgvUsuarios.Top + rectFila.Top + dgvUsuarios.Rows(filaSeleccionada.Index).Height + pnlDespDGV.Height)

        ' Posicionar el panel debajo si hay suficiente espacio, de lo contrario, arriba
        If espacioDisponibleAbajo >= 0 Then
            pnlDespDGV.Location = New Point(dgvUsuarios.Left, dgvUsuarios.Top + rectFila.Top + dgvUsuarios.Rows(filaSeleccionada.Index).Height)
        Else
            ' Si no hay suficiente espacio, colocar el panel arriba
            pnlDespDGV.Location = New Point(dgvUsuarios.Left, dgvUsuarios.Top + rectFila.Top - pnlDespDGV.Height)
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
        dgvPanelDesp.Rows.Add("Número de usuario", CInt(filaSeleccionada.Cells(0)?.Value))

        If rbUsuCan.Checked = True Then
            dgvPanelDesp.Rows.Add("Motivo de Deshabilitado", filaSeleccionada.Cells(5)?.Value.ToString)
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

End Class