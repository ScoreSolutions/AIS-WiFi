Imports KioskElo.KioskModule
Module lang
    
    Public Sub ChangeLanguage()
        Select Case Language
            Case "EN"
                'frmRegister.pb.BackgroundImage = My.Resources.GB_1366_768
                frmRegister.pb.BackColor = Color.White
                frmDialogMsg.btnCancel.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                frmDialogMsg.btnConfirm.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                frmDialogMsg.btnOK.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)

                frmDialogMsg.btnCancel.Text = "Cancel"
                frmDialogMsg.btnConfirm.Text = "Confirm"
                frmDialogMsg.btnOK.Text = "OK"

                frmDialogMsg.btnMain.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
                frmDialogMsg.btnPrevious.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)

                frmDialogMsg.btnMain.Text = "Main menu"
                frmDialogMsg.btnPrevious.Text = "Previous"

                '-----------------
                msgNotSufficientTime = "Your selected time is not sufficient " & vbCrLf & "for your requested services "
                msgPleaseSelectAppAgain = " Please selected appointment time again "


                itemname_field = "item_name"
                msgWarning = "Attention"
                msgVerifyYourNumber = "Please Correct The Mobile Number."
                msgWrongNumberFormat = "Invalid Mobile Number"
                msgQCancelled = "This appointment has been cancelled." & vbCrLf & "Please make a new queue request."

                msgWantToBeServedNow = "Take the queue number " & vbCrLf & " to be served now?"
                msgCannotAppoinment = "cannot make an appointment at the moment"
                msgHasAppointment = "has an appointment for:"
                msgPleastaketicket = "Please take your queue ticket"
                msgCancelAppointment = "Are you sure you want" & vbCrLf & "to cancel the appointment?"
                msgCancelAppointmentCompleted1 = "The appointment for" & vbCrLf
                msgCancelAppointmentCompleted2 = vbCrLf & "has been cancelled." & vbCrLf & vbCrLf & "Thank You."
                msgGetTicketAndWaitForAppointment = "Please take your queue ticket" & vbCrLf & "You will be served within" & vbCrLf & "about "
                msgAppointmentNotSupported = "Appointment not Supported" & vbCrLf & "Please Contact Our Staff"
                msgMaximum = "Maximum "
                msgService = " services can be selected"
                msgOnward = " onwards"
                msgAppointmentAgain = " appointment again from "
                msgYouChooseTheService = "You choose the service"
                msgBookingNotAllowed = "Which is not be able to Book Today"
                msgPleaseChooseOneService = "Please select the services"
                msgCannotBBooked = "Cannot be Booked "
                msgPleasmakeanew = "Please make a new "
                msgYouwillservewith = "You will be served within"
                msgYouwillbeservefirstwith = "You will be served first with"
                msgWithinabout = "within about "
                msgAbout = "about "
                msgDateon = " on "
                msgTimeAt = " at "
                msgAppTimeAt = " at: "
                msgPleasArrive = "Please arrive "
                'msgAtclock = " น."
                msgMinute = " minutes"
                msgAvailBookTime = "Our soonest availability for your appointment is "
                msgConfirm = "Confirm"
                msgSureToBook = "Do you want to make the appointment with us?"
                msgChooseAppTime = "Choose Appointment Time"
                msgAppTime = "Your selected time is not sufficient" & vbCrLf & "for your requested services" & vbCrLf & vbCrLf & "Please select your appointment time again"
                msgComeB4 = "Please Do Not Late Over "
                msgIfLate = "If you are late" & vbCrLf & "Your Appointment will be Cancelled"
                msgBook = "Book"
                msgMaxServiceApp = "Max Services Appointment per Time "
                msgHaveAppointment = "You have an appointment for"
                msgMinuteBeforeApptime = " minutes before the appointment time."
                msgLateArriveThan = "Late arrival than the scheduled time"
                msgAutomaticCancelApp = "will automatically cancel the appointment."
                msgDialogBtnOK = "OK"
                '-----------------
            Case "TH"
                'frmRegister.pb.BackgroundImage = My.Resources.GB_1366_768
                frmRegister.pb.BackColor = Color.White
                'frmRegister.btnAppBack.Text = "หน้าหลัก"

                frmDialogMsg.btnCancel.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                frmDialogMsg.btnConfirm.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                frmDialogMsg.btnOK.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)

                frmDialogMsg.btnCancel.Text = "ยกเลิก"
                frmDialogMsg.btnConfirm.Text = "ตกลง"
                frmDialogMsg.btnOK.Text = "ตกลง"

                frmDialogMsg.btnMain.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)
                frmDialogMsg.btnPrevious.Font = New Font("Microsoft Sans Serif", 14, FontStyle.Bold)

                frmDialogMsg.btnMain.Text = "หน้าหลัก"
                frmDialogMsg.btnPrevious.Text = "ก่อนหน้า"

                '-----------------
                itemname_field = "item_name_th"
                msgWarning = "ผิดพลาด"
                msgVerifyYourNumber = "กรุณาตรวจสอบหมายเลขโทรศัพท์"
                msgWrongNumberFormat = "รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง"
                msgQCancelled = "คิวนี้ได้ยกเลิกแล้ว" & vbCrLf & "กรุณากดเลือกทำรายการ" & vbCrLf & "เพื่อรับบริการอีกครั้ง"
                msgWantToBeServedNow = "ต้องการรับบริการทันทีหรือไม่ ?"
                msgCancelAppointment = "ต้องการยกเลิก" & vbCrLf & "การจองคิว ใช่หรือไม่ ?"
                msgCancelAppointmentCompleted1 = "ระบบได้ยกเลิกการจอง" & vbCrLf & "หมายเลข "
                msgCancelAppointmentCompleted2 = vbCrLf & vbCrLf & "เรียบร้อยแล้ว" & vbCrLf & "ขอบคุณค่ะ"
                msgGetTicketAndWaitForAppointment = "กรุณารับบัตรคิว" & vbCrLf & "และรอรับบริการประมาณ "
                msgAppointmentNotSupported = "ระบบไม่รองรับประเภทลูกค้านัด" & vbCrLf & "กรุณาติดต่อเจ้าหน้าที่"
                msgMaximum = "เลือกได้สูงสุด "
                msgService = " บริการ"
                'msgOnward = " onwards"
                msgAppointmentAgain = " ในวันที่ "
                msgYouwillbeservefirstwith = "และรอรับบริการ"
                msgYouChooseTheService = "คุณเลือกบริการ"
                msgBookingNotAllowed = "ซึ่งระบบไม่ได้เปิดการจองไว้ในวันนี้"
                msgCannotAppoinment = "ไม่สามารถทำรายการจองได้ "
                msgHasAppointment = "มีนัดรับบริการ"
                msgPleastaketicket = "กรุณารับบัตรคิว "
                msgPleasmakeanew = " จะสามารถทำการจองได้อีกครั้ง "
                msgPleaseChooseOneService = "กรุณากดเลือกบริการ"
                msgCannotBBooked = "ไม่สามารถทำการจองได้ "
                msgPlsWaitForAbout = "และรอรับบริการประมาณ "
                msgMinute = " นาที"
                msgTimeAt = " เวลา: "
                msgAppTimeAt = " เวลา: "
                msgDateon = "วันที่: "
                msgAtclock = " น."
                msgBefore = "ก่อน"
                msgPleasArrive = "กรุณามาก่อนเวลานัด "
                msgPlsChkQSetting = "กรุณาเช็คการตั้งค่าของหมายเลขคิว !!!"
                msgAvailBookTime = "เวลาที่สามารถจองได้คือ "
                msgSureToBook = "ต้องการทำการจอง ใช่หรือไม่?"
                msgConfirm = "ยืนยัน"
                msgChooseAppTime = "กรุณาเลือกเวลาการจอง"
                msgAppTime = "ช่วงเวลาที่เลือกรับบริการ" & vbCrLf & "ไม่เพียงพอต่อบริการที่เลือก" & vbCrLf & vbCrLf & "กรุณาเลือกบริการใหม่"
                msgComeB4 = "กรุณามาก่อนเวลานัด "
                msgIfLate = "หากมาเกินเวลานัด" & vbCrLf & "คิวจะยกเลิกโดยอัติโนมัติ"
                msgBook = ""
                msgMaxServiceApp = "เลือกได้สูงสุด "
                msgHaveAppointment = "มีนัดรับบริการ"
                msgMinuteBeforeApptime = " นาที"
                msgAutomaticCancelApp = "หากมาเกินเวลานัด คิวจะยกเลิกโดยอัตโนมัติ"
                msgDialogBtnOK = "ตกลง"
                '-----------------
        End Select
    End Sub
End Module

