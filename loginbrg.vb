Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class loginbrg

    Dim connStr As String = "server=localhost;user=root;database=dbkaryawan;port=3306"
    Dim connectionString As String = "server=localhost;user=root;database=dbkaryawan;port=3306;PIN=password"

    Dim conn As New MySqlConnection(connStr)
    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim NIK As String = txtUsername.Text
        Dim PIN As String = txtPassword.Text
        Dim pesan As String = "Silakan isi:"
        If String.IsNullOrEmpty(PIN) Then
            pesan &= " PIN,"
        End If
        If String.IsNullOrEmpty(NIK) Then
            pesan &= " NIK,"
        End If
        pesan = pesan.TrimEnd(","c)

        ' Menampilkan pesan jika ada bidang yang tidak diisi
        If pesan <> "Silakan isi:" Then
            MsgBox(pesan, MsgBoxStyle.Exclamation, "BIKERS2USED")
            Exit Sub
        End If
        ' Membuat koneksi ke database
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try
        If Not String.IsNullOrEmpty(NIK) AndAlso Not String.IsNullOrEmpty(PIN) Then
            If IsLoginValid(NIK, PIN) Then
                ' Jika pengguna ditemukan dan PIN valid, dapatkan jabatan dan tampilkan pesan sesuai jabatan
                Dim fullname As String = GetFullnameByUsername(NIK)
                Dim jabatan As String = GetJabatanFromDatabase(NIK)

                If Not String.IsNullOrEmpty(jabatan) Then
                    ' Menentukan jabatan yang diizinkan untuk login
                    Dim jabatanDiperbolehkan As List(Of String) = New List(Of String) From {"Staff", "Manager Accounting", "Presiden Director", "Chief Executive Officer", "Manager Software Engineer", "Cyber Security", "Human Resources Development", "Finance Consultant", "Project Manager"}

                    ' Memeriksa apakah jabatan sesuai dengan yang diizinkan (tanpa memperhatikan case dan spasi)
                    If jabatanDiperbolehkan.Any(Function(j) String.Equals(j, jabatan, StringComparison.OrdinalIgnoreCase)) Then
                        ' Menampilkan informasi jabatan asli dengan huruf besar dan spasi
                        MsgBox("Login berhasil! Selamat datang, " & fullname & "!", MsgBoxStyle.Information, "BIKER2USED")
                        pelangganDB.Show()
                        Me.Hide()
                    Else
                        ' Jika jabatan tidak sesuai dengan yang diizinkan, tampilkan pesan kesalahan
                        MsgBox("Anda tidak memiliki izin untuk login.", MsgBoxStyle.Exclamation, "Peringatan")
                        ' Kode untuk proses login gagal
                    End If
                Else
                    ' Jika jabatan tidak ditemukan, tampilkan pesan kesalahan
                    MsgBox("NIK tidak terdaftar.", MsgBoxStyle.Exclamation, "Peringatan")
                    ' Kode untuk proses login gagal
                End If
            Else
                ' Jika pengguna tidak ditemukan atau PIN salah, tampilkan pesan kesalahan
                lblloginstatus.Text = "NIK tidak terdaftar atau PIN salah!"
            End If
        Else
            ' Jika NIK atau PIN kosong, tampilkan pesan kesalahan
            lblloginstatus.Text = "Mohon isi NIK dan PIN."
        End If
        Me.Close()
    End Sub
    Private Function GetJabatanFromDatabase(ByVal nik As String) As String
        Dim jabatan As String = ""

        Using connection As MySqlConnection = New MySqlConnection(connStr)
            Try
                connection.Open()

                Dim query As String = "SELECT jabatan FROM tblkaryawan WHERE NIK = @NIK"
                Using command As MySqlCommand = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NIK", nik)
                    Dim reader As MySqlDataReader = command.ExecuteReader()
                    Console.WriteLine("Query: " & query)
                    Debug.Print("jabatan dari database: " & jabatan)
                    Console.WriteLine("Jabatan dari database: " & jabatan)
                    Console.WriteLine("NIK yang digunakan: " & nik)
                    If reader.Read() Then
                        jabatan = reader("jabatan").ToString()
                    End If
                End Using
            Catch ex As Exception
                ' Tampilkan pesan kesalahan jika ada
                Console.WriteLine("Terjadi kesalahan: " & ex.Message)
            End Try
        End Using

        Return jabatan
    End Function
    Private Function IsLoginValid(ByVal username As String, ByVal password As String) As Boolean
        Dim query As String = "SELECT * FROM tblkaryawan WHERE NIK = @NIK AND PIN = @PIN"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@NIK", username)
        cmd.Parameters.AddWithValue("@PIN", password)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Return reader.Read()
        Finally
            conn.Close()
        End Try
    End Function

    Private Function GetFullnameByUsername(ByVal username As String) As String
        ' Gantilah dengan logika atau query sesuai kebutuhan untuk mendapatkan nama lengkap dari tabel
        ' Sesuaikan dengan struktur tabel yang kamu miliki
        Dim query As String = "SELECT nama_karyawan FROM tblkaryawan WHERE NIK = @NIK"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@NIK", username)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Return reader("nama_karyawan").ToString()
            Else
                Return ""
            End If
        Finally
            conn.Close()
        End Try
    End Function
    Private Sub Btnlogin_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.MouseEnter
        Btnlogin.Cursor = Cursors.Hand
    End Sub

    Private Sub Btnlogin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.MouseLeave
        Btnlogin.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Btnlogin.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub loginkaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub btnlihatpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class
