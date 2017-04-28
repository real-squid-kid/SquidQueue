<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ShowScreenBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.HDCheck = New System.Windows.Forms.RadioButton()
        Me.FullHDCheck = New System.Windows.Forms.RadioButton()
        Me.GenericCheck = New System.Windows.Forms.RadioButton()
        Me.BrandedCheck = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ClockCheck = New System.Windows.Forms.CheckBox()
        Me.CustomCheck = New System.Windows.Forms.CheckBox()
        Me.CustomLabel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentTicketLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ServeButton = New System.Windows.Forms.Button()
        Me.ReEnableTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CustomLabel)
        Me.TabPage1.Controls.Add(Me.CustomCheck)
        Me.TabPage1.Controls.Add(Me.ClockCheck)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ShowScreenBtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(464, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Screen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ShowScreenBtn
        '
        Me.ShowScreenBtn.Location = New System.Drawing.Point(6, 6)
        Me.ShowScreenBtn.Name = "ShowScreenBtn"
        Me.ShowScreenBtn.Size = New System.Drawing.Size(152, 56)
        Me.ShowScreenBtn.TabIndex = 0
        Me.ShowScreenBtn.Text = "Show Screen"
        Me.ShowScreenBtn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ServeButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RegisterButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(464, 390)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Register"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(671, 390)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "System settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'HDCheck
        '
        Me.HDCheck.AutoSize = True
        Me.HDCheck.Checked = True
        Me.HDCheck.Location = New System.Drawing.Point(15, 23)
        Me.HDCheck.Name = "HDCheck"
        Me.HDCheck.Size = New System.Drawing.Size(49, 17)
        Me.HDCheck.TabIndex = 2
        Me.HDCheck.TabStop = True
        Me.HDCheck.Text = "720p"
        Me.HDCheck.UseVisualStyleBackColor = True
        '
        'FullHDCheck
        '
        Me.FullHDCheck.AutoSize = True
        Me.FullHDCheck.Enabled = False
        Me.FullHDCheck.Location = New System.Drawing.Point(15, 46)
        Me.FullHDCheck.Name = "FullHDCheck"
        Me.FullHDCheck.Size = New System.Drawing.Size(55, 17)
        Me.FullHDCheck.TabIndex = 2
        Me.FullHDCheck.Text = "1080p"
        Me.FullHDCheck.UseVisualStyleBackColor = True
        '
        'GenericCheck
        '
        Me.GenericCheck.AutoSize = True
        Me.GenericCheck.Checked = True
        Me.GenericCheck.Location = New System.Drawing.Point(6, 20)
        Me.GenericCheck.Name = "GenericCheck"
        Me.GenericCheck.Size = New System.Drawing.Size(62, 17)
        Me.GenericCheck.TabIndex = 4
        Me.GenericCheck.TabStop = True
        Me.GenericCheck.Text = "Generic"
        Me.GenericCheck.UseVisualStyleBackColor = True
        '
        'BrandedCheck
        '
        Me.BrandedCheck.AutoSize = True
        Me.BrandedCheck.Enabled = False
        Me.BrandedCheck.Location = New System.Drawing.Point(6, 43)
        Me.BrandedCheck.Name = "BrandedCheck"
        Me.BrandedCheck.Size = New System.Drawing.Size(93, 17)
        Me.BrandedCheck.TabIndex = 4
        Me.BrandedCheck.Text = "Branded (MSI)"
        Me.BrandedCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FullHDCheck)
        Me.GroupBox1.Controls.Add(Me.HDCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensions"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BrandedCheck)
        Me.GroupBox2.Controls.Add(Me.GenericCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(96, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 77)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'ClockCheck
        '
        Me.ClockCheck.AutoSize = True
        Me.ClockCheck.Checked = True
        Me.ClockCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClockCheck.Location = New System.Drawing.Point(6, 151)
        Me.ClockCheck.Name = "ClockCheck"
        Me.ClockCheck.Size = New System.Drawing.Size(53, 17)
        Me.ClockCheck.TabIndex = 7
        Me.ClockCheck.Text = "Clock"
        Me.ClockCheck.UseVisualStyleBackColor = True
        '
        'CustomCheck
        '
        Me.CustomCheck.AutoSize = True
        Me.CustomCheck.Checked = True
        Me.CustomCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CustomCheck.Location = New System.Drawing.Point(6, 174)
        Me.CustomCheck.Name = "CustomCheck"
        Me.CustomCheck.Size = New System.Drawing.Size(90, 17)
        Me.CustomCheck.TabIndex = 8
        Me.CustomCheck.Text = "Custom Label"
        Me.CustomCheck.UseVisualStyleBackColor = True
        '
        'CustomLabel
        '
        Me.CustomLabel.Location = New System.Drawing.Point(102, 171)
        Me.CustomLabel.MaxLength = 40
        Me.CustomLabel.Name = "CustomLabel"
        Me.CustomLabel.Size = New System.Drawing.Size(160, 20)
        Me.CustomLabel.TabIndex = 9
        Me.CustomLabel.Text = "Custom Label"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Now serving:"
        '
        'CurrentTicketLbl
        '
        Me.CurrentTicketLbl.AutoSize = True
        Me.CurrentTicketLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentTicketLbl.Location = New System.Drawing.Point(491, 48)
        Me.CurrentTicketLbl.Name = "CurrentTicketLbl"
        Me.CurrentTicketLbl.Size = New System.Drawing.Size(51, 55)
        Me.CurrentTicketLbl.TabIndex = 1
        Me.CurrentTicketLbl.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total tickets:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(491, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 55)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "0"
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(3, 3)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(164, 57)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "Register another ticket"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ServeButton
        '
        Me.ServeButton.Location = New System.Drawing.Point(6, 6)
        Me.ServeButton.Name = "ServeButton"
        Me.ServeButton.Size = New System.Drawing.Size(130, 62)
        Me.ServeButton.TabIndex = 0
        Me.ServeButton.Text = "Serve"
        Me.ServeButton.UseVisualStyleBackColor = True
        '
        'ReEnableTimer
        '
        Me.ReEnableTimer.Interval = 3000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurrentTicketLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Control Panel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ShowScreenBtn As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ClockCheck As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrandedCheck As RadioButton
    Friend WithEvents GenericCheck As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FullHDCheck As RadioButton
    Friend WithEvents HDCheck As RadioButton
    Friend WithEvents CustomLabel As TextBox
    Friend WithEvents CustomCheck As CheckBox
    Friend WithEvents ServeButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentTicketLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ReEnableTimer As Timer
End Class
