Public Class foto_2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Sub tampilgambar1()
        If PictureBox1.Visible = False Then
            PictureBox1.Visible = True
            btnsembunyi1.Visible = True
            btntampil1.Visible = False


        End If
    End Sub

    Sub sembunyigambar1()
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            btnsembunyi1.Visible = False
            btntampil1.Visible = True
        End If
    End Sub

    Sub tampilgambar2()
        If PictureBox2.Visible = False Then
            PictureBox2.Visible = True
            btnsembunyi2.Visible = True
            btntampil2.Visible = False

        End If
    End Sub
    Sub sembunyigambar2()
        If PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            btnsembunyi2.Visible = False
            btntampil2.Visible = True

        End If
    End Sub

    Private Sub btntampil1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntampil1.Click
        Call tampilgambar1()
    End Sub

    Private Sub btnsembunyi1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsembunyi1.Click
        Call sembunyigambar1()
    End Sub

    Private Sub foto_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call sembunyigambar1()
        Call sembunyigambar2()
    End Sub

    Private Sub btntampil2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntampil2.Click
        Call tampilgambar2()
    End Sub

    Private Sub btnsembunyi2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsembunyi2.Click
        Call sembunyigambar2()
    End Sub
End Class