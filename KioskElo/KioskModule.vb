Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing


Public Module KioskModule
    Dim _err As String = ""
    Public CountVDO = 0
    Public MaxCountVDO As Int32 = 120
    Public Mobile As String = ""
    Public CustomerTypeID As Int32 = 0
    Public DefaultCustomerTypeID As Int32 = 0
    Public Campang As String = ""
    Public Campaign_TH As String = ""
    Public Campaign_EN As String = ""
    Public Campaign_Desc1_EN As String = ""
    Public Campaign_Desc2_EN As String = ""
    Public Campaign_Desc1_TH As String = ""
    Public Campaign_Desc2_TH As String = ""
    Public Contact_ID As String = ""
    Public AssetID As String = ""
    Public NetworkType As String = ""
    Public Segment As String = ""
    Public CustomerName As String = ""
    Public Appointment As Boolean = False
    Public CustomerApp As Boolean = False   'เป็นลูกค้าที่สามารถจองได้หรือไม่
    Public CustomerAIS As Boolean = False    'เป็นเบอร์ลูกค้า AIS หรือไม่
    Public SMECorporateType As String = ""
    Public Lang_TH As Boolean = True
    Public ConnecetionPrimaryDB As Boolean = True
    Public Const AppointmentChannel As String = "1" 'Kiosk = 1

    'Kiosk Capture
    Public CustomerImageID As Long = 0
    Public CustomerPAGroup As String = ""
    Public CustomerURLCapture As String = ""
    Public CustomerURLCaptureDate As String = ""
    Public CustomerBOS As String = ""
    Public CustomerMobileStatus As String = ""
    Public CustomerCategory As String = ""
    Public CustomerBrandName As String = ""

    'Kiosk Config
    Public k_before As Int32 = 0
    Public k_late As Int32 = 0
    Public k_before_app As Int32 = 0
    Public k_cancel As Int32 = 0
    Public k_disable As Int32 = 0
    Public k_serve As Int32 = 0
    Public k_refresh As Int32 = 0
    Public k_vdo As Int32 = 0
    Public k_len As Int32 = 0
    Public k_no_show As Int32 = 0
    Public k_not_booked As Int32 = 0
    Public k_nud_k_no_show_within As Int32 = 0
    Public k_mobile1 As String = ""
    Public k_mobile2 As String = ""
    Public k_mobile3 As String = ""
    Public k_mobile4 As String = ""
    Public k_max_appointment As Int32 = 0
    Public s_close As String = ""
    Public k_before_close As Int32 = 0
    Public q_con_ldap As Boolean = False
    Public m_webservice_url As String = ""
    Public d_webservice_url As String = ""
    Public ShowCustomerCapture As String = ""

    'Kiosk Language
    Public Language As String = "TH"
    Public msgWarning As String = "ผิดพลาด"
    Public msgVerifyYourNumber As String = "กรุณาตรวจสอบหมายเลขโทรศัพท์"
    Public msgWrongNumberFormat As String = "รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง"
    Public msgQCancelled As String = "คิวนี้ได้ยกเลิกแล้ว" & vbCrLf & "กรุณากดเลือกทำรายการ" & vbCrLf & "เพื่อรับบริการอีกครั้ง"
    Public msgWantToBeServedNow As String = "ต้องการรับบริการทันทีหรือไม่?"
    Public itemname_field As String = "item_name_th"
    Public msgCancelAppointment As String = "ต้องการยกเลิก" & vbCrLf & "การจองคิวใช่หรือไม่ ?"
    Public msgCancelAppointmentCompleted1 As String = "ระบบได้ยกเลิกการจอง" & vbCrLf & "หมายเลข "
    Public msgCancelAppointmentCompleted2 As String = vbCrLf & vbCrLf & "เรียบร้อยแล้ว" & vbCrLf & "ขอบคุณค่ะ"
    Public msgGetTicketAndWaitForAppointment As String = "กรุณารับบัตรคิว" & vbCrLf & "และรอรับบริการประมาณ"
    Public msgAppointmentNotSupported As String = "ระบบไม่รองรับประเภทลูกค้านัด" & vbCrLf & "กรุณาติดต่อเจ้าหน้าที่"
    Public msgMaximum As String = "เลือกได้สูงสุด "
    Public msgService As String = " บริการ"
    Public msgHasAppointment As String = "มีนัดรับบริการ"
    Public msgDateon As String = "วันที่: "
    Public msgTimeAt As String = " เวลา: "
    Public msgAppTimeAt As String = " เวลา: "
    Public msgAtclock As String = " น."
    Public msgBefore As String = "ก่อน"
    Public msgCannotAppoinment As String = "ไม่สามารถทำรายการจองได้ "
    Public msgPleasmakeanew As String = " จะสามารถทำการจองได้อีกครั้ง "
    Public msgYouChooseTheService As String = "คุณเลือกบริการ"
    Public msgBookingNotAllowed As String = "ซึ่งระบบไม่ได้เปิดการจองไว้ในวันนี้"
    Public msgAppointmentAgain As String = " ในวันที่ "
    Public msgPleaseChooseOneService = "กรุณากดเลือกบริการ"
    Public msgOnward As String = " onwards"
    Public msgCannotBBooked As String = "ไม่สามารถทำการจองได้ "
    Public msgPlsWaitForAbout As String = "ประมาณ "
    Public msgMinute As String = " นาที"
    Public msgPlsChkQSetting As String = "กรุณาเช็คการตั้งค่าของหมายเลขคิว "
    Public msgOfService As String = "ของบริการ "
    Public msgAvailBookTime As String = "เวลาที่สามารถจองได้คือ "
    Public msgConfirm As String = "ยืนยัน"
    Public msgSureToBook As String = "ต้องการทำการจอง ใช่หรือไม่?"
    Public msgChooseAppTime As String = "กรุณาเลือกเวลาการจอง"
    Public msgAppTime As String = "ช่วงเวลาที่เลือกรับบริการ" & vbCrLf & "ไม่เพียงพอต่อบริการที่เลือก" & vbCrLf & vbCrLf & "กรุณาเลือกบริการใหม่"
    Public msgComeB4 As String = "กรุณามาก่อนเวลานัด "
    Public msgIfLate As String = "หากมาเกินเวลานัด" & vbCrLf & "คิวจะยกเลิกโดยอัติโนมัติ"
    Public msgBook As String = ""
    Public msgPleastaketicket As String = "กรุณารับบัตรคิว "
    '----
    Public msgYouwillservewith As String = ""
    Public msgYouwillbeservefirstwith As String = ""
    Public msgWithinabout As String = ""
    Public msgAbout As String = ""
    Public msgNotSufficientTime As String = ""
    Public msgPleaseSelectAppAgain As String = ""
    Public msgMaxServiceApp As String = "เลือกได้สูงสุด "
    Public msgHaveAppointment As String = "มีนัดรับบริการ"
    Public msgPleasArrive As String = "กรุณามาก่อนเวลานัด "
    Public msgMinuteBeforeApptime As String = " นาที"
    Public msgLateArriveThan As String = "Late arrival than the scheduled time"
    Public msgAutomaticCancelApp As String = "หากมาเกินเวลานัด คิวจะยกเลิกโดยอัตโนมัติ"
    Public msgMobile As String = ""
    Public msgDialogBtnOK As String = "ตกลง"

    Public msgDialogCaptureNotComplete As String = "ไม่สามารถบันทึกภาพได้!"

    Public ReadOnly Property ErrorMessage() As String
        Get
            Return _err
        End Get
    End Property

    Public Function GetStrToDateTime(ByVal DateIn As String) As DateTime
        'Convert ข้อมูลวันที่จาก String ในรูปแบบ YYYY-MM-DD HH:mm:ss.fff  ให้เป็นข้อมูล Datetime
        If DateIn.Trim <> "" Then
            Dim yy As Integer = DateIn.Substring(0, 4)
            Dim Mo As Integer = DateIn.Substring(5, 2)
            Dim dd As Integer = DateIn.Substring(8, 2)
            Dim HH As Integer = DateIn.Substring(11, 2)
            Dim mi As Integer = DateIn.Substring(14, 2)
            Dim ss As Integer = DateIn.Substring(17, 2)
            Dim ff As Integer = DateIn.Substring(20, 3)
            Return New Date(yy, Mo, dd, HH, mi, ss, ff)
        Else
            Return New Date(1, 1, 1)
        End If
    End Function
End Module


