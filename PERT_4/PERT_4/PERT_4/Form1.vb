Public Class Form1

    ' VALIDASI INPUT KARAKTER
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    ' VALIDASI LANGSUNG
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
        ValidasiTextBox(ErrorProvider1, txtNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub mtbNoHP_TextChanged(sender As Object, e As EventArgs) Handles mtxtNoHp.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtxtNoHp, "Nomor HP belum lengkap")
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat tidak boleh kosong")
    End Sub

    ' RINGKASAN
    Private Sub PerbaruiRingkasan()
        lblRingkasan.Text = BuatRingkasan(
            txtNama.Text,
            mtxtNoHp.Text,
            txtAlamat.Text
        )
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is tcRingkasan Then
            PerbaruiRingkasan()
        End If
    End Sub

    ' TOMBOL SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, mtxtNoHp, txtAlamat) Then
            MessageBox.Show(
                "Masih ada input yang belum valid.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Dim isi As String = BuatIsiFile(
                txtNama.Text,
                mtxtNoHp.Text,
                txtAlamat.Text
            )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_tamu.txt") Then
                PerbaruiRingkasan()
                TabControl1.SelectedTab = tcRingkasan

                MessageBox.Show(
                    "Data berhasil disimpan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show(
                "Data tidak jadi disimpan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show(
                "Proses dibatalkan.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    ' TOMBOL RESET

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnRst.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data ingin direset?",
            "Konfirmasi Reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            KosongkanForm()
        End If
    End Sub

    Private Sub KosongkanForm()
        txtNama.Clear()
        txtAlamat.Clear()
        lblRingkasan.Text = ""
        mtxtNoHp.Clear()

        ErrorProvider1.Clear()

        TabControl1.SelectedTab = tcIdentitas
        txtNama.Focus()
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles MnuOpenFile.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then Exit Sub

        KosongkanForm()
        IsiDataKeForm(data)
        PerbaruiRingkasan()
        TabControl1.SelectedTab = tcRingkasan

        MessageBox.Show(
            "File berhasil dibuka.",
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    ' LOAD DATA KE FORM
    Private Sub IsiDataKeForm(data As Dictionary(Of String, String))
        txtNama.Text = AmbilNilai(data, "Nama")
        mtxtNoHp.Text = AmbilNilai(data, "NoHP")
        txtAlamat.Text = AmbilNilai(data, "Alamat")
    End Sub

End Class