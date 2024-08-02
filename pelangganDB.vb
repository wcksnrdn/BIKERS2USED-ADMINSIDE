Imports MySql.Data.MySqlClient
Public Class pelangganDB
    Dim sql As String
    Dim proses As New modul3
    Dim tblakun As DataTable
    Public Mylistitem As ListViewItem
    Dim x As Integer
    Sub header()
        ListView1.Columns.Add("No", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("kode", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nama Lengkap", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Username", 200, HorizontalAlignment.Center)
        ListView1.Columns.Add("Password", 200, HorizontalAlignment.Center)
    End Sub
    Sub bersih()
        txtnama.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
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
            tblakun = proses.ExecuteQuery("Select * from tblakun")
            For i = 0 To tblakun.Rows.Count - 1
                With tblakun.Rows(i)
                    Mylistitem = ListView1.Items.Add(urut)
                    Mylistitem.SubItems.Add(.Item("kode").ToString)
                    Mylistitem.SubItems.Add(.Item("fullname").ToString)
                    Mylistitem.SubItems.Add(.Item("username").ToString)
                    Mylistitem.SubItems.Add(.Item("password").ToString)
                End With
                urut = urut + 1
            Next
        Catch ex As Exception
            MsgBox("Program error" & vbCrLf & Err.Description)
        End Try
        Me.ListView1.FullRowSelect = True

    End Sub
    Sub updatedata()
        sql = "Update tblakun Set fullname = '" & txtnama.Text & _
            "', password='" & TextBox2.Text & _
            "' Where username ='" & TextBox1.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data Telah Diubah", "BIKER2USED", _
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call tampil()

    End Sub
    Sub hapus()
        sql = "Delete from tblakun Where username = '" & TextBox1.Text & "'"
        proses.ExecuteNonQuery(sql)
        MessageBox.Show("Data telah dihapus", "HAPUS", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call bersih()
    End Sub
    Private Sub pelangganDB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        Call tampil()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        Me.txtkode.Text = ListView1.SelectedItems(0).SubItems(1).Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        If Me.TextBox1.Text = "" Then
            Exit Sub
        Else
            Call updatedata()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtkode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkode.TextChanged
        If Len(txtkode.Text) > 4 Then Exit Sub
        tblakun = proses.ExecuteQuery _
            ("Select * From tblakun Where kode='" & txtkode.Text & "'")
        If tblakun.Rows.Count > 0 Then
            With Me
                .TextBox1.Text = tblakun.Rows(0).Item("username")
                .TextBox2.Text = tblakun.Rows(0).Item("password")
                .txtnama.Text = tblakun.Rows(0).Item("fullname")
            End With
        Else
            Call bersih()
            TextBox1.Focus()
        End If
    End Sub
End Class