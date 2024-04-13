<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmp))
        pnlDGVEmp = New Panel()
        rbEmpAct = New RadioButton()
        rbEmpCan = New RadioButton()
        txtBusEmp = New TextBox()
        dgvEmpleados = New DataGridView()
        Label7 = New Label()
        pnlDatEmp = New Panel()
        btnNuevo = New Button()
        txtDNI = New TextBox()
        txtNom = New TextBox()
        txtApe = New TextBox()
        cmbPais = New ComboBox()
        txtDom = New TextBox()
        txtMail = New TextBox()
        txtTel = New TextBox()
        btnGuaMod = New Button()
        btnResEli = New Button()
        btnCreUsu = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        ep = New ErrorProvider(components)
        pnlDGVEmp.SuspendLayout()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        pnlDatEmp.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlDGVEmp
        ' 
        pnlDGVEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDGVEmp.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        pnlDGVEmp.Controls.Add(rbEmpAct)
        pnlDGVEmp.Controls.Add(rbEmpCan)
        pnlDGVEmp.Controls.Add(txtBusEmp)
        pnlDGVEmp.Controls.Add(dgvEmpleados)
        pnlDGVEmp.Controls.Add(Label7)
        pnlDGVEmp.Location = New Point(279, 0)
        pnlDGVEmp.Name = "pnlDGVEmp"
        pnlDGVEmp.Size = New Size(1625, 1041)
        pnlDGVEmp.TabIndex = 2
        ' 
        ' rbEmpAct
        ' 
        rbEmpAct.Appearance = Appearance.Button
        rbEmpAct.AutoSize = True
        rbEmpAct.BackColor = Color.SteelBlue
        rbEmpAct.FlatAppearance.BorderColor = Color.SlateGray
        rbEmpAct.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(55), CByte(104), CByte(145))
        rbEmpAct.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        rbEmpAct.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        rbEmpAct.FlatStyle = FlatStyle.Flat
        rbEmpAct.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbEmpAct.ForeColor = Color.White
        rbEmpAct.Image = My.Resources.Resources.icons8_usuario_de_género_neutro_24
        rbEmpAct.ImageAlign = ContentAlignment.MiddleLeft
        rbEmpAct.Location = New Point(19, 51)
        rbEmpAct.Name = "rbEmpAct"
        rbEmpAct.Size = New Size(109, 32)
        rbEmpAct.TabIndex = 12
        rbEmpAct.TabStop = True
        rbEmpAct.Text = "       Activos     "
        rbEmpAct.TextAlign = ContentAlignment.MiddleRight
        rbEmpAct.UseVisualStyleBackColor = False
        ' 
        ' rbEmpCan
        ' 
        rbEmpCan.Appearance = Appearance.Button
        rbEmpCan.AutoSize = True
        rbEmpCan.BackColor = Color.SteelBlue
        rbEmpCan.FlatAppearance.BorderColor = Color.SlateGray
        rbEmpCan.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(55), CByte(104), CByte(145))
        rbEmpCan.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        rbEmpCan.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        rbEmpCan.FlatStyle = FlatStyle.Flat
        rbEmpCan.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbEmpCan.ForeColor = Color.White
        rbEmpCan.Image = My.Resources.Resources.icons8_retire_hombre_usuario_24
        rbEmpCan.ImageAlign = ContentAlignment.MiddleLeft
        rbEmpCan.Location = New Point(134, 51)
        rbEmpCan.Name = "rbEmpCan"
        rbEmpCan.Size = New Size(107, 32)
        rbEmpCan.TabIndex = 13
        rbEmpCan.TabStop = True
        rbEmpCan.Text = "      Eliminados "
        rbEmpCan.TextAlign = ContentAlignment.MiddleRight
        rbEmpCan.UseVisualStyleBackColor = False
        ' 
        ' txtBusEmp
        ' 
        txtBusEmp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusEmp.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtBusEmp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusEmp.ForeColor = SystemColors.WindowFrame
        txtBusEmp.Location = New Point(1179, 51)
        txtBusEmp.MaxLength = 50
        txtBusEmp.Name = "txtBusEmp"
        txtBusEmp.Size = New Size(427, 22)
        txtBusEmp.TabIndex = 14
        txtBusEmp.Text = "Buscar"
        ' 
        ' dgvEmpleados
        ' 
        dgvEmpleados.AllowUserToAddRows = False
        dgvEmpleados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue
        dgvEmpleados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvEmpleados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvEmpleados.BackgroundColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle3
        dgvEmpleados.Location = New Point(19, 82)
        dgvEmpleados.Name = "dgvEmpleados"
        dgvEmpleados.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvEmpleados.RowHeadersVisible = False
        dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmpleados.Size = New Size(1587, 947)
        dgvEmpleados.TabIndex = 15
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.SteelBlue
        Label7.Location = New Point(19, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 24)
        Label7.TabIndex = 44
        Label7.Text = "Lista de Empleados"
        ' 
        ' pnlDatEmp
        ' 
        pnlDatEmp.BackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        pnlDatEmp.Controls.Add(btnNuevo)
        pnlDatEmp.Controls.Add(txtDNI)
        pnlDatEmp.Controls.Add(txtNom)
        pnlDatEmp.Controls.Add(txtApe)
        pnlDatEmp.Controls.Add(cmbPais)
        pnlDatEmp.Controls.Add(txtDom)
        pnlDatEmp.Controls.Add(txtMail)
        pnlDatEmp.Controls.Add(txtTel)
        pnlDatEmp.Controls.Add(btnGuaMod)
        pnlDatEmp.Controls.Add(btnResEli)
        pnlDatEmp.Controls.Add(btnCreUsu)
        pnlDatEmp.Controls.Add(Label5)
        pnlDatEmp.Controls.Add(Label3)
        pnlDatEmp.Controls.Add(Label4)
        pnlDatEmp.Controls.Add(label11)
        pnlDatEmp.Controls.Add(Label6)
        pnlDatEmp.Controls.Add(Label2)
        pnlDatEmp.Controls.Add(Label1)
        pnlDatEmp.Controls.Add(Label8)
        pnlDatEmp.Controls.Add(PictureBox1)
        pnlDatEmp.Dock = DockStyle.Left
        pnlDatEmp.Location = New Point(0, 0)
        pnlDatEmp.Name = "pnlDatEmp"
        pnlDatEmp.Size = New Size(277, 1041)
        pnlDatEmp.TabIndex = 3
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
        btnNuevo.Location = New Point(140, 296)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(114, 34)
        btnNuevo.TabIndex = 1
        btnNuevo.Text = "   Nuevo"
        btnNuevo.TextAlign = ContentAlignment.MiddleLeft
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' txtDNI
        ' 
        txtDNI.Anchor = AnchorStyles.None
        txtDNI.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtDNI.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDNI.Location = New Point(30, 336)
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
        txtNom.Location = New Point(30, 380)
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
        txtApe.Location = New Point(31, 424)
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
        cmbPais.Location = New Point(31, 468)
        cmbPais.MaxDropDownItems = 5
        cmbPais.MaxLength = 50
        cmbPais.Name = "cmbPais"
        cmbPais.Size = New Size(224, 24)
        cmbPais.TabIndex = 5
        ' 
        ' txtDom
        ' 
        txtDom.Anchor = AnchorStyles.None
        txtDom.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtDom.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtDom.Location = New Point(31, 514)
        txtDom.MaxLength = 100
        txtDom.Name = "txtDom"
        txtDom.Size = New Size(224, 22)
        txtDom.TabIndex = 6
        ' 
        ' txtMail
        ' 
        txtMail.Anchor = AnchorStyles.None
        txtMail.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtMail.Location = New Point(31, 558)
        txtMail.MaxLength = 50
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(224, 22)
        txtMail.TabIndex = 7
        txtMail.Tag = "Teléfono"
        ' 
        ' txtTel
        ' 
        txtTel.Anchor = AnchorStyles.None
        txtTel.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtTel.Location = New Point(30, 605)
        txtTel.MaxLength = 50
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(224, 22)
        txtTel.TabIndex = 8
        txtTel.Tag = "Teléfono"
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
        btnGuaMod.Location = New Point(29, 637)
        btnGuaMod.Name = "btnGuaMod"
        btnGuaMod.Size = New Size(224, 31)
        btnGuaMod.TabIndex = 9
        btnGuaMod.Text = "Guardar"
        btnGuaMod.UseVisualStyleBackColor = False
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
        btnResEli.Location = New Point(29, 674)
        btnResEli.Name = "btnResEli"
        btnResEli.Size = New Size(224, 31)
        btnResEli.TabIndex = 10
        btnResEli.Text = "Eliminar"
        btnResEli.UseVisualStyleBackColor = False
        ' 
        ' btnCreUsu
        ' 
        btnCreUsu.Anchor = AnchorStyles.None
        btnCreUsu.BackColor = Color.SteelBlue
        btnCreUsu.FlatAppearance.BorderColor = Color.SlateGray
        btnCreUsu.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnCreUsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnCreUsu.FlatStyle = FlatStyle.Flat
        btnCreUsu.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreUsu.ForeColor = Color.WhiteSmoke
        btnCreUsu.Image = My.Resources.Resources.icons8_añadir_usuario_masculino_25__1_
        btnCreUsu.ImageAlign = ContentAlignment.MiddleLeft
        btnCreUsu.Location = New Point(30, 711)
        btnCreUsu.Name = "btnCreUsu"
        btnCreUsu.Size = New Size(224, 55)
        btnCreUsu.TabIndex = 11
        btnCreUsu.Text = "Crear Usuario"
        btnCreUsu.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SteelBlue
        Label5.Location = New Point(29, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 24)
        Label5.TabIndex = 43
        Label5.Text = "Datos del Empleado"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 318)
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
        Label4.Location = New Point(30, 361)
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
        label11.Location = New Point(30, 405)
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
        Label6.Location = New Point(31, 449)
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
        Label2.Location = New Point(31, 495)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 16)
        Label2.TabIndex = 41
        Label2.Text = "Domicilio"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label1.Location = New Point(31, 539)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 16)
        Label1.TabIndex = 42
        Label1.Text = "Correo"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.None
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label8.Location = New Point(30, 586)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 16)
        Label8.TabIndex = 51
        Label8.Text = "Teléfono"
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
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmEmp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(1904, 1041)
        Controls.Add(pnlDatEmp)
        Controls.Add(pnlDGVEmp)
        Name = "frmEmp"
        Text = "frmEmp"
        pnlDGVEmp.ResumeLayout(False)
        pnlDGVEmp.PerformLayout()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).EndInit()
        pnlDatEmp.ResumeLayout(False)
        pnlDatEmp.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlDGVEmp As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents rbEmpAct As RadioButton
    Friend WithEvents rbEmpCan As RadioButton
    Friend WithEvents txtBusEmp As TextBox
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents pnlDatEmp As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtDom As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents btnGuaMod As Button
    Friend WithEvents btnResEli As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCreUsu As Button
    Friend WithEvents ep As ErrorProvider
End Class
