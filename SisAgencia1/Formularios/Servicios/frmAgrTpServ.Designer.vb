<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrTpServ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrTpServ))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnMiniMax = New Button()
        btnExit = New Button()
        Panel1 = New Panel()
        gbDatoTp = New GroupBox()
        Label1 = New Label()
        txtAgrTel = New TextBox()
        btnAgrMod = New Button()
        btnCancelar = New Button()
        gbTelefonos = New GroupBox()
        dgvTpServicios = New DataGridView()
        ep = New ErrorProvider(components)
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        gbDatoTp.SuspendLayout()
        gbTelefonos.SuspendLayout()
        CType(dgvTpServicios, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMnuTool.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuTool.Controls.Add(PictureBox2)
        pnlMnuTool.Controls.Add(PictureBox1)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnMiniMax)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(613, 34)
        pnlMnuTool.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_servicios_24__1_
        PictureBox2.Location = New Point(11, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 28)
        PictureBox2.TabIndex = 51
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.icons8_teléfono_254
        PictureBox1.Location = New Point(7, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(731, 0)
        PictureBox1.TabIndex = 50
        PictureBox1.TabStop = False
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(38, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(138, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Tipos de Servicios"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(502, 0)
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
        btnMiniMax.Location = New Point(539, 0)
        btnMiniMax.Name = "btnMiniMax"
        btnMiniMax.Size = New Size(37, 34)
        btnMiniMax.TabIndex = 2
        btnMiniMax.UseVisualStyleBackColor = False
        btnMiniMax.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_x_243
        btnExit.Location = New Point(576, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 3
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(gbDatoTp)
        Panel1.Controls.Add(btnAgrMod)
        Panel1.Controls.Add(btnCancelar)
        Panel1.Controls.Add(gbTelefonos)
        Panel1.Location = New Point(3, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(605, 260)
        Panel1.TabIndex = 2
        ' 
        ' gbDatoTp
        ' 
        gbDatoTp.Controls.Add(Label1)
        gbDatoTp.Controls.Add(txtAgrTel)
        gbDatoTp.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbDatoTp.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        gbDatoTp.Location = New Point(3, 2)
        gbDatoTp.Name = "gbDatoTp"
        gbDatoTp.Size = New Size(344, 58)
        gbDatoTp.TabIndex = 0
        gbDatoTp.TabStop = False
        gbDatoTp.Text = "Servicio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        Label1.Location = New Point(6, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 16)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' txtAgrTel
        ' 
        txtAgrTel.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtAgrTel.Enabled = False
        txtAgrTel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAgrTel.Location = New Point(74, 30)
        txtAgrTel.MaxLength = 50
        txtAgrTel.Name = "txtAgrTel"
        txtAgrTel.Size = New Size(240, 21)
        txtAgrTel.TabIndex = 1
        txtAgrTel.Tag = "Nombre"
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
        btnAgrMod.Location = New Point(347, 22)
        btnAgrMod.Name = "btnAgrMod"
        btnAgrMod.Size = New Size(123, 31)
        btnAgrMod.TabIndex = 1
        btnAgrMod.Text = "    Agregar"
        btnAgrMod.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Firebrick
        btnCancelar.FlatAppearance.BorderColor = Color.Maroon
        btnCancelar.FlatAppearance.MouseDownBackColor = Color.Firebrick
        btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.Image = My.Resources.Resources.icons8_cancelar_25
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(473, 22)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(123, 31)
        btnCancelar.TabIndex = 3
        btnCancelar.Text = "    Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' gbTelefonos
        ' 
        gbTelefonos.Controls.Add(dgvTpServicios)
        gbTelefonos.Location = New Point(3, 53)
        gbTelefonos.Name = "gbTelefonos"
        gbTelefonos.Size = New Size(599, 204)
        gbTelefonos.TabIndex = 4
        gbTelefonos.TabStop = False
        ' 
        ' dgvTpServicios
        ' 
        dgvTpServicios.AllowUserToAddRows = False
        dgvTpServicios.AllowUserToDeleteRows = False
        dgvTpServicios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvTpServicios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvTpServicios.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvTpServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvTpServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvTpServicios.DefaultCellStyle = DataGridViewCellStyle3
        dgvTpServicios.Location = New Point(6, 13)
        dgvTpServicios.Name = "dgvTpServicios"
        dgvTpServicios.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvTpServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvTpServicios.RowHeadersVisible = False
        dgvTpServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTpServicios.Size = New Size(587, 186)
        dgvTpServicios.TabIndex = 0
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ep.Icon = CType(resources.GetObject("ep.Icon"), Icon)
        ' 
        ' frmAgrTpServ
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(611, 296)
        Controls.Add(Panel1)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAgrTpServ"
        Text = "frmAgrTpServ"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        gbDatoTp.ResumeLayout(False)
        gbDatoTp.PerformLayout()
        gbTelefonos.ResumeLayout(False)
        CType(dgvTpServicios, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbDatoTp As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAgrTel As TextBox
    Friend WithEvents btnAgrMod As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbTelefonos As GroupBox
    Friend WithEvents dgvTpServicios As DataGridView
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMiniMax As Button
End Class
