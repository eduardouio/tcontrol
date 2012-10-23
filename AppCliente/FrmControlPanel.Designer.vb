<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmControlPanel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MenuStripInformes = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloquearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloquearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LblEstatus = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabHome = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me._LbxMeses = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me._BtnConfiguracionAvanzada = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me._BtnCrearMes = New System.Windows.Forms.Button
        Me.TabCaptura = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me._lblEstado = New System.Windows.Forms.Label
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me._BtnCapturaGuardar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me._CmbCapturaMeses = New System.Windows.Forms.ComboBox
        Me._DgvngresoDatos = New System.Windows.Forms.DataGridView
        Me._ColumnDgvId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me._ColumnDgvSexo = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TabInforme = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me._CmbInformeMeses = New System.Windows.Forms.ComboBox
        Me._DgvInformes = New System.Windows.Forms.DataGridView
        Me.ContextMenuStripCaptura = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SeleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStripInforme = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStripInformes.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabHome.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabCaptura.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me._DgvngresoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInforme.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me._DgvInformes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripCaptura.SuspendLayout()
        Me.ContextMenuStripInforme.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripInformes
        '
        Me.MenuStripInformes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStripInformes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.BloquearToolStripMenuItem})
        Me.MenuStripInformes.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripInformes.Name = "MenuStripInformes"
        Me.MenuStripInformes.Size = New System.Drawing.Size(970, 24)
        Me.MenuStripInformes.TabIndex = 0
        Me.MenuStripInformes.Text = "MenuStripInforme"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ConfiguracionesToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FileToolStripMenuItem.Text = "&Archivo"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NewToolStripMenuItem.Text = "&Nevo Mes"
        '
        'ConfiguracionesToolStripMenuItem
        '
        Me.ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        Me.ConfiguracionesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.HelpToolStripMenuItem.Text = "&Ayuda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'BloquearToolStripMenuItem
        '
        Me.BloquearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BloquearToolStripMenuItem1})
        Me.BloquearToolStripMenuItem.Name = "BloquearToolStripMenuItem"
        Me.BloquearToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.BloquearToolStripMenuItem.Text = "&Bloquear"
        '
        'BloquearToolStripMenuItem1
        '
        Me.BloquearToolStripMenuItem1.Name = "BloquearToolStripMenuItem1"
        Me.BloquearToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.BloquearToolStripMenuItem1.Text = "Bloquear"
        '
        'LblEstatus
        '
        Me.LblEstatus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblEstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEstatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstatus.ForeColor = System.Drawing.Color.Black
        Me.LblEstatus.Location = New System.Drawing.Point(0, 641)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(970, 24)
        Me.LblEstatus.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabHome)
        Me.TabControl1.Controls.Add(Me.TabCaptura)
        Me.TabControl1.Controls.Add(Me.TabInforme)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(970, 617)
        Me.TabControl1.TabIndex = 9
        '
        'TabHome
        '
        Me.TabHome.Controls.Add(Me.GroupBox2)
        Me.TabHome.Controls.Add(Me.GroupBox1)
        Me.TabHome.Location = New System.Drawing.Point(4, 25)
        Me.TabHome.Name = "TabHome"
        Me.TabHome.Padding = New System.Windows.Forms.Padding(3)
        Me.TabHome.Size = New System.Drawing.Size(962, 588)
        Me.TabHome.TabIndex = 0
        Me.TabHome.Text = "Home"
        Me.TabHome.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me._LbxMeses)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(472, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 582)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de Meses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Para  editar  o  ver un mes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "solamente debe dar doble " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "click  sobre  un   item d" & _
            "e la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lista y este se mostrará " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automaticamente"
        '
        '_LbxMeses
        '
        Me._LbxMeses.Dock = System.Windows.Forms.DockStyle.Left
        Me._LbxMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbxMeses.ForeColor = System.Drawing.Color.Teal
        Me._LbxMeses.FormattingEnabled = True
        Me._LbxMeses.ItemHeight = 20
        Me._LbxMeses.Location = New System.Drawing.Point(3, 16)
        Me._LbxMeses.Name = "_LbxMeses"
        Me._LbxMeses.Size = New System.Drawing.Size(182, 544)
        Me._LbxMeses.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._BtnConfiguracionAvanzada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me._BtnCrearMes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 582)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        '_BtnConfiguracionAvanzada
        '
        Me._BtnConfiguracionAvanzada.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._BtnConfiguracionAvanzada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BtnConfiguracionAvanzada.ForeColor = System.Drawing.Color.Teal
        Me._BtnConfiguracionAvanzada.Location = New System.Drawing.Point(3, 539)
        Me._BtnConfiguracionAvanzada.Name = "_BtnConfiguracionAvanzada"
        Me._BtnConfiguracionAvanzada.Size = New System.Drawing.Size(463, 40)
        Me._BtnConfiguracionAvanzada.TabIndex = 2
        Me._BtnConfiguracionAvanzada.Text = "Configuraciones Avanzadas"
        Me._BtnConfiguracionAvanzada.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Crear Mes"
        '
        '_BtnCrearMes
        '
        Me._BtnCrearMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BtnCrearMes.ForeColor = System.Drawing.Color.Teal
        Me._BtnCrearMes.Location = New System.Drawing.Point(32, 48)
        Me._BtnCrearMes.Name = "_BtnCrearMes"
        Me._BtnCrearMes.Size = New System.Drawing.Size(177, 49)
        Me._BtnCrearMes.TabIndex = 0
        Me._BtnCrearMes.Text = "Crear"
        Me._BtnCrearMes.UseVisualStyleBackColor = True
        '
        'TabCaptura
        '
        Me.TabCaptura.Controls.Add(Me.GroupBox3)
        Me.TabCaptura.Controls.Add(Me._DgvngresoDatos)
        Me.TabCaptura.Location = New System.Drawing.Point(4, 25)
        Me.TabCaptura.Name = "TabCaptura"
        Me.TabCaptura.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCaptura.Size = New System.Drawing.Size(962, 588)
        Me.TabCaptura.TabIndex = 1
        Me.TabCaptura.Text = "Captura de Datos"
        Me.TabCaptura.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me._lblEstado)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me._CmbCapturaMeses)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(956, 77)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        '_lblEstado
        '
        Me._lblEstado.AutoSize = True
        Me._lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me._lblEstado.Location = New System.Drawing.Point(638, 44)
        Me._lblEstado.Name = "_lblEstado"
        Me._lblEstado.Size = New System.Drawing.Size(0, 16)
        Me._lblEstado.TabIndex = 12
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me._BtnCapturaGuardar, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(820, 11)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(130, 54)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        '_BtnCapturaGuardar
        '
        Me._BtnCapturaGuardar.Enabled = False
        Me._BtnCapturaGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._BtnCapturaGuardar.Location = New System.Drawing.Point(3, 3)
        Me._BtnCapturaGuardar.Name = "_BtnCapturaGuardar"
        Me._BtnCapturaGuardar.Size = New System.Drawing.Size(124, 48)
        Me._BtnCapturaGuardar.TabIndex = 6
        Me._BtnCapturaGuardar.Text = "Guardar"
        Me._BtnCapturaGuardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mes"
        '
        '_CmbCapturaMeses
        '
        Me._CmbCapturaMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmbCapturaMeses.FormattingEnabled = True
        Me._CmbCapturaMeses.Location = New System.Drawing.Point(6, 39)
        Me._CmbCapturaMeses.Name = "_CmbCapturaMeses"
        Me._CmbCapturaMeses.Size = New System.Drawing.Size(171, 26)
        Me._CmbCapturaMeses.TabIndex = 4
        '
        '_DgvngresoDatos
        '
        Me._DgvngresoDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me._DgvngresoDatos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me._DgvngresoDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me._DgvngresoDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me._DgvngresoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._DgvngresoDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ColumnDgvId, Me._ColumnDgvSexo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me._DgvngresoDatos.DefaultCellStyle = DataGridViewCellStyle2
        Me._DgvngresoDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._DgvngresoDatos.Location = New System.Drawing.Point(3, 80)
        Me._DgvngresoDatos.Name = "_DgvngresoDatos"
        Me._DgvngresoDatos.Size = New System.Drawing.Size(956, 505)
        Me._DgvngresoDatos.TabIndex = 5
        '
        '_ColumnDgvId
        '
        Me._ColumnDgvId.HeaderText = "ID"
        Me._ColumnDgvId.Name = "_ColumnDgvId"
        Me._ColumnDgvId.ReadOnly = True
        Me._ColumnDgvId.Width = 43
        '
        '_ColumnDgvSexo
        '
        Me._ColumnDgvSexo.HeaderText = "SEXO"
        Me._ColumnDgvSexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me._ColumnDgvSexo.Name = "_ColumnDgvSexo"
        Me._ColumnDgvSexo.Width = 42
        '
        'TabInforme
        '
        Me.TabInforme.Controls.Add(Me.GroupBox4)
        Me.TabInforme.Controls.Add(Me._DgvInformes)
        Me.TabInforme.Location = New System.Drawing.Point(4, 25)
        Me.TabInforme.Name = "TabInforme"
        Me.TabInforme.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInforme.Size = New System.Drawing.Size(962, 588)
        Me.TabInforme.TabIndex = 2
        Me.TabInforme.Text = "Informes Mensuales"
        Me.TabInforme.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me._CmbInformeMeses)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(956, 65)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(783, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(170, 52)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Teal
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 46)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Copiar Todo"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mes"
        '
        '_CmbInformeMeses
        '
        Me._CmbInformeMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmbInformeMeses.FormattingEnabled = True
        Me._CmbInformeMeses.Location = New System.Drawing.Point(6, 32)
        Me._CmbInformeMeses.Name = "_CmbInformeMeses"
        Me._CmbInformeMeses.Size = New System.Drawing.Size(183, 28)
        Me._CmbInformeMeses.TabIndex = 7
        '
        '_DgvInformes
        '
        Me._DgvInformes.AllowUserToAddRows = False
        Me._DgvInformes.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me._DgvInformes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me._DgvInformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me._DgvInformes.DefaultCellStyle = DataGridViewCellStyle4
        Me._DgvInformes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._DgvInformes.Location = New System.Drawing.Point(3, 64)
        Me._DgvInformes.Name = "_DgvInformes"
        Me._DgvInformes.ReadOnly = True
        Me._DgvInformes.Size = New System.Drawing.Size(956, 521)
        Me._DgvInformes.TabIndex = 8
        '
        'ContextMenuStripCaptura
        '
        Me.ContextMenuStripCaptura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.SeleToolStripMenuItem})
        Me.ContextMenuStripCaptura.Name = "ContextMenuStripCaptura"
        Me.ContextMenuStripCaptura.Size = New System.Drawing.Size(165, 48)
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'SeleToolStripMenuItem
        '
        Me.SeleToolStripMenuItem.Name = "SeleToolStripMenuItem"
        Me.SeleToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SeleToolStripMenuItem.Text = "Seleccional Todo"
        '
        'ContextMenuStripInforme
        '
        Me.ContextMenuStripInforme.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStripInforme.Name = "ContextMenuStrip1"
        Me.ContextMenuStripInforme.Size = New System.Drawing.Size(165, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem1.Text = "Copiar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem2.Text = "Seleccional Todo"
        '
        'FrmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 665)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LblEstatus)
        Me.Controls.Add(Me.MenuStripInformes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStripInformes
        Me.Name = "FrmControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Control II"
        Me.MenuStripInformes.ResumeLayout(False)
        Me.MenuStripInformes.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabHome.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabCaptura.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me._DgvngresoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInforme.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me._DgvInformes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripCaptura.ResumeLayout(False)
        Me.ContextMenuStripInforme.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripInformes As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblEstatus As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabHome As System.Windows.Forms.TabPage
    Friend WithEvents TabCaptura As System.Windows.Forms.TabPage
    Friend WithEvents TabInforme As System.Windows.Forms.TabPage
    Friend WithEvents BloquearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloquearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _DgvngresoDatos As System.Windows.Forms.DataGridView
    Friend WithEvents _DgvInformes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _LbxMeses As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _BtnCrearMes As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _BtnConfiguracionAvanzada As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents _BtnCapturaGuardar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents _CmbCapturaMeses As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _CmbInformeMeses As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContextMenuStripCaptura As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripInforme As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _lblEstado As System.Windows.Forms.Label
    Friend WithEvents ConfiguracionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _ColumnDgvId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents _ColumnDgvSexo As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
