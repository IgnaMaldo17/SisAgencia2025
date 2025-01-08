<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFav))
        ckbCli = New CheckBox()
        ckbVent = New CheckBox()
        ckbDV = New CheckBox()
        ckbProv = New CheckBox()
        ckbServ = New CheckBox()
        ckbOp = New CheckBox()
        ckbChoferes = New CheckBox()
        ckbVeh = New CheckBox()
        ckbEmp = New CheckBox()
        ckbUsu = New CheckBox()
        Panel1 = New Panel()
        btnSelFav = New Button()
        pnlMnuTool = New Panel()
        PictureBox2 = New PictureBox()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        Panel1.SuspendLayout()
        pnlMnuTool.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ckbCli
        ' 
        ckbCli.Appearance = Appearance.Button
        ckbCli.AutoSize = True
        ckbCli.FlatAppearance.BorderSize = 0
        ckbCli.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbCli.FlatStyle = FlatStyle.Flat
        ckbCli.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbCli.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbCli.Image = My.Resources.Resources.icons8_clientes_50
        ckbCli.ImageAlign = ContentAlignment.TopCenter
        ckbCli.Location = New Point(10, 6)
        ckbCli.Name = "ckbCli"
        ckbCli.Size = New Size(79, 75)
        ckbCli.TabIndex = 0
        ckbCli.Tag = "1"
        ckbCli.Text = "   Clientes   "
        ckbCli.TextAlign = ContentAlignment.BottomCenter
        ckbCli.TextImageRelation = TextImageRelation.ImageAboveText
        ckbCli.UseVisualStyleBackColor = True
        ' 
        ' ckbVent
        ' 
        ckbVent.Appearance = Appearance.Button
        ckbVent.AutoSize = True
        ckbVent.FlatAppearance.BorderSize = 0
        ckbVent.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbVent.FlatStyle = FlatStyle.Flat
        ckbVent.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbVent.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbVent.Image = My.Resources.Resources.icons8_ventas_azul_501
        ckbVent.ImageAlign = ContentAlignment.TopCenter
        ckbVent.Location = New Point(100, 6)
        ckbVent.Name = "ckbVent"
        ckbVent.Size = New Size(78, 75)
        ckbVent.TabIndex = 1
        ckbVent.Tag = "2"
        ckbVent.Text = "    Ventas    "
        ckbVent.TextAlign = ContentAlignment.BottomCenter
        ckbVent.TextImageRelation = TextImageRelation.ImageAboveText
        ckbVent.UseVisualStyleBackColor = True
        ' 
        ' ckbDV
        ' 
        ckbDV.Appearance = Appearance.Button
        ckbDV.AutoSize = True
        ckbDV.FlatAppearance.BorderSize = 0
        ckbDV.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbDV.FlatStyle = FlatStyle.Flat
        ckbDV.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbDV.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbDV.Image = My.Resources.Resources.icons8_ventas_50__1_1
        ckbDV.ImageAlign = ContentAlignment.TopCenter
        ckbDV.Location = New Point(187, 6)
        ckbDV.Name = "ckbDV"
        ckbDV.Size = New Size(85, 75)
        ckbDV.TabIndex = 2
        ckbDV.Tag = "3"
        ckbDV.Text = " Det. Ventas "
        ckbDV.TextAlign = ContentAlignment.BottomCenter
        ckbDV.TextImageRelation = TextImageRelation.ImageAboveText
        ckbDV.UseVisualStyleBackColor = True
        ' 
        ' ckbProv
        ' 
        ckbProv.Appearance = Appearance.Button
        ckbProv.AutoSize = True
        ckbProv.FlatAppearance.BorderSize = 0
        ckbProv.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbProv.FlatStyle = FlatStyle.Flat
        ckbProv.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbProv.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbProv.Image = My.Resources.Resources.icons8_building_with_rooftop_terrace_501
        ckbProv.ImageAlign = ContentAlignment.TopCenter
        ckbProv.Location = New Point(278, 6)
        ckbProv.Name = "ckbProv"
        ckbProv.Size = New Size(86, 75)
        ckbProv.TabIndex = 3
        ckbProv.Tag = "4"
        ckbProv.Text = "Proveedores"
        ckbProv.TextAlign = ContentAlignment.BottomCenter
        ckbProv.TextImageRelation = TextImageRelation.ImageAboveText
        ckbProv.UseVisualStyleBackColor = True
        ' 
        ' ckbServ
        ' 
        ckbServ.Appearance = Appearance.Button
        ckbServ.AutoSize = True
        ckbServ.FlatAppearance.BorderSize = 0
        ckbServ.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbServ.FlatStyle = FlatStyle.Flat
        ckbServ.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbServ.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbServ.Image = My.Resources.Resources.icons8_parque_nacional_502
        ckbServ.Location = New Point(370, 6)
        ckbServ.Name = "ckbServ"
        ckbServ.Size = New Size(84, 75)
        ckbServ.TabIndex = 4
        ckbServ.Tag = "5"
        ckbServ.Text = "   Servicios   "
        ckbServ.TextAlign = ContentAlignment.BottomCenter
        ckbServ.TextImageRelation = TextImageRelation.ImageAboveText
        ckbServ.UseVisualStyleBackColor = True
        ' 
        ' ckbOp
        ' 
        ckbOp.Appearance = Appearance.Button
        ckbOp.AutoSize = True
        ckbOp.FlatAppearance.BorderSize = 0
        ckbOp.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbOp.FlatStyle = FlatStyle.Flat
        ckbOp.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbOp.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbOp.Image = My.Resources.Resources.icons8_waypoint_map_501
        ckbOp.ImageAlign = ContentAlignment.TopCenter
        ckbOp.Location = New Point(460, 6)
        ckbOp.Name = "ckbOp"
        ckbOp.Size = New Size(87, 75)
        ckbOp.TabIndex = 5
        ckbOp.Tag = "6"
        ckbOp.Text = "Operaciones"
        ckbOp.TextAlign = ContentAlignment.BottomCenter
        ckbOp.TextImageRelation = TextImageRelation.ImageAboveText
        ckbOp.UseVisualStyleBackColor = True
        ' 
        ' ckbChoferes
        ' 
        ckbChoferes.Appearance = Appearance.Button
        ckbChoferes.AutoSize = True
        ckbChoferes.FlatAppearance.BorderSize = 0
        ckbChoferes.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbChoferes.FlatStyle = FlatStyle.Flat
        ckbChoferes.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbChoferes.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbChoferes.Image = My.Resources.Resources.icons8_taxi_driver_501
        ckbChoferes.ImageAlign = ContentAlignment.TopCenter
        ckbChoferes.Location = New Point(8, 87)
        ckbChoferes.Name = "ckbChoferes"
        ckbChoferes.Size = New Size(84, 75)
        ckbChoferes.TabIndex = 6
        ckbChoferes.Tag = "7"
        ckbChoferes.Text = "   Choferes   "
        ckbChoferes.TextAlign = ContentAlignment.BottomCenter
        ckbChoferes.TextImageRelation = TextImageRelation.ImageAboveText
        ckbChoferes.UseVisualStyleBackColor = True
        ' 
        ' ckbVeh
        ' 
        ckbVeh.Appearance = Appearance.Button
        ckbVeh.AutoSize = True
        ckbVeh.FlatAppearance.BorderSize = 0
        ckbVeh.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbVeh.FlatStyle = FlatStyle.Flat
        ckbVeh.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbVeh.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbVeh.Image = My.Resources.Resources.icons8_auto_501
        ckbVeh.ImageAlign = ContentAlignment.TopCenter
        ckbVeh.Location = New Point(98, 87)
        ckbVeh.Name = "ckbVeh"
        ckbVeh.Size = New Size(82, 75)
        ckbVeh.TabIndex = 7
        ckbVeh.Tag = "8"
        ckbVeh.Text = "  Vehículos  "
        ckbVeh.TextAlign = ContentAlignment.BottomCenter
        ckbVeh.TextImageRelation = TextImageRelation.ImageAboveText
        ckbVeh.UseVisualStyleBackColor = True
        ' 
        ' ckbEmp
        ' 
        ckbEmp.Appearance = Appearance.Button
        ckbEmp.AutoSize = True
        ckbEmp.FlatAppearance.BorderSize = 0
        ckbEmp.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbEmp.FlatStyle = FlatStyle.Flat
        ckbEmp.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbEmp.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbEmp.Image = My.Resources.Resources.icons8_empleados_501
        ckbEmp.ImageAlign = ContentAlignment.TopCenter
        ckbEmp.Location = New Point(186, 87)
        ckbEmp.Name = "ckbEmp"
        ckbEmp.Size = New Size(86, 75)
        ckbEmp.TabIndex = 8
        ckbEmp.Tag = "9"
        ckbEmp.Text = " Empleados "
        ckbEmp.TextAlign = ContentAlignment.BottomCenter
        ckbEmp.TextImageRelation = TextImageRelation.ImageAboveText
        ckbEmp.UseVisualStyleBackColor = True
        ' 
        ' ckbUsu
        ' 
        ckbUsu.Appearance = Appearance.Button
        ckbUsu.AutoSize = True
        ckbUsu.FlatAppearance.BorderSize = 0
        ckbUsu.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(166), CByte(190), CByte(230))
        ckbUsu.FlatStyle = FlatStyle.Flat
        ckbUsu.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbUsu.ForeColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ckbUsu.Image = My.Resources.Resources.icons8_usuario_501
        ckbUsu.ImageAlign = ContentAlignment.TopCenter
        ckbUsu.Location = New Point(278, 87)
        ckbUsu.Name = "ckbUsu"
        ckbUsu.Size = New Size(84, 75)
        ckbUsu.TabIndex = 9
        ckbUsu.Tag = "10"
        ckbUsu.Text = "   Usuarios   "
        ckbUsu.TextAlign = ContentAlignment.BottomCenter
        ckbUsu.TextImageRelation = TextImageRelation.ImageAboveText
        ckbUsu.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        Panel1.Controls.Add(btnSelFav)
        Panel1.Controls.Add(ckbDV)
        Panel1.Controls.Add(ckbCli)
        Panel1.Controls.Add(ckbUsu)
        Panel1.Controls.Add(ckbVent)
        Panel1.Controls.Add(ckbEmp)
        Panel1.Controls.Add(ckbProv)
        Panel1.Controls.Add(ckbVeh)
        Panel1.Controls.Add(ckbServ)
        Panel1.Controls.Add(ckbChoferes)
        Panel1.Controls.Add(ckbOp)
        Panel1.Location = New Point(4, 34)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(555, 214)
        Panel1.TabIndex = 1
        ' 
        ' btnSelFav
        ' 
        btnSelFav.BackColor = Color.Green
        btnSelFav.FlatAppearance.BorderColor = Color.SlateGray
        btnSelFav.FlatAppearance.BorderSize = 0
        btnSelFav.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnSelFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnSelFav.FlatStyle = FlatStyle.Flat
        btnSelFav.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSelFav.ForeColor = Color.White
        btnSelFav.Image = CType(resources.GetObject("btnSelFav.Image"), Image)
        btnSelFav.ImageAlign = ContentAlignment.MiddleLeft
        btnSelFav.Location = New Point(354, 166)
        btnSelFav.Name = "btnSelFav"
        btnSelFav.Size = New Size(193, 43)
        btnSelFav.TabIndex = 10
        btnSelFav.Text = "   Guardar Cambios"
        btnSelFav.UseVisualStyleBackColor = False
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
        pnlMnuTool.Size = New Size(563, 34)
        pnlMnuTool.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icons8_estrella_24
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
        tsslNomUsu.Size = New Size(138, 16)
        tsslNomUsu.TabIndex = 0
        tsslNomUsu.Text = "Seleccionar Atajos"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(489, 0)
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
        btnExit.Location = New Point(526, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 2
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmFav
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        ClientSize = New Size(563, 252)
        Controls.Add(pnlMnuTool)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmFav"
        Text = "Seleccionar Atajos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents ckbCli As CheckBox
    Friend WithEvents ckbVent As CheckBox
    Friend WithEvents ckbDV As CheckBox
    Friend WithEvents ckbProv As CheckBox
    Friend WithEvents ckbServ As CheckBox
    Friend WithEvents ckbOp As CheckBox
    Friend WithEvents ckbChoferes As CheckBox
    Friend WithEvents ckbVeh As CheckBox
    Friend WithEvents ckbEmp As CheckBox
    Friend WithEvents ckbUsu As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSelFav As Button
End Class
