<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalibrationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegularHugeTxt = New System.Windows.Forms.TextBox()
        Me.RegularBigTxt = New System.Windows.Forms.TextBox()
        Me.RegularNormalTxt = New System.Windows.Forms.TextBox()
        Me.RegularSmallTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BoldHugeTXT = New System.Windows.Forms.TextBox()
        Me.BoldBigTxt = New System.Windows.Forms.TextBox()
        Me.BoldNormalTxt = New System.Windows.Forms.TextBox()
        Me.BoldSmallTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please count how many symbols can you see in each " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "line. If the whole line is on" &
    " the screen, just write 40." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This info will be used in word-wrapping function."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Huge"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Big"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Normal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Small"
        '
        'RegularHugeTxt
        '
        Me.RegularHugeTxt.Location = New System.Drawing.Point(89, 83)
        Me.RegularHugeTxt.Name = "RegularHugeTxt"
        Me.RegularHugeTxt.Size = New System.Drawing.Size(48, 20)
        Me.RegularHugeTxt.TabIndex = 1
        '
        'RegularBigTxt
        '
        Me.RegularBigTxt.Location = New System.Drawing.Point(89, 109)
        Me.RegularBigTxt.Name = "RegularBigTxt"
        Me.RegularBigTxt.Size = New System.Drawing.Size(48, 20)
        Me.RegularBigTxt.TabIndex = 2
        '
        'RegularNormalTxt
        '
        Me.RegularNormalTxt.Location = New System.Drawing.Point(89, 134)
        Me.RegularNormalTxt.Name = "RegularNormalTxt"
        Me.RegularNormalTxt.Size = New System.Drawing.Size(48, 20)
        Me.RegularNormalTxt.TabIndex = 3
        '
        'RegularSmallTxt
        '
        Me.RegularSmallTxt.Location = New System.Drawing.Point(89, 160)
        Me.RegularSmallTxt.Name = "RegularSmallTxt"
        Me.RegularSmallTxt.Size = New System.Drawing.Size(48, 20)
        Me.RegularSmallTxt.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Regular"
        '
        'BoldHugeTXT
        '
        Me.BoldHugeTXT.Location = New System.Drawing.Point(143, 83)
        Me.BoldHugeTXT.Name = "BoldHugeTXT"
        Me.BoldHugeTXT.Size = New System.Drawing.Size(48, 20)
        Me.BoldHugeTXT.TabIndex = 5
        '
        'BoldBigTxt
        '
        Me.BoldBigTxt.Location = New System.Drawing.Point(143, 109)
        Me.BoldBigTxt.Name = "BoldBigTxt"
        Me.BoldBigTxt.Size = New System.Drawing.Size(48, 20)
        Me.BoldBigTxt.TabIndex = 6
        '
        'BoldNormalTxt
        '
        Me.BoldNormalTxt.Location = New System.Drawing.Point(143, 134)
        Me.BoldNormalTxt.Name = "BoldNormalTxt"
        Me.BoldNormalTxt.Size = New System.Drawing.Size(48, 20)
        Me.BoldNormalTxt.TabIndex = 7
        '
        'BoldSmallTxt
        '
        Me.BoldSmallTxt.Location = New System.Drawing.Point(143, 160)
        Me.BoldSmallTxt.Name = "BoldSmallTxt"
        Me.BoldSmallTxt.Size = New System.Drawing.Size(48, 20)
        Me.BoldSmallTxt.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(163, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Bold"
        '
        'OKBtn
        '
        Me.OKBtn.Location = New System.Drawing.Point(199, 226)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(75, 23)
        Me.OKBtn.TabIndex = 9
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(118, 226)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 99
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'CalibrationForm
        '
        Me.AcceptButton = Me.OKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.BoldSmallTxt)
        Me.Controls.Add(Me.RegularSmallTxt)
        Me.Controls.Add(Me.BoldNormalTxt)
        Me.Controls.Add(Me.BoldBigTxt)
        Me.Controls.Add(Me.RegularNormalTxt)
        Me.Controls.Add(Me.BoldHugeTXT)
        Me.Controls.Add(Me.RegularBigTxt)
        Me.Controls.Add(Me.RegularHugeTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CalibrationForm"
        Me.Text = "Font Calibration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RegularHugeTxt As TextBox
    Friend WithEvents RegularBigTxt As TextBox
    Friend WithEvents RegularNormalTxt As TextBox
    Friend WithEvents RegularSmallTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BoldHugeTXT As TextBox
    Friend WithEvents BoldBigTxt As TextBox
    Friend WithEvents BoldNormalTxt As TextBox
    Friend WithEvents BoldSmallTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
