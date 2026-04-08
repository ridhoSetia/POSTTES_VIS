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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pbFotoKartu = New PictureBox()
        lblNamaKartu = New Label()
        lblIDKartu = New Label()
        lblDivisiKartu = New Label()
        lblKontakKartu = New Label()
        lblAlamatKartu = New Label()
        lblTglLahirKartu = New Label()
        lblHobiKartu = New Label()
        PanelKartu = New Panel()
        LabelJudul = New Label()
        Panel1 = New Panel()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        PanelKartu.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()

        pbFotoKartu.BorderStyle = BorderStyle.Fixed3D
        pbFotoKartu.Location = New Point(500, 50)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(220, 300)
        pbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoKartu.TabIndex = 0
        pbFotoKartu.TabStop = False

        lblNamaKartu.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblNamaKartu.Location = New Point(10, 15)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(420, 28)
        lblNamaKartu.TabIndex = 1

        lblIDKartu.Font = New Font("Segoe UI", 9.0F)
        lblIDKartu.Location = New Point(10, 50)
        lblIDKartu.Name = "lblIDKartu"
        lblIDKartu.Size = New Size(420, 20)
        lblIDKartu.TabIndex = 2

        lblDivisiKartu.Font = New Font("Segoe UI", 9.0F)
        lblDivisiKartu.Location = New Point(10, 75)
        lblDivisiKartu.Name = "lblDivisiKartu"
        lblDivisiKartu.Size = New Size(420, 20)
        lblDivisiKartu.TabIndex = 3

        lblKontakKartu.Font = New Font("Segoe UI", 9.0F)
        lblKontakKartu.Location = New Point(10, 125)
        lblKontakKartu.Name = "lblKontakKartu"
        lblKontakKartu.Size = New Size(420, 20)
        lblKontakKartu.TabIndex = 4

        lblAlamatKartu.Font = New Font("Segoe UI", 9.0F)
        lblAlamatKartu.Location = New Point(10, 150)
        lblAlamatKartu.Name = "lblAlamatKartu"
        lblAlamatKartu.Size = New Size(420, 40)
        lblAlamatKartu.TabIndex = 9

        lblTglLahirKartu.Font = New Font("Segoe UI", 9.0F)
        lblTglLahirKartu.Location = New Point(10, 100)
        lblTglLahirKartu.Name = "lblTglLahirKartu"
        lblTglLahirKartu.Size = New Size(420, 20)
        lblTglLahirKartu.TabIndex = 8

        lblHobiKartu.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblHobiKartu.Location = New Point(10, 200)
        lblHobiKartu.Name = "lblHobiKartu"
        lblHobiKartu.Size = New Size(420, 80)
        lblHobiKartu.TabIndex = 5

        PanelKartu.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        PanelKartu.BackgroundImageLayout = ImageLayout.Center
        PanelKartu.BorderStyle = BorderStyle.FixedSingle
        PanelKartu.Controls.Add(LabelJudul)
        PanelKartu.Controls.Add(Panel1)
        PanelKartu.Controls.Add(pbFotoKartu)
        PanelKartu.Location = New Point(12, 12)
        PanelKartu.Name = "PanelKartu"
        PanelKartu.Size = New Size(741, 370)
        PanelKartu.TabIndex = 0

        LabelJudul.BackColor = Color.Transparent
        LabelJudul.Dock = DockStyle.Top
        LabelJudul.Font = New Font("Arial", 12.0F, FontStyle.Bold)
        LabelJudul.ForeColor = Color.Transparent
        LabelJudul.Location = New Point(0, 0)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(739, 40)
        LabelJudul.TabIndex = 6
        LabelJudul.Text = "KARTU ANGGOTA IMPHNEN"
        LabelJudul.TextAlign = ContentAlignment.MiddleCenter

        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblNamaKartu)
        Panel1.Controls.Add(lblIDKartu)
        Panel1.Controls.Add(lblDivisiKartu)
        Panel1.Controls.Add(lblKontakKartu)
        Panel1.Controls.Add(lblAlamatKartu)
        Panel1.Controls.Add(lblTglLahirKartu)
        Panel1.Controls.Add(lblHobiKartu)
        Panel1.Location = New Point(40, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 300)
        Panel1.TabIndex = 7

        ClientSize = New Size(765, 395)
        Controls.Add(PanelKartu)
        Name = "Form2"
        Text = "Digital ID Card"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        PanelKartu.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIDKartu As Label
    Friend WithEvents lblDivisiKartu As Label
    Friend WithEvents lblKontakKartu As Label
    Friend WithEvents lblAlamatKartu As Label
    Friend WithEvents lblTglLahirKartu As Label
    Friend WithEvents lblHobiKartu As Label
    Friend WithEvents PanelKartu As Panel
    Friend WithEvents LabelJudul As Label
    Friend WithEvents Panel1 As Panel
End Class
