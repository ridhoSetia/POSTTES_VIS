Public Class Form2

    Private selectedID As Integer = -1

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Data Servis - Bengkel"
        MuatComboSparepart()
        RefreshGrid()
        Bersihkan()
    End Sub

    Private Sub MuatComboSparepart()
        Dim dt As DataTable = GetSparepartUntukCombo()
        cbSparepart.DataSource = dt
        cbSparepart.DisplayMember = "nama"
        cbSparepart.ValueMember = "id"
        cbSparepart.SelectedIndex = -1
    End Sub

    Private Sub RefreshGrid()
        dgvServis.DataSource = GetAllServis()
        If dgvServis.Columns.Contains("id_servis") Then
            dgvServis.Columns("id_servis").Visible = False
        End If
        If dgvServis.Columns.Contains("id_sparepart") Then
            dgvServis.Columns("id_sparepart").Visible = False
        End If
    End Sub

    Private Sub Bersihkan()
        txtNamaPelanggan.Clear()
        txtNoPolisi.Clear()
        txtKerusakan.Clear()
        MuatComboSparepart()
        txtJumlah.Clear()
        txtBiayaJasa.Clear()
        lblTotalBiaya.Text = "Rp 0"
        dtpTanggal.Value = Today
        txtCari.Clear()
        selectedID = -1
        ErrorProvider1.Clear()
        txtNamaPelanggan.Focus()
    End Sub

    Private Sub HitungTotal()
        Try
            If cbSparepart.SelectedIndex >= 0 AndAlso txtJumlah.Text <> "" AndAlso txtBiayaJasa.Text <> "" Then
                Dim idSp As Integer = CInt(cbSparepart.SelectedValue)
                Dim harga As Decimal = GetHargaSparepart(idSp)
                Dim jumlah As Integer = If(Integer.TryParse(txtJumlah.Text, 0), CInt(txtJumlah.Text), 0)
                Dim jasa As Decimal = If(Decimal.TryParse(txtBiayaJasa.Text, 0), CDec(txtBiayaJasa.Text), 0)
                Dim total As Decimal = (harga * jumlah) + jasa
                lblTotalBiaya.Text = "Rp " & total.ToString("N0")
            End If
        Catch
            lblTotalBiaya.Text = "Rp 0"
        End Try
    End Sub

    Private Sub cbSparepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSparepart.SelectedIndexChanged
        HitungTotal()
    End Sub

    Private Sub txtJumlah_TextChanged(sender As Object, e As EventArgs) Handles txtJumlah.TextChanged
        HitungTotal()
    End Sub

    Private Sub txtBiayaJasa_TextChanged(sender As Object, e As EventArgs) Handles txtBiayaJasa.TextChanged
        HitungTotal()
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtBiayaJasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBiayaJasa.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiInputServis(ErrorProvider1, txtNamaPelanggan, txtNoPolisi,
                                    txtKerusakan, cbSparepart, txtJumlah, txtBiayaJasa) Then
            Exit Sub
        End If

        Dim idSp As Integer = CInt(cbSparepart.SelectedValue)
        Dim jumlah As Integer = CInt(txtJumlah.Text.Trim())
        Dim jasa As Decimal = CDec(txtBiayaJasa.Text.Trim())

        If SimpanServis(txtNamaPelanggan.Text.Trim(), txtNoPolisi.Text.Trim(),
                        txtKerusakan.Text.Trim(), idSp, jumlah, jasa, dtpTanggal.Value) Then
            MessageBox.Show("Data servis berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            Bersihkan()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedID = -1 Then
            MessageBox.Show("Silakan pilih data servis yang ingin diubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ErrorProvider1.Clear()
        If Not ValidasiInputServis(ErrorProvider1, txtNamaPelanggan, txtNoPolisi,
                                    txtKerusakan, cbSparepart, txtJumlah, txtBiayaJasa) Then
            Exit Sub
        End If

        Dim idSp As Integer = CInt(cbSparepart.SelectedValue)
        Dim jumlah As Integer = CInt(txtJumlah.Text.Trim())
        Dim jasa As Decimal = CDec(txtBiayaJasa.Text.Trim())

        If UbahServis(selectedID, txtNamaPelanggan.Text.Trim(), txtNoPolisi.Text.Trim(),
                      txtKerusakan.Text.Trim(), idSp, jumlah, jasa, dtpTanggal.Value) Then
            MessageBox.Show("Data servis berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            Bersihkan()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedID = -1 Then
            MessageBox.Show("Silakan pilih data servis yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus data servis ini?" & vbNewLine &
            "Stok sparepart akan dikembalikan secara otomatis.",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusServis(selectedID) Then
                MessageBox.Show("Data servis berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshGrid()
                Bersihkan()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Bersihkan()
        RefreshGrid()
    End Sub

    Private Sub dgvServis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServis.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvServis.Rows(e.RowIndex)

            selectedID = CInt(row.Cells("id_servis").Value)
            txtNamaPelanggan.Text = row.Cells("nama_pelanggan").Value.ToString()
            txtNoPolisi.Text = row.Cells("no_polisi").Value.ToString()
            txtKerusakan.Text = row.Cells("jenis_kerusakan").Value.ToString()

            Dim namaSp As String = row.Cells("nama_sparepart").Value.ToString()
            For Each item As DataRowView In cbSparepart.Items
                If item("nama").ToString() = namaSp Then
                    cbSparepart.SelectedValue = item("id")
                    Exit For
                End If
            Next

            txtJumlah.Text = row.Cells("jumlah_pakai").Value.ToString()
            txtBiayaJasa.Text = row.Cells("biaya_jasa").Value.ToString()
            dtpTanggal.Value = CDate(row.Cells("tanggal").Value)

            HitungTotal()
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            dgvServis.DataSource = GetAllServis()
        Else
            dgvServis.DataSource = SearchServis(txtCari.Text.Trim())
        End If

        If dgvServis.Columns.Contains("id_servis") Then
            dgvServis.Columns("id_servis").Visible = False
        End If
    End Sub

End Class