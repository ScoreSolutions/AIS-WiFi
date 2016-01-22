<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputIDCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInputIDCard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDisplayIDCard = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pbCancel = New System.Windows.Forms.PictureBox()
        Me.lblDisplayDateOfBirth = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 42)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "กรุณาสอดบัตรประชาชน"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(516, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 368)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
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
        Me.pb.TabIndex = 19
        Me.pb.TabStop = False
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'lblDisplayIDCard
        '
        Me.lblDisplayIDCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDisplayIDCard.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayIDCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(222, Byte))
        Me.lblDisplayIDCard.Location = New System.Drawing.Point(96, 124)
        Me.lblDisplayIDCard.Name = "lblDisplayIDCard"
        Me.lblDisplayIDCard.Size = New System.Drawing.Size(299, 26)
        Me.lblDisplayIDCard.TabIndex = 69
        Me.lblDisplayIDCard.Text = "-"
        Me.lblDisplayIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDisplayIDCard.Visible = False
        '
        'lblDisplayName
        '
        Me.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDisplayName.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(222, Byte))
        Me.lblDisplayName.Location = New System.Drawing.Point(96, 80)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(299, 26)
        Me.lblDisplayName.TabIndex = 67
        Me.lblDisplayName.Text = "-"
        Me.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDisplayName.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'pbCancel
        '
        Me.pbCancel.Image = CType(resources.GetObject("pbCancel.Image"), System.Drawing.Image)
        Me.pbCancel.Location = New System.Drawing.Point(640, 609)
        Me.pbCancel.Name = "pbCancel"
        Me.pbCancel.Size = New System.Drawing.Size(169, 56)
        Me.pbCancel.TabIndex = 71
        Me.pbCancel.TabStop = False
        '
        'lblDisplayDateOfBirth
        '
        Me.lblDisplayDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDisplayDateOfBirth.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayDateOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(222, Byte))
        Me.lblDisplayDateOfBirth.Location = New System.Drawing.Point(96, 167)
        Me.lblDisplayDateOfBirth.Name = "lblDisplayDateOfBirth"
        Me.lblDisplayDateOfBirth.Size = New System.Drawing.Size(299, 26)
        Me.lblDisplayDateOfBirth.TabIndex = 72
        Me.lblDisplayDateOfBirth.Text = "-"
        Me.lblDisplayDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDisplayDateOfBirth.Visible = False
        '
        'frmInputIDCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblDisplayDateOfBirth)
        Me.Controls.Add(Me.pbCancel)
        Me.Controls.Add(Me.lblDisplayIDCard)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInputIDCard"
        Me.Text = "frmInputIDCard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblDisplayIDCard As System.Windows.Forms.Label
    Friend WithEvents lblDisplayName As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents pbCancel As System.Windows.Forms.PictureBox
    Friend WithEvents lblDisplayDateOfBirth As System.Windows.Forms.Label
End Class
