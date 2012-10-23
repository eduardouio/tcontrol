Imports LogicaAplicacion
Public Class FrmConfiguraciones

    Dim DtRango As DataTable
    Public Sub CargaTabla(ByVal MiMes As String)
        Dim Catmes As CatalogoMes = New CatalogoMes
        Dim Dt As DataTable = Catmes.ListarColumnas(MiMes)
        Dim num As Integer = Dt.Rows.Count()

        For x As Integer = 0 To num - 1
            _LbxCrearMeses.Items.Add(Dt.Rows(x)(1))
        Next

        Dim rangos As CatalogoRangos = New CatalogoRangos()
        DtRango = rangos.ListarRangos()
        _Dgv_Informes_Rangos.AutoGenerateColumns = False
        _ColumnDgvID.DataPropertyName = "ID"
        _Dgv_Informes_Rangos.AutoGenerateColumns = True
        _Dgv_Informes_Rangos.DataSource = DtRango
        _Dgv_Informes_Rangos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader

    End Sub

    Public Sub CargarMeses()
        Dim CatalogoMeses As CatalogoMes = New CatalogoMes()
        Dim Dt As DataTable = New DataTable()
        Dt = CatalogoMeses.ListarMeses()
        Dim num As Integer = Dt.Rows.Count()

        For x As Integer = 0 To num - 1
            _CmbCrearReutilizarCampos.Items.Add(Dt.Rows(x)(0).ToString())
            _CmbEditaMeses.Items.Add(Dt.Rows(x)(0).ToString())
        Next
    End Sub

    Private Sub FrmConfiguraciones_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call FrmControlPanel.Show()
    End Sub

    Private Sub FrmConfiguraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        Dim mes As String = Now.Month.ToString()
        Dim ano As String = Now.Year.ToString()
        If mes.Length() = 1 Then
            mes = "0" + mes
        End If
        _MTxtCrearMes.Text = "_" + mes + "_" + ano
        CargaTabla("_04_2012")
        CargarMeses()

    End Sub

    Private Sub _CmbCrearReutilizarCampos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CmbCrearReutilizarCampos.SelectedIndexChanged
        Dim tabla As String = Me._CmbCrearReutilizarCampos.Text
        _LbxCrearMeses.Items.Clear()
        CargaTabla(tabla)
    End Sub

    Private Sub _BtnEliminarSeleccionado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnEliminarSeleccionado.Click
        Dim campo_eliminar As String = _LbxCrearMeses.SelectedItem.ToString()
        Select Case campo_eliminar
            Case Is = "ID"
                MsgBox("Este campo es usado para generar los informes, por lo tanto no puede ser Eliminado", MsgBoxStyle.Information, "Error al intertar eliminar un campo")
            Case Is = "SEXO"
                MsgBox("Este campo es usado para generar los informes, por lo tanto no puede ser Eliminado", MsgBoxStyle.Information, "Error al intertar eliminar un campo")
            Case Is = "EDAD"
                MsgBox("Este campo es usado para generar los informes, por lo tanto no puede ser Eliminado", MsgBoxStyle.Information, "Error al intertar eliminar un campo")
            Case Else
                Try
                    _LbxCrearMeses.Items.Remove(_LbxCrearMeses.SelectedItem)
                Catch ex As Exception
                    MsgBox("No se pudo Eliminar el campo " + ex.Message)

                End Try
        End Select
    End Sub

    Private Sub _BtnCrearAnadirCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnCrearAnadirCampo.Click
        Dim bandera As Boolean = False
        If _TxtCrearAnadirCampo.Text = "" Then
            MsgBox("El campo esta vacio, primero debe ingresar un nombre en la caja de texto de arriba", MsgBoxStyle.Critical, "Error")
        Else
            'validacion para que no añada campos duplicados 
            Dim campo_a_anadir, campo As String
            campo_a_anadir = StrConv(_TxtCrearAnadirCampo.Text, VbStrConv.Uppercase)
            campo_a_anadir = campo_a_anadir.Replace(" ", "")

            For x As Integer = 0 To _LbxCrearMeses.Items.Count() - 1
                campo = _LbxCrearMeses.Items(x)
                If (campo = campo_a_anadir) Then
                    bandera = True
                End If
            Next
            If bandera = True Then
                MsgBox("El campo ya existe!")
            Else
                _LbxCrearMeses.Items.Add(campo_a_anadir)
            End If

        End If
    End Sub

    Private Sub _BtnCrearMes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnCrearMes.Click

        Dim Catalogomeses As CatalogoMes = New CatalogoMes()
        Dim Parametros(_LbxCrearMeses.Items.Count() - 4) As String
        Dim pos As Integer = 0
        For x As Integer = 0 To _LbxCrearMeses.Items.Count() - 1
            If x > 2 Then
                Parametros(pos) = _LbxCrearMeses.Items(x)
                pos += 1
            End If
        Next
        Catalogomeses.CrearMes(Parametros, _MTxtCrearMes.Text)
    End Sub

    Private Sub _CmbEditaMeses_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _CmbEditaMeses.SelectedIndexChanged
        Try
            Dim Catmes As CatalogoMes = New CatalogoMes
            Dim Dt As DataTable = Catmes.ListarColumnas(Me._CmbEditaMeses.Text)
            Dim num As Integer = Dt.Rows.Count()
            _LbxeditaMeses.Items.Clear()
            For x As Integer = 0 To num - 1
                _LbxeditaMeses.Items.Add(Dt.Rows(x)(1))
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un Error al intentar listar los campos" + ex.Message)
        End Try
    End Sub

    Private Sub _BtnEditaAnadirCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnEditaAnadirCampo.Click
        Dim bandera As Boolean = False
        If _TxtEditaAnadirCampo.Text = "" Then
            MsgBox("El campo esta vacio, primero debe ingresar un nombre en la caja de texto de arriba", MsgBoxStyle.Critical, "Error")
        Else
            'validacion para que no añada campos duplicados 
            Dim campo_a_anadir, campo As String
            campo_a_anadir = StrConv(_TxtEditaAnadirCampo.Text, VbStrConv.Uppercase)
            campo_a_anadir = campo_a_anadir.Replace(" ", "")

            For x As Integer = 0 To _LbxeditaMeses.Items.Count() - 1
                campo = _LbxeditaMeses.Items(x)
                If (campo = campo_a_anadir) Then
                    bandera = True
                End If
            Next
            If bandera = True Then
                MsgBox("El campo ya existe!")
            Else
                Try
                    Dim Catalogo As CatalogoMes = New CatalogoMes()
                    Catalogo.AnadirColumna(campo_a_anadir, "INTEGER DEFAULT '0'", _CmbEditaMeses.Text)
                    _LbxeditaMeses.Items.Add(campo_a_anadir)
                Catch ex As Exception
                    MsgBox("Error al añadir campo" + ex.Message)
                End Try

            End If

        End If
    End Sub

    Private Sub _BtnCambiarPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnCambiarPass.Click
        Dim passnuevo As String = _TxtPassNuevo.Text
        Dim Catalogo As CatalogoUsuarios = New CatalogoUsuarios()
        Try
            Catalogo.ActualizarPass(passnuevo)
            MsgBox("Actualizacion Correcta!", MsgBoxStyle.Information, "Información")
            _TxtPassNuevo.Enabled = False
            _BtnCambiarPass.Enabled = False
            _TxtPass.Text = Nothing
            _TxtUsuario.Text = Nothing
            _TxtUsuario.Focus()
            _TxtUsuario.Select()
        Catch
        End Try
    End Sub

    Private Sub _BtnComprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnComprobar.Click
        Dim userant As String = _TxtUsuario.Text
        Dim passant As String = _TxtPass.Text

        _TxtUsuarioNuevo.Text = _TxtUsuario.Text
        Dim catalogo As CatalogoUsuarios = New CatalogoUsuarios()
        Dim miuser As Usuario = catalogo.ObtenerUsuario(userant)
        If (miuser.Usuario = userant) And (miuser.Pass = passant) Then
            MsgBox("Usuario identificado Por favor ingrese la nueva contraseña")
            _TxtPassNuevo.Enabled = True
            _BtnCambiarPass.Enabled = True
        End If

    End Sub

    Private Sub _BtnGuardarRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _BtnGuardarRango.Click
        Dim Cambiosrango As DataTable = DtRango.GetChanges()
        Dim rangos As CatalogoRangos = New CatalogoRangos()
        Try
            rangos.Guadar(Cambiosrango)
            MsgBox("Los Datos Se Guardaron Correctamente", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub _Dgv_Informes_Rangos_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles _Dgv_Informes_Rangos.DataError
        If e.Exception IsNot Nothing AndAlso _
           e.Context = DataGridViewDataErrorContexts.Commit Then
            MessageBox.Show("No debe quedar en Blanco ninguna Celda")
        End If
    End Sub
End Class