Imports MySqlConnector
Imports System.Data

Public Module DataModule
    ' --- Konfigurasi Koneksi ---
    ' Pastikan fungsi GetConnection() didefinisikan di sini atau di modul koneksi utama Anda
    ' Private Function GetConnection() As MySqlConnection
    '     Return New MySqlConnection("server=localhost;user=root;database=db_perpustakaan;password=")
    ' End Function

    ''' <summary>
    ''' Mengambil semua data jenis buku untuk ditampilkan di Grid
    ''' </summary>
    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT idJenis, jenis FROM tbjenis ORDER BY idJenis ASC"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Mencari data jenis buku berdasarkan keyword pada kode atau nama jenis
    ''' </summary>
    Public Function SearchJenis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT idJenis, jenis FROM tbjenis " &
                             "WHERE idJenis LIKE @keyword OR jenis LIKE @keyword " &
                             "ORDER BY idJenis ASC"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Mengambil data spesifik berdasarkan Kode Jenis
    ''' </summary>
    Public Function GetJenisByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT idJenis, jenis FROM tbjenis WHERE idJenis = @kode"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil detail data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetBukuByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM tbbuku WHERE kodeBuku = @kode"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil detail data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' Mengecek apakah kode jenis sudah ada di database
    ''' </summary>
    Public Function KodeSudahAda(kode As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbjenis WHERE idJenis = @kode"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal validasi kode: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True ' Mengembalikan true untuk mencegah duplikasi jika error
        End Try
    End Function

    ''' <summary>
    ''' Menyimpan data jenis buku baru
    ''' </summary>
    Public Function SimpanJenis(kode As String, namaJenis As String) As Boolean
        Dim query As String = "INSERT INTO tbjenis (idJenis, jenis) VALUES (@kode, @jenis)"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@jenis", namaJenis)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Mengubah data jenis buku yang sudah ada
    ''' </summary>
    Public Function UbahJenis(kode As String, namaJenis As String) As Boolean
        Dim query As String = "UPDATE tbjenis SET jenis = @jenis WHERE idJenis = @kode"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@jenis", namaJenis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memperbarui data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Menghapus data jenis buku berdasarkan kode
    ''' </summary>
    Public Function HapusJenis(kode As String) As Boolean
        Dim query As String = "DELETE FROM tbjenis WHERE idJenis = @kode"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllBuku() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tbbuku.kodeBuku, tbjenis.jenis AS 'Jenis Buku', " &
            "tbbuku.judul, tbbuku.pengarang, tbbuku.penerbit, " &
            "tbbuku.jumlahBuku, tbbuku.deskripsi " &
            "FROM tbbuku " &
            "INNER JOIN tbjenis ON tbbuku.idJenis = tbjenis.idJenis " &
            "ORDER BY tbbuku.kodeBuku ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data buku: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function SearchBuku(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tbbuku.kodeBuku, tbjenis.jenis AS 'Jenis Buku', " &
            "tbbuku.judul, tbbuku.pengarang, tbbuku.penerbit, " &
            "tbbuku.jumlahBuku, tbbuku.deskripsi " &
            "FROM tbbuku " &
            "INNER JOIN tbjenis ON tbbuku.idJenis = tbjenis.idJenis " &
            "WHERE tbbuku.judul LIKE @keyword OR tbbuku.penerbit LIKE @keyword OR tbbuku.pengarang LIKE @keyword " &
            "ORDER BY tbbuku.kodeBuku ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data buku: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function KodeBukuSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbbuku WHERE kodeBuku = @kodeBuku"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeBuku", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function
    Public Function SimpanBuku(kode As String, idJenis As String, judul As String, pengarang As String, penerbit As String, jumlah As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbbuku (kodeBuku, idJenis, judul, pengarang, penerbit, jumlahBuku, deskripsi) " &
            "VALUES (@kode, @idJenis, @judul, @pengarang, @penerbit,@jumlah, @deskripsi)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@idJenis", idJenis)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@pengarang", pengarang)
                    cmd.Parameters.AddWithValue("@penerbit", penerbit)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data buku: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function UbahBuku(kode As String, idJenis As String, judul As String, pengarang As String, penerbit As String, jumlah As Integer, deskripsi As String) As Boolean
        Try
            Dim query As String = "UPDATE tbbuku SET idJenis = @idJenis, judul = @judul, pengarang = @pengarang, " &
            "penerbit = @penerbit, jumlahBuku = @jumlah, deskripsi = @deskripsi " &
            "WHERE kodeBuku = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@idJenis", idJenis)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@pengarang", pengarang)
                    cmd.Parameters.AddWithValue("@penerbit", penerbit)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data buku: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function HapusBuku(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbbuku WHERE kodeBuku = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data buku: " & ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module