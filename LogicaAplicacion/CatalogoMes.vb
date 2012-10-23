'*************************************************************************************
' Copyright (C) 2012 Eduardo Villota <eduardo@liposerve.com>
' @autor: Eduardo Villota <ev_villota@hotmail.com>
' @version: 1.0
' @date: 2012-05-14 14:17:00
'
' Este programa es software libre, puede redistribuirlo y / o modificar
' Bajo los términos de la Licencia Pública General de GNU según lo publicado 
' por La Free Software Foundation, ya sea la versión 2 de la Licencia, o
' (A su elección) cualquier versión posterior.
'
' Este programa se distribuye con la esperanza de que sea útil,
' Pero SIN NINGUNA GARANTÍA, incluso sin la garantía implícita de
' IDONEIDAD PARA UN PROPÓSITO PARTICULAR. Véase el
' Licencia Pública General GNU para más detalles.
'
' Debería haber recibido una copia de la Licencia Pública General de GNU
' Junto con este programa. Si no es así, consulte <http://www.gnu.org/licenses/>.
'*************************************************************************************
' File notes:
'*************************************************************************************
' Este File Usa Las Clases:
' nimguna
' Caba base datos
' Acciones del File:
' Representa las actividades que se pueden llevar a cabo con un mes
'*************************************************************************************

Imports AccsesoDatos
Imports System.Data.Common
''' <summary>
''' Representa los ingresos de un mes para el sistema
''' </summary>
Public Class CatalogoMes
    Private _DtMes As DataTable = Nothing

    ''' <summary>
    ''' Obtenemos un mes de la base de datos
    ''' </summary>
    Public Function ObtenerMes(ByVal Id_Mes As String) As DataTable
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "SELECT * " + _
                            "FROM @mes;"
        Try
            BD.Conectar()
            BD.CrearComando(Sql)
            BD.AsignarParametroCadena("@mes", Id_Mes)
            Dim Dr_Mes As DbDataReader = BD.EjecutarConsulta()
            Me._DtMes = New DataTable()
            Me._DtMes.Load(Dr_Mes)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        Return Me._DtMes
    End Function

    ''' <summary>
    ''' Creamos un mes en la base de datos
    ''' </summary>
    Public Sub CrearMes(ByVal Campos() As String, ByVal Nombre As String)
        _DtMes = Nothing
        Dim Parametros As String = Nothing

        For Each miCampo As String In Campos
            Parametros = Parametros + miCampo.ToString() + " INTEGER DEFAULT '0',"
        Next

        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "CREATE " + _
                            "TABLE IF NOT EXISTS @nombre " + _
                            "( " + _
                            "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " + _
                            "SEXO VARCHAR(8), " + _
                            "EDAD INTEGER DEFAULT '0'," + _
                            "@parametros" + _
                            ");"
        BD.CrearComando(Sql)
        BD.AsignarParametroCadenaSola("@nombre", Nombre)
        BD.AsignarParametroCadenaSola("@parametros", Parametros)
        BD.AsignarParametroCadenaSola(",);", ");")

        Try
            BD.Conectar()
            BD.EjecutarComando()
            MsgBox("El comando se ejecuto con éxito!")
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

    Public Sub EliminarMes(ByVal Mes As String)
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "DROP TABLE main.@mes;"

        BD.CrearComando(Sql)
        BD.AsignarParametroCadenaSola("@mes", Mes)
        Try
            BD.Conectar()
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
    ''' <summary>
    ''' Devuelve una lista de todos los meses
    ''' </summary>
    Public Function ListarMeses() As DataTable
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = " SELECT name " + _
                            "FROM(sqlite_master) " + _
                            "WHERE name !='Usuarios' and name != 'sqlite_sequence' and name != 'sqlite_autoindex_Usuarios_1';"
        BD.Conectar()
        BD.CrearComando(Sql)

        Try
            Dim Dr_Meses As DbDataReader = BD.EjecutarConsulta()
            Me._DtMes = New DataTable()
            Me._DtMes.Load(Dr_Meses)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        Return Me._DtMes
    End Function

    ''' <summary>
    ''' Añade una clumna a una tabla
    ''' </summary>
    Public Sub AnadirColumna(ByVal NomColumna As String, ByVal TipoDato As String, ByVal Tabla As String)
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "ALTER " + _
                            "TABLE @tabla " + _
                            "ADD COLUMN @columna @dato;"
        BD.CrearComando(Sql)
        BD.AsignarParametroCadenaSola("@tabla", Tabla)
        BD.AsignarParametroCadenaSola("@columna", NomColumna)
        BD.AsignarParametroCadenaSola("@dato", TipoDato)

        Try
            BD.Conectar()
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

    ''' <summary>
    ''' lista las columnas de una tabla
    ''' </summary>
    Public Function ListarColumnas(ByVal Tabla As String) As DataTable
        Me._DtMes = Nothing
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "PRAGMA table_info (@tabla)"
        Try
            BD.Conectar()
            BD.CrearComando(Sql)
            BD.AsignarParametroCadena("@tabla", Tabla)
            Dim Dr_columnas As DbDataReader = BD.EjecutarConsulta()
            Me._DtMes = New DataTable()
            Me._DtMes.Load(Dr_columnas)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        Return Me._DtMes
    End Function

    ''' <summary>
    ''' toma los campo de una tabla
    ''' </summary>
    Public Function DuplicarCampostabla(ByVal Tabla As String) As DataTable
        Me._DtMes = Nothing
        Me._DtMes = Nothing
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "PRAGMA table_info (@tabla)"
        Try
            BD.Conectar()
            BD.CrearComando(Sql)
            BD.AsignarParametroCadena("@tabla", Tabla)
            Dim Dr_columnas As DbDataReader = BD.EjecutarConsulta()
            Me._DtMes.Load(Dr_columnas)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
        Catch ex As Exception
            MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        BD.Conectar()
        Return Me._DtMes
    End Function

    ''' <summary>
    ''' guardar los cambios en las tablas
    ''' </summary>
    Public Sub Guardar(ByVal DsDatos As DataTable)
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
