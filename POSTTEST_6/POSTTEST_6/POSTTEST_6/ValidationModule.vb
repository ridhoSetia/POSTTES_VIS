Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
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

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex < 0 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)
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

    Public Function ValidasiInputServis(ep As ErrorProvider,
                                        txtNama As TextBox,
                                        txtNoPol As TextBox,
                                        txtKerusakan As TextBox,
                                        cbSparepart As ComboBox,
                                        txtJumlah As TextBox,
                                        txtBiayaJasa As TextBox) As Boolean

        Dim vNama = ValidasiTextBox(ep, txtNama, "Nama pelanggan tidak boleh kosong")
        Dim vNoPol = ValidasiTextBox(ep, txtNoPol, "Nomor polisi tidak boleh kosong")
        Dim vKerusakan = ValidasiTextBox(ep, txtKerusakan, "Jenis kerusakan tidak boleh kosong")
        Dim vSparepart = ValidasiComboBox(ep, cbSparepart, "Pilih sparepart yang digunakan")
        Dim vJumlah = ValidasiTextBox(ep, txtJumlah, "Jumlah pakai tidak boleh kosong")
        Dim vJasa = ValidasiTextBox(ep, txtBiayaJasa, "Biaya jasa tidak boleh kosong")

        Return vNama And vNoPol And vKerusakan And vSparepart And vJumlah And vJasa
    End Function

End Module