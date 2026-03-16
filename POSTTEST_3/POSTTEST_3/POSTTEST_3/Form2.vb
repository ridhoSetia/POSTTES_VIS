Imports System.Reflection

Public Class Form2
    ' Kita buat variabel global agar bisa diakses dari Form1
    Public Property dataNama As String
    Public Property dataUmur As String
    Public Property dataTglLahir As String
    Public Property dataJenKel As String
    Public Property dataNoTelp As String
    Public Property dataHobi As String
    Public Property dataAlamat As String
    Public Property dataFoto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menampilkan data ke Label/PictureBox di Form2
        nama.Text = dataNama
        umur.Text = dataUmur & " Tahun"
        tglLahir.Text = dataTglLahir
        jenKel.Text = dataJenKel
        noTelp.Text = dataNoTelp
        hobi.Text = dataHobi
        alamat.Text = dataAlamat
        profil.Image = dataFoto
        profil.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class