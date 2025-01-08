<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelefonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelefonos))
        ep = New ErrorProvider(components)
        pnlMnuTool = New Panel()
        PictureBox1 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnMiniMax = New Button()
        btnExit = New Button()
        Timer1 = New Timer(components)
        Panel1 = New Panel()
        gbDatoTel = New GroupBox()
        Label1 = New Label()
        txtAgrTel = New TextBox()
        btnAgrMod = New Button()
        btnEliRes = New Button()
        btnCancelar = New Button()
        gbTelefonos = New GroupBox()
        dgvTelefonos = New DataGridView()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        gbDatoTel.SuspendLayout()
        gbTelefonos.SuspendLayout()
        CType(dgvTelefonos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMnuTool.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuTool.Controls.Add(PictureBox1)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnMiniMax)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(806, 34)
        pnlMnuTool.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.icons8_teléfono_254
        PictureBox1.Location = New Point(7, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(34, 28)
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(159, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Teléfonos de Clientes"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(695, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 34)
        btnMini.TabIndex = 1
        btnMini.UseVisualStyleBackColor = False
        btnMini.Visible = False
        ' 
        ' btnMiniMax
        ' 
        btnMiniMax.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMiniMax.Dock = DockStyle.Right
        btnMiniMax.FlatAppearance.BorderSize = 0
        btnMiniMax.FlatStyle = FlatStyle.Flat
        btnMiniMax.Image = My.Resources.Resources.icons8_agrandar_25
        btnMiniMax.Location = New Point(732, 0)
        btnMiniMax.Name = "btnMiniMax"
        btnMiniMax.Size = New Size(37, 34)
        btnMiniMax.TabIndex = 2
        btnMiniMax.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_x_242
        btnExit.Location = New Point(769, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(gbDatoTel)
        Panel1.Controls.Add(btnAgrMod)
        Panel1.Controls.Add(btnEliRes)
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(gbTelefonos)
        Panel1.Location = New Point(4, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(797, 480)
        Panel1.TabIndex = 1
        ' 
        ' gbDatoTel
        ' 
        gbDatoTel.Controls.Add(Label1)
        gbDatoTel.Controls.Add(txtAgrTel)
        gbDatoTel.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbDatoTel.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        gbDatoTel.Location = New Point(3, 8)
        gbDatoTel.Name = "gbDatoTel"
        gbDatoTel.Size = New Size(393, 62)
        gbDatoTel.TabIndex = 0
        gbDatoTel.TabStop = False
        gbDatoTel.Text = "Datos Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(6, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 16)
        Label1.TabIndex = 0
        Label1.Text = "Teléfono"
        ' 
        ' txtAgrTel
        ' 
        txtAgrTel.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtAgrTel.Enabled = False
        txtAgrTel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAgrTel.Location = New Point(74, 35)
        txtAgrTel.MaxLength = 50
        txtAgrTel.Name = "txtAgrTel"
        txtAgrTel.Size = New Size(291, 21)
        txtAgrTel.TabIndex = 1
        txtAgrTel.Tag = "Teléfono"
        ' 
        ' btnAgrMod
        ' 
        btnAgrMod.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnAgrMod.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnAgrMod.FlatAppearance.BorderSize = 0
        btnAgrMod.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnAgrMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnAgrMod.FlatStyle = FlatStyle.Flat
        btnAgrMod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrMod.ForeColor = Color.White
        btnAgrMod.Image = My.Resources.Resources.icons8_más_24
        btnAgrMod.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrMod.Location = New Point(402, 33)
        btnAgrMod.Name = "btnAgrMod"
        btnAgrMod.Size = New Size(121, 31)
        btnAgrMod.TabIndex = 1
        btnAgrMod.Text = "    Agregar"
        btnAgrMod.UseVisualStyleBackColor = False
        ' 
        ' btnEliRes
        ' 
        btnEliRes.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEliRes.FlatAppearance.BorderColor = Color.FromArgb(CByte(15), CByte(31), CByte(55))
        btnEliRes.FlatAppearance.BorderSize = 0
        btnEliRes.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEliRes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnEliRes.FlatStyle = FlatStyle.Flat
        btnEliRes.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliRes.ForeColor = Color.White
        btnEliRes.Image = My.Resources.Resources.icons8_menos_25
        btnEliRes.ImageAlign = ContentAlignment.MiddleLeft
        btnEliRes.Location = New Point(529, 33)
        btnEliRes.Name = "btnEliRes"
        btnEliRes.Size = New Size(121, 31)
        btnEliRes.TabIndex = 2
        btnEliRes.Text = "    Eliminar"
        btnEliRes.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Firebrick
        btnCancelar.FlatAppearance.BorderColor = Color.Maroon
        btnCancelar.FlatAppearance.BorderSize = 0
        btnCancelar.FlatAppearance.MouseDownBackColor = Color.Firebrick
        btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.Image = My.Resources.Resources.icons8_cancelar_25
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(656, 33)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(121, 31)
        btnCancelar.TabIndex = 3
        btnCancelar.Text = "    Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' gbTelefonos
        ' 
        gbTelefonos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gbTelefonos.Controls.Add(dgvTelefonos)
        gbTelefonos.Location = New Point(3, 63)
        gbTelefonos.Name = "gbTelefonos"
        gbTelefonos.Size = New Size(791, 408)
        gbTelefonos.TabIndex = 4
        gbTelefonos.TabStop = False
        ' 
        ' dgvTelefonos
        ' 
        dgvTelefonos.AllowUserToAddRows = False
        dgvTelefonos.AllowUserToDeleteRows = False
        dgvTelefonos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTelefonos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTelefonos.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTelefonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTelefonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        dgvTelefonos.Location = New Point(6, 13)
        dgvTelefonos.Name = "dgvTelefonos"
        dgvTelefonos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvTelefonos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvTelefonos.RowHeadersVisible = False
        dgvTelefonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTelefonos.Size = New Size(779, 389)
        dgvTelefonos.TabIndex = 0
        ' 
        ' frmTelefonos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(804, 517)
        Controls.Add(Panel1)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmTelefonos"
        Text = "Teléfonos de Clientes"
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        gbDatoTel.ResumeLayout(False)
        gbDatoTel.PerformLayout()
        gbTelefonos.ResumeLayout(False)
        CType(dgvTelefonos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMiniMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliRes As Button
    Friend WithEvents btnAgrMod As Button
    Friend WithEvents gbDatoTel As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbTelefonos As GroupBox
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents txtAgrTel As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
