#Region "Imports"
Imports Datos
Imports Entidades
Imports System.Runtime.InteropServices
#End Region

Public Class frmSelCli

#Region "Shared Function"
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function AnimateWindow(hwnd As IntPtr, dwTime As Integer, dwFlags As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
#End Region

#Region "Declaraciones"
    Dim ClientesSP As New clsCli
    Dim ClientesDatos As New eCli
#End Region

#Region "Subrutinas"
    Private Sub GetCliShrt()
        dgvClientesShrt.DataSource = ClientesSP.GetClientesShrt()
    End Sub

    Public Sub Cargar()
        If txtBusCliShrt.Text.Length = 0 Or txtBusCliShrt.ForeColor = Color.Gray Then
            GetCliShrt()
        Else
            Me.dgvClientesShrt.DataSource = ClientesSP.BuscarClientesShrt(txtBusCliShrt.Text)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.FromArgb(30, 63, 111) Then
                    ColorParpadeo(pnlMnuTool, PictureBox2, btnMini, btnExit)
                Else
                    ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
                End If
            End If
        End If
    End Sub

    Private Sub MoverFrmPpal(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmSelCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        Cargar()
        GetCliShrt()
        ClearString(NomApeCliAgrVent)
        ClearInt(CodCliAgrVent)
        SetDoubleBuffered(dgvClientesShrt)
        dgvClientesShrt.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvClientesShrt.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.dgvClientesShrt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientesShrt.RowHeadersWidth = 15
        AnimateWindow(Me.Handle, 100, AW_BLEND)

        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub frmSelCli_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub txtBusCliShrt_Enter(sender As Object, e As EventArgs) Handles txtBusCliShrt.Enter
        If txtBusCliShrt.Text = "Buscar Cliente" Then
            ClearText(txtBusCliShrt)
            txtBusCliShrt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusCliShrt_Leave(sender As Object, e As EventArgs) Handles txtBusCliShrt.Leave
        If String.IsNullOrWhiteSpace(txtBusCliShrt.Text) Then
            txtBusCliShrt.Text = "Buscar Cliente"
            txtBusCliShrt.ForeColor = Color.Gray
            GetCliShrt()
        End If
    End Sub

    Private Sub txtBusCliShrt_TextChanged(sender As Object, e As EventArgs) Handles txtBusCliShrt.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusCliShrt_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusCliShrt.MouseClick
        If txtBusCliShrt.Text = "Buscar Cliente" Then
            ClearText(txtBusCliShrt)
            txtBusCliShrt.ForeColor = Color.Black
        Else
            Cargar()
        End If
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea salir sin seleccionar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            Me.Close()
            ClearString(NomApeCliAgrVent)
            ClearInt(CodCliAgrVent)
        End If

    End Sub

    Private Sub dgvClientesShrt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientesShrt.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvClientesShrt.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvClientesShrt.Rows.Count Then
                    Dim row As DataGridViewRow = dgvClientesShrt.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                    Else
                        CorreoCli = row.Cells(5)?.Value?.ToString()
                        CodCliAgrVent = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        NomApeClienteVen = row.Cells(2)?.Value?.ToString() & " " & row.Cells(3)?.Value?.ToString()
                        TelClienteVen = row.Cells(6)?.Value?.ToString()
                        DNIClienteVen = row.Cells(1)?.Value?.ToString()
                        'tsslNomUsu.Text = "Cliente: " & NomApeClienteVen & " seleccionado."
                    End If
                End If
            End If
        End If
        If NomApeClienteVen <> "" AndAlso CodCliAgrVent <> 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("Seleccionó al cliente: " & NomApeClienteVen & " ¿Proceder?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                If VendesdeVent = True Then
                    '  frmPrincipal.AbrirFormularioRe(frmVisorReportes)
                    frmAgrVent.txtCli.Text = NomApeClienteVen
                    CodCliVender = CodCliAgrVent
                    AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
                    ActualizarUltimosFormularios("frmAgrVent")
                    frmAgrVent.IluminarFormulario()
                    VendesdeVent = False
                Else
                    '  frmPrincipal.AbrirFormularioRe(frmVisorReportes)
                    frmAgrVent.txtCli.Text = NomApeClienteVen
                    CodCliVender = CodCliAgrVent

                    If VenderConVenCliAbierto = False Then

                        frmPrincipal.AbrirFormulario(frmVenCli)
                        VerPanel(frmPrincipal.btnVolver)
                        VerPanel(frmPrincipal.btnInicio2)
                        ActualizarUltimosFormularios("frmVenCli")

                    End If


                    AbrirFormPanel(frmAgrVent, frmVenCli.pnlVenCli)
                    ActualizarUltimosFormularios("frmAgrVent")
                    frmAgrVent.IluminarFormulario()
                End If



                Me.Close()

            Else
                ClearString(NomApeCliAgrVent)
                ClearInt(CodCliAgrVent)
                'Me.Close()
            End If
        Else
            ClearString(NomApeCliAgrVent)
            ClearInt(CodCliAgrVent)
            'Me.Close()
        End If
    End Sub
#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrmPpal(pnlMnuTool, e)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrmPpal(tsslNomUsu, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrmPpal(PictureBox2, e)
    End Sub

    Private Sub pnlMnuTool_MouseEnter(sender As Object, e As EventArgs) Handles pnlMnuTool.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub tsslNomUsu_MouseEnter(sender As Object, e As EventArgs) Handles tsslNomUsu.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub frmSelCli_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub pnlSelCli_MouseEnter(sender As Object, e As EventArgs) Handles pnlSelCli.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub dgvClientesShrt_MouseEnter(sender As Object, e As EventArgs) Handles dgvClientesShrt.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub btnMini_MouseEnter(sender As Object, e As EventArgs) Handles btnMini.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnExit.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        ColorMin(pnlMnuTool, PictureBox2)
        btnMini.BackColor = Color.FromArgb(30, 63, 111)
    End Sub
#End Region

#End Region

End Class