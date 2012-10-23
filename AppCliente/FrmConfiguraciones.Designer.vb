<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguraciones))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabMeses = New System.Windows.Forms.TabPage
        Me._BtnEliminarSeleccionado = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me._BtnCrearMes = New System.Windows.Forms.Button
        Me._BtnCrearAnadirCampo = New System.Windows.Forms.Button
        Me._TxtCrearAnadirCampo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me._CmbCrearReutilizarCampos = New System.Windows.Forms.ComboBox
        Me._LbxCrearMeses = New System.Windows.Forms.ListBox
        Me._MTxtCrearMes = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabTablas = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me._BtnEditaAnadirCampo = New System.Windows.Forms.Button
        Me._TxtEditaAnadirCampo = New System.Windows.Forms.TextBox
        Me._CmbEditaMeses = New System.Windows.Forms.ComboBox
        Me._LbxeditaMeses = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabUsuarios = New System.Windows.Forms.TabPage
        Me._BtnComprobar = New System.Windows.Forms.Button
        Me.DgbDatosNuevos = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me._TxtPassNuevo = New System.Windows.Forms.TextBox
        Me._TxtUsuarioNuevo = New System.Windows.Forms.TextBox
        Me.GbxDatosActuales = New System.Windows.Forms.GroupBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me._TxtUsuario = New System.Windows.Forms.TextBox
        Me._TxtPass = New System.Windows.Forms.TextBox
        Me._BtnCambiarPass = New System.Windows.Forms.Button
        Me.TabInformes = New System.Windows.Forms.TabPage
        Me._BtnGuardarRango = New System.Windows.Forms.Button
        Me._Dgv_Informes_Rangos = New System.Windows.Forms.DataGridView
        Me._ColumnDgvID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LblEstatus = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabMeses.SuspendLayout()
        Me.TabTablas.SuspendLayout()
        Me.TabUsuarios.SuspendLayout()
        Me.DgbDatosNuevos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxDatosActuales.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInformes.SuspendLayout()
        CType(Me._Dgv_Informes_Rangos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabMeses)
        Me.TabControl1.Controls.Add(Me.TabTablas)
        Me.TabControl1.Controls.Add(Me.TabUsuarios)
        Me.TabControl1.Controls.Add(Me.TabInformes)
        Me.TabControl1.Location = New System.Drawing.Point(0, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 465)
        Me.TabControl1.TabIndex = 0
        '
        'TabMeses
        '
        Me.TabMeses.Controls.Add(Me._BtnEliminarSeleccionado)
        Me.TabMeses.Controls.Add(Me.Label5)
        Me.TabMeses.Controls.Add(Me._BtnCrearMes)
        Me.TabMeses.Controls.Add(Me._BtnCrearAnadirCampo)
        Me.TabMeses.Controls.Add(Me._TxtCrearAnadirCampo)
        Me.TabMeses.Controls.Add(Me.Label4)
        Me.TabMeses.Controls.Add(Me._CmbCrearReutilizarCampos)
        Me.TabMeses.Controls.Add(Me._LbxCrearMeses)
        Me.TabMeses.Controls.Add(Me._MTxtCrearMes)
        Me.TabMeses.Controls.Add(Me.Label3)
        Me.TabMeses.Controls.Add(Me.Button1)
        Me.TabMeses.Location = New System.Drawing.Point(4, 25)
        Me.TabMeses.Name = "TabMeses"
        Me.TabMeses.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMeses.Size = New System.Drawing.Size(586, 436)
        Me.TabMeses.TabIndex = 0
        Me.TabMeses.Text = "Crear Meses"
        Me.TabMeses.UseVisualStyleBackColor = True
        '
        '_BtnEliminarSeleccionado
        '
        Me._BtnEliminarSeleccionado.Location = New System.Drawing.Point(411, 140)
        Me._BtnEliminarSeleccionado.Name = "_BtnEliminarSeleccionado"
        Me._BtnEliminarSeleccionado.Size = New System.Drawing.Size(167, 33)
        Me._BtnEliminarSeleccionado.TabIndex = 6
        Me._BtnEliminarSeleccionado.Text = "Eliminar Seleccionado"
        Me._BtnEliminarSeleccionado.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Añadir Campo"
        '
        '_BtnCrearMes
        '
        Me._BtnCrearMes.Location = New System.Drawing.Point(32, 83)
        Me._BtnCrearMes.Name = "_BtnCrearMes"
        Me._BtnCrearMes.Size = New System.Drawing.Size(124, 33)
        Me._BtnCrearMes.TabIndex = 1
        Me._BtnCrearMes.Text = "Crear"
        Me._BtnCrearMes.UseVisualStyleBackColor = True
        '
        '_BtnCrearAnadirCampo
        '
        Me._BtnCrearAnadirCampo.Location = New System.Drawing.Point(411, 83)
        Me._BtnCrearAnadirCampo.Name = "_BtnCrearAnadirCampo"
        Me._BtnCrearAnadirCampo.Size = New System.Drawing.Size(124, 33)
        Me._BtnCrearAnadirCampo.TabIndex = 5
        Me._BtnCrearAnadirCampo.Text = "Añadir"
        Me._BtnCrearAnadirCampo.UseVisualStyleBackColor = True
        '
        '_TxtCrearAnadirCampo
        '
        Me._TxtCrearAnadirCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtCrearAnadirCampo.Location = New System.Drawing.Point(411, 48)
        Me._TxtCrearAnadirCampo.Name = "_TxtCrearAnadirCampo"
        Me._TxtCrearAnadirCampo.Size = New System.Drawing.Size(169, 22)
        Me._TxtCrearAnadirCampo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Reutilizar  Campos"
        '
        '_CmbCrearReutilizarCampos
        '
        Me._CmbCrearReutilizarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmbCrearReutilizarCampos.FormattingEnabled = True
        Me._CmbCrearReutilizarCampos.Location = New System.Drawing.Point(5, 159)
        Me._CmbCrearReutilizarCampos.Name = "_CmbCrearReutilizarCampos"
        Me._CmbCrearReutilizarCampos.Size = New System.Drawing.Size(151, 23)
        Me._CmbCrearReutilizarCampos.TabIndex = 2
        '
        '_LbxCrearMeses
        '
        Me._LbxCrearMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbxCrearMeses.FormattingEnabled = True
        Me._LbxCrearMeses.ItemHeight = 15
        Me._LbxCrearMeses.Location = New System.Drawing.Point(162, 6)
        Me._LbxCrearMeses.Name = "_LbxCrearMeses"
        Me._LbxCrearMeses.Size = New System.Drawing.Size(228, 409)
        Me._LbxCrearMeses.TabIndex = 3
        '
        '_MTxtCrearMes
        '
        Me._MTxtCrearMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._MTxtCrearMes.Location = New System.Drawing.Point(5, 48)
        Me._MTxtCrearMes.Mask = "_L##_####"
        Me._MTxtCrearMes.Name = "_MTxtCrearMes"
        Me._MTxtCrearMes.Size = New System.Drawing.Size(151, 21)
        Me._MTxtCrearMes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Crear Mes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabTablas
        '
        Me.TabTablas.Controls.Add(Me.Label8)
        Me.TabTablas.Controls.Add(Me._BtnEditaAnadirCampo)
        Me.TabTablas.Controls.Add(Me._TxtEditaAnadirCampo)
        Me.TabTablas.Controls.Add(Me._CmbEditaMeses)
        Me.TabTablas.Controls.Add(Me._LbxeditaMeses)
        Me.TabTablas.Controls.Add(Me.Label10)
        Me.TabTablas.Location = New System.Drawing.Point(4, 25)
        Me.TabTablas.Name = "TabTablas"
        Me.TabTablas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTablas.Size = New System.Drawing.Size(586, 436)
        Me.TabTablas.TabIndex = 2
        Me.TabTablas.Text = "Editar Campos de Mes"
        Me.TabTablas.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(395, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Añadir Campo"
        '
        '_BtnEditaAnadirCampo
        '
        Me._BtnEditaAnadirCampo.Location = New System.Drawing.Point(398, 52)
        Me._BtnEditaAnadirCampo.Name = "_BtnEditaAnadirCampo"
        Me._BtnEditaAnadirCampo.Size = New System.Drawing.Size(124, 33)
        Me._BtnEditaAnadirCampo.TabIndex = 10
        Me._BtnEditaAnadirCampo.Text = "Añadir"
        Me._BtnEditaAnadirCampo.UseVisualStyleBackColor = True
        '
        '_TxtEditaAnadirCampo
        '
        Me._TxtEditaAnadirCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtEditaAnadirCampo.Location = New System.Drawing.Point(398, 24)
        Me._TxtEditaAnadirCampo.Name = "_TxtEditaAnadirCampo"
        Me._TxtEditaAnadirCampo.Size = New System.Drawing.Size(169, 22)
        Me._TxtEditaAnadirCampo.TabIndex = 9
        '
        '_CmbEditaMeses
        '
        Me._CmbEditaMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._CmbEditaMeses.FormattingEnabled = True
        Me._CmbEditaMeses.Location = New System.Drawing.Point(11, 24)
        Me._CmbEditaMeses.Name = "_CmbEditaMeses"
        Me._CmbEditaMeses.Size = New System.Drawing.Size(151, 23)
        Me._CmbEditaMeses.TabIndex = 7
        '
        '_LbxeditaMeses
        '
        Me._LbxeditaMeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LbxeditaMeses.FormattingEnabled = True
        Me._LbxeditaMeses.ItemHeight = 15
        Me._LbxeditaMeses.Location = New System.Drawing.Point(195, 6)
        Me._LbxeditaMeses.Name = "_LbxeditaMeses"
        Me._LbxeditaMeses.Size = New System.Drawing.Size(159, 379)
        Me._LbxeditaMeses.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Editar Mes"
        '
        'TabUsuarios
        '
        Me.TabUsuarios.Controls.Add(Me._BtnComprobar)
        Me.TabUsuarios.Controls.Add(Me.DgbDatosNuevos)
        Me.TabUsuarios.Controls.Add(Me.GbxDatosActuales)
        Me.TabUsuarios.Controls.Add(Me._BtnCambiarPass)
        Me.TabUsuarios.Location = New System.Drawing.Point(4, 25)
        Me.TabUsuarios.Name = "TabUsuarios"
        Me.TabUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabUsuarios.Size = New System.Drawing.Size(586, 436)
        Me.TabUsuarios.TabIndex = 1
        Me.TabUsuarios.Text = "Cambiar Contraseña"
        Me.TabUsuarios.UseVisualStyleBackColor = True
        '
        '_BtnComprobar
        '
        Me._BtnComprobar.Location = New System.Drawing.Point(251, 158)
        Me._BtnComprobar.Name = "_BtnComprobar"
        Me._BtnComprobar.Size = New System.Drawing.Size(124, 33)
        Me._BtnComprobar.TabIndex = 13
        Me._BtnComprobar.Text = "Verificar"
        Me._BtnComprobar.UseVisualStyleBackColor = True
        '
        'DgbDatosNuevos
        '
        Me.DgbDatosNuevos.Controls.Add(Me.PictureBox1)
        Me.DgbDatosNuevos.Controls.Add(Me.Label2)
        Me.DgbDatosNuevos.Controls.Add(Me.Label1)
        Me.DgbDatosNuevos.Controls.Add(Me._TxtPassNuevo)
        Me.DgbDatosNuevos.Controls.Add(Me._TxtUsuarioNuevo)
        Me.DgbDatosNuevos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgbDatosNuevos.Location = New System.Drawing.Point(11, 197)
        Me.DgbDatosNuevos.Name = "DgbDatosNuevos"
        Me.DgbDatosNuevos.Size = New System.Drawing.Size(364, 146)
        Me.DgbDatosNuevos.TabIndex = 23
        Me.DgbDatosNuevos.TabStop = False
        Me.DgbDatosNuevos.Text = "Datos Nuevos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 104)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(135, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(135, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Contraseña"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_TxtPassNuevo
        '
        Me._TxtPassNuevo.Enabled = False
        Me._TxtPassNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtPassNuevo.Location = New System.Drawing.Point(137, 107)
        Me._TxtPassNuevo.Name = "_TxtPassNuevo"
        Me._TxtPassNuevo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._TxtPassNuevo.Size = New System.Drawing.Size(169, 22)
        Me._TxtPassNuevo.TabIndex = 14
        '
        '_TxtUsuarioNuevo
        '
        Me._TxtUsuarioNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtUsuarioNuevo.Location = New System.Drawing.Point(137, 56)
        Me._TxtUsuarioNuevo.Name = "_TxtUsuarioNuevo"
        Me._TxtUsuarioNuevo.ReadOnly = True
        Me._TxtUsuarioNuevo.Size = New System.Drawing.Size(169, 22)
        Me._TxtUsuarioNuevo.TabIndex = 55
        '
        'GbxDatosActuales
        '
        Me.GbxDatosActuales.Controls.Add(Me.LogoPictureBox)
        Me.GbxDatosActuales.Controls.Add(Me.UsernameLabel)
        Me.GbxDatosActuales.Controls.Add(Me.PasswordLabel)
        Me.GbxDatosActuales.Controls.Add(Me._TxtUsuario)
        Me.GbxDatosActuales.Controls.Add(Me._TxtPass)
        Me.GbxDatosActuales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDatosActuales.Location = New System.Drawing.Point(21, 6)
        Me.GbxDatosActuales.Name = "GbxDatosActuales"
        Me.GbxDatosActuales.Size = New System.Drawing.Size(354, 146)
        Me.GbxDatosActuales.TabIndex = 22
        Me.GbxDatosActuales.TabStop = False
        Me.GbxDatosActuales.Text = "Datos Actuales"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.InitialImage = CType(resources.GetObject("LogoPictureBox.InitialImage"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(15, 21)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(99, 104)
        Me.LogoPictureBox.TabIndex = 14
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(124, 16)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(79, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(124, 66)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(79, 23)
        Me.PasswordLabel.TabIndex = 12
        Me.PasswordLabel.Text = "Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_TxtUsuario
        '
        Me._TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtUsuario.Location = New System.Drawing.Point(126, 41)
        Me._TxtUsuario.Name = "_TxtUsuario"
        Me._TxtUsuario.Size = New System.Drawing.Size(169, 22)
        Me._TxtUsuario.TabIndex = 11
        '
        '_TxtPass
        '
        Me._TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TxtPass.Location = New System.Drawing.Point(126, 92)
        Me._TxtPass.Name = "_TxtPass"
        Me._TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me._TxtPass.Size = New System.Drawing.Size(169, 22)
        Me._TxtPass.TabIndex = 12
        '
        '_BtnCambiarPass
        '
        Me._BtnCambiarPass.Enabled = False
        Me._BtnCambiarPass.Location = New System.Drawing.Point(251, 349)
        Me._BtnCambiarPass.Name = "_BtnCambiarPass"
        Me._BtnCambiarPass.Size = New System.Drawing.Size(124, 33)
        Me._BtnCambiarPass.TabIndex = 15
        Me._BtnCambiarPass.Text = "Cambiar"
        Me._BtnCambiarPass.UseVisualStyleBackColor = True
        '
        'TabInformes
        '
        Me.TabInformes.Controls.Add(Me._BtnGuardarRango)
        Me.TabInformes.Controls.Add(Me._Dgv_Informes_Rangos)
        Me.TabInformes.Location = New System.Drawing.Point(4, 25)
        Me.TabInformes.Name = "TabInformes"
        Me.TabInformes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabInformes.Size = New System.Drawing.Size(586, 436)
        Me.TabInformes.TabIndex = 3
        Me.TabInformes.Text = "Configuracion de Informes"
        Me.TabInformes.UseVisualStyleBackColor = True
        '
        '_BtnGuardarRango
        '
        Me._BtnGuardarRango.Location = New System.Drawing.Point(459, 382)
        Me._BtnGuardarRango.Name = "_BtnGuardarRango"
        Me._BtnGuardarRango.Size = New System.Drawing.Size(124, 33)
        Me._BtnGuardarRango.TabIndex = 17
        Me._BtnGuardarRango.Text = "Guardar Cambios"
        Me._BtnGuardarRango.UseVisualStyleBackColor = True
        '
        '_Dgv_Informes_Rangos
        '
        Me._Dgv_Informes_Rangos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._Dgv_Informes_Rangos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._ColumnDgvID})
        Me._Dgv_Informes_Rangos.Location = New System.Drawing.Point(6, 6)
        Me._Dgv_Informes_Rangos.Name = "_Dgv_Informes_Rangos"
        Me._Dgv_Informes_Rangos.Size = New System.Drawing.Size(572, 370)
        Me._Dgv_Informes_Rangos.TabIndex = 16
        '
        '_ColumnDgvID
        '
        Me._ColumnDgvID.HeaderText = "ID"
        Me._ColumnDgvID.Name = "_ColumnDgvID"
        Me._ColumnDgvID.ReadOnly = True
        '
        'LblEstatus
        '
        Me.LblEstatus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblEstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblEstatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblEstatus.Location = New System.Drawing.Point(0, 480)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(594, 24)
        Me.LblEstatus.TabIndex = 9
        '
        'FrmConfiguraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 504)
        Me.Controls.Add(Me.LblEstatus)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfiguraciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConfiguraciones"
        Me.TabControl1.ResumeLayout(False)
        Me.TabMeses.ResumeLayout(False)
        Me.TabMeses.PerformLayout()
        Me.TabTablas.ResumeLayout(False)
        Me.TabTablas.PerformLayout()
        Me.TabUsuarios.ResumeLayout(False)
        Me.DgbDatosNuevos.ResumeLayout(False)
        Me.DgbDatosNuevos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxDatosActuales.ResumeLayout(False)
        Me.GbxDatosActuales.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInformes.ResumeLayout(False)
        CType(Me._Dgv_Informes_Rangos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabMeses As System.Windows.Forms.TabPage
    Friend WithEvents TabUsuarios As System.Windows.Forms.TabPage
    Friend WithEvents TabTablas As System.Windows.Forms.TabPage
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents _TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents _TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _TxtPassNuevo As System.Windows.Forms.TextBox
    Friend WithEvents _TxtUsuarioNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _BtnCambiarPass As System.Windows.Forms.Button
    Friend WithEvents LblEstatus As System.Windows.Forms.Label
    Friend WithEvents DgbDatosNuevos As System.Windows.Forms.GroupBox
    Friend WithEvents GbxDatosActuales As System.Windows.Forms.GroupBox
    Friend WithEvents _MTxtCrearMes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents _LbxCrearMeses As System.Windows.Forms.ListBox
    Friend WithEvents _TxtCrearAnadirCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents _CmbCrearReutilizarCampos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents _BtnCrearMes As System.Windows.Forms.Button
    Friend WithEvents _BtnCrearAnadirCampo As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents _BtnEditaAnadirCampo As System.Windows.Forms.Button
    Friend WithEvents _TxtEditaAnadirCampo As System.Windows.Forms.TextBox
    Friend WithEvents _CmbEditaMeses As System.Windows.Forms.ComboBox
    Friend WithEvents _LbxeditaMeses As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents _BtnEliminarSeleccionado As System.Windows.Forms.Button
    Friend WithEvents TabInformes As System.Windows.Forms.TabPage
    Friend WithEvents _Dgv_Informes_Rangos As System.Windows.Forms.DataGridView
    Friend WithEvents _BtnGuardarRango As System.Windows.Forms.Button
    Friend WithEvents _BtnComprobar As System.Windows.Forms.Button
    Friend WithEvents _ColumnDgvID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
