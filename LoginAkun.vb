Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class LoginAkun
    Dim connStr As String = "server=localhost;user=root;database=dbakun;port=3306"
    Dim connectionString As String = "server=localhost;user=root;database=dbakun;port=3306;password=password"

    Dim conn As New MySqlConnection(connStr)

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        ' Mendapatkan informasi dari form login
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Membuat koneksi ke database
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            conn.Close()
        End Try

        ' Mengecek apakah pengguna dengan username dan password tertentu ada di database
        If IsLoginValid(username, password) Then
            ' Jika pengguna ditemukan, tampilkan pesan sukses atau pindah ke form utama
            Dim fullname As String = GetFullnameByUsername(username)
            MessageBox.Show("Login berhasil! Selamat datang, " & fullname & "!", "BIKERS2USED")
            Me.Hide()

            ' Set informasi login di form utama
            BIKERS2USED.SetLoginInfo(username, fullname)
            BIKERS2USED.Show()
        Else
            ' Jika pengguna tidak ditemukan, tampilkan pesan kesalahan
            lblloginstatus.Text = "Username atau password salah!"
        End If
    End Sub

    Private Function IsLoginValid(ByVal username As String, ByVal password As String) As Boolean
        Dim query As String = "SELECT * FROM tblakun WHERE username = @username AND password = @password"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

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
        Dim query As String = "SELECT fullname FROM tblakun WHERE username = @username"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)

        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Return reader("fullname").ToString()
            Else
                Return ""
            End If
        Finally
            conn.Close()
        End Try
    End Function


    Private Sub btnlihatpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.Click
        If txtPassword.UseSystemPasswordChar Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Blue()
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Gray()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Dim formDaftar As New DaftarAkun()
        formDaftar.Show()
        Me.Hide()
        Label7.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Masuk__Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnlihatpassword_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseEnter
        btnlihatpassword.Cursor = Cursors.Hand
    End Sub

    Private Sub btnlihatpassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseLeave
        btnlihatpassword.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub Btnlogin_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.MouseEnter
        Btnlogin.Cursor = Cursors.Hand
    End Sub

    Private Sub Btnlogin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.MouseLeave
        Btnlogin.Cursor = Cursors.Default
    End Sub

    Private Sub Label6_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.Cursor = Cursors.Hand
    End Sub

    Private Sub Label6_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.Cursor = Cursors.Default
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        DaftarAkun.Show()
        Label7.Visible = False
    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter
        Label7.ForeColor = Color.Blue()
        Label7.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Label7.ForeColor = Color.Gray()
        Label7.Cursor = Cursors.Default
    End Sub
End Class
