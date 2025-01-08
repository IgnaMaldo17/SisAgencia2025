#Region "Imports"
Imports Datos
Imports Entidades
Imports System.Runtime.InteropServices
#End Region

Public Class frmSelVeh

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
    Dim VehiculosSP As New clsVeh
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

    Private Sub GetVehiculos()
        dgvVehiculos.DataSource = VehiculosSP.GetVehiculos()
    End Sub

    Public Sub Cargar()
        If txtBusVeh.Text.Length = 0 Or txtBusVeh.ForeColor = Color.Gray Then
            GetVehiculos()
        Else
            Me.dgvVehiculos.DataSource = VehiculosSP.BuscarVehiculos(txtBusVeh.Text)
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
    Private Sub frmSelVeh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        GetVehiculos()
        CentrarForm(Me)
        ClearString(NomVehSelVeh)
        ClearString(NomApeChofSelVeh)
        ClearInt(CodVehSelVeh)
        ClearInt(CodChofSelVeh)
        SetDoubleBuffered(dgvVehiculos)
        dgvVehiculos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvVehiculos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVehiculos.RowHeadersWidth = 15
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub txtBusVeh_Enter(sender As Object, e As EventArgs) Handles txtBusVeh.Enter
        If txtBusVeh.Text = "Buscar Vehículo" Then
            ClearText(txtBusVeh)
            txtBusVeh.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusVeh_Leave(sender As Object, e As EventArgs) Handles txtBusVeh.Leave
        If String.IsNullOrWhiteSpace(txtBusVeh.Text) Then
            txtBusVeh.Text = "Buscar Vehículo"
            txtBusVeh.ForeColor = Color.Gray
            GetVehiculos()
        End If
    End Sub

    Private Sub txtBusVeh_TextChanged(sender As Object, e As EventArgs) Handles txtBusVeh.TextChanged
        Cargar()
    End Sub

    Private Sub txtBusVeh_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusVeh.MouseClick
        If txtBusVeh.Text = "Buscar Vehículo" Then
            ClearText(txtBusVeh)
            txtBusVeh.ForeColor = Color.Black
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
            ClearString(NomVehSelVeh)
            ClearString(NomApeChofSelVeh)
            ClearInt(CodVehSelVeh)
            ClearInt(CodChofSelVeh)
        End If
    End Sub

    Private Sub dgvVehiculos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehiculos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Verifica si se hizo clic en una celda válida
            If dgvVehiculos.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
                If e.RowIndex >= 0 AndAlso e.RowIndex < dgvVehiculos.Rows.Count Then
                    Dim row As DataGridViewRow = dgvVehiculos.Rows(e.RowIndex)
                    If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                        ' Verifica si todas las celdas de la fila no son nulas
                    Else
                        CodVehSelVeh = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                        NomVehSelVeh = row.Cells(2)?.Value?.ToString()
                        CodChofSelVeh = CInt(row.Cells(10)?.Value) 'no es date
                        NomApeChofSelVeh = row.Cells(5)?.Value?.ToString() & " " & row.Cells(6)?.Value?.ToString()
                        'tsslNomUsu.Text = "Vehículo: '" & NomVehSelVeh & "' del chofer: " & NomApeChofSelVeh & " seleccionado."
                    End If
                End If
            End If
        End If
        If NomVehSelVeh <> "" AndAlso NomApeChofSelVeh <> "" AndAlso CodVehSelVeh <> 0 AndAlso CodChofSelVeh <> 0 Then
            Dim respuesta As DialogResult = MessageBox.Show("Seleccionó al vehículo: " & NomVehSelVeh & " del chofer:" & NomApeChofSelVeh & " ¿Proceder?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                frmOp.txtVeh.Text = NomVehSelVeh
                frmOp.CodVeh = CodVehSelVeh
                frmOp.txtChof.Text = NomApeChofSelVeh
                frmOp.CodChof = CodChofSelVeh
                Me.Close()
            Else
                ClearString(NomVehSelVeh)
                ClearString(NomApeChofSelVeh)
                ClearInt(CodVehSelVeh)
                ClearInt(CodChofSelVeh)
            End If
        Else
            ClearString(NomVehSelVeh)
            ClearString(NomApeChofSelVeh)
            ClearInt(CodVehSelVeh)
            ClearInt(CodChofSelVeh)
        End If
    End Sub

    Private Sub dgvVehiculos_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvVehiculos.DataBindingComplete
        If dgvVehiculos.Columns.Count > 0 Then
            dgvVehiculos.Columns(dgvVehiculos.Columns.Count - 1).Visible = False
            dgvVehiculos.Columns(dgvVehiculos.Columns.Count - 3).Visible = False
        End If
    End Sub

    Private Sub frmSelVeh_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub
#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
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

    Private Sub pnlSelVeh_MouseEnter(sender As Object, e As EventArgs) Handles pnlSelVeh.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub dgvProveedoresShrt_MouseEnter(sender As Object, e As EventArgs) Handles dgvVehiculos.MouseEnter
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