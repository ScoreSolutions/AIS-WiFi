<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowInfo))
        Me.lblDisplayIDCard = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.lblIDCard = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.pbOK = New System.Windows.Forms.PictureBox()
        Me.pbCancel = New System.Windows.Forms.PictureBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.tmFinish = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMsg = New System.Windows.Forms.Panel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.pd = New System.Drawing.Printing.PrintDocument()
        CType(Me.pbOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplayIDCard
        '
        Me.lblDisplayIDCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDisplayIDCard.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDisplayIDCard.Location = New System.Drawing.Point(534, 268)
        Me.lblDisplayIDCard.Name = "lblDisplayIDCard"
        Me.lblDisplayIDCard.Size = New System.Drawing.Size(772, 40)
        Me.lblDisplayIDCard.TabIndex = 66
        Me.lblDisplayIDCard.Text = "-"
        Me.lblDisplayIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayName
        '
        Me.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDisplayName.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDisplayName.Location = New System.Drawing.Point(534, 369)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(772, 40)
        Me.lblDisplayName.TabIndex = 64
        Me.lblDisplayName.Text = "-"
        Me.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIDCard
        '
        Me.lblIDCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblIDCard.BackColor = System.Drawing.Color.Transparent
        Me.lblIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblIDCard.Location = New System.Drawing.Point(235, 267)
        Me.lblIDCard.Name = "lblIDCard"
        Me.lblIDCard.Size = New System.Drawing.Size(293, 40)
        Me.lblIDCard.TabIndex = 63
        Me.lblIDCard.Text = "ID Card  :"
        Me.lblIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(348, 368)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(180, 40)
        Me.lblFirstName.TabIndex = 61
        Me.lblFirstName.Text = "Name :"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbOK
        '
        Me.pbOK.Image = CType(resources.GetObject("pbOK.Image"), System.Drawing.Image)
        Me.pbOK.Location = New System.Drawing.Point(433, 571)
        Me.pbOK.Name = "pbOK"
        Me.pbOK.Size = New System.Drawing.Size(169, 56)
        Me.pbOK.TabIndex = 73
        Me.pbOK.TabStop = False
        '
        'pbCancel
        '
        Me.pbCancel.Image = CType(resources.GetObject("pbCancel.Image"), System.Drawing.Image)
        Me.pbCancel.Location = New System.Drawing.Point(642, 571)
        Me.pbCancel.Name = "pbCancel"
        Me.pbCancel.Size = New System.Drawing.Size(169, 56)
        Me.pbCancel.TabIndex = 72
        Me.pbCancel.TabStop = False
        '
        'pb
        '
        Me.pb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pb.BackColor = System.Drawing.Color.White
        Me.pb.BackgroundImage = CType(resources.GetObject("pb.BackgroundImage"), System.Drawing.Image)
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(1366, 768)
        Me.pb.TabIndex = 20
        Me.pb.TabStop = False
        '
        'tmFinish
        '
        Me.tmFinish.Interval = 1000
        '
        'PanelMsg
        '
        Me.PanelMsg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelMsg.BackgroundImage = CType(resources.GetObject("PanelMsg.BackgroundImage"), System.Drawing.Image)
        Me.PanelMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMsg.Controls.Add(Me.lblMsg)
        Me.PanelMsg.Location = New System.Drawing.Point(522, 255)
        Me.PanelMsg.Name = "PanelMsg"
        Me.PanelMsg.Size = New System.Drawing.Size(322, 259)
        Me.PanelMsg.TabIndex = 74
        Me.PanelMsg.Visible = False
        '
        'lblMsg
        '
        Me.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(10, 12)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(303, 235)
        Me.lblMsg.TabIndex = 0
        Me.lblMsg.Text = "[H]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Y]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[S]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[X]"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Location = New System.Drawing.Point(559, 121)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(48, 13)
        Me.lblCardType.TabIndex = 75
        Me.lblCardType.Text = "IDCARD"
        Me.lblCardType.Visible = False
        '
        'pd
        '
        '
        'frmShowInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblCardType)
        Me.Controls.Add(Me.PanelMsg)
        Me.Controls.Add(Me.pbOK)
        Me.Controls.Add(Me.pbCancel)
        Me.Controls.Add(Me.lblDisplayIDCard)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.lblIDCard)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmShowInfo"
        Me.Text = "frmShowInfo"
        CType(Me.pbOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMsg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents lblDisplayIDCard As System.Windows.Forms.Label
    Friend WithEvents lblDisplayName As System.Windows.Forms.Label
    Friend WithEvents lblIDCard As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents pbCancel As System.Windows.Forms.PictureBox
    Friend WithEvents pbOK As System.Windows.Forms.PictureBox
    Friend WithEvents tmFinish As System.Windows.Forms.Timer
    Friend WithEvents PanelMsg As System.Windows.Forms.Panel
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents lblCardType As System.Windows.Forms.Label
    Friend WithEvents pd As System.Drawing.Printing.PrintDocument
End Class
