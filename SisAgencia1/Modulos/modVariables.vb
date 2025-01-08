#Region "Imports"
Imports System.Drawing.Imaging
Imports System.Net.Http
Imports System.Net.NetworkInformation
Imports System.Net.Security
Imports System.Runtime.InteropServices
Imports System.Windows.Documents
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports Datos
Imports Entidades
#End Region

Module modVariables

#Region "Declaraciones"
    Public CodMonedaGlobal As Integer = 0
    Public CodMedPagoGlobal As Integer = 0
    Public CodTransGlobal As String = ""
    Public VenderConVenCliAbierto As Boolean = False
    Public VendesdeVent As Boolean = False
    Public Euro As Double
    Public Dolar As Double
    Public Real As Double
    Public CorreoCli As String
    Public AgrSimulacion As Boolean = False 'PARA INICIAR LA SIMULACION DE VENTA EN EL MENU PRINCIPAL EN VEZ DE ESPERAR UNA VENTA REAL
    Public NomEmp As String
    Public CodEmpCreUsu As String 'para crear usuario
    Public NomEmpCreUsu As String ''
    Public ApeEmpCreUsu As String ''
    Public NomCli As String
    Public ApeCli As String
    Public ApeEmp As String
    Public NomUsu As String
    Public NomUsuCamCon As String ' para cambiar contraseña
    Public CodUsu As Integer
    Public CodTpUsu As Integer
    Public PasUsu As String
    Public titulo As String = "Conquista tu Mundo" 'se usaba para las notificaciones de windows, creo que ya no tiene funcion
    Public banbl As Boolean 'bandera para detectar si es pantalla completa?
    Public UsuExiste As Boolean = False
    Public dnibus As Integer
    Public CodProvSelProv As Integer = 0
    Public RazonSocialSelProv As String
    Public textosincoma As String
    Public CodChofAgrVeh As Integer 'creo que es al insertar veh desde el frm veh o chof, pero no en selveh para el frmop
    Public NomApeChofAgrVeh As String 'creo que es al insertar veh desde el frm veh o chof, pero no en selveh para el frmop
    'Public CodProvAgrServ As Integer
    Public ServdesdeProv As Boolean = False
    Public VehdesdeChof As Boolean = False
    Public DetVentdesdeVent As Boolean = False
    Public NomApeClienteVen As String
    Public CodCliVender As Integer
    Public CodVender As Integer 'Es el codigo que genera la venta al vender en frmVender
    Public CodDetVender As Integer
    Public CodVentaMod As Integer 'Codigo usado para llevar una venta a modificar detventa directo
    Public NomApeClienteDetVent As String
    Public CodVentBus As Integer
    Public CodServSelServ As Integer
    Public CodDetVentSel As Integer 'Para el selDetVent
    Public NomServSelDetVent As String 'Para el selDetVent
    Public NomServSelServ As String
    Public SelVentdesdeBtnEle As Boolean = False
    Public CodVehSelVeh As Integer 'para el frmselveh para el frmop
    Public CodChofSelVeh As Integer 'para el frmselveh para el frmop
    Public NomVehSelVeh As String 'para el frmselveh para el frmop
    Public NomApeChofSelVeh As String 'para el frmselveh para el frmop
    Public MotivoDeshabilitar As String = "" 'aca se guarda el motivo por el cual se deshabilita
    Public VarADMIN As Integer = 0 'verifica que formulario fue el que abrio el panel de permiso de admin
    '0 = ninguno, error
    'cancelar
    '1= choferes
    '2= operaciones
    '3= vehiculos
    '4= proveedores
    '5= servicios
    '6= empleados
    '7= usuarios
    '8= clientes
    '9= detventas
    '10= ventas
    'modificar
    '11= choferes
    '12= operaciones
    '13= vehiculos
    '14= proveedores
    '15= servicios
    '16= empleados
    '17= usuarios
    '18= clientes
    '19= detventas
    '20= ventas
    Public PermisoADMIN As Boolean = False 'verifica para eliminar o restaurar si se recibio permiso del admin.
    Public NomApeCliAgrVent As String = "" 'Agarra el nombre del cliente al apretar el boton vender desde el menú, abre el seleccionar cliente y para eso.
    Public CodCliAgrVent As Integer = 0 'Para lo mismo de arriba pero con el codigo. AL FINAL NO FUERON USADOS LOS DOS, YA QUE HABIA UNOS IGUALES, NO BORRO POR LAS DUDAS, PERO NO CREO QUE TENGAN USO.
    Public botonesInfo As New List(Of Tuple(Of String, Image))() 'para el boton favoritos
    Public elprogramadebecerrarse As Boolean = False 'cuando el programa no se debe abrir debido a que la resolucion es muy  baja
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Boolean, ByVal lParam As Integer) As IntPtr
    Public Const WM_SETREDRAW As Integer = &HB
    Public formulariosAbiertos As New Stack(Of Form)
    Public UltimosFormularios As New List(Of String)
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public Const WM_MOUSEACTIVATE As Integer = &H21
    Public Const WM_NCACTIVATE As Integer = &H86
    Public Const AW_BLEND As Integer = &H80000 ' Efecto de desvanecimiento
    Public Const AW_HIDE As Integer = &H10000 ' Ocultar ventana
    Public Const AW_VER_POSITIVE As Integer = &H4  ' deslizar arriba abajo
    Public Const AW_VER_NEGATIVE As Integer = &H8  'deslizar abajo arriba
    Public Const AW_HOR_POSITIVE As Integer = &H1 ' Deslizar de izquierda a derecha
    Public Const AW_HOR_NEGATIVE As Integer = &H2 ' Deslizar de derecha a izquierda
    Public Const AW_SLIDE As Integer = &H40000 ' Efecto de deslizar
    Public Const CS_DROPSHADOW As Integer = &H20000
    Public TelClienteVen As String
    Public DNIClienteVen As Integer
#End Region

#Region "Sub Simple"
    'Public Sub CargaMin()
    '    frmVisorReportes.WindowState = FormWindowState.Normal
    '    frmPrincipal.AbrirFormulario2(frmVisorReportes)
    '    Threading.Thread.Sleep(5000)
    '    frmVisorReportes.HideWithAnimation()
    'End Sub

    'Public Sub CargaMinPanel(p As Panel)
    '    frmVisorReportes.WindowState = FormWindowState.Normal
    '    AbrirFormPanel(frmVisorReportes, p)
    '    Threading.Thread.Sleep(10000)
    '    frmVisorReportes.HideWithAnimation()
    'End Sub

    'Public Sub CargaMax()
    '    frmVisorReportes.WindowState = FormWindowState.Maximized
    '    frmPrincipal.AbrirFormulario2(frmVisorReportes)
    '    Threading.Thread.Sleep(10000)
    '    frmVisorReportes.HideWithAnimation()
    'End Sub
    Public Sub OcultarTodo()
        OcultarVenCli()
        OcultarEmpUsu()
        OcultarServProv()
        OcultarOpChofVeh()
    End Sub

    Public Sub OcultarFecha(pnl As Panel, btn As Button)
        MinimizarPanel(pnl)
        btn.Image = My.Resources.icons8_chevron_abajo_en_círculo_24
    End Sub


    Public Sub OcultarTodoMenosPnlPpal()
        MinimizarPanel(frmAgrVent.pnlAgrSer)
        OcultarFecha(frmVentas.pnlBusxFecha, frmVentas.btnBusxFecha)
        OcultarFecha(frmDetVentas.pnlBusxFecha, frmDetVentas.btnBusxFecha)
        OcultarFecha(frmClientes.pnlBusxFecha, frmClientes.btnBusxFecha)
        MinimizarPanel(frmVentas.pnlDespDGV)
        MinimizarPanel(frmDetVentas.pnlDespDGV)
        MinimizarPanel(frmClientes.pnlDespDGV)
        OcultarFecha(frmEmpleados.pnlBusxFecha, frmEmpleados.btnBusxFecha)
        OcultarFecha(frmUsuarios.pnlBusxFecha, frmUsuarios.btnBusxFecha)
        MinimizarPanel(frmEmpleados.pnlDespDGV)
        MinimizarPanel(frmUsuarios.pnlDespDGV)
        OcultarFecha(frmServ.pnlBusxFecha, frmServ.btnBusxFecha)
        OcultarFecha(frmProv.pnlBusxFecha, frmProv.btnBusxFecha)
        MinimizarPanel(frmServ.pnlDespDGV)
        MinimizarPanel(frmProv.pnlDespDGV)
        OcultarFecha(frmOp.pnlBusxFecha, frmOp.btnBusxFecha)
        OcultarFecha(frmChof.pnlBusxFecha, frmChof.btnBusxFecha)
        OcultarFecha(frmVeh.pnlBusxFecha, frmVeh.btnBusxFecha)
        MinimizarPanel(frmOp.pnlDespDGV)
        MinimizarPanel(frmChof.pnlDespDGV)
        MinimizarPanel(frmVeh.pnlDespDGV)
        MinimizarPanel(frmMenu.pnlOpSemanales)
    End Sub

    Public Sub OcultarVenCli()
        MinimizarPanel(frmAgrVent.pnlAgrSer)
        MinimizarPanel(frmPrincipal.pnlMnuDesp)
        OcultarFecha(frmVentas.pnlBusxFecha, frmVentas.btnBusxFecha)
        OcultarFecha(frmDetVentas.pnlBusxFecha, frmDetVentas.btnBusxFecha)
        OcultarFecha(frmClientes.pnlBusxFecha, frmClientes.btnBusxFecha)
        MinimizarPanel(frmVentas.pnlDespDGV)
        MinimizarPanel(frmDetVentas.pnlDespDGV)
        MinimizarPanel(frmClientes.pnlDespDGV)
    End Sub

    Public Sub OcultarEmpUsu()
        MinimizarPanel(frmPrincipal.pnlMnuDesp)
        OcultarFecha(frmEmpleados.pnlBusxFecha, frmEmpleados.btnBusxFecha)
        OcultarFecha(frmUsuarios.pnlBusxFecha, frmUsuarios.btnBusxFecha)
        MinimizarPanel(frmEmpleados.pnlDespDGV)
        MinimizarPanel(frmUsuarios.pnlDespDGV)
    End Sub

    Public Sub OcultarServProv()
        MinimizarPanel(frmPrincipal.pnlMnuDesp)
        OcultarFecha(frmServ.pnlBusxFecha, frmServ.btnBusxFecha)
        OcultarFecha(frmProv.pnlBusxFecha, frmProv.btnBusxFecha)
        MinimizarPanel(frmServ.pnlDespDGV)
        MinimizarPanel(frmProv.pnlDespDGV)
    End Sub

    Public Sub OcultarOpChofVeh()
        MinimizarPanel(frmPrincipal.pnlMnuDesp)
        OcultarFecha(frmOp.pnlBusxFecha, frmOp.btnBusxFecha)
        OcultarFecha(frmChof.pnlBusxFecha, frmChof.btnBusxFecha)
        OcultarFecha(frmVeh.pnlBusxFecha, frmVeh.btnBusxFecha)
        MinimizarPanel(frmOp.pnlDespDGV)
        MinimizarPanel(frmChof.pnlDespDGV)
        MinimizarPanel(frmVeh.pnlDespDGV)
    End Sub

    Public Sub OcultarPanel()
        frmPrincipal.pnlMnuDesp.Visible = False
    End Sub

    Public Sub MinimizarPanel(ctr As Control)
        ctr.Visible = False
    End Sub

    Public Sub VerPanel(ctr As Control)
        ctr.Visible = True
    End Sub

    Public Sub ControlFalse(ctr As Control)
        ctr.Enabled = False
    End Sub

    Public Sub ControlTrue(ctr As Control)
        ctr.Enabled = True
    End Sub

    Public Sub Maximizar(f As Form)
        f.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub Minimizar(f As Form)
        f.WindowState = FormWindowState.Normal
    End Sub

    Public Sub MinimizarMini(f As Form)
        f.WindowState = FormWindowState.Minimized
    End Sub

    Public Sub ClearText(text As TextBox)
        text.Text = ""
    End Sub

    Public Sub ClearString(ByRef text As String)
        text = ""
    End Sub

    Public Sub ClearDouble(ByRef text As Double)
        text = 0
    End Sub

    Public Sub ClearInt(ByRef text As Integer)
        text = 0
    End Sub

    Public Sub OpacidadNo(f As Form)

        If f IsNot Nothing Then
            f.Opacity = 0
        End If
    End Sub

    Public Sub OpacidadSi(f As Form)
        If f IsNot Nothing Then
            f.Opacity = 1
        End If

    End Sub

    Public Sub MiniFrmChof(dgv As DataGridView, pb As PictureBox, p As Point)
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        pb.Location = New Point(p)
        dgv.AllowUserToResizeColumns = True
    End Sub

    Public Sub MiniFrmIntermedio(dgv As DataGridView, pb As PictureBox, p As Point)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        pb.Location = New Point(p)
        dgv.AllowUserToResizeColumns = True
    End Sub

    Public Sub MiniFrmOp(dgv As DataGridView, pb As PictureBox, p As Point)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        pb.Location = New Point(p)
        dgv.AllowUserToResizeColumns = True
    End Sub

    Public Sub MiniFrmInterExtra(dgv As DataGridView)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.AllowUserToResizeColumns = True
    End Sub

    Public Sub ComboSelIdx(cb As ComboBox)
        cb.SelectedIndex = 0
    End Sub

    Public Sub ColorMax(pnl As Panel, pb As PictureBox, btm As Button, bte As Button)
        pnl.BackColor = Color.FromArgb(30, 63, 111)
        pb.BackColor = Color.FromArgb(30, 63, 111)
        btm.BackColor = Color.FromArgb(30, 63, 111)
        bte.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Public Sub ColorMax1b(pnl As Panel, pb As PictureBox, bte As Button)
        pnl.BackColor = Color.FromArgb(30, 63, 111)
        pb.BackColor = Color.FromArgb(30, 63, 111)
        bte.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Public Sub ColorMin(pnl As Panel, pb As PictureBox)
        pnl.BackColor = Color.FromArgb(30, 63, 111)
        pb.BackColor = Color.FromArgb(30, 63, 111)
    End Sub

    Public Sub ColorParpadeo(pnl As Panel, pb As PictureBox, btm As Button, bte As Button)
        pnl.BackColor = Color.FromArgb(43, 88, 157)
        pb.BackColor = Color.FromArgb(43, 88, 157)
        btm.BackColor = Color.FromArgb(43, 88, 157)
        bte.BackColor = Color.FromArgb(43, 88, 157)
    End Sub

    Public Function AreAllCheckboxesUnchecked(container As Control) As Boolean
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function
#End Region

#Region "Subrutina"
    Public Sub TamañoPantalla(ByRef tamaño As Size, ByRef mini As Point, ByRef full As Point, ByRef miniinicio As Point) 'verifica tamaño screen y cambia tam y posicion de ctrls
        Dim Pantalla As Size = Screen.PrimaryScreen.Bounds.Size
        Select Case Pantalla
            Case New Size(1920, 1080) 'no falla (casi imperceptible)
                tamaño = New Size(225, 149)
                mini = New Point(25, 65)
                full = New Point(24, 107)
                miniinicio = New Point(24, 190)
            Case New Size(1768, 992) 'falla ligeramente
                tamaño = New Size(210, 140)
                mini = New Point(30, 65)
                miniinicio = New Point(30, 155)
                full = New Point(25, 100)
            Case New Size(1680, 1050) 'falla alta, no maxi mejor
                tamaño = New Size(205, 135)
                mini = New Point(30, 70)
                full = New Point(30, 120)
                miniinicio = New Point(25, 170)
            Case New Size(1600, 1024) 'falla maxi 'Para arreglar todos habría que agregar otra categoria llamada fullinicio, pero no será necesario de momento
                tamaño = New Size(185, 125)
                mini = New Point(40, 50)
                full = New Point(40, 120)
                miniinicio = New Point(40, 120)
            Case New Size(1600, 900) 'falla maxi 'la categoria fullinicio reemplaria a full y se deberia calcular donde iria la full normal, no se por que anda tan como el
                tamaño = New Size(180, 120)
                mini = New Point(45, 75)
                full = New Point(45, 90)
                miniinicio = New Point(45, 120)
            Case New Size(1440, 1080)
                tamaño = New Size(180, 120) 'falla maxi 'no le veo sentido que vaya cambiando de lugar sin sentido
                mini = New Point(45, 75)
                full = New Point(40, 130)
                miniinicio = New Point(45, 190)
            Case New Size(1440, 900) 'falla maxi medio
                tamaño = New Size(180, 120)
                mini = New Point(45, 70)
                full = New Point(45, 70)
                miniinicio = New Point(45, 120)
            Case New Size(1366, 768) 'no falla
                tamaño = New Size(150, 90)
                mini = New Point(0, 0)
                miniinicio = New Point(0, 0)
                full = New Point(60, 85)
            Case Else 'no deberia usarse en otra resolucion, funciona mejor en maxima o minima, el resto medio medio
                tamaño = New Size(0, 0)
                mini = New Point(0, 0)
                full = New Point(0, 0)
        End Select
    End Sub

    Public Sub TamañoPantallaFull(ByRef full As Point) 'para definir el tamaño de pantalla max en frm de seleccion opchofveh, etc
        Dim Pantalla As Size = Screen.PrimaryScreen.Bounds.Size
        Select Case Pantalla
            Case New Size(1920, 1080)
                full = New Point(24, 107)
            Case New Size(1768, 992)
                full = New Point(25, 115)
            Case New Size(1680, 1600)
                full = New Point(35, 140)
            Case New Size(1600, 1024)
                full = New Point(50, 150)
            Case New Size(1600, 900)
                full = New Point(45, 120)
            Case New Size(1440, 1080)
                full = New Point(60, 150)
            Case New Size(1440, 900)
                full = New Point(60, 130)
            Case New Size(1366, 768)
                full = New Point(60, 110)
            Case Else
                full = New Point(0, 0)
        End Select
    End Sub

    Public Sub SetDoubleBuffered(ByVal control As Control)
        ' Verifica si el control soporta doble buffer
        Dim controlType As Type = control.GetType()
        Dim pi As Reflection.PropertyInfo = controlType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If pi IsNot Nothing Then
            pi.SetValue(control, True, Nothing)
        End If
    End Sub

    ' Función para suspender el redibujado de un control
    Public Sub SuspendDrawing(ByVal control As Control)
        ' Envía un mensaje para suspender el redibujado del control
        SendMessage(control.Handle, WM_SETREDRAW, False, 0)
    End Sub

    ' Función para reanudar el redibujado de un control
    Public Sub ResumeDrawing(ByVal control As Control)
        ' Envía un mensaje para reanudar el redibujado del control
        SendMessage(control.Handle, WM_SETREDRAW, True, 0)
        control.Refresh() ' Refresca el control para que se actualice con el nuevo contenido
    End Sub

    Public Sub MensajeNotificacion(mensaje As String, cabeza As String)
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmNoti Then
                frm.Close() ' cerrar la noti abierta asi no se tarda en salir otra
                Exit For
            End If
        Next
        If frmNoti.txtNotiCabeza IsNot Nothing Then
            frmNoti.txtNotiCabeza.Text = cabeza
        End If
        If frmNoti.txtNotiCuerpo IsNot Nothing Then
            frmNoti.txtNotiCuerpo.Text = mensaje
        End If
        If frmNoti IsNot Nothing Then

            frmNoti.Show()
        End If
    End Sub
#End Region

#Region "Fechas"
    Public Sub FechasCmb(cmbanho As ComboBox, cmbmes As ComboBox, cmbdia As ComboBox) ' para el combo fecha de ventas, para año bisiesto y eso
        If cmbanho.SelectedIndex = 0 Or cmbmes.SelectedIndex = 0 Then
            Return
        End If
        Dim anho As Integer = CInt(cmbanho.SelectedItem)
        Dim mes As Integer = CInt(cmbmes.SelectedItem)
        ' es bisiesto??
        Dim esBisiesto As Boolean = (anho Mod 4 = 0 And anho Mod 100 <> 0) Or (anho Mod 400 = 0)
        ' dias depende del mes y año bi
        Dim diasEnMes As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                diasEnMes = 31
            Case 4, 6, 9, 11
                diasEnMes = 30
            Case 2
                If esBisiesto Then
                    diasEnMes = 29
                Else
                    diasEnMes = 28
                End If
        End Select
        ' actualizar cmb
        cmbdia.Items.Clear()
        cmbdia.Items.Add("--") ' default
        For i As Integer = 1 To diasEnMes
            cmbdia.Items.Add(i.ToString())
        Next
        cmbdia.SelectedIndex = 0 ' seleccion default
    End Sub

    Public Sub FechasCmbSinDia(cmbanho As ComboBox, cmbmes As ComboBox, cmbanhoH As ComboBox, cmbmesH As ComboBox, ByRef desde As String, ByRef hasta As String) ' cuando no hay dias en los desdehasta
        Dim anho As Integer = CInt(cmbanhoH.SelectedItem)
        Dim mes As Integer = CInt(cmbmesH.SelectedItem)
        Dim esBisiesto As Boolean = (anho Mod 4 = 0 And anho Mod 100 <> 0) Or (anho Mod 400 = 0)
        Dim diasEnMes As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                diasEnMes = 31
            Case 4, 6, 9, 11
                diasEnMes = 30
            Case 2
                If esBisiesto Then
                    diasEnMes = 29
                Else
                    diasEnMes = 28
                End If
        End Select
        desde = "01" & "/" & cmbmes.SelectedItem & "/" & cmbanho.SelectedItem
        hasta = diasEnMes & "/" & cmbmesH.SelectedItem & "/" & cmbanhoH.SelectedItem
    End Sub

    Public Sub FechasCmbConDiaenD(cmbanhoH As ComboBox, cmbmesH As ComboBox, ByRef hasta As String) 'hay dia en desde nomas
        Dim anho As Integer = CInt(cmbanhoH.SelectedItem)
        Dim mes As Integer = CInt(cmbmesH.SelectedItem)
        Dim esBisiesto As Boolean = (anho Mod 4 = 0 And anho Mod 100 <> 0) Or (anho Mod 400 = 0)
        Dim diasEnMes As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                diasEnMes = 31
            Case 4, 6, 9, 11
                diasEnMes = 30
            Case 2
                If esBisiesto Then
                    diasEnMes = 29
                Else
                    diasEnMes = 28
                End If
        End Select
        hasta = diasEnMes & "/" & cmbmesH.SelectedItem & "/" & cmbanhoH.SelectedItem
    End Sub


    Public Sub FechasCmbConDiaenH(cmbanho As ComboBox, cmbmes As ComboBox, ByRef desde As String) 'dia en hasta nomas
        desde = "01" & "/" & cmbmes.SelectedItem & "/" & cmbanho.SelectedItem
    End Sub

    Public Sub FechasCmbSinDiaDesde(cmbanho As ComboBox, cmbmes As ComboBox, ByRef desde As String, ByRef hasta As String) 'sin dia, solo mes
        Dim anho As Integer = CInt(cmbanho.SelectedItem)
        Dim mes As Integer = CInt(cmbmes.SelectedItem)
        Dim esBisiesto As Boolean = (anho Mod 4 = 0 And anho Mod 100 <> 0) Or (anho Mod 400 = 0)
        Dim diasEnMes As Integer
        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                diasEnMes = 31
            Case 4, 6, 9, 11
                diasEnMes = 30
            Case 2
                If esBisiesto Then
                    diasEnMes = 29
                Else
                    diasEnMes = 28
                End If
        End Select
        desde = "01" & "/" & cmbmes.SelectedItem & "/" & cmbanho.SelectedItem
        hasta = diasEnMes & "/" & cmbmes.SelectedItem & "/" & cmbanho.SelectedItem
    End Sub
#End Region

#Region "Formularios"
    ' Método para actualizar la lista de últimos formularios visitados
    Public Sub ActualizarUltimosFormularios(nombreFormulario As String)
        If UltimosFormularios.Contains(nombreFormulario) Then
            UltimosFormularios.Remove(nombreFormulario)
        End If
        UltimosFormularios.Insert(0, nombreFormulario)
        ' Mantener solo los últimos 4 formularios visitados
        If UltimosFormularios.Count > 4 Then
            UltimosFormularios.RemoveAt(UltimosFormularios.Count - 1)
        End If
        CambiarBtnATick(nombreFormulario)
        ' Actualizar los botones en el panel
    End Sub

    Public Sub AbrirFormPanel(f As Form, p As Panel)
        'Limpio los controles existentes en el panel
        'p.Controls.Clear()
        'Establezco la propiedad toplevel del formualrio en falso para poder agregar un formulario dentro de otro
        If f IsNot Nothing Then
            If p IsNot Nothing Then
                f.TopLevel = False
                'Quito los bordes del formulario a abrir dentro del panel
                f.FormBorderStyle = FormBorderStyle.None
                'Agrego el control al panel
                p.Controls.Add(f)
                'Muestro el formulario en pantalla

                f.Show()
                f.BringToFront()
                f.Dock = DockStyle.Fill
            End If
        End If
    End Sub

    'Public Sub CerrarUltimoFormulario()
    '    ' Verificar si la lista no está vacía
    '    If UltimosFormularios.Count > 0 Then
    '        ' Obtener el nombre del último formulario abierto
    '        Dim nombreUltimoFormulario As String = UltimosFormularios(0)
    '        ' Buscar el formulario correspondiente utilizando su nombre
    '        Dim ultimoFormularioAbierto As Form = Application.OpenForms(nombreUltimoFormulario)
    '        If nombreUltimoFormulario = "frmEmpUsu" Or nombreUltimoFormulario = "frmVenCli" Or nombreUltimoFormulario = "frmServProv" Or nombreUltimoFormulario = "frmOpChofVeh" Then
    '            ultimoFormularioAbierto.Close()
    '            frmPrincipal.AbrirFormulario(frmMenu)
    '            frmMenu.OpSemanales()
    '            frmPrincipal.btnVolver.Visible = False
    '            frmPrincipal.btnInicio2.Visible = False
    '        Else
    '            ' Verificar si se encontró el formulario
    '            If ultimoFormularioAbierto IsNot Nothing Then
    '                ' Cerrar el formulario encontrado
    '                ultimoFormularioAbierto.Close()
    '                ' Actualizar la lista eliminando el último formulario cerrado
    '                UltimosFormularios.RemoveAt(0)
    '            End If
    '        End If
    '        ' Actualizar los botones en el panel
    '    End If
    'End Sub

    Public Sub CambiarBtnADefault(nomfrm As String)
        Select Case nomfrm
            Case "frmOp"
                frmOpChofVeh.btnOp.Image = My.Resources.icons8_ruta_24
            Case "frmChof"
                frmOpChofVeh.btnChof.Image = My.Resources.icons8_conductor_de_taxi_24
            Case "frmVeh"
                frmOpChofVeh.btnVeh.Image = My.Resources.icons8_auto_242
            Case "frmServ"
                frmServProv.btnServ.Image = My.Resources.icons8_parque_nacional_241
            Case "frmProv"
                frmServProv.btnProv.Image = My.Resources.icons8_edificio_24
            Case "frmUsuarios"
                frmEmpUsu.btnUsu.Image = My.Resources.icons8_usuario_24
            Case "frmEmpleados"
                frmEmpUsu.btnEmp.Image = My.Resources.icons8_empleado_24
            Case "frmClientes"
                frmVenCli.btnCliV.Image = My.Resources.icons8_cliente_241
            Case "frmDetVentas"
                frmVenCli.btnDetVent.Image = My.Resources.icons8_carrito_de_compras_243
            Case "frmVentas"
                frmVenCli.btnVenV.Image = My.Resources.icons8_ventas_241
            Case "frmAgrVent"
                frmVenCli.btnVender.Image = My.Resources.icons8_agregar_a_carrito_de_compras_24
        End Select
    End Sub

    Public Sub CambiarBtnATick(nomfrm As String)
        Select Case nomfrm
            Case "frmOp"
                frmOpChofVeh.btnOp.Image = My.Resources.OperacionTick
            Case "frmChof"
                frmOpChofVeh.btnChof.Image = My.Resources.ChoferTick
            Case "frmVeh"
                frmOpChofVeh.btnVeh.Image = My.Resources.VehiculoTick
            Case "frmServ"
                frmServProv.btnServ.Image = My.Resources.ServicioTick
            Case "frmProv"
                frmServProv.btnProv.Image = My.Resources.ProveedorTick
            Case "frmUsuarios"
                frmEmpUsu.btnUsu.Image = My.Resources.UsuarioTick
            Case "frmEmpleados"
                frmEmpUsu.btnEmp.Image = My.Resources.EmpleadoTick
            Case "frmClientes"
                frmVenCli.btnCliV.Image = My.Resources.ClienteTick
            Case "frmDetVentas"
                frmVenCli.btnDetVent.Image = My.Resources.DetalleVentaTick
            Case "frmVentas"
                frmVenCli.btnVenV.Image = My.Resources.VentaTick
            Case "frmAgrVent"
                frmVenCli.btnVender.Image = My.Resources.VenderTick
        End Select
    End Sub

    Public Sub CerrarUltimoFormulario()
        ' Verificar si la lista no está vacía
        If UltimosFormularios.Count > 0 Then
            ' Obtener el nombre del último formulario abierto
            Dim nombreUltimoFormulario As String = UltimosFormularios(0)
            ' Buscar el formulario correspondiente utilizando su nombre
            Dim ultimoFormularioAbierto As Form = Application.OpenForms(nombreUltimoFormulario)


            If nombreUltimoFormulario = "frmAgrVent" Then
                If frmAgrVent.Findeventa = True Then
                Else
                    Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir sin terminar la venta?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If respuesta = DialogResult.Yes Then
                        AgrSimulacion = False
                    Else
                        Return
                    End If
                End If
            End If

            If nombreUltimoFormulario = "frmEmpUsu" Or nombreUltimoFormulario = "frmVenCli" Or nombreUltimoFormulario = "frmServProv" Or nombreUltimoFormulario = "frmOpChofVeh" Then
                ultimoFormularioAbierto.Close()
                frmPrincipal.AbrirFormulario(frmMenu)
                frmMenu.OpSemanales()
                frmPrincipal.btnVolver.Visible = False
                frmPrincipal.btnInicio2.Visible = False
            Else
                ' Verificar si se encontró el formulario
                If ultimoFormularioAbierto IsNot Nothing Then
                    ' Cerrar el formulario encontrado
                    ultimoFormularioAbierto.Close()

                    If nombreUltimoFormulario = "frmDetVentas" Then
                        MinimizarPanel(frmVenCli.btnDetVent)
                    End If

                    ' Actualizar la lista eliminando el último formulario cerrado
                    UltimosFormularios.RemoveAt(0)
                End If
            End If

            CambiarBtnADefault(nombreUltimoFormulario)

            ' Verificar el nuevo formulario que queda activo después de cerrar el último
            If UltimosFormularios.Count > 0 Then
                ' Obtener el nombre del formulario que ahora está al frente
                Dim nombreFormularioActual As String = UltimosFormularios(0)
                Dim formularioActual As Form = Application.OpenForms(nombreFormularioActual)

                ' Llamar a la función para iluminar el botón correspondiente
                If formularioActual IsNot Nothing Then
                    Select Case nombreFormularioActual
                        Case "frmOp"
                            frmPrincipal.IluminarBoton(frmOpChofVeh.btnOp)
                        Case "frmChof"
                            frmPrincipal.IluminarBoton(frmOpChofVeh.btnChof)
                        Case "frmVeh"
                            frmPrincipal.IluminarBoton(frmOpChofVeh.btnVeh)
                        Case "frmServ"
                            frmPrincipal.IluminarBoton(frmServProv.btnServ)
                        Case "frmProv"
                            frmPrincipal.IluminarBoton(frmServProv.btnProv)
                        Case "frmUsuarios"
                            frmPrincipal.IluminarBoton(frmEmpUsu.btnUsu)
                        Case "frmEmpleados"
                            frmPrincipal.IluminarBoton(frmEmpUsu.btnEmp)
                        Case "frmClientes"
                            frmPrincipal.IluminarBoton(frmVenCli.btnCliV)
                        Case "frmDetVentas"
                            frmPrincipal.IluminarBoton(frmVenCli.btnDetVent)
                        Case "frmVentas"
                            frmPrincipal.IluminarBoton(frmVenCli.btnVenV)
                        Case "frmAgrVent"
                            frmPrincipal.IluminarBoton(frmVenCli.btnVender)
                    End Select
                End If
            End If
        End If
    End Sub

    Public Sub CentrarForm(form As Form)
        Dim xPos As Integer = (Screen.PrimaryScreen.Bounds.Width - form.Width) \ 2
        Dim yPos As Integer = (Screen.PrimaryScreen.Bounds.Height - form.Height) \ 2
        form.Location = New Point(xPos, yPos)
    End Sub

    Public Sub NotiPosicionForm(form As Form)
        Dim offsetX As Integer = 10 ' Ajusta este valor para mover hacia la izquierda
        Dim offsetY As Integer = 40 ' Ajusta este valor para mover hacia arriba
        Dim xPos As Integer = Screen.PrimaryScreen.Bounds.Width - form.Width - offsetX
        Dim yPos As Integer = Screen.PrimaryScreen.Bounds.Height - form.Height - offsetY
        form.Location = New Point(xPos, yPos)
    End Sub

    Public Sub CerrarFormularios(formularios As Form())
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub
#End Region

#Region "Texto y números"
    Public Sub KeyPressCon(sender As Object, e As KeyPressEventArgs)
        ' Verifica si el carácter presionado es un carácter prohibido
        If Char.IsLetter(e.KeyChar) Then
            ' Verifica si el carácter tiene tilde
            If e.KeyChar = "á" Or e.KeyChar = "é" Or e.KeyChar = "í" Or e.KeyChar = "ó" Or e.KeyChar = "ú" Or
           e.KeyChar = "Á" Or e.KeyChar = "É" Or e.KeyChar = "Í" Or e.KeyChar = "Ó" Or e.KeyChar = "Ú" Then
                ' Si el carácter tiene tilde, lo ignoramos
                e.Handled = True
            End If
        ElseIf Char.IsDigit(e.KeyChar) Then
            ' Si es un número, permitimos su ingreso
        ElseIf Char.IsControl(e.KeyChar) Then
            ' Si es una tecla de control (por ejemplo, retroceso), permitimos su ingreso
        Else
            ' Si no es una letra ni un número ni una tecla de control, lo prohibimos
            e.Handled = True
        End If
    End Sub

    Public Sub TextChangedCon(txt As TextBox, sender As Object, e As EventArgs)
        Dim textoValido As String = ""
        For Each c As Char In txt.Text
            If Char.IsLetter(c) Then
                ' Verifica si el carácter tiene tilde
                If c = "á" Or c = "é" Or c = "í" Or c = "ó" Or c = "ú" Or
               c = "Á" Or c = "É" Or c = "Í" Or c = "Ó" Or c = "Ú" Then
                    ' Si el carácter tiene tilde, lo ignoramos
                    Continue For
                End If
            End If
            If Char.IsLetterOrDigit(c) Or Char.IsControl(c) Then
                ' Permitir letras, números y teclas de control
                textoValido &= c
            End If
        Next
        txt.Text = textoValido
        ' Posicionar el cursor al final del texto
        txt.SelectionStart = txt.Text.Length
    End Sub

    Public Sub SoloInt(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub FiltrarNoInt(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Elimina cualquier carácter no numérico ni alfabético del texto
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsLetterOrDigit(c) Then
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub SoloIntDNI(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada es válida (letra, dígito, guión, espacio o BackSpace)
            If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso
           Not e.KeyChar = "-"c AndAlso
           Not e.KeyChar = " "c AndAlso
           Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es válida, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub FiltrarNoIntDNI(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Elimina cualquier carácter que no sea válido (letras, dígitos, guiones, espacios)
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsLetterOrDigit(c) OrElse c = "-"c OrElse c = " "c Then
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub SoloIntString(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito, ni una letra, ni la tecla BackSpace
            If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito, ni una letra, ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub



    Public Sub FiltrarNoSimbolo(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Elimina cualquier carácter no numérico ni alfabético del texto
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsLetterOrDigit(c) Then
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Function ReemplazarComaPorPunto(texto As String) As String
        ' Verifica si el texto contiene una coma
        If texto.Contains(",") Then
            ' Reemplaza todas las comas por puntos
            textosincoma = texto.Replace(",", ".")
        Else
            ' Si el texto no contiene comas, simplemente asigna el mismo valor a textosincoma
            textosincoma = texto
        End If
        ' Devuelve el texto modificado
        Return textosincoma
    End Function

    Public Sub SoloIntMonto(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito, +, -, espacio, ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "."c AndAlso Not e.KeyChar = ","c AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito, +, -, espacio, ni la tecla BackSpace, cancela el evento
                e.Handled = True
            Else
                ' Verifica si ya hay un punto o una coma en el texto
                Dim texto As String = textBox.Text
                Dim puntoComaPresente As Boolean = texto.Contains(".") OrElse texto.Contains(",")
                ' Si ya hay un punto o una coma en el texto y la tecla presionada es un punto o coma,
                ' o si el punto o coma está al final del texto, cancela el evento para evitar la inserción de otro punto o coma
                If (puntoComaPresente AndAlso (e.KeyChar = "."c OrElse e.KeyChar = ","c)) Then
                    e.Handled = True
                ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then
                    ' Si la tecla presionada es BackSpace, permitir la eliminación de caracteres
                Else
                    ' Verifica si se está seleccionando texto
                    If textBox.SelectionLength > 0 Then
                        ' Si hay selección de texto, elimina el texto seleccionado antes de verificar el nuevo carácter
                        Dim startIndex As Integer = textBox.SelectionStart
                        Dim lengthToDelete As Integer = textBox.SelectionLength
                        texto = texto.Remove(startIndex, lengthToDelete)
                    End If
                    ' Concatena el nuevo carácter al texto actual
                    Dim newText As String = texto.Insert(textBox.SelectionStart, e.KeyChar.ToString())
                    ' Verifica si hay más de dos decimales
                    Dim indiceSeparador As Integer = If(puntoComaPresente, Math.Max(newText.IndexOf("."c), newText.IndexOf(","c)), -1)
                    If indiceSeparador <> -1 AndAlso newText.Length - indiceSeparador > 3 Then
                        ' Si agregar el nuevo carácter resultaría en más de dos decimales, cancela el evento
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub SoloIntTel(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito, +, -, espacio ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "+"c AndAlso Not e.KeyChar = "-"c AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito, +, -, espacio ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub FiltrarNoIntTel(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Elimina cualquier carácter que no sea un dígito, +, -, o espacio
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsDigit(c) OrElse c = "+"c OrElse c = "-"c Then
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub FiltrarNoIntMonto(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Verifica si el TextBox está vacío
            If texto = "" Then
                Return
            End If
            ' Elimina cualquier carácter que no sea un dígito, +, -, o espacio
            Dim nuevoTexto As String = ""
            Dim puntoComaPresente As Boolean = False
            Dim contadorDespuesPuntoComa As Integer = 0 ' contador para los caracteres después del punto o la coma
            For Each c As Char In texto
                If Char.IsDigit(c) OrElse c = "."c OrElse c = ","c Then
                    If (c = "."c OrElse c = ","c) Then
                        If puntoComaPresente Then
                            ' Si ya hay un punto o coma en el texto y este es otro, no lo agregues
                            Continue For
                        Else
                            puntoComaPresente = True
                            contadorDespuesPuntoComa = 0 ' reiniciar el contador si se encuentra un nuevo punto o coma
                        End If
                    End If
                    ' Verificar si ya hay dos números después del punto o coma
                    If puntoComaPresente AndAlso contadorDespuesPuntoComa >= 3 Then
                        Continue For
                    End If
                    If puntoComaPresente Then
                        contadorDespuesPuntoComa += 1 ' incrementar el contador de caracteres después del punto o coma
                    End If
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub SoloIntCUIT(sender As Object, e As KeyPressEventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Verifica si la tecla presionada no es un dígito, +, -, espacio ni la tecla BackSpace
            If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "-"c AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) Then
                ' Si no es un dígito, +, -, espacio ni la tecla BackSpace, cancela el evento
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub FiltrarNoIntCUIT(sender As Object, e As EventArgs)
        Dim textBox = TryCast(sender, TextBox)
        If textBox IsNot Nothing Then
            ' Obtiene el texto actual del TextBox
            Dim texto As String = textBox.Text
            ' Elimina cualquier carácter que no sea un dígito, +, -, o espacio
            Dim nuevoTexto As String = ""
            For Each c As Char In texto
                If Char.IsDigit(c) OrElse c = "-"c Then
                    nuevoTexto &= c
                End If
            Next
            ' Si el texto ha cambiado, actualiza el contenido del TextBox
            If nuevoTexto <> texto Then
                textBox.Text = nuevoTexto
                ' Coloca el cursor al final del texto
                textBox.SelectionStart = textBox.TextLength
            End If
        End If
    End Sub

    Public Sub CampoBlanco(group As GroupBox, err As ErrorProvider)
        For Each texto In group.Controls
            If TypeOf texto Is TextBox Then
                If texto.text = "" And texto.name.ToString <> "txtMail" And texto.name.ToString <> "txtTel" Then
                    err.SetError(texto, $"El campo '{texto.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next
        banbl = True
    End Sub

    Public Sub CampoBlancoCliente(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" AndAlso textBox.Name <> "txtTel" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next
        banbl = True
    End Sub

    Public Sub CampoBlanco2(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" AndAlso textBox.Name <> "txtDes" AndAlso textBox.Name <> "txtOpMont" AndAlso textBox.Name <> "txtAcla" AndAlso textBox.Name <> "txtNotas" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next
        banbl = True
    End Sub

    Public Sub CampoBlanco3(panel As Panel, err As ErrorProvider)
        For Each control As Control In panel.Controls
            If TypeOf control Is TextBox Then
                Dim textBox As TextBox = DirectCast(control, TextBox)
                If String.IsNullOrEmpty(textBox.Text) AndAlso textBox.Name <> "txtMail" AndAlso textBox.Name <> "txtDes" AndAlso textBox.Name <> "txtNotas" AndAlso textBox.Name <> "txtAcla" Then
                    err.SetError(textBox, $"El campo '{textBox.Tag}' no puede estar vacío.")
                    banbl = False
                    Return
                End If
            End If
        Next
        banbl = True
    End Sub

    Public Function ContieneLetra(texto As String) As Boolean
        For Each caracter As Char In texto
            If Char.IsLetter(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ContieneNumero(texto As String) As Boolean
        For Each caracter As Char In texto
            If Char.IsDigit(caracter) Then
                Return True
            End If
        Next
        Return False
    End Function
#End Region

#Region "Cotización"
    Sub ObtenerFecha(fecha As Label)
        Dim url As String = "https://dolarapi.com/v1/dolares/blue"
        Try
            ' Crear cliente HttpClient
            Using client As New HttpClient()
                ' Realizar solicitud GET a la URL
                Dim response = client.GetAsync(url).Result
                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Obtener el contenido de la respuesta como una cadena JSON
                    Dim content = response.Content.ReadAsStringAsync().Result
                    ' Parsear el contenido JSON
                    Dim data = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(content)
                    Dim dia As String = data("fechaActualizacion")
                    fecha.Text = "Cotización: " & dia.Substring(0, 10)
                Else
                    Console.WriteLine("Error al obtener la cotización. Código de estado: " & response.StatusCode)
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub ObtenerReal(nombre As Label, compra As Label, venta As Label)
        ' URL de la API para obtener la cotización del real
        Dim url As String = "https://dolarapi.com/v1/cotizaciones/brl"
        Try
            ' Crear cliente HttpClient
            Using client As New HttpClient()
                ' Realizar solicitud GET a la URL
                Dim response = client.GetAsync(url).Result
                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Obtener el contenido de la respuesta como una cadena JSON
                    Dim content = response.Content.ReadAsStringAsync().Result
                    ' Parsear el contenido JSON
                    Dim data = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(content)
                    nombre.Text = data("moneda") & " " & data("casa")
                    compra.Text = data("compra")
                    venta.Text = data("venta")
                Else
                    Console.WriteLine("Error al obtener la cotización. Código de estado: " & response.StatusCode)
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub ObtenerEuro(nombre As Label, compra As Label, venta As Label)
        Dim url As String = "https://dolarapi.com/v1/cotizaciones/eur"
        Try
            ' Crear cliente HttpClient
            Using client As New HttpClient()
                ' Realizar solicitud GET a la URL
                Dim response = client.GetAsync(url).Result
                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Obtener el contenido de la respuesta como una cadena JSON
                    Dim content = response.Content.ReadAsStringAsync().Result
                    ' Parsear el contenido JSON
                    Dim data = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(content)

                    nombre.Text = data("moneda") & " " & data("casa")

                    compra.Text = data("compra")
                    venta.Text = data("venta")
                Else
                    Console.WriteLine("Error al obtener la cotización. Código de estado: " & response.StatusCode)
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub ObtenerDolarOficial(nombre As Label, compra As Label, venta As Label)
        Dim url As String = "https://dolarapi.com/v1/dolares/oficial"
        Try
            ' Crear cliente HttpClient
            Using client As New HttpClient()
                ' Realizar solicitud GET a la URL
                Dim response = client.GetAsync(url).Result
                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Obtener el contenido de la respuesta como una cadena JSON
                    Dim content = response.Content.ReadAsStringAsync().Result
                    ' Parsear el contenido JSON
                    Dim data = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(content)
                    nombre.Text = data("moneda") & " " & data("casa")
                    compra.Text = data("compra")
                    venta.Text = data("venta")
                Else
                    Console.WriteLine("Error al obtener la cotización. Código de estado: " & response.StatusCode)
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub ObtenerDolarBlue(nombre As Label, compra As Label, venta As Label)
        Dim url As String = "https://dolarapi.com/v1/dolares/blue"
        Try
            ' Crear cliente HttpClient
            Using client As New HttpClient()
                ' Realizar solicitud GET a la URL
                Dim response = client.GetAsync(url).Result
                ' Verificar si la solicitud fue exitosa
                If response.IsSuccessStatusCode Then
                    ' Obtener el contenido de la respuesta como una cadena JSON
                    Dim content = response.Content.ReadAsStringAsync().Result
                    ' Parsear el contenido JSON
                    Dim data = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(content)
                    ' obt los valores de las propiedades
                    nombre.Text = data("moneda") & " " & data("nombre")
                    compra.Text = data("compra")
                    venta.Text = data("venta")
                Else
                    'solicitud no fue exitos<
                    Console.WriteLine("Error al obtener la cotización. Código de estado: " & response.StatusCode)
                End If
            End Using
        Catch ex As Exception
            'mensaje de error
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Function HayInternet() As Boolean
        Try
            ' ping a google a ver si hay conex
            Dim ping As New Ping()
            Dim result = ping.Send("www.google.com")
            ' si hay true
            Return result.Status = IPStatus.Success
        Catch ex As PingException
            ' si no false
            Return False
        End Try
    End Function


    Function HaySistema() As Boolean
        Try
            ' hace ping a dolarapi
            Dim ping As New Ping()
            Dim result = ping.Send("dolarapi.com")
            ' si hay conex da true
            Return result.Status = IPStatus.Success
        Catch ex As PingException
            ' si no false
            Return False
        End Try
    End Function
#End Region

End Module