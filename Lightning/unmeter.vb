Public Class unmeter
    Dim unit As Double
    Dim dis1 As Double
    Dim dis2 As Double
    Public tot1 As Double
    Public tot2 As Double
    Public tot3 As Double
    Public units As Double

    Private Sub txtunits_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtunits.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Enter A valid Value")
        End If
    End Sub
    Private Sub txtunits_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtunits.TextChanged
        receipt.txtunits.Text = txtunits.Text
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnvisa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvisa.Click
        If txtunits.Text < 100 Then
            unit = txtunits.Text * 33


            tot2 = unit

            tot3 = tot2 - (tot2 * 0.05)
            txtamt.Text = tot3
        ElseIf txtunits.Text >= 100 Then
            unit = txtunits.Text * 30

            dis2 = unit * 0.09
            tot1 = unit - dis2
            tot2 = tot1

            tot3 = tot2 - (tot2 * 0.05)

            txtamt.Text = tot3
        Else
            MsgBox("invalid!!!")
        End If
    End Sub

    Private Sub btnmanual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmanual.Click
        If txtunits.Text < 100 Then
            unit = txtunits.Text * 33

            tot2 = unit



            txtamt.Text = tot2
        ElseIf txtunits.Text >= 100 Then
            unit = txtunits.Text * 30

            dis2 = unit * 0.09
            tot1 = unit - dis2
            tot2 = tot1

            txtamt.Text = tot2
        Else
            MsgBox("invalid!!!")
        End If
    End Sub

    Private Sub txtmeterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        receipt.txtmeter.Text = "Nullable"
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        receipt.txtname.Text = txtname.Text
    End Sub

    Private Sub calc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calc.Click

        Me.Hide()
        receipt.Show()
    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged
        receipt.txtamt.Text = txtamt.Text
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        mpya.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("YOU ARE ABOUT TO EXIT THE SYSTEM.", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtarea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtarea.TextChanged
        receipt.txtarea.Text = txtarea.Text
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class