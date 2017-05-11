<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ClockLabel = New System.Windows.Forms.Label()
        Me.CustomLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TicketLabel = New System.Windows.Forms.Label()
        Me.BlinkTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SyncPing = New System.Windows.Forms.Timer(Me.components)
        Me.QueueCountLbl = New System.Windows.Forms.Label()
        Me.EstimateResultLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ClockLabel
        '
        Me.ClockLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClockLabel.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ClockLabel.ForeColor = System.Drawing.Color.White
        Me.ClockLabel.Location = New System.Drawing.Point(959, 9)
        Me.ClockLabel.Name = "ClockLabel"
        Me.ClockLabel.Size = New System.Drawing.Size(309, 75)
        Me.ClockLabel.TabIndex = 0
        Me.ClockLabel.Text = "00:00:00"
        Me.ClockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomLabel
        '
        Me.CustomLabel.BackColor = System.Drawing.Color.Transparent
        Me.CustomLabel.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CustomLabel.ForeColor = System.Drawing.Color.White
        Me.CustomLabel.Location = New System.Drawing.Point(12, 115)
        Me.CustomLabel.Name = "CustomLabel"
        Me.CustomLabel.Size = New System.Drawing.Size(1256, 75)
        Me.CustomLabel.TabIndex = 0
        Me.CustomLabel.Text = "SquidQueue"
        Me.CustomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "☼"
        '
        'ClockTimer
        '
        Me.ClockTimer.Enabled = True
        Me.ClockTimer.Interval = 1000
        '
        'TicketLabel
        '
        Me.TicketLabel.AutoSize = True
        Me.TicketLabel.BackColor = System.Drawing.Color.Transparent
        Me.TicketLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 249.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketLabel.ForeColor = System.Drawing.Color.White
        Me.TicketLabel.Location = New System.Drawing.Point(463, 224)
        Me.TicketLabel.Name = "TicketLabel"
        Me.TicketLabel.Size = New System.Drawing.Size(360, 385)
        Me.TicketLabel.TabIndex = 2
        Me.TicketLabel.Text = "0"
        Me.TicketLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BlinkTimer
        '
        Me.BlinkTimer.Interval = 250
        '
        'SyncPing
        '
        Me.SyncPing.Enabled = True
        Me.SyncPing.Interval = 1000
        '
        'QueueCountLbl
        '
        Me.QueueCountLbl.BackColor = System.Drawing.Color.Transparent
        Me.QueueCountLbl.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.QueueCountLbl.ForeColor = System.Drawing.Color.White
        Me.QueueCountLbl.Location = New System.Drawing.Point(12, 609)
        Me.QueueCountLbl.Name = "QueueCountLbl"
        Me.QueueCountLbl.Size = New System.Drawing.Size(615, 75)
        Me.QueueCountLbl.TabIndex = 0
        Me.QueueCountLbl.Text = "SquidQueue"
        Me.QueueCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstimateResultLbl
        '
        Me.EstimateResultLbl.BackColor = System.Drawing.Color.Transparent
        Me.EstimateResultLbl.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.EstimateResultLbl.ForeColor = System.Drawing.Color.White
        Me.EstimateResultLbl.Location = New System.Drawing.Point(653, 609)
        Me.EstimateResultLbl.Name = "EstimateResultLbl"
        Me.EstimateResultLbl.Size = New System.Drawing.Size(615, 75)
        Me.EstimateResultLbl.TabIndex = 0
        Me.EstimateResultLbl.Text = "SquidQueue"
        Me.EstimateResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.TicketLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EstimateResultLbl)
        Me.Controls.Add(Me.QueueCountLbl)
        Me.Controls.Add(Me.CustomLabel)
        Me.Controls.Add(Me.ClockLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Screen"
        Me.Text = "Screen"
        Me.TransparencyKey = System.Drawing.Color.Snow
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClockLabel As Label
    Friend WithEvents CustomLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents TicketLabel As Label
    Friend WithEvents BlinkTimer As Timer
    Friend WithEvents SyncPing As Timer
    Friend WithEvents QueueCountLbl As Label
    Friend WithEvents EstimateResultLbl As Label
End Class
