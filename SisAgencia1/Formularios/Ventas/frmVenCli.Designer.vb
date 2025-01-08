<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenCli))
        btnCliV = New Button()
        btnVenV = New Button()
        pnlVenCli = New Panel()
        btnDetVent = New Button()
        tVent = New Timer(components)
        btnVender = New Button()
        SuspendLayout()
        ' 
        ' btnCliV
        ' 
        btnCliV.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCliV.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCliV.FlatAppearance.BorderSize = 0
        btnCliV.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnCliV.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnCliV.FlatStyle = FlatStyle.Flat
        btnCliV.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCliV.ForeColor = Color.White
        btnCliV.Image = My.Resources.Resources.icons8_cliente_241
        btnCliV.ImageAlign = ContentAlignment.MiddleLeft
        btnCliV.Location = New Point(0, 0)
        btnCliV.Name = "btnCliV"
        btnCliV.Size = New Size(106, 31)
        btnCliV.TabIndex = 0
        btnCliV.Text = "      Clientes"
        btnCliV.UseVisualStyleBackColor = False
        ' 
        ' btnVenV
        ' 
        btnVenV.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVenV.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVenV.FlatAppearance.BorderSize = 0
        btnVenV.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVenV.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnVenV.FlatStyle = FlatStyle.Flat
        btnVenV.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVenV.ForeColor = Color.White
        btnVenV.Image = My.Resources.Resources.icons8_ventas_24
        btnVenV.ImageAlign = ContentAlignment.MiddleLeft
        btnVenV.Location = New Point(106, 0)
        btnVenV.Name = "btnVenV"
        btnVenV.Size = New Size(169, 31)
        btnVenV.TabIndex = 1
        btnVenV.Text = "       Listado de Ventas"
        btnVenV.UseVisualStyleBackColor = False
        ' 
        ' pnlVenCli
        ' 
        pnlVenCli.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlVenCli.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlVenCli.BackgroundImage = CType(resources.GetObject("pnlVenCli.BackgroundImage"), Image)
        pnlVenCli.BackgroundImageLayout = ImageLayout.Center
        pnlVenCli.Location = New Point(0, 31)
        pnlVenCli.Name = "pnlVenCli"
        pnlVenCli.Size = New Size(1362, 704)
        pnlVenCli.TabIndex = 3
        ' 
        ' btnDetVent
        ' 
        btnDetVent.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnDetVent.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnDetVent.FlatAppearance.BorderSize = 0
        btnDetVent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnDetVent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnDetVent.FlatStyle = FlatStyle.Flat
        btnDetVent.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDetVent.ForeColor = Color.White
        btnDetVent.Image = My.Resources.Resources.icons8_carrito_de_compras_243
        btnDetVent.ImageAlign = ContentAlignment.MiddleLeft
        btnDetVent.Location = New Point(275, 0)
        btnDetVent.Name = "btnDetVent"
        btnDetVent.Size = New Size(146, 31)
        btnDetVent.TabIndex = 2
        btnDetVent.Text = "      Detalle Ventas"
        btnDetVent.UseVisualStyleBackColor = False
        btnDetVent.Visible = False
        ' 
        ' tVent
        ' 
        ' 
        ' btnVender
        ' 
        btnVender.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnVender.BackColor = Color.Transparent
        btnVender.FlatAppearance.BorderColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnVender.FlatAppearance.BorderSize = 0
        btnVender.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnVender.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnVender.FlatStyle = FlatStyle.Flat
        btnVender.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVender.ForeColor = Color.White
        btnVender.Image = My.Resources.Resources.icons8_agregar_a_carrito_de_compras_24
        btnVender.ImageAlign = ContentAlignment.MiddleLeft
        btnVender.Location = New Point(1257, 0)
        btnVender.Name = "btnVender"
        btnVender.Size = New Size(103, 31)
        btnVender.TabIndex = 4
        btnVender.Text = "      Vender"
        btnVender.UseVisualStyleBackColor = False
        ' 
        ' frmVenCli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1360, 734)
        Controls.Add(btnVender)
        Controls.Add(btnDetVent)
        Controls.Add(btnVenV)
        Controls.Add(pnlVenCli)
        Controls.Add(btnCliV)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Name = "frmVenCli"
        Text = "frmVentas"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnCliV As Button
    Friend WithEvents btnVenV As Button
    Friend WithEvents pnlVenCli As Panel
    Friend WithEvents btnDetVent As Button
    Friend WithEvents tVent As Timer
    Friend WithEvents btnVender As Button
End Class
