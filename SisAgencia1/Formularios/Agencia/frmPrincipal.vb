#Region "Imports"
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Net.Security
Imports System.Runtime.Intrinsics
Imports System.Windows.Media.Media3D
Imports System.Diagnostics
Imports System.IO
#End Region

Public Class frmPrincipal

#Region "Shared Function"
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function
#End Region

#Region "Declaraciones"
    Dim ctrl As Control
    Dim FrmClientes As New frmClientes
    Public bMax As Boolean = False
    Dim tamañominimo As Boolean = False
#End Region

#Region "Subrutina"




    Private ultimoBotonActivo As Button = Nothing

    Public Sub IluminarBoton(btn As Button)
        ' Si hay un botón iluminado, lo desiluminamos

        If ultimoBotonActivo IsNot Nothing Then
            If ultimoBotonActivo.Text = "      Vender" Then
                ultimoBotonActivo.BackColor = Color.Transparent
            Else
                ultimoBotonActivo.BackColor = Color.FromArgb(30, 63, 111) ' Color por defecto o desiluminado
            End If
        End If


        ' Iluminamos el nuevo botón
        btn.BackColor = Color.FromArgb(60, 117, 202) ' Color de iluminación
        ultimoBotonActivo = btn ' Guardamos el botón como último activo
    End Sub







































    Public Sub New()
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        OpacidadNo(Me)
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub InicioDesp()
        VerPanel(pnlArchivo)
        VerPanel(pnlDatos)
    End Sub
    Public Sub CerrarSesion()
        Dim formulariosACerrar As Form() = {Me, frmMenu, frmVenCli, FrmClientes, frmAgrVent, frmTelefonos, frmAgrUsu, frmContraseña, frmEmpleados, frmEmpUsu, frmUsuarios, frmChof, frmProv, frmSelProv, frmServ, frmServProv, frmOp, frmOpChofVeh, frmSelChof, frmVeh}
        CerrarFormularios(formulariosACerrar)
    End Sub

    Public Sub AbrirFormulario(f As Form)
        pnlPpal.Controls.Clear()
        'Establezco la propiedad toplevel del formualrio en falso para poder agregar un formulario dentro de otro
        f.TopLevel = False
        'Quito los bordes del formulario a abrir dentro del panel
        f.FormBorderStyle = FormBorderStyle.None
        pnlPpal.Controls.Add(f)
        f.Show()
        f.Dock = DockStyle.Fill
    End Sub

    Public Sub AbrirFormulario2(f As Form)

        ' Si el formulario principal está maximizado
        'If bMax = True Then
        '    ' Ajustar el formulario a ocupar toda la pantalla
        '    f.WindowState = FormWindowState.Maximized ' Primero asegúrate de que no esté maximizado
        '    f.Bounds = Screen.PrimaryScreen.Bounds ' Establecer su tamaño a la pantalla completa
        'Else
        '    ' Si no está maximizado, mostrar el formulario con su tamaño normal
        '    f.WindowState = FormWindowState.Normal
        'End If

        ' Limpiar los controles dentro del panel principal

        ' El formulario no debe ser un nivel superior para poder embeberse dentro de otro contenedor
        f.TopLevel = True

        ' Quitar los bordes del formulario
        f.FormBorderStyle = FormBorderStyle.None

        ' Agregar el formulario al panel

        ' Ajustar el formulario para que ocupe todo el espacio del panel
        f.Dock = DockStyle.Fill

        ' Mostrar el formulario
        f.Show()
    End Sub

    Private Sub TogglePanel()
        If pnlMnuDesp.Visible Then
            AnimateWindow(pnlMnuDesp.Handle, 150, AW_HOR_NEGATIVE Or AW_SLIDE Or AW_HIDE)
            MinimizarPanel(pnlMnuDesp)

        Else
            AnimateWindow(pnlMnuDesp.Handle, 150, AW_HOR_POSITIVE Or AW_SLIDE)
            VerPanel(pnlMnuDesp)


        End If
        RoundCornersTop(btnArchivo, 10)
        'RoundCornersBottom(pnlHerr, 10)
        'RoundCornersBottom(btnAyuda, 10)
        'RoundCornersBottom(btnConfig, 10)
    End Sub

    Private Sub MoverFrmPpal(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left And tamañominimo = False Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub AbrFrmDesdePnl(frm As Form)
        CerrarForms()
        VerPanel(btnVolver)
        VerPanel(btnInicio2)
        'ActualizarUltimosFormularios(frm.Name)
    End Sub

    Public Sub CerrarForms()
        Dim formulariosACerrar As Form() = {frmVenCli, frmOp, frmSelChof, FrmClientes, frmAgrVent, frmSelProv, frmEmpUsu, frmEmpleados, frmUsuarios, frmServProv, frmProv, frmServ, frmOpChofVeh, frmChof, frmVeh, frmTelefonos, frmAgrUsu, frmContraseña, frmEmpUsu}

        ' Cambiar los botones de los formularios a su estado predeterminado
        For Each form In formulariosACerrar
            CambiarBtnADefault(form.Name)
        Next

        ' Cerrar los formularios
        CerrarFormularios(formulariosACerrar)

        ' Abrir el panel de menú y minimizar otros paneles
        AbrirFormPanel(frmMenu, pnlPpal)
        MinimizarPanel(pnlMnuDesp)
        MinimizarPanel(btnVolver)
    End Sub


    Public Sub RoundCornersTop(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()

        ' Esquina superior izquierda (redondeada)
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        ' Línea recta hasta la esquina superior derecha
        path.AddLine(bounds.X + radius, bounds.Y, bounds.X + bounds.Width - radius, bounds.Y)
        ' Esquina superior derecha (redondeada)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90)
        ' Línea recta hacia la esquina inferior derecha
        path.AddLine(bounds.X + bounds.Width, bounds.Y + radius, bounds.X + bounds.Width, bounds.Y + bounds.Height)
        ' Línea recta hacia la esquina inferior izquierda
        path.AddLine(bounds.X + bounds.Width, bounds.Y + bounds.Height, bounds.X, bounds.Y + bounds.Height)
        ' Línea recta hacia la esquina superior izquierda
        path.AddLine(bounds.X, bounds.Y + bounds.Height, bounds.X, bounds.Y)

        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

    Public Sub RoundCornersBottom(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()

        ' Línea recta hacia la esquina superior izquierda
        path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y + bounds.Height - radius)
        ' Esquina inferior izquierda (redondeada)
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90)
        ' Línea recta hasta la esquina inferior derecha
        path.AddLine(bounds.X, bounds.Y + bounds.Height, bounds.X + bounds.Width, bounds.Y + bounds.Height)
        ' Esquina inferior derecha (redondeada)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90)
        ' Línea recta hacia la esquina superior derecha
        path.AddLine(bounds.X + bounds.Width, bounds.Y + bounds.Height - radius, bounds.X + bounds.Width, bounds.Y)

        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

#End Region

#Region "Eventos"
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elprogramadebecerrarse = False
        Dim Pantalla As Size = Screen.PrimaryScreen.Bounds.Size
        Select Case Pantalla
            Case New Size(1920, 1080)
            Case New Size(1768, 992)
            Case New Size(1680, 1050)
                MinimizarPanel(btnMiniMax)
                tamañominimo = True
            Case New Size(1600, 1024)
            Case New Size(1600, 900)
            Case New Size(1440, 1080)
            Case New Size(1440, 900)
            Case New Size(1366, 768)
                MinimizarPanel(btnMiniMax)
                frmMenu.Panel2.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Sombra3.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Label22.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.ckbMosCon.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Label21.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Button2.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Button3.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.btnRefresh.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.pnlCotAge.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Sombra2.Anchor = AnchorStyles.Bottom And AnchorStyles.Right
                frmMenu.Panel1.Anchor = AnchorStyles.Bottom And AnchorStyles.Right

                tamañominimo = True
            Case Else
                MinimizarPanel(btnMiniMax)
                Dim respuesta = MessageBox.Show("El programa no está configurado para esta resolución. Si lo abre, la aplicación podría no verse y/o funcionar correctamente ¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If respuesta = DialogResult.No Then
                    Me.Hide()
                    elprogramadebecerrarse = True
                Else
                    elprogramadebecerrarse = False
                End If
        End Select
        InicioDesp()
        CentrarForm(Me)
        bMax = True
        Me.btnMiniMax.Image = My.Resources.icons8_cuadrado_redondeado_2_24
        FormBorderStyle = FormBorderStyle.None
        tsslNomUsu.Select()
        RoundCornersTop(btnArchivo, 10)
        frmMenu.RoundButton(btnExit, 10)
        frmMenu.RoundButton(btnMiniMax, 10)
        frmMenu.RoundButton(btnMini, 10)
        frmMenu.RoundButton(btnInicio2, 10)
        frmMenu.RoundButton(btnVolver, 10)
        'RoundCornersBottom(pnlHerr, 10)
        'RoundCornersBottom(pnlHerr, 10)
        'RoundCornersBottom(btnAyuda, 10)
        'RoundCornersBottom(btnConfig, 10)
        Me.Invalidate()
        Me.Update()
    End Sub

    Private Sub frmPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        Me.MaximumSize = Screen.FromControl(Me).Bounds.Size
        Maximizar(Me)
        OpacidadSi(Me)
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Me.SuspendLayout()
        If Me.WindowState = FormWindowState.Normal Then
            bMax = False
            btnMiniMax.Image = My.Resources.icons8_cuadrado_redondeado_24
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            bMax = True
            btnMiniMax.Image = My.Resources.icons8_cuadrado_redondeado_2_24
        End If
        'Me.ResumeLayout()
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        OcultarTodo()
    End Sub

    Private Sub frmPrincipal_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If Not pnlMnuDesp.ClientRectangle.Contains(pnlMnuDesp.PointToClient(Cursor.Position)) Then
            MinimizarPanel(pnlMnuDesp)
        End If
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
        Dim loginForm As frmLogin = frmLogin.ObtenerInstancia()
        If loginForm Is Nothing OrElse Not loginForm.Visible Then
            loginForm = New frmLogin()
            botonesInfo.Clear()
            loginForm.Show()
        End If
    End Sub

    Private Sub pnlPpal_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlPpal.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub LoginFormClosed(sender As Object, e As FormClosedEventArgs)
        Application.Exit()
    End Sub

#Region "Menú desplegable y Barra superior"
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        If Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            Dim respuesta As DialogResult = MessageBox.Show("Una venta está en curso ¿Estás seguro de que deseas cerrarla?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                CerrarForms()
                AgrSimulacion = False
            Else
                Return
            End If
        Else
            CerrarForms()
        End If
        frmMenu.OpSemanales()
        MinimizarPanel(btnInicio2)
    End Sub

    Private Sub btnInicio2_Click(sender As Object, e As EventArgs) Handles btnInicio2.Click
        If Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            Dim respuesta As DialogResult = MessageBox.Show("Una venta está en curso ¿Estás seguro de que deseas cerrarla?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                CerrarForms()
                AgrSimulacion = False
            Else
                Return
            End If
        Else
            CerrarForms()
        End If
        MinimizarPanel(btnInicio2)
        frmMenu.OpSemanales()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        MinimizarPanel(pnlMnuDesp)
        If Application.OpenForms.OfType(Of frmVenCli)().Any() Then
        ElseIf Application.OpenForms.OfType(Of frmMenu)().Any() Then
            'AbrirFormularioRe(frmVisorReportes)
            frmMenu.Visible = False
            AbrFrmDesdePnl(frmVenCli)
            frmMenu.ManejarFormulario(frmVenCli, frmVentas, frmVenCli.pnlVenCli, "frmVenCli")
            frmVenCli.tVent.Stop()
            'frmVisorReportes.Hide()
        Else
            'AbrirFormularioRe(frmVisorReportes)
            AbrFrmDesdePnl(frmVenCli)
            frmMenu.ManejarFormulario(frmVenCli, frmVentas, frmVenCli.pnlVenCli, "frmVenCli")
            frmVenCli.tVent.Stop()
            'frmVisorReportes.Hide()
        End If

    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        MinimizarPanel(pnlMnuDesp)
        If Application.OpenForms.OfType(Of frmServProv)().Any() Then
        ElseIf Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            Dim respuesta As DialogResult = MessageBox.Show("Una venta está en curso ¿Estás seguro de que deseas cerrarla?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                'AbrirFormularioRe(frmVisorReportes)
                AbrFrmDesdePnl(frmServProv)
                frmMenu.ManejarFormulario(frmServProv, frmServ, frmServProv.pnlServProv, "frmServProv")
                frmServProv.tServ.Stop()
                'frmVisorReportes.Hide()
            End If
        ElseIf Application.OpenForms.OfType(Of frmMenu)().Any() Then
            'AbrirFormularioRe(frmVisorReportes)
            frmMenu.Visible = False
            AbrFrmDesdePnl(frmServProv)
            frmMenu.ManejarFormulario(frmServProv, frmServ, frmServProv.pnlServProv, "frmServProv")
            frmServProv.tServ.Stop()
            'frmVisorReportes.Hide()
        Else
            'AbrirFormularioRe(frmVisorReportes)
            AbrFrmDesdePnl(frmServProv)
            frmMenu.ManejarFormulario(frmServProv, frmServ, frmServProv.pnlServProv, "frmServProv")
            frmServProv.tServ.Stop()
            'frmVisorReportes.Hide()
        End If
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        MinimizarPanel(pnlMnuDesp)
        If Application.OpenForms.OfType(Of frmOpChofVeh)().Any() Then
        ElseIf Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            Dim respuesta As DialogResult = MessageBox.Show("Una venta está en curso ¿Estás seguro de que deseas cerrarla?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                'AbrirFormularioRe(frmVisorReportes)
                AbrFrmDesdePnl(frmOpChofVeh)
                frmMenu.ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
                frmOpChofVeh.tiOp.Stop()
                'frmVisorReportes.Hide()
            End If
        ElseIf Application.OpenForms.OfType(Of frmMenu)().Any() Then
            'AbrirFormularioRe(frmVisorReportes)
            frmMenu.Visible = False
            AbrFrmDesdePnl(frmOpChofVeh)
            frmMenu.ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
            frmOpChofVeh.tiOp.Stop()
            'frmVisorReportes.Hide()
        Else
            'AbrirFormularioRe(frmVisorReportes)
            AbrFrmDesdePnl(frmOpChofVeh)
            frmMenu.ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
            frmOpChofVeh.tiOp.Stop()
            'frmVisorReportes.Hide()
        End If
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        MinimizarPanel(pnlMnuDesp)
        If Application.OpenForms.OfType(Of frmEmpUsu)().Any() Then
        ElseIf Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            Dim respuesta As DialogResult = MessageBox.Show("Una venta está en curso ¿Estás seguro de que deseas cerrarla?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                'AbrirFormularioRe(frmVisorReportes)
                AbrFrmDesdePnl(frmEmpUsu)
                frmMenu.ManejarFormulario(frmEmpUsu, frmEmpleados, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
                frmEmpUsu.tUsu.Stop()
                'frmVisorReportes.Hide()
            End If
        ElseIf Application.OpenForms.OfType(Of frmMenu)().Any() Then
            'AbrirFormularioRe(frmVisorReportes)
            frmMenu.Visible = False
            AbrFrmDesdePnl(frmEmpUsu)
            frmMenu.ManejarFormulario(frmEmpUsu, frmEmpleados, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
            frmEmpUsu.tUsu.Stop()
            ' frmVisorReportes.Hide()
        Else
            '  AbrirFormularioRe(frmVisorReportes)
            AbrFrmDesdePnl(frmEmpUsu)
            frmMenu.ManejarFormulario(frmEmpUsu, frmEmpleados, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
            frmEmpUsu.tUsu.Stop()
            '  frmVisorReportes.Hide()
        End If
    End Sub

    Private Sub btnHerr_Click(sender As Object, e As EventArgs) Handles btnHerr.Click
        If pnlHerr.Visible = True Then
            MinimizarPanel(pnlHerr)
        Else
            VerPanel(pnlHerr)
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If pnlDatos.Visible = True Then
            MinimizarPanel(pnlDatos)
        Else
            VerPanel(pnlDatos)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pnlMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuDesp.MouseDown
        MoverFrmPpal(pnlMnuDesp, e)
    End Sub
    Private Sub btnMnuDesp_Click(sender As Object, e As EventArgs) Handles btnMnuDesp.Click
        TogglePanel()
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        If pnlArchivo.Visible = True Then
            MinimizarPanel(pnlArchivo)
        Else
            VerPanel(pnlArchivo)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnMiniMax_Click(sender As Object, e As EventArgs) Handles btnMiniMax.Click
        'Me.SuspendLayout()
        If bMax = False Then
            Maximizar(Me) 'pasar a base?
            bMax = True
            Me.btnMiniMax.Image = My.Resources.icons8_cuadrado_redondeado_2_24
            frmVenCli.Mini()
            frmEmpUsu.MiniEmpUsu()
            frmOpChofVeh.MiniOpChofVeh()
            frmServProv.MiniServProv()
            frmMenu.MinimizarMenuT()
        Else
            bMax = False
            Me.btnMiniMax.Image = My.Resources.icons8_cuadrado_redondeado_24
            Minimizar(Me) 'pasar a base?
            frmMenu.MinimizarMenuF()
        End If
        'Me.ResumeLayout()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
    End Sub

    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        OcultarTodo()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        MinimizarPanel(pnlMnuDesp)
        If Application.OpenForms.OfType(Of frmConfig)().Any() Then
        ElseIf Application.OpenForms.OfType(Of frmMenu)().Any() Then
            frmMenu.Visible = False
            AbrFrmDesdePnl(frmConfig)
            AbrirFormulario(frmConfig)
        Else
            AbrFrmDesdePnl(frmConfig)
            AbrirFormulario(frmConfig)
        End If
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        ' Minimizar el panel
        MinimizarPanel(pnlMnuDesp)
        ' Ruta donde se guardará temporalmente el archivo
        Dim rutaTemp As String = Path.Combine(Path.GetTempPath(), "Manual.docx") ' o Manual.pdf si es PDF

        Try
            ' Extraer el archivo desde los recursos y guardarlo en la ruta temporal
            File.WriteAllBytes(rutaTemp, My.Resources.Manual)

            ' Configuración para iniciar el proceso con el visor predeterminado
            Dim psi As New ProcessStartInfo()
            psi.FileName = rutaTemp
            psi.UseShellExecute = True ' Esto usa el programa predeterminado del sistema para abrir el archivo

            ' Abrir el archivo con la aplicación predeterminada
            Process.Start(psi)
        Catch ex As Exception
            ' Mostrar un mensaje en caso de error
            MensajeNotificacion("No se pudo abrir el manual: " & ex.Message, "Error.")
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        MinimizarPanel(pnlMnuDesp)
        CerrarUltimoFormulario()
    End Sub

    Private Sub tsmiSalir_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        Me.Close()
    End Sub

    Private Sub tsmiCerrar_Click(sender As Object, e As EventArgs) Handles tsmiCerrar.Click
        CerrarSesion()
    End Sub

    Private Sub tsmiInicio_Click(sender As Object, e As EventArgs) Handles tsmiInicio.Click
        AbrirFormulario(frmLogin)
    End Sub
#End Region

#Region "Ocultar Panel"
    Private Sub btnInicio2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnInicio2.MouseDown
        OcultarTodo()
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Private Sub btnVolver_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVolver.MouseDown
        OcultarTodo()
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Private Sub btnMini_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMini.MouseDown
        OcultarTodo()
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Private Sub btnMiniMax_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMiniMax.MouseDown
        OcultarTodo()
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Private Sub btnExit_MouseDown(sender As Object, e As MouseEventArgs) Handles btnExit.MouseDown
        OcultarTodo()
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Private Sub pbMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles pbMnuDesp.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMnuDesp.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnArchivo_MouseDown(sender As Object, e As MouseEventArgs) Handles btnArchivo.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnInicio_MouseDown(sender As Object, e As MouseEventArgs) Handles btnInicio.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnSalir_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSalir.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub pnlArchivo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlArchivo.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnDatos_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDatos.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVentas.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnServicios_MouseDown(sender As Object, e As MouseEventArgs) Handles btnServicios.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnOperaciones_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOperaciones.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnUsuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUsuarios.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnHerr_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHerr.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnConfig_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConfig.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub btnAyuda_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAyuda.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub pnlDatos_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatos.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub

    Private Sub pnlHerr_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHerr.MouseDown
        OcultarTodoMenosPnlPpal()
    End Sub



    Private Sub pnlMnuTool_Paint(sender As Object, e As PaintEventArgs) Handles pnlMnuTool.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio As Color = Color.FromArgb(200, 30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin As Color = Color.FromArgb(200, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
        New Point(pnlMnuTool.Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlMnuTool.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlMnuTool_Resize(sender As Object, e As EventArgs) Handles pnlMnuTool.Resize
        pnlMnuTool.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
    End Sub

    Private Sub pnlMnuDesp_Resize(sender As Object, e As EventArgs) Handles pnlMnuDesp.Resize
        pnlMnuDesp.Invalidate()
    End Sub

    Private Sub pnlMnuDesp_Paint(sender As Object, e As PaintEventArgs) Handles pnlMnuDesp.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio As Color = Color.FromArgb(170, 30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin As Color = Color.FromArgb(170, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
        New Point(pnlMnuDesp.Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlMnuDesp.ClientRectangle)
        End Using
    End Sub


#End Region

#End Region

End Class