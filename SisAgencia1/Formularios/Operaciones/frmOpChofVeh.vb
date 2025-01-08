Imports System.Drawing.Drawing2D

Public Class frmOpChofVeh

#Region "Declaraciones"
    Dim full As Point
    Dim frmprincipal As New frmPrincipal
#End Region

#Region "Subrutina"
    Public Sub MiniOpChofVeh()
        TamañoPantallaFull(full)
        If frmChof.rbChofCan.Checked = True Then
            frmChof.dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            frmChof.dgvChoferes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
        MiniFrmChof(frmChof.dgvChoferes, frmChof.PictureBox1, full)
        MiniFrmIntermedio(frmVeh.dgvVehiculos, frmVeh.PictureBox1, full)
        MiniFrmOp(frmOp.dgvOperaciones, frmOp.PictureBox1, full)
    End Sub

    Public Sub New()
        OpacidadNo(Me)
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub btnChof_Click(sender As Object, e As EventArgs) Handles btnChof.Click
        '  frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmChof, pnlOpChofVeh)
        frmChof.rbChofAct.Checked = True
        frmChof.Cargar()
        ActualizarUltimosFormularios("frmChof")
        tiOp.Stop()
        btnOp.BackColor = Color.FromArgb(30, 63, 111)
        frmChof.IluminarFormulario()
        ' frmVisorReportes.Hide()
    End Sub

    Private Sub btnVeh_Click(sender As Object, e As EventArgs) Handles btnVeh.Click
        '  frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmVeh, pnlOpChofVeh)
        frmVeh.rbVehAct.Checked = True
        frmVeh.Cargar()
        ActualizarUltimosFormularios("frmVeh")
        tiOp.Stop()
        btnOp.BackColor = Color.FromArgb(30, 63, 111)
        frmVeh.IluminarFormulario()
        '  frmVisorReportes.Hide()
    End Sub

    Private Sub btnOp_Click(sender As Object, e As EventArgs) Handles btnOp.Click
        '   frmprincipal.AbrirFormularioRe(frmVisorReportes)
        AbrirFormPanel(frmOp, pnlOpChofVeh)
        ActualizarUltimosFormularios("frmOp")
        frmOp.rbOpAct.Checked = True
        MinimizarPanel(frmprincipal.pnlMnuDesp)
        frmOp.Cargar()
        tiOp.Stop()
        btnOp.BackColor = Color.FromArgb(30, 63, 111)
        frmOp.IluminarFormulario()
    End Sub

    Private Sub frmOpChofVeh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf frmChof_Resize
        AddHandler Me.Resize, AddressOf frmVeh_Resize
        AddHandler Me.Resize, AddressOf frmOp_Resize
        tiOp.Interval = 500
        tiOp.Start()
    End Sub

    Private Sub tOp_Tick(sender As Object, e As EventArgs) Handles tiOp.Tick
        Static colorStep As Integer = 1
        Select Case colorStep
            Case 0
                btnOp.BackColor = Color.FromArgb(30, 63, 111)
                colorStep = 1
            Case 1
                btnOp.BackColor = Color.FromArgb(60, 117, 202)
                colorStep = 0
        End Select
    End Sub

    Private Sub frmOp_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmOp.MinimizarOperacionesF()
        End If
    End Sub

    Private Sub frmChof_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmChof.MinimizarChoferF()
        End If
    End Sub

    Private Sub frmVeh_Resize(sender As Object, e As EventArgs)
        If frmprincipal.WindowState = FormWindowState.Minimized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Maximized Then
        ElseIf frmprincipal.WindowState = FormWindowState.Normal Then
            frmVeh.MinimizarVehiculoF()
        End If
    End Sub
#Region "Ocultar Panel"
    Private Sub frmOpChofVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarOpChofVeh()
    End Sub

    Private Sub btnChof_MouseDown(sender As Object, e As MouseEventArgs) Handles btnChof.MouseDown
        OcultarOpChofVeh()
    End Sub

    Private Sub btnVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles btnVeh.MouseDown
        OcultarOpChofVeh()
    End Sub

    Private Sub btnOp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOp.MouseDown
        OcultarOpChofVeh()
    End Sub

    Private Sub pnlOpChofVeh_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlOpChofVeh.MouseDown
        OcultarOpChofVeh()
    End Sub

    Private Sub frmOpChofVeh_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        OcultarOpChofVeh()
    End Sub

    Public Sub RoundButtonRightSides(button As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()

        ' Lado superior izquierdo (sin redondeo)
        path.StartFigure()
        path.AddLine(0, 0, button.Width - cornerRadius, 0)

        ' Redondear la esquina superior derecha
        path.AddArc(New Rectangle(button.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius), -90, 90)

        ' Lado derecho (parte recta)
        path.AddLine(button.Width, cornerRadius, button.Width, button.Height - cornerRadius)

        ' Redondear la esquina inferior derecha
        path.AddArc(New Rectangle(button.Width - cornerRadius - 1, button.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90)

        ' Lado inferior izquierdo (sin redondeo)
        path.AddLine(button.Width - cornerRadius, button.Height, 0, button.Height)

        ' Lado izquierdo (recto)
        path.AddLine(0, button.Height, 0, 0)

        path.CloseFigure()

        ' Asignar la nueva forma al botón
        button.Region = New Region(path)


    End Sub

    Public Sub RoundButtonLeftSides(button As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()

        ' Redondear la esquina superior izquierda
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90)

        ' Lado superior (parte recta)
        path.AddLine(cornerRadius, 0, button.Width, 0)

        ' Lado derecho (recto)
        path.AddLine(button.Width, 0, button.Width, button.Height)

        ' Lado inferior (parte recta)
        path.AddLine(button.Width, button.Height, cornerRadius, button.Height)

        ' Redondear la esquina inferior izquierda
        path.AddArc(New Rectangle(0, button.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90)

        ' Lado izquierdo (recto)
        path.AddLine(0, button.Height - cornerRadius, 0, cornerRadius)

        path.CloseFigure()

        ' Asignar la nueva forma al botón
        button.Region = New Region(path)
    End Sub


    Private Sub btnOp_Paint(sender As Object, e As PaintEventArgs) Handles btnOp.Paint
        RoundButtonRightSides(btnOp, 10)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
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
        Invalidate()
    End Sub

    Private Sub pnlOpChofVeh_Paint(sender As Object, e As PaintEventArgs) Handles pnlOpChofVeh.Paint
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
        New Point(0, pnlOpChofVeh.Height),                    ' Punto de inicio
        New Point(pnlOpChofVeh.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Aplica el degradado transparente sobre la imagen de fondo
            e.Graphics.FillRectangle(brush, pnlOpChofVeh.ClientRectangle)
        End Using
    End Sub


#End Region

#End Region

End Class