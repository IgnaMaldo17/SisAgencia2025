<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelServ
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelServ))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        pnlSelProv = New Panel()
        txtBusProvShrt = New TextBox()
        dgvProveedoresShrt = New DataGridView()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlSelProv.SuspendLayout()
        CType(dgvProveedoresShrt, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlMnuTool.Size = New Size(876, 34)
        pnlMnuTool.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_parque_nacional_241
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
        tsslNomUsu.Size = New Size(151, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Seleccionar Servicio"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(802, 0)
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
        btnExit.Location = New Point(839, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlSelProv
        ' 
        pnlSelProv.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlSelProv.Controls.Add(txtBusProvShrt)
        pnlSelProv.Controls.Add(dgvProveedoresShrt)
        pnlSelProv.Location = New Point(3, 35)
        pnlSelProv.Name = "pnlSelProv"
        pnlSelProv.Size = New Size(870, 482)
        pnlSelProv.TabIndex = 1
        ' 
        ' txtBusProvShrt
        ' 
        txtBusProvShrt.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusProvShrt.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusProvShrt.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusProvShrt.ForeColor = SystemColors.WindowFrame
        txtBusProvShrt.Location = New Point(9, 6)
        txtBusProvShrt.MaxLength = 50
        txtBusProvShrt.Name = "txtBusProvShrt"
        txtBusProvShrt.Size = New Size(852, 22)
        txtBusProvShrt.TabIndex = 0
        txtBusProvShrt.Text = "Buscar Servicio"
        ' 
        ' dgvProveedoresShrt
        ' 
        dgvProveedoresShrt.AllowUserToAddRows = False
        dgvProveedoresShrt.AllowUserToDeleteRows = False
        dgvProveedoresShrt.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvProveedoresShrt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvProveedoresShrt.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvProveedoresShrt.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvProveedoresShrt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvProveedoresShrt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvProveedoresShrt.DefaultCellStyle = DataGridViewCellStyle3
        dgvProveedoresShrt.Location = New Point(9, 34)
        dgvProveedoresShrt.Name = "dgvProveedoresShrt"
        dgvProveedoresShrt.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvProveedoresShrt.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvProveedoresShrt.RowHeadersVisible = False
        dgvProveedoresShrt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProveedoresShrt.Size = New Size(852, 438)
        dgvProveedoresShrt.TabIndex = 1
        ' 
        ' frmSelServ
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(876, 519)
        Controls.Add(pnlSelProv)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmSelServ"
        Text = "Seleccionar Servicio"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlSelProv.ResumeLayout(False)
        pnlSelProv.PerformLayout()
        CType(dgvProveedoresShrt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlSelProv As Panel
    Friend WithEvents txtBusProvShrt As TextBox
    Friend WithEvents dgvProveedoresShrt As DataGridView
End Class
