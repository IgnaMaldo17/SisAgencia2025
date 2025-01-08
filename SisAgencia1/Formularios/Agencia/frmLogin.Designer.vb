<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        epLogin = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        btnSalirLog = New Button()
        Panel1 = New Panel()
        ckbMosCon = New CheckBox()
        btnMiniLog = New Button()
        PictureBox2 = New PictureBox()
        btnIngresar = New Button()
        lblContraseña = New Label()
        lblUsuario = New Label()
        txtContrasena = New TextBox()
        txtUsuario = New TextBox()
        CType(epLogin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' epLogin
        ' 
        epLogin.ContainerControl = Me
        epLogin.Icon = CType(resources.GetObject("epLogin.Icon"), Icon)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = My.Resources.Resources.pixelcut_export
        PictureBox1.Location = New Point(0, -7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 357)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnSalirLog
        ' 
        btnSalirLog.Anchor = AnchorStyles.None
        btnSalirLog.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnSalirLog.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnSalirLog.FlatAppearance.BorderSize = 0
        btnSalirLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnSalirLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnSalirLog.FlatStyle = FlatStyle.Flat
        btnSalirLog.Font = New Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalirLog.ForeColor = Color.White
        btnSalirLog.Image = My.Resources.Resources.icons8_x_24__1_
        btnSalirLog.Location = New Point(320, 5)
        btnSalirLog.Name = "btnSalirLog"
        btnSalirLog.Size = New Size(38, 34)
        btnSalirLog.TabIndex = 1
        btnSalirLog.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(ckbMosCon)
        Panel1.Controls.Add(btnMiniLog)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnSalirLog)
        Panel1.Controls.Add(btnIngresar)
        Panel1.Controls.Add(lblContraseña)
        Panel1.Controls.Add(lblUsuario)
        Panel1.Controls.Add(txtContrasena)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Location = New Point(251, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(361, 350)
        Panel1.TabIndex = 0
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
        ckbMosCon.Image = My.Resources.Resources.icons8_invisible_nuevo_243
        ckbMosCon.ImageAlign = ContentAlignment.MiddleLeft
        ckbMosCon.Location = New Point(85, 237)
        ckbMosCon.Name = "ckbMosCon"
        ckbMosCon.Size = New Size(35, 30)
        ckbMosCon.TabIndex = 6
        ckbMosCon.Text = "    "
        ckbMosCon.UseVisualStyleBackColor = True
        ' 
        ' btnMiniLog
        ' 
        btnMiniLog.Anchor = AnchorStyles.None
        btnMiniLog.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnMiniLog.FlatAppearance.BorderColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnMiniLog.FlatAppearance.BorderSize = 0
        btnMiniLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnMiniLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        btnMiniLog.FlatStyle = FlatStyle.Flat
        btnMiniLog.Font = New Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMiniLog.ForeColor = Color.White
        btnMiniLog.Image = My.Resources.Resources.icons8_minimizar_24__1_
        btnMiniLog.Location = New Point(279, 5)
        btnMiniLog.Name = "btnMiniLog"
        btnMiniLog.Size = New Size(38, 34)
        btnMiniLog.TabIndex = 0
        btnMiniLog.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(98, 23)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(165, 105)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnIngresar.FlatAppearance.BorderSize = 0
        btnIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnIngresar.FlatStyle = FlatStyle.Flat
        btnIngresar.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Location = New Point(85, 278)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(192, 44)
        btnIngresar.TabIndex = 7
        btnIngresar.Text = "Iniciar Sesión"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' lblContraseña
        ' 
        lblContraseña.AutoSize = True
        lblContraseña.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContraseña.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        lblContraseña.Location = New Point(85, 193)
        lblContraseña.Name = "lblContraseña"
        lblContraseña.Size = New Size(76, 16)
        lblContraseña.TabIndex = 4
        lblContraseña.Text = "Contraseña"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsuario.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        lblUsuario.Location = New Point(85, 140)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(54, 16)
        lblUsuario.TabIndex = 2
        lblUsuario.Text = "Usuario"
        ' 
        ' txtContrasena
        ' 
        txtContrasena.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtContrasena.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContrasena.Location = New Point(85, 211)
        txtContrasena.MaxLength = 50
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(192, 21)
        txtContrasena.TabIndex = 5
        ' 
        ' txtUsuario
        ' 
        txtUsuario.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtUsuario.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(85, 158)
        txtUsuario.MaxLength = 50
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 21)
        txtUsuario.TabIndex = 3
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(612, 349)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        Text = "Conquista tu Mundo Logueo"
        CType(epLogin, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents epLogin As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalirLog As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMiniLog As Button
    Friend WithEvents ckbMosCon As CheckBox
End Class
