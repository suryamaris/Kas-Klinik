Imports System.Data.SqlClient

Public Class Home
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiText()
        isiText1()
    End Sub
    Dim jumlahMasuk, jumlahKeluar, jumlahSaldo As Int64

    Sub isiText()
        Try
            bukakoneksi()
            Dim sql As String
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            sql = "SELECT SUM(jumlah) as jumlah FROM dbo.[kas] WHERE jenis ='Kas Masuk'"
            cmd = New SqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                masuk.Text = rd.Item("jumlah")
                jumlahMasuk = rd.Item("jumlah")
            End If

        Catch ex As Exception
        End Try
    End Sub

    Sub isiText1()
        Try
            bukakoneksi()
            Dim sql As String
            Dim cmd As SqlCommand
            Dim rd As SqlDataReader
            sql = "SELECT SUM(jumlah) as jumlah FROM dbo.[kas] WHERE jenis ='Kas Keluar'"
            cmd = New SqlCommand(sql, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                keluar.Text = rd.Item("jumlah")
                jumlahKeluar = rd.Item("jumlah")
            End If
            jumlahSaldo = jumlahMasuk - jumlahKeluar
            saldo.Text = jumlahSaldo

        Catch ex As Exception
        End Try
    End Sub

    Private Sub kasKeluar_Click(sender As Object, e As EventArgs) Handles kasKeluar.Click
        Me.Hide()
        kKeluar.Show()
    End Sub

    Private Sub rekapitulasi_Click(sender As Object, e As EventArgs) Handles rekapitulasi.Click
        Me.Hide()
        rekap.Show()
    End Sub


    Private Sub kasMasuk_Click(sender As Object, e As EventArgs) Handles kasMasuk.Click
        Me.Hide()
        kMasuk.Show()
    End Sub


End Class
