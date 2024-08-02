Imports MySql.Data.MySqlClient
Imports System.Threading

Public Class daftarkaryawan
    Dim connStr As String = "server=localhost;user=root;database=dbkaryawan;port=3306"

    Sub isicombo1()
        With Me
            cboxjabatan.Items.Add("Presiden Director")
            cboxjabatan.Items.Add("Chief Executive Officer")
            cboxjabatan.Items.Add("Manager Sotfware Engineer")
            cboxjabatan.Items.Add("Manager Accounting")
            cboxjabatan.Items.Add("Staff")
            cboxjabatan.Items.Add("Cyber Security")
            cboxjabatan.Items.Add("Human Resources Development")
            cboxjabatan.Items.Add("Crew")
            cboxjabatan.Items.Add("Finance Consultant")
            cboxjabatan.Items.Add("Marketing Officer")
            cboxjabatan.Items.Add("UI/UX Designer")
            cboxjabatan.Items.Add("Project Manager")
            cboxjabatan.Items.Add("Office Boy")
        End With
    End Sub
    Private Sub daftarkaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isicombo1()
        txtnik.ReadOnly = True
        txtnik.Enabled = False
        txtPassword.PasswordChar = "*"
        txtConfirmpassword.PasswordChar = "*"

        ' Mengatur mode autocomplete menjadi Suggest untuk mengaktifkan fungsi otomatis pencarian
        cboxjabatan.AutoCompleteMode = AutoCompleteMode.Suggest
        cboxjabatan.AutoCompleteSource = AutoCompleteSource.ListItems

        ' Mengatur DropDownStyle menjadi DropDownList
        cboxjabatan.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BtnDaftar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btndaftar.Click
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                Dim tahunMasuk As String = DateTimePicker2.Value.ToString("yyMM")
                Dim password As String = txtPassword.Text
                Dim confirmPassword As String = txtConfirmpassword.Text
                Dim fullname As String = txtUsername.Text
                Dim jabatan As String = cboxjabatan.Text
                Dim gmail As String = TextBox1.Text
                Dim tempat_lahir As String = TextBox2.Text
                Dim tanggal_lahir As String = DateTimePicker1.Text
                Dim tanggal_masuk As String = DateTimePicker2.Text
                Dim random As New Random()
                Dim nomorAcak As String = random.Next(1000, 9999).ToString()
                Dim chat As String
                If password <> confirmPassword Then
                    lblstatus.Text = "Password tidak sama."
                    Return
                End If
                Dim nik As String = tahunMasuk & nomorAcak
                txtnik.Text = nik
                MsgBox("Pendaftaran berhasil! NIK Anda: " & nik, MsgBoxStyle.Information, "Informasi")


                Dim pesan As String = "Silakan isi:"

                If String.IsNullOrEmpty(fullname) Then
                    pesan &= " Nama Lengkap,"
                End If

                If String.IsNullOrEmpty(password) Then
                    pesan &= " PIN,"
                End If

                If String.IsNullOrEmpty(gmail) Then
                    pesan &= " Gmail,"
                End If

                If String.IsNullOrEmpty(tempat_lahir) Then
                    pesan &= " Tempat Lahir,"
                End If

                If String.IsNullOrEmpty(jabatan) Then
                    pesan &= " Jabatan,"
                End If

                pesan = pesan.TrimEnd(","c)

                ' Menampilkan pesan jika ada bidang yang tidak diisi
                If pesan <> "Silakan isi:" Then
                    MsgBox(pesan, MsgBoxStyle.Exclamation, "Peringatan")
                    Exit Sub
                End If
                MsgBox("Pendaftaran berhasil!", MsgBoxStyle.Information, "Informasi")
                
    ' Verifikasi password

    ' Simpan data ke database
                Dim query As String = "INSERT INTO tblkaryawan (PIN, nama_karyawan, NIK, jabatan, gmail_karyawan, tempat_lahir, tanggal_lahir, tanggal_masuk) VALUES (@PIN, @nama_karyawan, @NIK, @jabatan, @gmail_karyawan, @tempat_lahir, @tanggal_lahir, @tanggal_masuk)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@PIN", password)
                    cmd.Parameters.AddWithValue("@nama_karyawan", fullname)
                    cmd.Parameters.AddWithValue("@NIK", nik)
                    cmd.Parameters.AddWithValue("@jabatan", jabatan)
                    cmd.Parameters.AddWithValue("@gmail_karyawan", gmail)
                    cmd.Parameters.AddWithValue("@tempat_lahir", tempat_lahir)
                    cmd.Parameters.AddWithValue("@tanggal_lahir", tanggal_lahir)
                    cmd.Parameters.AddWithValue("@tanggal_masuk", tanggal_masuk)
                    cmd.ExecuteNonQuery()


                    txtPassword.Text = ""
                    txtConfirmpassword.Text = ""
                    txtUsername.Text = ""
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    cboxjabatan.Text = ""
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
            Dim query As String = "SELECT COUNT(*) FROM tblkaryawan WHERE nama lengkap = @nama_karyawan"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@nama_karyawan", username)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged
        txtnik.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Btndaftar_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndaftar.MouseEnter
        Btndaftar.Cursor = Cursors.Hand
    End Sub

    Private Sub Btndaftar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndaftar.MouseLeave
        Btndaftar.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Cursor = Cursors.Default
    End Sub

    Private Sub txtnik_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.MouseEnter
        txtnik.Cursor = Cursors.No
    End Sub

    Private Sub txtnik_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.MouseLeave
        txtnik.Cursor = Cursors.Default
    End Sub

    Private Sub btnlihatpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatpassword.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnlihatkonfirmasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihatkonfirmasi.Click
        If txtConfirmpassword.PasswordChar = "*" Then
            txtConfirmpassword.PasswordChar = ""
        Else
            txtConfirmpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loginkaryawan.Show()
        Me.Hide()
    End Sub
End Class