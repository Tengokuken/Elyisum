Public Class frmMap
    Private Sub Label4_MouseClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseClick
        Me.Hide()
        frmMainTown.Show()
        frmMainVolcano.Hide()
        frmInn.Hide()
        frmDesert.Hide()
        frmForest.Hide()
        frmNavalCave.Hide()
    End Sub
    Private Sub Label5_MouseClick(sender As Object, e As MouseEventArgs) Handles Label5.MouseClick
        Me.Hide()
        frmVolcano.Show()
        frmInn.Hide()
        frmMainTown.Hide()
        frmDesert.Hide()
        frmForest.Hide()
        frmNavalCave.Hide()
    End Sub

    Private Sub Label2_MouseClick(sender As Object, e As MouseEventArgs) Handles Label2.MouseClick
        Me.Hide()
        frmInn.Hide()
        frmMainTown.Hide()
        frmMainVolcano.Hide()
        frmForest.Hide()
        frmDesert.Show()
        frmNavalCave.Hide()
    End Sub
    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        Me.Hide()
        frmForest.Show()
        frmMainTown.Hide()
        frmMainVolcano.Hide()
        frmInn.Hide()
        frmDesert.Hide()
        frmNavalCave.Hide()
    End Sub
    Private Sub Label1_MouseClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseClick
        Me.Hide()
        frmNavalCave.Show()
        frmForest.Hide()
        frmMainTown.Hide()
        frmMainVolcano.Hide()
        frmInn.Hide()
        frmDesert.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        frmCastleEntrance.Show()
    End Sub

End Class