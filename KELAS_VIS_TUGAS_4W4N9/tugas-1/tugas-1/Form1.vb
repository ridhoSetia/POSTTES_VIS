Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka As String = "121"
        Dim tahun As String = Year(Now).ToString()
        Dim huruf As String = "ALG"
        Dim tanggal As String = Format(Now, "dd-MM-yyyy")

        TextBox1.Text = angka & "/" & tahun & "/" & huruf & "/" & tanggal
    End Sub
End Class