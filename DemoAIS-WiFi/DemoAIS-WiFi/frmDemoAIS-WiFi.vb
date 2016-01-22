Public Class frmDemoAisWiFi

    Private Sub frmDemoAisWiFi_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Interval = 1000
        wb1.Navigate("file:///D:/_A/_AIS/AIS-WIFI/AIS-WiFi/WebRegisterAOT.html")

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Application.DoEvents()
        If wb1.Url.ToString = "file:///D:/_A/_AIS/AIS-WIFI/AIS-WiFi/WebRegisterAOT.html" Then
            wb1.Document.All.Item("title").SetAttribute("Value", "mr")
            wb1.Document.All.Item("name").SetAttribute("Value", "อัครวัฒน์ พุทธจันทร์")
            wb1.Document.All.Item("email").SetAttribute("Value", "akkarawatp@hotmail.com")
            wb1.Document.All.Item("country").SetAttribute("Value", "TH")
            wb1.Document.All.Item("year").SetAttribute("Value", "23")
            wb1.Document.All.Item("passport").SetAttribute("Value", "3410101141069")
            wb1.Document.All.Item("mobile").SetAttribute("Value", "0901989551")
            wb1.Document.All.Item("agree").SetAttribute("checked", "checked")

            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        wb1.Navigate("file:///D:/_A/_AIS/AIS-WIFI/AIS-WiFi/WebRegisterSuccess.html")
    End Sub
End Class
