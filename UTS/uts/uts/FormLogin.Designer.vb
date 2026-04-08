<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        inputUser = New TextBox()
        inputPass = New TextBox()
        Label2 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(283, 151)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' inputUser
        ' 
        inputUser.Location = New Point(367, 143)
        inputUser.Name = "inputUser"
        inputUser.Size = New Size(100, 23)
        inputUser.TabIndex = 1
        ' 
        ' inputPass
        ' 
        inputPass.Location = New Point(367, 187)
        inputPass.Name = "inputPass"
        inputPass.Size = New Size(100, 23)
        inputPass.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(283, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(351, 260)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(inputPass)
        Controls.Add(Label2)
        Controls.Add(inputUser)
        Controls.Add(Label1)
        Name = "FormLogin"
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inputUser As TextBox
    Friend WithEvents inputPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
End Class
