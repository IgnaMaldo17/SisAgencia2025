<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContraseña))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        pnlCreUsu = New Panel()
        txtCon = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnCamCon = New Button()
        txtConNew = New TextBox()
        txtReConNew = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        ckbMostrar = New CheckBox()
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
        PictureBox2.Image = My.Resources.Resources.icons8_contraseña_24
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
        tsslNomUsu.Size = New Size(154, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Modificar Contraseña"
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
        pnlCreUsu.Controls.Add(Label1)
        pnlCreUsu.Controls.Add(PictureBox1)
        pnlCreUsu.Controls.Add(btnCamCon)
        pnlCreUsu.Controls.Add(txtConNew)
        pnlCreUsu.Controls.Add(txtReConNew)
        pnlCreUsu.Controls.Add(Label3)
        pnlCreUsu.Controls.Add(Label4)
        pnlCreUsu.Controls.Add(label11)
        pnlCreUsu.Controls.Add(ckbMostrar)
        pnlCreUsu.Location = New Point(3, 27)
        pnlCreUsu.Name = "pnlCreUsu"
        pnlCreUsu.Size = New Size(312, 450)
        pnlCreUsu.TabIndex = 1
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.None
        txtCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCon.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCon.Location = New Point(30, 222)
        txtCon.MaxLength = 50
        txtCon.Name = "txtCon"
        txtCon.PasswordChar = "*"c
        txtCon.Size = New Size(257, 22)
        txtCon.TabIndex = 2
        txtCon.Tag = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Image = My.Resources.Resources.icons8_empleado_nuevo_183
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 13)
        Label1.TabIndex = 0
        Label1.Text = "       0123456789012012345678901234567890123456789"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_usuario_nuevo_1001
        PictureBox1.Location = New Point(84, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(144, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' btnCamCon
        ' 
        btnCamCon.BackColor = Color.Green
        btnCamCon.FlatAppearance.BorderColor = Color.SlateGray
        btnCamCon.FlatAppearance.BorderSize = 0
        btnCamCon.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnCamCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnCamCon.FlatStyle = FlatStyle.Flat
        btnCamCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCamCon.ForeColor = Color.White
        btnCamCon.Image = My.Resources.Resources.icons8_más_24
        btnCamCon.ImageAlign = ContentAlignment.MiddleLeft
        btnCamCon.Location = New Point(30, 370)
        btnCamCon.Name = "btnCamCon"
        btnCamCon.Size = New Size(257, 54)
        btnCamCon.TabIndex = 8
        btnCamCon.Text = "Agregar"
        btnCamCon.UseVisualStyleBackColor = False
        ' 
        ' txtConNew
        ' 
        txtConNew.Anchor = AnchorStyles.None
        txtConNew.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtConNew.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtConNew.Location = New Point(30, 266)
        txtConNew.MaxLength = 50
        txtConNew.Name = "txtConNew"
        txtConNew.PasswordChar = "*"c
        txtConNew.Size = New Size(257, 22)
        txtConNew.TabIndex = 4
        txtConNew.Tag = "Contraseña"
        ' 
        ' txtReConNew
        ' 
        txtReConNew.Anchor = AnchorStyles.None
        txtReConNew.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtReConNew.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtReConNew.Location = New Point(30, 310)
        txtReConNew.MaxLength = 50
        txtReConNew.Name = "txtReConNew"
        txtReConNew.PasswordChar = "*"c
        txtReConNew.Size = New Size(257, 22)
        txtReConNew.TabIndex = 6
        txtReConNew.Tag = "Repetir contraseña"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 16)
        Label3.TabIndex = 1
        Label3.Text = "Contraseña actual"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.Location = New Point(30, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 16)
        Label4.TabIndex = 3
        Label4.Text = "Contraseña nueva"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.Location = New Point(30, 291)
        label11.Name = "label11"
        label11.Size = New Size(161, 16)
        label11.TabIndex = 5
        label11.Text = "Repetir contraseña nueva"
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
        ckbMostrar.Image = My.Resources.Resources.icons8_invisible_nuevo_243
        ckbMostrar.ImageAlign = ContentAlignment.MiddleLeft
        ckbMostrar.Location = New Point(30, 334)
        ckbMostrar.Name = "ckbMostrar"
        ckbMostrar.Size = New Size(35, 30)
        ckbMostrar.TabIndex = 7
        ckbMostrar.Text = "    "
        ckbMostrar.UseVisualStyleBackColor = True
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmContraseña
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(318, 480)
        Controls.Add(pnlMnuTool)
        Controls.Add(pnlCreUsu)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmContraseña"
        Text = "Modificar Contraseña"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCamCon As Button
    Friend WithEvents txtConNew As TextBox
    Friend WithEvents txtReConNew As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents ckbMostrar As CheckBox
    Friend WithEvents ep As ErrorProvider
End Class
