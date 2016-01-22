
Imports System.Data.SqlClient
Imports KioskElo.Org.Mentalis.Files
Imports System.IO


Module Kiosk

    Public Const SoftwareName As String = "KioskElo"
    Public INIFileName As String = Application.StartupPath & "\Kiosk.ini"  'Parth ที่ใช้เก็บไฟล์ .ini
    
    
#Region "All Error"
    Sub showFormError(ByVal Message As String)
        Dim f As New frmErrorMessage
        f.txtMassage.Text = Message
        f.ShowDialog()
        f.Dispose()
    End Sub
#End Region

    Function ShowDialogBox(ByVal Text As String, ByVal HeadText As String, Optional ByVal btnYesNo As Boolean = False) As Boolean
        'Dim f As New frmDialogMsg
        If btnYesNo = True Then
            frmDialogMsg.btnOK.Visible = False
            frmDialogMsg.btnPrevious.Visible = False
            frmDialogMsg.btnMain.Visible = False
            frmDialogMsg.btnConfirm.Visible = True
            frmDialogMsg.btnCancel.Visible = True
        Else
            frmDialogMsg.btnConfirm.Visible = False
            frmDialogMsg.btnCancel.Visible = False
            frmDialogMsg.btnOK.Visible = False
            frmDialogMsg.btnPrevious.Visible = False
            frmDialogMsg.btnMain.Visible = True
            'frmDialogMsg.btnMain.Text = msgDialogBtnOK
        End If
        frmDialogMsg.Text = HeadText
        frmDialogMsg.lblText.Text = Text
        If frmDialogMsg.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            Return True
        End If
        Return False
    End Function


End Module
