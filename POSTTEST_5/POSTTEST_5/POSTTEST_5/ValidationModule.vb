Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        ' Char.IsControl agar tombol Backspace/Delete tetap berfungsi
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiInputSparepart(ep As ErrorProvider,
                                     txtNama As TextBox,
                                     txtStok As TextBox,
                                     txtHarga As TextBox) As Boolean

        Dim vNama = ValidasiTextBox(ep, txtNama, "Nama Sparepart tidak boleh kosong")
        Dim vStok = ValidasiTextBox(ep, txtStok, "Stok tidak boleh kosong")
        Dim vHarga = ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")

        Return vNama And vStok And vHarga
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)
    End Function

End Module
