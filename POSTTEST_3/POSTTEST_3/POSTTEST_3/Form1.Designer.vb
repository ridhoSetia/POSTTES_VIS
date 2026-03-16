<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        fotoProfil = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblTglLhir = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        groupJenKel = New GroupBox()
        radioLaki = New RadioButton()
        radioPerempuan = New RadioButton()
        groupHobi = New GroupBox()
        ngoding = New CheckBox()
        mancing = New CheckBox()
        gaming = New CheckBox()
        tidur = New CheckBox()
        belajar = New CheckBox()
        menulis = New CheckBox()
        membaca = New CheckBox()
        travelling = New CheckBox()
        olahraga = New CheckBox()
        belanja = New CheckBox()
        lblAlamat = New Label()
        tglLahir = New DateTimePicker()
        btnCetak = New Button()
        CType(fotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        groupJenKel.SuspendLayout()
        groupHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' fotoProfil
        ' 
        fotoProfil.BackColor = SystemColors.ControlDarkDark
        fotoProfil.Location = New Point(577, 96)
        fotoProfil.Name = "fotoProfil"
        fotoProfil.Size = New Size(176, 217)
        fotoProfil.TabIndex = 0
        fotoProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(629, 319)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(44, 105)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(44, 149)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(37, 15)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(44, 233)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(68, 15)
        lblNoTelp.TabIndex = 4
        lblNoTelp.Text = "No Telepon"
        ' 
        ' lblTglLhir
        ' 
        lblTglLhir.AutoSize = True
        lblTglLhir.Location = New Point(44, 192)
        lblTglLhir.Name = "lblTglLhir"
        lblTglLhir.Size = New Size(78, 15)
        lblTglLhir.TabIndex = 6
        lblTglLhir.Text = "Tanggal Lahir"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(139, 99)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(181, 23)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(139, 143)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(181, 23)
        txtUmur.TabIndex = 8
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(139, 230)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(181, 23)
        txtNoTelp.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(139, 274)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(181, 23)
        txtAlamat.TabIndex = 10
        ' 
        ' groupJenKel
        ' 
        groupJenKel.BackColor = Color.White
        groupJenKel.Controls.Add(radioLaki)
        groupJenKel.Controls.Add(radioPerempuan)
        groupJenKel.Location = New Point(340, 96)
        groupJenKel.Name = "groupJenKel"
        groupJenKel.Size = New Size(219, 90)
        groupJenKel.TabIndex = 11
        groupJenKel.TabStop = False
        groupJenKel.Text = "Jenis Kelamin"
        ' 
        ' radioLaki
        ' 
        radioLaki.AutoSize = True
        radioLaki.Location = New Point(15, 22)
        radioLaki.Name = "radioLaki"
        radioLaki.Size = New Size(69, 19)
        radioLaki.TabIndex = 0
        radioLaki.TabStop = True
        radioLaki.Text = "Laki-laki"
        radioLaki.UseVisualStyleBackColor = True
        ' 
        ' radioPerempuan
        ' 
        radioPerempuan.AutoSize = True
        radioPerempuan.Location = New Point(15, 47)
        radioPerempuan.Name = "radioPerempuan"
        radioPerempuan.Size = New Size(86, 19)
        radioPerempuan.TabIndex = 1
        radioPerempuan.TabStop = True
        radioPerempuan.Text = "Perempuan"
        radioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' groupHobi
        ' 
        groupHobi.BackColor = Color.White
        groupHobi.Controls.Add(ngoding)
        groupHobi.Controls.Add(mancing)
        groupHobi.Controls.Add(gaming)
        groupHobi.Controls.Add(tidur)
        groupHobi.Controls.Add(belajar)
        groupHobi.Controls.Add(menulis)
        groupHobi.Controls.Add(membaca)
        groupHobi.Controls.Add(travelling)
        groupHobi.Controls.Add(olahraga)
        groupHobi.Controls.Add(belanja)
        groupHobi.Location = New Point(340, 192)
        groupHobi.Name = "groupHobi"
        groupHobi.Size = New Size(219, 150)
        groupHobi.TabIndex = 0
        groupHobi.TabStop = False
        groupHobi.Text = "Hobi"
        ' 
        ' ngoding
        ' 
        ngoding.AutoSize = True
        ngoding.Location = New Point(15, 22)
        ngoding.Name = "ngoding"
        ngoding.Size = New Size(73, 19)
        ngoding.TabIndex = 2
        ngoding.Text = "Ngoding"
        ngoding.UseVisualStyleBackColor = True
        ' 
        ' mancing
        ' 
        mancing.AutoSize = True
        mancing.Location = New Point(15, 47)
        mancing.Name = "mancing"
        mancing.Size = New Size(73, 19)
        mancing.TabIndex = 3
        mancing.Text = "Mancing"
        mancing.UseVisualStyleBackColor = True
        ' 
        ' gaming
        ' 
        gaming.AutoSize = True
        gaming.Location = New Point(15, 72)
        gaming.Name = "gaming"
        gaming.Size = New Size(68, 19)
        gaming.TabIndex = 4
        gaming.Text = "Gaming"
        gaming.UseVisualStyleBackColor = True
        ' 
        ' tidur
        ' 
        tidur.AutoSize = True
        tidur.Location = New Point(15, 122)
        tidur.Name = "tidur"
        tidur.Size = New Size(54, 19)
        tidur.TabIndex = 10
        tidur.Text = "Tidur"
        tidur.UseVisualStyleBackColor = True
        ' 
        ' belajar
        ' 
        belajar.AutoSize = True
        belajar.Location = New Point(120, 72)
        belajar.Name = "belajar"
        belajar.Size = New Size(61, 19)
        belajar.TabIndex = 8
        belajar.Text = "Belajar"
        belajar.UseVisualStyleBackColor = True
        ' 
        ' menulis
        ' 
        menulis.AutoSize = True
        menulis.Location = New Point(120, 122)
        menulis.Name = "menulis"
        menulis.Size = New Size(68, 19)
        menulis.TabIndex = 11
        menulis.Text = "Menulis"
        menulis.UseVisualStyleBackColor = True
        ' 
        ' membaca
        ' 
        membaca.AutoSize = True
        membaca.Location = New Point(120, 47)
        membaca.Name = "membaca"
        membaca.Size = New Size(79, 19)
        membaca.TabIndex = 7
        membaca.Text = "Membaca"
        membaca.UseVisualStyleBackColor = True
        ' 
        ' travelling
        ' 
        travelling.AutoSize = True
        travelling.Location = New Point(15, 97)
        travelling.Name = "travelling"
        travelling.Size = New Size(77, 19)
        travelling.TabIndex = 5
        travelling.Text = "Travelling"
        travelling.UseVisualStyleBackColor = True
        ' 
        ' olahraga
        ' 
        olahraga.AutoSize = True
        olahraga.Location = New Point(120, 22)
        olahraga.Name = "olahraga"
        olahraga.Size = New Size(74, 19)
        olahraga.TabIndex = 6
        olahraga.Text = "Olahraga"
        olahraga.UseVisualStyleBackColor = True
        ' 
        ' belanja
        ' 
        belanja.AutoSize = True
        belanja.Location = New Point(120, 97)
        belanja.Name = "belanja"
        belanja.Size = New Size(64, 19)
        belanja.TabIndex = 9
        belanja.Text = "Belanja"
        belanja.UseVisualStyleBackColor = True
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(44, 277)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(45, 15)
        lblAlamat.TabIndex = 12
        lblAlamat.Text = "Alamat"
        ' 
        ' tglLahir
        ' 
        tglLahir.Location = New Point(139, 188)
        tglLahir.Name = "tglLahir"
        tglLahir.Size = New Size(181, 23)
        tglLahir.TabIndex = 13
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(47, 319)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(273, 23)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 450)
        Controls.Add(btnCetak)
        Controls.Add(tglLahir)
        Controls.Add(groupHobi)
        Controls.Add(lblAlamat)
        Controls.Add(groupJenKel)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblTglLhir)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(fotoProfil)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form Cetak"
        CType(fotoProfil, ComponentModel.ISupportInitialize).EndInit()
        groupJenKel.ResumeLayout(False)
        groupJenKel.PerformLayout()
        groupHobi.ResumeLayout(False)
        groupHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fotoProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblTglLhir As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents groupJenKel As GroupBox
    Friend WithEvents groupHobi As GroupBox
    Friend WithEvents menulis As CheckBox
    Friend WithEvents tidur As CheckBox
    Friend WithEvents belanja As CheckBox
    Friend WithEvents belajar As CheckBox
    Friend WithEvents membaca As CheckBox
    Friend WithEvents olahraga As CheckBox
    Friend WithEvents travelling As CheckBox
    Friend WithEvents gaming As CheckBox
    Friend WithEvents mancing As CheckBox
    Friend WithEvents ngoding As CheckBox
    Friend WithEvents radioPerempuan As RadioButton
    Friend WithEvents radioLaki As RadioButton
    Friend WithEvents lblAlamat As Label
    Friend WithEvents tglLahir As DateTimePicker
    Friend WithEvents btnCetak As Button

End Class
