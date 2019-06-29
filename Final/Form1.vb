Imports Logica
Imports System
Imports System.Windows.Forms


Public Class Form1
    Private Sub btnCargarExcel_Click(sender As Object, e As EventArgs) Handles btnCargarExcel.Click
        Dim x As DataSet
        x = AccesoLogica.CargarExcel()
        dtgExcel.DataSource = x
        dtgExcel.DataMember = "[Hoja1$]"
    End Sub
End Class