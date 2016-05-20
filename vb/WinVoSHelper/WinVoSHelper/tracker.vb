Public Class tracker
    Dim updateSecond As Integer = 0 ' 0 if check failed, 5 if clock is accurate, 30 if clock is within greater tolerance (25s)
    Dim haveInternet = 0
    Dim syncFlag = 1 ' 0 if the system clock is really accurate, 1 if it's slightly off, and 2 if it's totally off. Default to 1
    Dim enviroString As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\voshelper.txt"
    Dim oldBrowserText As String = "" ' Allows us to compare the old to the new value to see if we need to refresh again
    Dim forceEarlyRefresh As Boolean = False
    Dim amloddTime As Integer
    Dim cadarnTime As Integer
    Dim crwysTime As Integer
    Dim hefinTime As Integer
    Dim iorwerthTime As Integer
    Dim ithellTime As Integer
    Dim meilyrTime As Integer
    Dim trahaearnTime As Integer
    Dim bgColor As Integer = 1
    Dim txtColor As Integer = 0
    Dim vosAlerts As Boolean
    Dim forgetAlerts As Boolean
    Public Shared Function GetUnixTimestamp() As Long ' Use Int64, not interested in decimal places
        Return (My.Computer.Clock.GmtTime - New DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds ' Calculate seconds since UNIX epoch.
    End Function
    Public Sub ProcessSuccessfulRequest()
        Dim notifyTxt As New ArrayList
        'MsgBox("Debug: Successfully loaded VoS information (" & browser.Url.ToString & ")", MsgBoxStyle.Information, "Web-request notice")

        Dim browserString As String = browser.DocumentText

        If Not browserString.Length = 2 Then
            MsgBox("Recieved an unexpected response from server. Check internet connection.", MsgBoxStyle.Critical, "VoS Error")
        End If

        If browserString = oldBrowserText Then
            forceEarlyRefresh = True
            Exit Sub
        Else
            forceEarlyRefresh = False
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
            notifyTxt.Add("Amlodd")
        End If

        If browserString.Contains("b") Then
            chk_Cadarn.Font = New Font(chk_Cadarn.Font, FontStyle.Bold)
            notifyTxt.Add("Cadarn")
        End If
        If browserString.Contains("c") Then
            chk_Crwys.Font = New Font(chk_Crwys.Font, FontStyle.Bold)
            notifyTxt.Add("Crwys")
        End If
        If browserString.Contains("d") Then
            chk_Hefin.Font = New Font(chk_Hefin.Font, FontStyle.Bold)
            notifyTxt.Add("Hefin")
        End If
        If browserString.Contains("e") Then
            chk_Iorwerth.Font = New Font(chk_Iorwerth.Font, FontStyle.Bold)
            notifyTxt.Add("Iorwerth")
        End If
        If browserString.Contains("f") Then
            chk_Ithell.Font = New Font(chk_Ithell.Font, FontStyle.Bold)
            notifyTxt.Add("Ithell")
        End If
        If browserString.Contains("g") Then
            chk_Meilyr.Font = New Font(chk_Meilyr.Font, FontStyle.Bold)
            notifyTxt.Add("Meilyr")
        End If
        If browserString.Contains("h") Then
            chk_Trahaearn.Font = New Font(chk_Trahaearn.Font, FontStyle.Bold)
            notifyTxt.Add("Trahaearn")
        End If

        If alertOnUpdate.CheckState = CheckState.Checked Then
            notify.BalloonTipText = "The Voice of Seren is active in the " & notifyTxt(0) & " and " & notifyTxt(1) & " district."
            notify.BalloonTipIcon = ToolTipIcon.Info
            notify.BalloonTipTitle = "Voice of Seren Update"
            notify.ShowBalloonTip(2000)

            ' load text into a var at the end so we can only update if the text really is old
            oldBrowserText = browser.DocumentText

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
        If (My.Computer.Clock.LocalTime.Minute = 0 And My.Computer.Clock.LocalTime.Second = 20) Then ' refresh past the hour
            If syncFlag = 1 Then
                browser.Navigate(browser.Url)
            End If
        End If

        If (My.Computer.Clock.LocalTime.Minute = 0 And My.Computer.Clock.LocalTime.Second = 5) Then ' refresh past the hour
            If syncFlag = 0 Then
                browser.Navigate(browser.Url)
            End If
        End If

        If (My.Computer.Clock.LocalTime.Minute = 2 And My.Computer.Clock.LocalTime.Second = 15) Then ' refresh past the hour
            If syncFlag = 2 Then
                browser.Navigate(browser.Url)
            End If
        End If

        If forceEarlyRefresh = True And My.Computer.Clock.LocalTime.Second = 0 Then ' refresh every minute if we got old data last time for some reason
            browser.Navigate(browser.Url)
        End If

        ' now do logic to keep the user updated if the clan is no longer suspicious of them..

        Dim oldBalloon As String = notify.BalloonTipText

        Dim unixTime As Integer = GetUnixTimestamp()

        If unixTime = amloddTime Then
            chk_Amlodd.Checked = False
            notify.BalloonTipText = "Clan Amlodd has forgotten about your pickpocketing"
        End If

        If unixTime = cadarnTime Then
            chk_Cadarn.Checked = False
            notify.BalloonTipText = "Clan Cadarn has forgotten about your pickpocketing"
        End If

        If unixTime = crwysTime Then
            chk_Crwys.Checked = False
            notify.BalloonTipText = "Clan Crwys has forgotten about your pickpocketing"
        End If

        If unixTime = hefinTime Then
            chk_Hefin.Checked = False
            notify.BalloonTipText = "Clan Hefin has forgotten about your pickpocketing"
        End If

        If unixTime = iorwerthTime Then
            chk_Iorwerth.Checked = False
            notify.BalloonTipText = "Clan Iorwerth has forgotten about your pickpocketing"
        End If

        If unixTime = ithellTime Then
            chk_Ithell.Checked = False
            notify.BalloonTipText = "Clan Ithell has forgotten about your pickpocketing"
        End If

        If unixTime = meilyrTime Then
            chk_Meilyr.Checked = False
            notify.BalloonTipText = "Clan Meilyr has forgotten about your pickpocketing"
        End If

        If unixTime = trahaearnTime Then
            chk_Trahaearn.Checked = False
            notify.BalloonTipText = "Clan Trahaearn has forgotten about your pickpocketing"
        End If

        If AlertMeWhenClansForgetToolStripMenuItem.CheckState = CheckState.Checked Then
            If Not oldBalloon = notify.BalloonTipText Then 'something got updated
                notify.BalloonTipTitle = "Clan Information"
                notify.ShowBalloonTip(2000)
            End If
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
            End If
        End If
    End Sub

    Private Sub epochBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles epochBrowser.DocumentCompleted
        If Not Nothing Then
            If Not IsNothing(epochBrowser.DocumentText) Then
                Dim epochStr As String = epochBrowser.DocumentText
                Dim epochInt As Long = CType(epochStr, Long)
                Dim difference As Integer = GetUnixTimestamp() - epochInt
                If difference <= 4 And difference >= -4 Then
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

    Private Sub chk_All_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Amlodd.CheckedChanged, chk_Cadarn.CheckedChanged, chk_Crwys.CheckedChanged, chk_Hefin.CheckedChanged, chk_Iorwerth.CheckedChanged, chk_Ithell.CheckedChanged, chk_Meilyr.CheckedChanged, chk_Trahaearn.CheckedChanged
        Const delayConstant As Integer = 1200

        Dim ck As CheckBox = CType(sender, CheckBox)

        Select Case CInt(ck.Tag)
            Case 1 'Amlodd
                If chk_Amlodd.CheckState = CheckState.Checked Then
                    amloddTime = (GetUnixTimestamp() + delayConstant)
                Else
                    amloddTime = 0
                End If
            Case 2 ' Cadarn
                If chk_Cadarn.CheckState = CheckState.Checked Then
                    cadarnTime = (GetUnixTimestamp() + delayConstant)
                Else
                    cadarnTime = 0
                End If
            Case 3 ' Crwys
                If chk_Crwys.CheckState = CheckState.Checked Then
                    crwysTime = (GetUnixTimestamp() + delayConstant)
                Else
                    crwysTime = 0
                End If
            Case 4 ' Hefin
                If chk_Hefin.CheckState = CheckState.Checked Then
                    hefinTime = (GetUnixTimestamp() + delayConstant)
                Else
                    hefinTime = 0
                End If
            Case 5 ' Iorwerth
                If chk_Iorwerth.CheckState = CheckState.Checked Then
                    iorwerthTime = (GetUnixTimestamp() + delayConstant)
                Else
                    iorwerthTime = 0
                End If
            Case 6 ' Ithell
                If chk_Ithell.CheckState = CheckState.Checked Then
                    ithellTime = (GetUnixTimestamp() + delayConstant)
                Else
                    ithellTime = 0
                End If
            Case 7 ' Meilyr
                If chk_Meilyr.CheckState = CheckState.Checked Then
                    meilyrTime = (GetUnixTimestamp() + delayConstant)
                Else
                    meilyrTime = 0
                End If
            Case 8 ' Trahaearn
                If chk_Trahaearn.CheckState = CheckState.Checked Then
                    trahaearnTime = (GetUnixTimestamp() + delayConstant)
                Else
                    trahaearnTime = 0
                End If
        End Select
    End Sub

    Private Sub SetTransparencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetTransparencyToolStripMenuItem.Click
        transparency.Show()
    End Sub

    Private Sub HideAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideAppToolStripMenuItem.Click
        If HideAppToolStripMenuItem.CheckState = CheckState.Checked Then
            HideAppToolStripMenuItem.CheckState = CheckState.Unchecked
            Me.Visible = True
        Else
            HideAppToolStripMenuItem.CheckState = CheckState.Checked
            Me.Visible = False
        End If
    End Sub

    Private Sub AlertMeWhenClansForgetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlertMeWhenClansForgetToolStripMenuItem.Click
        If AlertMeWhenClansForgetToolStripMenuItem.CheckState = CheckState.Checked Then
            AlertMeWhenClansForgetToolStripMenuItem.CheckState = CheckState.Unchecked
        Else
            AlertMeWhenClansForgetToolStripMenuItem.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub ExitAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAppToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TransparentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransparentToolStripMenuItem.Click
        Me.TransparencyKey = Color.DarkGray
        Me.BackColor = Color.DarkGray
        bgColor = 0
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = SystemColors.Control
        bgColor = 1
    End Sub

    Private Sub RuneScapeBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RuneScapeBlueToolStripMenuItem.Click
        Me.BackColor = Color.FromArgb(12, 26, 35)
        bgColor = 2
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        Me.BackColor = Color.Black
        bgColor = 3
    End Sub

    Private Sub WhiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem.Click
        Me.BackColor = Color.White
        bgColor = 4
    End Sub

    Private Sub BlackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem1.Click
        Dim SingleControl As Control
        For Each SingleControl In Me.Controls
            Dim chk As CheckBox = TryCast(SingleControl, CheckBox)
            If chk IsNot Nothing Then
                chk.ForeColor = Color.Black
            End If
        Next
        txtColor = 0
    End Sub

    Private Sub WhiteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WhiteToolStripMenuItem1.Click
        Dim SingleControl As Control
        For Each SingleControl In Me.Controls
            Dim chk As CheckBox = TryCast(SingleControl, CheckBox)
            If chk IsNot Nothing Then
                chk.ForeColor = Color.White
            End If
        Next
        txtColor = 1
    End Sub

    Private Sub ShowIconOnTaskbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIconOnTaskbarToolStripMenuItem.Click
        If ShowIconOnTaskbarToolStripMenuItem.CheckState = CheckState.Checked Then
            ShowIconOnTaskbarToolStripMenuItem.CheckState = CheckState.Unchecked
            Me.ShowInTaskbar = False
        Else
            ShowIconOnTaskbarToolStripMenuItem.CheckState = CheckState.Checked
            Me.ShowInTaskbar = True
        End If
    End Sub
    Private Sub tracker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' user closed form. Write their settings to environment
        Dim strToWrite As String = ""

        ' go through everything we want to check and add it to a string

        'first check if we should notify 
        If AlertMeWhenClansForgetToolStripMenuItem.CheckState = CheckState.Checked Then
            strToWrite = strToWrite & "1"
        Else
            strToWrite = strToWrite & "0"
        End If

        ' check if they want vos updates
        If alertOnUpdate.CheckState = CheckState.Checked Then
            strToWrite = strToWrite & "1"
        Else
            strToWrite = strToWrite & "0"
        End If

        'check what the background colour is
        strToWrite = strToWrite & bgColor

        'check what the textcolor is
        strToWrite = strToWrite & txtColor

        ' add the opacity
        strToWrite = strToWrite & Me.Opacity

        ' add whether or not we show on the taskbar
        If ShowIconOnTaskbarToolStripMenuItem.CheckState = CheckState.Checked Then
            strToWrite = strToWrite & "1"
        Else
            strToWrite = strToWrite & "0"
        End If

        ' finally write the contents to file
        My.Computer.FileSystem.WriteAllText(enviroString, strToWrite, False)
    End Sub

    Private Sub tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' on load check if we have the settings file and if we do load settings from it
        Try
            If My.Computer.FileSystem.FileExists(enviroString) Then
                Dim infoTxt As String = My.Computer.FileSystem.ReadAllText(enviroString)

                If infoTxt.Chars(0) = "0" Then
                    AlertMeWhenClansForgetToolStripMenuItem_Click(sender, e)
                End If

                If infoTxt.Chars(1) = "0" Then
                    alertOnUpdate.CheckState = CheckState.Unchecked
                End If

                Select Case infoTxt.Chars(2)
                    Case "0"
                        TransparentToolStripMenuItem_Click(sender, e)
                    Case "1"
                    'don't need to do anything
                    Case "2"
                        RuneScapeBlueToolStripMenuItem_Click(sender, e)
                    Case "3"
                        BlackToolStripMenuItem_Click(sender, e)
                    Case "4"
                        WhiteToolStripMenuItem_Click(sender, e)
                End Select

                If infoTxt(3) = "1" Then
                    WhiteToolStripMenuItem1_Click(sender, e)
                End If

                If Not infoTxt(4) = "1" Then
                    Dim opacityStr As String = infoTxt(4) & "." & infoTxt(6) & infoTxt(7)
                    Me.Opacity = System.Convert.ToDecimal(opacityStr)
                Else
                    Me.Opacity = 1
                End If

                If infoTxt(infoTxt.Length - 1) = "1" Then
                    ShowIconOnTaskbarToolStripMenuItem_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error occured while loading your presets. You will have to reselect options.", MsgBoxStyle.Information, "Couldn't load presets")
        End Try

    End Sub

    Private Sub LockLocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockLocationToolStripMenuItem.Click
        If LockLocationToolStripMenuItem.CheckState = CheckState.Checked Then
            LockLocationToolStripMenuItem.CheckState = CheckState.Unchecked
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.Location = New Point(Me.Location.X - 8, Me.Location.Y - 31)
        Else
            LockLocationToolStripMenuItem.CheckState = CheckState.Checked
            Me.FormBorderStyle = FormBorderStyle.None
            Me.Location = New Point(Me.Location.X + 8, Me.Location.Y + 31)
        End If
    End Sub
End Class
