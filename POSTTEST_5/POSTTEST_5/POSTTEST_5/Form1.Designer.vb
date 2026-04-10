<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtStok = New TextBox()
        txtHarga = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvSparepart = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        txtCari = New TextBox()
        Label4 = New Label()
        CType(dgvSparepart, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        Label1.AutoSize = True
        Label1.Location = New Point(16, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Sparepart"

        Label2.AutoSize = True
        Label2.Location = New Point(16, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "Stok Awal"

        Label3.AutoSize = True
        Label3.Location = New Point(16, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 2
        Label3.Text = "Harga Sparepart"

        txtNama.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtNama.Location = New Point(147, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(289, 23)
        txtNama.TabIndex = 3

        txtStok.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStok.Location = New Point(147, 66)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(289, 23)
        txtStok.TabIndex = 4

        txtHarga.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtHarga.Location = New Point(147, 103)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(289, 23)
        txtHarga.TabIndex = 5

        btnSimpan.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSimpan.Location = New Point(487, 27)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True

        btnUbah.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnUbah.Location = New Point(487, 66)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(75, 23)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True

        btnHapus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHapus.Location = New Point(487, 103)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True

        btnBatal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnBatal.Location = New Point(487, 142)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True

        dgvSparepart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSparepart.BackgroundColor = SystemColors.ButtonFace
        dgvSparepart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSparepart.Location = New Point(12, 189)
        dgvSparepart.Name = "dgvSparepart"
        dgvSparepart.Size = New Size(550, 210)
        dgvSparepart.TabIndex = 10
        dgvSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ErrorProvider1.ContainerControl = Me

        txtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtCari.Location = New Point(147, 142)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(289, 23)
        txtCari.TabIndex = 12

        Label4.AutoSize = True
        Label4.Location = New Point(16, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 11
        Label4.Text = "Cari Data"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(584, 411)
        Controls.Add(txtCari)
        Controls.Add(Label4)
        Controls.Add(dgvSparepart)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtHarga)
        Controls.Add(txtStok)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvSparepart, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvSparepart As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label4 As Label

End Class
