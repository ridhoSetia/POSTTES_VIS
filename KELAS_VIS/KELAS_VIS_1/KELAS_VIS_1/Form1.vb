Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub btnCekEmail_Click(sender As Object, e As EventArgs) Handles btnCekEmail.Click
        Dim pola As String = "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"
        Dim input As String = txtEmail.Text

        If Regex.IsMatch(input, pola) Then
            lblHasilEmail.Text = "Email Valid"
            lblHasilEmail.ForeColor = Color.Green
        Else
            lblHasilEmail.Text = "Email Tidak Valid"
            lblHasilEmail.ForeColor = Color.Red
        End If
    End Sub

End Class
