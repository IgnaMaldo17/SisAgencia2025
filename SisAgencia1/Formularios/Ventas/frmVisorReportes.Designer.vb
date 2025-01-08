<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorReportes))
        Panel1 = New Panel()
        btnSelFav = New Button()
        lblPpal = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        Label1 = New Label()
        ckbUsu = New CheckBox()
        ckbEmp = New CheckBox()
        ckbVeh = New CheckBox()
        Label5 = New Label()
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        ep = New ErrorProvider(components)
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(btnSelFav)
        Panel1.Controls.Add(lblPpal)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(CheckBox6)
        Panel1.Controls.Add(CheckBox5)
        Panel1.Controls.Add(CheckBox4)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ckbUsu)
        Panel1.Controls.Add(ckbEmp)
        Panel1.Controls.Add(ckbVeh)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(2, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(570, 458)
        Panel1.TabIndex = 64
        ' 
        ' btnSelFav
        ' 
        btnSelFav.BackColor = Color.Green
        btnSelFav.FlatAppearance.BorderColor = Color.SlateGray
        btnSelFav.FlatAppearance.BorderSize = 0
        btnSelFav.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnSelFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnSelFav.FlatStyle = FlatStyle.Flat
        btnSelFav.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelFav.ForeColor = Color.White
        btnSelFav.Image = My.Resources.Resources.icons8_agregar_a_carrito_de_compras_245
        btnSelFav.ImageAlign = ContentAlignment.MiddleLeft
        btnSelFav.Location = New Point(206, 400)
        btnSelFav.Name = "btnSelFav"
        btnSelFav.Size = New Size(354, 43)
        btnSelFav.TabIndex = 79
        btnSelFav.Text = "   Finalizar Venta y Mostrar Voucher"
        btnSelFav.UseVisualStyleBackColor = False
        ' 
        ' lblPpal
        ' 
        lblPpal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblPpal.AutoSize = True
        lblPpal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPpal.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        lblPpal.Location = New Point(38, 330)
        lblPpal.Name = "lblPpal"
        lblPpal.Size = New Size(197, 20)
        lblPpal.TabIndex = 77
        lblPpal.Text = "Seleccionar tipo de tarjeta:"
        lblPpal.Visible = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Crédito", "Débito"})
        ComboBox1.Location = New Point(38, 353)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(461, 28)
        ComboBox1.TabIndex = 76
        ComboBox1.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        TextBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        TextBox1.Location = New Point(38, 353)
        TextBox1.MaxLength = 25
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(461, 26)
        TextBox1.TabIndex = 75
        TextBox1.Tag = "Usuario"
        TextBox1.Visible = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.Appearance = Appearance.Button
        CheckBox6.AutoSize = True
        CheckBox6.FlatAppearance.BorderSize = 0
        CheckBox6.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox6.FlatStyle = FlatStyle.Flat
        CheckBox6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox6.Image = My.Resources.Resources.icons8_circular_brasil_48
        CheckBox6.ImageAlign = ContentAlignment.TopCenter
        CheckBox6.Location = New Point(135, 79)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(85, 73)
        CheckBox6.TabIndex = 74
        CheckBox6.Tag = "10"
        CheckBox6.Text = "   Real BRA  "
        CheckBox6.TextAlign = ContentAlignment.BottomCenter
        CheckBox6.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.Appearance = Appearance.Button
        CheckBox5.AutoSize = True
        CheckBox5.FlatAppearance.BorderSize = 0
        CheckBox5.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox5.FlatStyle = FlatStyle.Flat
        CheckBox5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox5.Image = My.Resources.Resources.icons8_efectivo_48
        CheckBox5.ImageAlign = ContentAlignment.TopCenter
        CheckBox5.Location = New Point(435, 240)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(89, 73)
        CheckBox5.TabIndex = 73
        CheckBox5.Tag = "10"
        CheckBox5.Text = "     Efectivo     "
        CheckBox5.TextAlign = ContentAlignment.BottomCenter
        CheckBox5.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Appearance = Appearance.Button
        CheckBox4.AutoSize = True
        CheckBox4.FlatAppearance.BorderSize = 0
        CheckBox4.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox4.FlatStyle = FlatStyle.Flat
        CheckBox4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox4.Image = My.Resources.Resources.icons8_mercado_pago_48
        CheckBox4.ImageAlign = ContentAlignment.TopCenter
        CheckBox4.Location = New Point(331, 240)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(98, 73)
        CheckBox4.TabIndex = 72
        CheckBox4.Tag = "10"
        CheckBox4.Text = "Mercado Pago"
        CheckBox4.TextAlign = ContentAlignment.BottomCenter
        CheckBox4.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.AutoSize = True
        CheckBox1.FlatAppearance.BorderSize = 0
        CheckBox1.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox1.Image = My.Resources.Resources.icons8_american_express_al_cuadrado_48
        CheckBox1.ImageAlign = ContentAlignment.TopCenter
        CheckBox1.Location = New Point(232, 240)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(93, 73)
        CheckBox1.TabIndex = 71
        CheckBox1.Tag = "10"
        CheckBox1.Text = "American Exp"
        CheckBox1.TextAlign = ContentAlignment.BottomCenter
        CheckBox1.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Appearance = Appearance.Button
        CheckBox2.AutoSize = True
        CheckBox2.FlatAppearance.BorderSize = 0
        CheckBox2.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox2.FlatStyle = FlatStyle.Flat
        CheckBox2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox2.Image = My.Resources.Resources.icons8_visa_48
        CheckBox2.ImageAlign = ContentAlignment.TopCenter
        CheckBox2.Location = New Point(135, 240)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(91, 73)
        CheckBox2.TabIndex = 70
        CheckBox2.Tag = "9"
        CheckBox2.Text = "        Visa         "
        CheckBox2.TextAlign = ContentAlignment.BottomCenter
        CheckBox2.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.Appearance = Appearance.Button
        CheckBox3.AutoSize = True
        CheckBox3.FlatAppearance.BorderSize = 0
        CheckBox3.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        CheckBox3.FlatStyle = FlatStyle.Flat
        CheckBox3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CheckBox3.Image = My.Resources.Resources.icons8_mastercard_48
        CheckBox3.ImageAlign = ContentAlignment.TopCenter
        CheckBox3.Location = New Point(38, 240)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(91, 73)
        CheckBox3.TabIndex = 69
        CheckBox3.Tag = "8"
        CheckBox3.Text = "  Mastercard  "
        CheckBox3.TextAlign = ContentAlignment.BottomCenter
        CheckBox3.TextImageRelation = TextImageRelation.ImageAboveText
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(23, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 37)
        Label1.TabIndex = 68
        Label1.Text = "Seleccionar Medio de Pago"
        ' 
        ' ckbUsu
        ' 
        ckbUsu.Appearance = Appearance.Button
        ckbUsu.AutoSize = True
        ckbUsu.FlatAppearance.BorderSize = 0
        ckbUsu.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbUsu.FlatStyle = FlatStyle.Flat
        ckbUsu.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbUsu.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbUsu.Image = My.Resources.Resources.icons8_bandera_circular_de_union_europea_48
        ckbUsu.ImageAlign = ContentAlignment.TopCenter
        ckbUsu.Location = New Point(232, 79)
        ckbUsu.Name = "ckbUsu"
        ckbUsu.Size = New Size(82, 73)
        ckbUsu.TabIndex = 67
        ckbUsu.Tag = "10"
        ckbUsu.Text = "     EURO     "
        ckbUsu.TextAlign = ContentAlignment.BottomCenter
        ckbUsu.TextImageRelation = TextImageRelation.ImageAboveText
        ckbUsu.UseVisualStyleBackColor = True
        ' 
        ' ckbEmp
        ' 
        ckbEmp.Appearance = Appearance.Button
        ckbEmp.AutoSize = True
        ckbEmp.FlatAppearance.BorderSize = 0
        ckbEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbEmp.FlatStyle = FlatStyle.Flat
        ckbEmp.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbEmp.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbEmp.Image = My.Resources.Resources.icons8_circular_de_ee_uu_48
        ckbEmp.ImageAlign = ContentAlignment.TopCenter
        ckbEmp.Location = New Point(331, 79)
        ckbEmp.Name = "ckbEmp"
        ckbEmp.Size = New Size(83, 73)
        ckbEmp.TabIndex = 66
        ckbEmp.Tag = "9"
        ckbEmp.Text = "  Dólar USA "
        ckbEmp.TextAlign = ContentAlignment.BottomCenter
        ckbEmp.TextImageRelation = TextImageRelation.ImageAboveText
        ckbEmp.UseVisualStyleBackColor = True
        ' 
        ' ckbVeh
        ' 
        ckbVeh.Appearance = Appearance.Button
        ckbVeh.AutoSize = True
        ckbVeh.FlatAppearance.BorderSize = 0
        ckbVeh.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbVeh.FlatStyle = FlatStyle.Flat
        ckbVeh.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbVeh.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbVeh.Image = My.Resources.Resources.icons8_circular_argentina_48
        ckbVeh.ImageAlign = ContentAlignment.TopCenter
        ckbVeh.Location = New Point(38, 79)
        ckbVeh.Name = "ckbVeh"
        ckbVeh.Size = New Size(85, 73)
        ckbVeh.TabIndex = 65
        ckbVeh.Tag = "8"
        ckbVeh.Text = "  Peso ARG  "
        ckbVeh.TextAlign = ContentAlignment.BottomCenter
        ckbVeh.TextImageRelation = TextImageRelation.ImageAboveText
        ckbVeh.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label5.Location = New Point(23, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(325, 37)
        Label5.TabIndex = 64
        Label5.Text = "Seleccionar Moneda"
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuTool.Controls.Add(PictureBox2)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(574, 34)
        pnlMnuTool.TabIndex = 65
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_ventas_2431
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 101
        PictureBox2.TabStop = False
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(272, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Seleccionar Moneda y Medio de Pago"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(500, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 34)
        btnMini.TabIndex = 1
        btnMini.UseVisualStyleBackColor = False
        btnMini.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_x_243
        btnExit.Location = New Point(537, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmVisorReportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(574, 495)
        Controls.Add(pnlMnuTool)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmVisorReportes"
        Opacity = 0.9R
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmVisorReportes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPpal As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ckbUsu As CheckBox
    Friend WithEvents ckbEmp As CheckBox
    Friend WithEvents ckbVeh As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSelFav As Button
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
