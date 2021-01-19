Imports System.Data.SqlClient
Imports CrystalDecisions

Public Class rekap


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

    Private Sub cetak_Click(sender As Object, e As EventArgs) Handles cetak.Click

        Dim report As New CrystalReport1
        Me.CrystalReportViewer1.ReportSource = report
        Me.Show()


    End Sub

End Class