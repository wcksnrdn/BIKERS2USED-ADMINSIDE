Imports System.Media
Imports System.Data.SqlClient
Public Class BIKERS2USED
    Public loggedIn As Boolean = False
    Public loggedInUsername As String
    Public loggedInFullname As String
    Private Sub BIKERS2USED_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

        Private Sub UpdateUI()
            If loggedIn Then
            lbllogin.Visible = False
            lbldaftar.Visible = False
                lblWelcome.Visible = True
            lblwelcome.Text = "Selamat datang, " & vbNewLine & _
 loggedInFullname & "!"
            lblusername.Visible = True
            lblusername.Text = "Profil: " & loggedInUsername
            Else
            lbllogin.Visible = True
            lbldaftar.Visible = True
                lblWelcome.Visible = False
            lblusername.Visible = False
            GroupBox2.Visible = False
            End If
        End Sub

    ' Fungsi untuk mengambil informasi login dari form login
    Public Sub SetLoginInfo(ByVal username As String, ByVal fullname As String)
        loggedInUsername = username
        loggedInFullname = fullname
        loggedIn = True
        UpdateUI()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button3.Left > 0 - Button3.Width Then
            Button3.Left -= 1
        Else : Button3.Left = Me.ClientSize.Width
        End If
        If Button5.Left > 0 - Button5.Width Then
            Button5.Left -= 1
        Else : Button5.Left = Me.ClientSize.Width
        End If
        If Button6.Left > 0 - Button6.Width Then
            Button6.Left -= 1
        Else : Button6.Left = Me.ClientSize.Width
        End If
        If Button7.Left > 0 - Button7.Width Then
            Button7.Left -= 1
        Else : Button7.Left = Me.ClientSize.Width
        End If
        If Button8.Left > 0 - Button8.Width Then
            Button8.Left -= 1
        Else : Button8.Left = Me.ClientSize.Width
        End If
        If Button4.Left > 0 - Button4.Width Then
            Button4.Left -= 1
        Else : Button4.Left = Me.ClientSize.Width
        End If
        If Button9.Left > 0 - Button9.Width Then
            Button9.Left -= 1
        Else : Button9.Left = Me.ClientSize.Width
        End If
        If Button10.Left > 0 - Button10.Width Then
            Button10.Left -= 1
        Else : Button10.Left = Me.ClientSize.Width
        End If
        If Button11.Left > 0 - Button11.Width Then
            Button11.Left -= 1
        Else : Button11.Left = Me.ClientSize.Width
        End If
        If Button12.Left > 0 - Button12.Width Then
            Button12.Left -= 1
        Else : Button12.Left = Me.ClientSize.Width
        End If
        If Button13.Left > 0 - Button13.Width Then
            Button13.Left -= 1
        Else : Button13.Left = Me.ClientSize.Width
        End If
        If Button14.Left > 0 - Button14.Width Then
            Button14.Left -= 1
        Else : Button14.Left = Me.ClientSize.Width
        End If
        If Button15.Left > 0 - Button15.Width Then
            Button15.Left -= 1
        Else : Button15.Left = Me.ClientSize.Width
        End If
        If Button16.Left > 0 - Button16.Width Then
            Button16.Left -= 1
        Else : Button16.Left = Me.ClientSize.Width
        End If
        If Button17.Left > 0 - Button17.Width Then
            Button17.Left -= 1
        Else : Button17.Left = Me.ClientSize.Width
        End If
        If Button18.Left > 0 - Button18.Width Then
            Button18.Left -= 1
        Else : Button18.Left = Me.ClientSize.Width
        End If
        If Button19.Left > 0 - Button19.Width Then
            Button19.Left -= 1
        Else : Button19.Left = Me.ClientSize.Width
        End If
        If Button20.Left > 0 - Button20.Width Then
            Button20.Left -= 1
        Else : Button20.Left = Me.ClientSize.Width
        End If
    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Ducati.Show()
    End Sub

    Private Sub Button21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseEnter
        Button21.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button21_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.MouseLeave
        Button21.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Purchase_Ducati.Show()
    End Sub

    Private Sub Button22_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.MouseEnter
        Button22.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button22_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.MouseLeave
        Button22.FlatStyle = FlatStyle.Standard
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Purchase_Kawasaki.ShowDialog()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Me.Close()
        Button24.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        GroupBox1.Visible = True
        Button25.Visible = False
        Button26.Visible = True
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        GroupBox1.Visible = False
        Button25.Visible = True
        Button26.Visible = False
    End Sub

    Private Sub Label19_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogin.MouseEnter
        lbllogin.ForeColor = Color.Blue()
        lbllogin.Cursor = Cursors.Hand
    End Sub

    Private Sub Label19_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogin.MouseLeave
        lbllogin.ForeColor = Color.Black()
        lbllogin.Cursor = Cursors.Default
    End Sub

    Private Sub Label20_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldaftar.MouseEnter, Label20.MouseEnter
        lbldaftar.ForeColor = Color.Blue()
        lbldaftar.Cursor = Cursors.Hand
    End Sub

    Private Sub Label20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldaftar.MouseLeave
        lbldaftar.ForeColor = Color.Black()
        lbldaftar.Cursor = Cursors.Default
    End Sub

    Private Sub lbldaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbldaftar.Click
        DaftarAkun.ShowDialog()
    End Sub

    Private Sub Lbllogout_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbllogout.MouseEnter
        Lbllogout.ForeColor = Color.Blue()
        Lbllogout.Cursor = Cursors.Hand
    End Sub

    Private Sub Lbllogout_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbllogout.MouseLeave
        Lbllogout.ForeColor = Color.Black()
        Lbllogout.Cursor = Cursors.Default
    End Sub

    Private Sub Lbllogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbllogout.Click
        Dim result As DialogResult = MessageBox.Show("Anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            ' Logika logout
            loggedIn = False
            loggedInUsername = ""
            loggedInFullname = ""
            UpdateUI()
        End If
    End Sub

    Private Sub lbllogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbllogin.Click
        LoginAkun.ShowDialog()
    End Sub

    Private Sub lblusername_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusername.MouseEnter
        lblusername.ForeColor = Color.Blue()
        lblusername.Cursor = Cursors.Hand
    End Sub

    Private Sub lblusername_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusername.MouseLeave
        lblusername.ForeColor = Color.Black()
        lblusername.Cursor = Cursors.Default
    End Sub

    Private Sub lblusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusername.Click
        If GroupBox2.Visible = False Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Button23_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.MouseEnter
        Button23.FlatStyle = FlatStyle.Popup
    End Sub

    Private Sub Button23_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.MouseLeave
        Button23.FlatStyle = FlatStyle.Standard
    End Sub

End Class