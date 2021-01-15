Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Module koneksi

    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection
    Public str As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Job\Kas Klinik\Kas-Klinik\Database1.mdf';Integrated Security=True"

    Public Sub bukakoneksi()
        Try
            conn = New SqlConnection(str)
            conn.Open()
        Catch ex As Exception
            MsgBox("Maaf Koneksi gagal ! " & ex.Message)
        End Try
    End Sub
End Module
