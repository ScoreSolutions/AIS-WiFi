<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputPassport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputPassport))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPassportCapture = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pbPassportInfo = New System.Windows.Forms.PictureBox()
        Me.pbPassportPreview = New System.Windows.Forms.PictureBox()
        Me.pbPassportDisplay = New System.Windows.Forms.PictureBox()
        Me.btnLoadZone = New System.Windows.Forms.Button()
        Me.btnSaveZone = New System.Windows.Forms.Button()
        Me.btnClearZone = New System.Windows.Forms.Button()
        Me.btnRecognize = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbCancel = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pbPassportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPassportPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPassportDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'btnPassportCapture
        '
        Me.btnPassportCapture.BackgroundImage = CType(resources.GetObject("btnPassportCapture.BackgroundImage"), System.Drawing.Image)
        Me.btnPassportCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPassportCapture.Location = New System.Drawing.Point(689, 594)
        Me.btnPassportCapture.Name = "btnPassportCapture"
        Me.btnPassportCapture.Size = New System.Drawing.Size(111, 39)
        Me.btnPassportCapture.TabIndex = 31
        Me.btnPassportCapture.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(429, 105)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbPassportInfo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbPassportPreview)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbPassportDisplay)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnLoadZone)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSaveZone)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnClearZone)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRecognize)
        Me.SplitContainer1.Size = New System.Drawing.Size(881, 483)
        Me.SplitContainer1.SplitterDistance = 642
        Me.SplitContainer1.TabIndex = 32
        '
        'pbPassportInfo
        '
        Me.pbPassportInfo.BackColor = System.Drawing.Color.Transparent
        Me.pbPassportInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPassportInfo.Location = New System.Drawing.Point(30, 345)
        Me.pbPassportInfo.Name = "pbPassportInfo"
        Me.pbPassportInfo.Size = New System.Drawing.Size(588, 83)
        Me.pbPassportInfo.TabIndex = 5
        Me.pbPassportInfo.TabStop = False
        '
        'pbPassportPreview
        '
        Me.pbPassportPreview.InitialImage = Nothing
        Me.pbPassportPreview.Location = New System.Drawing.Point(0, 3)
        Me.pbPassportPreview.Name = "pbPassportPreview"
        Me.pbPassportPreview.Size = New System.Drawing.Size(640, 480)
        Me.pbPassportPreview.TabIndex = 2
        Me.pbPassportPreview.TabStop = False
        '
        'pbPassportDisplay
        '
        Me.pbPassportDisplay.Location = New System.Drawing.Point(0, 3)
        Me.pbPassportDisplay.Name = "pbPassportDisplay"
        Me.pbPassportDisplay.Size = New System.Drawing.Size(640, 480)
        Me.pbPassportDisplay.TabIndex = 3
        Me.pbPassportDisplay.TabStop = False
        '
        'btnLoadZone
        '
        Me.btnLoadZone.Location = New System.Drawing.Point(19, 186)
        Me.btnLoadZone.Name = "btnLoadZone"
        Me.btnLoadZone.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadZone.TabIndex = 53
        Me.btnLoadZone.Text = "Load Zone"
        Me.btnLoadZone.UseVisualStyleBackColor = True
        Me.btnLoadZone.Visible = False
        '
        'btnSaveZone
        '
        Me.btnSaveZone.BackgroundImage = CType(resources.GetObject("btnSaveZone.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveZone.Location = New System.Drawing.Point(19, 90)
        Me.btnSaveZone.Name = "btnSaveZone"
        Me.btnSaveZone.Size = New System.Drawing.Size(91, 33)
        Me.btnSaveZone.TabIndex = 52
        Me.btnSaveZone.UseVisualStyleBackColor = True
        Me.btnSaveZone.Visible = False
        '
        'btnClearZone
        '
        Me.btnClearZone.BackgroundImage = CType(resources.GetObject("btnClearZone.BackgroundImage"), System.Drawing.Image)
        Me.btnClearZone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearZone.Location = New System.Drawing.Point(19, 138)
        Me.btnClearZone.Name = "btnClearZone"
        Me.btnClearZone.Size = New System.Drawing.Size(88, 33)
        Me.btnClearZone.TabIndex = 51
        Me.btnClearZone.UseVisualStyleBackColor = True
        Me.btnClearZone.Visible = False
        '
        'btnRecognize
        '
        Me.btnRecognize.BackgroundImage = CType(resources.GetObject("btnRecognize.BackgroundImage"), System.Drawing.Image)
        Me.btnRecognize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecognize.Location = New System.Drawing.Point(19, 30)
        Me.btnRecognize.Name = "btnRecognize"
        Me.btnRecognize.Size = New System.Drawing.Size(108, 39)
        Me.btnRecognize.TabIndex = 50
        Me.btnRecognize.UseVisualStyleBackColor = True
        Me.btnRecognize.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(351, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 33
        '
        'pbCancel
        '
        Me.pbCancel.Image = CType(resources.GetObject("pbCancel.Image"), System.Drawing.Image)
        Me.pbCancel.Location = New System.Drawing.Point(1138, 594)
        Me.pbCancel.Name = "pbCancel"
        Me.pbCancel.Size = New System.Drawing.Size(169, 56)
        Me.pbCancel.TabIndex = 72
        Me.pbCancel.TabStop = False
        '
        'frmInputPassport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pbCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnPassportCapture)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInputPassport"
        Me.Text = "frmInputPassport"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pbPassportInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPassportPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPassportDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPassportCapture As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents pbPassportPreview As System.Windows.Forms.PictureBox
    Friend WithEvents pbPassportDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents btnRecognize As System.Windows.Forms.Button
    Friend WithEvents btnClearZone As System.Windows.Forms.Button
    Friend WithEvents btnSaveZone As System.Windows.Forms.Button
    Friend WithEvents btnLoadZone As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pbPassportInfo As System.Windows.Forms.PictureBox
    Friend WithEvents pbCancel As System.Windows.Forms.PictureBox
End Class
