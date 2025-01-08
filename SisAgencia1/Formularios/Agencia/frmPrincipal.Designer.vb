<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        pnlPpal = New Panel()
        pnlMnuDesp = New Panel()
        Label1 = New Label()
        pnlHerr = New Panel()
        btnAyuda = New Button()
        btnConfig = New Button()
        btnHerr = New Button()
        pnlDatos = New Panel()
        btnUsuarios = New Button()
        btnOperaciones = New Button()
        btnServicios = New Button()
        btnVentas = New Button()
        btnDatos = New Button()
        pnlArchivo = New Panel()
        btnSalir = New Button()
        btnInicio = New Button()
        btnArchivo = New Button()
        pbMnuDesp = New PictureBox()
        btnMnuDesp = New Button()
        pnlMnuTool = New Panel()
        btnInicio2 = New Button()
        btnVolver = New Button()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnMiniMax = New Button()
        btnExit = New Button()
        pnlMnuDesp.SuspendLayout()
        pnlHerr.SuspendLayout()
        pnlDatos.SuspendLayout()
        pnlArchivo.SuspendLayout()
        CType(pbMnuDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlMnuTool.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlPpal
        ' 
        pnlPpal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPpal.BackColor = Color.FromArgb(CByte(217), CByte(227), CByte(244))
        pnlPpal.Location = New Point(4, 32)
        pnlPpal.Name = "pnlPpal"
        pnlPpal.Size = New Size(1387, 802)
        pnlPpal.TabIndex = 2
        ' 
        ' pnlMnuDesp
        ' 
        pnlMnuDesp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlMnuDesp.AutoScroll = True
        pnlMnuDesp.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuDesp.Controls.Add(Label1)
        pnlMnuDesp.Controls.Add(pnlHerr)
        pnlMnuDesp.Controls.Add(btnHerr)
        pnlMnuDesp.Controls.Add(pnlDatos)
        pnlMnuDesp.Controls.Add(btnDatos)
        pnlMnuDesp.Controls.Add(pnlArchivo)
        pnlMnuDesp.Controls.Add(btnArchivo)
        pnlMnuDesp.Controls.Add(pbMnuDesp)
        pnlMnuDesp.Location = New Point(0, 31)
        pnlMnuDesp.Name = "pnlMnuDesp"
        pnlMnuDesp.Size = New Size(235, 803)
        pnlMnuDesp.TabIndex = 0
        pnlMnuDesp.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(3, 782)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 15)
        Label1.TabIndex = 10
        Label1.Text = "Sistema Conquista tu Mundo 2024"
        ' 
        ' pnlHerr
        ' 
        pnlHerr.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlHerr.Controls.Add(btnAyuda)
        pnlHerr.Controls.Add(btnConfig)
        pnlHerr.Dock = DockStyle.Top
        pnlHerr.Location = New Point(0, 483)
        pnlHerr.Name = "pnlHerr"
        pnlHerr.Size = New Size(235, 38)
        pnlHerr.TabIndex = 9
        ' 
        ' btnAyuda
        ' 
        btnAyuda.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnAyuda.Dock = DockStyle.Top
        btnAyuda.FlatAppearance.BorderSize = 0
        btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnAyuda.FlatStyle = FlatStyle.Flat
        btnAyuda.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAyuda.ForeColor = Color.White
        btnAyuda.Image = My.Resources.Resources.icons8_ayuda_24
        btnAyuda.ImageAlign = ContentAlignment.MiddleRight
        btnAyuda.Location = New Point(0, 38)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.Size = New Size(235, 38)
        btnAyuda.TabIndex = 1
        btnAyuda.Text = "Ayuda"
        btnAyuda.TextAlign = ContentAlignment.MiddleLeft
        btnAyuda.UseVisualStyleBackColor = False
        ' 
        ' btnConfig
        ' 
        btnConfig.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnConfig.Dock = DockStyle.Top
        btnConfig.FlatAppearance.BorderSize = 0
        btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnConfig.FlatStyle = FlatStyle.Flat
        btnConfig.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfig.ForeColor = Color.White
        btnConfig.Image = My.Resources.Resources.icons8_servicios_24__1_1
        btnConfig.ImageAlign = ContentAlignment.MiddleRight
        btnConfig.Location = New Point(0, 0)
        btnConfig.Name = "btnConfig"
        btnConfig.Size = New Size(235, 38)
        btnConfig.TabIndex = 0
        btnConfig.Text = "Configuración"
        btnConfig.TextAlign = ContentAlignment.MiddleLeft
        btnConfig.UseVisualStyleBackColor = False
        btnConfig.Visible = False
        ' 
        ' btnHerr
        ' 
        btnHerr.BackColor = Color.FromArgb(CByte(37), CByte(77), CByte(135))
        btnHerr.Dock = DockStyle.Top
        btnHerr.FlatAppearance.BorderSize = 0
        btnHerr.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnHerr.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnHerr.FlatStyle = FlatStyle.Flat
        btnHerr.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHerr.ForeColor = Color.White
        btnHerr.Image = My.Resources.Resources.icons8_herramienta_24
        btnHerr.ImageAlign = ContentAlignment.MiddleLeft
        btnHerr.Location = New Point(0, 445)
        btnHerr.Name = "btnHerr"
        btnHerr.Size = New Size(235, 38)
        btnHerr.TabIndex = 2
        btnHerr.Text = "        Herramientas"
        btnHerr.TextAlign = ContentAlignment.MiddleLeft
        btnHerr.UseVisualStyleBackColor = False
        ' 
        ' pnlDatos
        ' 
        pnlDatos.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlDatos.Controls.Add(btnUsuarios)
        pnlDatos.Controls.Add(btnOperaciones)
        pnlDatos.Controls.Add(btnServicios)
        pnlDatos.Controls.Add(btnVentas)
        pnlDatos.Dock = DockStyle.Top
        pnlDatos.Location = New Point(0, 293)
        pnlDatos.Name = "pnlDatos"
        pnlDatos.Size = New Size(235, 152)
        pnlDatos.TabIndex = 7
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnUsuarios.Dock = DockStyle.Top
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuarios.ForeColor = Color.White
        btnUsuarios.Image = My.Resources.Resources.icons8_usuario_241
        btnUsuarios.ImageAlign = ContentAlignment.MiddleRight
        btnUsuarios.Location = New Point(0, 114)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(235, 38)
        btnUsuarios.TabIndex = 3
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.TextAlign = ContentAlignment.MiddleLeft
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnOperaciones
        ' 
        btnOperaciones.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnOperaciones.Dock = DockStyle.Top
        btnOperaciones.FlatAppearance.BorderSize = 0
        btnOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnOperaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnOperaciones.FlatStyle = FlatStyle.Flat
        btnOperaciones.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOperaciones.ForeColor = Color.White
        btnOperaciones.Image = My.Resources.Resources.icons8_auto_243
        btnOperaciones.ImageAlign = ContentAlignment.MiddleRight
        btnOperaciones.Location = New Point(0, 76)
        btnOperaciones.Name = "btnOperaciones"
        btnOperaciones.Size = New Size(235, 38)
        btnOperaciones.TabIndex = 2
        btnOperaciones.Text = "Operaciones"
        btnOperaciones.TextAlign = ContentAlignment.MiddleLeft
        btnOperaciones.UseVisualStyleBackColor = False
        ' 
        ' btnServicios
        ' 
        btnServicios.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnServicios.Dock = DockStyle.Top
        btnServicios.FlatAppearance.BorderSize = 0
        btnServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnServicios.FlatStyle = FlatStyle.Flat
        btnServicios.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnServicios.ForeColor = Color.White
        btnServicios.Image = My.Resources.Resources.icons8_parque_nacional_243
        btnServicios.ImageAlign = ContentAlignment.MiddleRight
        btnServicios.Location = New Point(0, 38)
        btnServicios.Name = "btnServicios"
        btnServicios.Size = New Size(235, 38)
        btnServicios.TabIndex = 0
        btnServicios.Text = "Servicios"
        btnServicios.TextAlign = ContentAlignment.MiddleLeft
        btnServicios.UseVisualStyleBackColor = False
        ' 
        ' btnVentas
        ' 
        btnVentas.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnVentas.Dock = DockStyle.Top
        btnVentas.FlatAppearance.BorderSize = 0
        btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnVentas.FlatStyle = FlatStyle.Flat
        btnVentas.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVentas.ForeColor = Color.White
        btnVentas.Image = My.Resources.Resources.icons8_ventas_243
        btnVentas.ImageAlign = ContentAlignment.MiddleRight
        btnVentas.Location = New Point(0, 0)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(235, 38)
        btnVentas.TabIndex = 0
        btnVentas.Text = "Ventas"
        btnVentas.TextAlign = ContentAlignment.MiddleLeft
        btnVentas.UseVisualStyleBackColor = False
        ' 
        ' btnDatos
        ' 
        btnDatos.BackColor = Color.FromArgb(CByte(37), CByte(77), CByte(135))
        btnDatos.Dock = DockStyle.Top
        btnDatos.FlatAppearance.BorderSize = 0
        btnDatos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnDatos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnDatos.FlatStyle = FlatStyle.Flat
        btnDatos.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDatos.ForeColor = Color.White
        btnDatos.Image = My.Resources.Resources.icons8_configuración_de_datos_24
        btnDatos.ImageAlign = ContentAlignment.MiddleLeft
        btnDatos.Location = New Point(0, 255)
        btnDatos.Name = "btnDatos"
        btnDatos.Size = New Size(235, 38)
        btnDatos.TabIndex = 1
        btnDatos.Text = "        Datos"
        btnDatos.TextAlign = ContentAlignment.MiddleLeft
        btnDatos.UseVisualStyleBackColor = False
        ' 
        ' pnlArchivo
        ' 
        pnlArchivo.BackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        pnlArchivo.Controls.Add(btnSalir)
        pnlArchivo.Controls.Add(btnInicio)
        pnlArchivo.Dock = DockStyle.Top
        pnlArchivo.Location = New Point(0, 179)
        pnlArchivo.Name = "pnlArchivo"
        pnlArchivo.Size = New Size(235, 76)
        pnlArchivo.TabIndex = 3
        pnlArchivo.Visible = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnSalir.Dock = DockStyle.Top
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Image = My.Resources.Resources.icons8_x_241
        btnSalir.ImageAlign = ContentAlignment.MiddleRight
        btnSalir.Location = New Point(0, 38)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(235, 38)
        btnSalir.TabIndex = 1
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.MiddleLeft
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnInicio
        ' 
        btnInicio.BackColor = Color.FromArgb(CByte(50), CByte(103), CByte(182))
        btnInicio.Dock = DockStyle.Top
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicio.ForeColor = Color.White
        btnInicio.Image = My.Resources.Resources.icons8_casa_241
        btnInicio.ImageAlign = ContentAlignment.MiddleRight
        btnInicio.Location = New Point(0, 0)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(235, 38)
        btnInicio.TabIndex = 0
        btnInicio.Text = "Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = False
        ' 
        ' btnArchivo
        ' 
        btnArchivo.BackColor = Color.FromArgb(CByte(37), CByte(77), CByte(135))
        btnArchivo.Dock = DockStyle.Top
        btnArchivo.FlatAppearance.BorderSize = 0
        btnArchivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnArchivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(43), CByte(88), CByte(157))
        btnArchivo.FlatStyle = FlatStyle.Flat
        btnArchivo.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnArchivo.ForeColor = Color.White
        btnArchivo.Image = My.Resources.Resources.icons8_carpeta_24
        btnArchivo.ImageAlign = ContentAlignment.MiddleLeft
        btnArchivo.Location = New Point(0, 144)
        btnArchivo.Name = "btnArchivo"
        btnArchivo.Size = New Size(235, 35)
        btnArchivo.TabIndex = 0
        btnArchivo.Text = "        Archivo"
        btnArchivo.TextAlign = ContentAlignment.MiddleLeft
        btnArchivo.UseVisualStyleBackColor = False
        ' 
        ' pbMnuDesp
        ' 
        pbMnuDesp.BackColor = Color.Transparent
        pbMnuDesp.Dock = DockStyle.Top
        pbMnuDesp.Image = My.Resources.Resources.LOGO_Footer_Conquista_tu_Mundo_1_1__1__1_
        pbMnuDesp.Location = New Point(0, 0)
        pbMnuDesp.Name = "pbMnuDesp"
        pbMnuDesp.Size = New Size(235, 144)
        pbMnuDesp.SizeMode = PictureBoxSizeMode.CenterImage
        pbMnuDesp.TabIndex = 1
        pbMnuDesp.TabStop = False
        ' 
        ' btnMnuDesp
        ' 
        btnMnuDesp.BackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnMnuDesp.Dock = DockStyle.Left
        btnMnuDesp.FlatAppearance.BorderSize = 0
        btnMnuDesp.FlatStyle = FlatStyle.Flat
        btnMnuDesp.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMnuDesp.ForeColor = Color.White
        btnMnuDesp.Image = My.Resources.Resources.icons8_menú_241
        btnMnuDesp.ImageAlign = ContentAlignment.MiddleLeft
        btnMnuDesp.Location = New Point(0, 0)
        btnMnuDesp.Name = "btnMnuDesp"
        btnMnuDesp.Size = New Size(88, 31)
        btnMnuDesp.TabIndex = 0
        btnMnuDesp.Text = "     Menú"
        btnMnuDesp.UseVisualStyleBackColor = False
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMnuTool.BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        pnlMnuTool.Controls.Add(btnInicio2)
        pnlMnuTool.Controls.Add(btnVolver)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnMiniMax)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Controls.Add(btnMnuDesp)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(1394, 31)
        pnlMnuTool.TabIndex = 4
        ' 
        ' btnInicio2
        ' 
        btnInicio2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnInicio2.BackColor = Color.Transparent
        btnInicio2.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnInicio2.FlatAppearance.BorderSize = 0
        btnInicio2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnInicio2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnInicio2.FlatStyle = FlatStyle.Flat
        btnInicio2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicio2.ForeColor = Color.White
        btnInicio2.Image = My.Resources.Resources.icons8_casa_16
        btnInicio2.ImageAlign = ContentAlignment.MiddleLeft
        btnInicio2.Location = New Point(1112, 0)
        btnInicio2.Name = "btnInicio2"
        btnInicio2.Size = New Size(84, 31)
        btnInicio2.TabIndex = 2
        btnInicio2.Text = "   Inicio"
        btnInicio2.UseVisualStyleBackColor = False
        btnInicio2.Visible = False
        ' 
        ' btnVolver
        ' 
        btnVolver.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnVolver.BackColor = Color.Transparent
        btnVolver.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.icons8_atrás_24
        btnVolver.ImageAlign = ContentAlignment.MiddleLeft
        btnVolver.Location = New Point(1196, 0)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(84, 31)
        btnVolver.TabIndex = 3
        btnVolver.Text = "    Atrás"
        btnVolver.UseVisualStyleBackColor = False
        btnVolver.Visible = False
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.BackColor = Color.Transparent
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.ImageAlign = ContentAlignment.MiddleLeft
        tsslNomUsu.Location = New Point(94, 7)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(202, 16)
        tsslNomUsu.TabIndex = 1
        tsslNomUsu.Text = "Sistema Conquista tu Mundo"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.Transparent
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMini.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_241
        btnMini.Location = New Point(1283, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 31)
        btnMini.TabIndex = 4
        btnMini.UseVisualStyleBackColor = False
        ' 
        ' btnMiniMax
        ' 
        btnMiniMax.BackColor = Color.Transparent
        btnMiniMax.Dock = DockStyle.Right
        btnMiniMax.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMiniMax.FlatAppearance.BorderSize = 0
        btnMiniMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        btnMiniMax.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(117), CByte(202))
        btnMiniMax.FlatStyle = FlatStyle.Flat
        btnMiniMax.Image = My.Resources.Resources.icons8_cuadrado_redondeado_241
        btnMiniMax.Location = New Point(1320, 0)
        btnMiniMax.Name = "btnMiniMax"
        btnMiniMax.Size = New Size(37, 31)
        btnMiniMax.TabIndex = 5
        btnMiniMax.UseVisualStyleBackColor = False
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
        btnExit.Image = My.Resources.Resources.icons8_x_24
        btnExit.Location = New Point(1357, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 31)
        btnExit.TabIndex = 6
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(63), CByte(111))
        CancelButton = btnMnuDesp
        ClientSize = New Size(1394, 837)
        Controls.Add(pnlMnuDesp)
        Controls.Add(pnlPpal)
        Controls.Add(pnlMnuTool)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmPrincipal"
        Tag = "Conquista Tu Mundo"
        Text = "Conquista Tu Mundo"
        pnlMnuDesp.ResumeLayout(False)
        pnlMnuDesp.PerformLayout()
        pnlHerr.ResumeLayout(False)
        pnlDatos.ResumeLayout(False)
        pnlArchivo.ResumeLayout(False)
        CType(pbMnuDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents tsmArchivo As ToolStripMenuItem
    Friend WithEvents tsmiInicio As ToolStripMenuItem
    Friend WithEvents tsmiCerrar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiSalir As ToolStripMenuItem
    Friend WithEvents tsmHerramientas As ToolStripMenuItem
    Friend WithEvents tsmAyuda As ToolStripMenuItem
    Friend WithEvents pnlPpal As Panel
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents pnlMnuDesp As Panel
    Friend WithEvents btnMnuDesp As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMiniMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents pnlHerr As Panel
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnHerr As Button
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnOperaciones As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents pnlArchivo As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnArchivo As Button
    Friend WithEvents pbMnuDesp As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnInicio2 As Button
    Friend WithEvents Label1 As Label
End Class
