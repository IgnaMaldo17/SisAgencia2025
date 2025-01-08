<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoti
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
        txtNotiCabeza = New TextBox()
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnExit = New Button()
        txtNotiCuerpo = New TextBox()
        txtHora = New TextBox()
        tHora = New Timer(components)
        tNotificacion = New Timer(components)
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNotiCabeza
        ' 
        txtNotiCabeza.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtNotiCabeza.BorderStyle = BorderStyle.None
        txtNotiCabeza.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtNotiCabeza.ForeColor = Color.White
        txtNotiCabeza.Location = New Point(13, 40)
        txtNotiCabeza.MaxLength = 230
        txtNotiCabeza.Multiline = True
        txtNotiCabeza.Name = "txtNotiCabeza"
        txtNotiCabeza.ReadOnly = True
        txtNotiCabeza.Size = New Size(368, 23)
        txtNotiCabeza.TabIndex = 0
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuTool.Controls.Add(PictureBox2)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(393, 34)
        pnlMnuTool.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.icons8_campana_24
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
        tsslNomUsu.BackColor = Color.Transparent
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(139, 15)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Conquista Tu Mundo"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_x_15
        btnExit.Location = New Point(361, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(32, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtNotiCuerpo
        ' 
        txtNotiCuerpo.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtNotiCuerpo.BorderStyle = BorderStyle.None
        txtNotiCuerpo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNotiCuerpo.ForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        txtNotiCuerpo.Location = New Point(13, 69)
        txtNotiCuerpo.MaxLength = 230
        txtNotiCuerpo.Multiline = True
        txtNotiCuerpo.Name = "txtNotiCuerpo"
        txtNotiCuerpo.ReadOnly = True
        txtNotiCuerpo.Size = New Size(368, 66)
        txtNotiCuerpo.TabIndex = 2
        ' 
        ' txtHora
        ' 
        txtHora.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        txtHora.BorderStyle = BorderStyle.None
        txtHora.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHora.ForeColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        txtHora.Location = New Point(13, 145)
        txtHora.MaxLength = 230
        txtHora.Multiline = True
        txtHora.Name = "txtHora"
        txtHora.ReadOnly = True
        txtHora.Size = New Size(368, 17)
        txtHora.TabIndex = 3
        ' 
        ' tHora
        ' 
        ' 
        ' tNotificacion
        ' 
        ' 
        ' frmNoti
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(393, 167)
        Controls.Add(txtHora)
        Controls.Add(txtNotiCuerpo)
        Controls.Add(pnlMnuTool)
        Controls.Add(txtNotiCabeza)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmNoti"
        ShowIcon = False
        ShowInTaskbar = False
        Text = "Notificación Conquista Tu Mundo"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNotiCabeza As TextBox
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNotiCuerpo As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents tHora As Timer
    Friend WithEvents tNotificacion As Timer
End Class
