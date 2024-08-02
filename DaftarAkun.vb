Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class DaftarAkun
    Dim connStr As String = "server=localhost;user=root;database=dbakun;port=3306"
   
    Private Sub BtnDaftar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btndaftar.Click
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim confirmPassword As String = txtConfirmpassword.Text
                Dim fullname As String = TextBox1.Text ' Ambil nama lengkap dari TextBox

                ' Validasi kosong
                If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(confirmPassword) Then
                    MsgBox("Username dan Password harus diisi.", MsgBoxStyle.Exclamation, "BIKERSUSED")
                    Return
                End If

                ' Verifikasi password
                If password <> confirmPassword Then
                    lblstatus.Text = "Password tidak sama."
                    Return
                End If

                ' Periksa apakah username sudah terdaftar
                If IsUsernameExists(conn, username) Then
                    lblstatus.Text = "Username sudah terdaftar."
                    Return
                End If

                ' Simpan data ke database
                Dim query As String = "INSERT INTO tblakun (username, password, fullname) VALUES (@username, @password, @fullname)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@fullname", fullname)
                    cmd.ExecuteNonQuery()

                    'MessageBox.Show("Pendaftaran berhasil!")
                    txtPassword.Text = ""
                    txtConfirmpassword.Text = ""
                    txtUsername.Text = ""
                    TextBox1.Text = ""
                    Dim formLogin As New LoginAkun()
                    formLogin.Show()
                    Me.Hide()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function IsUsernameExists(ByVal connection As MySqlConnection, ByVal username As String) As Boolean
        If String.IsNullOrEmpty(username) Then
            Return False
        End If

        Try
            Dim query As String = "SELECT COUNT(*) FROM tblakun WHERE username = @username"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnLihatPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLihatKonfirmasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatkonfirmasi.Click
        If txtConfirmpassword.PasswordChar = "*" Then
            txtConfirmpassword.PasswordChar = ""
        Else
            txtConfirmpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub DaftarAkun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        txtConfirmpassword.PasswordChar = "*"
    End Sub

    Private Sub txtConfirmpassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConfirmpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btndaftar.Focus()
        End If
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Blue()
        Label6.Cursor = Cursors.Hand()
    End Sub

    Private Sub Label6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Gray()
        Label6.Cursor = Cursors.Default()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        LoginAkun.Show()
        Me.Close()
    End Sub

    Private Sub btnlihatkonfirmasi_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseEnter, btnlihatkonfirmasi.MouseEnter
        btnlihatkonfirmasi.Cursor = Cursors.Hand()
    End Sub

    Private Sub btnlihatkonfirmasi_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseLeave, btnlihatkonfirmasi.MouseLeave
        btnlihatkonfirmasi.Cursor = Cursors.Default()
    End Sub

    Private Sub btnlihatpassword_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseEnter
        btnlihatpassword.Cursor = Cursors.Hand()
    End Sub

    Private Sub btnlihatpassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.MouseLeave
        btnlihatpassword.Cursor = Cursors.Default()
    End Sub

    Private Sub Btndaftar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndaftar.MouseEnter
        Btndaftar.Cursor = Cursors.Hand()
    End Sub

    Private Sub Btndaftar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndaftar.MouseLeave
        Btndaftar.Cursor = Cursors.Default()
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Cursor = Cursors.Hand()
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Cursor = Cursors.Default()
    End Sub
End Class
