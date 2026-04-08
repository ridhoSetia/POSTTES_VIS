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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        nama = New Label()
        labelnim = New Label()
        nim = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 20F)
        Label1.Location = New Point(242, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 31)
        Label1.TabIndex = 0
        Label1.Text = "Kementerian Pendidikan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18F)
        Label2.Location = New Point(256, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(252, 27)
        Label2.TabIndex = 1
        Label2.Text = "Universitas Mulawarman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F)
        Label3.Location = New Point(68, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 19)
        Label3.TabIndex = 2
        Label3.Text = "Dengan ini menyatakan bahwa:"
        ' 
        ' nama
        ' 
        nama.AutoSize = True
        nama.FlatStyle = FlatStyle.Flat
        nama.Font = New Font("Times New Roman", 16F, FontStyle.Bold Or FontStyle.Underline)
        nama.Location = New Point(67, 145)
        nama.Name = "nama"
        nama.Size = New Size(64, 25)
        nama.TabIndex = 3
        nama.Text = "nama"
        ' 
        ' labelnim
        ' 
        labelnim.AutoSize = True
        labelnim.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        labelnim.Location = New Point(68, 176)
        labelnim.Name = "labelnim"
        labelnim.Size = New Size(54, 22)
        labelnim.TabIndex = 4
        labelnim.Text = "NIM:"
        ' 
        ' nim
        ' 
        nim.AutoSize = True
        nim.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        nim.Location = New Point(117, 176)
        nim.Name = "nim"
        nim.Size = New Size(40, 22)
        nim.TabIndex = 5
        nim.Text = "nim"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F)
        Label4.Location = New Point(68, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(634, 19)
        Label4.TabIndex = 6
        Label4.Text = "Telah menyelesaikan studi dan memenuhi segala syarat pendidikan strata satu Program Studi Informatika"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F)
        Label5.Location = New Point(68, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 19)
        Label5.TabIndex = 7
        Label5.Text = "Lulus pada tanggal:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F)
        Label6.Location = New Point(193, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 19)
        Label6.TabIndex = 8
        Label6.Text = "30 Maret 2026"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F)
        Label7.Location = New Point(68, 283)
        Label7.Name = "Label7"
        Label7.Size = New Size(262, 19)
        Label7.TabIndex = 9
        Label7.Text = "Oleh sebab itu kepadanya diberikan gelar:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F)
        Label8.Location = New Point(68, 308)
        Label8.Name = "Label8"
        Label8.Size = New Size(233, 19)
        Label8.TabIndex = 10
        Label8.Text = "SARJANA KOMPUTER (S.KOM)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12F)
        Label9.Location = New Point(68, 384)
        Label9.Name = "Label9"
        Label9.Size = New Size(332, 19)
        Label9.TabIndex = 11
        Label9.Text = "Dengan segala kewajiban melekat pada gelar tersebut"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(nim)
        Controls.Add(labelnim)
        Controls.Add(nama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nama As Label
    Friend WithEvents labelnim As Label
    Friend WithEvents nim As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
