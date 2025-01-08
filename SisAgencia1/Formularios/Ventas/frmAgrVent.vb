#Region "Imports"
Imports Datos
Imports Entidades
Imports FastReport
Imports System.Diagnostics.Eventing.Reader
Imports System.Net.Security
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text.Json
Imports FastReport.Data
Imports System.Globalization
Imports System.Drawing.Drawing2D
Imports Xamarin.Forms.Markup.GridRowsColumns


#End Region

Public Class frmAgrVent

#Region "Shared Function"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function
#End Region

#Region "Declaraciones"
    Dim ServiciosSP As New clsServ
    Dim ServiciosDatos As New eServ
    Dim VentasSP As New clsVenta
    Dim VentasDatos As New eVenta
    Dim OperacionesSP As New clsOp
    Dim OperacionesDatos As New eOp
    Dim bandera As Boolean = True
    Dim banoperacion As Boolean = False
    Dim CodServVenta As Integer
    Dim Monto As Double = 0
    Dim cliente As String
    Dim servicio As String
    Dim notas As String
    Dim fecha As Date
    Dim fechaformateada As String
    Dim hora As Date
    Dim horaformateada As String
    Dim cantidad As String
    Dim montoserv As Double = 0
    Dim montoop As Double = 0
    Dim aclaracion As String
    Dim total As Double
    Dim columna As Integer = 0
    Dim llevaOp As Integer = 0
    Dim columnaeliminar As Integer = 0
    Dim full As Point
    Dim mini As Point
    Dim miniinicio As Point
    Dim report As New Report()

    ' Cargar el archivo del reporte

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

    Private Sub TogglePanel()
        If pnlAgrSer.Visible Then
            ' Ocultar con animación
            AnimateWindow(pnlAgrSer.Handle, 150, AW_HOR_NEGATIVE Or AW_SLIDE Or AW_HIDE)
            pnlAgrSer.Visible = False
        Else
            ' Mostrar con animación
            AnimateWindow(pnlAgrSer.Handle, 150, AW_HOR_POSITIVE Or AW_SLIDE)
            pnlAgrSer.Visible = True
        End If
    End Sub

    Private Sub Cargar()
        If txtBusSer.Text.Length = 0 Or txtBusSer.ForeColor = Color.Gray Or txtBusSer.Text = "Buscar Servicios" Then
            GetServAct()
        Else
            Me.dgvServVen.DataSource = ServiciosSP.BuscarServiciosShrt(txtBusSer.Text)
        End If
    End Sub

    Private Sub GetServAct()
        dgvServVen.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvServVen.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.dgvServVen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServVen.RowHeadersWidth = 15
        dgvServVen.DataSource = ServiciosSP.GetServiciosShrt()
    End Sub

    Private Sub ColorCambio(b As Button, cl As Color, cl2 As Color, cl3 As Color)
        b.Text = "Retirar Servicio"
        b.Image = My.Resources.icons8_eliminar_24
        b.BackColor = cl
        b.FlatAppearance.BorderColor = cl2
        b.FlatAppearance.MouseDownBackColor = cl
        b.FlatAppearance.MouseOverBackColor = cl3
    End Sub

    Private Sub DisabledColor()
        ControlFalse(btnRetSer)
        ColorCambio(btnRetSer, Color.FromArgb(30, 63, 111), Color.FromArgb(15, 31, 55), Color.FromArgb(43, 88, 157))
        ControlFalse(btnNuevo)
        btnNuevo.Image = My.Resources.icons8_cancelar_30
        btnNuevo.ForeColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub EliminarColor()
        ControlTrue(btnRetSer)
        ColorCambio(btnRetSer, Color.Firebrick, Color.Maroon, Color.DarkRed)
        ControlTrue(btnNuevo)
        btnNuevo.Image = My.Resources.icons8_cancelar_rojo_30
        btnNuevo.ForeColor = Color.Firebrick
    End Sub

    Private Sub Limpiar()
        ClearText(txtServ)
        ClearText(txtCantPer)
        ClearText(txtNotas)
        ClearText(txtOpMont)
        ClearText(txtAcla)
        ep.Clear()
    End Sub

    Public Sub InicioEX()
        Monto = 0
        montoserv = 0
        montoop = 0
        columna = 0
        llevaOp = 0
        columnaeliminar = 0
        ClearText(txtTotal)
        dgvVender.Rows.Clear()
        Limpiar()
    End Sub

    Public Sub InicioSimulado()


        Sim = "simulación"

        ep.Clear()
        txtCli.Focus()
        GetServAct()
        bandera = True
        btnCancel.Text = "Reiniciar Sim."
        btnFinCom.Text = "Finalizar Sim."
        Button1.Text = "Cancelar Sim."
        ClearInt(columnaeliminar)
        ControlTrue(btnCancel)
        ControlTrue(ckbActHora)
        ControlTrue(btnFinCom)
        ControlTrue(btnAgrSer)
        ControlFalse(btnRetSer)
        ControlTrue(btnSelSer)
        btnAgrSer.Text = "Agregar Servicio"
        ControlTrue(txtCli)
        ControlFalse(txtServ)
        ControlTrue(txtCantPer)
        ControlTrue(txtNotas)
        ControlTrue(dtpFecha)
        ckbActHora.Checked = False
        dtpFecha.Value = Now
        dtpHora.Value = Today
        ControlFalse(dtpHora)
        Limpiar()
        DisabledColor()
        txtCli.Text = ""
        Label5.Text = "Simulación"
        Label7.Text = "Servicios a simular"
        dtpHora.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = "HH:mm"
        dtpHora.ShowUpDown = True
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "dd/MM/yyyy"
        MinimizarPanel(pnlAgrSer)
        btnAgrSer.Enabled = False
    End Sub

    Private Sub Inicio()
        ep.Clear()
        Sim = "venta"
        txtCantPer.Focus()
        GetServAct()
        bandera = True
        ClearInt(columnaeliminar)
        ControlTrue(btnCancel)
        ControlTrue(ckbActHora)
        ControlTrue(btnFinCom)
        ControlTrue(btnAgrSer)
        ControlFalse(btnRetSer)
        ControlTrue(btnSelSer)
        btnAgrSer.Text = "Agregar Servicio"
        ControlFalse(txtCli)
        ControlFalse(txtServ)
        ControlTrue(txtCantPer)
        ControlTrue(txtNotas)
        ControlTrue(dtpFecha)
        ckbActHora.Checked = False
        'ControlFalse(ckbActHora)
        'ckbActFecha.Checked = False
        dtpFecha.Value = Now
        dtpHora.Value = Today
        'ControlFalse(dtpFecha)
        ControlFalse(dtpHora)
        Limpiar()
        DisabledColor()
        txtCli.Text = NomApeClienteVen
        dtpHora.Format = DateTimePickerFormat.Custom
        dtpHora.CustomFormat = "HH:mm" ' Formato de 12 horas
        dtpHora.ShowUpDown = True
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "dd/MM/yyyy"
        MinimizarPanel(pnlAgrSer)
        btnAgrSer.Enabled = False
    End Sub

    Public Sub MinimizarFotoTrue()
        Me.dgvVender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVender.RowHeadersWidth = 15
        Me.dgvServVen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServVen.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(full)
    End Sub

    Public Sub MinimizarFotoFalse()
        Me.dgvVender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVender.RowHeadersWidth = 15
        Me.dgvServVen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvServVen.RowHeadersWidth = 15
        Me.PictureBox1.Location = New Point(mini)
    End Sub

    Public Sub RoundButtonIzquierdo(button As Control, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90)
        path.AddLine(cornerRadius, 0, button.Width, 0)
        path.AddLine(button.Width, 0, button.Width, button.Height)
        path.AddLine(button.Width, button.Height, cornerRadius, button.Height)
        path.AddArc(New Rectangle(0, button.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90)
        path.CloseFigure()
        button.Region = New Region(path)
    End Sub

#End Region

#Region "Eventos"
    Public Sub IluminarFormulario()
        frmPrincipal.IluminarBoton(frmVenCli.btnVender) ' Ilumina el botón del Formulario 1
    End Sub

    Private Sub Formulario1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        IluminarFormulario()
    End Sub

    Private Sub frmAgrVent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Findeventa = False
        If AgrSimulacion = True Then
            InicioSimulado()
        Else
            Inicio()
        End If


        InicioEX()
        TamañoPantalla(PictureBox1.Size, mini, full, miniinicio)
        dgvVender.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvVender.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        SetDoubleBuffered(dgvVender)
        If frmPrincipal.bMax = True Then
            MinimizarFotoTrue()
        Else
            MinimizarFotoFalse()
            Me.PictureBox1.Location = New Point(miniinicio)
        End If
        'txtTotal.Text = Convert.ToDecimal(txtTotal.Text).ToString("C2")
        dtpFecha.MinDate = DateTime.Today
        frmMenu.RoundButton(btnNuevo, 10)
        frmMenu.RoundButton(ckbActHora, 10)
        frmMenu.RoundButton(ckbActOp, 10)
        frmMenu.RoundButton(btnAgrSer, 10)
        frmMenu.RoundButton(btnFinCom, 10)
        frmMenu.RoundButton(btnCancel, 10)
        frmMenu.RoundButton(Button1, 10)
        frmMenu.RoundButton(txtTotal, 21)
        frmMenu.RoundButton(btnRetSer, 10)
        frmMenu.RoundButton(txtEuro, 10)
        frmMenu.RoundButton(txtDolar, 10)
        frmMenu.RoundButton(txtReal, 10)
        RoundButtonIzquierdo(btnSelSer, 10)

        If AgrSimulacion = True Then
            InicioSimulado()
        Else
            Inicio()
        End If
    End Sub

    Private Sub frmVentas_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Application.DoEvents()
        OpacidadSi(Me)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas reiniciar la " & Sim & "?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            'CerrarUltimoFormulario()
            'ClearInt(CodCliVender)
            'ClearString(NomApeCliAgrVent)
            'ClearInt(CodCliAgrVent)

            If AgrSimulacion = True Then
                InicioSimulado()
            Else
                Inicio()
            End If


            InicioEX()
        End If





    End Sub

    Private Sub pnlDatVender_Paint(sender As Object, e As PaintEventArgs) Handles pnlDatVender.Paint
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
        New Point(0, pnlDatVender.Height),                    ' Punto de inicio
        New Point(pnlDatVender.Width, 0),                 ' Punto final ajustado
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDatVender.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDatVender_Resize(sender As Object, e As EventArgs) Handles pnlDatVender.Resize
        pnlDatVender.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub pnlDGVServ_Paint(sender As Object, e As PaintEventArgs) Handles pnlDGVServ.Paint
        ' Definir los colores de inicio y fin del degradado
        Dim colorInicio = Color.FromArgb(200, 30, 63, 111)  ' Color inicial a la izquierda
        Dim colorFin = Color.FromArgb(200, 60, 117, 202)   ' Color final a la derecha

        ' Ajustar el objeto Graphics para mejorar la calidad del dibujo
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality

        ' Crea el pincel de degradado dinámicamente basado en el tamaño actual del panel
        Using brush As New LinearGradientBrush(
        New Point(0, 0),                      ' Punto de inicio (lado izquierdo)
        New Point(pnlDGVServ.Width, 0),       ' Punto final (lado derecho)
        colorInicio, colorFin)

            ' Rellenar el área del panel con el degradado
            e.Graphics.FillRectangle(brush, pnlDGVServ.ClientRectangle)
        End Using
    End Sub


    Private Sub pnlDGVServ_Resize(sender As Object, e As EventArgs) Handles pnlDGVServ.Resize
        pnlDGVServ.Invalidate() ' Forzar la repintada del panel al cambiar el tamaño
    End Sub

    Private Sub AgregarServ()
        ep.Clear()
        If ckbActOp.Checked Then
            CampoBlanco3(pnlDatVender, ep)
            If banbl = False Then
                Return
            End If
        Else
            CampoBlanco2(pnlDatVender, ep)
            If banbl = False Then
                Return
            End If
        End If
        If txtOpMont.Text.StartsWith(".") OrElse txtOpMont.Text.StartsWith(",") Then
            ep.SetError(txtOpMont, "Ingresa un número antes del decimal.")
            Return
        End If

        If AgrSimulacion = True Then
            If txtCli.Text = "" Then
                ep.SetError(txtCli, "Ingresa un nombre para el cliente simulado.")
                Return
            End If
            NomApeCliAgrVent = txtCli.Text
            cliente = txtCli.Text
            ControlFalse(txtCli)
        Else
            txtCli.Text = txtCli.Text
            cliente = txtCli.Text
        End If

        txtServ.Text = txtServ.Text
        servicio = txtServ.Text
        notas = txtNotas.Text
        cantidad = txtCantPer.Text

        If dtpFecha.Enabled Then
            fecha = dtpFecha.Value
            fechaformateada = fecha.ToString("yyyy-MM-dd")
        Else
            fecha = dtpFecha.MinDate
            fechaformateada = Nothing
        End If
        If dtpHora.Enabled Then
            hora = dtpHora.Value
            horaformateada = hora.ToString("HH:mm")
        Else
            hora = dtpHora.MinDate
            horaformateada = Nothing
        End If

        montoserv = Monto

        If ckbActOp.Checked Then
            ReemplazarComaPorPunto(txtOpMont.Text)
            montoop = Convert.ToDouble(txtOpMont.Text)
            aclaracion = txtAcla.Text
            llevaOp = 1
        Else
            ClearDouble(montoop)
            ClearString(aclaracion)
            ClearInt(llevaOp)
        End If
        If bandera = True Then
            columna = columna + 1
        End If
        Dim montoservx As Double
        Dim totalrow As Double

        montoservx = Math.Round(Convert.ToDouble(montoserv) * Convert.ToDouble(cantidad), 2)
        If montoop = 0 Then
            totalrow = montoservx + 0
        Else
            totalrow = Math.Round(montoservx + Convert.ToDouble(montoop), 2)
        End If
        If banbl = True Then
            If bandera = True Then
                dgvVender.Rows.Add(cliente, servicio, cantidad, fechaformateada, horaformateada, montoserv, montoservx, notas, montoop, aclaracion, totalrow, CodServVenta, columna, hora, fecha, llevaOp)
            Else
                ' Editar la fila existente en lugar de agregar una nueva
                For Each row As DataGridViewRow In dgvVender.Rows
                    ' Verificar si el valor en la columna oculta es igual al valor deseado
                    If row.Cells("numero").Value IsNot Nothing AndAlso CInt(row.Cells("numero").Value) = columnaeliminar Then
                        ' Editar los valores de la fila encontrada
                        row.Cells("cCliente").Value = cliente
                        row.Cells("cServicio").Value = servicio
                        row.Cells("cCanPersonas").Value = cantidad
                        row.Cells("cFecha").Value = fechaformateada
                        row.Cells("cHora").Value = horaformateada
                        row.Cells("cMonto").Value = montoserv
                        row.Cells("cMonServ").Value = montoservx
                        row.Cells("cNotas").Value = notas
                        row.Cells("cValorOp").Value = montoop
                        row.Cells("cAclaracion").Value = aclaracion
                        row.Cells("cTotal").Value = totalrow
                        row.Cells("codserv").Value = CodServVenta
                        row.Cells("horaform").Value = hora
                        row.Cells("fechaform").Value = fecha
                        row.Cells("llevaopera").Value = llevaOp
                        Exit For ' Salir del bucle una vez que se edita la fila
                    End If
                Next
            End If
            total = 0
            For Each row As DataGridViewRow In dgvVender.Rows
                ' Obtener el valor de la celda "cValorOp" y convertirlo a Double usando la cultura actual del sistema
                Dim valorOp As Double = 0
                Dim valorOpText As String = row.Cells("cValorOp").Value?.ToString().Replace("$", "").Trim() ' Limpiar el texto

                ' Intentar parsear el valor sin modificar los separadores
                If Double.TryParse(valorOpText, NumberStyles.Currency, CultureInfo.CurrentCulture, valorOp) Then
                    ' El valor fue correctamente convertido
                Else
                    valorOp = 0 ' En caso de error en la conversión
                End If

                ' Obtener el valor de la celda "cMonServ" y convertirlo a Double de la misma forma
                Dim monto As Double = 0
                Dim montoText As String = row.Cells("cMonServ").Value?.ToString().Replace("$", "").Trim()

                If Double.TryParse(montoText, NumberStyles.Currency, CultureInfo.CurrentCulture, monto) Then
                    ' El valor fue correctamente convertido
                Else
                    monto = 0 ' En caso de error en la conversión
                End If

                ' Sumar los valores a la variable total
                total += valorOp + monto
            Next

            txtTotal.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", total)
            txtReal.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", total / Real)
            txtEuro.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", total / Euro)
            txtDolar.Text = String.Format(CultureInfo.CurrentCulture, "{0:C2}", total / Dolar)

            AddHandler dgvVender.CellFormatting, AddressOf dgvVender_CellFormatting

            Limpiar()
            'Monto = 0
            'montoserv = 0
            'montoop = 0
            'columna = 0
            'llevaOp = 0
            'columnaeliminar = 0
            ckbActHora.Checked = False
            'ckbActFecha.Checked = False
            ckbActOp.Checked = False
            btnAgrSer.Enabled = False
            ControlFalse(btnRetSer)
            dtpHora.Value = Today
            DisabledColor()
            bandera = True
            btnAgrSer.Text = "Agregar Servicio"
        Else
        End If

        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnAgrSer_Click(sender As Object, e As EventArgs) Handles btnAgrSer.Click
        AgregarServ()
    End Sub

    Private Sub btnRetSer_Click(sender As Object, e As EventArgs) Handles btnRetSer.Click
        For Each row As DataGridViewRow In dgvVender.Rows
            ' Verificar si el valor en la columna oculta es igual al valor deseado
            If row.Cells("numero").Value IsNot Nothing AndAlso CInt(row.Cells("numero").Value) = columnaeliminar Then
                ' Remover la fila encontrada
                dgvVender.Rows.Remove(row)
                Exit For ' Salir del bucle una vez que se elimina la fila
            End If
        Next
        Limpiar()
        DisabledColor()
        bandera = True
        ClearInt(columnaeliminar)
        ControlFalse(btnRetSer)
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtCantPer.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantPer.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtOpMont_TextChanged(sender As Object, e As EventArgs) Handles txtOpMont.TextChanged
        FiltrarNoIntMonto(sender, e)
    End Sub

    Private Sub txtOpMont_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOpMont.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            AgregarServ()
        End If
        SoloIntMonto(sender, e)
    End Sub
    Private Sub dgvVender_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVender.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvVender.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvVender.Rows.Count Then
                    Dim row As DataGridViewRow = dgvVender.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                    Else
                        Monto = Convert.ToDouble(row.Cells(5)?.Value)
                        CodServVenta = CInt(row.Cells(11)?.Value)
                        btnAgrSer.Enabled = True
                        columnaeliminar = CInt(row.Cells(12)?.Value) ' Actualiza el código del cliente seleccionado
                        txtServ.Text = row.Cells(1)?.Value?.ToString()
                        txtNotas.Text = row.Cells(7)?.Value?.ToString()
                        txtCantPer.Text = row.Cells(2)?.Value?.ToString()
                        txtAcla.Text = row.Cells(9)?.Value?.ToString()
                        txtOpMont.Text = row.Cells(8)?.Value?.ToString()
                        If row.Cells(9)?.Value?.ToString() <> "" Or row.Cells(8)?.Value?.ToString() <> "" Then
                            ckbActOp.Checked = True
                        Else
                            ckbActOp.Checked = False
                        End If
                        If row.Cells(3)?.Value?.ToString() <> "" Then
                            ckbActFecha.Checked = True
                            If dtpFecha.Enabled Then
                                dtpFecha.Value = row.Cells(14)?.Value?.ToString()
                                If dtpFecha.Value.Year <= 2020 Then
                                    dtpFecha.Value = Today
                                End If
                            End If
                        End If
                        If row.Cells(4)?.Value?.ToString() <> "" Then
                            ckbActHora.Checked = True
                            ControlTrue(dtpHora)
                            If dtpHora.Enabled Then
                                dtpHora.Value = row.Cells(13)?.Value?.ToString()
                                If dtpHora.Value.Year <= 2020 Then
                                    dtpHora.Value = Today
                                End If
                            End If
                        End If
                    End If
                End If



                'montoop = 0
                'columna = 0
                'llevaOp = 0
                'columnaeliminar = 0


                bandera = False 'si es mod es false
                EliminarColor()
                ControlTrue(btnRetSer)
                btnAgrSer.Text = "Guardar Cambios"
            End If
        End If
    End Sub

    Private Sub txtBusSer_Enter(sender As Object, e As EventArgs) Handles txtBusSer.Enter
        If txtBusSer.Text = "Buscar Servicios" Then
            ClearText(txtBusSer)
            txtBusSer.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusSer_Leave(sender As Object, e As EventArgs) Handles txtBusSer.Leave
        If String.IsNullOrWhiteSpace(txtBusSer.Text) Then
            txtBusSer.Text = "Buscar Servicios"
            txtBusSer.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtBusSer_TextChanged(sender As Object, e As EventArgs) Handles txtBusSer.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusSer_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusSer.MouseClick
        If txtBusSer.Text = "Buscar Servicios" Then
            ClearText(txtBusSer)
            txtBusSer.ForeColor = Color.Black
        Else
            Cargar()
        End If
    End Sub

    Private Sub btnSelSer_Click(sender As Object, e As EventArgs) Handles btnSelSer.Click
        TogglePanel()
    End Sub

    Private Sub dgvServVen_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvServVen.DataBindingComplete
        If dgvServVen.Columns.Count > 0 Then
            dgvServVen.Columns(dgvServVen.Columns.Count - 1).Visible = False
            dgvServVen.Columns(dgvServVen.Columns.Count - 2).Visible = False
        End If
    End Sub

    Private Sub dgvServVen_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServVen.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvServVen.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvServVen.Rows.Count Then
                    Dim row As DataGridViewRow = dgvServVen.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                    Else
                        CodServVenta = CInt(row.Cells(6)?.Value) ' Actualiza el código del cliente seleccionado
                        txtServ.Text = row.Cells(2)?.Value?.ToString()
                        Monto = row.Cells(4)?.Value
                        MinimizarPanel(pnlAgrSer)
                        btnAgrSer.Enabled = True
                        txtCantPer.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Dim NombreCliente As String
    Dim CorreoCliente As String
    Dim ServicioCliente As String
    Dim FechaCliente As String

    Public Findeventa As Boolean = False

    Public Sub Vender()

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro que deseas finalizar la " & Sim & "?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then

            Dim reporte As New Report()
            Dim reportStream As New IO.MemoryStream(My.Resources.InfoVenta)
            reporte.Load(reportStream)

            Dim dataTable As New DataTable("MiTabla")
            dataTable.Columns.Add("Tipo")
            dataTable.Columns.Add("Servicio")
            dataTable.Columns.Add("Cantidad")
            dataTable.Columns.Add("PrecioU")
            dataTable.Columns.Add("PrecioServ")
            dataTable.Columns.Add("Fecha")
            dataTable.Columns.Add("Hora")
            dataTable.Columns.Add("Nota")
            dataTable.Columns.Add("PrecioOp")
            dataTable.Columns.Add("Observacion")
            dataTable.Columns.Add("PrecioTotal")

            Dim textObject12 As FastReport.TextObject = DirectCast(reporte.FindObject("Text58"), FastReport.TextObject)
            If textObject12 IsNot Nothing Then
                textObject12.Text = txtTotal.Text
            End If

            For Each row As DataGridViewRow In dgvVender.Rows
                If Not row.IsNewRow Then
                    Dim dataRow As DataRow = dataTable.NewRow()

                    For Each row1 As DataGridViewRow In dgvServVen.Rows
                        If Not row1.IsNewRow Then
                            dataRow("Tipo") = row1.Cells(3).Value
                        End If
                    Next

                    dataRow("Servicio") = row.Cells(1).Value
                    dataRow("Cantidad") = row.Cells(2).Value
                    dataRow("PrecioU") = String.Format("{0:C2}", Convert.ToDecimal(row.Cells(5).Value))
                    dataRow("PrecioServ") = String.Format("{0:C2}", Convert.ToDecimal(row.Cells(6).Value))

                    If row.Cells(8).Value = 0 Then
                        dataRow("PrecioOp") = ""
                    Else
                        dataRow("PrecioOp") = String.Format("{0:C2}", Convert.ToDecimal(row.Cells(8).Value))
                    End If

                    If row.Cells(10).Value = 0 Then
                        dataRow("PrecioTotal") = ""
                    Else
                        dataRow("PrecioTotal") = String.Format("{0:C2}", Convert.ToDecimal(row.Cells(10).Value))
                    End If

                    dataRow("Fecha") = Convert.ToDateTime(row.Cells(3).Value).ToString("dd/MM")

                    If Convert.ToDateTime(row.Cells(4).Value).Year > 2020 Then
                        dataRow("Hora") = Convert.ToDateTime(row.Cells(4).Value).ToString("HH:mm")
                    Else
                        dataRow("Hora") = Nothing
                    End If



                    dataRow("Nota") = row.Cells(7).Value
                    dataRow("Observacion") = row.Cells(9).Value
                    dataTable.Rows.Add(dataRow)
                End If

                Dim textObject14 As FastReport.TextObject = DirectCast(reporte.FindObject("Text41"), FastReport.TextObject)
                If textObject14 IsNot Nothing Then
                    textObject14.Text = row.Cells(0).Value
                End If
            Next

            For Each row As DataGridViewRow In dgvServVen.Rows
                If Not row.IsNewRow Then
                    Dim datarow As DataRow = dataTable.NewRow()
                    datarow("Tipo") = row.Cells(3).Value
                End If
            Next

            If AgrSimulacion = False Then

                Dim Tabla1 As DataTable
                Tabla1 = VentasSP.VerificarVenta(CodCliVender)


                If Tabla1(0)(0) = 0 Then

                Else
                    Dim respuesta1 As DialogResult = MessageBox.Show("Una de las últimas 5 ventas tiene el mismo cliente. Puede que la venta esté repetida ¿Estás seguro que deseas finalizar la " & Sim & "?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If respuesta1 = DialogResult.Yes Then

                    Else
                        Return
                    End If
                End If

                VentasDatos.CodMedPago = CodMedPagoGlobal
                VentasDatos.CodMoneda = CodMonedaGlobal
                VentasDatos.CodTrans = CodTransGlobal
                VentasDatos.CodCli = CodCliVender
                VentasDatos.IdAlta = CodUsu

                If dgvVender.Rows.Count > 0 Then

                    Dim tabla As DataTable
                    tabla = VentasSP.InsVenta(VentasDatos)
                    CodVender = tabla(0)(0)
                    If CodVender > 0 Then
                        For Each row As DataGridViewRow In dgvVender.Rows

                            VentasDatos.CodVenta = CodVender
                            VentasDatos.CodServ = CInt(row.Cells(11)?.Value)
                            VentasDatos.FechaServ = row.Cells(3)?.Value?.ToString()
                            VentasDatos.Observaciones = row.Cells(7)?.Value?.ToString()
                            VentasDatos.Hora = row.Cells(4)?.Value?.ToString()
                            VentasDatos.CanPersonas = CInt(row.Cells(2)?.Value)

                            NombreCliente = row.Cells(0)?.Value?.ToString()
                            CorreoCliente = CorreoCli
                            ' Inicializa las variables antes de la concatenación, si es necesario
                            If String.IsNullOrEmpty(ServicioCliente) Then
                                ServicioCliente = row.Cells(1)?.Value?.ToString()
                            Else
                                ServicioCliente &= ", " & row.Cells(1)?.Value?.ToString()
                            End If

                            ' Manejo de fecha y hora
                            If row.Cells(3)?.Value IsNot Nothing Then
                                ' Convertir la fecha en DateTime
                                Dim fecha As DateTime = Convert.ToDateTime(row.Cells(3)?.Value)

                                ' Verificar si hay una hora
                                If row.Cells(4)?.Value IsNot Nothing Then
                                    ' Convertir la hora en DateTime y combinarla con la fecha
                                    Dim hora As DateTime = Convert.ToDateTime(row.Cells(4)?.Value)
                                    Dim fechaHora As DateTime = fecha.Date.Add(hora.TimeOfDay)

                                    ' Concatenar fecha y hora a FechaCliente
                                    If String.IsNullOrEmpty(FechaCliente) Then
                                        FechaCliente = fechaHora.ToString("dd/MM/yyyy HH:mm")
                                    Else
                                        FechaCliente &= ", " & fechaHora.ToString("dd/MM/yyyy HH:mm")
                                    End If
                                Else
                                    ' Si no hay hora, solo mostrar la fecha
                                    If String.IsNullOrEmpty(FechaCliente) Then
                                        FechaCliente = fecha.ToString("dd/MM/yyyy")
                                    Else
                                        FechaCliente &= ", " & fecha.ToString("dd/MM/yyyy")
                                    End If
                                End If
                            End If



                            Dim tabla2 As DataTable
                            If VentasDatos.FechaServ = Nothing Then
                                ClearString(VentasDatos.FechaServ)
                            End If
                            If VentasDatos.Observaciones = Nothing Then
                                ClearString(VentasDatos.Observaciones)
                            End If
                            If VentasDatos.Hora = Nothing Then
                                ClearString(VentasDatos.Hora)
                            End If
                            tabla2 = VentasSP.InsDetVent(VentasDatos)
                            CodDetVender = tabla2(0)(0)
                            If CodDetVender > 0 Then
                                OperacionesDatos.CodDetVenta = CodDetVender
                                OperacionesDatos.Aclaracion = row.Cells(9)?.Value?.ToString()
                                If CInt(row.Cells(15)?.Value) = 1 Then
                                    OperacionesDatos.Valor = If(IsDBNull(row.Cells(8)?.Value), 0D, CDec(row.Cells(8)?.Value))
                                Else
                                    OperacionesDatos.Valor = 0D
                                End If
                                OperacionesDatos.FechaOp = row.Cells(3)?.Value?.ToString()
                                OperacionesDatos.HoraOp = row.Cells(4)?.Value?.ToString()
                                OperacionesDatos.Pasajeros = CInt(row.Cells(2)?.Value)
                                If OperacionesDatos.Aclaracion = Nothing Then
                                    ClearString(OperacionesDatos.Aclaracion)
                                End If
                                If OperacionesDatos.FechaOp = Nothing Then
                                    ClearString(OperacionesDatos.FechaOp)
                                End If
                                If OperacionesDatos.HoraOp = Nothing Then
                                    ClearString(OperacionesDatos.HoraOp)
                                End If
                                If CInt(row.Cells(15)?.Value) = 1 Then
                                    If OperacionesSP.InsOp(OperacionesDatos) Then
                                    Else
                                        MensajeNotificacion("Sucedió un error al intentar poner operacion para la fila " & row.Index + 1 & ".", "Error.")
                                    End If
                                End If
                            Else
                                MensajeNotificacion("Sucedió un error al intentar vender para la fila " & row.Index + 1 & ".", "Error.")
                            End If
                        Next

                        Dim textObject11 As TextObject = DirectCast(reporte.FindObject("Text56"), FastReport.TextObject)
                        If textObject11 IsNot Nothing Then
                            textObject11.Text = ApeEmp + " " + NomEmp + "."  ' NOMBRE EMPLEADO
                        End If

                        Dim textObject13 As FastReport.TextObject = DirectCast(reporte.FindObject("Text40"), FastReport.TextObject)
                        If textObject13 IsNot Nothing Then
                            textObject13.Text = DNIClienteVen
                        End If

                        Dim textObject15 As FastReport.TextObject = DirectCast(reporte.FindObject("Text54"), FastReport.TextObject)
                        If textObject15 IsNot Nothing Then
                            textObject15.Text = TelClienteVen
                        End If

                        Dim CodVentaConCeros As String = CodVender.ToString().PadLeft(8, "0"c)

                        Dim textObject16 As FastReport.TextObject = DirectCast(reporte.FindObject("Text29"), FastReport.TextObject)
                        If textObject16 IsNot Nothing Then
                            textObject16.Text = CodVentaConCeros
                        End If

                        reporte.RegisterData(dataTable, "MiTabla")
                        reporte.GetDataSource("MiTabla").Enabled = True

                        Dim dataSource As FastReport.Data.DataSourceBase = reporte.GetDataSource("MiTabla")
                        If dataSource IsNot Nothing Then
                            Debug.WriteLine("DataSource registrado correctamente")
                        Else
                            Debug.WriteLine("Error al registrar DataSource")
                        End If

                        Dim dataBand As FastReport.DataBand = CType(reporte.FindObject("dbd1"), FastReport.DataBand)
                        If dataBand IsNot Nothing Then
                            dataBand.DataSource = reporte.GetDataSource("MiTabla")
                            Debug.WriteLine("DataSource asignado correctamente al DataBand")
                        Else
                            Debug.WriteLine("No se encontró el DataBand")
                        End If

                        reporte.Prepare()
                        reporte.Show()
                        ClearInt(CodCliVender)
                        ClearString(NomApeCliAgrVent)
                        ClearInt(CodCliAgrVent)
                        Findeventa = True
                        CerrarUltimoFormulario()
                        'frmMenu.ManejarFormulario(frmVenCli, frmClientes, frmVenCli.pnlVenCli, "frmVenCli")
                        MensajeNotificacion("Venta realizada correctamente.", "Éxito.")
                        'frmClientes.rbCliAct.Checked = True
                        reporte.Dispose()
                        EnviarCorreoAutomatizado(NombreCliente, CorreoCliente, ServicioCliente, FechaCliente)
                    Else
                        MensajeNotificacion("Sucedió un error al intentar vender.", "Error.")
                    End If
                Else
                    MensajeNotificacion("No hay items para vender.", "Error.")
                End If
                Findeventa = False
            Else
                Dim textObject11 As TextObject = DirectCast(reporte.FindObject("Text56"), FastReport.TextObject)
                If textObject11 IsNot Nothing Then
                    textObject11.Text = ApeEmp + " " + NomEmp + "."  ' NOMBRE EMPLEADO
                End If

                Dim textObject13 As FastReport.TextObject = DirectCast(reporte.FindObject("Text40"), FastReport.TextObject)
                If textObject13 IsNot Nothing Then
                    textObject13.Text = "Simulación."
                End If

                Dim textObject15 As FastReport.TextObject = DirectCast(reporte.FindObject("Text54"), FastReport.TextObject)
                If textObject15 IsNot Nothing Then
                    textObject15.Text = "Simulación."
                End If

                Dim CodVentaConCeros As String = CodVender.ToString().PadLeft(8, "0"c)

                Dim textObject16 As FastReport.TextObject = DirectCast(reporte.FindObject("Text29"), FastReport.TextObject)
                If textObject16 IsNot Nothing Then
                    textObject16.Text = "Simulación."
                End If

                reporte.RegisterData(dataTable, "MiTabla")
                reporte.GetDataSource("MiTabla").Enabled = True

                Dim dataSource As FastReport.Data.DataSourceBase = reporte.GetDataSource("MiTabla")

                Dim dataBand As FastReport.DataBand = CType(reporte.FindObject("dbd1"), FastReport.DataBand)
                If dataBand IsNot Nothing Then
                    dataBand.DataSource = reporte.GetDataSource("MiTabla")
                Else

                End If

                reporte.Prepare()
                reporte.Show()
                ClearInt(CodCliVender)
                ClearString(NomApeCliAgrVent)
                ClearInt(CodCliAgrVent)
                CerrarUltimoFormulario()
                'frmMenu.ManejarFormulario(frmVenCli, frmClientes, frmVenCli.pnlVenCli, "frmVenCli")
                MensajeNotificacion("Simulación finalizada correctamente.", "Éxito.")
                reporte.Dispose()
                AgrSimulacion = False



            End If
        Else
            CodMonedaGlobal = 0
            CodMedPagoGlobal = 0
            CodTransGlobal = ""
        End If
    End Sub

    Private Sub btnFinCom_Click(sender As Object, e As EventArgs) Handles btnFinCom.Click
        If dgvVender.Rows.Count > 0 Then
            If AgrSimulacion = False Then
                If CodMonedaGlobal = 0 Or CodMedPagoGlobal = 0 Then
                    Dim frmMoneda As New frmVisorReportes()
                    frmMoneda.ShowDialog()
                    frmMoneda.TopMost = True
                    Return
                Else
                    CodMonedaGlobal = 0
                    CodMedPagoGlobal = 0
                    Dim frmMoneda As New frmVisorReportes()
                    frmMoneda.ShowDialog()
                    frmMoneda.TopMost = True
                    Return
                End If
            Else
                Vender()
            End If
        Else
            MensajeNotificacion("No hay items para vender.", "Error.")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Inicio()
    End Sub

    Private Sub ckbActFecha_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActFecha.CheckedChanged
        If ckbActFecha.Checked Then
            ckbActFecha.Image = My.Resources.icons8_tickc_24
            ControlTrue(dtpFecha)
            ControlTrue(ckbActHora)
        Else
            'ckbActFecha.Image = My.Resources.icons8_tickc_no_24
            'ControlFalse(dtpFecha)
            'ControlFalse(ckbActHora)
            'ckbActHora.Checked = False
            'ControlFalse(dtpHora)
        End If
    End Sub

    Private Sub ckbActHora_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActHora.CheckedChanged
        If ckbActHora.Checked Then
            ckbActHora.Image = My.Resources.icons8_tickc_24
            ControlTrue(dtpHora)
        Else
            ckbActHora.Image = My.Resources.icons8_tickc_no_24
            ControlFalse(dtpHora)
        End If
    End Sub

    Private Sub ckbActOp_CheckedChanged(sender As Object, e As EventArgs) Handles ckbActOp.CheckedChanged
        If ckbActOp.Checked Then
            ckbActOp.Image = My.Resources.icons8_tickc_24
            ControlTrue(txtOpMont)
            ControlTrue(txtAcla)
        Else
            ckbActOp.Image = My.Resources.icons8_tickc_no_24
            ControlFalse(txtOpMont)
            ControlFalse(txtAcla)
        End If
    End Sub

#Region "Ocultar Panel"
    Private Sub frmAgrVent_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub pnlDatVender_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDatVender.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnNuevo_MouseDown(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtCli_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCli.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs) Handles Label3.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtServ_MouseDown(sender As Object, e As MouseEventArgs) Handles txtServ.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtCantPer_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCantPer.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub ckbActFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub ckbActHora_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActHora.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub dtpFecha_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpFecha.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub dtpHora_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpHora.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtNotas_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNotas.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub ckbActOp_MouseDown(sender As Object, e As MouseEventArgs) Handles ckbActOp.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub pnlDGVVender_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVVender.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub dgvVender_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvVender.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label11_MouseDown(sender As Object, e As MouseEventArgs) Handles Label11.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtTotal_MouseDown(sender As Object, e As MouseEventArgs) Handles txtTotal.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label13_MouseDown(sender As Object, e As MouseEventArgs) Handles Label13.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label10.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtOpMont_MouseDown(sender As Object, e As MouseEventArgs) Handles txtOpMont.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label12_MouseDown(sender As Object, e As MouseEventArgs) Handles Label12.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtAcla_MouseDown(sender As Object, e As MouseEventArgs) Handles txtAcla.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnAgrSer_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAgrSer.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnRetSer_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRetSer.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label7_MouseDown(sender As Object, e As MouseEventArgs) Handles Label7.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnFinCom_MouseDown(sender As Object, e As MouseEventArgs) Handles btnFinCom.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub btnSelSer_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSelSer.MouseDown
        OcultarPanel()
    End Sub

    Private Sub pnlAgrSer_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAgrSer.MouseDown
        OcultarPanel()
    End Sub

    Private Sub pnlDGVServ_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlDGVServ.MouseDown
        OcultarPanel()
    End Sub

    Private Sub Label9_MouseDown(sender As Object, e As MouseEventArgs) Handles Label9.MouseDown
        OcultarPanel()
    End Sub

    Private Sub txtBusSer_MouseDown(sender As Object, e As MouseEventArgs) Handles txtBusSer.MouseDown
        OcultarPanel()
    End Sub

    Private Sub dgvServVen_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvServVen.MouseDown
        OcultarPanel()
    End Sub

    Private Sub dgvVender_Click(sender As Object, e As EventArgs) Handles dgvVender.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub pnlDGVVender_Click(sender As Object, e As EventArgs) Handles pnlDGVVender.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub pnlDatVender_Click(sender As Object, e As EventArgs) Handles pnlDatVender.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub dgvServVen_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvServVen.CellFormatting
        ' Verifica si la celda pertenece a la columna que deseas formatear (por ejemplo, la columna 1)
        If e.ColumnIndex = 4 AndAlso e.Value IsNot Nothing Then
            ' Aplica el formato de moneda
            e.Value = String.Format("{0:C2}", e.Value)
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub dgvVender_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ' Verifica si la celda pertenece a la columna que deseas formatear
        'If (e.ColumnIndex = 5 Or e.ColumnIndex = 8) AndAlso e.Value IsNot Nothing Then
        '    Dim doubleValue As Double

        '    ' Intenta convertir el valor a Double
        '    If Double.TryParse(e.Value.ToString(), doubleValue) Then
        '        If Not e.FormattingApplied Then
        '            e.Value = doubleValue ' Asigna el valor convertido            
        '            'e.FormattingApplied = True ' Asegúrate de marcar que se aplicó el formato
        '        End If
        '    Else
        '        ' Maneja el error de conversión aquí
        '        e.Value = DBNull.Value ' O deja el valor como DBNull si prefieres
        '        'e.FormattingApplied = True
        '    End If
        'End If

        ' Formatea el valor como moneda si corresponde
        If (e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 8 Or e.ColumnIndex = 10) AndAlso e.Value IsNot Nothing Then
            If Not e.FormattingApplied Then
                Dim decimalValue As Decimal

                If Decimal.TryParse(e.Value.ToString(), decimalValue) Then
                    e.Value = String.Format("{0:C2}", decimalValue)
                    e.FormattingApplied = True
                Else
                    e.Value = DBNull.Value ' O algún otro valor que prefieras
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub txtNotas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            ep.Clear()
            If ckbActOp.Checked Then
                txtOpMont.Focus()
                Return
            Else
                AgregarServ()
            End If
        End If
    End Sub

    Dim Sim As String = "venta"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir de la " & Sim & " sin terminarla?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            CerrarUltimoFormulario()
            ClearInt(CodCliVender)
            ClearString(NomApeCliAgrVent)
            ClearInt(CodCliAgrVent)
            AgrSimulacion = False
            'Inicio()
            'InicioEX()
        End If

    End Sub

    Private Sub txtDolar_MouseDown(sender As Object, e As MouseEventArgs) Handles txtDolar.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtEuro_MouseDown(sender As Object, e As MouseEventArgs) Handles txtEuro.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub txtReal_MouseDown(sender As Object, e As MouseEventArgs) Handles txtReal.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label17_MouseDown(sender As Object, e As MouseEventArgs) Handles Label17.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label14_MouseDown(sender As Object, e As MouseEventArgs) Handles Label14.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label15_MouseDown(sender As Object, e As MouseEventArgs) Handles Label15.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Label16_MouseDown(sender As Object, e As MouseEventArgs) Handles Label16.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        OcultarPanel()
        MinimizarPanel(pnlAgrSer)
    End Sub

    Private Sub frmAgrVent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmVenCli.btnVender.BackColor = Color.Transparent
    End Sub


#End Region

#End Region

End Class