<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        pnlDatVent = New Panel()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        btnNuevo = New Button()
        txtDNI = New TextBox()
        txtNom = New TextBox()
        btnResEli = New Button()
        btnModVent = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        pnlDGVVent = New Panel()
        pnlDespDGV = New Panel()
        dgvPanelDesp = New DataGridView()
        pnlBusxFecha = New Panel()
        Panel1 = New Panel()
        Label21 = New Label()
        Label14 = New Label()
        cmbAnho = New ComboBox()
        Label16 = New Label()
        ckbActHasta = New CheckBox()
        Label15 = New Label()
        cmbMes = New ComboBox()
        btnBusxDia = New Button()
        Label17 = New Label()
        cmbDia = New ComboBox()
        Label18 = New Label()
        cmbMesH = New ComboBox()
        cmbAnhoH = New ComboBox()
        cmbDiaH = New ComboBox()
        Label19 = New Label()
        Label20 = New Label()
        btnBusxFecha = New Button()
        CheckBox1 = New CheckBox()
        btnImpr = New Button()
        Label7 = New Label()
        rbVentAct = New RadioButton()
        rbVentCan = New RadioButton()
        txtBusVent = New TextBox()
        dgvVentas = New DataGridView()
        ep = New ErrorProvider(components)
        cmsVenta = New ContextMenuStrip(components)
        DeshabilitarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        DetalleToolStripMenuItem = New ToolStripMenuItem()
        ImprimirComprobanteToolStripMenuItem = New ToolStripMenuItem()
        pnlDatVent.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVVent.SuspendLayout()
        pnlDespDGV.SuspendLayout()
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlBusxFecha.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvVentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        cmsVenta.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDatVent
        ' 
        pnlDatVent.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatVent.Controls.Add(PictureBox1)
        pnlDatVent.Controls.Add(Button1)
        pnlDatVent.Controls.Add(btnNuevo)
        pnlDatVent.Controls.Add(txtDNI)
        pnlDatVent.Controls.Add(txtNom)
        pnlDatVent.Controls.Add(btnResEli)
        pnlDatVent.Controls.Add(btnModVent)
        pnlDatVent.Controls.Add(Label5)
        pnlDatVent.Controls.Add(Label3)
        pnlDatVent.Controls.Add(Label4)
        pnlDatVent.Dock = DockStyle.Left
        pnlDatVent.Location = New Point(0, 0)
        pnlDatVent.Name = "pnlDatVent"
        pnlDatVent.Size = New Size(277, 1041)
        pnlDatVent.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_ventas_100__2_
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 52
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom
        Button1.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.icons8_agregar_a_carrito_de_compras_244
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(25, 993)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 36)
        Button1.TabIndex = 51
        Button1.Text = "Iniciar una Venta"
        Button1.UseVisualStyleBackColor = False
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
        btnNuevo.Image = My.Resources.Resources.icons8_cancelar_nuevo_301
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(136, 374)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "Cancelar"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtDNI
        ' 
        txtDNI.Anchor = AnchorStyles.None
        txtDNI.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtDNI.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDNI.Location = New Point(28, 414)
        txtDNI.MaxLength = 10
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(224, 22)
        txtDNI.TabIndex = 3
        txtDNI.Tag = "DNI"
        ' 
        ' txtNom
        ' 
        txtNom.Anchor = AnchorStyles.None
        txtNom.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNom.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNom.Location = New Point(28, 458)
        txtNom.MaxLength = 50
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(224, 22)
        txtNom.TabIndex = 5
        txtNom.Tag = "Nombre"
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
        btnResEli.Location = New Point(29, 517)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 6
        btnResEli.Text = "Cancelar"
        btnResEli.UseVisualStyleBackColor = False
        ' 
        ' btnModVent
        ' 
        btnModVent.Anchor = AnchorStyles.None
        btnModVent.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnModVent.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnModVent.FlatAppearance.BorderSize = 0
        btnModVent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnModVent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnModVent.FlatStyle = FlatStyle.Flat
        btnModVent.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModVent.ForeColor = Color.WhiteSmoke
        btnModVent.Image = My.Resources.Resources.icons8_carrito_de_compras_242
        btnModVent.ImageAlign = ContentAlignment.MiddleLeft
        btnModVent.Location = New Point(29, 554)
        btnModVent.Name = "btnModVent"
        btnModVent.Size = New Size(224, 55)
        btnModVent.TabIndex = 7
        btnModVent.Text = "Ver Detalles"
        btnModVent.UseVisualStyleBackColor = False
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
        Label5.Size = New Size(111, 33)
        Label5.TabIndex = 0
        Label5.Text = "Ventas"
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
        Label3.Size = New Size(96, 16)
        Label3.TabIndex = 2
        Label3.Text = "DNI del Cliente"
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
        Label4.Size = New Size(122, 16)
        Label4.TabIndex = 4
        Label4.Text = "Nombre del Cliente"
        ' 
        ' pnlDGVVent
        ' 
        pnlDGVVent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVVent.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVVent.Controls.Add(pnlDespDGV)
        pnlDGVVent.Controls.Add(pnlBusxFecha)
        pnlDGVVent.Controls.Add(btnBusxFecha)
        pnlDGVVent.Controls.Add(CheckBox1)
        pnlDGVVent.Controls.Add(btnImpr)
        pnlDGVVent.Controls.Add(Label7)
        pnlDGVVent.Controls.Add(rbVentAct)
        pnlDGVVent.Controls.Add(rbVentCan)
        pnlDGVVent.Controls.Add(txtBusVent)
        pnlDGVVent.Controls.Add(dgvVentas)
        pnlDGVVent.ImeMode = ImeMode.Off
        pnlDGVVent.Location = New Point(279, 0)
        pnlDGVVent.Name = "pnlDGVVent"
        pnlDGVVent.Size = New Size(1625, 1041)
        pnlDGVVent.TabIndex = 1
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
        pnlBusxFecha.Size = New Size(276, 268)
        pnlBusxFecha.TabIndex = 23
        pnlBusxFecha.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(cmbAnho)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(ckbActHasta)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(cmbMes)
        Panel1.Controls.Add(btnBusxDia)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(cmbDia)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(cmbMesH)
        Panel1.Controls.Add(cmbAnhoH)
        Panel1.Controls.Add(cmbDiaH)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label20)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 262)
        Panel1.TabIndex = 16
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label21.Location = New Point(53, 115)
        Label21.Name = "Label21"
        Label21.Size = New Size(46, 16)
        Label21.TabIndex = 32
        Label21.Text = "Hasta:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label14.Location = New Point(13, 11)
        Label14.Name = "Label14"
        Label14.Size = New Size(181, 25)
        Label14.TabIndex = 24
        Label14.Text = "Buscar por fecha:"
        ' 
        ' cmbAnho
        ' 
        cmbAnho.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAnho.FormattingEnabled = True
        cmbAnho.Items.AddRange(New Object() {"----", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        cmbAnho.Location = New Point(22, 75)
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
        Label16.Location = New Point(185, 57)
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
        ckbActHasta.Location = New Point(19, 107)
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
        Label15.Location = New Point(105, 57)
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
        cmbMes.Location = New Point(105, 75)
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
        btnBusxDia.Location = New Point(22, 205)
        btnBusxDia.Name = "btnBusxDia"
        btnBusxDia.Size = New Size(228, 31)
        btnBusxDia.TabIndex = 39
        btnBusxDia.Text = "   Búsqueda Avanzada"
        btnBusxDia.UseVisualStyleBackColor = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label17.Location = New Point(19, 57)
        Label17.Name = "Label17"
        Label17.Size = New Size(29, 15)
        Label17.TabIndex = 25
        Label17.Text = "Año"
        ' 
        ' cmbDia
        ' 
        cmbDia.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDia.Enabled = False
        cmbDia.FormattingEnabled = True
        cmbDia.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        cmbDia.Location = New Point(185, 75)
        cmbDia.MaxDropDownItems = 5
        cmbDia.Name = "cmbDia"
        cmbDia.Size = New Size(65, 23)
        cmbDia.TabIndex = 30
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label18.Location = New Point(19, 145)
        Label18.Name = "Label18"
        Label18.Size = New Size(29, 15)
        Label18.TabIndex = 33
        Label18.Text = "Año"
        ' 
        ' cmbMesH
        ' 
        cmbMesH.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMesH.Enabled = False
        cmbMesH.FormattingEnabled = True
        cmbMesH.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        cmbMesH.Location = New Point(105, 163)
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
        cmbAnhoH.Location = New Point(22, 163)
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
        cmbDiaH.Location = New Point(185, 163)
        cmbDiaH.MaxDropDownItems = 5
        cmbDiaH.Name = "cmbDiaH"
        cmbDiaH.Size = New Size(65, 23)
        cmbDiaH.TabIndex = 38
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label19.Location = New Point(105, 145)
        Label19.Name = "Label19"
        Label19.Size = New Size(29, 15)
        Label19.TabIndex = 35
        Label19.Text = "Mes"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label20.Location = New Point(185, 145)
        Label20.Name = "Label20"
        Label20.Size = New Size(24, 15)
        Label20.TabIndex = 37
        Label20.Text = "Día"
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
        btnBusxFecha.TabIndex = 22
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
        CheckBox1.Location = New Point(162, 7)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(201, 30)
        CheckBox1.TabIndex = 21
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 24)
        Label7.TabIndex = 0
        Label7.Text = "Lista de Ventas"
        ' 
        ' rbVentAct
        ' 
        rbVentAct.Appearance = Appearance.Button
        rbVentAct.AutoSize = True
        rbVentAct.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVentAct.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbVentAct.FlatAppearance.BorderSize = 0
        rbVentAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVentAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVentAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVentAct.FlatStyle = FlatStyle.Flat
        rbVentAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbVentAct.ForeColor = Color.White
        rbVentAct.Image = My.Resources.Resources.icons8_ventas_242
        rbVentAct.ImageAlign = ContentAlignment.MiddleLeft
        rbVentAct.Location = New Point(19, 52)
        rbVentAct.Name = "rbVentAct"
        rbVentAct.Size = New Size(107, 30)
        rbVentAct.TabIndex = 1
        rbVentAct.TabStop = True
        rbVentAct.Text = "       Activas     "
        rbVentAct.TextAlign = ContentAlignment.MiddleRight
        rbVentAct.UseVisualStyleBackColor = False
        ' 
        ' rbVentCan
        ' 
        rbVentCan.Appearance = Appearance.Button
        rbVentCan.AutoSize = True
        rbVentCan.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVentCan.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbVentCan.FlatAppearance.BorderSize = 0
        rbVentCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVentCan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVentCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVentCan.FlatStyle = FlatStyle.Flat
        rbVentCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbVentCan.ForeColor = Color.White
        rbVentCan.Image = My.Resources.Resources.icons8_ventas_menos_24
        rbVentCan.ImageAlign = ContentAlignment.MiddleLeft
        rbVentCan.Location = New Point(126, 52)
        rbVentCan.Name = "rbVentCan"
        rbVentCan.Size = New Size(107, 30)
        rbVentCan.TabIndex = 2
        rbVentCan.TabStop = True
        rbVentCan.Text = "      Canceladas"
        rbVentCan.TextAlign = ContentAlignment.MiddleRight
        rbVentCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusVent
        ' 
        txtBusVent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusVent.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusVent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusVent.ForeColor = SystemColors.WindowFrame
        txtBusVent.Location = New Point(960, 52)
        txtBusVent.MaxLength = 50
        txtBusVent.Name = "txtBusVent"
        txtBusVent.Size = New Size(427, 22)
        txtBusVent.TabIndex = 3
        txtBusVent.Text = "Buscar"
        ' 
        ' dgvVentas
        ' 
        dgvVentas.AllowUserToAddRows = False
        dgvVentas.AllowUserToDeleteRows = False
        dgvVentas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvVentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvVentas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVentas.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvVentas.DefaultCellStyle = DataGridViewCellStyle7
        dgvVentas.Location = New Point(19, 82)
        dgvVentas.Name = "dgvVentas"
        dgvVentas.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvVentas.RowHeadersVisible = False
        dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVentas.Size = New Size(1587, 947)
        dgvVentas.TabIndex = 4
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' cmsVenta
        ' 
        cmsVenta.Items.AddRange(New ToolStripItem() {DeshabilitarToolStripMenuItem, ModificarToolStripMenuItem, DetalleToolStripMenuItem, ImprimirComprobanteToolStripMenuItem})
        cmsVenta.Name = "cmsChof"
        cmsVenta.Size = New Size(198, 92)
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
        ' frmVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDGVVent)
        Controls.Add(pnlDatVent)
        Name = "frmVentas"
        Text = "frmVentas"
        pnlDatVent.ResumeLayout(False)
        pnlDatVent.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVVent.ResumeLayout(False)
        pnlDGVVent.PerformLayout()
        pnlDespDGV.ResumeLayout(False)
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlBusxFecha.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvVentas, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        cmsVenta.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatVent As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnResEli As Button
    Friend WithEvents btnModVent As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlDGVVent As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbVentAct As RadioButton
    Friend WithEvents rbVentCan As RadioButton
    Friend WithEvents txtBusVent As TextBox
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents btnImpr As Button
    Friend WithEvents cmsVenta As ContextMenuStrip
    Friend WithEvents DeshabilitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirComprobanteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents pnlBusxFecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ckbActHasta As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnBusxDia As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbMesH As ComboBox
    Friend WithEvents cmbAnhoH As ComboBox
    Friend WithEvents cmbDiaH As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnBusxFecha As Button
    Friend WithEvents DetalleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlDespDGV As Panel
    Friend WithEvents dgvPanelDesp As DataGridView
End Class
