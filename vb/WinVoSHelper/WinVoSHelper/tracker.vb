Public Class tracker
    Dim updateSecond As Integer = 0 ' 0 if check failed, 5 if clock is accurate, 30 if clock is within greater tolerance (25s)
    Public Shared Function GetUnixTimestamp() As Int64 ' Use Int64, not interested in decimal places
        Return (My.Computer.Clock.GmtTime - New DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds ' Calculate seconds since UNIX epoch.
    End Function
    Private Sub x(sender As Object, e As EventArgs)
        Me.Height = 233

        Dim SingleControl As Control    ' Dummy to hold a form control
        For Each SingleControl In Me.Controls
            Dim chk As CheckBox = TryCast(SingleControl, CheckBox)
            If chk IsNot Nothing Then
                chk.Font = New Font(chk.Font, FontStyle.Regular)
            End If
        Next

        Select Case ""
            Case "Amlodd"
                chk_Amlodd.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)
            Case "Cadarn" ' This is a comment
                chk_Cadarn.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Crwys"
                chk_Crwys.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Hefin"
                chk_Hefin.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Iorwerth"
                chk_Iorwerth.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Ithell"
                chk_Ithell.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Meilyr"
                chk_Meilyr.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

            Case "Traehaearn"
                chk_Meilyr.Font = New Font(chk_Amlodd.Font, FontStyle.Bold)

        End Select



    End Sub

    Private Sub tracktime_Tick(sender As Object, e As EventArgs) Handles tracktime.Tick
        If (My.Computer.Clock.LocalTime.Minute = 0 & My.Computer.Clock.LocalTime.Second = 30) Then
            Me.Height = 341

        End If
    End Sub

    Private Sub tracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(GetUnixTimestamp)
    End Sub
End Class
