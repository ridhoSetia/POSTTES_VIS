Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = inputUser.Text
        Dim password As String = inputPass.Text

        ' Validasi kosong
        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password wajib diisi!")
            Exit Sub
        End If

        ' Validasi login (hardcode)
        If username = "ridho" And password = "123" Then
            MessageBox.Show("Login berhasil!")

            ' Buka Form1
            Dim f1 As New Form1
            f1.Show()

            ' Tutup form login
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!")
        End If
    End Sub
End Class