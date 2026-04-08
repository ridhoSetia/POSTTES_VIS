Public Class Form2
    Private namaMhs As String
    Private nimMhs As String

    ' Constructor
    Public Sub New(nama As String, nim As String)
        InitializeComponent()
        namaMhs = nama
        nimMhs = nim
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nama.Text = namaMhs
        nim.Text = "NIM: " & nimMhs
    End Sub
End Class