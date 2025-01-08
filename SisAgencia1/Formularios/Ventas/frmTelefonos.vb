#Region "Imports"
Imports System.Net.Security
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Datos
Imports Entidades
#End Region

Public Class frmTelefonos

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
    Dim TelefonosSP As New clsTel
    Dim clientes As New frmClientes
    Dim BanderaMod As Boolean = False
    Dim BanderaRes As Boolean = False
    Dim CodNum As Integer = 0
    Dim bMaxTel As Boolean = False
    Dim iteraciones As Integer = 0
#End Region

#Region "Subrutinas"
    Private Sub GetTel()
        dgvTelefonos.DataSource = TelefonosSP.MostrarTelefono(dnibus)
    End Sub

    Private Sub Inicio()
        ControlTrue(btnAgrMod)
        BanderaRes = False
        ClearText(txtAgrTel)
        BanderaMod = False
        btnAgrMod.Text = "    Agregar"
        btnEliRes.Text = "    Eliminar"
        ControlTrue(txtAgrTel)
        ControlFalse(btnEliRes)
        btnAgrMod.Image = My.Resources.icons8_más_24
        btnEliRes.Image = My.Resources.icons8_menos_25
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

    Private Sub VerificarNombreSize()
        If gbDatoTel.Text IsNot Nothing Then
            If gbDatoTel.Text.Length <= 33 Then
            Else
                If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 10)
                ElseIf gbDatoTel.Text.Length > 39 Then
                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 12)
                    gbDatoTel.Text = "Cliente: " + ApeCli
                    If gbDatoTel.Text.Length <= 33 Then
                    Else
                        If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                            gbDatoTel.Font = New Font("Microsoft Sans Serif", 10)
                        ElseIf gbDatoTel.Text.Length > 39 Then
                            gbDatoTel.Font = New Font("Microsoft Sans Serif", 12)
                            gbDatoTel.Text = ApeCli
                            If gbDatoTel.Text.Length <= 33 Then
                                gbDatoTel.Font = New Font("Microsoft Sans Serif", 11)
                            Else
                                If gbDatoTel.Text.Length > 33 AndAlso gbDatoTel.Text.Length <= 39 Then
                                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 9)
                                ElseIf gbDatoTel.Text.Length > 39 AndAlso gbDatoTel.Text.Length <= 47 Then
                                    gbDatoTel.Font = New Font("Microsoft Sans Serif", 8)
                                Else
                                    gbDatoTel.Text = "Ingrese el teléfono:"
                                End If
                            End If
                        End If
                    End If
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
#End Region

#Region "Eventos"
    Private Sub frmTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 200 ' Establece el intervalo del temporizador (en milisegundos)
        dgvTelefonos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvTelefonos.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        SetDoubleBuffered(dgvTelefonos)
        Inicio()
        gbDatoTel.Text = "Cliente: " + ApeCli + " " + NomCli
        VerificarNombreSize()
        CentrarForm(Me)
        GetTel()
        MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTelefonos.RowHeadersWidth = 15
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnAgrMod, 10)
        frmMenu.RoundButton(btnEliRes, 10)
        frmMenu.RoundButton(btnCancelar, 10)
        frmMenu.RoundButton(btnExit, 10)
    End Sub

    Private Sub frmTelefonos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Normal Then
            bMaxTel = False
            btnMiniMax.Image = My.Resources.icons8_agrandar_25
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            bMaxTel = True
            btnMiniMax.Image = My.Resources.icons8_comprimir_25
        End If
    End Sub

    Private Sub frmTelefonos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub dgvTelefonos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellDoubleClick
        If dgvTelefonos.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
            If e.RowIndex >= 0 AndAlso e.RowIndex < dgvTelefonos.Rows.Count Then
                Dim row = dgvTelefonos.Rows(e.RowIndex)
                If Not row.Cells.Cast(Of DataGridViewCell).Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                Else
                    CodNum = row.Cells(0)?.Value?.ToString
                    btnAgrMod.Text = "    Modificar"
                    btnAgrMod.Image = My.Resources.icons8_más_b_24
                    If row.Cells(6)?.Value?.ToString = "Activo" Then
                        ControlTrue(btnEliRes)
                        btnEliRes.Text = "    Eliminar"
                        ControlTrue(txtAgrTel)
                        BanderaMod = True
                        BanderaRes = False
                        ControlTrue(btnAgrMod)
                        btnEliRes.Image = My.Resources.icons8_menos_25
                        txtAgrTel.Text = row.Cells(3)?.Value?.ToString
                    ElseIf row.Cells(6)?.Value?.ToString = "Eliminado" Then
                        btnEliRes.Text = "    Restaurar"
                        BanderaMod = True
                        BanderaRes = True
                        txtAgrTel.Text = row.Cells(3)?.Value?.ToString
                        ControlFalse(btnAgrMod)
                        ControlTrue(btnEliRes)
                        ControlFalse(txtAgrTel)
                        btnEliRes.Image = My.Resources.icons8_cita_recurrente_24
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtAgrTel_TextChanged(sender As Object, e As EventArgs) Handles txtAgrTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtAgrTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAgrTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub btnAgrMod_Click(sender As Object, e As EventArgs) Handles btnAgrMod.Click
        ep.Clear()
        CampoBlanco(gbDatoTel, ep)
        Dim Usuario As New clsCli
        Dim tabla As New DataTable
        Dim ClienteDatos As New eCli
        'crear bandera de mod o cre
        If banbl = True Then
            ClienteDatos.CodNum = CodNum
            ClienteDatos.CodCli = frmClientes.CodCli
            ClienteDatos.Telefono = txtAgrTel.Text
            ClienteDatos.IdAlta = CodUsu
            If frmClientes.CodCli = 0 Then
                MensajeNotificacion("Ocurrió un error al intentar guardar los cambios (ID 0).", "Error.")
            Else
                If BanderaMod = False Then
                    If TelefonosSP.InsTel(ClienteDatos) Then
                        MensajeNotificacion("Teléfono grabado exitosamente.", "Éxito.")
                        frmClientes.Determinar()
                        Inicio()
                        GetTel()
                    Else
                        MensajeNotificacion("Sucedió un error al intentar grabar el teléfono.", "Error.")
                    End If
                Else
                    If TelefonosSP.ModTel(ClienteDatos) Then
                        ClienteDatos.CodCli = frmClientes.CodCli
                        MensajeNotificacion("Registro actualizado exitosamente.", "Éxito.")
                        frmClientes.Determinar()
                        Inicio()
                        GetTel()
                    Else
                        MensajeNotificacion("Ocurrió un error al intentar guardar los cambios.", "Error.")
                    End If
                End If
            End If
        ElseIf banbl = False Then
            CampoBlanco(gbDatoTel, ep)
        End If
        Inicio()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Inicio()
    End Sub

    Private Sub btnEliRes_Click(sender As Object, e As EventArgs) Handles btnEliRes.Click
        If BanderaRes = True Then
            'restaurar
            CampoBlanco(gbDatoTel, ep)
            If banbl = True Then
                If TelefonosSP.AltaTelefono(CodNum) Then
                    MensajeNotificacion("Teléfono restaurado exitosamente.", "Éxito.")
                    frmClientes.Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar recuperar el número.", "Error.")
                End If
            ElseIf banbl = False Then
                CampoBlanco(gbDatoTel, ep)
            End If
        Else
            'eliminar
            Dim resultado = MessageBox.Show("Está por dar de baja un número de cliente ¿Desea continuar?", "Eliminar número.", MessageBoxButtons.YesNoCancel)
            If resultado = DialogResult.Yes Then
                If TelefonosSP.BajaTelefono(CodNum, CodUsu) Then
                    MensajeNotificacion("Teléfono dado de baja exitosamente.", "Éxito.")
                    frmClientes.Determinar()
                Else
                    MensajeNotificacion("Hubo un error al intentar dar de baja el número.", "Error.")
                End If
            End If
        End If
        GetTel()
        Inicio()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If txtAgrTel.Text = "" And btnAgrMod.Text = "    Modificar" Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la ventana?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
            If respuesta = DialogResult.Yes Then
                Me.Close()
                frmClientes.Determinar()
            End If
        Else
            Me.Close()
            frmClientes.Determinar()
        End If
    End Sub

    Private Sub btnMiniMax_Click(sender As Object, e As EventArgs) Handles btnMiniMax.Click
        If bMaxTel = False Then
            Maximizar(Me)
            bMaxTel = True
            Me.btnMiniMax.Image = My.Resources.icons8_comprimir_25
            dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Else
            bMaxTel = False
            Me.btnMiniMax.Image = My.Resources.icons8_agrandar_25
            Minimizar(Me)
            dgvTelefonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
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

    Private Sub dgvTelefonos_MouseEnter(sender As Object, e As EventArgs) Handles dgvTelefonos.MouseEnter
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

#End Region

End Class