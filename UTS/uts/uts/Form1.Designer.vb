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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        inputNama = New TextBox()
        inputNIM = New TextBox()
        inputAkt = New TextBox()
        inputIPK = New TextBox()
        pilProdi = New ComboBox()
        btnCetak = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F)
        Label1.Location = New Point(51, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(248, 30)
        Label1.TabIndex = 0
        Label1.Text = "Universitas Mulawarman"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F)
        Label2.Location = New Point(51, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 30)
        Label2.TabIndex = 1
        Label2.Text = "Informatika"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F)
        Label3.Location = New Point(51, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 32)
        Label3.TabIndex = 2
        Label3.Text = "2026"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(317, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 25)
        Label4.TabIndex = 3
        Label4.Text = "Data Mahasiswa"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(172, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 4
        Label5.Text = "Nama Lengkap"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(172, 214)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 15)
        Label6.TabIndex = 5
        Label6.Text = "NIM"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(172, 259)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 6
        Label7.Text = "Program Studi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(172, 306)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 7
        Label8.Text = "Angkatan"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(172, 357)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 15)
        Label9.TabIndex = 8
        Label9.Text = "IPK"
        ' 
        ' inputNama
        ' 
        inputNama.Location = New Point(302, 171)
        inputNama.Name = "inputNama"
        inputNama.Size = New Size(199, 23)
        inputNama.TabIndex = 9
        ' 
        ' inputNIM
        ' 
        inputNIM.Location = New Point(302, 211)
        inputNIM.Name = "inputNIM"
        inputNIM.Size = New Size(199, 23)
        inputNIM.TabIndex = 10
        ' 
        ' inputAkt
        ' 
        inputAkt.Location = New Point(302, 303)
        inputAkt.Name = "inputAkt"
        inputAkt.Size = New Size(199, 23)
        inputAkt.TabIndex = 11
        ' 
        ' inputIPK
        ' 
        inputIPK.Location = New Point(302, 354)
        inputIPK.Name = "inputIPK"
        inputIPK.Size = New Size(199, 23)
        inputIPK.TabIndex = 12
        ' 
        ' pilProdi
        ' 
        pilProdi.FormattingEnabled = True
        pilProdi.Items.AddRange(New Object() {"Informatika", "Sipil"})
        pilProdi.Location = New Point(302, 256)
        pilProdi.Name = "pilProdi"
        pilProdi.Size = New Size(199, 23)
        pilProdi.TabIndex = 13
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(302, 401)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(426, 401)
        btnBack.Name = "btnBack"
        btnBack.RightToLeft = RightToLeft.Yes
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 15
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnCetak)
        Controls.Add(pilProdi)
        Controls.Add(inputIPK)
        Controls.Add(inputAkt)
        Controls.Add(inputNIM)
        Controls.Add(inputNama)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents inputNama As TextBox
    Friend WithEvents inputNIM As TextBox
    Friend WithEvents inputAkt As TextBox
    Friend WithEvents inputIPK As TextBox
    Friend WithEvents pilProdi As ComboBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnBack As Button

End Class
