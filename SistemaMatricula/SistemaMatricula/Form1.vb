Imports System.Data.OleDb
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conexion As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;data source=F:\Users\LAB4\Downloads\SISTEMA MATRICULA\BASE DE DATOS\MATRUCULA(2002-2003).mdb")
        Try
            conexion.Open()
            MsgBox("conectado")

            Dim query = "select * from ESTUDIANTE"
            Dim adap As New OleDbDataAdapter(query, conexion)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conecto por:" & ex.Message)
        End Try
    End Sub
End Class
