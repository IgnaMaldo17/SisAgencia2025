#Region "Imports"
Imports System.Drawing.Drawing2D
Imports Entidades
#End Region

Public Class frmVenCli

#Region "Declaraciones"
    Dim boton1 As Boolean = False
    Dim boton2 As Boolean = False
    Dim bMax As Boolean = False
    Dim frmTelefono As New frmTelefonos
    Dim frmVender As New frmAgrVent
    Dim frmprincipal As New frmPrincipal 'hacer q al minimazar desde frmprincipal pase lo sig, eso
    Dim full As Point
#End Region

#Region "Subrutina"
    Public Sub New()
        OpacidadNo(Me)
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Public Sub Mini()

        'frmClientes.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'frmClientes.dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'frmClientes.PictureBox1.Location = New Point(24, 107)

        'frmClientes.dgvClientes.AllowUserToResizeColumns = True

        'frmVentas.dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'frmVentas.dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'frmVentas.PictureBox1.Location = New Point(24, 107)

        'frmVentas.dgvVentas.AllowUserToResizeColumns = True

        'frmDetVentas.dgvDetVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'frmDetVentas.dgvDetVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'frmDetVentas.PictureBox1.Location = New Point(24, 107)

        'frmDetVentas.dgvDetVentas.AllowUserToResizeColumns = True

        'frmAgrVent.dgvVender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'frmAgrVent.dgvVender.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'frmAgrVent.PictureBox1.Location = New Point(24, 107)

        'frmAgrVent.dgvVender.AllowUserToResizeColumns = True

        'frmAgrVent.dgvServVen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        'frmAgrVent.dgvServVen.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'frmAgrVent.dgvServVen.AllowUserToResizeColumns = True

        TamañoPantallaFull(full)
        MiniFrmIntermedio(frmClientes.dgvClientes, frmClientes.PictureBox1, full)
        MiniFrmIntermedio(frmVentas.dgvVentas, frmVentas.PictureBox1, full)
        MiniFrmOp(frmDetVentas.dgvDetVentas, frmDetVentas.PictureBox1, full)
        MiniFrmIntermedio(frmAgrVent.dgvVender, frmAgrVent.PictureBox1, full)
        MiniFrmIntermedio(frmClientes.dgvClientes, frmClientes.PictureBox1, full)
        MiniFrmInterExtra(frmAgrVent.dgvServVen)
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf frmClientes_Resize
        AddHandler Me.Resize, AddressOf frmAgrVent_Resize
        AddHandler Me.Resize, AddressOf frmDetVentas_Resize
        AddHandler Me.Resize, AddressOf frmVentas_Resize
        tVent.Interval = 500
        tVent.Start()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub btnCliV_Click(sender As Object, e As EventArgs) Handles btnCliV.Click
        '  frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmClientes, pnlVenCli)
        frmClientes.rbCliAct.Checked = True
        ActualizarUltimosFormularios("frmClientes")
        tVent.Stop()
        btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        frmClientes.IluminarFormulario()
        '  frmVisorReportes.Hide()
    End Sub

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio = Color.FromArgb(30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin = Color.FromArgb(100, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New LinearGradientBrush(
        New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
        New Point(Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, ClientRectangle)
        End Using
    End Sub



    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Invalidate
    End Sub

    Private Sub btnVenV_Click(sender As Object, e As EventArgs) Handles btnVenV.Click
        '  frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmVentas, pnlVenCli)
        ActualizarUltimosFormularios("frmVentas")
        frmVentas.Determinar()
        frmVentas.Cargar()
        frmVentas.HabilitarNo()



        tVent.Stop()
        btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        frmVentas.IluminarFormulario()
        ' frmVisorReportes.Hide()
    End Sub

    Private Sub btnDetVent_Click(sender As Object, e As EventArgs) Handles btnDetVent.Click
        '   frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmDetVentas, pnlVenCli)
        ActualizarUltimosFormularios("frmDetVentas")
        frmDetVentas.Determinar()
        frmDetVentas.Cargar()
        frmDetVentas.HabilitarNo()
        MinimizarPanel(frmprincipal.pnlMnuDesp)
        tVent.Stop()
        btnVenV.BackColor = Color.FromArgb(30, 63, 111)
        frmDetVentas.IluminarFormulario()
        '   frmVisorReportes.Hide()
    End Sub

    Private Sub tVent_Tick(sender As Object, e As EventArgs) Handles tVent.Tick
        Static colorStep As Integer = 1
        Select Case colorStep
            Case 0
                btnVenV.BackColor = Color.FromArgb(30, 63, 111)
                colorStep = 1
            Case 1
                btnVenV.BackColor = Color.FromArgb(60, 117, 202)
                colorStep = 0
        End Select
    End Sub

    Private Sub frmDetVentas_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmDetVentas.MinimizarDetVentasF()
        End If
    End Sub

    Private Sub frmVentas_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmVentas.MinimizarVentasF()
        End If
    End Sub

    Private Sub frmClientes_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmClientes.MinimizarFotoCliF()
        End If
    End Sub

    Private Sub frmAgrVent_Resize(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Minimized Then
        ElseIf WindowState = FormWindowState.Maximized Then
        ElseIf WindowState = FormWindowState.Normal Then
            frmAgrVent.MinimizarFotoFalse()
        End If
    End Sub
#Region "Ocultar Panel"
    Private Sub pnlVenCli_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlVenCli.MouseDown
        OcultarVenCli()
        OcultarFecha(frmVentas.pnlBusxFecha, frmVentas.btnBusxFecha)
        OcultarFecha(frmDetVentas.pnlBusxFecha, frmDetVentas.btnBusxFecha)
        OcultarFecha(frmClientes.pnlBusxFecha, frmClientes.btnBusxFecha)
    End Sub

    Private Sub frmVenCli_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarVenCli()
    End Sub

    Private Sub btnCliV_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCliV.MouseDown
        OcultarVenCli()
    End Sub

    Private Sub btnVenV_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVenV.MouseDown
        OcultarVenCli()
    End Sub

    Private Sub btnDetVent_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDetVent.MouseDown
        OcultarVenCli()
    End Sub

    Private Sub btnDetVent_Paint(sender As Object, e As PaintEventArgs) Handles btnDetVent.Paint
        frmOpChofVeh.RoundButtonRightSides(btnDetVent, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    End Sub

    Private Sub btnVent_Paint(sender As Object, e As PaintEventArgs) Handles btnVenV.Paint
        frmOpChofVeh.RoundButtonRightSides(btnVenV, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    End Sub

    Private Sub btnVender_Paint(sender As Object, e As PaintEventArgs) Handles btnVender.Paint
        frmOpChofVeh.RoundButtonLeftSides(btnVender, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    End Sub

    Private Sub pnlVenCli_Paint(sender As Object, e As PaintEventArgs) Handles pnlVenCli.Paint
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
        New Point(0, pnlVenCli.Height),                    ' Punto de inicio
        New Point(pnlVenCli.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Aplica el degradado transparente sobre la imagen de fondo
            e.Graphics.FillRectangle(brush, pnlVenCli.ClientRectangle)
        End Using
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim nombreUltimoFormulario As String = UltimosFormularios(0)

        If Application.OpenForms.OfType(Of frmAgrVent)().Any() Then
            ActualizarUltimosFormularios("frmAgrVent")
            AbrirFormPanel(frmAgrVent, pnlVenCli)
            frmAgrVent.IluminarFormulario()
            Return
        End If

        VenderConVenCliAbierto = True

        Dim resultado As DialogResult = MessageBox.Show("Está por iniciar una venta a un cliente ya registrado, sin embargo, puede simular una venta sin cliente ¿Desea iniciar una simulación de venta en vez de seleccionar un cliente?", "Iniciar venta.", MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            AgrSimulacion = True
            frmAgrVent.txtCli.Text = "Simulación sin Cliente."
            CodCliVender = 0
            AbrirFormPanel(frmAgrVent, pnlVenCli)

            ActualizarUltimosFormularios("frmAgrVent")
        ElseIf resultado = DialogResult.No Then
            Dim frmSelCli As New frmSelCli()
            frmSelCli.ShowDialog()
            frmSelCli.TopMost = True
        End If
        tVent.Stop()
    End Sub

    Private Sub btnVender_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVender.MouseDown
        OcultarVenCli()
    End Sub
#End Region

#End Region

End Class