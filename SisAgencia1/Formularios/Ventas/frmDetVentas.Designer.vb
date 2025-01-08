<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetVentas))
        pnlDatDetVent = New Panel()
        btnEleServ = New Button()
        btnEleVent = New Button()
        ckbActFecha = New CheckBox()
        ckbActHora = New CheckBox()
        txtNotas = New TextBox()
        dtpHora = New DateTimePicker()
        dtpFecha = New DateTimePicker()
        txtCantPer = New TextBox()
        Label1 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        btnNuevo = New Button()
        txtCodVent = New TextBox()
        txtNomServ = New TextBox()
        txtNomCli = New TextBox()
        btnGuaMod = New Button()
        btnResEli = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        pnlDGVDetVent = New Panel()
        pnlDespDGV = New Panel()
        dgvPanelDesp = New DataGridView()
        pnlBusxFecha = New Panel()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        Label13 = New Label()
        Label9 = New Label()
        cmbAnho = New ComboBox()
        Label16 = New Label()
        ckbActHasta = New CheckBox()
        Label15 = New Label()
        cmbMes = New ComboBox()
        btnBusxDia = New Button()
        Label14 = New Label()
        cmbDia = New ComboBox()
        Label10 = New Label()
        cmbMesH = New ComboBox()
        cmbAnhoH = New ComboBox()
        cmbDiaH = New ComboBox()
        Label12 = New Label()
        Label17 = New Label()
        btnBusxFecha = New Button()
        CheckBox1 = New CheckBox()
        btnImpr = New Button()
        btnBusxVent = New Button()
        Label7 = New Label()
        rbDetVentAct = New RadioButton()
        rbDetVentCan = New RadioButton()
        txtBusDetVent = New TextBox()
        dgvDetVentas = New DataGridView()
        ep = New ErrorProvider(components)
        cmsDetVent = New ContextMenuStrip(components)
        DeshabilitarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        DetalleToolStripMenuItem = New ToolStripMenuItem()
        ImprimirComprobanteToolStripMenuItem = New ToolStripMenuItem()
        pnlDatDetVent.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVDetVent.SuspendLayout()
        pnlDespDGV.SuspendLayout()
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlBusxFecha.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvDetVentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        cmsDetVent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDatDetVent
        ' 
        pnlDatDetVent.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatDetVent.Controls.Add(btnEleServ)
        pnlDatDetVent.Controls.Add(btnEleVent)
        pnlDatDetVent.Controls.Add(ckbActFecha)
        pnlDatDetVent.Controls.Add(ckbActHora)
        pnlDatDetVent.Controls.Add(txtNotas)
        pnlDatDetVent.Controls.Add(dtpHora)
        pnlDatDetVent.Controls.Add(dtpFecha)
        pnlDatDetVent.Controls.Add(txtCantPer)
        pnlDatDetVent.Controls.Add(Label1)
        pnlDatDetVent.Controls.Add(Label6)
        pnlDatDetVent.Controls.Add(Label2)
        pnlDatDetVent.Controls.Add(Label8)
        pnlDatDetVent.Controls.Add(PictureBox1)
        pnlDatDetVent.Controls.Add(btnNuevo)
        pnlDatDetVent.Controls.Add(txtCodVent)
        pnlDatDetVent.Controls.Add(txtNomServ)
        pnlDatDetVent.Controls.Add(txtNomCli)
        pnlDatDetVent.Controls.Add(btnGuaMod)
        pnlDatDetVent.Controls.Add(btnResEli)
        pnlDatDetVent.Controls.Add(Label5)
        pnlDatDetVent.Controls.Add(Label3)
        pnlDatDetVent.Controls.Add(Label4)
        pnlDatDetVent.Controls.Add(label11)
        pnlDatDetVent.Dock = DockStyle.Left
        pnlDatDetVent.Location = New Point(0, 0)
        pnlDatDetVent.Name = "pnlDatDetVent"
        pnlDatDetVent.Size = New Size(277, 1041)
        pnlDatDetVent.TabIndex = 0
        ' 
        ' btnEleServ
        ' 
        btnEleServ.Anchor = AnchorStyles.None
        btnEleServ.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEleServ.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnEleServ.FlatAppearance.BorderSize = 0
        btnEleServ.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEleServ.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnEleServ.FlatStyle = FlatStyle.Flat
        btnEleServ.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEleServ.ForeColor = Color.White
        btnEleServ.Image = My.Resources.Resources.icons8_parque_nacional_242
        btnEleServ.ImageAlign = ContentAlignment.MiddleLeft
        btnEleServ.Location = New Point(26, 729)
        btnEleServ.Name = "btnEleServ"
        btnEleServ.Size = New Size(224, 31)
        btnEleServ.TabIndex = 19
        btnEleServ.Text = "Elegir Servicio"
        btnEleServ.UseVisualStyleBackColor = False
        ' 
        ' btnEleVent
        ' 
        btnEleVent.Anchor = AnchorStyles.None
        btnEleVent.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEleVent.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnEleVent.FlatAppearance.BorderSize = 0
        btnEleVent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEleVent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnEleVent.FlatStyle = FlatStyle.Flat
        btnEleVent.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEleVent.ForeColor = Color.White
        btnEleVent.Image = My.Resources.Resources.icons8_ventas_241
        btnEleVent.ImageAlign = ContentAlignment.MiddleLeft
        btnEleVent.Location = New Point(26, 766)
        btnEleVent.Name = "btnEleVent"
        btnEleVent.Size = New Size(224, 31)
        btnEleVent.TabIndex = 20
        btnEleVent.Text = "Elegir Venta"
        btnEleVent.UseVisualStyleBackColor = False
        ' 
        ' ckbActFecha
        ' 
        ckbActFecha.Anchor = AnchorStyles.None
        ckbActFecha.Appearance = Appearance.Button
        ckbActFecha.AutoSize = True
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
        ckbActFecha.Location = New Point(115, 876)
        ckbActFecha.Name = "ckbActFecha"
        ckbActFecha.Size = New Size(35, 30)
        ckbActFecha.TabIndex = 11
        ckbActFecha.Text = "    "
        ckbActFecha.UseVisualStyleBackColor = True
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
        ckbActHora.Location = New Point(148, 588)
        ckbActHora.Name = "ckbActHora"
        ckbActHora.Size = New Size(35, 30)
        ckbActHora.TabIndex = 14
        ckbActHora.Text = "    "
        ckbActHora.UseVisualStyleBackColor = False
        ' 
        ' txtNotas
        ' 
        txtNotas.Anchor = AnchorStyles.None
        txtNotas.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNotas.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNotas.Location = New Point(28, 645)
        txtNotas.MaxLength = 200
        txtNotas.Multiline = True
        txtNotas.Name = "txtNotas"
        txtNotas.Size = New Size(224, 22)
        txtNotas.TabIndex = 17
        txtNotas.Tag = "Observación"
        ' 
        ' dtpHora
        ' 
        dtpHora.Anchor = AnchorStyles.None
        dtpHora.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpHora.Enabled = False
        dtpHora.Format = DateTimePickerFormat.Time
        dtpHora.Location = New Point(186, 591)
        dtpHora.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        dtpHora.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        dtpHora.Name = "dtpHora"
        dtpHora.Size = New Size(65, 23)
        dtpHora.TabIndex = 15
        dtpHora.Value = New Date(2024, 5, 3, 20, 10, 35, 0)
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Anchor = AnchorStyles.None
        dtpFecha.CalendarFont = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpFecha.Enabled = False
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(28, 591)
        dtpFecha.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        dtpFecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(102, 23)
        dtpFecha.TabIndex = 12
        dtpFecha.Value = New Date(2024, 5, 3, 20, 10, 31, 0)
        ' 
        ' txtCantPer
        ' 
        txtCantPer.Anchor = AnchorStyles.None
        txtCantPer.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCantPer.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCantPer.Location = New Point(28, 546)
        txtCantPer.MaxLength = 2
        txtCantPer.Name = "txtCantPer"
        txtCantPer.Size = New Size(224, 22)
        txtCantPer.TabIndex = 9
        txtCantPer.Tag = "Cantidad de Personas"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(28, 527)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 16)
        Label1.TabIndex = 8
        Label1.Text = "Cantidad de Personas*"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(28, 572)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 16)
        Label6.TabIndex = 10
        Label6.Text = "Fecha*"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(186, 572)
        Label2.Name = "Label2"
        Label2.Size = New Size(37, 16)
        Label2.TabIndex = 13
        Label2.Text = "Hora"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label8.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label8.Location = New Point(32, 626)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 16)
        Label8.TabIndex = 16
        Label8.Text = "Observación"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_ventas_100__1___1_
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.None
        btnNuevo.BackColor = Color.Transparent
        btnNuevo.FlatAppearance.BorderColor = Color.SlateGray
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnNuevo.Image = My.Resources.Resources.icons8_más_nuevo_241
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(136, 374)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "   Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtCodVent
        ' 
        txtCodVent.Anchor = AnchorStyles.None
        txtCodVent.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCodVent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCodVent.Location = New Point(28, 414)
        txtCodVent.MaxLength = 10
        txtCodVent.Name = "txtCodVent"
        txtCodVent.Size = New Size(224, 22)
        txtCodVent.TabIndex = 3
        txtCodVent.Tag = "Venta"
        txtCodVent.Text = "Seleccione una venta."
        ' 
        ' txtNomServ
        ' 
        txtNomServ.Anchor = AnchorStyles.None
        txtNomServ.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNomServ.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNomServ.Location = New Point(28, 458)
        txtNomServ.MaxLength = 50
        txtNomServ.Name = "txtNomServ"
        txtNomServ.Size = New Size(224, 22)
        txtNomServ.TabIndex = 5
        txtNomServ.Tag = "Servicio"
        txtNomServ.Text = "Seleccione un servicio."
        ' 
        ' txtNomCli
        ' 
        txtNomCli.Anchor = AnchorStyles.None
        txtNomCli.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNomCli.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNomCli.Location = New Point(28, 502)
        txtNomCli.MaxLength = 50
        txtNomCli.Name = "txtNomCli"
        txtNomCli.Size = New Size(224, 22)
        txtNomCli.TabIndex = 7
        txtNomCli.Tag = "Nombre del Cliente"
        ' 
        ' btnGuaMod
        ' 
        btnGuaMod.Anchor = AnchorStyles.None
        btnGuaMod.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnGuaMod.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnGuaMod.FlatAppearance.BorderSize = 0
        btnGuaMod.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnGuaMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnGuaMod.FlatStyle = FlatStyle.Flat
        btnGuaMod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuaMod.ForeColor = Color.White
        btnGuaMod.Image = My.Resources.Resources.icons8_botón_guardar_24
        btnGuaMod.ImageAlign = ContentAlignment.MiddleLeft
        btnGuaMod.Location = New Point(28, 692)
        btnGuaMod.Name = "btnGuaMod"
        btnGuaMod.Size = New Size(224, 31)
        btnGuaMod.TabIndex = 18
        btnGuaMod.Text = "Guardar"
        btnGuaMod.UseVisualStyleBackColor = False
        ' 
        ' btnResEli
        ' 
        btnResEli.Anchor = AnchorStyles.None
        btnResEli.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnResEli.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnResEli.FlatAppearance.BorderSize = 0
        btnResEli.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnResEli.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnResEli.FlatStyle = FlatStyle.Flat
        btnResEli.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnResEli.ForeColor = Color.White
        btnResEli.Image = My.Resources.Resources.icons8_eliminar_24
        btnResEli.ImageAlign = ContentAlignment.MiddleLeft
        btnResEli.Location = New Point(26, 803)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 21
        btnResEli.Text = "Cancelar"
        btnResEli.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label5.Location = New Point(28, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 33)
        Label5.TabIndex = 0
        Label5.Text = "Serv. Vendidos"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(28, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 16)
        Label3.TabIndex = 2
        Label3.Text = "Código de Venta*"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(28, 439)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 16)
        Label4.TabIndex = 4
        Label4.Text = "Servicio*"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.BackColor = Color.Transparent
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        label11.Location = New Point(28, 483)
        label11.Name = "label11"
        label11.Size = New Size(122, 16)
        label11.TabIndex = 6
        label11.Text = "Nombre del Cliente"
        ' 
        ' pnlDGVDetVent
        ' 
        pnlDGVDetVent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVDetVent.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVDetVent.Controls.Add(pnlDespDGV)
        pnlDGVDetVent.Controls.Add(pnlBusxFecha)
        pnlDGVDetVent.Controls.Add(btnBusxFecha)
        pnlDGVDetVent.Controls.Add(CheckBox1)
        pnlDGVDetVent.Controls.Add(btnImpr)
        pnlDGVDetVent.Controls.Add(btnBusxVent)
        pnlDGVDetVent.Controls.Add(Label7)
        pnlDGVDetVent.Controls.Add(rbDetVentAct)
        pnlDGVDetVent.Controls.Add(rbDetVentCan)
        pnlDGVDetVent.Controls.Add(txtBusDetVent)
        pnlDGVDetVent.Controls.Add(dgvDetVentas)
        pnlDGVDetVent.ImeMode = ImeMode.Off
        pnlDGVDetVent.Location = New Point(279, 0)
        pnlDGVDetVent.Name = "pnlDGVDetVent"
        pnlDGVDetVent.Size = New Size(1625, 1041)
        pnlDGVDetVent.TabIndex = 1
        ' 
        ' pnlDespDGV
        ' 
        pnlDespDGV.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlDespDGV.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        pnlDespDGV.Controls.Add(dgvPanelDesp)
        pnlDespDGV.Location = New Point(19, 391)
        pnlDespDGV.Name = "pnlDespDGV"
        pnlDespDGV.Size = New Size(1587, 259)
        pnlDespDGV.TabIndex = 25
        pnlDespDGV.Visible = False
        ' 
        ' dgvPanelDesp
        ' 
        dgvPanelDesp.AllowUserToAddRows = False
        dgvPanelDesp.AllowUserToDeleteRows = False
        dgvPanelDesp.AllowUserToResizeColumns = False
        dgvPanelDesp.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvPanelDesp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvPanelDesp.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPanelDesp.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvPanelDesp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvPanelDesp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvPanelDesp.DefaultCellStyle = DataGridViewCellStyle3
        dgvPanelDesp.Location = New Point(3, 3)
        dgvPanelDesp.Name = "dgvPanelDesp"
        dgvPanelDesp.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvPanelDesp.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvPanelDesp.RowHeadersVisible = False
        dgvPanelDesp.ScrollBars = ScrollBars.None
        dgvPanelDesp.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPanelDesp.Size = New Size(1581, 253)
        dgvPanelDesp.TabIndex = 17
        ' 
        ' pnlBusxFecha
        ' 
        pnlBusxFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlBusxFecha.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlBusxFecha.Controls.Add(Panel1)
        pnlBusxFecha.Location = New Point(1330, 82)
        pnlBusxFecha.Name = "pnlBusxFecha"
        pnlBusxFecha.Size = New Size(276, 330)
        pnlBusxFecha.TabIndex = 22
        pnlBusxFecha.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(cmbAnho)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(ckbActHasta)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(cmbMes)
        Panel1.Controls.Add(btnBusxDia)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(cmbDia)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(cmbMesH)
        Panel1.Controls.Add(cmbAnhoH)
        Panel1.Controls.Add(cmbDiaH)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label17)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 324)
        Panel1.TabIndex = 16
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Appearance = Appearance.Button
        CheckBox3.AutoSize = True
        CheckBox3.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox3.FlatAppearance.BorderSize = 0
        CheckBox3.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox3.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox3.FlatStyle = FlatStyle.Flat
        CheckBox3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox3.Image = My.Resources.Resources.icons8_tickc_no_24
        CheckBox3.ImageAlign = ContentAlignment.MiddleLeft
        CheckBox3.Location = New Point(13, 79)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(122, 30)
        CheckBox3.TabIndex = 41
        CheckBox3.Text = "       De Servicio"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Appearance = Appearance.Button
        CheckBox2.AutoSize = True
        CheckBox2.Checked = True
        CheckBox2.CheckState = CheckState.Checked
        CheckBox2.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox2.FlatAppearance.BorderSize = 0
        CheckBox2.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox2.FlatStyle = FlatStyle.Flat
        CheckBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox2.Image = My.Resources.Resources.icons8_tickc_24
        CheckBox2.ImageAlign = ContentAlignment.MiddleLeft
        CheckBox2.Location = New Point(13, 43)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(126, 30)
        CheckBox2.TabIndex = 40
        CheckBox2.Text = "       De creación"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label13.Location = New Point(52, 185)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 16)
        Label13.TabIndex = 32
        Label13.Text = "Hasta:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label9.Location = New Point(13, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(181, 25)
        Label9.TabIndex = 24
        Label9.Text = "Buscar por fecha:"
        ' 
        ' cmbAnho
        ' 
        cmbAnho.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAnho.FormattingEnabled = True
        cmbAnho.Items.AddRange(New Object() {"----", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        cmbAnho.Location = New Point(21, 145)
        cmbAnho.MaxDropDownItems = 5
        cmbAnho.Name = "cmbAnho"
        cmbAnho.Size = New Size(65, 23)
        cmbAnho.TabIndex = 26
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label16.Location = New Point(184, 127)
        Label16.Name = "Label16"
        Label16.Size = New Size(24, 15)
        Label16.TabIndex = 29
        Label16.Text = "Día"
        ' 
        ' ckbActHasta
        ' 
        ckbActHasta.Appearance = Appearance.Button
        ckbActHasta.AutoSize = True
        ckbActHasta.BackColor = Color.Transparent
        ckbActHasta.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHasta.FlatAppearance.BorderSize = 0
        ckbActHasta.FlatAppearance.CheckedBackColor = Color.Transparent
        ckbActHasta.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHasta.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        ckbActHasta.FlatStyle = FlatStyle.Flat
        ckbActHasta.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbActHasta.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbActHasta.Image = My.Resources.Resources.icons8_tickc_no_242
        ckbActHasta.ImageAlign = ContentAlignment.MiddleLeft
        ckbActHasta.Location = New Point(18, 177)
        ckbActHasta.Name = "ckbActHasta"
        ckbActHasta.Size = New Size(35, 30)
        ckbActHasta.TabIndex = 31
        ckbActHasta.Text = "    "
        ckbActHasta.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label15.Location = New Point(104, 127)
        Label15.Name = "Label15"
        Label15.Size = New Size(29, 15)
        Label15.TabIndex = 27
        Label15.Text = "Mes"
        ' 
        ' cmbMes
        ' 
        cmbMes.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMes.Enabled = False
        cmbMes.FormattingEnabled = True
        cmbMes.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        cmbMes.Location = New Point(104, 145)
        cmbMes.MaxDropDownItems = 5
        cmbMes.Name = "cmbMes"
        cmbMes.Size = New Size(65, 23)
        cmbMes.TabIndex = 28
        ' 
        ' btnBusxDia
        ' 
        btnBusxDia.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxDia.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnBusxDia.FlatAppearance.BorderSize = 0
        btnBusxDia.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxDia.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnBusxDia.FlatStyle = FlatStyle.Flat
        btnBusxDia.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBusxDia.ForeColor = Color.WhiteSmoke
        btnBusxDia.Image = My.Resources.Resources.icons8_buscar_24
        btnBusxDia.ImageAlign = ContentAlignment.MiddleLeft
        btnBusxDia.Location = New Point(21, 275)
        btnBusxDia.Name = "btnBusxDia"
        btnBusxDia.Size = New Size(228, 31)
        btnBusxDia.TabIndex = 39
        btnBusxDia.Text = "   Búsqueda Avanzada"
        btnBusxDia.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label14.Location = New Point(18, 127)
        Label14.Name = "Label14"
        Label14.Size = New Size(29, 15)
        Label14.TabIndex = 25
        Label14.Text = "Año"
        ' 
        ' cmbDia
        ' 
        cmbDia.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDia.Enabled = False
        cmbDia.FormattingEnabled = True
        cmbDia.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbDia.Location = New Point(184, 145)
        cmbDia.MaxDropDownItems = 5
        cmbDia.Name = "cmbDia"
        cmbDia.Size = New Size(65, 23)
        cmbDia.TabIndex = 30
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label10.Location = New Point(18, 215)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 15)
        Label10.TabIndex = 33
        Label10.Text = "Año"
        ' 
        ' cmbMesH
        ' 
        cmbMesH.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMesH.Enabled = False
        cmbMesH.FormattingEnabled = True
        cmbMesH.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        cmbMesH.Location = New Point(104, 233)
        cmbMesH.MaxDropDownItems = 5
        cmbMesH.Name = "cmbMesH"
        cmbMesH.Size = New Size(65, 23)
        cmbMesH.TabIndex = 36
        ' 
        ' cmbAnhoH
        ' 
        cmbAnhoH.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAnhoH.Enabled = False
        cmbAnhoH.FormattingEnabled = True
        cmbAnhoH.Items.AddRange(New Object() {"----", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        cmbAnhoH.Location = New Point(21, 233)
        cmbAnhoH.MaxDropDownItems = 5
        cmbAnhoH.Name = "cmbAnhoH"
        cmbAnhoH.Size = New Size(65, 23)
        cmbAnhoH.TabIndex = 34
        ' 
        ' cmbDiaH
        ' 
        cmbDiaH.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDiaH.Enabled = False
        cmbDiaH.FormattingEnabled = True
        cmbDiaH.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbDiaH.Location = New Point(184, 233)
        cmbDiaH.MaxDropDownItems = 5
        cmbDiaH.Name = "cmbDiaH"
        cmbDiaH.Size = New Size(65, 23)
        cmbDiaH.TabIndex = 38
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label12.Location = New Point(104, 215)
        Label12.Name = "Label12"
        Label12.Size = New Size(29, 15)
        Label12.TabIndex = 35
        Label12.Text = "Mes"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label17.Location = New Point(184, 215)
        Label17.Name = "Label17"
        Label17.Size = New Size(24, 15)
        Label17.TabIndex = 37
        Label17.Text = "Día"
        ' 
        ' btnBusxFecha
        ' 
        btnBusxFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBusxFecha.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxFecha.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnBusxFecha.FlatAppearance.BorderSize = 0
        btnBusxFecha.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxFecha.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnBusxFecha.FlatStyle = FlatStyle.Flat
        btnBusxFecha.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBusxFecha.ForeColor = Color.White
        btnBusxFecha.Image = My.Resources.Resources.icons8_chevron_abajo_en_círculo_24
        btnBusxFecha.ImageAlign = ContentAlignment.MiddleLeft
        btnBusxFecha.Location = New Point(1393, 52)
        btnBusxFecha.Name = "btnBusxFecha"
        btnBusxFecha.Size = New Size(213, 31)
        btnBusxFecha.TabIndex = 21
        btnBusxFecha.Text = "  Buscar por Fecha"
        btnBusxFecha.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.AutoSize = True
        CheckBox1.FlatAppearance.BorderColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox1.FlatAppearance.BorderSize = 0
        CheckBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox1.Image = My.Resources.Resources.icons8_tickc_no_24
        CheckBox1.ImageAlign = ContentAlignment.MiddleLeft
        CheckBox1.Location = New Point(266, 7)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(201, 30)
        CheckBox1.TabIndex = 20
        CheckBox1.Text = "      Mostrar a partir de hoy"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnImpr
        ' 
        btnImpr.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnImpr.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnImpr.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnImpr.FlatAppearance.BorderSize = 0
        btnImpr.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnImpr.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnImpr.FlatStyle = FlatStyle.Flat
        btnImpr.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnImpr.ForeColor = Color.White
        btnImpr.Image = My.Resources.Resources.icons8_print_24
        btnImpr.ImageAlign = ContentAlignment.MiddleLeft
        btnImpr.Location = New Point(1447, 11)
        btnImpr.Name = "btnImpr"
        btnImpr.Size = New Size(159, 31)
        btnImpr.TabIndex = 15
        btnImpr.Text = "  Imprimir"
        btnImpr.UseVisualStyleBackColor = False
        ' 
        ' btnBusxVent
        ' 
        btnBusxVent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBusxVent.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxVent.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnBusxVent.FlatAppearance.BorderSize = 0
        btnBusxVent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnBusxVent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnBusxVent.FlatStyle = FlatStyle.Flat
        btnBusxVent.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBusxVent.ForeColor = Color.WhiteSmoke
        btnBusxVent.Image = My.Resources.Resources.icons8_buscar_24
        btnBusxVent.ImageAlign = ContentAlignment.MiddleLeft
        btnBusxVent.Location = New Point(1163, 52)
        btnBusxVent.Name = "btnBusxVent"
        btnBusxVent.Size = New Size(224, 31)
        btnBusxVent.TabIndex = 3
        btnBusxVent.Text = "Buscar por Venta"
        btnBusxVent.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(241, 24)
        Label7.TabIndex = 0
        Label7.Text = "Lista de Servicios Vendidos"
        ' 
        ' rbDetVentAct
        ' 
        rbDetVentAct.Appearance = Appearance.Button
        rbDetVentAct.AutoSize = True
        rbDetVentAct.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbDetVentAct.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbDetVentAct.FlatAppearance.BorderSize = 0
        rbDetVentAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbDetVentAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbDetVentAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbDetVentAct.FlatStyle = FlatStyle.Flat
        rbDetVentAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbDetVentAct.ForeColor = Color.White
        rbDetVentAct.Image = My.Resources.Resources.icons8_carrito_de_compras_alta_24
        rbDetVentAct.ImageAlign = ContentAlignment.MiddleLeft
        rbDetVentAct.Location = New Point(19, 52)
        rbDetVentAct.Name = "rbDetVentAct"
        rbDetVentAct.Size = New Size(107, 30)
        rbDetVentAct.TabIndex = 1
        rbDetVentAct.TabStop = True
        rbDetVentAct.Text = "       Activos     "
        rbDetVentAct.TextAlign = ContentAlignment.MiddleRight
        rbDetVentAct.UseVisualStyleBackColor = False
        ' 
        ' rbDetVentCan
        ' 
        rbDetVentCan.Appearance = Appearance.Button
        rbDetVentCan.AutoSize = True
        rbDetVentCan.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbDetVentCan.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbDetVentCan.FlatAppearance.BorderSize = 0
        rbDetVentCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbDetVentCan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbDetVentCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbDetVentCan.FlatStyle = FlatStyle.Flat
        rbDetVentCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbDetVentCan.ForeColor = Color.White
        rbDetVentCan.Image = My.Resources.Resources.icons8_carrito_de_compras_baja_24
        rbDetVentCan.ImageAlign = ContentAlignment.MiddleLeft
        rbDetVentCan.Location = New Point(126, 52)
        rbDetVentCan.Name = "rbDetVentCan"
        rbDetVentCan.Size = New Size(107, 30)
        rbDetVentCan.TabIndex = 2
        rbDetVentCan.TabStop = True
        rbDetVentCan.Text = "      Cancelados"
        rbDetVentCan.TextAlign = ContentAlignment.MiddleRight
        rbDetVentCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusDetVent
        ' 
        txtBusDetVent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusDetVent.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusDetVent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusDetVent.ForeColor = SystemColors.WindowFrame
        txtBusDetVent.Location = New Point(795, 51)
        txtBusDetVent.MaxLength = 50
        txtBusDetVent.Name = "txtBusDetVent"
        txtBusDetVent.Size = New Size(362, 22)
        txtBusDetVent.TabIndex = 4
        txtBusDetVent.Text = "Buscar"
        ' 
        ' dgvDetVentas
        ' 
        dgvDetVentas.AllowUserToAddRows = False
        dgvDetVentas.AllowUserToDeleteRows = False
        dgvDetVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvDetVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvDetVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvDetVentas.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvDetVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvDetVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvDetVentas.DefaultCellStyle = DataGridViewCellStyle7
        dgvDetVentas.Location = New Point(19, 82)
        dgvDetVentas.Name = "dgvDetVentas"
        dgvDetVentas.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvDetVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvDetVentas.RowHeadersVisible = False
        dgvDetVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDetVentas.Size = New Size(1587, 947)
        dgvDetVentas.TabIndex = 5
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' cmsDetVent
        ' 
        cmsDetVent.Items.AddRange(New ToolStripItem() {DeshabilitarToolStripMenuItem, ModificarToolStripMenuItem, DetalleToolStripMenuItem, ImprimirComprobanteToolStripMenuItem})
        cmsDetVent.Name = "cmsChof"
        cmsDetVent.Size = New Size(198, 92)
        ' 
        ' DeshabilitarToolStripMenuItem
        ' 
        DeshabilitarToolStripMenuItem.Name = "DeshabilitarToolStripMenuItem"
        DeshabilitarToolStripMenuItem.Size = New Size(197, 22)
        DeshabilitarToolStripMenuItem.Text = "Cancelar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(197, 22)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' DetalleToolStripMenuItem
        ' 
        DetalleToolStripMenuItem.Name = "DetalleToolStripMenuItem"
        DetalleToolStripMenuItem.Size = New Size(197, 22)
        DetalleToolStripMenuItem.Text = "Detalle"
        ' 
        ' ImprimirComprobanteToolStripMenuItem
        ' 
        ImprimirComprobanteToolStripMenuItem.Name = "ImprimirComprobanteToolStripMenuItem"
        ImprimirComprobanteToolStripMenuItem.Size = New Size(197, 22)
        ImprimirComprobanteToolStripMenuItem.Text = "Imprimir Comprobante"
        ' 
        ' frmDetVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDGVDetVent)
        Controls.Add(pnlDatDetVent)
        Name = "frmDetVentas"
        Text = "frmDetVentas"
        pnlDatDetVent.ResumeLayout(False)
        pnlDatDetVent.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVDetVent.ResumeLayout(False)
        pnlDGVDetVent.PerformLayout()
        pnlDespDGV.ResumeLayout(False)
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlBusxFecha.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvDetVentas, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        cmsDetVent.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatDetVent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtCodVent As TextBox
    Friend WithEvents txtNomServ As TextBox
    Friend WithEvents txtNomCli As TextBox
    Friend WithEvents btnGuaMod As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents pnlDGVDetVent As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbDetVentAct As RadioButton
    Friend WithEvents rbDetVentCan As RadioButton
    Friend WithEvents txtBusDetVent As TextBox
    Friend WithEvents dgvDetVentas As DataGridView
    Friend WithEvents btnBusxVent As Button
    Friend WithEvents ckbActFecha As CheckBox
    Friend WithEvents ckbActHora As CheckBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents dtpHora As DateTimePicker
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtCantPer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnEleServ As Button
    Friend WithEvents btnEleVent As Button
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents btnImpr As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmsDetVent As ContextMenuStrip
    Friend WithEvents DeshabilitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlBusxFecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ckbActHasta As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnBusxDia As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbMesH As ComboBox
    Friend WithEvents cmbAnhoH As ComboBox
    Friend WithEvents cmbDiaH As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnBusxFecha As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents DetalleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlDespDGV As Panel
    Friend WithEvents dgvPanelDesp As DataGridView
End Class
