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
        txtEmail = New TextBox()
        btnCekEmail = New Button()
        lblHasilEmail = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 0
        Label1.Text = "Input Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(50, 80)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 23)
        txtEmail.TabIndex = 1
        ' 
        ' btnCekEmail
        ' 
        btnCekEmail.Location = New Point(50, 120)
        btnCekEmail.Name = "btnCekEmail"
        btnCekEmail.Size = New Size(150, 30)
        btnCekEmail.TabIndex = 2
        btnCekEmail.Text = "Validasi Email"
        btnCekEmail.UseVisualStyleBackColor = True
        ' 
        ' lblHasilEmail
        ' 
        lblHasilEmail.AutoSize = True
        lblHasilEmail.Location = New Point(50, 170)
        lblHasilEmail.Name = "lblHasilEmail"
        lblHasilEmail.Size = New Size(12, 15)
        lblHasilEmail.TabIndex = 3
        lblHasilEmail.Text = "-"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(400, 250)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(btnCekEmail)
        Controls.Add(lblHasilEmail)
        Name = "Form1"
        Text = "Validasi Email"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnCekEmail As Button
    Friend WithEvents lblHasilEmail As Label

End Class