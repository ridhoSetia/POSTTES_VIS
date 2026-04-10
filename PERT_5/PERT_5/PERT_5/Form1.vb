Public Class Form1

    Private Sub Kosong()
        txtIdJenis.Clear()
        txtJenisBuku.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtIdJenis.Focus()
    End Sub

    Private Sub TampilData()
        dgvJenisBuku.DataSource = GetAllJenis()
    End Sub

    Private Sub FormJenisBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiJenisBuku(ErrorProvider1, txtIdJenis, txtJenisBuku) Then Exit Sub

        Dim kode As String = txtIdJenis.Text.Trim()
        Dim namaJenis As String = txtJenisBuku.Text.Trim()

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Jenis sudah terdaftar",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdJenis.Focus()
            Exit Sub
        End If

        If SimpanJenis(kode, namaJenis) Then
            MessageBox.Show("Data berhasil disimpan",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiJenisBuku(ErrorProvider1, txtIdJenis, txtJenisBuku) Then Exit Sub

        Dim kode As String = txtIdJenis.Text.Trim()
        Dim namaJenis As String = txtJenisBuku.Text.Trim()

        If UbahJenis(kode, namaJenis) Then
            MessageBox.Show("Data berhasil diubah",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan",
                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtIdJenis.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdJenis.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dihapus?",
                                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusJenis(txtIdJenis.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus",
                                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenisBuku.CellClick
        If e.RowIndex = 0 Then
            txtIdJenis.Text = dgvJenisBuku.Rows(e.RowIndex).Cells("idJenis").Value.ToString()
            txtJenisBuku.Text = dgvJenisBuku.Rows(e.RowIndex).Cells("Jenis").Value.ToString()
        End If
    End Sub

    Private Sub txtIdJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdJenis.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True

            Dim dt As DataTable = GetJenisByKode(txtIdJenis.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtIdJenis.Text = dt.Rows(0)("idJenis").ToString()
                txtJenisBuku.Text = dt.Rows(0)("jenis").ToString()
            Else
                txtJenisBuku.Clear()
            End If

            txtJenisBuku.Focus()
        End If
    End Sub

    Private Sub txtJenisBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJenisBuku.KeyPress
        HanyaHuruf(e)

        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvJenisBuku.DataSource = SearchJenis(txtSearch.Text.Trim())
        End If
    End Sub

End Class