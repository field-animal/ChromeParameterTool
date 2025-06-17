Public Class Form1
    Dim pathChrome As String
    Dim launcherParameter As String
    Dim logPath As String
    Dim targetURL As String = " https://ki.sesojung.com"


    Function findChrome(chromePath) As Boolean
        If System.IO.File.Exists(chromePath) Then
            Return True
        Else
            MsgBox("크롬 없음")
            Return False
        End If
    End Function

    Function setLogPath(logPath As String)
        If Not (My.Computer.FileSystem.DirectoryExists(logPath)) Then
            My.Computer.FileSystem.CreateDirectory(logPath)
        End If
        Return logPath
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isPROD.Checked Then
            '상용 서버 접속
            targetURL = " https://ki.sesojung.com"
            logPath = setLogPath("c:\logs_prod\")
        Else
            '개발 서버 접속
            targetURL = " https://kioskdev.sesojung.com"
            logPath = setLogPath("c:\logs_dev\")
        End If

        logPath &= My.Computer.Name.TrimEnd & Format(Now(), "_yyMMddtthhmmss") & ".log"

        launcherParameter = " --disable-web-security --remote-allow-origins=* --remote-debugging-port=9222 --user-data-dir=c:\chromeUserData --disable-features=ChromeWhatsNewUI --enable-logging=info --v=0 --force-device-scale-factor=1 --no-default-browser-check --no-first-run  --log-file=" & logPath
        If Me.isKiosk.Checked Then _
            launcherParameter &= " --kiosk " ' kiosk parameter 추가

        pathChrome = "C:\Program Files\Google\Chrome\Application\chrome.exe"
        If findChrome(pathChrome) Then
            pathChrome = """" & pathChrome & """"
            Shell($"{pathChrome}{launcherParameter}{targetURL}", AppWinStyle.NormalFocus)
        End If

        Dim debuggingJson As HttpStyleUriParser

        Dim strData As String = debuggingJson = UriFormat(""localhost:9222/json")


    End Sub
End Class
