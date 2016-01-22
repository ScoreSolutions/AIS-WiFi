Imports System.Text
Imports System.IO
Imports KioskElo.Org.Mentalis.Files

Public Class frmInputIDCard
    Dim frm As New frmDemoAisWiFi
    Sub ClearForm()
        lblDisplayIDCard.Text = ""
        lblDisplayName.Text = ""
        Timer2.Enabled = True
        IsFinish = False
    End Sub

#Region "อ่านบัตรประชาชน"
    Private Delegate Sub myDelegateOne(ByVal data As String)
    Private myUpdateBoxThaiID As myDelegateOne
    'Private myUpdateBoxSex As myDelegateOne
    'Private myUpdateBoxNameThai As myDelegateOne
    Private myUpdateBoxNameEnglish As myDelegateOne
    Private myUpdateBoxDateOfBirth As myDelegateOne
    'Private myUpdateBoxAddress As myDelegateOne
    'Private myUpdateBoxIssueDate As myDelegateOne
    'Private myUpdateBoxIssuePlace As myDelegateOne
    'Private myUpdateBoxNumber As myDelegateOne

    Private Sub frmInputIDCard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(0, 0)
      

        myUpdateBoxThaiID = AddressOf WriteBoxThaiID
        'myUpdateBoxSex = AddressOf WriteBoxSex
        'myUpdateBoxNameThai = AddressOf WriteBoxNameThai
        myUpdateBoxNameEnglish = AddressOf WriteBoxNameEnglish
        myUpdateBoxDateOfBirth = AddressOf WriteBoxDateOfBirth
        'myUpdateBoxAddress = AddressOf WriteBoxAddress
        'myUpdateBoxIssueDate = AddressOf WriteBoxIssueDate
        'myUpdateBoxIssuePlace = AddressOf WriteBoxIssuePlace
        'myUpdateBoxNumber = AddressOf WriteBoxNumber

        Try
            LoopRec = 0
            ClearForm()

            If Not SerialPort1.IsOpen Then
                Dim ini As New IniReader(Application.StartupPath & "\Kiosk.ini")
                ini.Section = "IDCardReader"
                SerialPort1.PortName = ini.ReadString("IDCardComPort")
                SerialPort1.BaudRate = ini.ReadString("IDCardBaudRate")
                SerialPort1.Open()
                'buttonConnect.Text = "DISCONNECT"
                SerialPort1.DiscardInBuffer()
                ini = Nothing
            Else
                SerialPort1.Close()
                'buttonConnect.Text = "CONNECT"
            End If

            frm.Show()
            'frm.Visible = False
            Me.BringToFront()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WriteBoxThaiID(ByVal msg As String)
        lblDisplayIDCard.Text = msg
    End Sub
    '===================================================================================================
    '         * Write text Sex 
    '         *===================================================================================================

    'Private Sub WriteBoxSex(ByVal msg As String)
    '    'txt.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text box Name Thai 
    '         *===================================================================================================

    Private Sub WriteBoxNameEnglish(ByVal msg As String)
        If msg = "" Then
            lblDisplayName.Text = ""
        Else
            lblDisplayName.Text = msg
        End If
    End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxNameEnglish(ByVal msg As String)
    '    If msg = "" Then
    '        txtFName_EN.Text = ""
    '        txtLName_EN.Text = ""
    '    Else
    '        txtFName_EN.Text = msg.Split(" ")(0) & " " & msg.Split(" ")(1)
    '        txtLName_EN.Text = msg.Split(" ")(3)
    '    End If

    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    Private Sub WriteBoxDateOfBirth(ByVal msg As String)
        lblDisplayDateOfBirth.Text = msg
    End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxAddress(ByVal msg As String)
    '    If msg.Trim <> "" Then
    '        Dim Tmp() As String = Split(msg, " ")
    '        Dim City As String = Tmp(Tmp.Length - 1).Trim
    '        Dim _Addr As String = msg.Replace(City, "").Trim

    '        txtAddress.Text = _Addr
    '        txtCity.Text = Replace(City, "จังหวัด", "")
    '        txtCountry.Text = "ไทย"
    '    Else
    '        txtAddress.Text = ""
    '        txtCity.Text = ""
    '        txtCountry.Text = ""
    '    End If
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxIssueDate(ByVal msg As String)
    '    If msg = "" Then
    '        txtIssueDate.Text = ""
    '        txtExpDate.Text = ""
    '    Else
    '        txtIssueDate.Text = msg.Split("-")(0)
    '        txtExpDate.Text = msg.Split("-")(1)
    '    End If

    '    txtCusName.Focus()
    '    txtCusName.Select()
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxIssuePlace(ByVal msg As String)
    '    'txt.Text = msg
    'End Sub
    '===================================================================================================
    '         * Write text box Name English 
    '         *===================================================================================================

    'Private Sub WriteBoxNumber(ByVal msg As String)
    '    'textBoxNumber.Text = msg
    'End Sub
    Dim LengthBuffer As Integer = 255
    Dim LoopRec As Integer = 0

    'Public recieve As Byte() = New Byte(255) {}
    'Public DataID As Byte() = New Byte(255) {}
    'Public DataGPS As Byte() = New Byte(255) {}
    Public BuffComPort As Byte() = New Byte(9999) {}
    Public DataCom As String() = New String(8) {}
    'Public DataThai As String() = New String(8) {}
    Public BuffCom As String = ""

    Public buffer As Integer = 0
    Public Length As Integer = 0
    Public BuffLength As Integer = 0

    Public FlagEnd As Boolean = False
    Public FlagSum As Boolean = False
    Public CheckSum As Byte = &H0
    Public DataSum As Byte = &H0
    Public LengthGPS As Integer = 0
    Public LengthSum As Integer = 0
    Public TimeOut As Integer
    Public IsFinish As Boolean = False

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If SerialPort1.IsOpen Then
            Dim Len As Integer = SerialPort1.BytesToRead
            TimeOut = 1
            If Len >= 10000 Then
                Len = 0
            End If
            If BuffLength >= 10000 Then
                ' Check length data for limit  
                ' Initial Buffer length 
                BuffLength = 0
            End If

            SerialPort1.Read(BuffComPort, BuffLength, Len)
            BuffLength += Len



            
            If BuffLength >= 1 Then
                'ต้องการ ให้ LoopRec แค่ 6 พอ เพราะ LoopRec=5 คือ ที่อยู่

                If Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec < 9 Then

                    BuffCom = Encoding.GetEncoding(&H36A).GetString(BuffComPort, 0, BuffLength)
                    BuffLength = 0
                    SerialPort1.DiscardInBuffer()
                    If BuffCom = "REMOVE" & vbCr Then
                        LoopRec = 0
                        'Me.Invoke(myUpdateBoxThaiID, "")
                        'Me.Invoke(myUpdateBoxSex, "")
                        'Me.Invoke(myUpdateBoxNameThai, "")
                        'Me.Invoke(myUpdateBoxNameEnglish, "")
                        'Me.Invoke(myUpdateBoxDateOfBirth, "")
                        ' Me.Invoke(myUpdateBoxAddress, "")
                        'Me.Invoke(myUpdateBoxIssueDate, "")
                        'Me.Invoke(myUpdateBoxIssuePlace, "")
                        'Me.Invoke(myUpdateBoxNumber, "")
                        'pcCapture.Image = Nothing
                    Else

                        'Try
                        '    Select Case LoopRec
                        '        Case 0
                        '            Me.Invoke(myUpdateBoxThaiID, BuffCom)
                        '            'Case 1
                        '            '    Me.Invoke(myUpdateBoxSex, BuffCom)
                        '            'Case 2
                        '            '    Me.Invoke(myUpdateBoxNameThai, BuffCom)
                        '        Case 3
                        '            Me.Invoke(myUpdateBoxNameEnglish, BuffCom)
                        '            'Case 4
                        '            '    Me.Invoke(myUpdateBoxDateOfBirth, BuffCom)
                        '            'Case 5
                        '            '    Me.Invoke(myUpdateBoxAddress, BuffCom)
                        '            'Case 6
                        '            '    Me.Invoke(myUpdateBoxIssueDate, BuffCom)
                        '            'Case 7
                        '            '    Me.Invoke(myUpdateBoxIssuePlace, BuffCom)
                        '            'Case 8
                        '            '    Me.Invoke(myUpdateBoxNumber, BuffCom)
                        '    End Select
                        'Catch ex As Exception

                        'End Try

                        DataCom(LoopRec) = BuffCom
                        LoopRec += 1

                        If LoopRec = 9 Then
                            Me.Invoke(myUpdateBoxThaiID, DataCom(0))
                            Me.Invoke(myUpdateBoxNameEnglish, DataCom(3))
                            Me.Invoke(myUpdateBoxDateOfBirth, DataCom(4))

                            SerialPort1.DiscardInBuffer()

                            If lblDisplayName.Text <> "" AndAlso lblDisplayIDCard.Text <> "" And LoopRec = 9 Then
                                SerialPort1.Close()
                                IsFinish = True
                            End If


                            BuffLength = 0
                            LoopRec = 0
                        End If
                        'Console.WriteLine("AAAAAAAA " & LoopRec & " $$$$ " & BuffCom)
                        
                    End If
                ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso BuffLength >= 5120 AndAlso LoopRec = 9 Then
                    'ElseIf Chr(BuffComPort(BuffLength - 1)) = Chr(13) AndAlso LoopRec = 6 Then

                    Me.Invoke(myUpdateBoxThaiID, DataCom(0))
                    ''Me.Invoke(myUpdateBoxSex, DataCom(1))
                    ''Me.Invoke(myUpdateBoxNameThai, DataCom(2))
                    Me.Invoke(myUpdateBoxNameEnglish, DataCom(3))
                    Me.Invoke(myUpdateBoxDateOfBirth, DataCom(4))
                    'Me.Invoke(myUpdateBoxAddress, DataCom(5))
                    'Me.Invoke(myUpdateBoxIssueDate, DataCom(6))
                    'Me.Invoke(myUpdateBoxIssuePlace, DataCom(7))
                    'Me.Invoke(myUpdateBoxNumber, DataCom(8))

                    'Dim picture As New MemoryStream(BuffComPort)
                    'pcCapture.Image = Image.FromStream(picture)
                    'pcCapture.SizeMode = PictureBoxSizeMode.StretchImage

                    SerialPort1.DiscardInBuffer()

                    If lblDisplayName.Text <> "" AndAlso lblDisplayIDCard.Text <> "" And lblDisplayDateOfBirth.Text <> "" And LoopRec = 9 Then
                        SerialPort1.Close()
                        IsFinish = True
                    End If


                    BuffLength = 0
                    LoopRec = 0


                End If
            End If

        End If

        

    End Sub
#End Region


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If IsFinish = True Then

            Timer2.Enabled = False
            'Dim frm As New frmDemoAisWiFi
            frm.fullname = lblDisplayName.Text.Split(" ")(1) & " " & lblDisplayName.Text.Split(" ")(3)
            frm.title = lblDisplayName.Text.Split(" ")(0)
            frm.country = "TH"
            Dim year As Integer = 0
            Try
                year = CInt(lblDisplayDateOfBirth.Text.Split("/")(2)) - 543
            Catch ex As Exception
            End Try

            frm.year = year
            frm.passport = lblDisplayIDCard.Text
            frm.DisplayInfo()
            'frm.Visible = True
            'frm.Activate()
            frm.BringToFront()
            Timer2.Enabled = False
            Me.Close()
           
        End If
    End Sub

    Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
        Dim frm As New frmRegister
        frm.Show()
        frm.BringToFront()
        Me.Close()
    End Sub
End Class