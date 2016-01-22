Imports System.Runtime.InteropServices

Public Class frmMain
    'Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal IpClassName As String, ByVal IpWindowName As String) As IntPtr
    'Private Declare Function ShowWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As IntPtr
    '<DllImport("user32.dll", EntryPoint:="SendMessage", SetLastError:=True)> _
    'Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Int32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    'End Function


    'Private Const SW_HIDE As Integer = 0
    'Private Const SW_RESTORE As Integer = 9
    'Private Sub HideDesktopIcon()
    '    Dim hwnd As IntPtr
    '    hwnd = FindWindow(vbNullString, "Program Manager")
    '    If hwnd <> 0 Then
    '        ShowWindow(hwnd, SW_HIDE)
    '    End If
    'End Sub
    'Private Sub ShowDesktopIcon()
    '    Dim hwnd As IntPtr
    '    hwnd = FindWindow(vbNullString, "Program Manager")
    '    If hwnd <> 0 Then
    '        ShowWindow(hwnd, SW_RESTORE)
    '    End If
    'End Sub

    'Const WM_COMMAND As Integer = &H111
    'Const MIN_ALL As Integer = 419
    'Const MIN_ALL_UNDO As Integer = 416
    'Private Sub MinimizeAllWindows()
    '    Dim lHwnd As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
    '    SendMessage(lHwnd, WM_COMMAND, MIN_ALL, IntPtr.Zero)
    'End Sub

    'Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '    ShowDesktopIcon()
    'End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Minimized
        frmRegister.ShowDialog()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'HideDesktopIcon()
        'MinimizeAllWindows()
    End Sub
End Class