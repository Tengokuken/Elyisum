Public Class frmOptions

    Private Sub chkMute_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMute.CheckedChanged
        If chkMute.Checked = True Then
            My.Computer.Audio.Stop()
        Else
            Call PlayMusic()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        frmTitle.Show()
        Me.Close()
    End Sub

    Private Sub lblSound_Click(sender As Object, e As EventArgs) Handles lblSound.Click

    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class