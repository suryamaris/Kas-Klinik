Imports System.Data.SqlClient
Public Class kKeluar
    Dim sql As String
    Dim cmd As SqlCommand
    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.kas' table. You can move, or remove it, as needed.

        tampil()
    End Sub

    Sub tampil()
        bukakoneksi()
        Dim da As New SqlDataAdapter("SELECT * FROM dbo.[kas] WHERE jenis ='Kas Keluar'", conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable

        For Each dt In ds.Tables
            DataGridView1.DataSource = dt
        Next

    End Sub



    Private Sub kembali_Click(sender As Object, e As EventArgs) Handles kembali.Click
        Home.Show()
        Me.Hide()

    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        bukakoneksi()
        sql = "INSERT INTO dbo.[kas](tanggal,jenis,keterangan,jumlah) VALUES('" + tanggal.Text + "','Kas Keluar','" + keterangan.Text + "','" + jumlah.Text + "') "
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Input", MsgBoxStyle.Information, "Information")
        keterangan.Text = ""
        jumlah.Text = ""
        tampil()
    End Sub


    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Call bukakoneksi()
        Dim i As Integer
        Dim RD As SqlDataReader
        i = DataGridView1.CurrentRow.Index
        cmd = New SqlCommand("Select * from dbo.[kas] where id='" & DataGridView1.Item(0, i).Value & "'", conn)
        RD = cmd.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            keterangan.Focus()
        Else
            id.Text = RD.Item("Id")
            tanggal.Text = RD.Item("tanggal")
            jumlah.Text = RD.Item("jumlah")
            keterangan.Text = RD.Item("keterangan")
            id.Focus()
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        bukakoneksi()
        sql = "Update dbo.[kas] set tanggal= '" & tanggal.Text & "', jumlah = '" & jumlah.Text & "', keterangan='" & keterangan.Text & "' where Id= '" & id.Text & "'"
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di Ubah", MsgBoxStyle.Information, "Information")
        keterangan.Text = ""
        jumlah.Text = ""
        tampil()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Dim pesanuser As String
        pesanuser = MsgBox("Yakin Hapus Data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Programer Junior")
        If pesanuser = vbYes Then
            bukakoneksi()
            sql = "delete from dbo.[kas] where Id='" & id.Text & "'"
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di Hapus", MsgBoxStyle.Information, "Information")
            keterangan.Text = ""
            jumlah.Text = ""
            tampil()
        End If
    End Sub
End Class