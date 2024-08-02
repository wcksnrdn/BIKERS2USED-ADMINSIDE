Imports MySql.Data.MySqlClient
Public Class karyawanDB
    Dim sql As String
    Dim proses As New modul2
    Dim tblkaryawan As DataTable
    Public Mylistitem As ListViewItem
    Dim x As Integer
    Sub isicombo()
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
    Sub header()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("NIK", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nama Lengkap", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Jabatan", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Gmail", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tempat Lahir", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tanggal Lahir", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tanggal Masuk", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("PIN", 90, HorizontalAlignment.Center)
    End Sub
    Sub bersih()
        txtnama.Text = ""
        txtgmail.Text = ""
        txtpin.Text = ""
        cboxjabatan.Text = ""
        txtnik.Text = ""
        Call tampil()
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
            tblkaryawan = proses.ExecuteQuery("Select * from tblkaryawan")
            For i = 0 To tblkaryawan.Rows.Count - 1
                With tblkaryawan.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("NIK").ToString)
                    Mylistitem.SubItems.Add(.Item("nama_karyawan").ToString)
                    Mylistitem.SubItems.Add(.Item("jabatan").ToString)
                    Mylistitem.SubItems.Add(.Item("gmail_karyawan").ToString)
                    Mylistitem.SubItems.Add(.Item("tempat_lahir").ToString)
                    Mylistitem.SubItems.Add(.Item("tanggal_lahir").ToString)
                    Mylistitem.SubItems.Add(.Item("tanggal_masuk").ToString)
                    Mylistitem.SubItems.Add(.Item("PIN").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True

    End Sub
    Sub updatedata()
        sql = "Update tblkaryawan Set nama_karyawan = '" & txtnama.Text & _
            "', jabatan='" & cboxjabatan.Text & _
            "', gmail_karyawan='" & txtgmail.Text & _
            "', tempat_lahir='" & txttempatlahir.Text & _
            "', tanggal_lahir='" & tanggallahir.Text & _
            "', tanggal_masuk='" & tanggalmasuk.Text & _
            "', PIN='" & txtpin.Text & _
            "' Where NIK ='" & txtnik.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data Telah Diubah", "BIKER2USED", _
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call tampil()

    End Sub
    Sub hapus()
        sql = "Delete from tblkaryawan Where NIK = '" & txtnik.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data telah dihapus", "HAPUS", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub karyawanDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.SendToBack()
        Label8.SendToBack()
        Label9.SendToBack()
        Label13.SendToBack()
        txtpin.TextAlign = HorizontalAlignment.Center
        txtnik.TextAlign = HorizontalAlignment.Center
        tampil()
        Call isicombo()
        cboxjabatan.AutoCompleteMode = AutoCompleteMode.Suggest
        cboxjabatan.AutoCompleteSource = AutoCompleteSource.ListItems
        cboxjabatan.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Suggest
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        Me.txtnik.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub txtnik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnik.TextChanged
        If Len(txtnik.Text) < 8 Then Exit Sub
        tblkaryawan = proses.ExecuteQuery _
            ("Select * From tblkaryawan Where NIK='" & txtnik.Text & "'")
        If tblkaryawan.Rows.Count > 0 Then
            With Me
                .txtgmail.Text = tblkaryawan.Rows(0).Item("gmail_karyawan")
                .txtnama.Text = tblkaryawan.Rows(0).Item("nama_karyawan")
                .cboxjabatan.Text = tblkaryawan.Rows(0).Item("jabatan")
                .tanggalmasuk.Text = tblkaryawan.Rows(0).Item("tanggal_masuk")
                .txttempatlahir.Text = tblkaryawan.Rows(0).Item("tempat_lahir")
                .tanggallahir.Text = tblkaryawan.Rows(0).Item("tanggal_lahir")
                .txtpin.Text = tblkaryawan.Rows(0).Item("PIN")
            End With
        Else
            Call bersih()
            txtnik.Focus()
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim pesan As String
        pesan = MsgBox("Yakin akan dihapus ?", _
                        MsgBoxStyle.YesNo, "BIKERS2USED")
        If pesan = MsgBoxResult.Yes Then
            hapus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If Me.txtnik.Text = "" Then
            Exit Sub
        Else
            Call updatedata()
        End If

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
            If Me.ComboBox1.Text = "Nama" Then
                tblkaryawan = proses.ExecuteQuery("Select * from tblkaryawan " & " WHERE nama_karyawan LIKE '%" & TextBox4.Text & "%'")
            End If
            If Me.ComboBox1.Text = "Jabatan" Then
                tblkaryawan = proses.ExecuteQuery("Select * from tblkaryawan " & " WHERE jabatan LIKE '%" & TextBox4.Text & "%'")
            End If
            If Me.ComboBox1.Text = "NIK" Then
                tblkaryawan = proses.ExecuteQuery("Select * from tblkaryawan " & " WHERE NIK LIKE '%" & TextBox4.Text & "%'")
            End If
            For i = 0 To tblkaryawan.Rows.Count - 1
                With tblkaryawan.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("NIK").ToString)
                    Mylistitem.SubItems.Add(.Item("nama_karyawan").ToString)
                    Mylistitem.SubItems.Add(.Item("jabatan").ToString)
                    Mylistitem.SubItems.Add(.Item("gmail_karyawan").ToString)
                    Mylistitem.SubItems.Add(.Item("tempat_lahir").ToString)
                    Mylistitem.SubItems.Add(.Item("tanggal_lahir").ToString)
                    Mylistitem.SubItems.Add(.Item("tanggal_masuk").ToString)
                    Mylistitem.SubItems.Add(.Item("PIN").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True

    End Sub

    Private Sub cboxjabatan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxjabatan.SelectedIndexChanged

    End Sub
End Class