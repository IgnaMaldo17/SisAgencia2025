#Region "Imports"
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
#End Region

Public Class frmSelProv

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
    Dim ProveedoresSP As New clsProv
    Dim ProveedoresDatos As New eProv
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

    Private Sub GetProvShrt()
        dgvProveedoresShrt.DataSource = ProveedoresSP.GetProveedoresShrt()
    End Sub

    Public Sub Cargar()
        If txtBusProvShrt.Text.Length = 0 Or txtBusProvShrt.ForeColor = Color.Gray Then
            GetProvShrt()
        Else
            Me.dgvProveedoresShrt.DataSource = ProveedoresSP.BuscarProveedoresShrt(txtBusProvShrt.Text)
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
    Private Sub frmSelProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        GetProvShrt()
        CentrarForm(Me)
        ClearString(RazonSocialSelProv)
        ClearInt(CodProvSelProv)
        SetDoubleBuffered(dgvProveedoresShrt)
        dgvProveedoresShrt.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvProveedoresShrt.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.dgvProveedoresShrt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProveedoresShrt.RowHeadersWidth = 15
        AnimateWindow(Me.Handle, 100, AW_BLEND)

        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub txtBusProvShrt_Enter(sender As Object, e As EventArgs) Handles txtBusProvShrt.Enter
        If txtBusProvShrt.Text = "Buscar Proveedor" Then
            ClearText(txtBusProvShrt)
            txtBusProvShrt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusProvShrt_Leave(sender As Object, e As EventArgs) Handles txtBusProvShrt.Leave
        If String.IsNullOrWhiteSpace(txtBusProvShrt.Text) Then
            txtBusProvShrt.Text = "Buscar Proveedor"
            txtBusProvShrt.ForeColor = Color.Gray
            GetProvShrt()
        End If
    End Sub

    Private Sub txtBusProvShrt_TextChanged(sender As Object, e As EventArgs) Handles txtBusProvShrt.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusProvShrt_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusProvShrt.MouseClick
        If txtBusProvShrt.Text = "Buscar Proveedor" Then
            ClearText(txtBusProvShrt)
            txtBusProvShrt.ForeColor = Color.Black
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
            ClearString(RazonSocialSelProv)
            ClearInt(CodProvSelProv)
        End If
    End Sub

    Private Sub dgvProveedoresShrt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedoresShrt.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvProveedoresShrt.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvProveedoresShrt.Rows.Count Then
                    Dim row As DataGridViewRow = dgvProveedoresShrt.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                    Else
                        CodProvSelProv = CInt(row.Cells(5)?.Value) ' Actualiza el código del cliente seleccionado
                        RazonSocialSelProv = row.Cells(1)?.Value?.ToString()
                        'tsslNomUsu.Text = "Proveedor: '" & RazonSocialSelProv & "' seleccionado."
                    End If
                End If
            End If
        End If
        If RazonSocialSelProv <> "" AndAlso CodProvSelProv <> 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("Seleccionó al proveedor: '" & RazonSocialSelProv & "' ¿Proceder?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                frmServ.txtProv.Text = RazonSocialSelProv
                frmServ.CodProv = CodProvSelProv
                Me.Close()
            Else
                ClearString(RazonSocialSelProv)
                ClearInt(CodProvSelProv)
            End If
        Else
            ClearString(RazonSocialSelProv)
            ClearInt(CodProvSelProv)
        End If
    End Sub

    Private Sub dgvProveedoresShrt_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvProveedoresShrt.DataBindingComplete
        If dgvProveedoresShrt.Columns.Count > 0 Then
            dgvProveedoresShrt.Columns(dgvProveedoresShrt.Columns.Count - 1).Visible = False
        End If
    End Sub

    Private Sub frmSelProv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
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

    Private Sub frmSelProv_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub pnlSelProv_MouseEnter(sender As Object, e As EventArgs) Handles pnlSelProv.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub dgvProveedoresShrt_MouseEnter(sender As Object, e As EventArgs) Handles dgvProveedoresShrt.MouseEnter
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