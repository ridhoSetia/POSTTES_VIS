<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Prosedur ini diperlukan oleh Windows Form Designer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtKodeBuku = New TextBox()
        Label2 = New Label()
        txtJudul = New TextBox()
        Label3 = New Label()
        txtPengarang = New TextBox()
        Label4 = New Label()
        txtPenerbit = New TextBox()
        Label5 = New Label()
        txtJumlahBuku = New TextBox()
        Label6 = New Label()
        txtDeskripsi = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvBuku = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        MySqlCommand1 = New MySqlConnector.MySqlCommand()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 17
        Label1.Text = "Kode Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(120, 20)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(135, 23)
        txtKodeBuku.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(20, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 15
        Label2.Text = "Judul"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(120, 50)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(135, 23)
        txtJudul.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(20, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 13
        Label3.Text = "Pengarang"
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(120, 80)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(135, 23)
        txtPengarang.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(20, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 11
        Label4.Text = "Penerbit"
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(120, 110)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(135, 23)
        txtPenerbit.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(20, 140)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 9
        Label5.Text = "Jumlah Buku"
        ' 
        ' txtJumlahBuku
        ' 
        txtJumlahBuku.Location = New Point(120, 140)
        txtJumlahBuku.Name = "txtJumlahBuku"
        txtJumlahBuku.Size = New Size(135, 23)
        txtJumlahBuku.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(320, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 7
        Label6.Text = "Deskripsi"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Location = New Point(380, 20)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(180, 143)
        txtDeskripsi.TabIndex = 6
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(20, 233)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(540, 23)
        txtCari.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(20, 193)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(126, 23)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(159, 193)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(118, 23)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(300, 193)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 23)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(444, 193)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(116, 23)
        btnBatal.TabIndex = 1
        btnBatal.Text = "Batal"
        ' 
        ' dgvBuku
        ' 
        dgvBuku.Location = New Point(20, 262)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.Size = New Size(540, 178)
        dgvBuku.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CommandTimeout = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.Transaction = Nothing
        MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
        ' 
        ' Form2
        ' 
        ClientSize = New Size(585, 460)
        Controls.Add(dgvBuku)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label6)
        Controls.Add(txtJumlahBuku)
        Controls.Add(Label5)
        Controls.Add(txtPenerbit)
        Controls.Add(Label4)
        Controls.Add(txtPengarang)
        Controls.Add(Label3)
        Controls.Add(txtJudul)
        Controls.Add(Label2)
        Controls.Add(txtKodeBuku)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Master Buku"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    'Deklarasi Variabel Kontrol
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJumlahBuku As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Private components As System.ComponentModel.IContainer
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
End Class
