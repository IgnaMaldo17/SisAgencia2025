<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrVent
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrVent))
        pnlDatVender = New Panel()
        Label13 = New Label()
        ckbActOp = New CheckBox()
        ckbActFecha = New CheckBox()
        ckbActHora = New CheckBox()
        btnNuevo = New Button()
        txtOpMont = New TextBox()
        Label10 = New Label()
        txtAcla = New TextBox()
        txtNotas = New TextBox()
        Label12 = New Label()
        dtpHora = New DateTimePicker()
        dtpFecha = New DateTimePicker()
        btnSelSer = New Button()
        txtCli = New TextBox()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        txtServ = New TextBox()
        txtCantPer = New TextBox()
        btnAgrSer = New Button()
        btnRetSer = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnFinCom = New Button()
        dgvVender = New DataGridView()
        cCliente = New DataGridViewTextBoxColumn()
        cServicio = New DataGridViewTextBoxColumn()
        cCanPersonas = New DataGridViewTextBoxColumn()
        cFecha = New DataGridViewTextBoxColumn()
        cHora = New DataGridViewTextBoxColumn()
        cMonto = New DataGridViewTextBoxColumn()
        cMonServ = New DataGridViewTextBoxColumn()
        cNotas = New DataGridViewTextBoxColumn()
        cValorOp = New DataGridViewTextBoxColumn()
        cAclaracion = New DataGridViewTextBoxColumn()
        cTotal = New DataGridViewTextBoxColumn()
        codserv = New DataGridViewTextBoxColumn()
        numero = New DataGridViewTextBoxColumn()
        horaform = New DataGridViewTextBoxColumn()
        fechaform = New DataGridViewTextBoxColumn()
        llevaopera = New DataGridViewTextBoxColumn()
        Label7 = New Label()
        btnCancel = New Button()
        pnlDGVVender = New Panel()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        txtDolar = New TextBox()
        txtEuro = New TextBox()
        txtReal = New TextBox()
        Button1 = New Button()
        txtTotal = New TextBox()
        Label11 = New Label()
        pnlAgrSer = New Panel()
        pnlDGVServ = New Panel()
        Label9 = New Label()
        dgvServVen = New DataGridView()
        txtBusSer = New TextBox()
        ep = New ErrorProvider(components)
        pnlDatVender.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvVender, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVVender.SuspendLayout()
        pnlAgrSer.SuspendLayout()
        pnlDGVServ.SuspendLayout()
        CType(dgvServVen, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDatVender
        ' 
        pnlDatVender.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatVender.Controls.Add(Label13)
        pnlDatVender.Controls.Add(ckbActOp)
        pnlDatVender.Controls.Add(ckbActFecha)
        pnlDatVender.Controls.Add(ckbActHora)
        pnlDatVender.Controls.Add(btnNuevo)
        pnlDatVender.Controls.Add(txtOpMont)
        pnlDatVender.Controls.Add(Label10)
        pnlDatVender.Controls.Add(txtAcla)
        pnlDatVender.Controls.Add(txtNotas)
        pnlDatVender.Controls.Add(Label12)
        pnlDatVender.Controls.Add(dtpHora)
        pnlDatVender.Controls.Add(dtpFecha)
        pnlDatVender.Controls.Add(btnSelSer)
        pnlDatVender.Controls.Add(txtCli)
        pnlDatVender.Controls.Add(Label8)
        pnlDatVender.Controls.Add(PictureBox1)
        pnlDatVender.Controls.Add(txtServ)
        pnlDatVender.Controls.Add(txtCantPer)
        pnlDatVender.Controls.Add(btnAgrSer)
        pnlDatVender.Controls.Add(btnRetSer)
        pnlDatVender.Controls.Add(Label5)
        pnlDatVender.Controls.Add(Label3)
        pnlDatVender.Controls.Add(Label4)
        pnlDatVender.Controls.Add(Label6)
        pnlDatVender.Controls.Add(Label2)
        pnlDatVender.Controls.Add(Label1)
        pnlDatVender.Dock = DockStyle.Left
        pnlDatVender.Location = New Point(0, 0)
        pnlDatVender.Name = "pnlDatVender"
        pnlDatVender.Size = New Size(277, 1041)
        pnlDatVender.TabIndex = 0
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.None
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label13.Location = New Point(46, 609)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 16)
        Label13.TabIndex = 17
        Label13.Text = "Cuenta con Operación"
        ' 
        ' ckbActOp
        ' 
        ckbActOp.Anchor = AnchorStyles.None
        ckbActOp.Appearance = Appearance.Button
        ckbActOp.AutoSize = True
        ckbActOp.BackColor = Color.Transparent
        ckbActOp.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActOp.FlatAppearance.BorderSize = 0
        ckbActOp.FlatAppearance.CheckedBackColor = Color.Transparent
        ckbActOp.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActOp.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActOp.FlatStyle = FlatStyle.Flat
        ckbActOp.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbActOp.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbActOp.Image = My.Resources.Resources.icons8_tickc_no_242
        ckbActOp.ImageAlign = ContentAlignment.MiddleLeft
        ckbActOp.Location = New Point(12, 601)
        ckbActOp.Name = "ckbActOp"
        ckbActOp.Size = New Size(35, 30)
        ckbActOp.TabIndex = 16
        ckbActOp.Text = "    "
        ckbActOp.UseVisualStyleBackColor = False
        ' 
        ' ckbActFecha
        ' 
        ckbActFecha.Anchor = AnchorStyles.None
        ckbActFecha.Appearance = Appearance.Button
        ckbActFecha.AutoSize = True
        ckbActFecha.BackColor = Color.Transparent
        ckbActFecha.Checked = True
        ckbActFecha.CheckState = CheckState.Checked
        ckbActFecha.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActFecha.FlatAppearance.BorderSize = 0
        ckbActFecha.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActFecha.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActFecha.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActFecha.FlatStyle = FlatStyle.Flat
        ckbActFecha.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbActFecha.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbActFecha.Image = My.Resources.Resources.icons8_tickc_no_241
        ckbActFecha.ImageAlign = ContentAlignment.MiddleLeft
        ckbActFecha.Location = New Point(93, 913)
        ckbActFecha.Name = "ckbActFecha"
        ckbActFecha.Size = New Size(35, 30)
        ckbActFecha.TabIndex = 9
        ckbActFecha.Text = "    "
        ckbActFecha.UseVisualStyleBackColor = False
        ckbActFecha.Visible = False
        ' 
        ' ckbActHora
        ' 
        ckbActHora.Anchor = AnchorStyles.None
        ckbActHora.Appearance = Appearance.Button
        ckbActHora.AutoSize = True
        ckbActHora.BackColor = Color.Transparent
        ckbActHora.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHora.FlatAppearance.BorderSize = 0
        ckbActHora.FlatAppearance.CheckedBackColor = Color.Transparent
        ckbActHora.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHora.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHora.FlatStyle = FlatStyle.Flat
        ckbActHora.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbActHora.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbActHora.Image = My.Resources.Resources.icons8_tickc_no_24
        ckbActHora.ImageAlign = ContentAlignment.MiddleLeft
        ckbActHora.Location = New Point(146, 511)
        ckbActHora.Name = "ckbActHora"
        ckbActHora.Size = New Size(35, 30)
        ckbActHora.TabIndex = 12
        ckbActHora.Text = "    "
        ckbActHora.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.None
        btnNuevo.BackColor = Color.Transparent
        btnNuevo.FlatAppearance.BorderColor = Color.SlateGray
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnNuevo.Image = My.Resources.Resources.icons8_más_30
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(136, 343)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "Cancelar"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtOpMont
        ' 
        txtOpMont.Anchor = AnchorStyles.None
        txtOpMont.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtOpMont.Enabled = False
        txtOpMont.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOpMont.Location = New Point(28, 660)
        txtOpMont.MaxLength = 12
        txtOpMont.Name = "txtOpMont"
        txtOpMont.Size = New Size(224, 22)
        txtOpMont.TabIndex = 19
        txtOpMont.Tag = "Monto de Operación"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.None
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label10.Location = New Point(28, 641)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 16)
        Label10.TabIndex = 18
        Label10.Text = "Monto de Operación*"
        ' 
        ' txtAcla
        ' 
        txtAcla.Anchor = AnchorStyles.None
        txtAcla.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtAcla.Enabled = False
        txtAcla.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAcla.Location = New Point(29, 702)
        txtAcla.MaxLength = 250
        txtAcla.Name = "txtAcla"
        txtAcla.Size = New Size(224, 22)
        txtAcla.TabIndex = 21
        txtAcla.Tag = "Aclaración"
        ' 
        ' txtNotas
        ' 
        txtNotas.Anchor = AnchorStyles.None
        txtNotas.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNotas.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNotas.Location = New Point(25, 568)
        txtNotas.MaxLength = 200
        txtNotas.Multiline = True
        txtNotas.Name = "txtNotas"
        txtNotas.Size = New Size(224, 22)
        txtNotas.TabIndex = 15
        txtNotas.Tag = "Notas"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.None
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label12.Location = New Point(29, 684)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 16)
        Label12.TabIndex = 20
        Label12.Text = "Aclaración"
        ' 
        ' dtpHora
        ' 
        dtpHora.Anchor = AnchorStyles.None
        dtpHora.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpHora.Enabled = False
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.Location = New Point(184, 514)
        dtpHora.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        dtpHora.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        dtpHora.Name = "dtpHora"
        dtpHora.Size = New Size(65, 23)
        dtpHora.TabIndex = 13
        dtpHora.Value = New Date(2024, 5, 3, 20, 10, 35, 0)
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Anchor = AnchorStyles.None
        dtpFecha.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFecha.Enabled = False
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(26, 514)
        dtpFecha.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        dtpFecha.MinDate = New Date(2024, 10, 30, 0, 0, 0, 0)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(102, 23)
        dtpFecha.TabIndex = 10
        dtpFecha.Value = New Date(2024, 10, 30, 0, 0, 0, 0)
        ' 
        ' btnSelSer
        ' 
        btnSelSer.Anchor = AnchorStyles.None
        btnSelSer.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelSer.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnSelSer.FlatAppearance.BorderSize = 0
        btnSelSer.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelSer.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnSelSer.FlatStyle = FlatStyle.Flat
        btnSelSer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelSer.ForeColor = Color.White
        btnSelSer.Image = My.Resources.Resources.icons8_flecha_derecha_24
        btnSelSer.ImageAlign = ContentAlignment.MiddleRight
        btnSelSer.Location = New Point(26, 747)
        btnSelSer.Name = "btnSelSer"
        btnSelSer.Size = New Size(251, 31)
        btnSelSer.TabIndex = 22
        btnSelSer.Text = "Elegir Servicio"
        btnSelSer.UseVisualStyleBackColor = False
        ' 
        ' txtCli
        ' 
        txtCli.Anchor = AnchorStyles.None
        txtCli.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCli.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCli.Location = New Point(25, 383)
        txtCli.MaxLength = 100
        txtCli.Name = "txtCli"
        txtCli.Size = New Size(224, 22)
        txtCli.TabIndex = 3
        txtCli.Tag = "Cliente"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label8.Location = New Point(25, 364)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 16)
        Label8.TabIndex = 2
        Label8.Text = "Cliente*"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_carrito_de_compras_100__1_
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' txtServ
        ' 
        txtServ.Anchor = AnchorStyles.None
        txtServ.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtServ.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtServ.Location = New Point(26, 425)
        txtServ.MaxLength = 50
        txtServ.Name = "txtServ"
        txtServ.Size = New Size(224, 22)
        txtServ.TabIndex = 5
        txtServ.Tag = "Servicio"
        ' 
        ' txtCantPer
        ' 
        txtCantPer.Anchor = AnchorStyles.None
        txtCantPer.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCantPer.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCantPer.Location = New Point(26, 469)
        txtCantPer.MaxLength = 2
        txtCantPer.Name = "txtCantPer"
        txtCantPer.Size = New Size(224, 22)
        txtCantPer.TabIndex = 7
        txtCantPer.Tag = "Cantidad de Personas"
        ' 
        ' btnAgrSer
        ' 
        btnAgrSer.Anchor = AnchorStyles.None
        btnAgrSer.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnAgrSer.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnAgrSer.FlatAppearance.BorderSize = 0
        btnAgrSer.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnAgrSer.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnAgrSer.FlatStyle = FlatStyle.Flat
        btnAgrSer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrSer.ForeColor = Color.White
        btnAgrSer.Image = My.Resources.Resources.icons8_parque_nacional_nuevob_241
        btnAgrSer.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrSer.Location = New Point(26, 784)
        btnAgrSer.Name = "btnAgrSer"
        btnAgrSer.Size = New Size(224, 31)
        btnAgrSer.TabIndex = 23
        btnAgrSer.Text = "Agregar Servicio"
        btnAgrSer.UseVisualStyleBackColor = False
        ' 
        ' btnRetSer
        ' 
        btnRetSer.Anchor = AnchorStyles.None
        btnRetSer.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnRetSer.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnRetSer.FlatAppearance.BorderSize = 0
        btnRetSer.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnRetSer.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnRetSer.FlatStyle = FlatStyle.Flat
        btnRetSer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRetSer.ForeColor = Color.White
        btnRetSer.Image = My.Resources.Resources.icons8_eliminar_24
        btnRetSer.ImageAlign = ContentAlignment.MiddleLeft
        btnRetSer.Location = New Point(26, 821)
        btnRetSer.Name = "btnRetSer"
        btnRetSer.Size = New Size(224, 31)
        btnRetSer.TabIndex = 24
        btnRetSer.Text = "Retirar Servicio"
        btnRetSer.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label5.Location = New Point(29, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 33)
        Label5.TabIndex = 0
        Label5.Text = "Vender"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(26, 407)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 16)
        Label3.TabIndex = 4
        Label3.Text = "Servicio*"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(26, 450)
        Label4.Name = "Label4"
        Label4.Size = New Size(146, 16)
        Label4.TabIndex = 6
        Label4.Text = "Cantidad de Personas*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(29, 495)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 16)
        Label6.TabIndex = 8
        Label6.Text = "Fecha*"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(184, 495)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 16)
        Label2.TabIndex = 11
        Label2.Text = "Hora"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(30, 549)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 16)
        Label1.TabIndex = 14
        Label1.Text = "Notas"
        ' 
        ' btnFinCom
        ' 
        btnFinCom.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnFinCom.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnFinCom.FlatAppearance.BorderSize = 0
        btnFinCom.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnFinCom.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnFinCom.FlatStyle = FlatStyle.Flat
        btnFinCom.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFinCom.ForeColor = Color.WhiteSmoke
        btnFinCom.Image = My.Resources.Resources.icons8_agregar_a_carrito_de_compras_24
        btnFinCom.ImageAlign = ContentAlignment.MiddleLeft
        btnFinCom.Location = New Point(252, 49)
        btnFinCom.Name = "btnFinCom"
        btnFinCom.Size = New Size(224, 31)
        btnFinCom.TabIndex = 3
        btnFinCom.Text = "Finalizar Venta"
        btnFinCom.UseVisualStyleBackColor = False
        ' 
        ' dgvVender
        ' 
        dgvVender.AllowUserToAddRows = False
        dgvVender.AllowUserToDeleteRows = False
        dgvVender.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvVender.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvVender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVender.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvVender.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvVender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVender.Columns.AddRange(New DataGridViewColumn() {cCliente, cServicio, cCanPersonas, cFecha, cHora, cMonto, cMonServ, cNotas, cValorOp, cAclaracion, cTotal, codserv, numero, horaform, fechaform, llevaopera})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvVender.DefaultCellStyle = DataGridViewCellStyle3
        dgvVender.Location = New Point(22, 86)
        dgvVender.Name = "dgvVender"
        dgvVender.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvVender.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvVender.RowHeadersVisible = False
        dgvVender.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVender.Size = New Size(1587, 883)
        dgvVender.TabIndex = 4
        ' 
        ' cCliente
        ' 
        cCliente.HeaderText = "Cliente"
        cCliente.Name = "cCliente"
        cCliente.ReadOnly = True
        ' 
        ' cServicio
        ' 
        cServicio.HeaderText = "Servicio"
        cServicio.Name = "cServicio"
        cServicio.ReadOnly = True
        ' 
        ' cCanPersonas
        ' 
        cCanPersonas.HeaderText = "Cantidad"
        cCanPersonas.Name = "cCanPersonas"
        cCanPersonas.ReadOnly = True
        ' 
        ' cFecha
        ' 
        cFecha.HeaderText = "Fecha"
        cFecha.Name = "cFecha"
        cFecha.ReadOnly = True
        ' 
        ' cHora
        ' 
        cHora.HeaderText = "Hora"
        cHora.Name = "cHora"
        cHora.ReadOnly = True
        ' 
        ' cMonto
        ' 
        cMonto.HeaderText = "Precio Unitario"
        cMonto.Name = "cMonto"
        cMonto.ReadOnly = True
        ' 
        ' cMonServ
        ' 
        cMonServ.HeaderText = "Precio Servicios"
        cMonServ.Name = "cMonServ"
        cMonServ.ReadOnly = True
        ' 
        ' cNotas
        ' 
        cNotas.HeaderText = "Notas"
        cNotas.Name = "cNotas"
        cNotas.ReadOnly = True
        ' 
        ' cValorOp
        ' 
        cValorOp.HeaderText = "Precio Operación"
        cValorOp.Name = "cValorOp"
        cValorOp.ReadOnly = True
        ' 
        ' cAclaracion
        ' 
        cAclaracion.HeaderText = "Aclaración"
        cAclaracion.Name = "cAclaracion"
        cAclaracion.ReadOnly = True
        ' 
        ' cTotal
        ' 
        cTotal.HeaderText = "Total"
        cTotal.Name = "cTotal"
        cTotal.ReadOnly = True
        ' 
        ' codserv
        ' 
        codserv.HeaderText = "codserv"
        codserv.Name = "codserv"
        codserv.ReadOnly = True
        codserv.Visible = False
        ' 
        ' numero
        ' 
        numero.HeaderText = "numero"
        numero.Name = "numero"
        numero.ReadOnly = True
        numero.Visible = False
        ' 
        ' horaform
        ' 
        horaform.HeaderText = "horaform"
        horaform.Name = "horaform"
        horaform.ReadOnly = True
        horaform.Visible = False
        ' 
        ' fechaform
        ' 
        fechaform.HeaderText = "fechaform"
        fechaform.Name = "fechaform"
        fechaform.ReadOnly = True
        fechaform.Visible = False
        ' 
        ' llevaopera
        ' 
        llevaopera.HeaderText = "llevaopera"
        llevaopera.Name = "llevaopera"
        llevaopera.ReadOnly = True
        llevaopera.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(15, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(169, 24)
        Label7.TabIndex = 1
        Label7.Text = "Servicios a Vender"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.WhiteSmoke
        btnCancel.Image = My.Resources.Resources.icons8_reiniciar_24
        btnCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnCancel.Location = New Point(22, 49)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(224, 31)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Reiniciar Venta"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' pnlDGVVender
        ' 
        pnlDGVVender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVVender.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVVender.Controls.Add(Label17)
        pnlDGVVender.Controls.Add(Label16)
        pnlDGVVender.Controls.Add(Label15)
        pnlDGVVender.Controls.Add(Label14)
        pnlDGVVender.Controls.Add(txtDolar)
        pnlDGVVender.Controls.Add(txtEuro)
        pnlDGVVender.Controls.Add(txtReal)
        pnlDGVVender.Controls.Add(Button1)
        pnlDGVVender.Controls.Add(txtTotal)
        pnlDGVVender.Controls.Add(Label11)
        pnlDGVVender.Controls.Add(btnFinCom)
        pnlDGVVender.Controls.Add(btnCancel)
        pnlDGVVender.Controls.Add(dgvVender)
        pnlDGVVender.Controls.Add(Label7)
        pnlDGVVender.Location = New Point(280, 0)
        pnlDGVVender.Name = "pnlDGVVender"
        pnlDGVVender.Size = New Size(1624, 1041)
        pnlDGVVender.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label17.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label17.Location = New Point(1145, 1017)
        Label17.Name = "Label17"
        Label17.Size = New Size(104, 16)
        Label17.TabIndex = 54
        Label17.Text = "En Pesos (ARS)"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label16.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label16.Location = New Point(935, 982)
        Label16.Name = "Label16"
        Label16.Size = New Size(103, 16)
        Label16.TabIndex = 53
        Label16.Text = "Total en Reales"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label15.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label15.Location = New Point(758, 982)
        Label15.Name = "Label15"
        Label15.Size = New Size(94, 16)
        Label15.TabIndex = 52
        Label15.Text = "Total en Euros"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label14.Location = New Point(581, 982)
        Label14.Name = "Label14"
        Label14.Size = New Size(147, 16)
        Label14.TabIndex = 50
        Label14.Text = "Total en Dólares (USD)"
        ' 
        ' txtDolar
        ' 
        txtDolar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtDolar.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtDolar.BorderStyle = BorderStyle.None
        txtDolar.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDolar.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtDolar.Location = New Point(581, 1001)
        txtDolar.MaxLength = 2
        txtDolar.Name = "txtDolar"
        txtDolar.ReadOnly = True
        txtDolar.Size = New Size(171, 28)
        txtDolar.TabIndex = 51
        txtDolar.Tag = "Cantidad de Personas"
        ' 
        ' txtEuro
        ' 
        txtEuro.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtEuro.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtEuro.BorderStyle = BorderStyle.None
        txtEuro.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEuro.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtEuro.Location = New Point(758, 1001)
        txtEuro.MaxLength = 2
        txtEuro.Name = "txtEuro"
        txtEuro.ReadOnly = True
        txtEuro.Size = New Size(171, 28)
        txtEuro.TabIndex = 50
        txtEuro.Tag = "Cantidad de Personas"
        ' 
        ' txtReal
        ' 
        txtReal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtReal.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtReal.BorderStyle = BorderStyle.None
        txtReal.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReal.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtReal.Location = New Point(935, 1001)
        txtReal.MaxLength = 100
        txtReal.Name = "txtReal"
        txtReal.ReadOnly = True
        txtReal.Size = New Size(171, 28)
        txtReal.TabIndex = 50
        txtReal.Tag = "Cliente"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Image = My.Resources.Resources.icons8_cancelar_241
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1385, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 31)
        Button1.TabIndex = 6
        Button1.Text = "Cancelar Venta"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtTotal.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtTotal.BorderStyle = BorderStyle.None
        txtTotal.Font = New Font("Segoe UI", 33.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotal.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtTotal.Location = New Point(1277, 974)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(330, 60)
        txtTotal.TabIndex = 5
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label11.Location = New Point(1130, 975)
        Label11.Name = "Label11"
        Label11.Size = New Size(139, 42)
        Label11.TabIndex = 0
        Label11.Text = "TOTAL"
        ' 
        ' pnlAgrSer
        ' 
        pnlAgrSer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlAgrSer.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlAgrSer.Controls.Add(pnlDGVServ)
        pnlAgrSer.Location = New Point(277, 0)
        pnlAgrSer.Name = "pnlAgrSer"
        pnlAgrSer.Size = New Size(516, 1041)
        pnlAgrSer.TabIndex = 2
        pnlAgrSer.Visible = False
        ' 
        ' pnlDGVServ
        ' 
        pnlDGVServ.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVServ.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlDGVServ.Controls.Add(Label9)
        pnlDGVServ.Controls.Add(dgvServVen)
        pnlDGVServ.Controls.Add(txtBusSer)
        pnlDGVServ.Location = New Point(3, 0)
        pnlDGVServ.Name = "pnlDGVServ"
        pnlDGVServ.Size = New Size(510, 1041)
        pnlDGVServ.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Label9.Location = New Point(15, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(155, 24)
        Label9.TabIndex = 0
        Label9.Text = "Lista de Servicios"
        ' 
        ' dgvServVen
        ' 
        dgvServVen.AllowUserToAddRows = False
        dgvServVen.AllowUserToDeleteRows = False
        dgvServVen.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        dgvServVen.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvServVen.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvServVen.BackgroundColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvServVen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvServVen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(157), CByte(186), CByte(230))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvServVen.DefaultCellStyle = DataGridViewCellStyle7
        dgvServVen.Location = New Point(15, 86)
        dgvServVen.Name = "dgvServVen"
        dgvServVen.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvServVen.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvServVen.RowHeadersVisible = False
        dgvServVen.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvServVen.Size = New Size(479, 943)
        dgvServVen.TabIndex = 2
        ' 
        ' txtBusSer
        ' 
        txtBusSer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtBusSer.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        txtBusSer.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusSer.ForeColor = SystemColors.WindowFrame
        txtBusSer.Location = New Point(15, 58)
        txtBusSer.MaxLength = 50
        txtBusSer.Name = "txtBusSer"
        txtBusSer.Size = New Size(479, 22)
        txtBusSer.TabIndex = 1
        txtBusSer.Text = "Buscar Servicios"
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmAgrVent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlAgrSer)
        Controls.Add(pnlDGVVender)
        Controls.Add(pnlDatVender)
        Name = "frmAgrVent"
        Text = "frmAgrVent"
        pnlDatVender.ResumeLayout(False)
        pnlDatVender.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvVender, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVVender.ResumeLayout(False)
        pnlDGVVender.PerformLayout()
        pnlAgrSer.ResumeLayout(False)
        pnlDGVServ.ResumeLayout(False)
        pnlDGVServ.PerformLayout()
        CType(dgvServVen, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatVender As Panel
    Friend WithEvents txtServ As TextBox
    Friend WithEvents txtCantPer As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents btnAgrSer As Button
    Friend WithEvents btnRetSer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCli As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnFinCom As Button
    Friend WithEvents dgvVender As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlDGVVender As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSelSer As Button
    Friend WithEvents pnlAgrSer As Panel
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents dgvServVen As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBusSer As TextBox
    Friend WithEvents pnlDGVServ As Panel
    Friend WithEvents txtOpMont As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAcla As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cCliente As DataGridViewTextBoxColumn
    Friend WithEvents cServicio As DataGridViewTextBoxColumn
    Friend WithEvents cCanPersonas As DataGridViewTextBoxColumn
    Friend WithEvents cFecha As DataGridViewTextBoxColumn
    Friend WithEvents cHora As DataGridViewTextBoxColumn
    Friend WithEvents cMonto As DataGridViewTextBoxColumn
    Friend WithEvents cMonServ As DataGridViewTextBoxColumn
    Friend WithEvents cNotas As DataGridViewTextBoxColumn
    Friend WithEvents cValorOp As DataGridViewTextBoxColumn
    Friend WithEvents cAclaracion As DataGridViewTextBoxColumn
    Friend WithEvents cTotal As DataGridViewTextBoxColumn
    Friend WithEvents codserv As DataGridViewTextBoxColumn
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents horaform As DataGridViewTextBoxColumn
    Friend WithEvents fechaform As DataGridViewTextBoxColumn
    Friend WithEvents llevaopera As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents ckbActHora As CheckBox
    Friend WithEvents ckbActFecha As CheckBox
    Friend WithEvents ckbActOp As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDolar As TextBox
    Friend WithEvents txtEuro As TextBox
    Friend WithEvents txtReal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
End Class
