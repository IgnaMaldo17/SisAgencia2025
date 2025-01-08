<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpChofVeh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpChofVeh))
        btnChof = New Button()
        btnVeh = New Button()
        btnOp = New Button()
        pnlOpChofVeh = New Panel()
        tiOp = New Timer(components)
        SuspendLayout()
        ' 
        ' btnChof
        ' 
        btnChof.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnChof.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnChof.FlatAppearance.BorderSize = 0
        btnChof.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnChof.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnChof.FlatStyle = FlatStyle.Flat
        btnChof.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChof.ForeColor = Color.White
        btnChof.Image = My.Resources.Resources.icons8_conductor_de_taxi_24
        btnChof.ImageAlign = ContentAlignment.MiddleLeft
        btnChof.Location = New Point(0, 0)
        btnChof.Name = "btnChof"
        btnChof.Size = New Size(109, 31)
        btnChof.TabIndex = 0
        btnChof.Text = "       Choferes"
        btnChof.UseVisualStyleBackColor = False
        ' 
        ' btnVeh
        ' 
        btnVeh.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVeh.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVeh.FlatAppearance.BorderSize = 0
        btnVeh.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVeh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnVeh.FlatStyle = FlatStyle.Flat
        btnVeh.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVeh.ForeColor = Color.White
        btnVeh.Image = My.Resources.Resources.icons8_auto_24
        btnVeh.ImageAlign = ContentAlignment.MiddleLeft
        btnVeh.Location = New Point(109, 0)
        btnVeh.Name = "btnVeh"
        btnVeh.Size = New Size(115, 31)
        btnVeh.TabIndex = 1
        btnVeh.Text = "       Vehículos"
        btnVeh.UseVisualStyleBackColor = False
        ' 
        ' btnOp
        ' 
        btnOp.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnOp.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnOp.FlatAppearance.BorderSize = 0
        btnOp.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnOp.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnOp.FlatStyle = FlatStyle.Flat
        btnOp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOp.ForeColor = Color.White
        btnOp.Image = My.Resources.Resources.icons8_ruta_24
        btnOp.ImageAlign = ContentAlignment.MiddleLeft
        btnOp.Location = New Point(224, 0)
        btnOp.Name = "btnOp"
        btnOp.Size = New Size(136, 31)
        btnOp.TabIndex = 2
        btnOp.Text = "       Operaciones"
        btnOp.UseVisualStyleBackColor = False
        ' 
        ' pnlOpChofVeh
        ' 
        pnlOpChofVeh.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlOpChofVeh.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlOpChofVeh.BackgroundImage = CType(resources.GetObject("pnlOpChofVeh.BackgroundImage"), Image)
        pnlOpChofVeh.BackgroundImageLayout = ImageLayout.Center
        pnlOpChofVeh.Location = New Point(0, 31)
        pnlOpChofVeh.Name = "pnlOpChofVeh"
        pnlOpChofVeh.Size = New Size(1916, 1016)
        pnlOpChofVeh.TabIndex = 3
        ' 
        ' tiOp
        ' 
        ' 
        ' frmOpChofVeh
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1914, 1046)
        Controls.Add(pnlOpChofVeh)
        Controls.Add(btnOp)
        Controls.Add(btnVeh)
        Controls.Add(btnChof)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "frmOpChofVeh"
        Text = "frmOpChofVeh"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnChof As Button
    Friend WithEvents btnVeh As Button
    Friend WithEvents btnOp As Button
    Friend WithEvents pnlOpChofVeh As Panel
    Friend WithEvents tiOp As Timer
End Class
