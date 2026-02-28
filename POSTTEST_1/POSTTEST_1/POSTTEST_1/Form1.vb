Public Class Form1
    Dim ips As Double
    Dim ipk As Double
    Dim ipTotal As Double
    Dim semester As Integer

    Private Sub ValidateInput()
        If Double.TryParse(inputIPS.Text.Replace(".", ","), ips) Then

        Else
            MessageBox.Show("Input harus berupa angka")
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ValidateInput()
        If ips < 0 Or ips > 4 Then
            MessageBox.Show("Input harus antara 0 dan 4")
            Return
        End If
        semester += 1
        MessageBox.Show("IP Semester " & semester & " : " & ips)
        ipTotal += ips
        ipk = ipTotal / semester
        inputIPK.Text = ipk
        inputIPS.Text = ""

        If ipk >= 2 And ipk <= 2.75 Then
            predikat.Text = "Cukup"
        ElseIf ipk >= 2.76 And ipk < 3 Then
            predikat.Text = "Memuaskan"
        ElseIf ipk >= 3 And ipk <= 4 Then
            predikat.Text = "Sangat Memuaskan"
        Else
            predikat.Text = "Tidak berpredikat"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        inputIPS.Text = ""
        predikat.Text = "Predikat"
        ipk = 0
        inputIPK.Text = ""
    End Sub
End Class
