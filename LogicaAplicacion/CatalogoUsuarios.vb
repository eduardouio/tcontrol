Imports System.Data.Common
Imports AccsesoDatos


Public Class CatalogoUsuarios
    Private _Nombre As String = Nothing
    Private _Pass As String = Nothing

    Public Function ObtenerUsuarios() As List(Of Usuario)
        Dim misusuarioas As List(Of Usuario) = New List(Of Usuario)()
        Dim cad As String = "Select * from usuarios;"
        Dim BD As BaseDatos = New BaseDatos()
        Try
            BD.Conectar()
            BD.CrearComando(cad)
            Dim Dr_Usuarios As DbDataReader = BD.EjecutarConsulta()

            While Dr_Usuarios.Read()
                Dim MiUsuario As Usuario = New Usuario()
                MiUsuario.Usuario = Dr_Usuarios.GetString(1)
                MiUsuario.Pass = Dr_Usuarios.GetString(2)
                misusuarioas.Add(MiUsuario)
            End While
            Dr_Usuarios.Close()
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        Return misusuarioas
    End Function
    Public Function ObtenerUsuario(ByVal Elusuario As String) As Usuario
        Dim Miusuario As Usuario = Nothing
        Dim cad As String = "Select * from usuarios where usuario = @usuario;"
        Dim BD As BaseDatos = New BaseDatos()

        BD.Conectar()
        BD.CrearComando(cad)
        BD.AsignarParametroCadena("@usuario", Elusuario)
        Try
            Dim Dr_Usuarios As DbDataReader = BD.EjecutarConsulta()

            While Dr_Usuarios.Read()
                Miusuario = New Usuario()
                Miusuario.Usuario = Dr_Usuarios.GetString(1)
                Miusuario.Pass = Dr_Usuarios.GetString(2)
            End While
            Dr_Usuarios.Close()
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try

        Return Miusuario

    End Function

    Public Sub ActualizarPass(ByVal pass As String)
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "UPDATE Usuarios SET Pass = @pass WHERE usuario = 'admin';"

        Try
            BD.Conectar()
            BD.CrearComando(Sql)
            BD.AsignarParametroCadena("@pass", pass)
            BD.EjecutarComando()
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try

    End Sub
End Class
