<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.TimerVDO = New System.Windows.Forms.Timer(Me.components)
        Me.pd = New System.Drawing.Printing.PrintDocument()
        Me.TimerCheckCaptureFile = New System.Windows.Forms.Timer(Me.components)
        Me.pbPassport = New System.Windows.Forms.PictureBox()
        Me.pbIDCard = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VDO = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.pbPassport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbIDCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.VDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerVDO
        '
        Me.TimerVDO.Interval = 1000
        '
        'TimerCheckCaptureFile
        '
        Me.TimerCheckCaptureFile.Enabled = True
        Me.TimerCheckCaptureFile.Interval = 600000
        '
        'pbPassport
        '
        Me.pbPassport.Image = CType(resources.GetObject("pbPassport.Image"), System.Drawing.Image)
        Me.pbPassport.Location = New System.Drawing.Point(708, 616)
        Me.pbPassport.Name = "pbPassport"
        Me.pbPassport.Size = New System.Drawing.Size(298, 56)
        Me.pbPassport.TabIndex = 66
        Me.pbPassport.TabStop = False
        '
        'pbIDCard
        '
        Me.pbIDCard.Image = CType(resources.GetObject("pbIDCard.Image"), System.Drawing.Image)
        Me.pbIDCard.Location = New System.Drawing.Point(404, 616)
        Me.pbIDCard.Name = "pbIDCard"
        Me.pbIDCard.Size = New System.Drawing.Size(298, 56)
        Me.pbIDCard.TabIndex = 65
        Me.pbIDCard.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.KioskElo.My.Resources.Resources.Close
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(2, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 51
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pb
        '
        Me.pb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb.BackgroundImage = CType(resources.GetObject("pb.BackgroundImage"), System.Drawing.Image)
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(1366, 768)
        Me.pb.TabIndex = 18
        Me.pb.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VDO)
        Me.Panel1.Location = New System.Drawing.Point(377, 155)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 440)
        Me.Panel1.TabIndex = 73
        '
        'VDO
        '
        Me.VDO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VDO.Enabled = True
        Me.VDO.Location = New System.Drawing.Point(0, 0)
        Me.VDO.Name = "VDO"
        Me.VDO.OcxState = CType(resources.GetObject("VDO.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VDO.Size = New System.Drawing.Size(650, 440)
        Me.VDO.TabIndex = 65
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbPassport)
        Me.Controls.Add(Me.pbIDCard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmSlot"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbPassport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbIDCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.VDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerVDO As System.Windows.Forms.Timer
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents pd As System.Drawing.Printing.PrintDocument
    Friend WithEvents TimerCheckCaptureFile As System.Windows.Forms.Timer
    Friend WithEvents pbIDCard As System.Windows.Forms.PictureBox
    Friend WithEvents pbPassport As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VDO As AxWMPLib.AxWindowsMediaPlayer
End Class
