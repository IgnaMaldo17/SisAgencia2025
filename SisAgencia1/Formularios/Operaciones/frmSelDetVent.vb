#Region "Imports"
Imports Datos
Imports Entidades
Imports System.Runtime.InteropServices
#End Region

Public Class frmSelDetVent

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
    Dim OperacionesSP As New clsOp
#End Region

#Region "Subrutinas"
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

    Private Sub GetDetVentNoOp()
        dgvDetVentas.DataSource = OperacionesSP.GetDetVentNoOp()
    End Sub

    Public Sub Cargar()
        If txtBusDetVentas.Text.Length = 0 Or txtBusDetVentas.ForeColor = Color.Gray Then
            GetDetVentNoOp()
        Else
            Me.dgvDetVentas.DataSource = OperacionesSP.BuscarDetVentNoOp(txtBusDetVentas.Text)
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
    Private Sub frmSelDetVent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        GetDetVentNoOp()
        CentrarForm(Me)
        ClearString(NomServSelDetVent)
        ClearInt(CodDetVentSel)
        SetDoubleBuffered(dgvDetVentas)
        dgvDetVentas.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvDetVentas.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.dgvDetVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetVentas.RowHeadersWidth = 15
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub dgvProveedoresShrt_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvDetVentas.DataBindingComplete
        If dgvDetVentas.Columns.Count > 0 Then
            dgvDetVentas.Columns(dgvDetVentas.Columns.Count - 1).Visible = False
        End If
    End Sub

    Private Sub frmSelDetVent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub txtBusDetVentas_Enter(sender As Object, e As EventArgs) Handles txtBusDetVentas.Enter
        If txtBusDetVentas.Text = "Buscar Servicio Vendido" Then
            ClearText(txtBusDetVentas)
            txtBusDetVentas.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusDetVentas_Leave(sender As Object, e As EventArgs) Handles txtBusDetVentas.Leave
        If String.IsNullOrWhiteSpace(txtBusDetVentas.Text) Then
            txtBusDetVentas.Text = "Buscar Servicio Vendido"
            txtBusDetVentas.ForeColor = Color.Gray
            GetDetVentNoOp()
        End If
    End Sub

    Private Sub txtBusDetVentas_TextChanged(sender As Object, e As EventArgs) Handles txtBusDetVentas.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusDetVentas_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusDetVentas.MouseClick
        If txtBusDetVentas.Text = "Buscar Servicio Vendido" Then
            ClearText(txtBusDetVentas)
            txtBusDetVentas.ForeColor = Color.Black
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
            ClearString(NomServSelDetVent)
            ClearInt(CodDetVentSel)
        End If

    End Sub

    Private Sub dgvDetVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetVentas.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvDetVentas.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvDetVentas.Rows.Count Then
                    Dim row As DataGridViewRow = dgvDetVentas.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                    Else
                        CodDetVentSel = CInt(row.Cells(1)?.Value) ' Actualiza el código del cliente seleccionado
                        NomServSelDetVent = row.Cells(7)?.Value?.ToString()
                        'tsslNomUsu.Text = "Servicio vendido: '" & NomServSelDetVent & "' de número " & CodDetVentSel & " seleccionado."
                    End If
                End If
            End If
        End If
        If NomServSelDetVent <> "" AndAlso CodDetVentSel <> 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("Seleccionó el servicio vendido: '" & NomServSelDetVent & "' de número " & CodDetVentSel & " ¿Proceder?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                frmOp.btnEleDetVent.Enabled = False
                frmOp.btnEleVeh.Enabled = True
                frmOp.CodDetVent = CodDetVentSel
                frmOp.txtDetVent.Text = NomServSelDetVent
                Me.Close()
            Else
                ClearString(NomServSelDetVent)
                ClearInt(CodDetVentSel)
                'Me.Close()
            End If
        Else
            ClearString(NomServSelDetVent)
            ClearInt(CodDetVentSel)
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

    Private Sub frmSelDetVent_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub pnlSelDetVent_MouseEnter(sender As Object, e As EventArgs) Handles pnlSelDetVent.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub dgvProveedoresShrt_MouseEnter(sender As Object, e As EventArgs) Handles dgvDetVentas.MouseEnter
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