Public Class frmInGameOptions
    Private Sub frmInGameOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmInGameMenu.Show()
        Me.Close()
    End Sub
End Class