Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFile.ShowDialog() = DialogResult.OK Then
            fotoProfil.Image = Image.FromFile(openFile.FileName)
            fotoProfil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Function GetTxtNama() As TextBox
        Return txtNama
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTelp.Text) OrElse String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            MsgBox("Inputan tidak boleh kosong", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If Not (radioLaki.Checked Or radioPerempuan.Checked) Then
            MsgBox("Inputan tidak boleh kosong (Jenis Kelamin)", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim listHobi As New List(Of String)
        For Each ctrl As Control In groupHobi.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                listHobi.Add(DirectCast(ctrl, CheckBox).Text)
            End If
        Next

        If listHobi.Count = 0 Then
            MsgBox("Hobi tidak boleh kosong!", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If fotoProfil.Image Is Nothing Then
            MsgBox("Foto tidak boleh kosong!", MsgBoxStyle.Critical, "Error")
        End If

        Dim f2 As New Form2()

        f2.dataNama = txtNama.Text
        f2.dataUmur = txtUmur.Text
        f2.dataTglLahir = tglLahir.Value.ToString("dd MMMM yyyy")
        f2.dataNoTelp = txtNoTelp.Text
        f2.dataAlamat = txtAlamat.Text
        f2.dataFoto = fotoProfil.Image
        f2.dataJenKel = If(radioLaki.Checked, "Laki-laki", "Perempuan")
        f2.dataHobi = String.Join(", ", listHobi)

        f2.Show()
    End Sub

    Private Sub HanyaAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress, txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HanyaHuruf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class
