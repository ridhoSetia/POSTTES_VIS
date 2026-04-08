<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TabControl1 As TabControl
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabPage1 = New TabPage()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LabelJK = New Label()
        cmbDivisi = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtxtTelepon = New MaskedTextBox()
        TabPage3 = New TabPage()
        btnSimpanCetak = New Button()
        GroupBox2 = New GroupBox()
        chk1 = New CheckBox()
        chk2 = New CheckBox()
        chk3 = New CheckBox()
        chk4 = New CheckBox()
        chk5 = New CheckBox()
        chk6 = New CheckBox()
        chk7 = New CheckBox()
        chk8 = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        pbProfil = New PictureBox()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        PictureBoxLogo = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1 = New TabControl()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbProfil, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        TabPage1.BackColor = Color.DarkGray
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(LabelJK)
        TabPage1.Controls.Add(cmbDivisi)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(514, 302)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"

        Label5.Location = New Point(21, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 23)
        Label5.TabIndex = 9
        Label5.Text = "Divisi/Jenis:"

        Label4.Location = New Point(21, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 23)
        Label4.TabIndex = 8
        Label4.Text = "Tgl Lahir:"

        Label3.Location = New Point(21, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 23)
        Label3.TabIndex = 7
        Label3.Text = "ID Anggota:"

        Label2.Location = New Point(21, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 23)
        Label2.TabIndex = 6
        Label2.Text = "Nama Lengkap:"

        LabelJK.Location = New Point(21, 158)
        LabelJK.Name = "LabelJK"
        LabelJK.Size = New Size(110, 23)
        LabelJK.TabIndex = 10
        LabelJK.Text = "Jenis Kelamin:"

        cmbDivisi.FormattingEnabled = True
        cmbDivisi.Items.AddRange(New Object() {"Gaming", "Programming", "Design", "Musik", "Olahraga", "Fotografi", "Literasi", "Seni"})
        cmbDivisi.Location = New Point(140, 197)
        cmbDivisi.Name = "cmbDivisi"
        cmbDivisi.Size = New Size(300, 23)
        cmbDivisi.TabIndex = 5

        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(235, 155)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(86, 19)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True

        rbLaki.AutoSize = True
        rbLaki.Location = New Point(140, 155)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(69, 19)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True

        dtpLahir.Location = New Point(140, 110)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(300, 23)
        dtpLahir.TabIndex = 2

        txtID.Location = New Point(140, 66)
        txtID.Name = "txtID"
        txtID.Size = New Size(300, 23)
        txtID.TabIndex = 1

        txtNama.Location = New Point(140, 25)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(300, 23)
        txtNama.TabIndex = 0

        TabPage2.BackColor = Color.DarkGray
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtxtTelepon)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(514, 302)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"

        Label8.Location = New Point(24, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 23)
        Label8.TabIndex = 5
        Label8.Text = "Alamat:"

        Label7.Location = New Point(24, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 23)
        Label7.TabIndex = 4
        Label7.Text = "Email:"

        Label6.Location = New Point(24, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 23)
        Label6.TabIndex = 3
        Label6.Text = "No. Telepon:"

        txtAlamat.Location = New Point(121, 111)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(330, 83)
        txtAlamat.TabIndex = 2

        txtEmail.Location = New Point(121, 69)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(330, 23)
        txtEmail.TabIndex = 1

        mtxtTelepon.Location = New Point(121, 27)
        mtxtTelepon.Mask = "0000-0000-0000"
        mtxtTelepon.Name = "mtxtTelepon"
        mtxtTelepon.Size = New Size(330, 23)
        mtxtTelepon.TabIndex = 0

        TabPage3.BackColor = Color.DarkGray
        TabPage3.Controls.Add(btnSimpanCetak)
        TabPage3.Controls.Add(GroupBox2)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbProfil)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(514, 302)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"

        btnSimpanCetak.BackColor = Color.DarkSlateGray
        btnSimpanCetak.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpanCetak.ForeColor = SystemColors.ButtonFace
        btnSimpanCetak.Location = New Point(148, 268)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(355, 28)
        btnSimpanCetak.TabIndex = 4
        btnSimpanCetak.Text = "Simpan & Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False

        GroupBox2.Controls.Add(chk1)
        GroupBox2.Controls.Add(chk2)
        GroupBox2.Controls.Add(chk3)
        GroupBox2.Controls.Add(chk4)
        GroupBox2.Controls.Add(chk5)
        GroupBox2.Controls.Add(chk6)
        GroupBox2.Controls.Add(chk7)
        GroupBox2.Controls.Add(chk8)
        GroupBox2.Location = New Point(148, 100)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(355, 160)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Minat / Aktivitas (pilih minimal 1)"

        chk1.Location = New Point(10, 25)
        chk1.Name = "chk1"
        chk1.Size = New Size(100, 24)
        chk1.TabIndex = 0
        chk1.Text = "Gaming"

        chk2.Location = New Point(10, 55)
        chk2.Name = "chk2"
        chk2.Size = New Size(100, 24)
        chk2.TabIndex = 1
        chk2.Text = "Musik"

        chk3.Location = New Point(10, 85)
        chk3.Name = "chk3"
        chk3.Size = New Size(100, 24)
        chk3.TabIndex = 2
        chk3.Text = "Membaca"

        chk4.Location = New Point(10, 115)
        chk4.Name = "chk4"
        chk4.Size = New Size(100, 24)
        chk4.TabIndex = 3
        chk4.Text = "Olahraga"

        chk5.Location = New Point(185, 25)
        chk5.Name = "chk5"
        chk5.Size = New Size(100, 24)
        chk5.TabIndex = 4
        chk5.Text = "Desain"

        chk6.Location = New Point(185, 55)
        chk6.Name = "chk6"
        chk6.Size = New Size(100, 24)
        chk6.TabIndex = 5
        chk6.Text = "Ngoding"

        chk7.Location = New Point(185, 85)
        chk7.Name = "chk7"
        chk7.Size = New Size(100, 24)
        chk7.TabIndex = 6
        chk7.Text = "Fotografi"

        chk8.Location = New Point(185, 115)
        chk8.Name = "chk8"
        chk8.Size = New Size(100, 24)
        chk8.TabIndex = 7
        chk8.Text = "Travelling"

        GroupBox1.Controls.Add(rbAdmin)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Location = New Point(148, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(355, 78)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran Anggota"

        rbAdmin.Location = New Point(240, 34)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(100, 24)
        rbAdmin.TabIndex = 2
        rbAdmin.Text = "Member"

        rbAnggota.Location = New Point(120, 34)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(100, 24)
        rbAnggota.TabIndex = 1
        rbAnggota.Text = "Admin Cabang"

        rbKetua.Location = New Point(10, 34)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(100, 24)
        rbKetua.TabIndex = 0
        rbKetua.Text = "Ketua"

        btnBrowse.Location = New Point(15, 215)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 28)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True

        pbProfil.BorderStyle = BorderStyle.FixedSingle
        pbProfil.Location = New Point(15, 37)
        pbProfil.Name = "pbProfil"
        pbProfil.Size = New Size(120, 160)
        pbProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfil.TabIndex = 0
        pbProfil.TabStop = False

        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(142, 194)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(522, 330)
        TabControl1.TabIndex = 3

        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(822, 24)
        MenuStrip1.TabIndex = 0

        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"

        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(76, 20)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"

        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(86, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"

        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(72, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"

        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"

        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Label1.Location = New Point(161, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(491, 32)
        Label1.TabIndex = 1
        Label1.Text = "PEMBUATAN KARTU ANGGOTA IMPHNEN"

        PictureBoxLogo.BorderStyle = BorderStyle.FixedSingle
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(146, 71)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(518, 107)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(822, 545)
        Controls.Add(TabControl1)
        Controls.Add(PictureBoxLogo)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Manajemen Komunitas"
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(pbProfil, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cmbDivisi As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelJK As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtxtTelepon As MaskedTextBox
    Friend WithEvents pbProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
