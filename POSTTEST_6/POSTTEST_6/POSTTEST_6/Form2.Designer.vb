<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblNamaPelanggan = New Label()
        lblNoPolisi = New Label()
        lblKerusakan = New Label()
        lblSparepart = New Label()
        lblJumlah = New Label()
        lblBiayaJasa = New Label()
        lblTanggal = New Label()
        lblTotal = New Label()
        lblTotalBiaya = New Label()
        lblCari = New Label()
        txtNamaPelanggan = New TextBox()
        txtNoPolisi = New TextBox()
        txtKerusakan = New TextBox()
        txtJumlah = New TextBox()
        txtBiayaJasa = New TextBox()
        txtCari = New TextBox()
        cbSparepart = New ComboBox()
        dtpTanggal = New DateTimePicker()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvServis = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvServis, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblNamaPelanggan.AutoSize = True
        lblNamaPelanggan.Location = New Point(15, 20)
        lblNamaPelanggan.Name = "lblNamaPelanggan"
        lblNamaPelanggan.Size = New Size(98, 15)
        lblNamaPelanggan.TabIndex = 0
        lblNamaPelanggan.Text = "Nama Pelanggan"

        lblNoPolisi.AutoSize = True
        lblNoPolisi.Location = New Point(15, 55)
        lblNoPolisi.Name = "lblNoPolisi"
        lblNoPolisi.Size = New Size(57, 15)
        lblNoPolisi.TabIndex = 1
        lblNoPolisi.Text = "No. Polisi"

        lblKerusakan.AutoSize = True
        lblKerusakan.Location = New Point(15, 90)
        lblKerusakan.Name = "lblKerusakan"
        lblKerusakan.Size = New Size(89, 15)
        lblKerusakan.TabIndex = 2
        lblKerusakan.Text = "Jenis Kerusakan"

        lblSparepart.AutoSize = True
        lblSparepart.Location = New Point(15, 125)
        lblSparepart.Name = "lblSparepart"
        lblSparepart.Size = New Size(99, 15)
        lblSparepart.TabIndex = 3
        lblSparepart.Text = "Sparepart Dipakai"

        lblJumlah.AutoSize = True
        lblJumlah.Location = New Point(15, 160)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(76, 15)
        lblJumlah.TabIndex = 4
        lblJumlah.Text = "Jumlah Pakai"

        lblBiayaJasa.AutoSize = True
        lblBiayaJasa.Location = New Point(15, 195)
        lblBiayaJasa.Name = "lblBiayaJasa"
        lblBiayaJasa.Size = New Size(84, 15)
        lblBiayaJasa.TabIndex = 5
        lblBiayaJasa.Text = "Biaya Jasa (Rp)"

        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(15, 230)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(82, 15)
        lblTanggal.TabIndex = 6
        lblTanggal.Text = "Tanggal Servis"

        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotal.Location = New Point(15, 265)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(66, 15)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Total Biaya"

        lblTotalBiaya.AutoSize = True
        lblTotalBiaya.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblTotalBiaya.ForeColor = Color.DarkGreen
        lblTotalBiaya.Location = New Point(155, 263)
        lblTotalBiaya.Name = "lblTotalBiaya"
        lblTotalBiaya.Size = New Size(41, 20)
        lblTotalBiaya.TabIndex = 8
        lblTotalBiaya.Text = "Rp 0"

        lblCari.AutoSize = True
        lblCari.Location = New Point(15, 308)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(55, 15)
        lblCari.TabIndex = 9
        lblCari.Text = "Cari Data"

        txtNamaPelanggan.Location = New Point(155, 17)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.Size = New Size(270, 23)
        txtNamaPelanggan.TabIndex = 10

        txtNoPolisi.CharacterCasing = CharacterCasing.Upper
        txtNoPolisi.Location = New Point(155, 52)
        txtNoPolisi.Name = "txtNoPolisi"
        txtNoPolisi.Size = New Size(270, 23)
        txtNoPolisi.TabIndex = 11

        txtKerusakan.Location = New Point(155, 87)
        txtKerusakan.Name = "txtKerusakan"
        txtKerusakan.Size = New Size(270, 23)
        txtKerusakan.TabIndex = 12

        txtJumlah.Location = New Point(155, 157)
        txtJumlah.Name = "txtJumlah"
        txtJumlah.Size = New Size(100, 23)
        txtJumlah.TabIndex = 14

        txtBiayaJasa.Location = New Point(155, 192)
        txtBiayaJasa.Name = "txtBiayaJasa"
        txtBiayaJasa.Size = New Size(270, 23)
        txtBiayaJasa.TabIndex = 15

        txtCari.Location = New Point(155, 305)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama, no. pol, kerusakan..."
        txtCari.Size = New Size(270, 23)
        txtCari.TabIndex = 17

        cbSparepart.DropDownStyle = ComboBoxStyle.DropDownList
        cbSparepart.Location = New Point(155, 122)
        cbSparepart.Name = "cbSparepart"
        cbSparepart.Size = New Size(270, 23)
        cbSparepart.TabIndex = 13

        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(155, 227)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(270, 23)
        dtpTanggal.TabIndex = 16

        btnSimpan.BackColor = Color.MediumSeaGreen
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(460, 182)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(90, 28)
        btnSimpan.TabIndex = 18
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False

        btnUbah.BackColor = Color.SteelBlue
        btnUbah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(460, 222)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(90, 28)
        btnUbah.TabIndex = 19
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False

        btnHapus.BackColor = Color.IndianRed
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(460, 262)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(90, 28)
        btnHapus.TabIndex = 20
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False

        btnBatal.Location = New Point(460, 302)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(90, 28)
        btnBatal.TabIndex = 21
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True

        dgvServis.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvServis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvServis.BackgroundColor = SystemColors.ButtonFace
        dgvServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvServis.Location = New Point(12, 337)
        dgvServis.MultiSelect = False
        dgvServis.Name = "dgvServis"
        dgvServis.ReadOnly = True
        dgvServis.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvServis.Size = New Size(558, 230)
        dgvServis.TabIndex = 22

        ErrorProvider1.ContainerControl = Me

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(582, 580)
        Controls.Add(lblNamaPelanggan)
        Controls.Add(lblNoPolisi)
        Controls.Add(lblKerusakan)
        Controls.Add(lblSparepart)
        Controls.Add(lblJumlah)
        Controls.Add(lblBiayaJasa)
        Controls.Add(lblTanggal)
        Controls.Add(lblTotal)
        Controls.Add(lblTotalBiaya)
        Controls.Add(lblCari)
        Controls.Add(txtNamaPelanggan)
        Controls.Add(txtNoPolisi)
        Controls.Add(txtKerusakan)
        Controls.Add(cbSparepart)
        Controls.Add(txtJumlah)
        Controls.Add(txtBiayaJasa)
        Controls.Add(dtpTanggal)
        Controls.Add(txtCari)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(dgvServis)
        MinimumSize = New Size(598, 619)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Data Servis - Bengkel"
        CType(dgvServis, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNamaPelanggan As Label
    Friend WithEvents lblNoPolisi As Label
    Friend WithEvents lblKerusakan As Label
    Friend WithEvents lblSparepart As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblBiayaJasa As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalBiaya As Label
    Friend WithEvents lblCari As Label

    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents txtNoPolisi As TextBox
    Friend WithEvents txtKerusakan As TextBox
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents txtBiayaJasa As TextBox
    Friend WithEvents txtCari As TextBox

    Friend WithEvents cbSparepart As ComboBox
    Friend WithEvents dtpTanggal As DateTimePicker

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button

    Friend WithEvents dgvServis As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class