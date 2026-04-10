Public Class Form1
    Private selectedID As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        Dim data As DataTable = GetAllSparepart()

        If data IsNot Nothing Then
            dgvSparepart.DataSource = data

            If dgvSparepart.Columns.Contains("id") Then
                dgvSparepart.Columns("id").Visible = False
            End If
        End If
    End Sub

    Private Sub Bersihkan()
        txtNama.Clear()
        txtStok.Clear()
        txtHarga.Clear()
        txtCari.Clear()
        selectedID = ""
        ErrorProvider1.Clear()
        txtNama.Focus()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi apakah textbox kosong
        If ValidasiInputSparepart(ErrorProvider1, txtNama, txtStok, txtHarga) Then
            ' Simpan ke Database (ID tidak dikirim karena Auto Increment)
            If SimpanSparepart(txtNama.Text, CInt(txtStok.Text), CDec(txtHarga.Text)) Then
                MessageBox.Show("Data sparepart baru berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                Bersihkan()
            End If
        End If
    End Sub

    Private Sub dgvSparepart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSparepart.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSparepart.Rows(e.RowIndex)

            ' Ambil ID untuk proses Update/Delete nanti
            selectedID = row.Cells("id").Value.ToString()

            ' Tampilkan data ke TextBox
            txtNama.Text = row.Cells("nama").Value.ToString()
            txtStok.Text = row.Cells("stok").Value.ToString()
            txtHarga.Text = row.Cells("harga").Value.ToString()

            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrEmpty(selectedID) Then
            MessageBox.Show("Silakan pilih data pada tabel yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If ValidasiInputSparepart(ErrorProvider1, txtNama, txtStok, txtHarga) Then
            If UbahSparepart(selectedID, txtNama.Text, CInt(txtStok.Text), CDec(txtHarga.Text)) Then
                MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                Bersihkan()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrEmpty(selectedID) Then
            MessageBox.Show("Silakan pilih data pada tabel yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim dialog As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            If HapusSparepart(selectedID) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                Bersihkan()
            End If
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        dgvSparepart.DataSource = SearchSparepart(txtCari.Text)
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersihkan()
    End Sub

End Class
