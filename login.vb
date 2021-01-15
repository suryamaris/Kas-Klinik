
Imports System.Data.SqlClient

Public Class login

    Private Sub pass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pass.KeyPress

        If (e.KeyChar = Chr(13)) Then

            masuk.PerformClick()

        End If

    End Sub
    Private Sub masuk_Click(sender As Object, e As EventArgs) Handles masuk.Click

        Try
            If user.Text = "" Or pass.Text = "" Then
                MessageBox.Show("Isi username dan password terlebih dahulu!!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                bukakoneksi()
                Dim sql, username, password As String
                Dim cmd As SqlCommand
                Dim rd As SqlDataReader

                username = user.Text
                password = pass.Text

                sql = "SELECT * FROM dbo.[Table] WHERE username = '" + username + "' AND pass ='" + password + "' "
                cmd = New SqlCommand(sql, conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    Me.Hide()
                    Home.Show()

                Else
                    MsgBox("Maaf Username atau Passwor Salah", vbInformation)

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class