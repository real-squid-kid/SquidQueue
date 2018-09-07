<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CouponForm
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
        Me.PrizeTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClaimTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prize to give out:"
        '
        'PrizeTxt
        '
        Me.PrizeTxt.Location = New System.Drawing.Point(105, 10)
        Me.PrizeTxt.Name = "PrizeTxt"
        Me.PrizeTxt.Size = New System.Drawing.Size(167, 20)
        Me.PrizeTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Claim No."
        '
        'ClaimTxt
        '
        Me.ClaimTxt.Location = New System.Drawing.Point(105, 35)
        Me.ClaimTxt.Name = "ClaimTxt"
        Me.ClaimTxt.Size = New System.Drawing.Size(167, 20)
        Me.ClaimTxt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Make sure you prepared the appropriate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "claim before printing coupon."
        '
        'OKBtn
        '
        Me.OKBtn.Location = New System.Drawing.Point(197, 114)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(75, 23)
        Me.OKBtn.TabIndex = 2
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(16, 114)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'CouponForm
        '
        Me.AcceptButton = Me.OKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OKBtn)
        Me.Controls.Add(Me.ClaimTxt)
        Me.Controls.Add(Me.PrizeTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CouponForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Coupon printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PrizeTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ClaimTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OKBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
