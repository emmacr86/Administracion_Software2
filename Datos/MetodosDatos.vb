Imports System.Data
Imports System.Data.SqlClient

Public Class MetodosDatos
    Public Shared Function CrearComando() As SqlCommand
        Dim dbString = Configuracion.dbString
        Dim conexion As New SqlConnection
        conexion.ConnectionString = dbString
        Dim comando As New SqlCommand
        comando = conexion.CreateCommand
        comando.CommandType = CommandType.Text
        Return comando
    End Function
    Public Shared Function EjecutarComandoSelect(comando As SqlCommand, _str As String) As DataTable
        Dim tabla As New DataTable
        Try
            comando.Connection.Open()
            Dim adaptador As New SqlDataAdapter()
            adaptador.SelectCommand = comando
            adaptador.Fill(tabla)
            If _str <> "" Then
                MsgBox(_str + " insertado/actualizado correctamente")
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error durante el insertado, revise los logs")
        Finally
            comando.Connection.Close()
        End Try
        Return tabla
    End Function
End Class
