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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblGenre = New Label()
        txtGenre = New TextBox()
        btnTambah = New Button()
        btnHps = New Button()
        dgvListBuku = New DataGridView()
        gBoxHps = New GroupBox()
        judulBuku = New Label()
        txtJudulHps = New TextBox()
        gBoxTambah = New GroupBox()
        txtJudul = New TextBox()
        lblJudul = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        CType(dgvListBuku, ComponentModel.ISupportInitialize).BeginInit()
        gBoxHps.SuspendLayout()
        gBoxTambah.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(12, 98)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(38, 15)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(15, 116)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(280, 23)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(220, 145)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHps
        ' 
        btnHps.Location = New Point(220, 75)
        btnHps.Name = "btnHps"
        btnHps.Size = New Size(75, 23)
        btnHps.TabIndex = 6
        btnHps.Text = "Hapus"
        btnHps.UseVisualStyleBackColor = True
        ' 
        ' dgvListBuku
        ' 
        dgvListBuku.BackgroundColor = SystemColors.InactiveCaption
        dgvListBuku.BorderStyle = BorderStyle.None
        dgvListBuku.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvListBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListBuku.ColumnHeadersVisible = False
        dgvListBuku.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvListBuku.GridColor = Color.DarkGray
        dgvListBuku.Location = New Point(321, 3)
        dgvListBuku.Name = "dgvListBuku"
        dgvListBuku.ReadOnly = True
        dgvListBuku.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvListBuku.RowHeadersVisible = False
        dgvListBuku.Size = New Size(302, 326)
        dgvListBuku.TabIndex = 8
        ' 
        ' gBoxHps
        ' 
        gBoxHps.BackColor = SystemColors.InactiveCaption
        gBoxHps.Controls.Add(judulBuku)
        gBoxHps.Controls.Add(txtJudulHps)
        gBoxHps.Controls.Add(btnHps)
        gBoxHps.Location = New Point(0, 201)
        gBoxHps.Name = "gBoxHps"
        gBoxHps.Size = New Size(315, 128)
        gBoxHps.TabIndex = 9
        gBoxHps.TabStop = False
        gBoxHps.Text = "Hapus Buku"
        ' 
        ' judulBuku
        ' 
        judulBuku.AutoSize = True
        judulBuku.Location = New Point(15, 28)
        judulBuku.Name = "judulBuku"
        judulBuku.Size = New Size(65, 15)
        judulBuku.TabIndex = 9
        judulBuku.Text = "Judul Buku"
        ' 
        ' txtJudulHps
        ' 
        txtJudulHps.Location = New Point(15, 46)
        txtJudulHps.Name = "txtJudulHps"
        txtJudulHps.Size = New Size(280, 23)
        txtJudulHps.TabIndex = 8
        ' 
        ' gBoxTambah
        ' 
        gBoxTambah.BackColor = SystemColors.InactiveCaption
        gBoxTambah.Controls.Add(txtJudul)
        gBoxTambah.Controls.Add(lblJudul)
        gBoxTambah.Controls.Add(lblGenre)
        gBoxTambah.Controls.Add(txtGenre)
        gBoxTambah.Controls.Add(btnTambah)
        gBoxTambah.Location = New Point(0, 3)
        gBoxTambah.Name = "gBoxTambah"
        gBoxTambah.Size = New Size(315, 192)
        gBoxTambah.TabIndex = 9
        gBoxTambah.TabStop = False
        gBoxTambah.Text = "Tambah Buku Baru"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(15, 51)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(280, 23)
        txtJudul.TabIndex = 2
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(15, 33)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(65, 15)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Judul Buku"
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle1.BackColor = SystemColors.InactiveCaption
        DataGridViewCellStyle1.ForeColor = Color.White
        Column1.DefaultCellStyle = DataGridViewCellStyle1
        Column1.HeaderText = ""
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(622, 331)
        Controls.Add(gBoxTambah)
        Controls.Add(gBoxHps)
        Controls.Add(dgvListBuku)
        Name = "Form1"
        Text = "Form1"
        CType(dgvListBuku, ComponentModel.ISupportInitialize).EndInit()
        gBoxHps.ResumeLayout(False)
        gBoxHps.PerformLayout()
        gBoxTambah.ResumeLayout(False)
        gBoxTambah.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents dgvListBuku As DataGridView
    Friend WithEvents gBoxHps As GroupBox
    Friend WithEvents gBoxTambah As GroupBox
    Friend WithEvents txtJudulHps As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents judulBuku As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn

End Class
