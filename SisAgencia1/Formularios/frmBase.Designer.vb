<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBase))
        pnlDGVCli = New Panel()
        Label7 = New Label()
        rbCliAct = New RadioButton()
        rbCliCan = New RadioButton()
        txtBusCli = New TextBox()
        dgvClientes = New DataGridView()
        txtDNI = New TextBox()
        txtNom = New TextBox()
        txtApe = New TextBox()
        cmbPais = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnAgrCom = New Button()
        Label5 = New Label()
        txtMail = New TextBox()
        btnGuaMod = New Button()
        txtTel = New TextBox()
        btnAgrTel = New Button()
        btnResEli = New Button()
        btnNuevo = New Button()
        PictureBox1 = New PictureBox()
        pnlDatCli = New Panel()
        ep = New ErrorProvider(components)
        pnlDGVCli.SuspendLayout()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlDatCli.SuspendLayout()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDGVCli
        ' 
        pnlDGVCli.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVCli.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        pnlDGVCli.Controls.Add(Label7)
        pnlDGVCli.Controls.Add(rbCliAct)
        pnlDGVCli.Controls.Add(rbCliCan)
        pnlDGVCli.Controls.Add(txtBusCli)
        pnlDGVCli.Controls.Add(dgvClientes)
        pnlDGVCli.Location = New Point(279, 0)
        pnlDGVCli.Name = "pnlDGVCli"
        pnlDGVCli.Size = New Size(1625, 1041)
        pnlDGVCli.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SteelBlue
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 24)
        Label7.TabIndex = 44
        Label7.Text = "Lista de Clientes"
        ' 
        ' rbCliAct
        ' 
        rbCliAct.Appearance = Appearance.Button
        rbCliAct.AutoSize = True
        rbCliAct.BackColor = Color.SteelBlue
        rbCliAct.FlatAppearance.BorderColor = Color.SlateGray
        rbCliAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(55), CByte(104), CByte(145))
        rbCliAct.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        rbCliAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        rbCliAct.FlatStyle = FlatStyle.Flat
        rbCliAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCliAct.ForeColor = Color.White
        rbCliAct.Image = My.Resources.Resources.icons8_usuario_de_género_neutro_24
        rbCliAct.ImageAlign = ContentAlignment.MiddleLeft
        rbCliAct.Location = New Point(19, 51)
        rbCliAct.Name = "rbCliAct"
        rbCliAct.Size = New Size(109, 32)
        rbCliAct.TabIndex = 12
        rbCliAct.TabStop = True
        rbCliAct.Text = "       Activos     "
        rbCliAct.TextAlign = ContentAlignment.MiddleRight
        rbCliAct.UseVisualStyleBackColor = False
        ' 
        ' rbCliCan
        ' 
        rbCliCan.Appearance = Appearance.Button
        rbCliCan.AutoSize = True
        rbCliCan.BackColor = Color.SteelBlue
        rbCliCan.FlatAppearance.BorderColor = Color.SlateGray
        rbCliCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(55), CByte(104), CByte(145))
        rbCliCan.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        rbCliCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        rbCliCan.FlatStyle = FlatStyle.Flat
        rbCliCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbCliCan.ForeColor = Color.White
        rbCliCan.Image = My.Resources.Resources.icons8_retire_hombre_usuario_24
        rbCliCan.ImageAlign = ContentAlignment.MiddleLeft
        rbCliCan.Location = New Point(134, 51)
        rbCliCan.Name = "rbCliCan"
        rbCliCan.Size = New Size(107, 32)
        rbCliCan.TabIndex = 13
        rbCliCan.TabStop = True
        rbCliCan.Text = "      Eliminados "
        rbCliCan.TextAlign = ContentAlignment.MiddleRight
        rbCliCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusCli
        ' 
        txtBusCli.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusCli.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtBusCli.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusCli.ForeColor = SystemColors.WindowFrame
        txtBusCli.Location = New Point(1179, 51)
        txtBusCli.MaxLength = 50
        txtBusCli.Name = "txtBusCli"
        txtBusCli.Size = New Size(427, 22)
        txtBusCli.TabIndex = 14
        txtBusCli.Text = "Buscar"
        ' 
        ' dgvClientes
        ' 
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue
        dgvClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClientes.BackgroundColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvClientes.DefaultCellStyle = DataGridViewCellStyle3
        dgvClientes.Location = New Point(19, 82)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvClientes.RowHeadersVisible = False
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.Size = New Size(1587, 947)
        dgvClientes.TabIndex = 15
        ' 
        ' txtDNI
        ' 
        txtDNI.Anchor = AnchorStyles.None
        txtDNI.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtDNI.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDNI.Location = New Point(29, 338)
        txtDNI.MaxLength = 10
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(224, 22)
        txtDNI.TabIndex = 2
        txtDNI.Tag = "DNI"
        ' 
        ' txtNom
        ' 
        txtNom.Anchor = AnchorStyles.None
        txtNom.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtNom.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtNom.Location = New Point(29, 382)
        txtNom.MaxLength = 50
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(224, 22)
        txtNom.TabIndex = 3
        txtNom.Tag = "Nombre(s)"
        ' 
        ' txtApe
        ' 
        txtApe.Anchor = AnchorStyles.None
        txtApe.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtApe.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtApe.Location = New Point(30, 426)
        txtApe.MaxLength = 50
        txtApe.Name = "txtApe"
        txtApe.Size = New Size(224, 22)
        txtApe.TabIndex = 4
        txtApe.Tag = "Apellido(s)"
        ' 
        ' cmbPais
        ' 
        cmbPais.Anchor = AnchorStyles.None
        cmbPais.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        cmbPais.Font = New Font("Microsoft Sans Serif", 9.75F)
        cmbPais.FormattingEnabled = True
        cmbPais.Location = New Point(30, 470)
        cmbPais.MaxDropDownItems = 5
        cmbPais.MaxLength = 50
        cmbPais.Name = "cmbPais"
        cmbPais.Size = New Size(224, 24)
        cmbPais.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 16)
        Label3.TabIndex = 37
        Label3.Text = "DNI"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.Location = New Point(29, 363)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 16)
        Label4.TabIndex = 38
        Label4.Text = "Nombre(s)"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.Location = New Point(29, 407)
        label11.Name = "label11"
        label11.Size = New Size(72, 16)
        label11.TabIndex = 39
        label11.Text = "Apellido(s)"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label6.Location = New Point(30, 451)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 16)
        Label6.TabIndex = 40
        Label6.Text = "País"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label2.Location = New Point(30, 497)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 16)
        Label2.TabIndex = 41
        Label2.Text = "Correo"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label1.Location = New Point(30, 541)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 16)
        Label1.TabIndex = 42
        Label1.Text = "Teléfono"
        ' 
        ' btnAgrCom
        ' 
        btnAgrCom.Anchor = AnchorStyles.None
        btnAgrCom.BackColor = Color.SteelBlue
        btnAgrCom.FlatAppearance.BorderColor = Color.SlateGray
        btnAgrCom.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnAgrCom.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnAgrCom.FlatStyle = FlatStyle.Flat
        btnAgrCom.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrCom.ForeColor = Color.WhiteSmoke
        btnAgrCom.Image = My.Resources.Resources.icons8_carrito_de_compras_24
        btnAgrCom.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrCom.Location = New Point(29, 687)
        btnAgrCom.Name = "btnAgrCom"
        btnAgrCom.Size = New Size(224, 55)
        btnAgrCom.TabIndex = 11
        btnAgrCom.Text = "Vender"
        btnAgrCom.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SteelBlue
        Label5.Location = New Point(29, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 24)
        Label5.TabIndex = 43
        Label5.Text = "Datos del Cliente"
        ' 
        ' txtMail
        ' 
        txtMail.Anchor = AnchorStyles.None
        txtMail.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtMail.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtMail.Location = New Point(30, 516)
        txtMail.MaxLength = 50
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(224, 22)
        txtMail.TabIndex = 6
        ' 
        ' btnGuaMod
        ' 
        btnGuaMod.Anchor = AnchorStyles.None
        btnGuaMod.BackColor = Color.SteelBlue
        btnGuaMod.FlatAppearance.BorderColor = Color.SlateGray
        btnGuaMod.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnGuaMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnGuaMod.FlatStyle = FlatStyle.Flat
        btnGuaMod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuaMod.ForeColor = Color.White
        btnGuaMod.Image = My.Resources.Resources.icons8_botón_guardar_24
        btnGuaMod.ImageAlign = ContentAlignment.MiddleLeft
        btnGuaMod.Location = New Point(29, 613)
        btnGuaMod.Name = "btnGuaMod"
        btnGuaMod.Size = New Size(224, 31)
        btnGuaMod.TabIndex = 9
        btnGuaMod.Text = "Guardar"
        btnGuaMod.UseVisualStyleBackColor = False
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.None
        txtTel.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtTel.Location = New Point(30, 560)
        txtTel.MaxLength = 50
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(224, 22)
        txtTel.TabIndex = 7
        txtTel.Tag = "Teléfono"
        ' 
        ' btnAgrTel
        ' 
        btnAgrTel.Anchor = AnchorStyles.None
        btnAgrTel.BackColor = Color.SteelBlue
        btnAgrTel.FlatAppearance.BorderColor = Color.SlateGray
        btnAgrTel.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnAgrTel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnAgrTel.FlatStyle = FlatStyle.Flat
        btnAgrTel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrTel.ForeColor = Color.White
        btnAgrTel.Image = My.Resources.Resources.icons8_teléfono_25
        btnAgrTel.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrTel.Location = New Point(30, 560)
        btnAgrTel.Name = "btnAgrTel"
        btnAgrTel.Size = New Size(224, 31)
        btnAgrTel.TabIndex = 8
        btnAgrTel.Text = "  Agregar/Modificar"
        btnAgrTel.UseVisualStyleBackColor = False
        ' 
        ' btnResEli
        ' 
        btnResEli.Anchor = AnchorStyles.None
        btnResEli.BackColor = Color.SteelBlue
        btnResEli.FlatAppearance.BorderColor = Color.SlateGray
        btnResEli.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnResEli.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnResEli.FlatStyle = FlatStyle.Flat
        btnResEli.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnResEli.ForeColor = Color.White
        btnResEli.Image = My.Resources.Resources.icons8_eliminar_24
        btnResEli.ImageAlign = ContentAlignment.MiddleLeft
        btnResEli.Location = New Point(29, 650)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 10
        btnResEli.Text = "Eliminar"
        btnResEli.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.None
        btnNuevo.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        btnNuevo.FlatAppearance.BorderColor = Color.SlateGray
        btnNuevo.FlatAppearance.BorderSize = 0
        btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        btnNuevo.FlatStyle = FlatStyle.Flat
        btnNuevo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNuevo.ForeColor = Color.SteelBlue
        btnNuevo.Image = My.Resources.Resources.icons8_más_30
        btnNuevo.ImageAlign = ContentAlignment.MiddleRight
        btnNuevo.Location = New Point(139, 298)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "   Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.LOGO_Footer_Conquista_tu_Mundo_1
        PictureBox1.Location = New Point(29, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        ' 
        ' pnlDatCli
        ' 
        pnlDatCli.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        pnlDatCli.Controls.Add(PictureBox1)
        pnlDatCli.Controls.Add(btnNuevo)
        pnlDatCli.Controls.Add(txtDNI)
        pnlDatCli.Controls.Add(txtNom)
        pnlDatCli.Controls.Add(txtApe)
        pnlDatCli.Controls.Add(cmbPais)
        pnlDatCli.Controls.Add(txtMail)
        pnlDatCli.Controls.Add(txtTel)
        pnlDatCli.Controls.Add(btnAgrTel)
        pnlDatCli.Controls.Add(btnGuaMod)
        pnlDatCli.Controls.Add(btnResEli)
        pnlDatCli.Controls.Add(btnAgrCom)
        pnlDatCli.Controls.Add(Label5)
        pnlDatCli.Controls.Add(Label3)
        pnlDatCli.Controls.Add(Label4)
        pnlDatCli.Controls.Add(label11)
        pnlDatCli.Controls.Add(Label6)
        pnlDatCli.Controls.Add(Label2)
        pnlDatCli.Controls.Add(Label1)
        pnlDatCli.Dock = DockStyle.Left
        pnlDatCli.Location = New Point(0, 0)
        pnlDatCli.Name = "pnlDatCli"
        pnlDatCli.Size = New Size(277, 1041)
        pnlDatCli.TabIndex = 0
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmBase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDGVCli)
        Controls.Add(pnlDatCli)
        Name = "frmBase"
        Text = "Clientes"
        pnlDGVCli.ResumeLayout(False)
        pnlDGVCli.PerformLayout()
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlDatCli.ResumeLayout(False)
        pnlDatCli.PerformLayout()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlDGVCli As Panel
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtBusCli As TextBox
    Friend WithEvents rbCliAct As RadioButton
    Friend WithEvents rbCliCan As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgrCom As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnGuaMod As Button
    Friend WithEvents txtTel As TextBox
    Friend WithEvents btnAgrTel As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlDatCli As Panel
    Friend WithEvents ep As ErrorProvider
End Class
