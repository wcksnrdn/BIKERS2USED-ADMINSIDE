Imports MySql.Data.MySqlClient
Public Class BIKERS2USED_DB
    Dim sql As String
    Dim proses As New ClsKoneksi
    Dim tbmotor As DataTable
    Public Mylistitem As ListViewItem
    Dim x As Integer
    Sub header()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Kode", 70, HorizontalAlignment.Center)
        ListView1.Columns.Add("Merk", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nama", 95, HorizontalAlignment.Center)
        ListView1.Columns.Add("Jenis", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Unit", 70, HorizontalAlignment.Center)
        ListView1.Columns.Add("Harga", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Deskripsi", 400, HorizontalAlignment.Center)
    End Sub
    Sub tampil()
        Dim i As Integer
        Dim urut As Integer
        Dim jml As Double
        urut = 1
        jml = 0
        Try
            If ListView1.Items.Count > 0 Then
                ListView1.Clear()
            End If
            ListView1.View = View.Details
            Call header()
            tbmotor = proses.ExecuteQuery("Select * from tbmotor")
            For i = 0 To tbmotor.Rows.Count - 1
                With tbmotor.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("Kode").ToString)
                    Mylistitem.SubItems.Add(.Item("Merk").ToString)
                    Mylistitem.SubItems.Add(.Item("Nama").ToString)
                    Mylistitem.SubItems.Add(.Item("Jenis").ToString)
                    Mylistitem.SubItems.Add(.Item("Unit").ToString)
                    Mylistitem.SubItems.Add(.Item("Harga").ToString)
                    Mylistitem.SubItems.Add(.Item("Deskripsi").ToString)
                    Mylistitem.SubItems.Add(.Item("Foto").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True

    End Sub
    Sub tampilfoto()
        Me.Display.ImageLocation = Me.txtdisplay.Text
        Me.Display.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    Sub cari()
        Dim i As Integer
        Dim urut As Integer
        Dim jml As Double
        urut = 1
        jml = 0
        Try
            If ListView1.Items.Count > 0 Then
                ListView1.Clear()
            End If
            ListView1.View = View.Details
            Call header()
            sql = "Select * from tbmotor Where Merk like '%" & TextBox4.Text & "%'"
            tbmotor = proses.ExecuteQuery(sql)
            For i = 0 To tbmotor.Rows.Count - 1
                With tbmotor.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("Kode").ToString)
                    Mylistitem.SubItems.Add(.Item("Merk").ToString)
                    Mylistitem.SubItems.Add(.Item("Nama").ToString)
                    Mylistitem.SubItems.Add(.Item("Jenis").ToString)
                    Mylistitem.SubItems.Add(.Item("Unit").ToString)
                    Mylistitem.SubItems.Add(.Item("Harga").ToString)
                    Mylistitem.SubItems.Add(.Item("Deskripsi").ToString)
                    Mylistitem.SubItems.Add(.Item("Foto").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True
    End Sub

    Private Sub BIKERS2USED_DB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        CenterToScreen()
        Call aktif()
        Me.cbojenis.Items.Add("Sport Bike")
        Me.cbojenis.Items.Add("Hyper Bike")
        Me.cbojenis.Items.Add("Naked Bike")
    End Sub

    Sub nonaktif()
        tblsimpan.Enabled = False
        txtnama.Enabled = False
        txtdeskripsi.Enabled = False
        txtmerk.Enabled = False
        cbojenis.Enabled = False
        txtnama.BackColor = Color.White
        txtdeskripsi.BackColor = Color.White
        txtmerk.BackColor = Color.White
        txtharga.BackColor = Color.White
        txtunit.BackColor = Color.White
    End Sub

    Sub aktif()
        txtnama.Enabled = True
        txtmerk.Enabled = True
        cbojenis.Enabled = True
        txtkode.Enabled = True
        txtdeskripsi.Enabled = True
        txtunit.Enabled = True
        txtnama.BackColor = Color.Aquamarine
        txtdeskripsi.BackColor = Color.Aquamarine
        txtkode.BackColor = Color.Aquamarine
        txtmerk.BackColor = Color.Aquamarine
        txtharga.BackColor = Color.Aquamarine
        txtunit.BackColor = Color.Aquamarine
    End Sub

    Sub bersih()
        txtnama.Text = ""
        txtdeskripsi.Text = ""
        txtmerk.Text = ""
        cbojenis.Text = ""
        txtharga.Text = ""
        txtunit.Text = ""
        Call tampil()
        nonaktif()
        tblsimpan.Enabled = False : tblhapus.Enabled = False
        tblbaru.Enabled = False : tblkeluar.Enabled = True
    End Sub

    Sub simpan()
        sql = "INSERT INTO tbmotor (Kode, Merk, Nama, Jenis, Harga, Deskripsi, Foto) VALUES (@Kode, @Merk, @Nama, @Jenis, @Harga, @Deskripsi, @Foto)"

        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("@Kode", MySqlDbType.VarChar) With {.Value = txtkode.Text})
        parameters.Add(New MySqlParameter("@Merk", MySqlDbType.VarChar) With {.Value = txtmerk.Text})
        parameters.Add(New MySqlParameter("@Nama", MySqlDbType.VarChar) With {.Value = txtnama.Text})
        parameters.Add(New MySqlParameter("@Jenis", MySqlDbType.VarChar) With {.Value = cbojenis.Text})
        parameters.Add(New MySqlParameter("@Unit", MySqlDbType.VarChar) With {.Value = txtunit.text})
        parameters.Add(New MySqlParameter("@Harga", MySqlDbType.VarChar) With {.Value = txtharga.Text})
        parameters.Add(New MySqlParameter("@Deskripsi", MySqlDbType.VarChar) With {.Value = txtdeskripsi.Text})
        parameters.Add(New MySqlParameter("@Foto", MySqlDbType.VarChar) With {.Value = txtdisplay.Text.Replace("\", "/")})

        proses.ExecuteNonQueryWithParameters(sql, parameters)

        MessageBox.Show("Data Baru Telah Disimpan", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call bersih()
    End Sub

    Sub updatedata()
        sql = "Update tbmotor Set Merk = '" & txtmerk.Text & _
            "', Nama='" & txtnama.Text & _
            "', Jenis='" & cbojenis.Text & _
            "', Harga='" & txtharga.Text & _
            "', Unit='" & txtunit.Text & _
            "', Deskripsi='" & txtdeskripsi.Text & _
            "', Foto='" & txtdisplay.Text & _
            "' Where Kode ='" & txtkode.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data Telah Diubah", "BIKER2USED", _
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call tampil()

    End Sub

    Sub hapus()
        sql = "Delete from tbmotor Where Kode = '" & txtkode.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data telah dihapus", "HAPUS", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub

    Private Sub tblsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblsimpan.Click
        If Me.txtkode.Text = "" Then
            Exit Sub
        End If
        If Me.tblsimpan.Text = "Simpan" Then
            Call simpan()
        Else
            Call updatedata()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        Me.txtkode.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Me.tblhapus.Enabled = True
        Me.tblbatal.Enabled = True
        tblsimpan.Enabled = True
    End Sub

    Private Sub txtkode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkode.TextChanged
        txtkode.TextAlign = HorizontalAlignment.Center
        If Len(txtkode.Text) < 3 Then Exit Sub
        tbmotor = proses.ExecuteQuery _
            ("Select * From tbmotor Where Kode='" & txtkode.Text & "'")
        If tbmotor.Rows.Count > 0 Then
            With Me
                .txtmerk.Text = tbmotor.Rows(0).Item("Merk")
                .txtnama.Text = tbmotor.Rows(0).Item("Nama")
                .cbojenis.Text = tbmotor.Rows(0).Item("Jenis")
                .txtunit.Text = tbmotor.Rows(0).Item("Unit")
                .txtharga.Text = tbmotor.Rows(0).Item("Harga")
                .txtdeskripsi.Text = tbmotor.Rows(0).Item("Deskripsi")
                .txtdisplay.Text = tbmotor.Rows(0).Item("Foto")
                Call tampilfoto()
            End With
            Display.Visible = True
            Call aktif()
            txtmerk.Enabled = True
            txtmerk.Focus()
            tblsimpan.Text = "Update"
        Else
            Call bersih()
            Call aktif()
            txtkode.Focus()
            tblsimpan.Text = "Simpan" : tblsimpan.Enabled = True
            tblhapus.Enabled = False : tblbatal.Enabled = True
        End If
    End Sub

    Private Sub tblhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblhapus.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan dihapus ?", _
                        MsgBoxStyle.YesNo, "BIKERS2USED")
        If pesan = MsgBoxResult.Yes Then
            hapus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tblkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblkeluar.Click
        Me.Close()
    End Sub

    Private Sub tblbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblbatal.Click
        Call nonaktif()
        Call bersih()
        tblbaru.Enabled = True
        tblsimpan.Enabled = True
        tblsimpan.Text = "Simpan"
        txtkode.Text = ""
        txtkode.Enabled = True
    End Sub

    Private Sub tblbaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblbaru.Click
        Me.txtkode.Focus()
        Call aktif()
        Me.txtkode.Text = ""
        Me.txtkode.Focus()
        Me.txtnama.Text = ""
        Me.txtmerk.Text = ""
        Me.cbojenis.Text = ""
        Me.txtdeskripsi.Text = ""
        Me.txtharga.Text = ""
        Me.txtdisplay.Text = ""
        Me.txtunit.Text = ""
        Me.Display.Visible = False
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim i As Integer
        Dim urut As Integer
        Dim jml As Double
        urut = 1
        jml = 0
        Try
            If ListView1.Items.Count > 0 Then
                ListView1.Clear()
            End If
            ListView1.View = View.Details
            Call header()
            If Me.ComboBox1.Text = "Merk" Then
                tbmotor = proses.ExecuteQuery("Select * from tbmotor " & " WHERE Merk LIKE '%" & TextBox4.Text & "%'")
            End If
            If Me.ComboBox1.Text = "Jenis" Then
                tbmotor = proses.ExecuteQuery("Select * from tbmotor " & " WHERE Jenis LIKE '%" & TextBox4.Text & "%'")
            End If
            If Me.ComboBox1.Text = "Nama" Then
                tbmotor = proses.ExecuteQuery("Select * from tbmotor " & " WHERE Nama LIKE '%" & TextBox4.Text & "%'")
            End If
            For i = 0 To tbmotor.Rows.Count - 1
                With tbmotor.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("Kode").ToString)
                    Mylistitem.SubItems.Add(.Item("Merk").ToString)
                    Mylistitem.SubItems.Add(.Item("Nama").ToString)
                    Mylistitem.SubItems.Add(.Item("Jenis").ToString)
                    Mylistitem.SubItems.Add(.Item("Unit").ToString)
                    Mylistitem.SubItems.Add(.Item("Harga").ToString)
                    Mylistitem.SubItems.Add(.Item("Deskripsi").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True
    End Sub

    Private Sub txtkode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmerk.Focus()
        End If
    End Sub

    Private Sub txtmerk_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmerk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtmerk.Text = "" Then
                MsgBox("Tidak Boleh Kosong", MsgBoxStyle.Critical, "BIKERS2USED")
                txtmerk.Focus()
            End If
            txtnama.Focus()
        End If
    End Sub

    Private Sub txtnama_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtdeskripsi.Focus()
        End If
    End Sub

    Private Sub btndisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplay.Click
        OpenFileDialog1.Filter = "Foto|*.Jpg;*.Jpeg;*.Png;*.bmp|Semua Berkas|*.*"
        OpenFileDialog1.ShowDialog()
        Display.Visible = True
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.txtdisplay.Text = OpenFileDialog1.FileName
        Call tampilfoto()
    End Sub

    Private Sub txtmerk_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmerk.TextChanged
        Dim kata As String
        kata = txtmerk.Text
        txtmerk.Text = kata.Replace(" ", "")
        txtmerk.SelectionStart = txtmerk.Text.Length
        txtmerk.Text = txtmerk.Text.ToUpper
    End Sub

    Private Sub txtkode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkode.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And _
           ("1234567890.").IndexOf(e.KeyChar) = -1) Or _
       (e.KeyChar = "." And txtkode.Text.ToCharArray() _
        .Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtunit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtunit.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And _
           ("1234567890.").IndexOf(e.KeyChar) = -1) Or _
       (e.KeyChar = "." And txtkode.Text.ToCharArray() _
        .Count(Function(c) c = ".") > 0) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tblcetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblcetak.Click
        Laporan.ShowDialog()
    End Sub
End Class