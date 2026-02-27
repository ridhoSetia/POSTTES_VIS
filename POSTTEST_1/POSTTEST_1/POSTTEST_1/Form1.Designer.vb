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
        btnTambah = New Button()
        inputIPS = New TextBox()
        inputIPK = New TextBox()
        ipsLbl = New Label()
        ipkLbl = New Label()
        btnReset = New Button()
        predikat = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(141, 93)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(61, 23)
        btnTambah.TabIndex = 0
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' inputIPS
        ' 
        inputIPS.Location = New Point(141, 64)
        inputIPS.Name = "inputIPS"
        inputIPS.Size = New Size(128, 23)
        inputIPS.TabIndex = 2
        ' 
        ' inputIPK
        ' 
        inputIPK.Location = New Point(141, 134)
        inputIPK.Name = "inputIPK"
        inputIPK.Size = New Size(128, 23)
        inputIPK.TabIndex = 3
        ' 
        ' ipsLbl
        ' 
        ipsLbl.AutoSize = True
        ipsLbl.Location = New Point(102, 67)
        ipsLbl.Name = "ipsLbl"
        ipsLbl.Size = New Size(23, 15)
        ipsLbl.TabIndex = 4
        ipsLbl.Text = "IPS"
        ' 
        ' ipkLbl
        ' 
        ipkLbl.AutoSize = True
        ipkLbl.Location = New Point(102, 137)
        ipkLbl.Name = "ipkLbl"
        ipkLbl.Size = New Size(24, 15)
        ipkLbl.TabIndex = 5
        ipkLbl.Text = "IPK"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(208, 93)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(61, 23)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' predikat
        ' 
        predikat.AutoSize = True
        predikat.Location = New Point(178, 177)
        predikat.Name = "predikat"
        predikat.Size = New Size(50, 15)
        predikat.TabIndex = 7
        predikat.Text = "Predikat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(396, 235)
        Controls.Add(predikat)
        Controls.Add(btnReset)
        Controls.Add(ipkLbl)
        Controls.Add(ipsLbl)
        Controls.Add(inputIPK)
        Controls.Add(inputIPS)
        Controls.Add(btnTambah)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambah As Button
    Friend WithEvents inputIPS As TextBox
    Friend WithEvents inputIPK As TextBox
    Friend WithEvents ipsLbl As Label
    Friend WithEvents ipkLbl As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents predikat As Label

End Class
