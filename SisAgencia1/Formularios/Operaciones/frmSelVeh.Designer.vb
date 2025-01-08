<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelVeh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelVeh))
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        pnlSelVeh = New Panel()
        txtBusVeh = New TextBox()
        dgvVehiculos = New DataGridView()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlSelVeh.SuspendLayout()
        CType(dgvVehiculos, ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox2.Image = My.Resources.Resources.icons8_auto_nuevo_241
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
        tsslNomUsu.Text = "Seleccionar Vehículo"
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
        ' pnlSelVeh
        ' 
        pnlSelVeh.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlSelVeh.Controls.Add(txtBusVeh)
        pnlSelVeh.Controls.Add(dgvVehiculos)
        pnlSelVeh.Location = New Point(3, 35)
        pnlSelVeh.Name = "pnlSelVeh"
        pnlSelVeh.Size = New Size(870, 482)
        pnlSelVeh.TabIndex = 1
        ' 
        ' txtBusVeh
        ' 
        txtBusVeh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txtBusVeh.BackColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        txtBusVeh.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBusVeh.ForeColor = SystemColors.WindowFrame
        txtBusVeh.Location = New Point(9, 6)
        txtBusVeh.MaxLength = 50
        txtBusVeh.Name = "txtBusVeh"
        txtBusVeh.Size = New Size(852, 22)
        txtBusVeh.TabIndex = 0
        txtBusVeh.Text = "Buscar Vehículo"
        ' 
        ' dgvVehiculos
        ' 
        dgvVehiculos.AllowUserToAddRows = False
        dgvVehiculos.AllowUserToDeleteRows = False
        dgvVehiculos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        dgvVehiculos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvVehiculos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVehiculos.BackgroundColor = Color.FromArgb(CByte(243), CByte(247), CByte(252))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvVehiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvVehiculos.DefaultCellStyle = DataGridViewCellStyle3
        dgvVehiculos.Location = New Point(9, 34)
        dgvVehiculos.Name = "dgvVehiculos"
        dgvVehiculos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvVehiculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvVehiculos.RowHeadersVisible = False
        dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVehiculos.Size = New Size(852, 438)
        dgvVehiculos.TabIndex = 1
        ' 
        ' frmSelVeh
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(876, 519)
        Controls.Add(pnlSelVeh)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmSelVeh"
        Text = "Seleccionar Vehículo"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlSelVeh.ResumeLayout(False)
        pnlSelVeh.PerformLayout()
        CType(dgvVehiculos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlSelVeh As Panel
    Friend WithEvents txtBusVeh As TextBox
    Friend WithEvents dgvVehiculos As DataGridView
End Class
