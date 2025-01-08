Imports Datos
Imports System.Runtime.InteropServices
Imports Entidades

Public Class frmAgrTpServ

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

    Dim BanderaMod As Boolean
    Dim CodTpServ As Integer = 0

    Private Sub Inicio()
        CodTpServ = 0
        ControlTrue(btnAgrMod)
        ClearText(txtAgrTel)
        BanderaMod = False
        btnAgrMod.Text = "    Agregar"
        ControlTrue(txtAgrTel)
        btnAgrMod.Image = My.Resources.icons8_más_24
        btnCancelar.Image = My.Resources.icons8_cancelar_25
    End Sub

    Private Sub MoverFrmPpal(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.FromArgb(30, 63, 111) Then
                    ColorParpadeo(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
                Else
                    ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
                End If
            End If
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Dim ServiciosSp As New clsServ

    Private Sub GetTpServ()
        dgvTpServicios.DataSource = ServiciosSp.GetTpServicios()
    End Sub


    Private Sub frmAgrTpServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTpServicios.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvTpServicios.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        SetDoubleBuffered(dgvTpServicios)
        Inicio()
        CentrarForm(Me)
        GetTpServ()
        MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        ' Establece un tamaño fijo para la primera columna
        dgvTpServicios.Columns(0).Width = 50  ' Ajusta el ancho según necesites
        dgvTpServicios.Columns(1).Width = 534
        ' Establece que las demás columnas se ajusten automáticamente al espacio disponible
        'dgvTpServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ' Ajusta el tamaño de los encabezados
        dgvTpServicios.RowHeadersWidth = 15
        ' Anima la ventana
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnAgrMod, 10)
        frmMenu.RoundButton(btnCancelar, 10)
        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub frmTelefonos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub dgvTpServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTpServicios.CellDoubleClick
        If dgvTpServicios.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
            If e.RowIndex >= 0 AndAlso e.RowIndex < dgvTpServicios.Rows.Count Then
                Dim row = dgvTpServicios.Rows(e.RowIndex)
                If Not row.Cells.Cast(Of DataGridViewCell).Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                Else
                    CodTpServ = row.Cells(0)?.Value?.ToString
                    btnAgrMod.Text = "    Modificar"
                    btnAgrMod.Image = My.Resources.icons8_más_b_24
                    ControlTrue(txtAgrTel)
                    BanderaMod = True
                    ControlTrue(btnAgrMod)
                    txtAgrTel.Text = row.Cells(1)?.Value?.ToString
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Inicio()
    End Sub

    Private Sub btnAgrMod_Click(sender As Object, e As EventArgs) Handles btnAgrMod.Click
        ep.Clear()
        CampoBlanco(gbDatoTp, ep)
        Dim Servicio As New clsServ
        Dim tabla As New DataTable
        Dim ServicioDatos As New eServ
        'crear bandera de mod o cre
        If banbl = True Then
            ServicioDatos.CodTpServ = CodTpServ
            ServicioDatos.NombreTp = txtAgrTel.Text
            ServicioDatos.IdAltaTp = CodUsu
            If BanderaMod = False Then
                If ServiciosSp.InsTpServ(ServicioDatos) Then
                    MensajeNotificacion("Tipo de servicio grabado exitosamente.", "Éxito.")
                    frmServ.Determinar()
                    frmServ.CargaCmbTpServ()
                    Inicio()
                    GetTpServ()
                Else
                    MensajeNotificacion("Sucedió un error al intentar grabar el tipo de servicio.", "Error.")
                End If
            Else
                If ServiciosSp.ModTpServ(ServicioDatos) Then
                    MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                    frmServ.Determinar()
                    frmServ.CargaCmbTpServ()
                    Inicio()
                    GetTpServ()
                Else
                    MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco(gbDatoTp, ep)
        End If
        Inicio()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If txtAgrTel.Text = "" And btnAgrMod.Text = "    Modificar" Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                Me.Close()
                frmServ.Determinar()
            End If
        Else
            Me.Close()
            frmServ.Determinar()
        End If
    End Sub

#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrmPpal(pnlMnuTool, e)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrmPpal(tsslNomUsu, e)
    End Sub

    Private Sub frmTelefonos_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
    End Sub

    Private Sub dgvTelefonos_MouseEnter(sender As Object, e As EventArgs) Handles dgvTpServicios.MouseEnter
        ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
    End Sub

    Private Sub pnlMnuTool_MouseEnter(sender As Object, e As EventArgs) Handles pnlMnuTool.MouseEnter
        ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
    End Sub

    Private Sub btnMini_MouseEnter(sender As Object, e As EventArgs) Handles btnMini.MouseEnter
        ColorMin(pnlMnuTool, PictureBox1)
        btnMiniMax.BackColor = Color.FromArgb(30, 63, 111)
        btnExit.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnMiniMax_MouseEnter(sender As Object, e As EventArgs) Handles btnMiniMax.MouseEnter
        ColorMin(pnlMnuTool, PictureBox1)
        btnMini.BackColor = Color.FromArgb(30, 63, 111)
        btnExit.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        ColorMin(pnlMnuTool, PictureBox1)
        btnMiniMax.BackColor = Color.FromArgb(30, 63, 111)
        btnMini.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        ColorMax(pnlMnuTool, PictureBox1, btnMiniMax, btnExit)
    End Sub
#End Region
End Class