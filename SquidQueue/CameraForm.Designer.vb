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
        Me.CalibrationPageBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImagePathTxt = New System.Windows.Forms.TextBox()
        Me.BrowseFileBtn = New System.Windows.Forms.Button()
        Me.CameraPrintBtn = New System.Windows.Forms.Button()
        Me.BrightnessBar = New System.Windows.Forms.TrackBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrightnessBar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CameraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 350)
        Me.Controls.Add(Me.BrightnessBar)
        Me.Controls.Add(Me.CameraPrintBtn)
        Me.Controls.Add(Me.BrowseFileBtn)
        Me.Controls.Add(Me.ImagePathTxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CalibrationPageBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CameraForm"
        Me.Text = "CameraForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrightnessBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalibrationPageBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImagePathTxt As TextBox
    Friend WithEvents BrowseFileBtn As Button
    Friend WithEvents CameraPrintBtn As Button
    Friend WithEvents BrightnessBar As TrackBar
End Class
