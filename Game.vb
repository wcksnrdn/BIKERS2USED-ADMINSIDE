Public Class Game
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub movetostart()
        Dim startingpoint = Panel1.Location()
        startingpoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingpoint)
    End Sub

    Private Sub wall_mouseenter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        Jumpscare.Show()
        movetostart()
    End Sub

    Private Sub Label38_MouseEnter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.MouseEnter
        MessageBox.Show("Well Done!")
        Me.Close()
    End Sub

    Private Sub Game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
