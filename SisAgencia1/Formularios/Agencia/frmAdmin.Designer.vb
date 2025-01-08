<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        pnlCreUsu = New Panel()
        txtCon = New TextBox()
        PictureBox1 = New PictureBox()
        btnAgrUsu = New Button()
        txtUsu = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        ckbMosCon = New CheckBox()
        ep = New ErrorProvider(components)
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlCreUsu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        pnlMnuTool.Size = New Size(318, 34)
        pnlMnuTool.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_usuario_253
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
        tsslNomUsu.Size = New Size(96, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Inicio ADMIN"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(244, 0)
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
        btnExit.Location = New Point(281, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlCreUsu
        ' 
        pnlCreUsu.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlCreUsu.Controls.Add(txtCon)
        pnlCreUsu.Controls.Add(PictureBox1)
        pnlCreUsu.Controls.Add(btnAgrUsu)
        pnlCreUsu.Controls.Add(txtUsu)
        pnlCreUsu.Controls.Add(Label3)
        pnlCreUsu.Controls.Add(Label4)
        pnlCreUsu.Controls.Add(ckbMosCon)
        pnlCreUsu.Location = New Point(3, 34)
        pnlCreUsu.Name = "pnlCreUsu"
        pnlCreUsu.Size = New Size(312, 369)
        pnlCreUsu.TabIndex = 1
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.None
        txtCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCon.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCon.Location = New Point(30, 229)
        txtCon.MaxLength = 50
        txtCon.Name = "txtCon"
        txtCon.PasswordChar = "*"c
        txtCon.Size = New Size(257, 22)
        txtCon.TabIndex = 3
        txtCon.Tag = "Usuario"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_usuario_nuevo_100
        PictureBox1.Location = New Point(83, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' btnAgrUsu
        ' 
        btnAgrUsu.BackColor = Color.Green
        btnAgrUsu.FlatAppearance.BorderColor = Color.SlateGray
        btnAgrUsu.FlatAppearance.BorderSize = 0
        btnAgrUsu.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnAgrUsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnAgrUsu.FlatStyle = FlatStyle.Flat
        btnAgrUsu.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrUsu.ForeColor = Color.White
        btnAgrUsu.Image = My.Resources.Resources.icons8_más_24
        btnAgrUsu.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrUsu.Location = New Point(30, 293)
        btnAgrUsu.Name = "btnAgrUsu"
        btnAgrUsu.Size = New Size(257, 54)
        btnAgrUsu.TabIndex = 5
        btnAgrUsu.Text = "Agregar"
        btnAgrUsu.UseVisualStyleBackColor = False
        ' 
        ' txtUsu
        ' 
        txtUsu.Anchor = AnchorStyles.None
        txtUsu.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtUsu.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtUsu.Location = New Point(30, 185)
        txtUsu.MaxLength = 50
        txtUsu.Name = "txtUsu"
        txtUsu.Size = New Size(257, 22)
        txtUsu.TabIndex = 1
        txtUsu.Tag = "Repetir contraseña"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(30, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 16)
        Label3.TabIndex = 0
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(30, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 16)
        Label4.TabIndex = 2
        Label4.Text = "Contraseña"
        ' 
        ' ckbMosCon
        ' 
        ckbMosCon.Appearance = Appearance.Button
        ckbMosCon.AutoSize = True
        ckbMosCon.FlatAppearance.BorderSize = 0
        ckbMosCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        ckbMosCon.FlatStyle = FlatStyle.Flat
        ckbMosCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbMosCon.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbMosCon.Image = My.Resources.Resources.icons8_invisible_nuevo_241
        ckbMosCon.ImageAlign = ContentAlignment.MiddleLeft
        ckbMosCon.Location = New Point(30, 257)
        ckbMosCon.Name = "ckbMosCon"
        ckbMosCon.Size = New Size(35, 30)
        ckbMosCon.TabIndex = 4
        ckbMosCon.Text = "    "
        ckbMosCon.UseVisualStyleBackColor = True
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(318, 406)
        Controls.Add(pnlCreUsu)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAdmin"
        Text = "Inicio ADMIN"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlCreUsu.ResumeLayout(False)
        pnlCreUsu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlCreUsu As Panel
    Friend WithEvents txtCon As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgrUsu As Button
    Friend WithEvents txtUsu As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ckbMosCon As CheckBox
    Friend WithEvents ep As ErrorProvider
End Class
