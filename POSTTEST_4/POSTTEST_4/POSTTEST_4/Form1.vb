Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pbProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Nama harus diisi)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 0
            txtNama.Focus()
            Return
        End If

        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (ID Anggota harus diisi)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 0
            txtID.Focus()
            Return
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong (Jenis Kelamin harus dipilih)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 0
            Return
        End If

        If cmbDivisi.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Divisi/Komunitas harus dipilih)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 0
            cmbDivisi.Focus()
            Return
        End If

        If Not mtxtTelepon.MaskCompleted Then
            MessageBox.Show("Inputan tidak boleh kosong (Nomor Telepon belum lengkap sesuai format)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 1
            mtxtTelepon.Focus()
            Return
        End If

        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Email harus diisi)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 1
            txtEmail.Focus()
            Return
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Alamat harus diisi)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 1
            txtAlamat.Focus()
            Return
        End If

        Dim peranTerpilih As String = ""
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                peranTerpilih = DirectCast(ctrl, RadioButton).Text
            End If
        Next

        If peranTerpilih = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Peran Anggota harus dipilih)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 2
            Return
        End If

        Dim hobbyTerpilih As String = ""
        For Each ctrl In GroupBox2.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobbyTerpilih &= DirectCast(ctrl, CheckBox).Text & ", "
            End If
        Next

        If hobbyTerpilih = "" Then
            MessageBox.Show("Inputan tidak boleh kosong (Pilih minimal 1 hobby/aktivitas)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TabControl1.SelectedIndex = 2
            Return
        End If

        hobbyTerpilih = hobbyTerpilih.TrimEnd(", ".ToCharArray())

        Dim jenisKelamin As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")

        Dim tanya = MessageBox.Show("Apakah Anda yakin ingin simpan dan cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then
            Dim f2 As New Form2()
            f2.TampilkanData(
                txtNama.Text,
                txtID.Text,
                cmbDivisi.Text,
                mtxtTelepon.Text,
                hobbyTerpilih,
                pbProfil.Image,
                jenisKelamin,
                dtpLahir.Value.ToString("dd/MM/yyyy"),
                txtEmail.Text,
                txtAlamat.Text,
                peranTerpilih
            )
            f2.Show()
        End If
    End Sub
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi = MessageBox.Show("Apakah anda yakin ingin keluar dari aplikasi?", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If txtNama.Text.Trim() = "" AndAlso txtID.Text.Trim() = "" Then
            MessageBox.Show("Tidak ada data untuk disimpan. Isi form terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        SaveFileDialog1.DefaultExt = "txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim jenisKelamin As String = If(rbLaki.Checked, "Laki-laki", If(rbPerempuan.Checked, "Perempuan", "-"))

            Dim peranTerpilih As String = "-"
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is RadioButton AndAlso DirectCast(ctrl, RadioButton).Checked Then
                    peranTerpilih = DirectCast(ctrl, RadioButton).Text
                End If
            Next

            Dim hobbyTerpilih As String = ""
            For Each ctrl In GroupBox2.Controls
                If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                    hobbyTerpilih &= DirectCast(ctrl, CheckBox).Text & ", "
                End If
            Next
            If hobbyTerpilih.Length > 2 Then hobbyTerpilih = hobbyTerpilih.Substring(0, hobbyTerpilih.Length - 2)

            Dim isi As String = "=== DATA KARTU ANGGOTA ===" & vbCrLf &
                                "Nama          : " & txtNama.Text & vbCrLf &
                                "ID Anggota    : " & txtID.Text & vbCrLf &
                                "Tanggal Lahir : " & dtpLahir.Value.ToString("dd/MM/yyyy") & vbCrLf &
                                "Jenis Kelamin : " & jenisKelamin & vbCrLf &
                                "Divisi        : " & cmbDivisi.Text & vbCrLf &
                                "Telepon       : " & mtxtTelepon.Text & vbCrLf &
                                "Email         : " & txtEmail.Text & vbCrLf &
                                "Alamat        : " & txtAlamat.Text & vbCrLf &
                                "Peran         : " & peranTerpilih & vbCrLf &
                                "Hobby/Minat   : " & hobbyTerpilih & vbCrLf &
                                "=========================="

            IO.File.WriteAllText(SaveFileDialog1.FileName, isi)
            MessageBox.Show("Data berhasil disimpan ke:" & vbCrLf & SaveFileDialog1.FileName, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = IO.File.ReadAllLines(ofd.FileName)
                For Each line As String In lines
                    If line.StartsWith("Nama          : ") Then txtNama.Text = line.Replace("Nama          : ", "")
                    If line.StartsWith("ID Anggota    : ") Then txtID.Text = line.Replace("ID Anggota    : ", "")
                    If line.StartsWith("Divisi        : ") Then cmbDivisi.Text = line.Replace("Divisi        : ", "")
                    If line.StartsWith("Telepon       : ") Then mtxtTelepon.Text = line.Replace("Telepon       : ", "")
                    If line.StartsWith("Email         : ") Then txtEmail.Text = line.Replace("Email         : ", "")
                    If line.StartsWith("Alamat        : ") Then txtAlamat.Text = line.Replace("Alamat        : ", "")
                    If line.StartsWith("Jenis Kelamin : ") Then
                        Dim jk As String = line.Replace("Jenis Kelamin : ", "")
                        rbLaki.Checked = (jk = "Laki-laki")
                        rbPerempuan.Checked = (jk = "Perempuan")
                    End If
                    If line.StartsWith("Tanggal Lahir : ") Then
                        Dim tglStr As String = line.Replace("Tanggal Lahir : ", "")
                        Dim tgl As DateTime
                        If DateTime.TryParseExact(tglStr, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, tgl) Then
                            dtpLahir.Value = tgl
                        End If
                    End If
                Next
                MessageBox.Show("Data berhasil dibuka!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membuka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class
