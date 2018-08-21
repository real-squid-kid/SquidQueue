Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim myFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                            "crash.log")

            Using sw As New StreamWriter(File.Open(myFilePath, FileMode.Append))
                sw.WriteLine(DateTime.Now)
                sw.WriteLine(e.Exception.ToString())
            End Using
            CrashForm.ex = e.Exception
            CrashForm.Show()
            '        MessageBox.Show("An unexcpected error occured. Application will be terminated.")
            e.ExitApplication = False
        End Sub
    End Class
End Namespace
