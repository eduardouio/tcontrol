Imports System.Exception
Imports System.Data.Common
Imports AccsesoDatos


''' <summary>
''' Geenenra el informe mensual 
''' </summary>
Public Class CatalgoInformes
    Private _DtInforme As DataTable = Nothing

    ''' <summary>
    ''' encargada de generar el informe del mes
    ''' </summary>
    Public Function CrearInforme(ByVal mes As String) As DataTable
        Me._DtInforme = New DataTable()
        Dim CatalogoMeses As CatalogoMes = New CatalogoMes()

        Try
            Dim Dt_Filas As DataTable = CatalogoMeses.ListarColumnas(mes)
            Dim Dt_Condiciones As DataTable = Me.ObtenerCondiciones()

            'Añadimos las columnas estaticas
            Me._DtInforme.Columns.Add(Me.AgregarColumna("Especialidades", "String"))
            Me._DtInforme.Columns.Add(Me.AgregarColumna("Totales", "String"))
            Me._DtInforme.Columns.Add(Me.AgregarColumna("T_Hombre", "String"))
            Me._DtInforme.Columns.Add(Me.AgregarColumna("T_Mujer", "String"))

            'añadimos columnas dimanicas
            For x As Integer = 0 To Dt_Condiciones.Rows.Count() - 1
                Me._DtInforme.Columns.Add(Me.AgregarColumna("De_" + Dt_Condiciones.Rows(x)(0).ToString() + "_A_ " + Dt_Condiciones.Rows(x)(1).ToString(), "String"))
            Next

            'Primero listamos las columnas
            Dim columnas(_DtInforme.Columns.Count - 1) As String
            For i As Integer = 0 To Me._DtInforme.Columns.Count - 1
                columnas(i) = Me._DtInforme.Columns(i).ColumnName.ToString()
            Next

            'Ahora listamos la fila
            Dim Fila(columnas.Length() - 1) As String

            'cantidad de filas a aumentar
            Dim x7 As Integer = 3

            For xx As Integer = 0 To Dt_Filas.Rows.Count() - 4
                Dim condicion As Integer = 0
                'la fila a aumentar
                For ii As Integer = 0 To columnas.Length() - 1
                    If ii = 0 Then
                        Fila(ii) = Dt_Filas.Rows(x7)(1).ToString()
                    ElseIf ii = 1 Then
                        Fila(ii) = Me.ObtenerTotal(Dt_Filas.Rows(x7)(1).ToString(), mes, 0, 0, "0")
                    ElseIf ii = 2 Then
                        Fila(ii) = Me.ObtenerTotal(Dt_Filas.Rows(x7)(1).ToString(), mes, 0, 0, "Hombre")
                    ElseIf ii = 3 Then
                        Fila(ii) = Me.ObtenerTotal(Dt_Filas.Rows(x7)(1).ToString(), mes, 0, 0, "Mujer")
                    Else
                        If condicion < Dt_Condiciones.Rows.Count() Then
                            Fila(ii) = Me.ObtenerTotal(Dt_Filas.Rows(x7)(1).ToString(), mes, Dt_Condiciones(condicion)(0), Dt_Condiciones(condicion)(1), "0")
                            condicion = condicion + 1
                        End If
                    End If
                Next
                AgregarRow(Fila, columnas)
                x7 = x7 + 1
            Next
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
            '  Catch ex As Exception
            '     MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")

        End Try
        Return Me._DtInforme
    End Function

    ''' <summary>
    ''' Retorna las condiciones de la tabla
    ''' </summary>
    Public Function ObtenerCondiciones() As DataTable
        Dim Dt_condiciones As DataTable = Nothing
        Dim BD As BaseDatos = New BaseDatos()
        Dim Sql As String = "SELECT Rango_inicio, Rango_Fin " + _
                            "FROM Condiciones;"
        Try
            BD.Conectar()
            BD.CrearComando(Sql)
            Dim Dr_condiciones As DbDataReader = BD.EjecutarConsulta()
            Dt_condiciones = New DataTable()
            Dt_condiciones.Load(Dr_condiciones)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
            '     Catch ex As Exception
            '  MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Finally
            BD.Desconectar()
        End Try
        Return Dt_condiciones
    End Function

    ''' <summary>
    ''' Agrega una coluna al datatable
    ''' </summary>
    ''' <param name="Nombre">nombre de la columna</param>
    ''' <param name="tipo">tipo de dato</param>
    Public Function AgregarColumna(ByVal Nombre As String, ByVal tipo As String) As DataColumn
        Dim MiDatacolumn As DataColumn = New DataColumn()

        MiDatacolumn.DataType = System.Type.GetType("System." + tipo.ToString())
        MiDatacolumn.ColumnName = Nombre
        MiDatacolumn.ReadOnly = True
        MiDatacolumn.Caption = Nombre

        Return MiDatacolumn
    End Function

    ''' <summary>
    ''' Agrega una nueva fila al datatable
    ''' </summary>
    Public Sub AgregarRow(ByVal Valor() As String, ByVal NombreCol() As String)
        Dim Fila As DataRow = Me._DtInforme.NewRow()
        For i As Integer = 0 To NombreCol.Length() - 1
            Fila(NombreCol(i)) = Valor(i)
        Next
        Me._DtInforme.Rows.Add(Fila)
    End Sub

    ''' <summary>
    ''' Obtiene los totales de todos los rangos
    ''' </summary>
    ''' <param name="NombreColumna">nombre de la columna a sumar</param>
    ''' <param name="Tabla">Tabla a la que se hace la referencia</param>
    ''' <param name="RangoInicio">Rango inicio</param>
    ''' <param name="RangoFin">Rango Fin</param>
    ''' <param name="Condicion">Condicion de la consulta usada para la suma
    ''' de totales de las sumas para cada genero</param>
    Public Function ObtenerTotal(ByVal NombreColumna As String, ByVal Tabla As String, ByVal RangoInicio As Integer, ByVal RangoFin As Integer, ByVal Condicion As String) As String
        Dim Total As String = Nothing
        Dim BD As BaseDatos = New BaseDatos()

        Dim Sql As String = "SELECT SUM(" + NombreColumna + ") as Suma from " + Tabla


        If Not Condicion = "0" And RangoFin = 0 Then
            Sql = Sql + " Where Sexo = '" + Condicion + "';"

        ElseIf Condicion = "0" And RangoFin > 0 Then
            Sql = Sql + " where Edad > " + (RangoInicio - 1).ToString() + " and Edad < " + (RangoFin + 1).ToString() + " ;"

        ElseIf Condicion = "0" And RangoFin = 0 Then
            Sql = Sql + ";"
        End If

        Try
            BD.Conectar()
            BD.CrearComando(Sql)

            Dim Dt As DataTable = New DataTable()
            Dim Dr As DbDataReader = BD.EjecutarConsulta()
            Dt.Load(Dr)
            Total = Dt.Rows(0)(0)
        Catch ex As DataException
            MsgBox("Error al Obtener Los datos del servidor verifique su conexion", MsgBoxStyle.Critical, ex.Message)
        Catch ex As FormatException
            MsgBox("Uno de los formatos no coinciden")
            ' Catch ex As Exception
            '    MsgBox("Ocurrio un error al ejecutar la accion" + ex.Message, MsgBoxStyle.Information, "Error en tiempo de Ejecución")
        Catch ex As System.InvalidCastException
            Total = "0"
        Finally
            BD.Desconectar()
        End Try
        Return Total
    End Function
End Class
