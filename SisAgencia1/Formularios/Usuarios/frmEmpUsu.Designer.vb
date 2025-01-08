<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpUsu))
        tlpMenu = New TableLayoutPanel()
        gbMenu = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        bServicios = New Button()
        bVentas = New Button()
        lblDescripcion = New Label()
        btnUsu = New Button()
        btnEmp = New Button()
        pnlEmpUsu = New Panel()
        tUsu = New Timer(components)
        tlpMenu.SuspendLayout()
        gbMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' tlpMenu
        ' 
        tlpMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpMenu.BackColor = Color.Azure
        tlpMenu.ColumnCount = 3
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.2231407F))
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 86.77686F))
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 85F))
        tlpMenu.Controls.Add(gbMenu, 1, 1)
        tlpMenu.Location = New Point(0, 0)
        tlpMenu.Name = "tlpMenu"
        tlpMenu.RowCount = 2
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMenu.Size = New Size(200, 100)
        tlpMenu.TabIndex = 0
        ' 
        ' gbMenu
        ' 
        gbMenu.Anchor = AnchorStyles.None
        gbMenu.Controls.Add(Button1)
        gbMenu.Controls.Add(Button2)
        gbMenu.Controls.Add(bServicios)
        gbMenu.Controls.Add(bVentas)
        gbMenu.FlatStyle = FlatStyle.Flat
        gbMenu.Location = New Point(18, 23)
        gbMenu.Name = "gbMenu"
        gbMenu.Size = New Size(93, 74)
        gbMenu.TabIndex = 0
        gbMenu.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(16, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 95)
        Button1.TabIndex = 3
        Button1.Text = "Operaciones"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        Button2.Location = New Point(186, 120)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 95)
        Button2.TabIndex = 2
        Button2.Text = "Personal"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' bServicios
        ' 
        bServicios.BackColor = Color.SteelBlue
        bServicios.FlatStyle = FlatStyle.Flat
        bServicios.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bServicios.ForeColor = Color.White
        bServicios.Image = My.Resources.Resources.icons8_cascada_40
        bServicios.Location = New Point(186, 19)
        bServicios.Name = "bServicios"
        bServicios.Size = New Size(164, 95)
        bServicios.TabIndex = 1
        bServicios.Text = "Servicios"
        bServicios.TextAlign = ContentAlignment.BottomCenter
        bServicios.UseVisualStyleBackColor = False
        ' 
        ' bVentas
        ' 
        bVentas.BackColor = Color.SteelBlue
        bVentas.FlatStyle = FlatStyle.Flat
        bVentas.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bVentas.ForeColor = Color.White
        bVentas.Image = My.Resources.Resources.icons8_barato_2_60
        bVentas.Location = New Point(16, 19)
        bVentas.Name = "bVentas"
        bVentas.Size = New Size(164, 95)
        bVentas.TabIndex = 0
        bVentas.Text = "Ventas"
        bVentas.TextAlign = ContentAlignment.BottomCenter
        bVentas.UseVisualStyleBackColor = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.Anchor = AnchorStyles.Top
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.SteelBlue
        lblDescripcion.Location = New Point(33, 236)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(63, 20)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Label1"
        lblDescripcion.Visible = False
        ' 
        ' btnUsu
        ' 
        btnUsu.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnUsu.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnUsu.FlatAppearance.BorderSize = 0
        btnUsu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnUsu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnUsu.FlatStyle = FlatStyle.Flat
        btnUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsu.ForeColor = Color.White
        btnUsu.Image = My.Resources.Resources.icons8_usuario_24
        btnUsu.ImageAlign = ContentAlignment.MiddleLeft
        btnUsu.Location = New Point(0, 0)
        btnUsu.Name = "btnUsu"
        btnUsu.Size = New Size(110, 31)
        btnUsu.TabIndex = 0
        btnUsu.Text = "       Usuarios"
        btnUsu.UseVisualStyleBackColor = False
        ' 
        ' btnEmp
        ' 
        btnEmp.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEmp.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEmp.FlatAppearance.BorderSize = 0
        btnEmp.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnEmp.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnEmp.FlatStyle = FlatStyle.Flat
        btnEmp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmp.ForeColor = Color.White
        btnEmp.Image = My.Resources.Resources.icons8_empleado_24
        btnEmp.ImageAlign = ContentAlignment.MiddleLeft
        btnEmp.Location = New Point(110, 0)
        btnEmp.Name = "btnEmp"
        btnEmp.Size = New Size(127, 31)
        btnEmp.TabIndex = 1
        btnEmp.Text = "       Empleados"
        btnEmp.UseVisualStyleBackColor = False
        ' 
        ' pnlEmpUsu
        ' 
        pnlEmpUsu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEmpUsu.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlEmpUsu.BackgroundImage = CType(resources.GetObject("pnlEmpUsu.BackgroundImage"), Image)
        pnlEmpUsu.BackgroundImageLayout = ImageLayout.Center
        pnlEmpUsu.Location = New Point(0, 31)
        pnlEmpUsu.Name = "pnlEmpUsu"
        pnlEmpUsu.Size = New Size(1362, 704)
        pnlEmpUsu.TabIndex = 2
        ' 
        ' tUsu
        ' 
        ' 
        ' frmEmpUsu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(1360, 734)
        Controls.Add(pnlEmpUsu)
        Controls.Add(btnEmp)
        Controls.Add(btnUsu)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmEmpUsu"
        Text = "frmEmpUsu"
        tlpMenu.ResumeLayout(False)
        gbMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bServicios As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents btnUsu As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents pnlEmpUsu As Panel
    Friend WithEvents tUsu As Timer
End Class
