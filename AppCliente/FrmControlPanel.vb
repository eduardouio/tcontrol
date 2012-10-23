Imports LogicaAplicacion

Public Class FrmControlPanel

    Dim _DtMes As DataTable = Nothing
    Dim _DtInforme As DataTable = Nothing
    ''' <summary>
    ''' Carga en los objetos los meses 
    ''' </summary>
    Public Sub CargarMeses()
        Dim CatalogoMeses As CatalogoMes = New CatalogoMes()
        Dim Dt As DataTable = New DataTable()
        Dt = CatalogoMeses.ListarMeses()
        Dim num As Integer = Dt.Rows.Count()

        For x As Integer = 0 To num - 1
            If Not (Dt.Rows(x)(0).ToString() = "Condiciones") Then
                _CmbCapturaMeses.Items.Add(Dt.Rows(x)(0).ToString())
                _CmbInformeMeses.Items.Add(Dt.Rows(x)(0).ToString())
                _LbxMeses.Items.Add(Dt.Rows(x)(0).ToString())
            End If
        Next
        LblEstatus.Text = "Se han encontrado " + Me._CmbCapturaMeses.Items.Count().ToString() + " Meses registrados"
    End Sub

    Private Sub FrmControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarMeses()
            _DgvInformes.ContextMenuStrip = ContextMenuStripInforme
            _DgvngresoDatos.ContextMenuStrip = ContextMenuStripCaptura
            _lblEstado.Text = Nothing
        Catch ex As Exception
            MsgBox("Ocurrio un Erro al iniciar la aplicacion" + ex.Message)
        End Try
        _LbxMeses.Focus()
        _LbxMeses.Select()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnConfiguracionAvanzada.Click
        Call FrmConfiguraciones.Show()
        Me.Close()
    End Sub

    Private Sub _BtnCrearMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnCrearMes.Click
        Call FrmConfiguraciones.Show()
        Me.Close()
    End Sub

    Private Sub _CmbCapturaMeses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CmbCapturaMeses.SelectedIndexChanged
        Dim tabla As String = Me._CmbCapturaMeses.Text
        Dim Catalogo As CatalogoMes = New CatalogoMes()
        Me._DtMes = Catalogo.ObtenerMes(tabla)
        _DgvngresoDatos.AutoGenerateColumns = False
        _ColumnDgvId.DataPropertyName = "ID"
        _ColumnDgvSexo.DataPropertyName = "SEXO"
        _DgvngresoDatos.AutoGenerateColumns = True
        _DgvngresoDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me._DgvngresoDatos.DataSource = _DtMes
        LblEstatus.Text = "Se han encontrado " + Me._DtMes.Rows.Count().ToString() + " Registros en la tabla" + Me._CmbCapturaMeses.Text
    End Sub

    Private Sub _LbxMeses_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles _LbxMeses.DoubleClick
        Dim Tablas As String = _LbxMeses.SelectedItem
        TabControl1.SelectedTab = TabControl1.TabPages(1)
        _CmbCapturaMeses.Text = Tablas.ToString()
        _CmbCapturaMeses.Focus()
        _CmbCapturaMeses.Select()
    End Sub

    Private Sub _BtnCapturaGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnCapturaGuardar.Click

        Try
            Dim cambios As DataTable
            Dim catalogo As CatalogoMes = New CatalogoMes()
            cambios = Me._DtMes.GetChanges()
            catalogo.Guardar(Me._DtMes)
            MsgBox("Datos Guardados Correctamente.", MsgBoxStyle.Information, "Guardado!")
            LblEstatus.Text = "Datos Guardados Correctamente"
            _lblEstado.Text = ""
            Me._BtnCapturaGuardar.Enabled = False
        Catch ex As Exception
            MsgBox("Error al guardar los datos ev_villota@hotmail.com", MsgBoxStyle.Critical, "Error Critico")
        End Try
        
    End Sub

    Private Sub _CmbInformeMeses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CmbInformeMeses.SelectedIndexChanged
        Dim informe As CatalgoInformes = New CatalgoInformes()
        Dim dt_Informe As DataTable = informe.CrearInforme(Me._CmbInformeMeses.Text)
        _DgvInformes.DataSource = dt_Informe
        LblEstatus.Text = "Se han encontrado " + dt_Informe.Rows.Count().ToString() + " Especialidades para la tabla" + Me._CmbInformeMeses.Text
    End Sub

    Private Sub BloquearToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloquearToolStripMenuItem1.Click
        If MsgBox("¿Desea Bloquear la Ventana?", MsgBoxStyle.OkCancel, "¿Pregunta?") = MsgBoxResult.Ok Then
            Call FrmLoginII.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("¿Desea Salir del Sistema?", MsgBoxStyle.OkCancel, "¿Pregunta?") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Call FrmConfiguraciones.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me._DgvInformes.SelectAll()
        Me._DgvInformes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
        If Me._DgvInformes.GetCellCount(DataGridViewElementStates.Selected) > 0 Then
            Try
                Clipboard.SetDataObject(Me._DgvInformes.GetClipboardContent())
            Catch ex As Exception
                MsgBox("Error al copiar la seleccion, es provable que no exista ninguna seleccion!", MsgBoxStyle.Information, "No hay seleccion")
            End Try
        End If
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        _DgvngresoDatos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
        If _DgvngresoDatos.GetCellCount(DataGridViewElementStates.Selected) > 0 Then
            Try
                Clipboard.SetDataObject(_DgvngresoDatos.GetClipboardContent())
            Catch ex As Exception
                MsgBox("Error al copiar la seleccion, es provable que no exista ninguna seleccion!", MsgBoxStyle.Information, "No hay seleccion")
            End Try
        End If
    End Sub

    Private Sub SeleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleToolStripMenuItem.Click
        _DgvngresoDatos.SelectAll()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        _DgvInformes.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText
        If _DgvInformes.GetCellCount(DataGridViewElementStates.Selected) > 0 Then
            Try
                Clipboard.SetDataObject(_DgvInformes.GetClipboardContent())
            Catch ex As Exception
                MsgBox("Error al copiar la seleccion, es provable que no exista ninguna seleccion!", MsgBoxStyle.Information, "No hay seleccion")
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        _DgvInformes.SelectAll()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Call SplashScreen.Show()
    End Sub

    Private Sub _DgvngresoDatos_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles _DgvngresoDatos.CellEndEdit
        _lblEstado.Text = "Editado Mes!"
        _BtnCapturaGuardar.Enabled = True
    End Sub

    Private Sub _DgvngresoDatos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles _DgvngresoDatos.DataError
        If e.Exception IsNot Nothing AndAlso _
            e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("No debe quedar en Blanco ninguna Celda")
        End If
    End Sub

    Private Sub ConfiguracionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionesToolStripMenuItem.Click
        Call FrmConfiguraciones.Show()
        Me.Close()
    End Sub

 
End Class