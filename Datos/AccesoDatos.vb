Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AccesoDatos
    Public Shared Function CargarExcel() As DataSet
        Dim excelconn As OleDbConnection
        Dim excelDTA As OleDbDataAdapter
        Dim excelDTS As DataSet
        Dim excelFileName As String
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx)|*.xlsx|Xls Files (*.xls)|*.xls"
        If OpenFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName
            excelFileName = fi.FullName
            excelconn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFileName + ";Extended Properties=Excel 12.0")
            excelDTA = New OleDbDataAdapter("select * from [Hoja1$]", excelconn)
            excelDTS = New DataSet
            excelDTA.Fill(excelDTS, "[Hoja1$]")
            excelconn.Close()
        End If
        Return excelDTS
    End Function


End Class
