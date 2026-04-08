Public Class Form2
    Public Sub TampilkanData(nama As String, id As String, divisi As String, kontak As String,
                             hobi As String, foto As Image,
                             jenisKelamin As String, tglLahir As String,
                             email As String, alamat As String, peran As String)
        lblNamaKartu.Text = nama
        lblIDKartu.Text = "ID: " & id
        lblDivisiKartu.Text = "Divisi: " & divisi & "  |  " & jenisKelamin
        lblKontakKartu.Text = "Telp: " & kontak & "   Email: " & email
        lblAlamatKartu.Text = "Alamat: " & alamat
        lblTglLahirKartu.Text = "Tgl Lahir: " & tglLahir & "   Peran: " & peran
        lblHobiKartu.Text = "Minat/Aktivitas: " & hobi
        If foto IsNot Nothing Then
            pbFotoKartu.Image = foto
        End If
    End Sub
End Class
