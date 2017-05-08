Imports System.Drawing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Public Class PrinterClass
    Private p As Printer
    Private _Path As String
    Private _Align As TextAlignment = TextAlignment.Default
    Private bIsDebug As Boolean = False
    Public Enum TextAlignment As Byte
        [Default] = 0
        Left
        Center
        Right
    End Enum
#Region "Constructors"
    Public Sub New(ByVal AppPath As String)
        SetPrinterName(My.Settings.PrinterName, AppPath)
    End Sub
    Public Sub New(ByVal strPrinterName As String, ByVal AppPath As String)
        SetPrinterName(strPrinterName, AppPath)
    End Sub
    Private Sub SetPrinterName(ByVal PrinterName As String, ByVal AppPath As String)
        Dim prnPrinter As Printer

        For Each prnPrinter In Printers
            If prnPrinter.DeviceName = PrinterName Then
                p = prnPrinter
                Exit For
            End If
        Next
        p.DocumentName = "SquidQueue Slip"
        '   Me.Path = AppPath
        If bIsDebug Then
            p.PrintAction = Printing.PrintAction.PrintToPreview
        End If
    End Sub
#End Region
#Region "Font"

    Public Property Alignment() As TextAlignment
        Get
            Return _Align
        End Get
        Set(ByVal value As TextAlignment)
            _Align = value
        End Set
    End Property
    Public Sub AlignLeft()
        _Align = TextAlignment.Left
    End Sub
    Public Sub AlignCenter()
        _Align = TextAlignment.Center
    End Sub
    Public Sub AlignRight()
        _Align = TextAlignment.Right
    End Sub
    Public Property FontName() As String
        Get
            Return p.FontName
        End Get
        Set(ByVal value As String)
            p.FontName = value
        End Set
    End Property

    Public Property FontSize() As Single
        Get
            Return p.FontSize
        End Get
        Set(ByVal value As Single)
            p.FontSize = value
        End Set
    End Property
    Public Property Bold() As Boolean
        Get
            Return p.FontBold
        End Get
        Set(ByVal value As Boolean)
            p.FontBold = value
        End Set
    End Property
    Public Sub DrawLine()
        p.DrawWidth = 5
        p.Line(p.Width, p.CurrentY)
        p.CurrentY += 20 ' to move under the drawn line
    End Sub
    Public Sub NormalFont()
        Me.FontSize = 9.5F
    End Sub
    Public Sub BigFont()
        Me.FontSize = 15.0F
    End Sub
    Public Sub HugeFont()
        Me.FontSize = 48.0F
    End Sub
    Public Sub SmallFont()
        Me.FontSize = 6.0F
    End Sub
    Public Sub TinyFont()
        'Unreadable, debug only!
        Me.FontSize = 4.0F
    End Sub

    Public Sub SetFont(Optional ByVal FontSize As Single = 9.5F,
Optional ByVal FontName As String = Nothing,
Optional ByVal BoldType As Boolean = False)
        Me.FontSize = FontSize
        Me.FontName = My.Settings.PrinterFont
        Me.Bold = BoldType
    End Sub
#End Region
#Region "Images"
    Public Property Path() As String
        Get
            Return _Path
        End Get
        Set(ByVal value As String)
            _Path = value
        End Set
    End Property
    Public Sub PrintLogo()
        If Form1.PrintLogoChk.Checked = True Then
            Try
                Me.PrintImage(My.Settings.LogoPath)
            Catch
                MessageBox.Show("Can't print logo, incorrect file provided or no file provided at all.", "SquidQueue", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End If

    End Sub
    Private Sub PrintImage(ByVal FileName As String)
        Dim pic As Image

        pic = pic.FromFile(FileName)

        p.PaintPicture(pic, p.CurrentX, p.CurrentY)
        p.CurrentY = p.CurrentY + pic.Height * 12

    End Sub
#End Region
#Region "Control"

    Public Sub NewPage()
        p.NewPage()
    End Sub
    Public Property RTL() As Boolean
        Get
            Return p.RightToLeft
        End Get
        Set(ByVal value As Boolean)
            p.RightToLeft = value
        End Set
    End Property
    Public Sub FeedPaper(Optional ByVal nlines As Integer = 3)
        For i As Integer = 1 To nlines
            Me.WriteLine(" ")
        Next
    End Sub

    Public Sub GotoCol(Optional ByVal ColNumber As Integer = 0)
        Dim ColWidth As Single = p.Width / 48
        p.CurrentX = ColWidth * ColNumber
    End Sub
    Public Sub GotoSixth(Optional ByVal nSixth As Integer = 1)
        Dim OneSixth As Single = p.Width / 6
        p.CurrentX = OneSixth * (nSixth - 1)
    End Sub

    Public Sub UnderlineOn()
        p.FontUnderline = True
    End Sub
    Public Sub UnderlineOff()
        p.FontUnderline = False
    End Sub
    Public Sub EndDoc()
        p.EndDoc()
    End Sub
    Public Sub EndJob()
        Me.EndDoc()
    End Sub
    Public Sub WriteLine(ByVal Text As String)
        Dim sTextWidth As Single = p.TextWidth(Text)
        Select Case _Align
            Case TextAlignment.Default
                'do nothing
            Case TextAlignment.Left
                p.CurrentX = 0
            Case TextAlignment.Center
                p.CurrentX = (p.Width - sTextWidth) / 2.7
            Case TextAlignment.Right
                p.CurrentX = (p.Width - sTextWidth)
        End Select
        If My.Settings.OmitCalibration = True Then
            p.Print(Text)
            Exit Sub
        Else
            If Me.Bold = False Then
                '       'huge
                If Me.FontSize = 48.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(0))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'big
                If Me.FontSize = 15.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(1))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'normal
                If Me.FontSize = 9.5F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(2))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'small
                If Me.FontSize = 6.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(3))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                If Me.FontSize = 4.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, 50)
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
            Else
                '       'huge
                If Me.FontSize = 48.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(4))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'big
                If Me.FontSize = 15.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(5))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'normal
                If Me.FontSize = 9.5F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(6))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
                'small
                If Me.FontSize = 6.0F Then
                    Dim t As List(Of String)
                    t = WrapText(Text, My.Settings.PrinterCalibrate(7))
                    For a = 0 To t.Count - 1
                        p.Print(t(a))
                    Next
                    Exit Sub
                End If
            End If
        End If
    End Sub
#End Region

    Public Sub WriteChars(ByVal Text As String)
        p.Write(Text)
    End Sub
    Public Sub CutPaper()
        p.NewPage()
    End Sub
    Public Function WrapText(ByVal Text As String, ByVal LineLength As Integer) As List(Of String)

        Dim ReturnValue As New List(Of String)
        ' Remove leading and trailing spaces
        'Text = Trim(Text)


        Dim Words As String() = Text.Split(" ")
        Dim CurrentLine As String = ""

        For CurrentWord = 0 To Words.Length - 1
            If CurrentLine.Length + Words(CurrentWord).Length < LineLength Then
                If CurrentLine = "" Then
                    CurrentLine += Words(CurrentWord)
                Else
                    CurrentLine += " "
                    CurrentLine += Words(CurrentWord)
                End If
            Else
                ReturnValue.Add(CurrentLine)
                If Words(CurrentWord).Length <= LineLength Then
                    CurrentLine = Words(CurrentWord)
                Else
                    CurrentLine = Words(CurrentWord).Substring(0, LineLength)
                    ReturnValue.Add(CurrentLine)
                    CurrentLine = Words(CurrentWord).Substring(LineLength - 1, Words(CurrentWord).Length - LineLength + 1)
                End If
            End If

        Next
        ReturnValue.Add(CurrentLine)

        Return ReturnValue
    End Function


End Class
