#Region "Imports"
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
#End Region


Public Class frmNoti

#Region "Shared Function"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function
#End Region

#Region "Subrutinas"
    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub
#End Region

#Region "Eventos"

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim radius As Integer = 31 ' Cambia el radio según sea necesario
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()

        ' Agregar esquinas redondeadas
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90) ' Esquina superior izquierda
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90) ' Esquina superior derecha
        path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90) ' Esquina inferior derecha
        path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90) ' Esquina inferior izquierda

        path.CloseFigure()

        ' Establecer la región del formulario
        Me.Region = New Region(path)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style And Not &H20000000 ' Quita el borde de la ventana
            Return cp
        End Get
    End Property

    Private Sub frmDesMotivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mantener el formulario actual en la parte superior
        Me.TopMost = True
        MinimizarPanel(txtHora)
        tNotificacion.Stop()
        tHora.Start()
        NotiPosicionForm(Me)

        ' Configurar el temporizador de notificación
        tNotificacion.Interval = 7000 ' 7000 milisegundos = 7 segundos
        tNotificacion.Start() ' Iniciar el temporizador

        ' Seleccionar PictureBox2
        PictureBox2.Select()

        ' Ver el panel y redondear el botón de salida
        VerPanel(txtHora)
        frmMenu.RoundButton(btnExit, 21)

        ' Aplicar la región redondeada inmediatamente
        Me.Invalidate() ' Forzar el redibujo del formulario
        Me.Update() ' Asegurarse de que se actualice

        ' Animar el formulario actual
        AnimateWindow(Me.Handle, 150, AW_HOR_NEGATIVE Or AW_SLIDE)
        Me.Invalidate() ' Forzar el redibujo del formulario
        Me.Update() ' Asegurarse de que se actualice
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tNotificacion.Stop() ' Detener el temporizador para que no siga funcionando
        Me.Close()
    End Sub

    Private Sub frmDesMotivo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ClearText(txtNotiCabeza)
        AnimateWindow(Me.Handle, 150, AW_HOR_POSITIVE Or AW_SLIDE Or AW_HIDE)
    End Sub

    Private Sub txtNoti_Enter(sender As Object, e As EventArgs) Handles txtNotiCabeza.Enter
        txtNotiCabeza.SelectionLength = 0 ' No selecciona texto
        txtNotiCabeza.SelectionStart = txtNotiCabeza.TextLength ' El cursor se coloca al final
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles txtNotiCuerpo.Enter
        txtNotiCuerpo.SelectionLength = 0 ' No selecciona texto
        txtNotiCuerpo.SelectionStart = txtNotiCuerpo.TextLength ' El cursor se coloca al final
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles txtHora.Enter
        txtHora.SelectionLength = 0 ' No selecciona texto
        txtHora.SelectionStart = txtHora.TextLength ' El cursor se coloca al final
    End Sub

    Private Sub tNoti_Tick(sender As Object, e As EventArgs) Handles tHora.Tick
        txtHora.Text = DateAndTime.Now.ToString("HH:mm")
    End Sub

    Private Sub tNotificacion_Tick(sender As Object, e As EventArgs) Handles tNotificacion.Tick
        tNotificacion.Stop() ' Detener el temporizador para que no siga funcionando
        Me.Close()
    End Sub

    Private Sub pnlMnuTool_Paint(sender As Object, e As PaintEventArgs) Handles pnlMnuTool.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio = Color.FromArgb(200, 30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin = Color.FromArgb(200, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

        Using brush As New Drawing2D.LinearGradientBrush(
        New Point(0, pnlMnuTool.Height),                    ' Punto de inicio
        New Point(pnlMnuTool.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlMnuTool.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlMnuTool_Resize(sender As Object, e As EventArgs) Handles pnlMnuTool.Resize
        pnlMnuTool.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub
#Region "Color y Arrastrar"
    'Private Sub frmAdmin_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
    '    ColorMax1b(pnlMnuTool, PictureBox2, btnExit)
    'End Sub

    'Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles txtNotiCabeza.MouseEnter
    '    ColorMax1b(pnlMnuTool, PictureBox2, btnExit)
    'End Sub

    'Private Sub pnlMnuTool_MouseEnter(sender As Object, e As EventArgs) Handles pnlMnuTool.MouseEnter
    '    ColorMax1b(pnlMnuTool, PictureBox2, btnExit)
    'End Sub

    'Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
    '    ColorMax1b(pnlMnuTool, PictureBox2, btnExit)
    'End Sub

    'Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
    '    ColorMin(pnlMnuTool, PictureBox2)
    'End Sub
#End Region

#End Region

End Class