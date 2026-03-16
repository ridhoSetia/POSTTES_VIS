<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        profil = New PictureBox()
        lblUmur = New Label()
        lblTglLahir = New Label()
        lblJenKel = New Label()
        lblNoTelp = New Label()
        lblHobi = New Label()
        lblAlamat = New Label()
        umur = New Label()
        tglLahir = New Label()
        jenKel = New Label()
        noTelp = New Label()
        hobi = New Label()
        alamat = New Label()
        nama = New Label()
        lblNama = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(profil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(717, 375)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(76, 74)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' profil
        ' 
        profil.BackgroundImageLayout = ImageLayout.Stretch
        profil.Location = New Point(559, 117)
        profil.Name = "profil"
        profil.Size = New Size(189, 215)
        profil.TabIndex = 1
        profil.TabStop = False
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(254, 121)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(53, 18)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur: "
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.Transparent
        lblTglLahir.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTglLahir.Location = New Point(254, 150)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(98, 18)
        lblTglLahir.TabIndex = 3
        lblTglLahir.Text = "Tanggal Lahir:"
        ' 
        ' lblJenKel
        ' 
        lblJenKel.AutoSize = True
        lblJenKel.BackColor = Color.Transparent
        lblJenKel.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJenKel.Location = New Point(254, 192)
        lblJenKel.Name = "lblJenKel"
        lblJenKel.Size = New Size(101, 18)
        lblJenKel.TabIndex = 4
        lblJenKel.Text = "Jenis Kelamin: "
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.Transparent
        lblNoTelp.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoTelp.Location = New Point(254, 222)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(94, 18)
        lblNoTelp.TabIndex = 5
        lblNoTelp.Text = "No. Telepon: "
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobi.Location = New Point(254, 263)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(47, 18)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobi: "
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(222, 333)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(53, 18)
        lblAlamat.TabIndex = 8
        lblAlamat.Text = "Alamat"
        ' 
        ' umur
        ' 
        umur.AutoSize = True
        umur.BackColor = Color.Transparent
        umur.Location = New Point(304, 124)
        umur.Name = "umur"
        umur.Size = New Size(41, 15)
        umur.TabIndex = 9
        umur.Text = "Label1"
        ' 
        ' tglLahir
        ' 
        tglLahir.AutoSize = True
        tglLahir.BackColor = Color.Transparent
        tglLahir.Location = New Point(353, 153)
        tglLahir.Name = "tglLahir"
        tglLahir.Size = New Size(41, 15)
        tglLahir.TabIndex = 10
        tglLahir.Text = "Label1"
        ' 
        ' jenKel
        ' 
        jenKel.AutoSize = True
        jenKel.BackColor = Color.Transparent
        jenKel.Location = New Point(351, 195)
        jenKel.Name = "jenKel"
        jenKel.Size = New Size(41, 15)
        jenKel.TabIndex = 11
        jenKel.Text = "Label1"
        ' 
        ' noTelp
        ' 
        noTelp.AutoSize = True
        noTelp.BackColor = Color.Transparent
        noTelp.Location = New Point(344, 225)
        noTelp.Name = "noTelp"
        noTelp.Size = New Size(41, 15)
        noTelp.TabIndex = 12
        noTelp.Text = "Label1"
        ' 
        ' hobi
        ' 
        hobi.AutoSize = True
        hobi.BackColor = Color.Transparent
        hobi.Location = New Point(255, 291)
        hobi.Name = "hobi"
        hobi.Size = New Size(41, 15)
        hobi.TabIndex = 13
        hobi.Text = "Label1"
        ' 
        ' alamat
        ' 
        alamat.AutoSize = True
        alamat.BackColor = Color.Transparent
        alamat.Location = New Point(60, 382)
        alamat.Name = "alamat"
        alamat.Size = New Size(41, 15)
        alamat.TabIndex = 14
        alamat.Text = "Label1"
        ' 
        ' nama
        ' 
        nama.AutoSize = True
        nama.BackColor = Color.Transparent
        nama.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nama.Location = New Point(559, 384)
        nama.Name = "nama"
        nama.Size = New Size(46, 16)
        nama.TabIndex = 15
        nama.Text = "Label1"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(559, 363)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(42, 16)
        lblNama.TabIndex = 16
        lblNama.Text = "Nama:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblNama)
        Controls.Add(nama)
        Controls.Add(alamat)
        Controls.Add(hobi)
        Controls.Add(noTelp)
        Controls.Add(jenKel)
        Controls.Add(tglLahir)
        Controls.Add(umur)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobi)
        Controls.Add(lblNoTelp)
        Controls.Add(lblJenKel)
        Controls.Add(lblTglLahir)
        Controls.Add(lblUmur)
        Controls.Add(profil)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(profil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents profil As PictureBox
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblJenKel As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents umur As Label
    Friend WithEvents tglLahir As Label
    Friend WithEvents jenKel As Label
    Friend WithEvents noTelp As Label
    Friend WithEvents hobi As Label
    Friend WithEvents alamat As Label
    Friend WithEvents nama As Label
    Friend WithEvents lblNama As Label
End Class
