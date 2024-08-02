Public Class Form1
    Dim originalsize As Size

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.SendToBack()
        Label2.SendToBack()
        Label3.SendToBack()
        Label4.SendToBack()
        Label5.SendToBack()
        Label6.SendToBack()
        Label7.SendToBack()
        Label8.SendToBack()
        Label9.SendToBack()
        Label10.SendToBack()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.Size = New Size(332, 258)
        Button1.BringToFront()
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.Size = New Size(232, 158)
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button2.Size = New Size(332, 258)
        Button2.BringToFront()
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        Button2.Size = New Size(232, 158)
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button3.Size = New Size(332, 258)
        Button3.BringToFront()
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        Button3.Size = New Size(232, 158)
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button4.Size = New Size(332, 258)
        Button4.BringToFront()
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        Button4.Size = New Size(232, 158)
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button5.Size = New Size(332, 258)
        Button5.BringToFront()
        Button5.Left -= 100
    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Button5.Size = New Size(232, 158)
        Button5.Left += 100
    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button6.Size = New Size(332, 258)
        Button6.BringToFront()
    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        Button6.Size = New Size(232, 158)
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button7.Size = New Size(332, 258)
        Button7.BringToFront()
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        Button7.Size = New Size(232, 158)
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button8.Size = New Size(332, 258)
        Button8.BringToFront()
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        Button8.Size = New Size(232, 158)
    End Sub

    Private Sub Button9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.MouseEnter
        Button9.Size = New Size(332, 258)
        Button9.BringToFront()
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        Button9.Size = New Size(232, 158)
    End Sub

    Private Sub Button10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.MouseEnter
        Button10.Size = New Size(332, 258)
        Button10.BringToFront()
        Button10.Left -= 100
    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        Button10.Size = New Size(232, 158)
        Button10.Left += 100
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("The Kawasaki Ninja ZX-25R is a 249 cc Ninja series sport bike introduced by the Japanese motorcycle manufacturer Kawasaki since 2020." & vbNewLine & _
                        "Top Speed; 199 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("The Kawasaki Ninja ZX-10R is a motorcycle in the Ninja sport bike series from the Japanese manufacturer Kawasaki, the successor to the Ninja ZX-9R. It was originally released in 2004 and has been updated and revised throughout the years. It combines an ultra-narrow chassis, low weight and radial brakes." & vbNewLine & _
                        "Top Speed; 300 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("The Kawasaki Ninja ZX-6R is a 636 cc class motorcycle in the Ninja sport bike series from the Japanese manufacturer Kawasaki. It was introduced in 1995, and has been constantly updated throughout the years in response to new products from Honda, Suzuki, and Yamaha." & vbNewLine & _
                        "Top Speed; 262 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("The Kawasaki Ninja ZX-4R is a 399 cc sports bike introduced by Japanese motorcycle manufacturer Kawasaki in 2023." & vbNewLine & _
                        "Top Speed; 207 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("The Kawasaki Ninja H2 is a supercharged supersport-class motorcycle in the Ninja sports bike series manufactured by Kawasaki, featuring a variable-speed centrifugal supercharger." & vbNewLine & _
                        "Top Speed; 400 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MsgBox("The Kawasaki Z800 is a Z series four-cylinder standard motorcycle made by Kawasaki from 2013 through 2016, replaced by the Z900 for 2017." & vbNewLine & _
                        "Top Speed; 262 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox("The Kawasaki Z900 is a standard motorcycle of the Kawasaki Z series made by Kawasaki since 2017. It replaced the Z800. It is the flagship Z series motorcycle besides the ZH2 from Kawasaki." & vbNewLine & _
                          "Top Speed; 195 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MsgBox("The Kawasaki Z1000 is a four-cylinder motorcycle introduced in 2003 with streetfighter or standard styling. The Z1000 was first introduced in 1977 superseding the previous 903 cc capacity Z1/Z900." & vbNewLine & _
                        "Top Speed; 258 KMH/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox("The Kawasaki Z650 is a naked motorcycle produced by Kawasaki Motors. It was introduced in 2016 as part of its Z series and entered production the following year, succeeding the Kawasaki Ninja 650R." & vbNewLine & _
                         "Top Speed; 212 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MsgBox("Kawasaki's legacy of creating motorcycles that have unrivaled performance, excitement, and Sugomi™ styling continues with a flagship model of the Kawasaki Z line of naked motorcycles, the Z H2 supercharged hypernaked. The next-level Z H2 SE hypernaked combines the balanced supercharged engine with premium components including Kawasaki Electronic Control Suspension (KECS) with Showa Skyhook EERA Technology and Brembo Stylema® calipers." & vbNewLine & _
                          "Top Speed; 280 KM/H", MsgBoxStyle.Information, "BIKERS2USED")
    End Sub

   
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Me.Close()
    End Sub
End Class
