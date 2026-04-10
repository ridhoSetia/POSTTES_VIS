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
            Return True ' Jika error, anggap ada agar tidak menimpa data sembarangan
        End Try
    End Function

    ' Simpan Data tanpa Kode/ID (karena Auto Increment)
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
End Module
