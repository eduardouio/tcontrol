Imports System.Data.Common
Imports AccsesoDatos

Public Class CatalogoRangos

    Public Function ListarRangos() As DataTable
        Dim Dt_rangos As DataTable = New DataTable()
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "Select * from Condiciones;"
        Try
            BD.CrearComando(Sql)
            BD.Conectar()
            Dim Dr_rangos As DbDataReader = BD.EjecutarConsulta()
            Dt_rangos.Load(Dr_rangos)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try

        Return Dt_rangos
    End Function

    Public Sub Guadar(ByVal DsDatos As DataTable)
        Dim BD As BaseDatos = New BaseDatos()
        Try
            BD.Conectar()
            BD.SalvarCambios(DsDatos)
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
