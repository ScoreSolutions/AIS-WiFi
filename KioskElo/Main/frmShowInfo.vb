Imports System.Drawing.Printing

Public Class frmShowInfo

    WriteOnly Property FullName() As String
        Set(value As String)
            lblDisplayName.Text = value
        End Set
    End Property

    WriteOnly Property IDCard() As String
        Set(value As String)
            lblDisplayIDCard.Text = value
        End Set
    End Property
    Private Sub frmShowInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        
    End Sub

    Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
        tmFinish.Enabled = True
        tmFinish.Start()
    End Sub

    Private Sub pbOK_Click(sender As Object, e As EventArgs) Handles pbOK.Click
        'Print Ticket
        lblMsg.Text = "Please receive your ticket."
        lblMsg.Text += vbNewLine & "Thank You."
        PanelMsg.Visible = True

        System.Threading.Thread.Sleep(1000)
        Application.DoEvents()

        Dim p As New PrintDocument
        p.PrintController = New Printing.StandardPrintController
        AddHandler p.PrintPage, AddressOf pd_PrintPage
        p.Print()

        tmFinish.Enabled = True
        tmFinish.Start()
    End Sub

    Private Sub tmFinish_Tick(sender As Object, e As EventArgs) Handles tmFinish.Tick
        frmRegister.Show()
        Me.Close()
    End Sub    

    Dim _lastPrintY As Integer = 0
    Protected ReadOnly Property lastPrintY() As Integer
        Get
            Return _lastPrintY
        End Get
    End Property

    Private Sub PrintText(ByVal txt As String, ByVal fnt As System.Drawing.Font, ByVal align As Align, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = e.Graphics.MeasureString(txt, fnt).Width
        Dim h As Integer = e.Graphics.MeasureString(txt, fnt).Height
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim brsh As New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 0, 0))
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawString(txt, fnt, brsh, x, y)
        'TextRenderer.DrawText(e.Graphics, txt, fnt, New Point(x, y), SystemColors.ControlText)
        _lastPrintY = y + h
    End Sub

    Private Sub PrintImage(ByVal img As System.Drawing.Image, ByVal align As Int16, ByRef e As System.Drawing.Printing.PrintPageEventArgs)
        Dim w As Integer = img.Width
        Dim h As Integer = img.Height
        Dim x As Integer = 0
        Dim y As Integer = 0
        Select Case align
            Case 0 'Default, LEFT
                x = e.PageSettings.PrintableArea.Left
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 1 'CENTER
                x = e.PageSettings.PrintableArea.Width / 2 - w / 2
                y = e.PageSettings.PrintableArea.Top + lastPrintY
            Case 2 'RIGHT
                x = e.PageSettings.PrintableArea.Right - w
                y = e.PageSettings.PrintableArea.Top + lastPrintY
        End Select
        e.Graphics.DrawImage(img, x, y)
        _lastPrintY = y + h
        img.Dispose()
    End Sub

    Protected Enum Align As Short
        Left = 0
        Center = 1
        Right = 2
    End Enum

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd.PrintPage
        Dim fn5 As New Font("Tahoma", 5, FontStyle.Regular)
        Dim fn8 As New Font("Tahoma", 8, FontStyle.Regular)
        Dim fn10 As New Font("Tahoma", 10, FontStyle.Regular)
        Dim fn12 As New Font("Tahoma", 12, FontStyle.Regular)
        Dim fn8b As New Font("Tahoma", 8, FontStyle.Bold)
        Dim fn9b As New Font("Tahoma", 9, FontStyle.Bold)
        Dim fn10b As New Font("Tahoma", 10, FontStyle.Bold)
        Dim fn12b As New Font("Tahoma", 12, FontStyle.Bold)
        Dim fn16b As New Font("Tahoma", 16, FontStyle.Bold)
        Dim fn14b As New Font("Tahoma", 14, FontStyle.Bold)
        Dim fn24b As New Font("Tahoma", 24, FontStyle.Bold)
        Dim fn36b As New Font("Tahoma", 36, FontStyle.Bold)
        Dim fn42b As New Font("Tahoma", 42, FontStyle.Bold)

        Dim DateNow As DateTime = DateTime.Now
        Dim vDateNowStr As String = DateNow.ToString("dd-MM-yyyy", New Globalization.CultureInfo("en-US"))
        Dim vTimeNowStr As String = DateNow.ToString("HH:mm")

        PrintImage(Image.FromFile("Logo_EN.bmp"), Align.Right, e)
        PrintText("Date: " & vDateNowStr & " | Time: " & vTimeNowStr, fn10b, Align.Center, e)
        PrintText(" ", fn5, Align.Center, e)

        Dim DisplayID As String = lblDisplayIDCard.Text.Substring(0, lblDisplayIDCard.Text.Length - 3) & "***"
        If lblCardType.Text.ToUpper = "IDCARD" Then
            PrintText("ID Card : " & DisplayID, fn10b, Align.Center, e)
        Else
            PrintText("Passport No : " & DisplayID, fn10b, Align.Center, e)
        End If
        PrintText(lblDisplayName.Text, fn10b, Align.Center, e)
        PrintText(" ", fn5, Align.Center, e)

        PrintText("Username", fn10b, Align.Center, e)
        If lblCardType.Text.ToUpper = "IDCARD" Then
            Dim DisplayUsername As String = ""
            DisplayUsername = Split(lblDisplayName.Text, " ")(1)
            PrintText(DisplayUsername.Substring(0, 4) & lblDisplayIDCard.Text.Substring(0, 4), fn12, Align.Center, e)
        Else
            PrintText(lblDisplayName.Text.Substring(0, 4) & lblDisplayIDCard.Text.Substring(0, 4), fn12, Align.Center, e)
        End If

        PrintText("Password", fn10b, Align.Center, e)
        PrintText(DateNow.ToString("HHmmssfff"), fn12, Align.Center, e)
        PrintText(" ", fn5, Align.Center, e)
        PrintText("Expired Time : " & DateNow.AddHours(24).ToString("dd MMM yy HH:mm:ss"), fn10b, Align.Center, e)
        PrintText("Period Time : 1 hour", fn10b, Align.Center, e)
        PrintText(" ", fn5, Align.Center, e)


        PrintText("Thank You.", fn12b, Align.Center, e)

        e.HasMorePages = False
    End Sub
End Class