Imports System.Drawing.Printing
Imports KioskElo.Org.Mentalis.Files
Imports System.IO


Public Class frmRegister


    Private Sub frmRegister_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Try
        '    Dim screen As Screen
        '    'Show the form on second screen
        '    screen = screen.AllScreens(1)
        '    frmVDO.StartPosition = FormStartPosition.Manual
        '    frmVDO.Location = screen.Bounds.Location + New Point(0, 0)
        '    frmVDO.Show()
        'Catch ex As Exception
        'End Try

        Try
            frmInputIDCard.Close()
        Catch ex As Exception
        End Try

        Try
            frmInputPassport.Close()
        Catch ex As Exception
        End Try

        Try
            frmDemoAisWiFi.Close()
        Catch ex As Exception
        End Try


        VDO.settings.setMode("loop", True)
        VDO.URL = Application.StartupPath & "\AIS.wmv"
        Try
            VDO.uiMode = "none"
            VDO.stretchToFit = True
            VDO.Ctlcontrols.play()
        Catch ex As Exception
        End Try
    End Sub


    Dim PrintQueue As Print
    Public Structure Print
        Dim QueueNo As String
        Dim Mobile As String
        Dim WaitingTime As String
        Dim ListService As String
        Dim CountQueue As String
        Dim AppTime As String
    End Structure

    Public Function getMyVersion() As String
        Dim version As System.Version = System.Reflection.Assembly.GetExecutingAssembly.GetName().Version
        Return version.Major & "." & version.Minor & "." & version.Build & "." & version.Revision
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub TimerVDO_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerVDO.Tick
        Try
            If CountVDO < MaxCountVDO Then
                CountVDO = CountVDO + 1
            Else
                TimerVDO.Enabled = False
                frmDialogMsg.Hide()
                If frmVDO.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    frmDialogMsg.Close()
                    frmVDO.Close()
                    CountVDO = 0
                    TimerVDO.Enabled = True
                End If
            End If
        Catch ex As Exception : End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbPassport.Click
        VDO.Ctlcontrols.stop()
        Me.Close()
        Dim frm As New frmInputPassport
        frm.ShowDialog()
    End Sub

    Private Sub pbIDCard_Click(sender As Object, e As EventArgs) Handles pbIDCard.Click
        VDO.Ctlcontrols.stop()
        Me.Close()
        Dim frm As New frmInputIDCard
        frm.ShowDialog()
    End Sub
End Class