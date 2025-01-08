#Region "Imports"
Imports System.IO
Imports System.Drawing.Text
Imports System.Drawing
Imports Datos
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

#End Region

Public Class frmFav

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
    Dim CodForm As Integer
    Private Const MaxFilas As Integer = 5
    Private Const BotonesPorFila As Integer = 4
    Private Const BotonAncho As Integer = 88
    Private Const BotonAlto As Integer = 80
    Private Const Espacio As Integer = 22
    Private Const Margen As Integer = 4
    Dim UsuariosSP As New clsUsu
    Dim HizoClickenCKB As Boolean = False
#End Region

#Region "Subrutinas"
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                If pnlMnuTool.BackColor = Color.FromArgb(30, 63, 111) Then
                    ColorParpadeo(pnlMnuTool, PictureBox2, btnMini, btnExit)
                Else
                    ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
                End If
            End If
        End If
    End Sub

    Private Sub MoverFrm(sender As Object, e As MouseEventArgs)
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

    Private Sub MarcarFav()
        ' Obtener los valores de la tabla y guardarlos en una lista
        Dim tabla As New DataTable
        tabla = UsuariosSP.GetFav(CodUsu)
        Dim listaFav As New List(Of Integer)
        For Each fila As DataRow In tabla.Rows
            listaFav.Add(Convert.ToInt32(fila(0))) ' Suponiendo que el número favorito está en la primera columna de la tabla
        Next
        ' Suponiendo que el panel se llama "Panel1"
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                ' Obtener el número de CheckBox del atributo Tag
                Dim numCheckbox As Integer
                If Integer.TryParse(chk.Tag.ToString(), numCheckbox) Then
                    ' Verificar si el número de CheckBox está en la lista de favoritos
                    If listaFav.Contains(numCheckbox) Then
                        ' Marcar el CheckBox si está en la lista de favoritos
                        chk.Checked = True
                    End If
                End If
            End If
        Next
    End Sub

    Private Function VerificarFav() As Boolean
        ' Obtener los valores de la tabla y guardarlos en una lista
        Dim tabla As New DataTable
        tabla = UsuariosSP.GetFav(CodUsu)
        Dim listaFav As New List(Of Integer)
        For Each fila As DataRow In tabla.Rows
            listaFav.Add(Convert.ToInt32(fila(0))) ' Suponiendo que el número favorito está en la primera columna de la tabla
        Next
        ' Suponiendo que el panel se llama "Panel1"
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                Dim numCheckbox As Integer
                ' Extraer el número de CheckBox del atributo Tag
                If Integer.TryParse(chk.Tag.ToString(), numCheckbox) Then
                    ' Verificar si el número de CheckBox está en la lista de favoritos y si el CheckBox está marcado
                    If listaFav.Contains(numCheckbox) AndAlso chk.Checked = False Then
                        ' Si algún CheckBox que debería estar marcado no lo está, retornar False
                        Return False
                    ElseIf Not listaFav.Contains(numCheckbox) AndAlso chk.Checked = True Then
                        ' Si algún CheckBox que no debería estar marcado lo está, retornar False
                        Return False
                    End If
                End If
            End If
        Next
        ' Si todos los CheckBox coinciden con los números de la lista de favoritos, retornar True
        Return True
    End Function

    Private Sub LimpiarPanelFavoritos()
        frmMenu.pnlFavoritos.Controls.Clear()
    End Sub
#End Region

#Region "Eventos"


    Private Sub frmFav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MarcarFav()
        CentrarForm(Me)
        AnimateWindow(Me.Handle, 100, AW_BLEND)
        frmMenu.RoundButton(btnSelFav, 10)
        frmMenu.RoundButton(btnExit, 10)
        frmMenu.RoundButton(ckbCli, 10)
        frmMenu.RoundButton(ckbVent, 10)
        frmMenu.RoundButton(ckbDV, 10)
        frmMenu.RoundButton(btnExit, 10)
        frmMenu.RoundButton(ckbProv, 10)
        frmMenu.RoundButton(ckbServ, 10)
        frmMenu.RoundButton(ckbOp, 10)
        frmMenu.RoundButton(ckbChoferes, 10)
        frmMenu.RoundButton(ckbVeh, 10)
        frmMenu.RoundButton(ckbEmp, 10)
        frmMenu.RoundButton(ckbUsu, 10)
    End Sub

    Private Sub frmFav_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimateWindow(Me.Handle, 100, AW_BLEND Or AW_HIDE)
    End Sub

    Private Sub btnSelFav_Click(sender As Object, e As EventArgs) Handles btnSelFav.Click
        If VerificarFav() Then
            Me.Close()
            Return
        End If
        botonesInfo.Clear()
        LimpiarPanelFavoritos()
        UsuariosSP.FavoritosDel(CodUsu)
        If ckbCli.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Clientes", My.Resources.icons8_clientes_50))
            CodForm = 1
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbVent.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Ventas", My.Resources.icons8_ventas_azul_50))
            CodForm = 2
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbDV.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Det. Ventas", My.Resources.icons8_ventas_50__1_))
            CodForm = 3
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbProv.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Proveedores", My.Resources.icons8_building_with_rooftop_terrace_50))
            CodForm = 4
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbServ.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Servicios", My.Resources.icons8_parque_nacional_501))
            CodForm = 5
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbOp.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Operaciones", My.Resources.icons8_waypoint_map_50))
            CodForm = 6
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbChoferes.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Choferes", My.Resources.icons8_taxi_driver_50))
            CodForm = 7
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbVeh.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Vehículos", My.Resources.icons8_auto_50))
            CodForm = 8
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbEmp.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Empleados", My.Resources.icons8_empleados_50))
            CodForm = 9
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If ckbUsu.Checked Then
            botonesInfo.Add(New Tuple(Of String, Image)("Usuarios", My.Resources.icons8_usuario_50))
            CodForm = 10
            UsuariosSP.FavoritosModIns(CodUsu, CodForm)
        End If
        If AreAllCheckboxesUnchecked(Panel1) Then
            Me.Close()
            Return
        End If
        Dim fontPath As String = Path.Combine(Application.StartupPath, "Fonts", "Merriweather-Bold.ttf")
        ' Cargar la fuente en la colección privada
        frmMenu.privateFonts.AddFontFile(fontPath)
        ' Asignar la fuente personalizada a un control
        Dim miFuentePersonalizadacc As New Font(frmMenu.privateFonts.Families(0), 8.0F)
        For Each info In botonesInfo
            ' Verificar si se ha alcanzado el número máximo de botones
            If frmMenu.pnlFavoritos.Controls.Count >= BotonesPorFila * MaxFilas Then
                MessageBox.Show("Se ha alcanzado el número máximo de botones permitidos.")
                Exit For
            End If
            Dim newButton As New Button()
            newButton.Text = info.Item1
            newButton.ForeColor = Color.FromArgb(30, 63, 111)
            newButton.FlatStyle = FlatStyle.Flat
            newButton.FlatAppearance.BorderSize = 0
            newButton.Font = miFuentePersonalizadacc
            newButton.TextAlign = ContentAlignment.BottomCenter
            newButton.ImageAlign = ContentAlignment.TopCenter
            newButton.Image = info.Item2
            ' Configurar propiedades del botón (tamaño, ubicación, etc.)
            newButton.Size = New Size(BotonAncho, BotonAlto)
            ' Calcular la ubicación del nuevo botón
            Dim index As Integer = frmMenu.pnlFavoritos.Controls.Count
            Dim row As Integer = index \ BotonesPorFila
            Dim col As Integer = index Mod BotonesPorFila
            Dim x As Integer = Margen + col * (BotonAncho + Espacio)
            Dim y As Integer = Margen + row * (BotonAlto + Espacio)
            newButton.Location = New Point(x, y)
            AddHandler newButton.Click, AddressOf frmMenu.DynamicButton_Click
            ' Agregar el botón al Panel
            frmMenu.pnlFavoritos.Controls.Add(newButton)
        Next
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        MinimizarMini(Me)
    End Sub
#Region "Color y Arrastrar"
    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        MoverFrm(pnlMnuTool, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        MoverFrm(PictureBox2, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        MoverFrm(tsslNomUsu, e)
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub frmFav_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
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

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        ColorMax(pnlMnuTool, PictureBox2, btnMini, btnExit)
    End Sub
#End Region

#End Region

End Class