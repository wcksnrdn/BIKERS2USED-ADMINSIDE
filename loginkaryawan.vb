Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class loginkaryawan

    Dim connStr As String = "server=localhost;user=root;database=dbkaryawan;port=3306"
    Dim connectionString As String = "server=localhost;user=root;database=dbkaryawan;port=3306;PIN=password"

    Dim conn As New MySqlConnection(connStr)

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        ' Mendapatkan informasi dari form login
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

        ' Mengecek apakah pengguna dengan username dan password tertentu ada di database
        If IsLoginValid(NIK, PIN) Then
            ' Jika pengguna ditemukan, tampilkan pesan sukses atau pindah ke form utama
            Dim fullname As String = GetFullnameByUsername(NIK)
            MessageBox.Show("Login berhasil! Selamat datang, " & fullname & "!", "BIKERS2USED")
            Me.Hide()
        Else
            ' Jika pengguna tidak ditemukan, tampilkan pesan kesalahan
            lblloginstatus.Text = "Username atau password salah!"
        End If
        BIKERS2USEDINTERNAL.ShowDialog()
        Me.Close()
    End Sub

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

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        daftarkaryawan.Show()
        Me.Hide()
    End Sub
End Class