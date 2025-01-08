Public Class frmServProv

#Region "Declaraciones"
    Dim frmprincipal As New frmPrincipal
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

    Public Sub MiniServProv()
        TamañoPantallaFull(full)
        MiniFrmIntermedio(frmProv.dgvProveedores, frmProv.PictureBox1, full)
        MiniFrmIntermedio(frmServ.dgvServicios, frmServ.PictureBox1, full)
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub btnProv_Click(sender As Object, e As EventArgs) Handles btnProv.Click
        ' frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmProv, pnlServProv)
        frmProv.Cargar()
        ActualizarUltimosFormularios("frmProv")
        tServ.Stop()
        btnServ.BackColor = Color.FromArgb(30, 63, 111)
        frmProv.IluminarFormulario()
        '  frmVisorReportes.Hide()
    End Sub

    Private Sub btnServ_Click(sender As Object, e As EventArgs) Handles btnServ.Click
        '  frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmServ, pnlServProv)
        frmServ.Cargar()
        ActualizarUltimosFormularios("frmServ")
        tServ.Stop()
        btnServ.BackColor = Color.FromArgb(30, 63, 111)
        frmServ.IluminarFormulario()

        ' frmVisorReportes.Hide()
    End Sub

    Private Sub frmServ_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmServ.MinimizarServicioF()
        End If
    End Sub

    Private Sub frmProv_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmProv.MinimizarProveedorF()
        End If
    End Sub

    Private Sub frmServProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf frmServ_Resize
        AddHandler Me.Resize, AddressOf frmProv_Resize
        tServ.Interval = 500
        tServ.Start()
    End Sub

    Private Sub tServ_Tick(sender As Object, e As EventArgs) Handles tServ.Tick
        Static colorStep As Integer = 1
        Select Case colorStep
            Case 0
                btnServ.BackColor = Color.FromArgb(30, 63, 111)
                colorStep = 1
            Case 1
                btnServ.BackColor = Color.FromArgb(60, 117, 202)
                colorStep = 0
        End Select
    End Sub

#Region "Ocultar Panel"
    Private Sub frmServProv_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarServProv()
    End Sub

    Private Sub btnProv_MouseDown(sender As Object, e As MouseEventArgs) Handles btnProv.MouseDown
        OcultarServProv()
    End Sub

    Private Sub btnServ_MouseDown(sender As Object, e As MouseEventArgs) Handles btnServ.MouseDown
        OcultarServProv()
    End Sub

    Private Sub pnlServProv_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlServProv.MouseDown
        OcultarServProv()
    End Sub

    Private Sub frmServProv_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        OcultarServProv()
    End Sub

    Private Sub btnServ_Paint(sender As Object, e As PaintEventArgs) Handles btnServ.Paint
        frmOpChofVeh.RoundButtonRightSides(btnServ, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    End Sub

    Private Sub Me_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio As Color = Color.FromArgb(30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin As Color = Color.FromArgb(100, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
        New Point(Me.Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, Me.ClientRectangle)
        End Using
    End Sub



    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Invalidate()
    End Sub

    Private Sub pnlServProv_Paint(sender As Object, e As PaintEventArgs) Handles pnlServProv.Paint
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
        New Point(0, pnlServProv.Height),                    ' Punto de inicio
        New Point(pnlServProv.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Aplica el degradado transparente sobre la imagen de fondo
            e.Graphics.FillRectangle(brush, pnlServProv.ClientRectangle)
        End Using
    End Sub
#End Region

#End Region

End Class