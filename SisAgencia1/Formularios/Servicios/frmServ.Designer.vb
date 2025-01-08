<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServ))
        pnlDatServ = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        btnNuevo = New Button()
        txtProv = New TextBox()
        txtNomServ = New TextBox()
        cmbTpServ = New ComboBox()
        txtPrecio = New TextBox()
        txtDes = New TextBox()
        btnGuaMod = New Button()
        btnResEli = New Button()
        btnSelProv = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        label11 = New Label()
        Label2 = New Label()
        pnlDGVServ = New Panel()
        pnlDespDGV = New Panel()
        dgvPanelDesp = New DataGridView()
        pnlBusxFecha = New Panel()
        Panel1 = New Panel()
        Label13 = New Label()
        Label8 = New Label()
        cmbAnho = New ComboBox()
        Label16 = New Label()
        ckbActHasta = New CheckBox()
        Label15 = New Label()
        cmbMes = New ComboBox()
        btnBusxDia = New Button()
        Label14 = New Label()
        cmbDia = New ComboBox()
        Label9 = New Label()
        cmbMesH = New ComboBox()
        cmbAnhoH = New ComboBox()
        cmbDiaH = New ComboBox()
        Label10 = New Label()
        Label12 = New Label()
        btnBusxFecha = New Button()
        btnImpr = New Button()
        Label7 = New Label()
        rbServAct = New RadioButton()
        rbServCan = New RadioButton()
        txtBusServ = New TextBox()
        dgvServicios = New DataGridView()
        ep = New ErrorProvider(components)
        cmsServ = New ContextMenuStrip(components)
        DeshabilitarToolStripMenuItem = New ToolStripMenuItem()
        ModificarToolStripMenuItem = New ToolStripMenuItem()
        DetalleToolStripMenuItem = New ToolStripMenuItem()
        pnlDatServ.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDGVServ.SuspendLayout()
        pnlDespDGV.SuspendLayout()
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlBusxFecha.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvServicios, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        cmsServ.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlDatServ
        ' 
        pnlDatServ.BackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        pnlDatServ.Controls.Add(Label1)
        pnlDatServ.Controls.Add(Button1)
        pnlDatServ.Controls.Add(PictureBox1)
        pnlDatServ.Controls.Add(Label5)
        pnlDatServ.Controls.Add(btnNuevo)
        pnlDatServ.Controls.Add(txtProv)
        pnlDatServ.Controls.Add(txtNomServ)
        pnlDatServ.Controls.Add(cmbTpServ)
        pnlDatServ.Controls.Add(txtPrecio)
        pnlDatServ.Controls.Add(txtDes)
        pnlDatServ.Controls.Add(btnGuaMod)
        pnlDatServ.Controls.Add(btnResEli)
        pnlDatServ.Controls.Add(btnSelProv)
        pnlDatServ.Controls.Add(Label3)
        pnlDatServ.Controls.Add(Label4)
        pnlDatServ.Controls.Add(Label6)
        pnlDatServ.Controls.Add(label11)
        pnlDatServ.Controls.Add(Label2)
        pnlDatServ.Dock = DockStyle.Left
        pnlDatServ.Location = New Point(0, 0)
        pnlDatServ.Name = "pnlDatServ"
        pnlDatServ.Size = New Size(277, 1041)
        pnlDatServ.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(41, 1012)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 16)
        Label1.TabIndex = 54
        Label1.Text = "Agregar tipo de Servicio"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderColor = Color.SlateGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Button1.Image = My.Resources.Resources.icons8_más_16
        Button1.Location = New Point(3, 1004)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 34)
        Button1.TabIndex = 53
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.icons8_parque_nacional_100__1_
        PictureBox1.Location = New Point(28, 51)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 149)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 52
        PictureBox1.TabStop = False
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
        Label5.Size = New Size(144, 33)
        Label5.TabIndex = 0
        Label5.Text = "Servicios"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.None
        btnNuevo.BackColor = Color.Transparent
        btnNuevo.FlatAppearance.BorderColor = Color.SlateGray
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(232), CByte(238), CByte(249))
        btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnNuevo.Image = My.Resources.Resources.icons8_más_nuevo_244
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(138, 369)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "   Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtProv
        ' 
        txtProv.Anchor = AnchorStyles.None
        txtProv.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtProv.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProv.Location = New Point(28, 409)
        txtProv.MaxLength = 50
        txtProv.Name = "txtProv"
        txtProv.Size = New Size(224, 22)
        txtProv.TabIndex = 3
        txtProv.Tag = "Proveedor"
        ' 
        ' txtNomServ
        ' 
        txtNomServ.Anchor = AnchorStyles.None
        txtNomServ.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtNomServ.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNomServ.Location = New Point(28, 453)
        txtNomServ.MaxLength = 50
        txtNomServ.Name = "txtNomServ"
        txtNomServ.Size = New Size(224, 22)
        txtNomServ.TabIndex = 5
        txtNomServ.Tag = "Nombre del Servicio"
        ' 
        ' cmbTpServ
        ' 
        cmbTpServ.Anchor = AnchorStyles.None
        cmbTpServ.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        cmbTpServ.Font = New Font("Microsoft Sans Serif", 9.75F)
        cmbTpServ.FormattingEnabled = True
        cmbTpServ.Location = New Point(28, 497)
        cmbTpServ.MaxDropDownItems = 5
        cmbTpServ.MaxLength = 50
        cmbTpServ.Name = "cmbTpServ"
        cmbTpServ.Size = New Size(224, 24)
        cmbTpServ.TabIndex = 7
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Anchor = AnchorStyles.None
        txtPrecio.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtPrecio.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtPrecio.Location = New Point(28, 543)
        txtPrecio.MaxLength = 50
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(224, 22)
        txtPrecio.TabIndex = 9
        txtPrecio.Tag = "Precio"
        ' 
        ' txtDes
        ' 
        txtDes.Anchor = AnchorStyles.None
        txtDes.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtDes.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtDes.Location = New Point(29, 587)
        txtDes.MaxLength = 100
        txtDes.Multiline = True
        txtDes.Name = "txtDes"
        txtDes.Size = New Size(224, 71)
        txtDes.TabIndex = 11
        txtDes.Tag = "Descripción"
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
        btnGuaMod.Location = New Point(29, 694)
        btnGuaMod.Name = "btnGuaMod"
        btnGuaMod.Size = New Size(225, 31)
        btnGuaMod.TabIndex = 12
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
        btnResEli.Location = New Point(29, 731)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(225, 31)
        btnResEli.TabIndex = 13
        btnResEli.Text = "Deshabilitar"
        btnResEli.UseVisualStyleBackColor = False
        ' 
        ' btnSelProv
        ' 
        btnSelProv.Anchor = AnchorStyles.None
        btnSelProv.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelProv.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnSelProv.FlatAppearance.BorderSize = 0
        btnSelProv.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnSelProv.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnSelProv.FlatStyle = FlatStyle.Flat
        btnSelProv.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelProv.ForeColor = Color.White
        btnSelProv.Image = My.Resources.Resources.icons8_edificio_nuevo_24
        btnSelProv.ImageAlign = ContentAlignment.MiddleLeft
        btnSelProv.Location = New Point(29, 768)
        btnSelProv.Name = "btnSelProv"
        btnSelProv.Size = New Size(225, 31)
        btnSelProv.TabIndex = 14
        btnSelProv.Text = "Elegir Proveedor"
        btnSelProv.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(28, 391)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 16)
        Label3.TabIndex = 2
        Label3.Text = "Proveedor"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(28, 434)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 16)
        Label4.TabIndex = 4
        Label4.Text = "Nombre del Servicio"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(28, 478)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 16)
        Label6.TabIndex = 6
        Label6.Text = "Tipo de Servicio"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.BackColor = Color.Transparent
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        label11.Location = New Point(27, 524)
        label11.Name = "label11"
        label11.Size = New Size(46, 16)
        label11.TabIndex = 8
        label11.Text = "Precio"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(29, 568)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 16)
        Label2.TabIndex = 10
        Label2.Text = "Descripción"
        ' 
        ' pnlDGVServ
        ' 
        pnlDGVServ.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVServ.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlDGVServ.Controls.Add(pnlDespDGV)
        pnlDGVServ.Controls.Add(pnlBusxFecha)
        pnlDGVServ.Controls.Add(btnBusxFecha)
        pnlDGVServ.Controls.Add(btnImpr)
        pnlDGVServ.Controls.Add(Label7)
        pnlDGVServ.Controls.Add(rbServAct)
        pnlDGVServ.Controls.Add(rbServCan)
        pnlDGVServ.Controls.Add(txtBusServ)
        pnlDGVServ.Controls.Add(dgvServicios)
        pnlDGVServ.Location = New Point(279, 0)
        pnlDGVServ.Name = "pnlDGVServ"
        pnlDGVServ.Size = New Size(1625, 1041)
        pnlDGVServ.TabIndex = 1
        ' 
        ' pnlDespDGV
        ' 
        pnlDespDGV.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        pnlDespDGV.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        pnlDespDGV.Controls.Add(dgvPanelDesp)
        pnlDespDGV.Location = New Point(19, 391)
        pnlDespDGV.Name = "pnlDespDGV"
        pnlDespDGV.Size = New Size(1587, 259)
        pnlDespDGV.TabIndex = 26
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
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(cmbAnho)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(ckbActHasta)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(cmbMes)
        Panel1.Controls.Add(btnBusxDia)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(cmbDia)
        Panel1.Controls.Add(Label9)
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label8.Location = New Point(13, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 25)
        Label8.TabIndex = 24
        Label8.Text = "Buscar por fecha:"
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
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label9.Location = New Point(19, 145)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 15)
        Label9.TabIndex = 33
        Label9.Text = "Año"
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(155, 24)
        Label7.TabIndex = 0
        Label7.Text = "Lista de Servicios"
        ' 
        ' rbServAct
        ' 
        rbServAct.Appearance = Appearance.Button
        rbServAct.AutoSize = True
        rbServAct.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbServAct.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbServAct.FlatAppearance.BorderSize = 0
        rbServAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbServAct.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbServAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbServAct.FlatStyle = FlatStyle.Flat
        rbServAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbServAct.ForeColor = Color.White
        rbServAct.Image = My.Resources.Resources.icons8_parque_nacional_alta_24
        rbServAct.ImageAlign = ContentAlignment.MiddleLeft
        rbServAct.Location = New Point(19, 52)
        rbServAct.Name = "rbServAct"
        rbServAct.Size = New Size(107, 30)
        rbServAct.TabIndex = 1
        rbServAct.TabStop = True
        rbServAct.Text = "       Activos     "
        rbServAct.TextAlign = ContentAlignment.MiddleRight
        rbServAct.UseVisualStyleBackColor = False
        ' 
        ' rbServCan
        ' 
        rbServCan.Appearance = Appearance.Button
        rbServCan.AutoSize = True
        rbServCan.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbServCan.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        rbServCan.FlatAppearance.BorderSize = 0
        rbServCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbServCan.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        rbServCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        rbServCan.FlatStyle = FlatStyle.Flat
        rbServCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbServCan.ForeColor = Color.White
        rbServCan.Image = My.Resources.Resources.icons8_parque_nacional_baja_24
        rbServCan.ImageAlign = ContentAlignment.MiddleLeft
        rbServCan.Location = New Point(126, 52)
        rbServCan.Name = "rbServCan"
        rbServCan.Size = New Size(124, 30)
        rbServCan.TabIndex = 2
        rbServCan.TabStop = True
        rbServCan.Text = "      Deshabilitados"
        rbServCan.TextAlign = ContentAlignment.MiddleRight
        rbServCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusServ
        ' 
        txtBusServ.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusServ.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusServ.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusServ.ForeColor = SystemColors.WindowFrame
        txtBusServ.Location = New Point(960, 52)
        txtBusServ.MaxLength = 50
        txtBusServ.Name = "txtBusServ"
        txtBusServ.Size = New Size(427, 22)
        txtBusServ.TabIndex = 3
        txtBusServ.Text = "Buscar"
        ' 
        ' dgvServicios
        ' 
        dgvServicios.AllowUserToAddRows = False
        dgvServicios.AllowUserToDeleteRows = False
        dgvServicios.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvServicios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgvServicios.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvServicios.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvServicios.DefaultCellStyle = DataGridViewCellStyle7
        dgvServicios.Location = New Point(19, 82)
        dgvServicios.Name = "dgvServicios"
        dgvServicios.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvServicios.RowHeadersVisible = False
        dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvServicios.Size = New Size(1587, 947)
        dgvServicios.TabIndex = 4
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' cmsServ
        ' 
        cmsServ.Items.AddRange(New ToolStripItem() {DeshabilitarToolStripMenuItem, ModificarToolStripMenuItem, DetalleToolStripMenuItem})
        cmsServ.Name = "cmsChof"
        cmsServ.Size = New Size(137, 70)
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
        ' frmServ
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDatServ)
        Controls.Add(pnlDGVServ)
        Name = "frmServ"
        Text = "frmServ"
        pnlDatServ.ResumeLayout(False)
        pnlDatServ.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDGVServ.ResumeLayout(False)
        pnlDGVServ.PerformLayout()
        pnlDespDGV.ResumeLayout(False)
        CType(dgvPanelDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlBusxFecha.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvServicios, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        cmsServ.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDatServ As Panel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtProv As TextBox
    Friend WithEvents txtNomServ As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cmbTpServ As ComboBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents btnGuaMod As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlDGVServ As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbServAct As RadioButton
    Friend WithEvents rbServCan As RadioButton
    Friend WithEvents txtBusServ As TextBox
    Friend WithEvents dgvServicios As DataGridView
    Friend WithEvents btnSelProv As Button
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnImpr As Button
    Friend WithEvents cmsServ As ContextMenuStrip
    Friend WithEvents DeshabilitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlBusxFecha As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbAnho As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ckbActHasta As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents btnBusxDia As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents Label9 As Label
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
