Imports System.Data.Common
Imports System.Data.SQLite

Public Class BaseDatos
    Protected _Cad As String = Nothing
    Protected _Comando As SQLiteCommand = Nothing
    Private _Conn As SQLiteConnection = Nothing
    Private _Adapter As SQLiteDataAdapter = Nothing
    Private _ComandoConstructor As SQLiteCommandBuilder = Nothing

    ''' <summary>
    ''' configura la conexion cuando se instancia la clase
    ''' </summary>
    Public Sub New()
        'Me._Cad = "Data Source=C:\Users\eduardo\Dropbox\desarrollo2012\TControl\AccsesoDatos\bd\ControlDB"
        Me._Cad = "Data Source=C:\control\ControlDB"
        Try
            Me._Conn = New SQLiteConnection(Me._Cad)
        Catch ex As Exception
            MsgBox("Error al establecer la cadena de Conexion", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub Conectar()
        If Not Me._Conn Is Nothing Then
            Try
                Me._Conn.Open()
            Catch ex As SQLiteException
                MsgBox("Error al conectarse a la base de datos el servidor Dijo..." + ex.Message, MsgBoxStyle.Critical, ex.ErrorCode.ToString())
            End Try
        Else
            MsgBox("no Existe conexion error de Programacion Accxell_axc3@hotmail.es", MsgBoxStyle.Critical)
        End If
    End Sub

    Public Sub SalvarCambios(ByVal DsTabla As DataTable)
        Try
            Me._Adapter = New SQLiteDataAdapter("SELECT * FROM " + DsTabla.TableName.ToString(), Me._Conn)
            Me._ComandoConstructor = New SQLiteCommandBuilder(Me._Adapter)
            Me._Adapter.Update(DsTabla)
            DsTabla.AcceptChanges()
        Catch ex As SQLiteException
            MsgBox("Error al guardar los datos el servidor dijo... " + ex.Message, MsgBoxStyle.Critical, ex.ErrorCode.ToString())
        End Try
    End Sub

    Public Sub Desconectar()
        If Not Me._Conn.State.Equals(ConnectionState.Open) Then
            MsgBox("La conexion ya esta Cerrada!", MsgBoxStyle.Exclamation)
        Else
            Me._Conn.Close()
        End If
    End Sub

    Public Sub CrearComando(ByVal Sql As String)
        Try
            If Not Sql Is Nothing Then
                Me._Comando = New SQLiteCommand()
                Me._Comando.Connection = Me._Conn
                Me._Comando.CommandType = CommandType.Text
                Me._Comando.CommandText = Sql
            End If
        Catch ex As Exception
            MsgBox("Error al crear el comando el servidor Dijo..." + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub EjecutarComando()
        Try
            If Not Me._Comando Is Nothing Then
                Me._Comando.ExecuteNonQuery()
            Else
                MsgBox("El comando no se ha creado ahún")
            End If
        Catch ex As SQLiteException
            MsgBox("Error al escribir datos el servidor Dijo..." + ex.Message, MsgBoxStyle.Critical, ex.ErrorCode.ToString())
        Catch ex As Exception
            MsgBox("Error al escribir datos Error..." + ex.Message)
        End Try
    End Sub

    Public Function EjecutarConsulta() As DbDataReader
        Return Me._Comando.ExecuteReader()
    End Function

    ''' <summary>
    ''' Asigna los parametros a las cadenas SQL
    ''' </summary>
    Public Sub AsignarParametro(ByVal Nombre As String, ByVal Separador As String, ByVal Valor As String)
        Dim indice As Integer = Me._Comando.CommandText.IndexOf(Nombre)
        Dim prefijo As String = Me._Comando.CommandText.Substring(0, indice)
        Dim sufijo As String = Me._Comando.CommandText.Substring(indice + Nombre.Length)
        Me._Comando.CommandText = prefijo + Separador + Valor + Separador + sufijo
    End Sub

    ''' <summary>
    ''' Asinga un parametro tipo Cadena
    ''' </summary>
    ''' <param name="Nombre">nombre del parametro @nombre</param>
    ''' <param name="Valor">valor del parametro</param>
    ''' <remarks>acondiciona los parámetros par la llamar a la funcion Asignar parametro</remarks>
    Public Sub AsignarParametroCadena(ByVal Nombre As String, ByVal Valor As String)
        Me.AsignarParametro(Nombre, "'", Valor.ToString())
    End Sub
    Public Sub AsignarParametroCadenaSola(ByVal Nombre As String, ByVal Valor As String)
        Me.AsignarParametro(Nombre, "", Valor.ToString())
    End Sub

    ''' <summary>
    ''' Asigna un Parametro Entero
    ''' </summary>
    ''' <param name="Nombre">nombre del parametro @nombre</param>
    ''' <param name="Valor">valor del parametro</param>
    Public Sub AsignarParametroEntero(ByVal Nombre As String, ByVal Valor As Integer)
        Me.AsignarParametro(Nombre, "", Valor.ToString())
    End Sub

    ''' <summary>
    ''' Asigna un Parametro Nulo
    ''' </summary>
    ''' <param name="Nombre">nombre del parametro @nombre</param>
    ''' <remarks>Se envia la palabra null para la consulta</remarks>
    Public Sub AsignarParametroCero(ByVal Nombre As String)
        Me.AsignarParametro(Nombre, "", "0")
    End Sub
End Class
