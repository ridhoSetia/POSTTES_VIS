Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teks As String = "Total belanja: 750000 rupiah, diskon: 10000"
        Dim pattern As String = "\d+"
        Dim matches As MatchCollection = Regex.Matches(teks, pattern)

        ListBox1.Items.Clear()
        For Each m As Match In matches
            ListBox1.Items.Add("Angka ditemukan        : " & m.Value)
        Next
    End Sub
End Class