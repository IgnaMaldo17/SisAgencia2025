<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrUsu))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        txtUsr = New TextBox()
        txtCon = New TextBox()
        txtReCon = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label1 = New Label()
        ckbMostrar = New CheckBox()
        btnAgrUsu = New Button()
        PictureBox1 = New PictureBox()
        pnlCreUsu = New Panel()
        Label2 = New Label()
        cmbTpUsu = New ComboBox()
        ep = New ErrorProvider(components)
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCreUsu.SuspendLayout()
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
        PictureBox2.Image = My.Resources.Resources.icons8_usuario_nuevo_24
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
        tsslNomUsu.Size = New Size(103, 16)
        tsslNomUsu.TabIndex = 1
        tsslNomUsu.Text = "Crear Usuario"
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
        btnMini.TabIndex = 2
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
        btnExit.TabIndex = 0
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtUsr
        ' 
        txtUsr.Anchor = AnchorStyles.None
        txtUsr.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtUsr.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsr.Location = New Point(30, 261)
        txtUsr.MaxLength = 50
        txtUsr.Name = "txtUsr"
        txtUsr.Size = New Size(257, 22)
        txtUsr.TabIndex = 4
        txtUsr.Tag = "Usuario"
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.None
        txtCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCon.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCon.Location = New Point(30, 305)
        txtCon.MaxLength = 50
        txtCon.Name = "txtCon"
        txtCon.PasswordChar = "*"c
        txtCon.Size = New Size(257, 22)
        txtCon.TabIndex = 6
        txtCon.Tag = "Contraseña"
        ' 
        ' txtReCon
        ' 
        txtReCon.Anchor = AnchorStyles.None
        txtReCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtReCon.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtReCon.Location = New Point(30, 349)
        txtReCon.MaxLength = 50
        txtReCon.Name = "txtReCon"
        txtReCon.PasswordChar = "*"c
        txtReCon.Size = New Size(257, 22)
        txtReCon.TabIndex = 8
        txtReCon.Tag = "Repetir contraseña"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label3.Location = New Point(30, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 16)
        Label3.TabIndex = 3
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(30, 286)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 16)
        Label4.TabIndex = 5
        Label4.Text = "Contraseña"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        label11.Location = New Point(30, 330)
        label11.Name = "label11"
        label11.Size = New Size(121, 16)
        label11.TabIndex = 7
        label11.Text = "Repetir contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Image = My.Resources.Resources.icons8_empleado_nuevo_181
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 13)
        Label1.TabIndex = 0
        Label1.Text = "       0123456789012012345678901234567890123456789"
        ' 
        ' ckbMostrar
        ' 
        ckbMostrar.Appearance = Appearance.Button
        ckbMostrar.AutoSize = True
        ckbMostrar.FlatAppearance.BorderSize = 0
        ckbMostrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        ckbMostrar.FlatStyle = FlatStyle.Flat
        ckbMostrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbMostrar.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbMostrar.Image = My.Resources.Resources.icons8_invisible_nuevo_241
        ckbMostrar.ImageAlign = ContentAlignment.MiddleLeft
        ckbMostrar.Location = New Point(30, 370)
        ckbMostrar.Name = "ckbMostrar"
        ckbMostrar.Size = New Size(35, 30)
        ckbMostrar.TabIndex = 9
        ckbMostrar.Text = "    "
        ckbMostrar.UseVisualStyleBackColor = True
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
        btnAgrUsu.Location = New Point(30, 406)
        btnAgrUsu.Name = "btnAgrUsu"
        btnAgrUsu.Size = New Size(257, 54)
        btnAgrUsu.TabIndex = 10
        btnAgrUsu.Text = "Agregar"
        btnAgrUsu.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_usuario_nuevo_100
        PictureBox1.Location = New Point(84, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' pnlCreUsu
        ' 
        pnlCreUsu.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlCreUsu.Controls.Add(Label2)
        pnlCreUsu.Controls.Add(cmbTpUsu)
        pnlCreUsu.Controls.Add(txtUsr)
        pnlCreUsu.Controls.Add(Label1)
        pnlCreUsu.Controls.Add(PictureBox1)
        pnlCreUsu.Controls.Add(btnAgrUsu)
        pnlCreUsu.Controls.Add(txtCon)
        pnlCreUsu.Controls.Add(txtReCon)
        pnlCreUsu.Controls.Add(Label3)
        pnlCreUsu.Controls.Add(Label4)
        pnlCreUsu.Controls.Add(label11)
        pnlCreUsu.Controls.Add(ckbMostrar)
        pnlCreUsu.Location = New Point(3, 34)
        pnlCreUsu.Name = "pnlCreUsu"
        pnlCreUsu.Size = New Size(312, 482)
        pnlCreUsu.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(30, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 16)
        Label2.TabIndex = 1
        Label2.Text = "Tipo de Usuario"
        ' 
        ' cmbTpUsu
        ' 
        cmbTpUsu.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        cmbTpUsu.FormattingEnabled = True
        cmbTpUsu.Location = New Point(30, 216)
        cmbTpUsu.Name = "cmbTpUsu"
        cmbTpUsu.Size = New Size(257, 23)
        cmbTpUsu.TabIndex = 2
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmAgrUsu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(318, 519)
        Controls.Add(pnlCreUsu)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAgrUsu"
        Text = "Crear Usuario"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCreUsu.ResumeLayout(False)
        pnlCreUsu.PerformLayout()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtUsr As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtReCon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ckbMostrar As CheckBox
    Friend WithEvents btnAgrUsu As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlCreUsu As Panel
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTpUsu As ComboBox
End Class
