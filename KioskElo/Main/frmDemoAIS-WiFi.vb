Public Class frmDemoAisWiFi

    Dim _title, _name, _email, _country, _year, _passport, _mobile, _agree As String

    WriteOnly Property title() As String
        Set(value As String)

            Select Case value.ToLower
                Case "miss"
                    _title = "ms"
                Case "mr"
                    _title = "ms"
                Case "mrs"
                    _title = "mrs"
                Case Else
                    _title = "title"
            End Select

        End Set
    End Property
    WriteOnly Property fullname() As String
        Set(value As String)
            _name = value
        End Set
    End Property
    'WriteOnly Property email() As String
    '    Set(value As String)
    '        _email = value
    '    End Set
    'End Property
    WriteOnly Property country() As String
        Set(value As String)
            _country = value
        End Set
    End Property
    WriteOnly Property year() As String
        Set(value As String)
            _year = value
        End Set
    End Property
    WriteOnly Property passport() As String
        Set(value As String)
            _passport = value
        End Set
    End Property
    'WriteOnly Property mobile() As String
    '    Set(value As String)
    '        _mobile = value
    '    End Set
    'End Property
    'WriteOnly Property agree() As String
    '    Set(value As String)
    '        _agree = value
    '    End Set
    'End Property

    Function GetYearID(stryear As String) As String
        Dim ret As String = ""

        For i As Integer = 0 To 109
            If stryear = 2005 - i Then
                Return i
            End If
        Next

        Return ret
    End Function


    Private Sub frmDemoAisWiFi_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Interval = 1000
        wb1.Navigate("file:///C:/AIS-WiFi/WebRegisterAOT.html")
        Timer1.Enabled = True
    End Sub

    Public Sub DisplayInfo()
        Application.DoEvents()
        wb1.Document.All.Item("title").SetAttribute("Value", _title)
        wb1.Document.All.Item("name").SetAttribute("Value", _name)
        wb1.Document.All.Item("country").SetAttribute("Value", _country)
        wb1.Document.All.Item("year").SetAttribute("Value", GetYearID(_year))
        wb1.Document.All.Item("passport").SetAttribute("Value", _passport)
        Timer1.Enabled = True     
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs)
        'Application.DoEvents()
        'If wb1.Url.ToString = "file:///C:/AIS-WiFi/WebRegisterAOT.html" Then
        '    wb1.Document.All.Item("title").SetAttribute("Value", "mr")
        '    wb1.Document.All.Item("name").SetAttribute("Value", "อัครวัฒน์ พุทธจันทร์")
        '    wb1.Document.All.Item("email").SetAttribute("Value", "akkarawatp@hotmail.com")
        '    wb1.Document.All.Item("country").SetAttribute("Value", "TH")
        '    wb1.Document.All.Item("year").SetAttribute("Value", "23")
        '    wb1.Document.All.Item("passport").SetAttribute("Value", "3410101141069")
        '    wb1.Document.All.Item("mobile").SetAttribute("Value", "0901989551")
        '    wb1.Document.All.Item("agree").SetAttribute("checked", "checked")

        '    Timer1.Enabled = True
        'End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' wb1.Navigate("file:///C:/AIS-WiFi/WebRegisterSuccess.html")

        'Threading.Thread.Sleep(5000)

        'wb1.Document.All.Item("title").SetAttribute("Value", _title)
        'wb1.Document.All.Item("name").SetAttribute("Value", _name)
        'wb1.Document.All.Item("country").SetAttribute("Value", _country)
        'wb1.Document.All.Item("year").SetAttribute("Value", GetYearID(_year))
        'wb1.Document.All.Item("passport").SetAttribute("Value", _passport)

        Timer1.Enabled = False
    End Sub

    Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click

        Dim frm As New frmRegister
        frm.Show()
        frm.BringToFront()
        Try
            frmInputIDCard.Close()
        Catch ex As Exception
        End Try

        Try
            frmInputPassport.Close()
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub
End Class
