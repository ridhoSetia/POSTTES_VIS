Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = TextBox1.Text

        Dim parts() As String = input.Split("/")

        Dim angkaBaru As String = (CInt(parts(0)) + 1).ToString()
        Dim tahunBaru As String = Year(Now).ToString()
        Dim huruf As String = Mid(parts(2), 1, 3)
        Dim tanggalBaru As String = "01-01-" & tahunBaru

        TextBox2.Text = angkaBaru & "/" & tahunBaru & "/" & huruf & "/" & tanggalBaru
    End Sub
End Class