Imports MySqlConnector

Module DataModule
    Public Function GetAllSparepart() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama, stok, harga FROM sparepart ORDER BY id ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchSparepart(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama, stok, harga FROM sparepart " &
                                 "WHERE id LIKE @keyword OR nama LIKE @keyword OR stok LIKE @keyword OR harga LIKE @keyword " &
                                 "ORDER BY id ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM sparepart WHERE id = @id"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanSparepart(nama As String, stok As Integer, harga As Decimal) As Boolean
        Try
            Dim query As String = "INSERT INTO sparepart (nama, stok, harga) VALUES (@nama, @stok, @harga)"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahSparepart(kode As String, nama As String, stok As Integer, harga As Decimal) As Boolean
        Try
            Dim query As String = "UPDATE sparepart SET nama = @nama, stok = @stok, harga = @harga WHERE id = @id"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusSparepart(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM sparepart WHERE id = @id"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllServis() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT s.id_servis, s.nama_pelanggan, s.no_polisi, s.jenis_kerusakan, " &
                "       sp.nama AS nama_sparepart, s.jumlah_pakai, s.biaya_jasa, s.tanggal, " &
                "       (s.jumlah_pakai * sp.harga + s.biaya_jasa) AS total_biaya " &
                "FROM servis s " &
                "INNER JOIN sparepart sp ON s.id_sparepart = sp.id " &
                "ORDER BY s.id_servis ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data servis: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchServis(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT s.id_servis, s.nama_pelanggan, s.no_polisi, s.jenis_kerusakan, " &
                "       sp.nama AS nama_sparepart, s.jumlah_pakai, s.biaya_jasa, s.tanggal, " &
                "       (s.jumlah_pakai * sp.harga + s.biaya_jasa) AS total_biaya " &
                "FROM servis s " &
                "INNER JOIN sparepart sp ON s.id_sparepart = sp.id " &
                "WHERE s.nama_pelanggan LIKE @kw OR s.no_polisi LIKE @kw OR s.jenis_kerusakan LIKE @kw " &
                "ORDER BY s.id_servis ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data servis: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanServis(namaPelanggan As String, noPolisi As String,
                                  jenisKerusakan As String, idSparepart As Integer,
                                  jumlahPakai As Integer, biayaJasa As Decimal,
                                  tanggal As Date) As Boolean
        Using conn = GetConnection()
            conn.Open()
            Dim tx = conn.BeginTransaction()
            Try
                ' 1. Cek stok sparepart cukup
                Dim qCekStok As String = "SELECT stok FROM sparepart WHERE id = @id"
                Dim stokSekarang As Integer = 0
                Using cmd As New MySqlCommand(qCekStok, conn, tx)
                    cmd.Parameters.AddWithValue("@id", idSparepart)
                    stokSekarang = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If stokSekarang < jumlahPakai Then
                    MessageBox.Show("Stok sparepart tidak mencukupi!" & vbNewLine &
                                    "Stok tersedia: " & stokSekarang & " unit.",
                                    "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    tx.Rollback()
                    Return False
                End If

                ' 2. Insert ke tabel servis
                Dim qInsert As String =
                    "INSERT INTO servis (nama_pelanggan, no_polisi, jenis_kerusakan, id_sparepart, jumlah_pakai, biaya_jasa, tanggal) " &
                    "VALUES (@nama, @nopol, @jenis, @idsp, @jml, @jasa, @tgl)"
                Using cmd As New MySqlCommand(qInsert, conn, tx)
                    cmd.Parameters.AddWithValue("@nama", namaPelanggan)
                    cmd.Parameters.AddWithValue("@nopol", noPolisi)
                    cmd.Parameters.AddWithValue("@jenis", jenisKerusakan)
                    cmd.Parameters.AddWithValue("@idsp", idSparepart)
                    cmd.Parameters.AddWithValue("@jml", jumlahPakai)
                    cmd.Parameters.AddWithValue("@jasa", biayaJasa)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.ExecuteNonQuery()
                End Using

                ' 3. Kurangi stok sparepart
                Dim qKurangi As String = "UPDATE sparepart SET stok = stok - @jml WHERE id = @id"
                Using cmd As New MySqlCommand(qKurangi, conn, tx)
                    cmd.Parameters.AddWithValue("@jml", jumlahPakai)
                    cmd.Parameters.AddWithValue("@id", idSparepart)
                    cmd.ExecuteNonQuery()
                End Using

                tx.Commit()
                Return True

            Catch ex As Exception
                tx.Rollback()
                MessageBox.Show("Gagal menyimpan data servis: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function


    Public Function UbahServis(idServis As Integer, namaPelanggan As String, noPolisi As String,
                                jenisKerusakan As String, idSparepart As Integer,
                                jumlahPakai As Integer, biayaJasa As Decimal,
                                tanggal As Date) As Boolean
        Using conn = GetConnection()
            conn.Open()
            Dim tx = conn.BeginTransaction()
            Try
                ' 1. Ambil data lama (id_sparepart & jumlah_pakai)
                Dim qLama As String = "SELECT id_sparepart, jumlah_pakai FROM servis WHERE id_servis = @id"
                Dim idSpLama As Integer = 0
                Dim jumlahLama As Integer = 0
                Using cmd As New MySqlCommand(qLama, conn, tx)
                    cmd.Parameters.AddWithValue("@id", idServis)
                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            idSpLama = dr.GetInt32(0)
                            jumlahLama = dr.GetInt32(1)
                        End If
                    End Using
                End Using

                ' 2. Kembalikan stok sparepart lama
                Dim qKembali As String = "UPDATE sparepart SET stok = stok + @jml WHERE id = @id"
                Using cmd As New MySqlCommand(qKembali, conn, tx)
                    cmd.Parameters.AddWithValue("@jml", jumlahLama)
                    cmd.Parameters.AddWithValue("@id", idSpLama)
                    cmd.ExecuteNonQuery()
                End Using

                ' 3. Cek stok baru cukup
                Dim qCekStok As String = "SELECT stok FROM sparepart WHERE id = @id"
                Dim stokSekarang As Integer = 0
                Using cmd As New MySqlCommand(qCekStok, conn, tx)
                    cmd.Parameters.AddWithValue("@id", idSparepart)
                    stokSekarang = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If stokSekarang < jumlahPakai Then
                    MessageBox.Show("Stok sparepart tidak mencukupi!" & vbNewLine &
                                    "Stok tersedia: " & stokSekarang & " unit.",
                                    "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    tx.Rollback()
                    Return False
                End If

                ' 4. Update tabel servis
                Dim qUpdate As String =
                    "UPDATE servis SET nama_pelanggan=@nama, no_polisi=@nopol, jenis_kerusakan=@jenis, " &
                    "id_sparepart=@idsp, jumlah_pakai=@jml, biaya_jasa=@jasa, tanggal=@tgl " &
                    "WHERE id_servis=@id"
                Using cmd As New MySqlCommand(qUpdate, conn, tx)
                    cmd.Parameters.AddWithValue("@nama", namaPelanggan)
                    cmd.Parameters.AddWithValue("@nopol", noPolisi)
                    cmd.Parameters.AddWithValue("@jenis", jenisKerusakan)
                    cmd.Parameters.AddWithValue("@idsp", idSparepart)
                    cmd.Parameters.AddWithValue("@jml", jumlahPakai)
                    cmd.Parameters.AddWithValue("@jasa", biayaJasa)
                    cmd.Parameters.AddWithValue("@tgl", tanggal.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@id", idServis)
                    cmd.ExecuteNonQuery()
                End Using

                ' 5. Kurangi stok sparepart baru
                Dim qKurangi As String = "UPDATE sparepart SET stok = stok - @jml WHERE id = @id"
                Using cmd As New MySqlCommand(qKurangi, conn, tx)
                    cmd.Parameters.AddWithValue("@jml", jumlahPakai)
                    cmd.Parameters.AddWithValue("@id", idSparepart)
                    cmd.ExecuteNonQuery()
                End Using

                tx.Commit()
                Return True

            Catch ex As Exception
                tx.Rollback()
                MessageBox.Show("Gagal mengubah data servis: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function HapusServis(idServis As Integer) As Boolean
        Using conn = GetConnection()
            conn.Open()
            Dim tx = conn.BeginTransaction()
            Try
                ' 1. Ambil data servis yang akan dihapus
                Dim qLama As String = "SELECT id_sparepart, jumlah_pakai FROM servis WHERE id_servis = @id"
                Dim idSpLama As Integer = 0
                Dim jumlahLama As Integer = 0
                Using cmd As New MySqlCommand(qLama, conn, tx)
                    cmd.Parameters.AddWithValue("@id", idServis)
                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            idSpLama = dr.GetInt32(0)
                            jumlahLama = dr.GetInt32(1)
                        End If
                    End Using
                End Using

                ' 2. Hapus data servis
                Dim qHapus As String = "DELETE FROM servis WHERE id_servis = @id"
                Using cmd As New MySqlCommand(qHapus, conn, tx)
                    cmd.Parameters.AddWithValue("@id", idServis)
                    cmd.ExecuteNonQuery()
                End Using

                ' 3. Kembalikan stok sparepart
                Dim qKembali As String = "UPDATE sparepart SET stok = stok + @jml WHERE id = @id"
                Using cmd As New MySqlCommand(qKembali, conn, tx)
                    cmd.Parameters.AddWithValue("@jml", jumlahLama)
                    cmd.Parameters.AddWithValue("@id", idSpLama)
                    cmd.ExecuteNonQuery()
                End Using

                tx.Commit()
                Return True

            Catch ex As Exception
                tx.Rollback()
                MessageBox.Show("Gagal menghapus data servis: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function
    Public Function GetSparepartUntukCombo() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama FROM sparepart WHERE stok > 0 ORDER BY nama ASC"
            Using conn = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar sparepart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetHargaSparepart(idSparepart As Integer) As Decimal
        Try
            Dim query As String = "SELECT harga FROM sparepart WHERE id = @id"
            Using conn = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idSparepart)
                    Dim hasil = cmd.ExecuteScalar()
                    If hasil IsNot Nothing Then Return Convert.ToDecimal(hasil)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return 0
    End Function

End Module