<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Label3 = New Label()
        pblBasBut = New Panel()
        bPersonal = New Button()
        bServicios = New Button()
        bVentas = New Button()
        bOperaciones = New Button()
        btnFav = New Button()
        Label4 = New Label()
        pnlFavoritos = New Panel()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        Label5 = New Label()
        btnOpNew = New Button()
        tt = New ToolTip(components)
        btnRefresh = New Button()
        btnConfigCot = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label23 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        PictureBox4 = New PictureBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        pnlCotAge = New Panel()
        Label24 = New Label()
        Label25 = New Label()
        PictureBox5 = New PictureBox()
        Label32 = New Label()
        Label33 = New Label()
        Label34 = New Label()
        Label35 = New Label()
        Label36 = New Label()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        Label37 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Panel2 = New Panel()
        ckbConver = New CheckBox()
        btnCamCon = New Button()
        Label29 = New Label()
        cmbCot = New ComboBox()
        Label28 = New Label()
        Label27 = New Label()
        TextBox1 = New TextBox()
        txtCon = New TextBox()
        Label26 = New Label()
        PictureBox9 = New PictureBox()
        PictureBox8 = New PictureBox()
        Label22 = New Label()
        Sombra = New Panel()
        Sombra2 = New Panel()
        Sombra3 = New Panel()
        btnIngresar = New Button()
        Button2 = New Button()
        Button3 = New Button()
        ckbMosCon = New CheckBox()
        pnlOpSemanales = New Panel()
        Label38 = New Label()
        Label31 = New Label()
        Button4 = New Button()
        Label30 = New Label()
        pblBasBut.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlCotAge.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        pnlOpSemanales.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(12, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 24)
        Label3.TabIndex = 0
        Label3.Text = "Elegir categoría"
        ' 
        ' pblBasBut
        ' 
        pblBasBut.BackColor = Color.Transparent
        pblBasBut.Controls.Add(bPersonal)
        pblBasBut.Controls.Add(bServicios)
        pblBasBut.Controls.Add(bVentas)
        pblBasBut.Controls.Add(bOperaciones)
        pblBasBut.Location = New Point(6, 41)
        pblBasBut.Name = "pblBasBut"
        pblBasBut.Size = New Size(434, 86)
        pblBasBut.TabIndex = 1
        ' 
        ' bPersonal
        ' 
        bPersonal.BackColor = Color.Transparent
        bPersonal.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bPersonal.FlatAppearance.BorderSize = 0
        bPersonal.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        bPersonal.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bPersonal.FlatStyle = FlatStyle.Flat
        bPersonal.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bPersonal.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        bPersonal.Image = CType(resources.GetObject("bPersonal.Image"), Image)
        bPersonal.ImageAlign = ContentAlignment.TopCenter
        bPersonal.Location = New Point(336, 3)
        bPersonal.Name = "bPersonal"
        bPersonal.Size = New Size(88, 80)
        bPersonal.TabIndex = 3
        bPersonal.Text = "Usuarios"
        bPersonal.TextAlign = ContentAlignment.BottomCenter
        tt.SetToolTip(bPersonal, "Abre la sección de usuarios, dónde se muestran los datos de los empleados y sus respectivos usuarios.")
        bPersonal.UseVisualStyleBackColor = False
        ' 
        ' bServicios
        ' 
        bServicios.BackColor = Color.Transparent
        bServicios.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bServicios.FlatAppearance.BorderSize = 0
        bServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        bServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bServicios.FlatStyle = FlatStyle.Flat
        bServicios.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bServicios.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        bServicios.Image = My.Resources.Resources.icons8_natural_501
        bServicios.ImageAlign = ContentAlignment.TopCenter
        bServicios.Location = New Point(119, 3)
        bServicios.Name = "bServicios"
        bServicios.Size = New Size(88, 80)
        bServicios.TabIndex = 1
        bServicios.Text = "Servicios"
        bServicios.TextAlign = ContentAlignment.BottomCenter
        tt.SetToolTip(bServicios, "Abre la sección de servicios, dónde se mostrará los datos de los proveedores y sus servicios.")
        bServicios.UseVisualStyleBackColor = False
        ' 
        ' bVentas
        ' 
        bVentas.BackColor = Color.Transparent
        bVentas.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bVentas.FlatAppearance.BorderSize = 0
        bVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        bVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bVentas.FlatStyle = FlatStyle.Flat
        bVentas.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bVentas.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        bVentas.Image = My.Resources.Resources.icons8_ventas_502
        bVentas.ImageAlign = ContentAlignment.TopCenter
        bVentas.Location = New Point(10, 3)
        bVentas.Name = "bVentas"
        bVentas.Size = New Size(88, 80)
        bVentas.TabIndex = 0
        bVentas.Text = "Ventas"
        bVentas.TextAlign = ContentAlignment.BottomCenter
        tt.SetToolTip(bVentas, "Abre la sección de ventas, dónde están los datos de las ventas, cada servicio vendido en dichas ventas (detalle ventas) y los clientes cargados en el sistema.")
        bVentas.UseVisualStyleBackColor = False
        ' 
        ' bOperaciones
        ' 
        bOperaciones.BackColor = Color.Transparent
        bOperaciones.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bOperaciones.FlatAppearance.BorderSize = 0
        bOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        bOperaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        bOperaciones.FlatStyle = FlatStyle.Flat
        bOperaciones.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bOperaciones.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        bOperaciones.Image = My.Resources.Resources.icons8_personas_en_coche__vista_lateral_601
        bOperaciones.ImageAlign = ContentAlignment.TopCenter
        bOperaciones.Location = New Point(228, 3)
        bOperaciones.Name = "bOperaciones"
        bOperaciones.Size = New Size(88, 80)
        bOperaciones.TabIndex = 2
        bOperaciones.Text = "Operaciones"
        bOperaciones.TextAlign = ContentAlignment.BottomCenter
        tt.SetToolTip(bOperaciones, "Sección de operaciones, dónde se mostrarán los datos de los choferes, sus vehículos y las operaciones cargadas al sistema.")
        bOperaciones.UseVisualStyleBackColor = False
        ' 
        ' btnFav
        ' 
        btnFav.BackColor = Color.Transparent
        btnFav.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnFav.FlatAppearance.BorderSize = 0
        btnFav.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        btnFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnFav.FlatStyle = FlatStyle.Flat
        btnFav.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFav.ForeColor = Color.SteelBlue
        btnFav.Image = My.Resources.Resources.icons8_más_nuevo_242
        btnFav.Location = New Point(111, 136)
        btnFav.Name = "btnFav"
        btnFav.Size = New Size(35, 36)
        btnFav.TabIndex = 3
        btnFav.TextAlign = ContentAlignment.MiddleLeft
        tt.SetToolTip(btnFav, "Haga click en este botón para seleccionar atajos favoritos los cuales se mostrarán cada vez que inicie sesión con su usuario.")
        btnFav.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(12, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 24)
        Label4.TabIndex = 2
        Label4.Text = "Favoritos"
        ' 
        ' pnlFavoritos
        ' 
        pnlFavoritos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlFavoritos.BackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        pnlFavoritos.Location = New Point(6, 178)
        pnlFavoritos.Name = "pnlFavoritos"
        pnlFavoritos.Size = New Size(434, 590)
        pnlFavoritos.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(642, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 37)
        Label1.TabIndex = 5
        Label1.Text = "00:00"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(573, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 20)
        Label2.TabIndex = 6
        Label2.Text = "Lunes, 15 de Junio de 2020"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label5.Location = New Point(203, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 20)
        Label5.TabIndex = 4
        Label5.Text = "Sin conexión"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnOpNew
        ' 
        btnOpNew.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpNew.BackColor = Color.Transparent
        btnOpNew.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnOpNew.FlatAppearance.BorderSize = 0
        btnOpNew.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        btnOpNew.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnOpNew.FlatStyle = FlatStyle.Flat
        btnOpNew.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnOpNew.ForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnOpNew.Image = CType(resources.GetObject("btnOpNew.Image"), Image)
        btnOpNew.ImageAlign = ContentAlignment.TopCenter
        btnOpNew.Location = New Point(1313, 12)
        btnOpNew.Name = "btnOpNew"
        btnOpNew.Size = New Size(61, 65)
        btnOpNew.TabIndex = 7
        btnOpNew.Text = " "
        tt.SetToolTip(btnOpNew, "Indica cuántas operaciones hay en los siguientes 7 días. Al hacer click abre la sección de operaciones.")
        btnOpNew.UseVisualStyleBackColor = False
        ' 
        ' tt
        ' 
        tt.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        tt.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.Transparent
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.SteelBlue
        btnRefresh.Image = My.Resources.Resources.icons8_recargar_30
        btnRefresh.Location = New Point(1333, 136)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(41, 39)
        btnRefresh.TabIndex = 9
        btnRefresh.TextAlign = ContentAlignment.MiddleLeft
        tt.SetToolTip(btnRefresh, "Recarga la tabla. Si hay conexión a internet, se mostrarán las cotizaciones según la página ""www.dolarhoy.com"".")
        btnRefresh.UseVisualStyleBackColor = False
        btnRefresh.Visible = False
        ' 
        ' btnConfigCot
        ' 
        btnConfigCot.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnConfigCot.BackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        btnConfigCot.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnConfigCot.FlatAppearance.BorderSize = 0
        btnConfigCot.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnConfigCot.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        btnConfigCot.FlatStyle = FlatStyle.Flat
        btnConfigCot.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfigCot.ForeColor = Color.SteelBlue
        btnConfigCot.Image = My.Resources.Resources.icons8_engranaje_24
        btnConfigCot.Location = New Point(388, 7)
        btnConfigCot.Name = "btnConfigCot"
        btnConfigCot.Size = New Size(38, 32)
        btnConfigCot.TabIndex = 21
        btnConfigCot.TextAlign = ContentAlignment.MiddleLeft
        tt.SetToolTip(btnConfigCot, "Recarga la tabla. Si hay conexión a internet, se mostrarán las cotizaciones según la página ""www.dolarhoy.com"".")
        btnConfigCot.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(37), CByte(77), CByte(135))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(37), CByte(77), CByte(135))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.Image = My.Resources.Resources.icons8_estrella_50
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(261, 16)
        Button1.Name = "Button1"
        Button1.Size = New Size(61, 65)
        Button1.TabIndex = 23
        Button1.Text = " "
        tt.SetToolTip(Button1, "Indica cuántas operaciones hay en los siguientes 7 días. Al hacer click abre la sección de operaciones.")
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.icons8_circular_de_ee_uu_48__1_
        PictureBox1.Location = New Point(13, 96)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 50)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(940, 178)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(434, 276)
        Panel1.TabIndex = 17
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label23.Location = New Point(262, 256)
        Label23.Name = "Label23"
        Label23.Size = New Size(166, 16)
        Label23.TabIndex = 39
        Label23.Text = "Fuente: www.dolarhoy.com"
        Label23.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label19.Location = New Point(320, 15)
        Label19.Name = "Label19"
        Label19.Size = New Size(57, 20)
        Label19.TabIndex = 2
        Label19.Text = "Venta"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label18.Location = New Point(203, 15)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 20)
        Label18.TabIndex = 1
        Label18.Text = "Compra"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label17.Location = New Point(67, 15)
        Label17.Name = "Label17"
        Label17.Size = New Size(73, 20)
        Label17.TabIndex = 0
        Label17.Text = "Moneda"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label14.Location = New Point(320, 111)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 20)
        Label14.TabIndex = 8
        Label14.Text = "Sin conexión"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label15.Location = New Point(67, 111)
        Label15.Name = "Label15"
        Label15.Size = New Size(111, 20)
        Label15.TabIndex = 6
        Label15.Text = "Sin conexión"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label16.Location = New Point(203, 111)
        Label16.Name = "Label16"
        Label16.Size = New Size(111, 20)
        Label16.TabIndex = 7
        Label16.Text = "Sin conexión"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Image = My.Resources.Resources.icons8_circular_de_ee_uu_48
        PictureBox4.Location = New Point(13, 40)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 50)
        PictureBox4.TabIndex = 19
        PictureBox4.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label13.Location = New Point(320, 224)
        Label13.Name = "Label13"
        Label13.Size = New Size(111, 20)
        Label13.TabIndex = 14
        Label13.Text = "Sin conexión"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label12.Location = New Point(320, 169)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 20)
        Label12.TabIndex = 2
        Label12.Text = "Sin conexión"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label11.Location = New Point(320, 57)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 20)
        Label11.TabIndex = 5
        Label11.Text = "Sin conexión"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label10.Location = New Point(203, 224)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 20)
        Label10.TabIndex = 13
        Label10.Text = "Sin conexión"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label9.Location = New Point(203, 169)
        Label9.Name = "Label9"
        Label9.Size = New Size(111, 20)
        Label9.TabIndex = 10
        Label9.Text = "Sin conexión"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label8.Location = New Point(67, 224)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 20)
        Label8.TabIndex = 12
        Label8.Text = "Sin conexión"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(67, 169)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 20)
        Label7.TabIndex = 1
        Label7.Text = "Sin conexión"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(67, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 20)
        Label6.TabIndex = 3
        Label6.Text = "Sin conexión"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Image = My.Resources.Resources.icons8_circular_brasil_48
        PictureBox3.Location = New Point(13, 209)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 50)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = My.Resources.Resources.icons8_bandera_circular_de_union_europea_48
        PictureBox2.Location = New Point(13, 152)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 50)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' pnlCotAge
        ' 
        pnlCotAge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlCotAge.BackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        pnlCotAge.BackgroundImageLayout = ImageLayout.Center
        pnlCotAge.Controls.Add(btnConfigCot)
        pnlCotAge.Controls.Add(Label24)
        pnlCotAge.Controls.Add(Label25)
        pnlCotAge.Controls.Add(PictureBox5)
        pnlCotAge.Controls.Add(Label32)
        pnlCotAge.Controls.Add(Label33)
        pnlCotAge.Controls.Add(Label34)
        pnlCotAge.Controls.Add(Label35)
        pnlCotAge.Controls.Add(Label36)
        pnlCotAge.Controls.Add(PictureBox6)
        pnlCotAge.Controls.Add(PictureBox7)
        pnlCotAge.Controls.Add(Label37)
        pnlCotAge.Location = New Point(940, 178)
        pnlCotAge.Name = "pnlCotAge"
        pnlCotAge.Size = New Size(434, 276)
        pnlCotAge.TabIndex = 7
        pnlCotAge.Visible = False
        ' 
        ' Label24
        ' 
        Label24.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label24.Location = New Point(275, 20)
        Label24.Name = "Label24"
        Label24.Size = New Size(51, 20)
        Label24.TabIndex = 21
        Label24.Text = "Valor"
        Label24.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label25
        ' 
        Label25.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label25.AutoSize = True
        Label25.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label25.Location = New Point(112, 20)
        Label25.Name = "Label25"
        Label25.Size = New Size(73, 20)
        Label25.TabIndex = 20
        Label25.Text = "Moneda"
        Label25.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.Image = My.Resources.Resources.icons8_circular_de_ee_uu_48
        PictureBox5.Location = New Point(43, 53)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(48, 50)
        PictureBox5.TabIndex = 38
        PictureBox5.TabStop = False
        ' 
        ' Label32
        ' 
        Label32.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label32.AutoSize = True
        Label32.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label32.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label32.Location = New Point(275, 211)
        Label32.Name = "Label32"
        Label32.Size = New Size(111, 20)
        Label32.TabIndex = 36
        Label32.Text = "Sin conexión"
        Label32.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label33
        ' 
        Label33.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label33.AutoSize = True
        Label33.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label33.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label33.Location = New Point(275, 141)
        Label33.Name = "Label33"
        Label33.Size = New Size(111, 20)
        Label33.TabIndex = 33
        Label33.Text = "Sin conexión"
        Label33.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label34
        ' 
        Label34.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label34.AutoSize = True
        Label34.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label34.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label34.Location = New Point(111, 211)
        Label34.Name = "Label34"
        Label34.Size = New Size(111, 20)
        Label34.TabIndex = 35
        Label34.Text = "Sin conexión"
        Label34.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label35
        ' 
        Label35.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label35.AutoSize = True
        Label35.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label35.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label35.Location = New Point(111, 141)
        Label35.Name = "Label35"
        Label35.Size = New Size(111, 20)
        Label35.TabIndex = 22
        Label35.Text = "Sin conexión"
        Label35.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label36
        ' 
        Label36.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label36.AutoSize = True
        Label36.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label36.Location = New Point(111, 70)
        Label36.Name = "Label36"
        Label36.Size = New Size(111, 20)
        Label36.TabIndex = 25
        Label36.Text = "Sin conexión"
        Label36.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.None
        PictureBox6.Image = My.Resources.Resources.icons8_circular_brasil_48
        PictureBox6.Location = New Point(43, 195)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(48, 50)
        PictureBox6.TabIndex = 34
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.Image = My.Resources.Resources.icons8_bandera_circular_de_union_europea_48
        PictureBox7.Location = New Point(43, 124)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(48, 50)
        PictureBox7.TabIndex = 32
        PictureBox7.TabStop = False
        ' 
        ' Label37
        ' 
        Label37.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label37.AutoSize = True
        Label37.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label37.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label37.Location = New Point(275, 70)
        Label37.Name = "Label37"
        Label37.Size = New Size(111, 20)
        Label37.TabIndex = 26
        Label37.Text = "Sin conexión"
        Label37.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label20.Location = New Point(1077, 31)
        Label20.Name = "Label20"
        Label20.Size = New Size(215, 24)
        Label20.TabIndex = 6
        Label20.Text = "Operaciones semanales"
        ' 
        ' Label21
        ' 
        Label21.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label21.Location = New Point(943, 117)
        Label21.Name = "Label21"
        Label21.Size = New Size(97, 24)
        Label21.TabIndex = 8
        Label21.Text = "Cotización"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(ckbConver)
        Panel2.Controls.Add(btnCamCon)
        Panel2.Controls.Add(Label29)
        Panel2.Controls.Add(cmbCot)
        Panel2.Controls.Add(Label28)
        Panel2.Controls.Add(Label27)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(txtCon)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(PictureBox9)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Location = New Point(940, 518)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(434, 254)
        Panel2.TabIndex = 6
        ' 
        ' ckbConver
        ' 
        ckbConver.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ckbConver.Appearance = Appearance.Button
        ckbConver.AutoSize = True
        ckbConver.FlatAppearance.BorderSize = 0
        ckbConver.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        ckbConver.FlatStyle = FlatStyle.Flat
        ckbConver.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbConver.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbConver.Image = My.Resources.Resources.icons8_flecha_izquierda_24
        ckbConver.ImageAlign = ContentAlignment.MiddleLeft
        ckbConver.Location = New Point(200, 129)
        ckbConver.Name = "ckbConver"
        ckbConver.Size = New Size(35, 30)
        ckbConver.TabIndex = 22
        ckbConver.Text = "    "
        ckbConver.UseVisualStyleBackColor = True
        ' 
        ' btnCamCon
        ' 
        btnCamCon.Anchor = AnchorStyles.Top
        btnCamCon.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCamCon.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnCamCon.FlatAppearance.BorderSize = 0
        btnCamCon.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCamCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnCamCon.FlatStyle = FlatStyle.Flat
        btnCamCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCamCon.ForeColor = Color.White
        btnCamCon.Image = My.Resources.Resources.icons8_estimar_25
        btnCamCon.ImageAlign = ContentAlignment.MiddleLeft
        btnCamCon.Location = New Point(21, 188)
        btnCamCon.Name = "btnCamCon"
        btnCamCon.Size = New Size(172, 37)
        btnCamCon.TabIndex = 59
        btnCamCon.Text = "Calcular"
        btnCamCon.UseVisualStyleBackColor = False
        ' 
        ' Label29
        ' 
        Label29.Anchor = AnchorStyles.Top
        Label29.AutoSize = True
        Label29.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label29.Location = New Point(296, 37)
        Label29.Name = "Label29"
        Label29.Size = New Size(73, 20)
        Label29.TabIndex = 58
        Label29.Text = "Moneda"
        Label29.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbCot
        ' 
        cmbCot.Anchor = AnchorStyles.Top
        cmbCot.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        cmbCot.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCot.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCot.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        cmbCot.FormattingEnabled = True
        cmbCot.Location = New Point(296, 60)
        cmbCot.Name = "cmbCot"
        cmbCot.Size = New Size(118, 28)
        cmbCot.TabIndex = 57
        ' 
        ' Label28
        ' 
        Label28.Anchor = AnchorStyles.Top
        Label28.AutoSize = True
        Label28.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label28.Location = New Point(243, 110)
        Label28.Name = "Label28"
        Label28.Size = New Size(138, 20)
        Label28.TabIndex = 43
        Label28.Text = "Valor Extranjero"
        Label28.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label27
        ' 
        Label27.Anchor = AnchorStyles.Top
        Label27.AutoSize = True
        Label27.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.ForeColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Label27.Location = New Point(21, 110)
        Label27.Name = "Label27"
        Label27.Size = New Size(130, 20)
        Label27.TabIndex = 39
        Label27.Text = "Valor en Pesos"
        Label27.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top
        TextBox1.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        TextBox1.Location = New Point(242, 133)
        TextBox1.MaxLength = 17
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(172, 26)
        TextBox1.TabIndex = 42
        TextBox1.Tag = "Usuario"
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.Top
        txtCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCon.Enabled = False
        txtCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCon.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtCon.Location = New Point(21, 133)
        txtCon.MaxLength = 17
        txtCon.Name = "txtCon"
        txtCon.Size = New Size(172, 26)
        txtCon.TabIndex = 41
        txtCon.Tag = "Usuario"
        ' 
        ' Label26
        ' 
        Label26.Anchor = AnchorStyles.Top
        Label26.AutoSize = True
        Label26.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label26.Location = New Point(75, 52)
        Label26.Name = "Label26"
        Label26.Size = New Size(93, 20)
        Label26.TabIndex = 39
        Label26.Text = "Peso ARG"
        Label26.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top
        PictureBox9.Image = My.Resources.Resources.icons8_circular_de_ee_uu_48
        PictureBox9.Location = New Point(242, 38)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(48, 50)
        PictureBox9.TabIndex = 40
        PictureBox9.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.Top
        PictureBox8.Image = My.Resources.Resources.icons8_circular_argentina_48
        PictureBox8.Location = New Point(21, 38)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(48, 50)
        PictureBox8.TabIndex = 39
        PictureBox8.TabStop = False
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label22.AutoSize = True
        Label22.BackColor = Color.Transparent
        Label22.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label22.Location = New Point(981, 484)
        Label22.Name = "Label22"
        Label22.Size = New Size(229, 24)
        Label22.TabIndex = 10
        Label22.Text = "Calculadora de Cotización"
        ' 
        ' Sombra
        ' 
        Sombra.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Sombra.BackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        Sombra.Location = New Point(6, 190)
        Sombra.Name = "Sombra"
        Sombra.Size = New Size(443, 586)
        Sombra.TabIndex = 5
        ' 
        ' Sombra2
        ' 
        Sombra2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Sombra2.BackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        Sombra2.Location = New Point(940, 190)
        Sombra2.Name = "Sombra2"
        Sombra2.Size = New Size(443, 272)
        Sombra2.TabIndex = 11
        ' 
        ' Sombra3
        ' 
        Sombra3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Sombra3.BackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        Sombra3.Location = New Point(940, 528)
        Sombra3.Name = "Sombra3"
        Sombra3.Size = New Size(443, 252)
        Sombra3.TabIndex = 13
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Anchor = AnchorStyles.Bottom
        btnIngresar.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Image = My.Resources.Resources.icons8_buy_26_1_
        btnIngresar.ImageAlign = ContentAlignment.MiddleLeft
        btnIngresar.Location = New Point(550, 705)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(283, 63)
        btnIngresar.TabIndex = 14
        btnIngresar.Text = "  Iniciar Venta"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Button2.Location = New Point(940, 146)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 33)
        Button2.TabIndex = 19
        Button2.Text = "Agencia"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Button3.Location = New Point(1026, 146)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 33)
        Button3.TabIndex = 20
        Button3.Text = "Web"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ckbMosCon
        ' 
        ckbMosCon.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        ckbMosCon.Appearance = Appearance.Button
        ckbMosCon.AutoSize = True
        ckbMosCon.BackColor = Color.Transparent
        ckbMosCon.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        ckbMosCon.FlatAppearance.BorderSize = 0
        ckbMosCon.FlatAppearance.CheckedBackColor = Color.Transparent
        ckbMosCon.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(191), CByte(208), CByte(236))
        ckbMosCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        ckbMosCon.FlatStyle = FlatStyle.Flat
        ckbMosCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbMosCon.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbMosCon.Image = My.Resources.Resources.icons8_invisible_nuevo_243
        ckbMosCon.ImageAlign = ContentAlignment.MiddleLeft
        ckbMosCon.Location = New Point(945, 480)
        ckbMosCon.Name = "ckbMosCon"
        ckbMosCon.Size = New Size(35, 30)
        ckbMosCon.TabIndex = 21
        ckbMosCon.Text = "    "
        ckbMosCon.UseVisualStyleBackColor = False
        ' 
        ' pnlOpSemanales
        ' 
        pnlOpSemanales.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlOpSemanales.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlOpSemanales.Controls.Add(Label38)
        pnlOpSemanales.Controls.Add(Label31)
        pnlOpSemanales.Controls.Add(Button4)
        pnlOpSemanales.Controls.Add(Label30)
        pnlOpSemanales.Controls.Add(Button1)
        pnlOpSemanales.Location = New Point(1052, -4)
        pnlOpSemanales.Name = "pnlOpSemanales"
        pnlOpSemanales.Size = New Size(334, 466)
        pnlOpSemanales.TabIndex = 12
        pnlOpSemanales.Visible = False
        ' 
        ' Label38
        ' 
        Label38.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label38.AutoSize = True
        Label38.BackColor = Color.Transparent
        Label38.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label38.ForeColor = Color.FromArgb(CByte(209), CByte(223), CByte(243))
        Label38.Location = New Point(290, 377)
        Label38.Name = "Label38"
        Label38.Size = New Size(24, 24)
        Label38.TabIndex = 62
        Label38.Text = "N"
        Label38.TextAlign = ContentAlignment.MiddleCenter
        Label38.Visible = False
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label31.AutoSize = True
        Label31.BackColor = Color.Transparent
        Label31.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.ForeColor = Color.FromArgb(CByte(209), CByte(223), CByte(243))
        Label31.Location = New Point(63, 217)
        Label31.Name = "Label31"
        Label31.Size = New Size(207, 48)
        Label31.TabIndex = 61
        Label31.Text = "No hay operaciones en" & vbCrLf & "los siguientes 7 días."
        Label31.TextAlign = ContentAlignment.MiddleCenter
        Label31.Visible = False
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.Transparent
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Button4.Image = My.Resources.Resources.icons8_auto_243
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(1, 406)
        Button4.Name = "Button4"
        Button4.Size = New Size(333, 37)
        Button4.TabIndex = 60
        Button4.Text = "    Ver Operaciones Cercanas"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label30
        ' 
        Label30.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label30.AutoSize = True
        Label30.BackColor = Color.Transparent
        Label30.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label30.ForeColor = Color.FromArgb(CByte(233), CByte(239), CByte(250))
        Label30.Location = New Point(25, 35)
        Label30.Name = "Label30"
        Label30.Size = New Size(215, 24)
        Label30.TabIndex = 22
        Label30.Text = "Operaciones semanales"
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        BackgroundImage = My.Resources.Resources.iconmaxi
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1386, 788)
        Controls.Add(pnlOpSemanales)
        Controls.Add(ckbMosCon)
        Controls.Add(pnlCotAge)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        Controls.Add(btnIngresar)
        Controls.Add(Panel2)
        Controls.Add(btnRefresh)
        Controls.Add(Label22)
        Controls.Add(Label3)
        Controls.Add(pblBasBut)
        Controls.Add(btnFav)
        Controls.Add(Label21)
        Controls.Add(Label4)
        Controls.Add(Label20)
        Controls.Add(pnlFavoritos)
        Controls.Add(btnOpNew)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Sombra)
        Controls.Add(Sombra2)
        Controls.Add(Sombra3)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMenu"
        Text = "A"
        pblBasBut.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlCotAge.ResumeLayout(False)
        pnlCotAge.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        pnlOpSemanales.ResumeLayout(False)
        pnlOpSemanales.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents bOperaciones As Button
    Friend WithEvents bPersonal As Button
    Friend WithEvents bServicios As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents pblBasBut As Panel
    Friend WithEvents pnlFavoritos As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFav As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnOpNew As Button
    Friend WithEvents tt As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Sombra As Panel
    Friend WithEvents Sombra2 As Panel
    Friend WithEvents Sombra3 As Panel
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pnlCotAge As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label37 As Label
    Friend WithEvents btnConfigCot As Button
    Friend WithEvents ckbMosCon As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cmbCot As ComboBox
    Friend WithEvents btnCamCon As Button
    Friend WithEvents ckbConver As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents pnlOpSemanales As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label38 As Label
End Class
