Public Class mpya

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mpya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnmetered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmetered.Click
        Me.Hide()
        meter.Show()
    End Sub

    Private Sub btnunmetered_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnunmetered.Click
        Me.Hide()
        unmeter.Show()
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("YOU ARE ABOUT TO EXIT THE SYSTEM.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
End Class