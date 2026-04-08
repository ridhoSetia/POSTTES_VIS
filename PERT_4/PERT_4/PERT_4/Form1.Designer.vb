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
        MenuStrip1 = New MenuStrip()
        MnuOpenFile = New ToolStripMenuItem()
        MnuExit = New ToolStripMenuItem()
        tcRingkasan = New TabPage()
        tcIdentitas = New TabPage()
        mtxtNoHp = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtNama = New TextBox()
        TabControl1 = New TabControl()
        lblRingkasan = New Label()
        btnSave = New Button()
        btnRst = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        tcRingkasan.SuspendLayout()
        tcIdentitas.SuspendLayout()
        TabControl1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MnuOpenFile, MnuExit})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MnuOpenFile
        ' 
        MnuOpenFile.Name = "MnuOpenFile"
        MnuOpenFile.Size = New Size(69, 20)
        MnuOpenFile.Text = "Open File"
        ' 
        ' MnuExit
        ' 
        MnuExit.Name = "MnuExit"
        MnuExit.Size = New Size(37, 20)
        MnuExit.Text = "Exit"
        ' 
        ' tcRingkasan
        ' 
        tcRingkasan.Controls.Add(lblRingkasan)
        tcRingkasan.Location = New Point(4, 24)
        tcRingkasan.Name = "tcRingkasan"
        tcRingkasan.Padding = New Padding(3)
        tcRingkasan.Size = New Size(275, 150)
        tcRingkasan.TabIndex = 1
        tcRingkasan.Text = "Ringkasan"
        tcRingkasan.UseVisualStyleBackColor = True
        ' 
        ' tcIdentitas
        ' 
        tcIdentitas.Controls.Add(mtxtNoHp)
        tcIdentitas.Controls.Add(txtAlamat)
        tcIdentitas.Controls.Add(txtNama)
        tcIdentitas.Location = New Point(4, 24)
        tcIdentitas.Name = "tcIdentitas"
        tcIdentitas.Padding = New Padding(3)
        tcIdentitas.Size = New Size(275, 150)
        tcIdentitas.TabIndex = 0
        tcIdentitas.Text = "Identitas"
        tcIdentitas.UseVisualStyleBackColor = True
        ' 
        ' mtxtNoHp
        ' 
        mtxtNoHp.Location = New Point(15, 99)
        mtxtNoHp.Mask = "000-000-000-000"
        mtxtNoHp.Name = "mtxtNoHp"
        mtxtNoHp.Size = New Size(100, 23)
        mtxtNoHp.TabIndex = 2
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(15, 56)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat"
        txtAlamat.Size = New Size(100, 23)
        txtAlamat.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(15, 17)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tcIdentitas)
        TabControl1.Controls.Add(tcRingkasan)
        TabControl1.Location = New Point(60, 107)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(283, 178)
        TabControl1.TabIndex = 1
        ' 
        ' lblRingkasan
        ' 
        lblRingkasan.AutoSize = True
        lblRingkasan.Location = New Point(18, 17)
        lblRingkasan.Name = "lblRingkasan"
        lblRingkasan.Size = New Size(61, 15)
        lblRingkasan.TabIndex = 0
        lblRingkasan.Text = "Ringkasan"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(371, 229)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnRst
        ' 
        btnRst.Location = New Point(371, 260)
        btnRst.Name = "btnRst"
        btnRst.Size = New Size(75, 23)
        btnRst.TabIndex = 4
        btnRst.Text = "Reset"
        btnRst.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRst)
        Controls.Add(btnSave)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tcRingkasan.ResumeLayout(False)
        tcRingkasan.PerformLayout()
        tcIdentitas.ResumeLayout(False)
        tcIdentitas.PerformLayout()
        TabControl1.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuOpenFile As ToolStripMenuItem
    Friend WithEvents MnuExit As ToolStripMenuItem
    Friend WithEvents tcRingkasan As TabPage
    Friend WithEvents tcIdentitas As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents mtxtNoHp As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblRingkasan As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRst As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
