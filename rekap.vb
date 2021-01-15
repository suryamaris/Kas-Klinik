Imports System.Data.SqlClient
Public Class rekap
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampil()
    End Sub

    Sub tampil()
        bukakoneksi()
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.[kas]", conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable

        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next

    End Sub

    Private Sub kasMasuk_Click(sender As Object, e As EventArgs) Handles kasMasuk.Click
        Me.Hide()
        kMasuk.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        kKeluar.Show()
    End Sub

    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class