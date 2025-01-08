Public Class frmEmpUsu

#Region "Declaraciones"
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

    Public Sub MiniEmpUsu()
        TamañoPantallaFull(full)
        MiniFrmIntermedio(frmEmpleados.dgvEmpleados, frmEmpleados.PictureBox1, full)
        MiniFrmIntermedio(frmUsuarios.dgvUsuarios, frmUsuarios.PictureBox1, full)
    End Sub
#End Region

#Region "Eventos"
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
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf frmEmpleados_Resize
        AddHandler Me.Resize, AddressOf frmUsuarios_Resize
        tUsu.Interval = 500
        tUsu.Start()
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub btnUsu_Click(sender As Object, e As EventArgs) Handles btnUsu.Click
        '   frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmUsuarios, pnlEmpUsu)
        frmUsuarios.Cargar()
        ActualizarUltimosFormularios("frmUsuarios")


        tUsu.Stop()
        btnUsu.BackColor = Color.FromArgb(30, 63, 111)
        frmUsuarios.IluminarFormulario()
        ' frmVisorReportes.Hide()
    End Sub

    Private Sub tUsu_Tick(sender As Object, e As EventArgs) Handles tUsu.Tick
        Static colorStep As Integer = 1
        Select Case colorStep
            Case 0
                btnUsu.BackColor = Color.FromArgb(30, 63, 111)
                colorStep = 1
            Case 1
                btnUsu.BackColor = Color.FromArgb(60, 117, 202)
                colorStep = 0
        End Select
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        '   frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmEmpleados, pnlEmpUsu)
        frmEmpleados.Cargar()
        ActualizarUltimosFormularios("frmEmpleados")
        tUsu.Stop()
        btnUsu.BackColor = Color.FromArgb(30, 63, 111)
        frmEmpleados.IluminarFormulario()
        '  frmVisorReportes.Hide()
    End Sub

    Private Sub frmEmpleados_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmEmpleados.MinimizarEmpleadoF()
        End If
    End Sub

    Private Sub frmUsuarios_Resize(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Minimized Then
        ElseIf WindowState = FormWindowState.Maximized Then
        ElseIf WindowState = FormWindowState.Normal Then
            frmUsuarios.MinimizarUsuarioF()
        End If
    End Sub
#Region "Ocultar Panel"
    Private Sub frmEmpUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarEmpUsu()
    End Sub

    Private Sub btnUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUsu.MouseDown
        OcultarEmpUsu()
    End Sub

    Private Sub btnEmp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEmp.MouseDown
        OcultarEmpUsu()
    End Sub

    Private Sub pnlEmpUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlEmpUsu.MouseDown
        OcultarEmpUsu()
    End Sub

    Private Sub frmEmpUsu_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        OcultarEmpUsu()
    End Sub

    Private Sub btnEmp_Paint(sender As Object, e As PaintEventArgs) Handles btnEmp.Paint
        frmOpChofVeh.RoundButtonRightSides(btnEmp, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
    End Sub

    Private Sub pnlEmpUsu_Paint(sender As Object, e As PaintEventArgs) Handles pnlEmpUsu.Paint
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
        New Point(0, pnlEmpUsu.Height),                    ' Punto de inicio
        New Point(pnlEmpUsu.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Aplica el degradado transparente sobre la imagen de fondo
            e.Graphics.FillRectangle(brush, pnlEmpUsu.ClientRectangle)
        End Using
    End Sub
#End Region

#End Region

End Class