<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        pnlDatUsu = New Panel()
        PictureBox1 = New PictureBox()
        btnModCon = New Button()
        btnCancelar = New Button()
        txtUsu = New TextBox()
        cmbTpUsu = New ComboBox()
        btnMod = New Button()
        btnResEli = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        pnlDGVUsu = New Panel()
        pnlDespDGV = New Panel()
        dgvPanelDesp = New DataGridView()
        pnlBusxFecha = New Panel()
        Panel1 = New Panel()
        Label13 = New Label()
        Label1 = New Label()
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
        rbUsuAct = New RadioButton()
        rbUsuCan = New RadioButton()
        txtBusUsu = New TextBox()
        dgvUsuarios = New DataGridView()
        Label7 = New Label()
        ep = New ErrorProvider(components)
        cmsUsu = New ContextMenuStrip(components)
        DeshabilitarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        DetalleToolStripMenuItem = New ToolStripMenuItem()
        pnlDatUsu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVUsu.SuspendLayout()
        pnlDespDGV.SuspendLayout()
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlBusxFecha.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        cmsUsu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDatUsu
        ' 
        pnlDatUsu.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatUsu.Controls.Add(PictureBox1)
        pnlDatUsu.Controls.Add(btnModCon)
        pnlDatUsu.Controls.Add(btnCancelar)
        pnlDatUsu.Controls.Add(txtUsu)
        pnlDatUsu.Controls.Add(cmbTpUsu)
        pnlDatUsu.Controls.Add(btnMod)
        pnlDatUsu.Controls.Add(btnResEli)
        pnlDatUsu.Controls.Add(Label5)
        pnlDatUsu.Controls.Add(Label3)
        pnlDatUsu.Controls.Add(Label4)
        pnlDatUsu.Controls.Add(Label6)
        pnlDatUsu.Dock = DockStyle.Left
        pnlDatUsu.Location = New Point(0, 0)
        pnlDatUsu.Name = "pnlDatUsu"
        pnlDatUsu.Size = New Size(277, 1041)
        pnlDatUsu.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_usuarios_100__1_
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' btnModCon
        ' 
        btnModCon.Anchor = AnchorStyles.None
        btnModCon.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnModCon.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnModCon.FlatAppearance.BorderSize = 0
        btnModCon.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnModCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnModCon.FlatStyle = FlatStyle.Flat
        btnModCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModCon.ForeColor = Color.White
        btnModCon.Image = My.Resources.Resources.icons8_contraseña_241
        btnModCon.ImageAlign = ContentAlignment.MiddleLeft
        btnModCon.Location = New Point(29, 573)
        btnModCon.Name = "btnModCon"
        btnModCon.Size = New Size(224, 31)
        btnModCon.TabIndex = 7
        btnModCon.Text = "   Cambiar Contraseña"
        btnModCon.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.None
        btnCancelar.BackColor = Color.Transparent
        btnCancelar.FlatAppearance.BorderColor = Color.SlateGray
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCancelar.Image = My.Resources.Resources.icons8_cancelar_nuevo_30
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(141, 443)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(114, 34)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleLeft
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' txtUsu
        ' 
        txtUsu.Anchor = AnchorStyles.None
        txtUsu.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsu.Location = New Point(30, 483)
        txtUsu.MaxLength = 50
        txtUsu.Name = "txtUsu"
        txtUsu.Size = New Size(224, 22)
        txtUsu.TabIndex = 3
        txtUsu.Tag = "Usuario"
        ' 
        ' cmbTpUsu
        ' 
        cmbTpUsu.Anchor = AnchorStyles.None
        cmbTpUsu.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        cmbTpUsu.Font = New Font("Microsoft Sans Serif", 9.75F)
        cmbTpUsu.FormattingEnabled = True
        cmbTpUsu.Location = New Point(31, 527)
        cmbTpUsu.MaxDropDownItems = 5
        cmbTpUsu.MaxLength = 50
        cmbTpUsu.Name = "cmbTpUsu"
        cmbTpUsu.Size = New Size(224, 24)
        cmbTpUsu.TabIndex = 5
        ' 
        ' btnMod
        ' 
        btnMod.Anchor = AnchorStyles.None
        btnMod.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMod.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnMod.FlatAppearance.BorderSize = 0
        btnMod.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnMod.FlatStyle = FlatStyle.Flat
        btnMod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMod.ForeColor = Color.White
        btnMod.Image = My.Resources.Resources.icons8_botón_guardar_24
        btnMod.ImageAlign = ContentAlignment.MiddleLeft
        btnMod.Location = New Point(31, 624)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(224, 31)
        btnMod.TabIndex = 8
        btnMod.Text = "Guardar Cambios"
        btnMod.UseVisualStyleBackColor = False
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
        btnResEli.Location = New Point(31, 661)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 9
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
        Label5.Location = New Point(27, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 33)
        Label5.TabIndex = 0
        Label5.Text = "Usuarios"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(30, 465)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 16)
        Label3.TabIndex = 2
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(28, 554)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 16)
        Label4.TabIndex = 6
        Label4.Text = "Contraseña"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(30, 508)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 16)
        Label6.TabIndex = 4
        Label6.Text = "Tipo de Usuario"
        ' 
        ' pnlDGVUsu
        ' 
        pnlDGVUsu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVUsu.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVUsu.Controls.Add(pnlDespDGV)
        pnlDGVUsu.Controls.Add(pnlBusxFecha)
        pnlDGVUsu.Controls.Add(btnBusxFecha)
        pnlDGVUsu.Controls.Add(btnImpr)
        pnlDGVUsu.Controls.Add(rbUsuAct)
        pnlDGVUsu.Controls.Add(rbUsuCan)
        pnlDGVUsu.Controls.Add(txtBusUsu)
        pnlDGVUsu.Controls.Add(dgvUsuarios)
        pnlDGVUsu.Controls.Add(Label7)
        pnlDGVUsu.Location = New Point(279, 0)
        pnlDGVUsu.Name = "pnlDGVUsu"
        pnlDGVUsu.Size = New Size(1625, 1041)
        pnlDGVUsu.TabIndex = 1
        ' 
        ' pnlDespDGV
        ' 
        pnlDespDGV.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlDespDGV.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        pnlDespDGV.Controls.Add(dgvPanelDesp)
        pnlDespDGV.Location = New Point(19, 391)
        pnlDespDGV.Name = "pnlDespDGV"
        pnlDespDGV.Size = New Size(1587, 259)
        pnlDespDGV.TabIndex = 27
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
        pnlBusxFecha.TabIndex = 18
        pnlBusxFecha.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label1)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(13, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 24
        Label1.Text = "Buscar por fecha:"
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
        btnBusxFecha.Location = New Point(1393, 52)
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
        btnImpr.Location = New Point(1447, 11)
        btnImpr.Name = "btnImpr"
        btnImpr.Size = New Size(159, 31)
        btnImpr.TabIndex = 16
        btnImpr.Text = "  Imprimir"
        btnImpr.UseVisualStyleBackColor = False
        ' 
        ' rbUsuAct
        ' 
        rbUsuAct.Appearance = Appearance.Button
        rbUsuAct.AutoSize = True
        rbUsuAct.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbUsuAct.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbUsuAct.FlatAppearance.BorderSize = 0
        rbUsuAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbUsuAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbUsuAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbUsuAct.FlatStyle = FlatStyle.Flat
        rbUsuAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbUsuAct.ForeColor = Color.White
        rbUsuAct.Image = My.Resources.Resources.icons8_usuario_de_género_neutro_24
        rbUsuAct.ImageAlign = ContentAlignment.MiddleLeft
        rbUsuAct.Location = New Point(19, 52)
        rbUsuAct.Name = "rbUsuAct"
        rbUsuAct.Size = New Size(107, 30)
        rbUsuAct.TabIndex = 1
        rbUsuAct.TabStop = True
        rbUsuAct.Text = "       Activos     "
        rbUsuAct.TextAlign = ContentAlignment.MiddleRight
        rbUsuAct.UseVisualStyleBackColor = False
        ' 
        ' rbUsuCan
        ' 
        rbUsuCan.Appearance = Appearance.Button
        rbUsuCan.AutoSize = True
        rbUsuCan.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbUsuCan.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbUsuCan.FlatAppearance.BorderSize = 0
        rbUsuCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbUsuCan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbUsuCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbUsuCan.FlatStyle = FlatStyle.Flat
        rbUsuCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbUsuCan.ForeColor = Color.White
        rbUsuCan.Image = My.Resources.Resources.icons8_retire_hombre_usuario_24
        rbUsuCan.ImageAlign = ContentAlignment.MiddleLeft
        rbUsuCan.Location = New Point(126, 52)
        rbUsuCan.Name = "rbUsuCan"
        rbUsuCan.Size = New Size(124, 30)
        rbUsuCan.TabIndex = 2
        rbUsuCan.TabStop = True
        rbUsuCan.Text = "      Deshabilitados"
        rbUsuCan.TextAlign = ContentAlignment.MiddleRight
        rbUsuCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusUsu
        ' 
        txtBusUsu.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusUsu.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusUsu.ForeColor = SystemColors.WindowFrame
        txtBusUsu.Location = New Point(960, 52)
        txtBusUsu.MaxLength = 50
        txtBusUsu.Name = "txtBusUsu"
        txtBusUsu.Size = New Size(427, 22)
        txtBusUsu.TabIndex = 3
        txtBusUsu.Text = "Buscar"
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.AllowUserToDeleteRows = False
        dgvUsuarios.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvUsuarios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuarios.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvUsuarios.DefaultCellStyle = DataGridViewCellStyle7
        dgvUsuarios.Location = New Point(19, 82)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvUsuarios.RowHeadersVisible = False
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.Size = New Size(1587, 947)
        dgvUsuarios.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 24)
        Label7.TabIndex = 0
        Label7.Text = "Lista de Usuarios"
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' cmsUsu
        ' 
        cmsUsu.Items.AddRange(New ToolStripItem() {DeshabilitarToolStripMenuItem, ModificarToolStripMenuItem, DetalleToolStripMenuItem})
        cmsUsu.Name = "cmsChof"
        cmsUsu.Size = New Size(137, 70)
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
        ' frmUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDGVUsu)
        Controls.Add(pnlDatUsu)
        Name = "frmUsuarios"
        Text = "frmUsu"
        pnlDatUsu.ResumeLayout(False)
        pnlDatUsu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVUsu.ResumeLayout(False)
        pnlDGVUsu.PerformLayout()
        pnlDespDGV.ResumeLayout(False)
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlBusxFecha.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        cmsUsu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatUsu As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents cmbTpUsu As ComboBox
    Friend WithEvents btnMod As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlDGVUsu As Panel
    Friend WithEvents rbEmpAct As RadioButton
    Friend WithEvents rbUsuCan As RadioButton
    Friend WithEvents txtBusUsu As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUsu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModCon As Button
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents rbUsuAct As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnImpr As Button
    Friend WithEvents cmsUsu As ContextMenuStrip
    Friend WithEvents DeshabilitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlBusxFecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
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
