Public Class bri

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Thank you for your order, your order is being processed", MsgBoxStyle.Information, "BIKERS2USED.")
        BIKERS2USED.Label18.Text = ("Name         :" & Purchase_Ducati.TextBox4.Text & vbNewLine & _
        "No.Telp   :" & Purchase_Ducati.TextBox3.Text & vbNewLine & _
        "Adress     :" & Purchase_Ducati.TextBox2.Text & vbNewLine & _
        "Status      :Your order is being processed")
        Me.Close()
        Payment.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub bri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class