<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeRollForm
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RollLengthTxt = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.NoTrackBtn = New System.Windows.Forms.Button()
        Me.DebugLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SquidQueue.My.Resources.Resources.rawr
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter new roll length (in meters):"
        '
        'RollLengthTxt
        '
        Me.RollLengthTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RollLengthTxt.Location = New System.Drawing.Point(367, 190)
        Me.RollLengthTxt.Name = "RollLengthTxt"
        Me.RollLengthTxt.Size = New System.Drawing.Size(112, 31)
        Me.RollLengthTxt.TabIndex = 2
        Me.RollLengthTxt.Text = "20"
        '
        'OKButton
        '
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.OKButton.Location = New System.Drawing.Point(367, 243)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(112, 41)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'NoTrackBtn
        '
        Me.NoTrackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.NoTrackBtn.Location = New System.Drawing.Point(12, 356)
        Me.NoTrackBtn.Name = "NoTrackBtn"
        Me.NoTrackBtn.Size = New System.Drawing.Size(467, 37)
        Me.NoTrackBtn.TabIndex = 3
        Me.NoTrackBtn.Text = "I don't want roll tracking for now"
        Me.NoTrackBtn.UseVisualStyleBackColor = True
        '
        'DebugLbl
        '
        Me.DebugLbl.AutoSize = True
        Me.DebugLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DebugLbl.Location = New System.Drawing.Point(12, 251)
        Me.DebugLbl.Name = "DebugLbl"
        Me.DebugLbl.Size = New System.Drawing.Size(77, 25)
        Me.DebugLbl.TabIndex = 4
        Me.DebugLbl.Text = "Label2"
        '
        'ChangeRollForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 405)
        Me.Controls.Add(Me.DebugLbl)
        Me.Controls.Add(Me.NoTrackBtn)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RollLengthTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangeRollForm"
        Me.Text = "Changing roll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RollLengthTxt As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents NoTrackBtn As Button
    Friend WithEvents DebugLbl As Label
End Class
