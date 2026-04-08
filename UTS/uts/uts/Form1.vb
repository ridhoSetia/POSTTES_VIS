Public Class Form1
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim nama As String = inputNama.Text
        Dim nim As String = inputNIM.Text

        ' Validasi (jangan males, ini basic tapi penting)
        If nama = "" Or nim = "" Then
            MessageBox.Show("Nama dan NIM harus diisi!")
            Exit Sub
        End If

        ' Kirim data ke Form2
        Dim f2 As New Form2(nama, nim)
        f2.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim flogin As New FormLogin()
        flogin.Show()
    End Sub
End Class
