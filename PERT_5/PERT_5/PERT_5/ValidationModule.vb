Imports System.Windows.Forms

Public Module ValidationModule
    ' --- Input Restrictions ---

    ''' <summary>
    ''' Membatasi input agar hanya menerima huruf, spasi, dan tombol kontrol (backspace)
    ''' </summary>
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' Membatasi input agar hanya menerima angka dan tombol kontrol (backspace)
    ''' </summary>
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' --- TextBox Validation ---

    ''' <summary>
    ''' Memeriksa apakah TextBox kosong dan mengatur ErrorProvider jika diperlukan
    ''' </summary>
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
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    ''' <summary>
    ''' Validasi khusus untuk form Jenis Buku
    ''' </summary>
    Public Function ValidasiJenisBuku(ep As ErrorProvider, txtidJenis As TextBox, txtJenis As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtidJenis, "Kode Jenis tidak boleh kosong")
        Dim jenisValid As Boolean = ValidasiTextBox(ep, txtJenis, "Jenis Buku tidak boleh kosong")

        ' Mengembalikan true hanya jika keduanya valid
        Return kodeValid And jenisValid
    End Function

    ' --- Keyboard Helpers ---

    ''' <summary>
    ''' Mengecek apakah tombol yang ditekan adalah Enter
    ''' </summary>
    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)
    End Function

    Public Function ValidasiDataBuku(ep As ErrorProvider, txtKode As TextBox, cbJenis As ComboBox, txtJudul As TextBox, txtPengarang As TextBox, txtPenerbit As TextBox, txtJumlahBuku As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Buku wajib diisi!")
        Dim jenisValid As Boolean = ValidasiComboBox(ep, cbJenis, "Silakan pilih Jenis Buku!")
        Dim judulValid As Boolean = ValidasiTextBox(ep, txtJudul, "Judul Buku wajib diisi!")
        Dim pengarangValid As Boolean = ValidasiTextBox(ep, txtPengarang, "Nama Pengarang wajib diisi!")
        Dim penerbitValid As Boolean = ValidasiTextBox(ep, txtPenerbit, "Nama Penerbit wajib diisi!")
        Dim jumlahValid As Boolean = ValidasiTextBox(ep, txtJumlahBuku, "Jumlah/Stok Buku wajib diisi!")
        Return kodeValid And jenisValid And judulValid And pengarangValid And penerbitValid And
        jumlahValid
    End Function

End Module