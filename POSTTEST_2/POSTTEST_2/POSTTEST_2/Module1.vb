Imports System.Text.RegularExpressions

Module Module1
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0
    Public Sub tambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            MessageBox.Show("Berhasil Menambahkan Buku " + judul + "", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            daftarBuku(jumlahBuku, 0) = judul + " (" + genre + ")"
            jumlahBuku += 1
        End If
    End Sub

    Public Sub hapusBuku(ByVal judul As String)
        For i As Integer = 0 To jumlahBuku - 1
            If Regex.Replace(daftarBuku(i, 0), "\(.*?\)", "").Contains(judul) Then
                MessageBox.Show("Buku " + judul + " Berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                Next
                jumlahBuku -= 1
                Exit For
            Else
                MessageBox.Show("Buku tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
    End Sub
End Module