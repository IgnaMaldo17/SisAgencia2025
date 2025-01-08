<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        pnlCreUsu = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        cmbCot = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        txtCon = New TextBox()
        PictureBox1 = New PictureBox()
        btnCamCon = New Button()
        Label4 = New Label()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlCreUsu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlMnuTool.Size = New Size(485, 34)
        pnlMnuTool.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
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
        tsslNomUsu.Size = New Size(123, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Cambiar Valores"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(411, 0)
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
        btnExit.Location = New Point(448, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlCreUsu
        ' 
        pnlCreUsu.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlCreUsu.Controls.Add(Label7)
        pnlCreUsu.Controls.Add(Label6)
        pnlCreUsu.Controls.Add(Label5)
        pnlCreUsu.Controls.Add(cmbCot)
        pnlCreUsu.Controls.Add(Label2)
        pnlCreUsu.Controls.Add(Label1)
        pnlCreUsu.Controls.Add(txtCon)
        pnlCreUsu.Controls.Add(PictureBox1)
        pnlCreUsu.Controls.Add(btnCamCon)
        pnlCreUsu.Controls.Add(Label4)
        pnlCreUsu.Location = New Point(3, 35)
        pnlCreUsu.Name = "pnlCreUsu"
        pnlCreUsu.Size = New Size(478, 238)
        pnlCreUsu.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label7.Location = New Point(9, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 20)
        Label7.TabIndex = 59
        Label7.Text = "Cambiar valor:"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label6.Location = New Point(9, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(158, 20)
        Label6.TabIndex = 58
        Label6.Text = "Seleccionar moneda:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label5.Location = New Point(160, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(184, 20)
        Label5.TabIndex = 57
        Label5.Text = "Seleccioné una moneda."
        ' 
        ' cmbCot
        ' 
        cmbCot.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cmbCot.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        cmbCot.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCot.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbCot.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        cmbCot.FormattingEnabled = True
        cmbCot.Location = New Point(9, 93)
        cmbCot.Name = "cmbCot"
        cmbCot.Size = New Size(461, 28)
        cmbCot.TabIndex = 56
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label2.Location = New Point(71, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 24)
        Label2.TabIndex = 55
        Label2.Text = "Valor actual:"
        Label2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(195, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 54
        Label1.Text = "ValorActual"
        Label1.Visible = False
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtCon.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtCon.Enabled = False
        txtCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCon.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtCon.Location = New Point(9, 148)
        txtCon.MaxLength = 50
        txtCon.Name = "txtCon"
        txtCon.Size = New Size(461, 26)
        txtCon.TabIndex = 2
        txtCon.Tag = "Usuario"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_circular_argentina_48
        PictureBox1.Location = New Point(16, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(49, 49)
        PictureBox1.TabIndex = 53
        PictureBox1.TabStop = False
        ' 
        ' btnCamCon
        ' 
        btnCamCon.BackColor = Color.Green
        btnCamCon.Enabled = False
        btnCamCon.FlatAppearance.BorderColor = Color.SlateGray
        btnCamCon.FlatAppearance.BorderSize = 0
        btnCamCon.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnCamCon.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnCamCon.FlatStyle = FlatStyle.Flat
        btnCamCon.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCamCon.ForeColor = Color.White
        btnCamCon.Image = My.Resources.Resources.icons8_más_24
        btnCamCon.ImageAlign = ContentAlignment.MiddleLeft
        btnCamCon.Location = New Point(295, 190)
        btnCamCon.Name = "btnCamCon"
        btnCamCon.Size = New Size(168, 37)
        btnCamCon.TabIndex = 8
        btnCamCon.Text = " Modificar"
        btnCamCon.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label4.Location = New Point(71, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 24)
        Label4.TabIndex = 3
        Label4.Text = "Nombre:"
        ' 
        ' frmConfig
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(485, 276)
        Controls.Add(pnlCreUsu)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmConfig"
        Text = "frmConfig"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlCreUsu.ResumeLayout(False)
        pnlCreUsu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnCamCon As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCot As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
