<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServProv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServProv))
        btnServ = New Button()
        btnProv = New Button()
        pnlServProv = New Panel()
        tServ = New Timer(components)
        SuspendLayout()
        ' 
        ' btnServ
        ' 
        btnServ.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnServ.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnServ.FlatAppearance.BorderSize = 0
        btnServ.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnServ.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnServ.FlatStyle = FlatStyle.Flat
        btnServ.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnServ.ForeColor = Color.White
        btnServ.Image = My.Resources.Resources.icons8_parque_nacional_24
        btnServ.ImageAlign = ContentAlignment.MiddleLeft
        btnServ.Location = New Point(139, 0)
        btnServ.Name = "btnServ"
        btnServ.Size = New Size(121, 31)
        btnServ.TabIndex = 1
        btnServ.Text = "       Servicios"
        btnServ.UseVisualStyleBackColor = False
        ' 
        ' btnProv
        ' 
        btnProv.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnProv.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnProv.FlatAppearance.BorderSize = 0
        btnProv.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnProv.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnProv.FlatStyle = FlatStyle.Flat
        btnProv.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProv.ForeColor = Color.White
        btnProv.Image = My.Resources.Resources.icons8_edificio_24
        btnProv.ImageAlign = ContentAlignment.MiddleLeft
        btnProv.Location = New Point(0, 0)
        btnProv.Name = "btnProv"
        btnProv.Size = New Size(139, 31)
        btnProv.TabIndex = 0
        btnProv.Text = "       Proveedores"
        btnProv.UseVisualStyleBackColor = False
        ' 
        ' pnlServProv
        ' 
        pnlServProv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlServProv.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlServProv.BackgroundImage = CType(resources.GetObject("pnlServProv.BackgroundImage"), Image)
        pnlServProv.BackgroundImageLayout = ImageLayout.Center
        pnlServProv.Location = New Point(0, 31)
        pnlServProv.Name = "pnlServProv"
        pnlServProv.Size = New Size(1362, 704)
        pnlServProv.TabIndex = 2
        ' 
        ' tServ
        ' 
        ' 
        ' frmServProv
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1360, 734)
        Controls.Add(pnlServProv)
        Controls.Add(btnServ)
        Controls.Add(btnProv)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmServProv"
        Text = "frmServProv"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnServ As Button
    Friend WithEvents btnProv As Button
    Friend WithEvents pnlServProv As Panel
    Friend WithEvents tServ As Timer
End Class
