Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports WebCam_Capture
Public Class CameraForm
    Dim Brightness As Single = 0
    Dim CameraCaptured As Boolean
    Dim webcam As WebCamClass
    Private Sub CalibrationPageBtn_Click(sender As Object, e As EventArgs) Handles CalibrationPageBtn.Click
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            .FeedPaper(2)
            .RTL = False
            .PrintImageDirect(My.Resources.calibration)
            .FeedPaper(2)
            .EndDoc()

        End With
        Try
            My.Settings.PrinterWidth = InputBox("Please enter how much lines are shown on printer.", "RaffleRaffle", "180")
            PictureBox1.Width = My.Settings.PrinterWidth
        Catch ex As Exception
            MessageBox.Show("Invalid number.", "RaffleRaffle", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub BrowseFileBtn_Click(sender As Object, e As EventArgs) Handles BrowseFileBtn.Click
        ' Try
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            '  PictureBox1.ImageLocation = dialog.FileName
            TempBox.ImageLocation = dialog.FileName
            Dim img As New Bitmap(TempBox.ImageLocation)
            Dim printHeight As Integer = Math.Round(My.Settings.PrinterWidth / (img.Width / img.Height))
            'Dim print As Image = New Bitmap(My.Settings.PrinterWidth, printHeight)
            Dim print As Image = ResizeImage(img, New Size(My.Settings.PrinterWidth, printHeight))
            PictureBox1.Image = ToBlackAndWhite(print)
            ImagePathTxt.Text = dialog.FileName
            CameraPrintBtn.Enabled = True
            BrightnessBar.Enabled = True
            CameraCaptured = False
        End Using
        'Catch ex As Exception
        '    MessageBox.Show("Not a valid image file. Should be .png, .jpg or .bmp.", "RaffleRaffle", xd            MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ' End Try

    End Sub

    Private Sub CameraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PrinterWidth <> Nothing Then
            PictureBox1.Width = My.Settings.PrinterWidth
        Else
            My.Settings.PrinterWidth = 180
            PictureBox1.Width = My.Settings.PrinterWidth
        End If
        webcam = New WebCamClass()
        webcam.InitializeWebCam(PictureBox1)
    End Sub

    Private Sub CameraPrintBtn_Click(sender As Object, e As EventArgs) Handles CameraPrintBtn.Click
        Dim P As New PrinterClass(Application.StartupPath)
        Dim printHeight As Integer = Math.Round(My.Settings.PrinterWidth / (PictureBox1.Image.Width / PictureBox1.Image.Height))
        Dim print As Image = ResizeImage(PictureBox1.Image, New Size(My.Settings.PrinterWidth, printHeight))
        Dim borderheight As Integer = Math.Round(My.Settings.PrinterWidth / (64 / 5))
        Dim top As Image = ResizeImage(My.Resources.top, New Size(My.Settings.PrinterWidth, printHeight))
        Dim bottom As Image = ResizeImage(My.Resources.bottom, New Size(My.Settings.PrinterWidth, printHeight))
        With P
            .FeedPaper(2)
            .RTL = False
            '    .PrintImageDirect(top)
            .PrintImageDirect(print)
            '   .PrintImageDirect(bottom)
            .FeedPaper(2)
            .EndDoc()

        End With
    End Sub

    Public Shared Function ResizeImage(ByVal image As Image,
  ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.NearestNeighbor

            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Public Function ToBlackAndWhite(ByVal bmp As Bitmap) As Bitmap
        Dim x As Integer
        Dim y As Integer
        Dim col As Color

        For x = 0 To bmp.Width - 1
            For y = 0 To bmp.Height - 1

                col = bmp.GetPixel(x, y)
                Dim aver
                aver = (CInt(col.R) + CInt(col.G) + CInt(col.B)) / 3
                Dim bwcol As Byte
                Select Case aver
                    Case Is > 212 + Brightness
                        bwcol = 255
                    Case Is > 170 + Brightness
                        bwcol = 225
                    Case Is > 127 + Brightness
                        bwcol = 175
                    Case Is > 85 + Brightness
                        bwcol = 125
                    Case Is > 42 + Brightness
                        bwcol = 75
                    Case Else
                        bwcol = 0
                End Select

                'R/G/B = (red * 0.30) + (green * 0.59) + (blue * 0.11)

                col = Color.FromArgb(255, CInt(bwcol), CInt(bwcol), CInt(bwcol))
                bmp.SetPixel(x, y, col)


            Next y
        Next x

        Return bmp
    End Function

    Private Sub BrightnessBar_Scroll(sender As Object, e As EventArgs) Handles BrightnessBar.Scroll
        Brightness = BrightnessBar.Value - 40
        Dim img As New Bitmap(TempBox.Image)
        'Dim img As New Bitmap(ImagePathTxt.Text)
        Dim printHeight As Integer = Math.Round(My.Settings.PrinterWidth / (img.Width / img.Height))
        'Dim print As Image = New Bitmap(My.Settings.PrinterWidth, printHeight)
        Dim print As Image = ResizeImage(img, New Size(My.Settings.PrinterWidth, printHeight))
        PictureBox1.Image = ToBlackAndWhite(print)
    End Sub

    Private Sub WebCamRestartBtn_Click(sender As Object, e As EventArgs) Handles WebCamRestartBtn.Click
        webcam.Continue()
    End Sub

    Private Sub WebCamCaptureBtn_Click(sender As Object, e As EventArgs) Handles WebCamCaptureBtn.Click
        webcam.Stop()
        TempBox.Image = PictureBox1.Image
        Dim img As New Bitmap(TempBox.Image)
        Dim printHeight As Integer = Math.Round(My.Settings.PrinterWidth / (img.Width / img.Height))
        'Dim print As Image = New Bitmap(My.Settings.PrinterWidth, printHeight)
        Dim print As Image = ResizeImage(img, New Size(My.Settings.PrinterWidth, printHeight))
        PictureBox1.Image = ToBlackAndWhite(print)
        ImagePathTxt.Text = "Camera image"
        CameraPrintBtn.Enabled = True
        BrightnessBar.Enabled = True
        CameraCaptured = True
    End Sub

    Private Sub WebCamSettingsBtn_Click(sender As Object, e As EventArgs) Handles WebCamSettingsBtn.Click
        webcam.ResolutionSetting()
        webcam.AdvanceSetting()
    End Sub

    Private Sub Monitor_Tick(sender As Object, e As EventArgs) Handles Monitor.Tick
        Dim x As Process = Process.GetCurrentProcess()
        DebugLabel.Text = Math.Round(x.WorkingSet64 / 1024 / 1024) & "M"
    End Sub
End Class