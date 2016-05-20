Public Class tracker
    Dim updateSecond As Integer = 0 ' 0 if check failed, 5 if clock is accurate, 30 if clock is within greater tolerance (25s)
    Dim haveInternet = 0
    Dim syncFlag = 1 ' 0 if the system clock is really accurate, 1 if it's slightly off, and 2 if it's totally off. Default to 1
    Dim oldBrowserText As String = "" ' Allows us to compare the old to the new value to see if we need to refresh again
    Dim forceEarlyRefresh As Boolean = False
    Public Shared Function GetUnixTimestamp() As Long ' Use Int64, not interested in decimal places
        Return (My.Computer.Clock.GmtTime - New DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds ' Calculate seconds since UNIX epoch.
    End Function
    Public Sub ProcessSuccessfulRequest()
        MsgBox("Debug: Successfully loaded VoS information (" & browser.Url.ToString & ")", MsgBoxStyle.Information, "Web-request notice")

        Dim browserString As String = browser.DocumentText

        If browserString = oldBrowserText Then
            forceEarlyRefresh = True
        End If
        ' Loop through every checkbox and restore them to their default state
        Dim SingleControl As Control
        For Each SingleControl In Me.Controls
            Dim chk As CheckBox = TryCast(SingleControl, CheckBox)
            If chk IsNot Nothing Then
                chk.Font = New Font(chk.Font, FontStyle.Regular)
            End If
        Next

        If browserString.Contains("a") Then
            chk_Amlodd.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)
        End If

        If browserString.Contains("b") Then
            chk_Cadarn.Font = New Font(chk_Cadarn.Font, FontStyle.Bold)
        End If
        If browserString.Contains("c") Then
            chk_Crwys.Font = New Font(chk_Crwys.Font, FontStyle.Bold)
        End If
        If browserString.Contains("d") Then
            chk_Hefin.Font = New Font(chk_Hefin.Font, FontStyle.Bold)
        End If
        If browserString.Contains("e") Then
            chk_Iorwerth.Font = New Font(chk_Iorwerth.Font, FontStyle.Bold)
        End If
        If browserString.Contains("f") Then
            chk_Ithell.Font = New Font(chk_Ithell.Font, FontStyle.Bold)
        End If
        If browserString.Contains("g") Then
            chk_Meilyr.Font = New Font(chk_Meilyr.Font, FontStyle.Bold)
        End If
        If browserString.Contains("h") Then
            chk_Trahaearn.Font = New Font(chk_Trahaearn.Font, FontStyle.Bold)
        End If
    End Sub
    Public Function HaveInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try

    End Function
    Private Sub tracktime_Tick(sender As Object, e As EventArgs) Handles tracktime.Tick
        If (My.Computer.Clock.LocalTime.Minute = 0 And My.Computer.Clock.LocalTime.Second = 20) Then
            browser.Navigate(browser.Url)
        End If

        If forceEarlyRefresh = True And My.Computer.Clock.LocalTime.Second = 0 Then
            browser.Navigate(browser.Url)
        End If
    End Sub

    Private Sub tracker_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If HaveInternetConnection() = True Then
            haveInternet = 1
        Else
            MsgBox("Couldn't verify connection to the internet, VoS updating may may not function correctly", MsgBoxStyle.Exclamation, "Internet issue")
        End If
        Debug.WriteLine(Int(GetUnixTimestamp))
    End Sub

    Private Sub browser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles browser.DocumentCompleted
        If Not IsNothing(browser) Then
            If Not IsNothing(browser.DocumentText) Then
                ProcessSuccessfulRequest()
                oldBrowserText = browser.DocumentText
            End If
        End If
    End Sub

    Private Sub epochBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles epochBrowser.DocumentCompleted
        If Not Nothing Then
            If Not IsNothing(epochBrowser.DocumentText) Then
                Dim epochStr As String = epochBrowser.DocumentText
                Dim epochInt As Long = CType(epochStr, Long)
                Dim difference As Integer = GetUnixTimestamp() - epochInt
                If difference <= 3 And difference >= -3 Then
                    syncFlag = 0 ' Very accurate clock
                ElseIf difference <= 12 And difference >= -24 Then
                    syncFlag = 1 ' Clock is decent
                    MsgBox("Your clock is slightly off. Check your clock is accurate to ensure the app works properly.", MsgBoxStyle.Information, "Info")
                Else
                    syncFlag = 2 ' Clock is terrible
                    MsgBox("Your clock is very inaccurate. VoS updating may may not function correctly.", MsgBoxStyle.Exclamation, "Inaccurate Clock")
                End If
            Else
                MsgBox("There was a problem getting time info from the server. VoS updating may may not function correctly.", MsgBoxStyle.Information, "Sync Issue")
            End If
        Else
            MsgBox("Issue when attempting to check time. Check network connectivity is active. VoS updating may may not function correctly.", MsgBoxStyle.Exclamation, "Sync Issue")
        End If


        epochBrowser.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        browser.Navigate(browser.Url)
    End Sub

    Private Sub chk_Amlodd_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Amlodd.CheckedChanged

    End Sub
End Class
