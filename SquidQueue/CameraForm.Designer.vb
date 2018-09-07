<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CameraForm
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
        Me.CalibrationPageBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImagePathTxt = New System.Windows.Forms.TextBox()
        Me.BrowseFileBtn = New System.Windows.Forms.Button()
        Me.CameraPrintBtn = New System.Windows.Forms.Button()
        Me.BrightnessBar = New System.Windows.Forms.TrackBar()
        Me.WebCamRestartBtn = New System.Windows.Forms.Button()
        Me.WebCamCaptureBtn = New System.Windows.Forms.Button()
        Me.WebCamSettingsBtn = New System.Windows.Forms.Button()
        Me.TempBox = New System.Windows.Forms.PictureBox()
        Me.DebugLabel = New System.Windows.Forms.Label()
        Me.Monitor = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrightnessBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalibrationPageBtn
        '
        Me.CalibrationPageBtn.Location = New System.Drawing.Point(13, 13)
        Me.CalibrationPageBtn.Name = "CalibrationPageBtn"
        Me.CalibrationPageBtn.Size = New System.Drawing.Size(75, 23)
        Me.CalibrationPageBtn.TabIndex = 0
        Me.CalibrationPageBtn.Text = "Calibration..."
        Me.CalibrationPageBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ImagePathTxt
        '
        Me.ImagePathTxt.Enabled = False
        Me.ImagePathTxt.Location = New System.Drawing.Point(12, 44)
        Me.ImagePathTxt.Name = "ImagePathTxt"
        Me.ImagePathTxt.Size = New System.Drawing.Size(259, 20)
        Me.ImagePathTxt.TabIndex = 2
        '
        'BrowseFileBtn
        '
        Me.BrowseFileBtn.Location = New System.Drawing.Point(12, 70)
        Me.BrowseFileBtn.Name = "BrowseFileBtn"
        Me.BrowseFileBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseFileBtn.TabIndex = 3
        Me.BrowseFileBtn.Text = "Browse..."
        Me.BrowseFileBtn.UseVisualStyleBackColor = True
        '
        'CameraPrintBtn
        '
        Me.CameraPrintBtn.Enabled = False
        Me.CameraPrintBtn.Location = New System.Drawing.Point(197, 70)
        Me.CameraPrintBtn.Name = "CameraPrintBtn"
        Me.CameraPrintBtn.Size = New System.Drawing.Size(75, 23)
        Me.CameraPrintBtn.TabIndex = 4
        Me.CameraPrintBtn.Text = "Print"
        Me.CameraPrintBtn.UseVisualStyleBackColor = True
        '
        'BrightnessBar
        '
        Me.BrightnessBar.Enabled = False
        Me.BrightnessBar.Location = New System.Drawing.Point(13, 312)
        Me.BrightnessBar.Maximum = 80
        Me.BrightnessBar.Name = "BrightnessBar"
        Me.BrightnessBar.Size = New System.Drawing.Size(258, 45)
        Me.BrightnessBar.TabIndex = 5
        Me.BrightnessBar.Value = 40
        '
        'WebCamRestartBtn
        '
        Me.WebCamRestartBtn.Location = New System.Drawing.Point(277, 41)
        Me.WebCamRestartBtn.Name = "WebCamRestartBtn"
        Me.WebCamRestartBtn.Size = New System.Drawing.Size(89, 23)
        Me.WebCamRestartBtn.TabIndex = 6
        Me.WebCamRestartBtn.Text = "Camera"
        Me.WebCamRestartBtn.UseVisualStyleBackColor = True
        '
        'WebCamCaptureBtn
        '
        Me.WebCamCaptureBtn.Location = New System.Drawing.Point(278, 70)
        Me.WebCamCaptureBtn.Name = "WebCamCaptureBtn"
        Me.WebCamCaptureBtn.Size = New System.Drawing.Size(89, 23)
        Me.WebCamCaptureBtn.TabIndex = 6
        Me.WebCamCaptureBtn.Text = "CAPTURE"
        Me.WebCamCaptureBtn.UseVisualStyleBackColor = True
        '
        'WebCamSettingsBtn
        '
        Me.WebCamSettingsBtn.Location = New System.Drawing.Point(278, 99)
        Me.WebCamSettingsBtn.Name = "WebCamSettingsBtn"
        Me.WebCamSettingsBtn.Size = New System.Drawing.Size(89, 23)
        Me.WebCamSettingsBtn.TabIndex = 6
        Me.WebCamSettingsBtn.Text = "Settings..."
        Me.WebCamSettingsBtn.UseVisualStyleBackColor = True
        '
        'TempBox
        '
        Me.TempBox.Location = New System.Drawing.Point(440, 44)
        Me.TempBox.Name = "TempBox"
        Me.TempBox.Size = New System.Drawing.Size(259, 206)
        Me.TempBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TempBox.TabIndex = 1
        Me.TempBox.TabStop = False
        '
        'DebugLabel
        '
        Me.DebugLabel.AutoSize = True
        Me.DebugLabel.Location = New System.Drawing.Point(279, 291)
        Me.DebugLabel.Name = "DebugLabel"
        Me.DebugLabel.Size = New System.Drawing.Size(39, 13)
        Me.DebugLabel.TabIndex = 7
        Me.DebugLabel.Text = "Label1"
        '
        'Monitor
        '
        Me.Monitor.Enabled = True
        Me.Monitor.Interval = 750
        '
        'CameraForm
        '
        Me.AcceptButton = Me.WebCamCaptureBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 350)
        Me.Controls.Add(Me.DebugLabel)
        Me.Controls.Add(Me.WebCamSettingsBtn)
        Me.Controls.Add(Me.WebCamCaptureBtn)
        Me.Controls.Add(Me.WebCamRestartBtn)
        Me.Controls.Add(Me.BrightnessBar)
        Me.Controls.Add(Me.CameraPrintBtn)
        Me.Controls.Add(Me.BrowseFileBtn)
        Me.Controls.Add(Me.ImagePathTxt)
        Me.Controls.Add(Me.TempBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CalibrationPageBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CameraForm"
        Me.Text = "CameraForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrightnessBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalibrationPageBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImagePathTxt As TextBox
    Friend WithEvents BrowseFileBtn As Button
    Friend WithEvents CameraPrintBtn As Button
    Friend WithEvents BrightnessBar As TrackBar
    Friend WithEvents WebCamRestartBtn As Button
    Friend WithEvents WebCamCaptureBtn As Button
    Friend WithEvents WebCamSettingsBtn As Button
    Friend WithEvents TempBox As PictureBox
    Friend WithEvents DebugLabel As Label
    Friend WithEvents Monitor As Timer
End Class
