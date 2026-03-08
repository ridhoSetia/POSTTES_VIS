Public Class Form1
    Public judul As String
    Public genre As String
    Public index As Integer

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtJudul.Text
        genre = txtGenre.Text
        If judul = "" And genre = "" Then
            MessageBox.Show("Nama dan Nim Harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()
        End If
    End Sub
    Private Sub btnHps_Click(sender As Object, e As EventArgs) Handles btnHps.Click
        judul = txtJudulHps.Text
        If judul = "" Then
            MessageBox.Show("Nama Harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            hapusBuku(judul)
            tampilkanData()
            txtJudulHps.Clear()
        End If
    End Sub

    Private Sub tampilkanData()
        dgvListBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvListBuku.Rows.Add(daftarBuku(i, 0))
        Next
    End Sub
End Class