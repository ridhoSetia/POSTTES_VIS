Imports System.Data

Public Class Form1
    ' --- Inisialisasi & Event Utama ---

    Private Sub FormJenisBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        KosongkanForm()
    End Sub

    ' --- Prosedur & Fungsi Pendukung ---

    ''' <summary>
    ''' Membersihkan semua inputan pada form
    ''' </summary>
    Private Sub KosongkanForm()
        txtIdJenis.Clear()
        txtJenis.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtIdJenis.Focus()
    End Sub

    ''' <summary>
    ''' Memperbarui tampilan grid dengan data terbaru
    ''' </summary>
    Private Sub TampilData()
        Try
            dgvJenis.DataSource = GetAllJenis()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- Event Handler Tombol ---

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        ' Validasi Input
        If Not ValidasiJenisBuku(ErrorProvider1, txtIdJenis, txtJenis) Then Exit Sub

        Dim kode As String = txtIdJenis.Text.Trim()
        Dim namaJenis As String = txtJenis.Text.Trim()

        ' Cek Duplikasi
        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Jenis sudah terdaftar", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdJenis.Focus()
            Exit Sub
        End If

        ' Eksekusi Simpan
        If SimpanJenis(kode, namaJenis) Then
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        ' Validasi Input
        If Not ValidasiJenisBuku(ErrorProvider1, txtIdJenis, txtJenis) Then Exit Sub

        Dim kode As String = txtIdJenis.Text.Trim()
        Dim namaJenis As String = txtJenis.Text.Trim()

        ' Eksekusi Ubah
        If UbahJenis(kode, namaJenis) Then
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        Else
            MessageBox.Show("Data tidak ditemukan atau gagal diubah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim kode As String = txtIdJenis.Text.Trim()

        If String.IsNullOrEmpty(kode) Then
            MessageBox.Show("Pilih data yang akan dihapus melalui tabel atau masukkan Kode Jenis", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIdJenis.Focus()
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusJenis(kode) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    ' --- Interaksi Grid & Input ---

    Private Sub dgvJenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJenis.CellClick
        ' Memastikan klik bukan pada header
        If e.RowIndex >= 0 Then
            Try
                txtIdJenis.Text = dgvJenis.Rows(e.RowIndex).Cells("idJenis").Value.ToString()
                txtJenis.Text = dgvJenis.Rows(e.RowIndex).Cells("Jenis").Value.ToString()
            Catch ex As Exception
                ' Handle jika nama kolom di dgv berbeda
            End Try
        End If
    End Sub

    Private Sub txtidJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdJenis.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetJenisByKode(txtIdJenis.Text.Trim())

            If dt.Rows.Count > 0 Then
                txtJenis.Text = dt.Rows(0)("jenis").ToString()
            Else
                txtJenis.Clear()
            End If
            txtJenis.Focus()
        End If
    End Sub

    Private Sub txtJenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJenis.KeyPress
        HanyaHuruf(e) ' Memanggil helper global

        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim keyword As String = txtSearch.Text.Trim()

        If keyword = "" Then
            TampilData()
        Else
            dgvJenis.DataSource = SearchJenis(keyword)
        End If
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub
End Class