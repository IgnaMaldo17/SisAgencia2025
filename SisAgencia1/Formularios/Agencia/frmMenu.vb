#Region "Imports"
Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports Datos
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports Entidades
Imports System.Runtime.Intrinsics
#End Region

Imports System.Data.SqlClient
Public Class frmMenu

#Region "Declaraciones"
    Dim UsuariosSP As New clsUsu
    Dim OperacionesSP As New clsOp
    Private Const MaxFilas As Integer = 5
    Private Const BotonesPorFila As Integer = 4
    Private Const BotonAncho As Integer = 88
    Private Const BotonAlto As Integer = 80
    Private Const Espacio As Integer = 21
    Private Const Margen As Integer = 10
    Public privateFonts As New PrivateFontCollection()
    Dim full As Point
#End Region

#Region "Funciones"
    Public Sub FavoritosUsu()
        Dim tabla As New DataTable
        tabla = UsuariosSP.GetFav(CodUsu)
        For Each fila As DataRow In tabla.Rows
            For Each item As Object In fila.ItemArray
                Dim numero As Integer = Convert.ToInt32(item)
                Select Case numero
                    Case 1
                        botonesInfo.Add(New Tuple(Of String, Image)("Clientes", My.Resources.icons8_clientes_50))
                    Case 2
                        botonesInfo.Add(New Tuple(Of String, Image)("Ventas", My.Resources.icons8_ventas_azul_50))
                    Case 3
                        botonesInfo.Add(New Tuple(Of String, Image)("Det. Ventas", My.Resources.icons8_ventas_50__1_))
                    Case 4
                        botonesInfo.Add(New Tuple(Of String, Image)("Proveedores", My.Resources.icons8_building_with_rooftop_terrace_50))
                    Case 5
                        botonesInfo.Add(New Tuple(Of String, Image)("Servicios", My.Resources.icons8_parque_nacional_501))
                    Case 6
                        botonesInfo.Add(New Tuple(Of String, Image)("Operaciones", My.Resources.icons8_waypoint_map_50))
                    Case 7
                        botonesInfo.Add(New Tuple(Of String, Image)("Choferes", My.Resources.icons8_taxi_driver_50))
                    Case 8
                        botonesInfo.Add(New Tuple(Of String, Image)("Vehículos", My.Resources.icons8_auto_50))
                    Case 9
                        botonesInfo.Add(New Tuple(Of String, Image)("Empleados", My.Resources.icons8_empleados_50))
                    Case 10
                        botonesInfo.Add(New Tuple(Of String, Image)("Usuarios", My.Resources.icons8_usuario_50))
                    Case Else
                End Select
            Next
        Next
    End Sub

    Public Sub New()
        InitializeComponent()
        OpacidadNo(Me)
        LoadCustomFont()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Public Sub CustomFont(lbl As Label)
        Dim fontPath As String = Path.Combine(Application.StartupPath, "Fonts", "Merriweather-Bold.ttf")
        ' Cargar la fuente en la colección privada
        privateFonts.AddFontFile(fontPath)
        ' Asignar la fuente personalizada a un control
        Dim miFuentePersonalizada As New Font(privateFonts.Families(0), 14.0F)
        Dim miFuentePersonalizadac As New Font(privateFonts.Families(0), 12.0F)
        Dim miFuentePersonalizadacc As New Font(privateFonts.Families(0), 8.0F)
        Dim miFuentePersonalizadag As New Font(privateFonts.Families(0), 24.0F)

        lbl.Font = miFuentePersonalizada
        lbl.ForeColor = Color.FromArgb(209, 223, 243)
        lbl.BackColor = Color.Transparent
    End Sub

    Public Sub LoadCustomFont()
        ' Ruta del archivo de fuente en el directorio de salida
        Dim fontPath As String = Path.Combine(Application.StartupPath, "Fonts", "Merriweather-Bold.ttf")
        ' Cargar la fuente en la colección privada
        privateFonts.AddFontFile(fontPath)
        ' Asignar la fuente personalizada a un control
        Dim miFuentePersonalizada As New Font(privateFonts.Families(0), 14.0F)
        Dim miFuentePersonalizadac As New Font(privateFonts.Families(0), 12.0F)
        Dim miFuentePersonalizadacc As New Font(privateFonts.Families(0), 8.0F)
        Dim miFuentePersonalizadag As New Font(privateFonts.Families(0), 24.0F)
        Label3.Font = miFuentePersonalizada
        Label20.Font = miFuentePersonalizada
        Label4.Font = miFuentePersonalizada
        Label21.Font = miFuentePersonalizada
        Label22.Font = miFuentePersonalizada
        bVentas.Font = miFuentePersonalizadacc
        bServicios.Font = miFuentePersonalizadacc
        bOperaciones.Font = miFuentePersonalizadacc
        bPersonal.Font = miFuentePersonalizadacc
        btnCamCon.Font = miFuentePersonalizadac
        Button4.Font = miFuentePersonalizadac
        btnIngresar.Font = miFuentePersonalizada
        Label1.Font = miFuentePersonalizadag
        Label2.Font = miFuentePersonalizadac
        Label17.Font = miFuentePersonalizadac
        Label18.Font = miFuentePersonalizadac
        Label19.Font = miFuentePersonalizadac
        Label6.Font = miFuentePersonalizadac
        Label5.Font = miFuentePersonalizadac
        Label11.Font = miFuentePersonalizadac
        Label15.Font = miFuentePersonalizadac
        Label16.Font = miFuentePersonalizadac
        Label14.Font = miFuentePersonalizadac
        Label7.Font = miFuentePersonalizadac
        Label9.Font = miFuentePersonalizadac
        Label12.Font = miFuentePersonalizadac
        Label8.Font = miFuentePersonalizadac
        Label10.Font = miFuentePersonalizadac
        Label13.Font = miFuentePersonalizadac
        Label24.Font = miFuentePersonalizadac
        Label25.Font = miFuentePersonalizadac
        Label32.Font = miFuentePersonalizadac
        Label33.Font = miFuentePersonalizadac
        Label34.Font = miFuentePersonalizadac
        Label35.Font = miFuentePersonalizadac
        Label36.Font = miFuentePersonalizadac
        Label37.Font = miFuentePersonalizadac
        Label30.Font = miFuentePersonalizada
        Label31.Font = miFuentePersonalizada
        Label38.Font = miFuentePersonalizada
    End Sub

    Dim Monedas As DataTable

    Public Sub GetCotizaciones()
        Monedas = UsuariosSP.GetCotizacion()

        ' Asegúrate de que Monedas tenga al menos el número de filas esperadas
        If Monedas.Rows.Count > 0 Then
            Label36.Text = Monedas.Rows(0)(1).ToString() ' Nombre de la moneda
            Label37.Text = Monedas.Rows(0)(2).ToString() ' Valor de la moneda
            Dolar = Convert.ToDouble(Label37.Text)
        End If

        If Monedas.Rows.Count > 1 Then
            Label35.Text = Monedas.Rows(1)(1).ToString() ' Nombre de la segunda moneda
            Label33.Text = Monedas.Rows(1)(2).ToString() ' Valor de la segunda moneda
            Euro = Convert.ToDouble(Label33.Text)
        End If

        If Monedas.Rows.Count > 2 Then
            Label34.Text = Monedas.Rows(2)(1).ToString() ' Nombre de la tercera moneda
            Label32.Text = Monedas.Rows(2)(2).ToString() ' Valor de la tercera moneda
            Real = Convert.ToDouble(Label32.Text)
        End If
        MonedaAgenciaFormato()
    End Sub

    Public Sub RoundCorners2(ByVal pnl As Panel, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()
        ' Esquina superior izquierda (no redondeada)
        path.AddLine(bounds.X, bounds.Y, bounds.X + bounds.Width - radius, bounds.Y) ' Línea recta desde la esquina superior izquierda hasta la superior derecha
        ' Esquina superior derecha (redondeada)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90)
        ' Esquina inferior derecha (redondeada)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90)
        ' Esquina inferior izquierda (redondeada)
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90)
        ' Línea recta desde la esquina inferior izquierda hasta la superior izquierda
        path.AddLine(bounds.X, bounds.Y + bounds.Height - radius, bounds.X, bounds.Y)
        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

    Public Sub RoundBottomLeftCorner(ByVal pnl As Panel, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()

        ' Añadir líneas rectas para las otras esquinas no redondeadas
        path.AddLine(bounds.X, bounds.Y, bounds.X + bounds.Width, bounds.Y) ' Línea superior
        path.AddLine(bounds.X + bounds.Width, bounds.Y, bounds.X + bounds.Width, bounds.Y + bounds.Height) ' Línea derecha
        path.AddLine(bounds.X + bounds.Width, bounds.Y + bounds.Height, bounds.X + radius, bounds.Y + bounds.Height) ' Línea inferior derecha

        ' Añadir arco en la esquina inferior izquierda
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90)

        ' Línea para conectar la esquina izquierda
        path.AddLine(bounds.X, bounds.Y + bounds.Height - radius, bounds.X, bounds.Y)

        ' Establecer la región del panel con la ruta creada
        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub



    Public Sub RoundCorners(ByVal pnl As Panel, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90)
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90)
        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

    Public Sub RoundCornersBtn2(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()
        ' Esquina superior izquierda (recta)
        path.AddLine(bounds.X, bounds.Y, bounds.X + bounds.Width - radius, bounds.Y) ' Línea recta desde la esquina superior izquierda hasta antes de la superior derecha
        ' Esquina superior derecha (redondeada)
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90)
        ' Esquina inferior derecha (recta)
        path.AddLine(bounds.X + bounds.Width, bounds.Y + radius, bounds.X + bounds.Width, bounds.Y + bounds.Height)
        ' Esquina inferior izquierda (recta)
        path.AddLine(bounds.X + bounds.Width, bounds.Y + bounds.Height, bounds.X, bounds.Y + bounds.Height)
        ' Línea recta hacia la esquina superior izquierda
        path.AddLine(bounds.X, bounds.Y + bounds.Height, bounds.X, bounds.Y)
        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub


    Public Sub RoundCornersBtn(ByVal pnl As Control, ByVal radius As Integer)
        Dim bounds As New Rectangle(0, 0, pnl.Width, pnl.Height)
        Dim path As New GraphicsPath()
        ' Solo redondear la esquina superior izquierda
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90) ' Esquina superior izquierda
        path.AddLine(bounds.X + radius, bounds.Y, bounds.X + bounds.Width, bounds.Y) ' Línea recta hacia la esquina superior derecha
        path.AddLine(bounds.X + bounds.Width, bounds.Y, bounds.X + bounds.Width, bounds.Y + bounds.Height) ' Línea recta hacia la esquina inferior derecha
        path.AddLine(bounds.X + bounds.Width, bounds.Y + bounds.Height, bounds.X, bounds.Y + bounds.Height) ' Línea recta hacia la esquina inferior izquierda
        path.AddLine(bounds.X, bounds.Y + bounds.Height, bounds.X, bounds.Y + radius) ' Línea recta hacia la esquina superior izquierda
        Dim roundedRectangle As New Region(path)
        pnl.Region = roundedRectangle
    End Sub

    Private Sub MostrarFormulariosEnLista()
        For Each nombreFormulario As String In UltimosFormularios
            MessageBox.Show(nombreFormulario)
        Next
    End Sub

    Private Sub Boton()
        Dim fontPath As String = Path.Combine(Application.StartupPath, "Fonts", "Merriweather-Bold.ttf")
        ' Cargar la fuente en la colección privada
        privateFonts.AddFontFile(fontPath)
        ' Asignar la fuente personalizada a un control
        Dim miFuentePersonalizadacc As New Font(privateFonts.Families(0), 8.0F)
        For Each info In botonesInfo
            ' Verificar si se ha alcanzado el número máximo de botones
            If pnlFavoritos.Controls.Count >= BotonesPorFila * MaxFilas Then
                MessageBox.Show("Se ha alcanzado el número máximo de botones permitidos.")
                Exit For
            End If
            Dim newButton As New Button()
            newButton.Text = info.Item1
            newButton.ForeColor = Color.FromArgb(30, 63, 111)
            newButton.FlatAppearance.BorderColor = Color.FromArgb(233, 239, 250)
            newButton.FlatStyle = FlatStyle.Flat
            newButton.FlatAppearance.BorderSize = 0
            newButton.Font = miFuentePersonalizadacc
            newButton.TextAlign = ContentAlignment.BottomCenter
            newButton.ImageAlign = ContentAlignment.TopCenter
            newButton.Image = info.Item2
            ' Configurar propiedades del botón (tamaño, ubicación, etc.)
            newButton.Size = New Size(BotonAncho, BotonAlto)
            ' Calcular la ubicación del nuevo botón
            Dim index As Integer = pnlFavoritos.Controls.Count
            Dim row As Integer = index \ BotonesPorFila
            Dim col As Integer = index Mod BotonesPorFila
            Dim x As Integer = Margen + col * (BotonAncho + Espacio)
            Dim y As Integer = Margen + row * (BotonAlto + Espacio)
            newButton.Location = New Point(x, y)
            ' Agregar el evento click para el nuevo botón
            AddHandler newButton.Click, AddressOf DynamicButton_Click
            ' Agregar el botón al Panel
            RoundButton(newButton, 40)
            pnlFavoritos.Controls.Add(newButton)
        Next
    End Sub

    Public Sub ManejarFormulario(principalForm As Form, panelForm As Form, panel As Panel, nombreFormulario As String)
        OcultarPanel()
        '  frmPrincipal.AbrirFormularioRe(frmVisorReportes)
        frmPrincipal.AbrirFormulario(principalForm)
        VerPanel(frmPrincipal.btnVolver)
        VerPanel(frmPrincipal.btnInicio2)
        ActualizarUltimosFormularios(nombreFormulario)
        AbrirFormPanel(panelForm, panel)
        ActualizarUltimosFormularios(panelForm.Name)

        '  frmVisorReportes.Hide()
    End Sub

    Private Sub ManejarFormulario(principalForm As Form)
        OcultarPanel()
        '  frmPrincipal.AbrirFormularioRe(frmVisorReportes)
        frmPrincipal.AbrirFormulario(principalForm)
        VerPanel(frmPrincipal.btnVolver)
        VerPanel(frmPrincipal.btnInicio2)
        ActualizarUltimosFormularios(principalForm.Name)
        ' frmVisorReportes.Hide()
    End Sub

    Private Sub FormatearComoMoneda(lbl As Label)
        Dim valorDecimal As Decimal
        If Decimal.TryParse(lbl.Text, valorDecimal) Then
            lbl.Text = String.Format("{0:C2}", valorDecimal)
        Else
            lbl.Text = "$0.00" ' O un valor predeterminado si no se puede convertir
        End If
    End Sub

    Public Sub MonedaAgenciaFormato()
        FormatearComoMoneda(Label37)
        FormatearComoMoneda(Label33)
        FormatearComoMoneda(Label32)
    End Sub

    Private Sub FormatearLabelsComoMoneda()
        ' Convertir y formatear los valores de las etiquetas

        FormatearComoMoneda(Label5)
        FormatearComoMoneda(Label11)
        FormatearComoMoneda(Label16)
        FormatearComoMoneda(Label14)
        FormatearComoMoneda(Label9)
        FormatearComoMoneda(Label12)
        FormatearComoMoneda(Label10)
        FormatearComoMoneda(Label13)
    End Sub

    Private Sub ObtenerCotizaciones()
        ObtenerDolarOficial(Label6, Label5, Label11)
        ObtenerDolarBlue(Label15, Label16, Label14)
        ObtenerEuro(Label7, Label9, Label12)
        ObtenerReal(Label8, Label10, Label13)
        MinimizarPanel(btnRefresh)
        FormatearLabelsComoMoneda()
    End Sub




    Public Sub RoundButton(button As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90)
        path.AddLine(cornerRadius, 0, button.Width - cornerRadius, 0)
        path.AddArc(New Rectangle(button.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90)
        path.AddLine(button.Width, cornerRadius, button.Width, button.Height - cornerRadius)
        path.AddArc(New Rectangle(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90)
        path.AddLine(button.Width - cornerRadius, button.Height, cornerRadius, button.Height)
        path.AddArc(New Rectangle(0, button.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90)
        path.CloseFigure()

        Dim roundedRectangle As New Region(path)
        button.Region = roundedRectangle
    End Sub

    Public Sub OpSemanales()
        Dim operacion As New clsOp
        Dim totalopsemana As Integer = operacion.VerificarTotalOperacionesSiguienteSemana()
        btnOpNew.Text = " " & totalopsemana.ToString()
    End Sub

    Private Sub CargaCmbPais()
        cmbCot.DataSource = UsuariosSP.GetCotizacion()
        cmbCot.ValueMember = "ID"
        cmbCot.DisplayMember = "NOMBRE"
    End Sub
#End Region

#Region "Eventos"

    Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Esto evita que se dibuje el rectángulo de enfoque
        Dim buttonRectangle As New Rectangle(0, 0, Me.Width, Me.Height)
        pevent.Graphics.DrawRectangle(New Pen(Me.BackColor, 1), buttonRectangle)
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.GotFocus
        Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
    End Sub

    Private Sub Button3_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.GotFocus
        Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
    End Sub

    Private Sub btnIngresar_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles btnIngresar.GotFocus
        Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
    End Sub

    Dim CargoCotizacion As Boolean = False

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCmbPais()
        cmbCot.SelectedIndex = 0
        Me.Size = New Size(1920, 1080)
        Me.Visible = False
        MinimizarPanel(Panel2)
        MinimizarPanel(Sombra3)
        FavoritosUsu()
        Boton()
        RoundBottomLeftCorner(pnlOpSemanales, 31)
        RoundButton(btnIngresar, 10)
        RoundButton(btnCamCon, 10)
        RoundButton(bPersonal, 41)
        RoundButton(bVentas, 41)
        RoundButton(bServicios, 41)
        RoundButton(bOperaciones, 41)
        RoundButton(btnFav, 21)
        RoundButton(btnConfigCot, 10)
        RoundButton(btnRefresh, 21)
        RoundButton(btnOpNew, 41)
        RoundButton(ckbMosCon, 21)
        RoundButton(ckbConver, 21)
        Button2.BackColor = Color.FromArgb(233, 239, 250)
        Button2.ForeColor = Color.FromArgb(30, 63, 111)
        GetCotizaciones()
        If HayInternet() = True Then
            If HaySistema() = True Then
                ObtenerCotizaciones()
                CargoCotizacion = True
                'MensajeNotificacion("El sistema de cotización se encuentra caído.", "Error.")
                'VerPanel(btnRefresh)
            End If
            'VerPanel(btnRefresh)
        End If
        'Button2.TabStop = False
        'Button3.TabStop = False
        'btnIngresar.TabStop = False

        'Button2.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.ResizeRedraw, True)
        'Button2.TabStop = False ' Esto evita el foco
        RoundCornersBtn(Button2, 21)
        RoundCornersBtn2(Button3, 21)
        VerPanel(pnlCotAge)
        MinimizarPanel(Panel1)
        Timer1.Start()
        Label2.Text = DateAndTime.Now.ToString("D")
        OpSemanales()
        RoundCorners(pnlFavoritos, 31)
        RoundCorners2(pnlCotAge, 31)
        RoundCorners2(Panel1, 31)
        RoundCorners(Panel2, 31)
        RoundCorners(Sombra, 31)
        RoundCorners(Sombra2, 31)
        RoundCorners(Sombra3, 31)
        AddHandler Me.Resize, AddressOf frmMenu_Resize
        SetDoubleBuffered(Panel1)
        SetDoubleBuffered(Panel2)
        SetDoubleBuffered(Button4)
        SetDoubleBuffered(pnlFavoritos)
        SetDoubleBuffered(Sombra)
        SetDoubleBuffered(Sombra2)
        SetDoubleBuffered(Sombra3)
        SetDoubleBuffered(pblBasBut)
        SetDoubleBuffered(pnlOpSemanales)
        If frmPrincipal.bMax = True Then
            MinimizarMenuT()
        Else
            MinimizarMenuF()
        End If
        Me.Visible = True
        frmVisorReportes.Hide()
        RoundCorners(pnlFavoritos, 30)
        RoundCorners(Sombra, 30)
        ckbMosCon.Checked = True
        SetDoubleBuffered(btnIngresar)
    End Sub

    Private Sub frmPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub frmMenu_Resize(sender As Object, e As EventArgs)
        If frmPrincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmPrincipal.WindowState = FormWindowState.Maximized Then
            MinimizarMenuT()
            RoundCorners(pnlFavoritos, 30)
            RoundCorners(Sombra, 30)
        ElseIf frmPrincipal.WindowState = FormWindowState.Normal Then
            MinimizarMenuF()
            RoundCorners(pnlFavoritos, 30)
            RoundCorners(Sombra, 30)
        End If
    End Sub

    Private Sub frmMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Now.ToString("HH:mm")
    End Sub

    Private Sub bOperaciones_Click(sender As Object, e As EventArgs) Handles bOperaciones.Click
        MinimizarPanel(pnlOpSemanales)
        ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
        frmOpChofVeh.tiOp.Stop()
    End Sub

    Private Sub bPersonal_Click(sender As Object, e As EventArgs) Handles bPersonal.Click
        MinimizarPanel(pnlOpSemanales)
        ManejarFormulario(frmEmpUsu, frmUsuarios, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
        frmEmpUsu.tUsu.Stop()
    End Sub

    Private Sub bVentas_Click(sender As Object, e As EventArgs) Handles bVentas.Click
        MinimizarPanel(pnlOpSemanales)
        ManejarFormulario(frmVenCli, frmVentas, frmVenCli.pnlVenCli, "frmVenCli")
        frmVenCli.tVent.Stop()
    End Sub

    Private Sub bServicios_Click(sender As Object, e As EventArgs) Handles bServicios.Click
        MinimizarPanel(pnlOpSemanales)
        ManejarFormulario(frmServProv, frmServ, frmServProv.pnlServProv, "frmServProv")
        frmServProv.tServ.Stop()
    End Sub

    Private Sub btnOpNew_Click(sender As Object, e As EventArgs) Handles btnOpNew.Click

        Button1.Text = btnOpNew.Text

        If btnOpNew.Text = 0 Then
            Label31.Visible = True
        Else
            Label31.Visible = False
            'pnlOpSemanales.Controls.Clear()
            ObtOp()

            If CInt(btnOpNew.Text) > 4 Then
                Label38.Text = "+" & CInt(btnOpNew.Text) - 4
                Label38.Visible = True
            Else
                Label38.Visible = False
            End If

        End If


        TogglePanel()
    End Sub

    Public Sub MinimizarMenuT()
        Me.BackgroundImage = My.Resources.output_onlinepngtools__1_5
    End Sub

    Public Sub MinimizarMenuF()
        Me.BackgroundImage = My.Resources.output_onlinepngtools
    End Sub

    Public Sub MiniMenu()
        Me.BackgroundImage = My.Resources.output_onlinepngtools__1_5
    End Sub

    Private Sub btnFav_Click(sender As Object, e As EventArgs) Handles btnFav.Click
        Dim frmFav As New frmFav()
        frmFav.ShowDialog()
        frmFav.TopMost = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        MinimizarPanel(pnlOpSemanales)
        MinimizarPanel(btnRefresh)
        If HayInternet() = True Then
            If HaySistema() = True Then
                ObtenerCotizaciones()
            Else
                MensajeNotificacion("El sistema de cotización se encuentra caído.", "Error.")
                VerPanel(btnRefresh)
                Return
            End If
        Else
            MensajeNotificacion("No hay conexión a internet, conectese a una red y vuelva a intentarlo.", "Error.")
            VerPanel(btnRefresh)
        End If
    End Sub



    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim resultado As DialogResult = MessageBox.Show("Está por iniciar una venta a un cliente ya registrado, sin embargo, puede simular una venta sin cliente ¿Desea iniciar una simulación de venta en vez de seleccionar un cliente?", "Iniciar venta.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            AgrSimulacion = True
            frmAgrVent.txtCli.Text = "Simulación sin Cliente."
            CodCliVender = 0
            frmPrincipal.AbrirFormulario(frmVenCli)
            VerPanel(frmPrincipal.btnVolver)
            VerPanel(frmPrincipal.btnInicio2)
            ActualizarUltimosFormularios("frmVenCli")
            AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
            ActualizarUltimosFormularios("frmAgrVent")
        ElseIf resultado = DialogResult.No Then
            VenderConVenCliAbierto = False
            Dim frmSelCli As New frmSelCli()
            frmSelCli.ShowDialog()
            frmSelCli.TopMost = True
        End If
        ActualizarUltimosFormularios("frmAgrVent")
        frmVenCli.tVent.Stop()
        frmAgrVent.IluminarFormulario()
    End Sub

    Public Sub DynamicButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Select Case clickedButton.Text
            Case "Clientes"
                'AbrirFormPanel(frmVisorReportes, frmVenCli.pnlVenCli)
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmVenCli, frmClientes, frmVenCli.pnlVenCli, "frmVenCli")
                frmVenCli.tVent.Stop()
            Case "Ventas"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmVenCli, frmVentas, frmVenCli.pnlVenCli, "frmVenCli")
                frmVenCli.tVent.Stop()
                'frmVenCli.btnVenV.BackColor = Color.FromArgb(30, 63, 111)
            Case "Det. Ventas"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmVenCli, frmDetVentas, frmVenCli.pnlVenCli, "frmVenCli")
                frmDetVentas.HabilitarNo()
                frmVenCli.tVent.Stop()
                VerPanel(frmVenCli.btnDetVent)
            Case "Proveedores"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmServProv, frmProv, frmServProv.pnlServProv, "frmServProv")
                frmServProv.tServ.Stop()
            Case "Servicios"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmServProv, frmServ, frmServProv.pnlServProv, "frmServProv")
                frmServProv.tServ.Stop()
                'frmServProv.btnServ.BackColor = Color.FromArgb(30, 63, 111)
            Case "Operaciones"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
                frmOpChofVeh.tiOp.Stop()
                'frmOpChofVeh.btnOp.BackColor = Color.FromArgb(30, 63, 111)
            Case "Choferes"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmOpChofVeh, frmChof, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
                frmOpChofVeh.tiOp.Stop()
            Case "Vehículos"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmOpChofVeh, frmVeh, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
                frmOpChofVeh.tiOp.Stop()
            Case "Empleados"
                ManejarFormulario(frmEmpUsu, frmEmpleados, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
                frmEmpUsu.tUsu.Stop()
            Case "Usuarios"
                MinimizarPanel(pnlOpSemanales)
                ManejarFormulario(frmEmpUsu, frmUsuarios, frmEmpUsu.pnlEmpUsu, "frmEmpUsu")
                frmEmpUsu.tUsu.Stop()
                'frmEmpUsu.btnUsu.BackColor = Color.FromArgb(30, 63, 111)
        End Select
    End Sub

    Public Sub ObtOp()
        ' Obtener los datos de la función que llama al procedimiento
        Dim dtOperaciones As DataTable = OperacionesSP.GetOperacionesCDPanel()

        ' Verificar si hay datos y crear los labels
        For i As Integer = 0 To Math.Min(3, dtOperaciones.Rows.Count - 1)
            Dim row As DataRow = dtOperaciones.Rows(i)

            ' Crear un nuevo label para cada fila
            Dim lbl As New Label()
            lbl.AutoSize = True
            lbl.TextAlign = ContentAlignment.MiddleCenter ' Centrar el texto

            ' Verificar si la columna "Hora" es nula o no es compatible
            Dim horaFormatted As String
            If Not IsDBNull(row("Hora")) AndAlso TypeOf row("Hora") Is TimeSpan Then
                horaFormatted = CType(row("Hora"), TimeSpan).ToString("hh\:mm")
            Else
                horaFormatted = "N/A" ' Valor predeterminado si no se puede convertir
            End If

            ' Configurar el texto con salto de línea
            lbl.Text = $"{row("Destino")}{Environment.NewLine}{CDate(row("Fecha")).ToString("dd/MM")} {horaFormatted}"
            CustomFont(lbl)
            ' Ajustar la posición del label
            lbl.Location = New Point((pnlOpSemanales.Width - lbl.PreferredWidth) / 2, 95 + (i * 75)) ' Centrado horizontal y espaciado vertical
            pnlOpSemanales.Controls.Add(lbl)
        Next
    End Sub


#Region "Ocultar Panel"
    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label20_MouseDown(sender As Object, e As MouseEventArgs) Handles Label20.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub btnOpNew_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpNew.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub pblBasBut_MouseDown(sender As Object, e As MouseEventArgs) Handles pblBasBut.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub bVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles bVentas.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub bServicios_MouseDown(sender As Object, e As MouseEventArgs) Handles bServicios.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub bOperaciones_MouseDown(sender As Object, e As MouseEventArgs) Handles bOperaciones.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub bPersonal_MouseDown(sender As Object, e As MouseEventArgs) Handles bPersonal.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub btnFav_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFav.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub pnlFavoritos_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlFavoritos.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Sombra_MouseDown(sender As Object, e As MouseEventArgs) Handles Sombra.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label21_MouseDown(sender As Object, e As MouseEventArgs) Handles Label21.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub btnRefresh_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRefresh.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Sombra2_MouseDown(sender As Object, e As MouseEventArgs) Handles Sombra2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label17_MouseDown(sender As Object, e As MouseEventArgs) Handles Label17.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label18_MouseDown(sender As Object, e As MouseEventArgs) Handles Label18.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label19_MouseDown(sender As Object, e As MouseEventArgs) Handles Label19.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label15_MouseDown(sender As Object, e As MouseEventArgs) Handles Label15.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label16_MouseDown(sender As Object, e As MouseEventArgs) Handles Label16.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label10.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label11_MouseDown(sender As Object, e As MouseEventArgs) Handles Label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label14_MouseDown(sender As Object, e As MouseEventArgs) Handles Label14.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label12_MouseDown(sender As Object, e As MouseEventArgs) Handles Label12.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label13_MouseDown(sender As Object, e As MouseEventArgs) Handles Label13.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub btnIngresar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnIngresar.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.FromArgb(233, 239, 250)
        Button2.ForeColor = Color.FromArgb(30, 63, 111)
        Button3.BackColor = Color.FromArgb(30, 63, 111)
        Button3.ForeColor = Color.FromArgb(233, 239, 250)
        Label21.Text = "Cotización"
        VerPanel(pnlCotAge)
        MinimizarPanel(Panel1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CargoCotizacion = True Then
            Button3.BackColor = Color.FromArgb(233, 239, 250)
            Button3.ForeColor = Color.FromArgb(30, 63, 111)
            Button2.BackColor = Color.FromArgb(30, 63, 111)
            Button2.ForeColor = Color.FromArgb(233, 239, 250)
            ObtenerFecha(Label21)
            VerPanel(Panel1)
            MinimizarPanel(pnlCotAge)
        Else
            If HayInternet() = True Then
                If HaySistema() = True Then
                    Button3.BackColor = Color.FromArgb(233, 239, 250)
                    Button3.ForeColor = Color.FromArgb(30, 63, 111)
                    Button2.BackColor = Color.FromArgb(30, 63, 111)
                    Button2.ForeColor = Color.FromArgb(233, 239, 250)
                    ObtenerCotizaciones()
                    ObtenerFecha(Label21)
                    VerPanel(Panel1)
                    MinimizarPanel(pnlCotAge)
                Else
                    MensajeNotificacion("El sistema de cotización se encuentra caído.", "Error.")
                    'VerPanel(btnRefresh)
                    Return
                End If
            Else
                MensajeNotificacion("No hay conexión a internet, conectese a una red y vuelva a intentarlo.", "Error.")
                'VerPanel(btnRefresh)
            End If
        End If
    End Sub

    Private Sub btnConfigCot_Click(sender As Object, e As EventArgs) Handles btnConfigCot.Click
        If CodTpUsu = 2 Then
            VarADMIN = 50
            Dim frmAdmin As New frmAdmin()
            frmAdmin.ShowDialog()
            frmAdmin.TopMost = True
        Else
            Dim frmContraseña As New frmConfig()
            frmContraseña.ShowDialog()
            frmContraseña.TopMost = True
        End If
    End Sub

    Private Sub ckbMosCon_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMosCon.CheckedChanged
        If ckbMosCon.Checked = True Then
            ckbMosCon.Image = My.Resources.icons8_visible_nuevo_24
            VerPanel(Panel2)
            VerPanel(Sombra3)
        Else
            ckbMosCon.Image = My.Resources.icons8_invisible_nuevo_24
            MinimizarPanel(Panel2)
            MinimizarPanel(Sombra3)
        End If
        'EnviarCorreoAutomatizado("Ignacio Leonel Maldonado", "nachi_17_@hotmail.com.ar", "Cataratas Argentinas", "17-07-2002")
    End Sub

    Private Sub txtCon_TextChanged(sender As Object, e As EventArgs) Handles txtCon.TextChanged
        If txtCon.Enabled Then
            FiltrarNoIntMonto(sender, e)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Enabled Then
            FiltrarNoIntMonto(sender, e)
        End If
    End Sub

    Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
        SoloIntMonto(sender, e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        SoloIntMonto(sender, e)
    End Sub

    Dim tasaCambio As Double

    Private Function RecortarDecimales(valor As String) As String
        ' Convierte el valor a un número decimal para manejo de precisión
        Dim numero As Decimal
        If Not Decimal.TryParse(valor, numero) Then
            Return valor ' Si no se puede convertir, retorna el valor original
        End If

        ' Redondea a dos decimales significativos no cero, o muestra "00" si es un número entero
        If numero < 1 AndAlso numero > 0 Then
            ' Para valores pequeños, redondea y muestra al menos dos dígitos significativos no cero
            Return numero.ToString("0.##00").TrimEnd("0"c).TrimEnd("."c)
        Else
            ' Para otros valores, muestra siempre dos decimales
            Return numero.ToString("N2")
        End If
    End Function


    Private Sub btnCamCon_Click(sender As Object, e As EventArgs) Handles btnCamCon.Click
        MinimizarPanel(pnlOpSemanales)
        Select Case cmbCot.SelectedIndex
            Case 0 ' Dólar
                tasaCambio = Dolar
            Case 1 ' Euro
                tasaCambio = Euro
            Case 2 ' Real
                tasaCambio = Real
            Case Else
                MensajeNotificacion("Seleccione una moneda válida.", "Aviso.")
                Exit Sub
        End Select

        If ConvertPesoaOtro = True Then
            If txtCon.Text <> "" Then
                Dim valorMoneda As Double
                If Double.TryParse(txtCon.Text, valorMoneda) Then
                    Dim resultado As String = (valorMoneda / tasaCambio).ToString("F10")
                    ' Recortar los ceros finales dejando al menos dos decimales
                    TextBox1.Text = "$" & RecortarDecimales(resultado)
                Else
                    MensajeNotificacion("Ingrese un valor numérico válido en la moneda seleccionada.", "Error.")
                End If
            End If
        Else
            If TextBox1.Text <> "" Then
                Dim valorPesos As Double
                If Double.TryParse(TextBox1.Text, valorPesos) Then
                    Dim resultado As String = (valorPesos * tasaCambio).ToString("F10")
                    ' Recortar los ceros finales dejando al menos dos decimales
                    txtCon.Text = "$" & RecortarDecimales(resultado)
                Else
                    MensajeNotificacion("Ingrese un valor numérico válido en Pesos.", "Error.")
                End If
            End If
        End If
    End Sub


    Dim ConvertPesoaOtro As Boolean = False

    Private Sub ckbConver_CheckedChanged(sender As Object, e As EventArgs) Handles ckbConver.CheckedChanged
        If ckbConver.Checked = True Then
            ckbConver.Image = My.Resources.icons8_flecha_derecha_242
            txtCon.Enabled = True
            TextBox1.Enabled = False
            ClearText(TextBox1)
            ClearText(txtCon)
            ConvertPesoaOtro = True
            txtCon.Focus()
        Else
            ckbConver.Image = My.Resources.icons8_flecha_izquierda_24
            txtCon.Enabled = False
            ClearText(txtCon)
            ClearText(TextBox1)
            TextBox1.Enabled = True
            ConvertPesoaOtro = False
            TextBox1.Focus()
        End If
    End Sub

    Private Sub cmbCot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCot.SelectedIndexChanged
        If cmbCot.Text = "Dólar USA" Then
            PictureBox9.Image = My.Resources.icons8_circular_de_ee_uu_48
        ElseIf cmbCot.Text = "EURO" Then
            PictureBox9.Image = My.Resources.icons8_bandera_circular_de_union_europea_48
        ElseIf cmbCot.Text = "Real BRA" Then
            PictureBox9.Image = My.Resources.icons8_circular_brasil_48
        End If
        ClearText(txtCon)
        ClearText(TextBox1)
    End Sub

    Private Sub frmMenu_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Dibuja primero la imagen de fondo
        'If Me.BackgroundImage IsNot Nothing Then
        '    e.Graphics.DrawImage(Me.BackgroundImage, Me.ClientRectangle)
        'End If

        ' Define los colores de inicio y fin del degradado, pero con transparencia
        Dim colorInicio As Color = Color.FromArgb(150, 173, 197, 231)  ' Color inicial con transparencia
        Dim colorFin As Color = Color.FromArgb(150, 253, 254, 255)    ' Color final con transparencia
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Ajusta los puntos del gradiente
        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, Me.Height),                    ' Punto de inicio
        New Point(Me.Width - 1, 1),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Aplica el degradado transparente sobre la imagen de fondo
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TogglePanel()
        If pnlOpSemanales.Visible Then
            AnimateWindow(pnlOpSemanales.Handle, 150, AW_HOR_POSITIVE Or AW_SLIDE Or AW_HIDE)
            MinimizarPanel(pnlOpSemanales)
        Else
            AnimateWindow(pnlOpSemanales.Handle, 150, AW_HOR_NEGATIVE Or AW_SLIDE)
            VerPanel(pnlOpSemanales)
        End If
        RoundButton(Button1, 41)
    End Sub


    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TogglePanel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ManejarFormulario(frmOpChofVeh, frmOp, frmOpChofVeh.pnlOpChofVeh, "frmOpChofVeh")
        frmOpChofVeh.tiOp.Stop()
        frmOp.CheckBox1.Checked = True
        frmOpChofVeh.btnOp.BackColor = Color.FromArgb(30, 63, 111)
        frmOp.IluminarFormulario()
    End Sub

    Private Sub pnlMnuDesp_Resize(sender As Object, e As EventArgs) Handles pnlOpSemanales.Resize
        pnlOpSemanales.Invalidate()
    End Sub

    Private Sub pnlMnuDesp_Paint(sender As Object, e As PaintEventArgs) Handles pnlOpSemanales.Paint
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
        New Point(pnlOpSemanales.Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlOpSemanales.ClientRectangle)
        End Using
    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub pnlCotAge_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlCotAge.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub ckbMosCon_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbMosCon.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label22_MouseDown(sender As Object, e As MouseEventArgs) Handles Label22.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Sombra3_MouseDown(sender As Object, e As MouseEventArgs) Handles Sombra3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label26_MouseDown(sender As Object, e As MouseEventArgs) Handles Label26.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label29_MouseDown(sender As Object, e As MouseEventArgs) Handles Label29.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub cmbCot_MouseDown(sender As Object, e As MouseEventArgs) Handles cmbCot.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label27_MouseDown(sender As Object, e As MouseEventArgs) Handles Label27.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub Label28_MouseDown(sender As Object, e As MouseEventArgs) Handles Label28.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub txtCon_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCon.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub ckbConver_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbConver.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub TextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

    Private Sub btnCamCon_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCamCon.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlOpSemanales)
    End Sub

#End Region

#End Region

End Class