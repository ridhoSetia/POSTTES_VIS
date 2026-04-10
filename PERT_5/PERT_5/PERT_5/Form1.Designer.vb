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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtIdJenis = New TextBox()
        txtJenisBuku = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvJenisBuku = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvJenisBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID Jenis"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 2
        Label3.Text = "Cari Data"
        ' 
        ' txtIdJenis
        ' 
        txtIdJenis.Location = New Point(125, 27)
        txtIdJenis.Name = "txtIdJenis"
        txtIdJenis.Size = New Size(264, 23)
        txtIdJenis.TabIndex = 3
        ' 
        ' txtJenisBuku
        ' 
        txtJenisBuku.Location = New Point(125, 72)
        txtJenisBuku.Name = "txtJenisBuku"
        txtJenisBuku.Size = New Size(264, 23)
        txtJenisBuku.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(125, 116)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(264, 23)
        txtSearch.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(12, 156)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(110, 156)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(213, 156)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(314, 156)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvJenisBuku
        ' 
        dgvJenisBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvJenisBuku.Location = New Point(12, 189)
        dgvJenisBuku.Name = "dgvJenisBuku"
        dgvJenisBuku.Size = New Size(377, 183)
        dgvJenisBuku.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 384)
        Controls.Add(dgvJenisBuku)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtSearch)
        Controls.Add(txtJenisBuku)
        Controls.Add(txtIdJenis)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvJenisBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdJenis As TextBox
    Friend WithEvents txtJenisBuku As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvJenisBuku As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
