<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVeh))
        pnlDatVeh = New Panel()
        PictureBox1 = New PictureBox()
        txtChof = New TextBox()
        btnNuevo = New Button()
        txtMatricula = New TextBox()
        txtModel = New TextBox()
        txtCapPasj = New TextBox()
        btnGuaMod = New Button()
        btnResEli = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label1 = New Label()
        btnSelChof = New Button()
        pnlDGVVeh = New Panel()
        pnlDespDGV = New Panel()
        dgvPanelDesp = New DataGridView()
        pnlBusxFecha = New Panel()
        Panel1 = New Panel()
        Label13 = New Label()
        Label6 = New Label()
        cmbAnho = New ComboBox()
        Label16 = New Label()
        ckbActHasta = New CheckBox()
        Label15 = New Label()
        cmbMes = New ComboBox()
        btnBusxDia = New Button()
        Label14 = New Label()
        cmbDia = New ComboBox()
        Label8 = New Label()
        cmbMesH = New ComboBox()
        cmbAnhoH = New ComboBox()
        cmbDiaH = New ComboBox()
        Label10 = New Label()
        Label12 = New Label()
        btnBusxFecha = New Button()
        btnImpr = New Button()
        Label7 = New Label()
        rbVehAct = New RadioButton()
        rbVehCan = New RadioButton()
        txtBusVeh = New TextBox()
        dgvVehiculos = New DataGridView()
        ep = New ErrorProvider(components)
        cmsVeh = New ContextMenuStrip(components)
        DeshabilitarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        DetalleToolStripMenuItem = New ToolStripMenuItem()
        pnlDatVeh.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVVeh.SuspendLayout()
        pnlDespDGV.SuspendLayout()
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlBusxFecha.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvVehiculos, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        cmsVeh.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDatVeh
        ' 
        pnlDatVeh.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatVeh.Controls.Add(PictureBox1)
        pnlDatVeh.Controls.Add(txtChof)
        pnlDatVeh.Controls.Add(btnNuevo)
        pnlDatVeh.Controls.Add(txtMatricula)
        pnlDatVeh.Controls.Add(txtModel)
        pnlDatVeh.Controls.Add(txtCapPasj)
        pnlDatVeh.Controls.Add(btnGuaMod)
        pnlDatVeh.Controls.Add(btnResEli)
        pnlDatVeh.Controls.Add(Label5)
        pnlDatVeh.Controls.Add(Label3)
        pnlDatVeh.Controls.Add(Label4)
        pnlDatVeh.Controls.Add(label11)
        pnlDatVeh.Controls.Add(Label1)
        pnlDatVeh.Controls.Add(btnSelChof)
        pnlDatVeh.Dock = DockStyle.Left
        pnlDatVeh.Location = New Point(0, 0)
        pnlDatVeh.Name = "pnlDatVeh"
        pnlDatVeh.Size = New Size(277, 1046)
        pnlDatVeh.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_auto_100__1_
        PictureBox1.Location = New Point(29, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 138)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 52
        PictureBox1.TabStop = False
        ' 
        ' txtChof
        ' 
        txtChof.Anchor = AnchorStyles.None
        txtChof.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtChof.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtChof.Location = New Point(29, 556)
        txtChof.MaxLength = 101
        txtChof.Name = "txtChof"
        txtChof.Size = New Size(224, 22)
        txtChof.TabIndex = 8
        txtChof.Tag = "Chofer"
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
        btnNuevo.Image = My.Resources.Resources.icons8_más_nuevo_243
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(138, 384)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "   Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtMatricula
        ' 
        txtMatricula.Anchor = AnchorStyles.None
        txtMatricula.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtMatricula.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMatricula.Location = New Point(28, 424)
        txtMatricula.MaxLength = 15
        txtMatricula.Name = "txtMatricula"
        txtMatricula.Size = New Size(224, 22)
        txtMatricula.TabIndex = 2
        txtMatricula.Tag = "Matrícula"
        ' 
        ' txtModel
        ' 
        txtModel.Anchor = AnchorStyles.None
        txtModel.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtModel.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtModel.Location = New Point(28, 468)
        txtModel.MaxLength = 100
        txtModel.Name = "txtModel"
        txtModel.Size = New Size(224, 22)
        txtModel.TabIndex = 4
        txtModel.Tag = "Modelo"
        ' 
        ' txtCapPasj
        ' 
        txtCapPasj.Anchor = AnchorStyles.None
        txtCapPasj.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCapPasj.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCapPasj.Location = New Point(29, 512)
        txtCapPasj.MaxLength = 2
        txtCapPasj.Name = "txtCapPasj"
        txtCapPasj.Size = New Size(224, 22)
        txtCapPasj.TabIndex = 6
        txtCapPasj.Tag = "Capacidad de Pasajeros"
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
        btnGuaMod.Location = New Point(28, 606)
        btnGuaMod.Name = "btnGuaMod"
        btnGuaMod.Size = New Size(224, 31)
        btnGuaMod.TabIndex = 9
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
        btnResEli.Location = New Point(28, 643)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 10
        btnResEli.Text = "Deshabilitar"
        btnResEli.UseVisualStyleBackColor = False
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
        Label5.Size = New Size(151, 33)
        Label5.TabIndex = 11
        Label5.Text = "Vehículos"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(28, 406)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 16)
        Label3.TabIndex = 1
        Label3.Text = "Matrícula*"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(28, 449)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 16)
        Label4.TabIndex = 3
        Label4.Text = "Modelo*"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.BackColor = Color.Transparent
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        label11.Location = New Point(28, 493)
        label11.Name = "label11"
        label11.Size = New Size(163, 16)
        label11.TabIndex = 5
        label11.Text = "Capacidad de Pasajeros*"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(29, 537)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 16)
        Label1.TabIndex = 7
        Label1.Text = "Chofer*"
        ' 
        ' btnSelChof
        ' 
        btnSelChof.Anchor = AnchorStyles.None
        btnSelChof.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelChof.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnSelChof.FlatAppearance.BorderSize = 0
        btnSelChof.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelChof.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnSelChof.FlatStyle = FlatStyle.Flat
        btnSelChof.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelChof.ForeColor = Color.White
        btnSelChof.Image = My.Resources.Resources.icons8_conductor_de_taxi_nuevo_241
        btnSelChof.ImageAlign = ContentAlignment.MiddleLeft
        btnSelChof.Location = New Point(29, 680)
        btnSelChof.Name = "btnSelChof"
        btnSelChof.Size = New Size(224, 31)
        btnSelChof.TabIndex = 12
        btnSelChof.Text = "  Seleccionar Chofer"
        btnSelChof.UseVisualStyleBackColor = False
        ' 
        ' pnlDGVVeh
        ' 
        pnlDGVVeh.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVVeh.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVVeh.Controls.Add(pnlDespDGV)
        pnlDGVVeh.Controls.Add(pnlBusxFecha)
        pnlDGVVeh.Controls.Add(btnBusxFecha)
        pnlDGVVeh.Controls.Add(btnImpr)
        pnlDGVVeh.Controls.Add(Label7)
        pnlDGVVeh.Controls.Add(rbVehAct)
        pnlDGVVeh.Controls.Add(rbVehCan)
        pnlDGVVeh.Controls.Add(txtBusVeh)
        pnlDGVVeh.Controls.Add(dgvVehiculos)
        pnlDGVVeh.Location = New Point(279, 0)
        pnlDGVVeh.Name = "pnlDGVVeh"
        pnlDGVVeh.Size = New Size(1635, 1046)
        pnlDGVVeh.TabIndex = 1
        ' 
        ' pnlDespDGV
        ' 
        pnlDespDGV.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlDespDGV.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        pnlDespDGV.Controls.Add(dgvPanelDesp)
        pnlDespDGV.Location = New Point(19, 394)
        pnlDespDGV.Name = "pnlDespDGV"
        pnlDespDGV.Size = New Size(1597, 259)
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
        dgvPanelDesp.Size = New Size(1591, 253)
        dgvPanelDesp.TabIndex = 17
        ' 
        ' pnlBusxFecha
        ' 
        pnlBusxFecha.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlBusxFecha.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlBusxFecha.Controls.Add(Panel1)
        pnlBusxFecha.Location = New Point(1340, 82)
        pnlBusxFecha.Name = "pnlBusxFecha"
        pnlBusxFecha.Size = New Size(276, 268)
        pnlBusxFecha.TabIndex = 18
        pnlBusxFecha.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(cmbAnho)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(ckbActHasta)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(cmbMes)
        Panel1.Controls.Add(btnBusxDia)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(cmbDia)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cmbMesH)
        Panel1.Controls.Add(cmbAnhoH)
        Panel1.Controls.Add(cmbDiaH)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label12)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 262)
        Panel1.TabIndex = 16
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label13.Location = New Point(53, 115)
        Label13.Name = "Label13"
        Label13.Size = New Size(46, 16)
        Label13.TabIndex = 32
        Label13.Text = "Hasta:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(13, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(181, 25)
        Label6.TabIndex = 24
        Label6.Text = "Buscar por fecha:"
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
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label14.Location = New Point(19, 57)
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
        cmbDia.Location = New Point(185, 75)
        cmbDia.MaxDropDownItems = 5
        cmbDia.Name = "cmbDia"
        cmbDia.Size = New Size(65, 23)
        cmbDia.TabIndex = 30
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label8.Location = New Point(19, 145)
        Label8.Name = "Label8"
        Label8.Size = New Size(29, 15)
        Label8.TabIndex = 33
        Label8.Text = "Año"
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
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label10.Location = New Point(105, 145)
        Label10.Name = "Label10"
        Label10.Size = New Size(29, 15)
        Label10.TabIndex = 35
        Label10.Text = "Mes"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label12.Location = New Point(185, 145)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 15)
        Label12.TabIndex = 37
        Label12.Text = "Día"
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
        btnBusxFecha.Location = New Point(1403, 52)
        btnBusxFecha.Name = "btnBusxFecha"
        btnBusxFecha.Size = New Size(213, 31)
        btnBusxFecha.TabIndex = 17
        btnBusxFecha.Text = "  Buscar por Fecha"
        btnBusxFecha.UseVisualStyleBackColor = False
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
        btnImpr.Location = New Point(1457, 11)
        btnImpr.Name = "btnImpr"
        btnImpr.Size = New Size(159, 31)
        btnImpr.TabIndex = 16
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
        Label7.Size = New Size(163, 24)
        Label7.TabIndex = 0
        Label7.Text = "Lista de Vehículos"
        ' 
        ' rbVehAct
        ' 
        rbVehAct.Appearance = Appearance.Button
        rbVehAct.AutoSize = True
        rbVehAct.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVehAct.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbVehAct.FlatAppearance.BorderSize = 0
        rbVehAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVehAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVehAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVehAct.FlatStyle = FlatStyle.Flat
        rbVehAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbVehAct.ForeColor = Color.White
        rbVehAct.Image = My.Resources.Resources.icons8_auto_alta_24
        rbVehAct.ImageAlign = ContentAlignment.MiddleLeft
        rbVehAct.Location = New Point(19, 52)
        rbVehAct.Name = "rbVehAct"
        rbVehAct.Size = New Size(107, 30)
        rbVehAct.TabIndex = 1
        rbVehAct.TabStop = True
        rbVehAct.Text = "       Activos     "
        rbVehAct.TextAlign = ContentAlignment.MiddleRight
        rbVehAct.UseVisualStyleBackColor = False
        ' 
        ' rbVehCan
        ' 
        rbVehCan.Appearance = Appearance.Button
        rbVehCan.AutoSize = True
        rbVehCan.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVehCan.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbVehCan.FlatAppearance.BorderSize = 0
        rbVehCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVehCan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbVehCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbVehCan.FlatStyle = FlatStyle.Flat
        rbVehCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbVehCan.ForeColor = Color.White
        rbVehCan.Image = My.Resources.Resources.icons8_auto_baja_24
        rbVehCan.ImageAlign = ContentAlignment.MiddleLeft
        rbVehCan.Location = New Point(126, 52)
        rbVehCan.Name = "rbVehCan"
        rbVehCan.Size = New Size(124, 30)
        rbVehCan.TabIndex = 2
        rbVehCan.TabStop = True
        rbVehCan.Text = "      Deshabilitados"
        rbVehCan.TextAlign = ContentAlignment.MiddleRight
        rbVehCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusVeh
        ' 
        txtBusVeh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusVeh.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusVeh.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusVeh.ForeColor = SystemColors.WindowFrame
        txtBusVeh.Location = New Point(970, 52)
        txtBusVeh.MaxLength = 50
        txtBusVeh.Name = "txtBusVeh"
        txtBusVeh.Size = New Size(427, 22)
        txtBusVeh.TabIndex = 3
        txtBusVeh.Text = "Buscar"
        ' 
        ' dgvVehiculos
        ' 
        dgvVehiculos.AllowUserToAddRows = False
        dgvVehiculos.AllowUserToDeleteRows = False
        dgvVehiculos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvVehiculos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        dgvVehiculos.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvVehiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvVehiculos.DefaultCellStyle = DataGridViewCellStyle7
        dgvVehiculos.Location = New Point(19, 82)
        dgvVehiculos.Name = "dgvVehiculos"
        dgvVehiculos.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.Black
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvVehiculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvVehiculos.RowHeadersVisible = False
        dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVehiculos.Size = New Size(1597, 952)
        dgvVehiculos.TabIndex = 4
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' cmsVeh
        ' 
        cmsVeh.Items.AddRange(New ToolStripItem() {DeshabilitarToolStripMenuItem, ModificarToolStripMenuItem, DetalleToolStripMenuItem})
        cmsVeh.Name = "cmsChof"
        cmsVeh.Size = New Size(137, 70)
        ' 
        ' DeshabilitarToolStripMenuItem
        ' 
        DeshabilitarToolStripMenuItem.Name = "DeshabilitarToolStripMenuItem"
        DeshabilitarToolStripMenuItem.Size = New Size(136, 22)
        DeshabilitarToolStripMenuItem.Text = "Deshabilitar"
        ' 
        ' ModificarToolStripMenuItem
        ' 
        ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        ModificarToolStripMenuItem.Size = New Size(136, 22)
        ModificarToolStripMenuItem.Text = "Modificar"
        ' 
        ' DetalleToolStripMenuItem
        ' 
        DetalleToolStripMenuItem.Name = "DetalleToolStripMenuItem"
        DetalleToolStripMenuItem.Size = New Size(136, 22)
        DetalleToolStripMenuItem.Text = "Detalle"
        ' 
        ' frmVeh
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1914, 1046)
        Controls.Add(pnlDGVVeh)
        Controls.Add(pnlDatVeh)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmVeh"
        Text = "frmVeh"
        pnlDatVeh.ResumeLayout(False)
        pnlDatVeh.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVVeh.ResumeLayout(False)
        pnlDGVVeh.PerformLayout()
        pnlDespDGV.ResumeLayout(False)
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlBusxFecha.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvVehiculos, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        cmsVeh.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatVeh As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtCapPasj As TextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents btnSelChof As Button
    Friend WithEvents btnGuaMod As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlDGVVeh As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbVehAct As RadioButton
    Friend WithEvents rbVehCan As RadioButton
    Friend WithEvents txtBusVeh As TextBox
    Friend WithEvents dgvVehiculos As DataGridView
    Friend WithEvents txtChof As TextBox
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnImpr As Button
    Friend WithEvents cmsVeh As ContextMenuStrip
    Friend WithEvents DeshabilitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlBusxFecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ckbActHasta As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnBusxDia As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMesH As ComboBox
    Friend WithEvents cmbAnhoH As ComboBox
    Friend WithEvents cmbDiaH As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnBusxFecha As Button
    Friend WithEvents pnlDespDGV As Panel
    Friend WithEvents dgvPanelDesp As DataGridView
    Friend WithEvents DetalleToolStripMenuItem As ToolStripMenuItem
End Class
