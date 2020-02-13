
Public Class frmInGameMenu
    Private Sub frmInGameMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMaleName.Text = maleName
        lblMLevel.Text = "Level: " & mLevel
        mMaxHP = CalculateHP(mLevel, mVit)
        lblMHP.Text = "HP: " & vbTab & mCurrHP & " / " & mMaxHP
        lblFemaleName.Text = femaleName
        lblFLevel.Text = "Level: " & flevel
        fMaxHP = CalculateHP(flevel, fVit)
        lblFHP.Text = "HP: " & vbTab & fCurrHP & " / " & fMaxHP
        lblArea.Text = "Location: " & area
        lblMoney.Text = gold & "G"
        Me.Focus()
    End Sub

    Private Sub frmInGameMenu_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            returnToPrev = True
            Call HiddenForm(area)
            returnToPrev = False
            Me.Hide()
        End If
    End Sub

    Private Sub btnGoToItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoToItems.Click, btnGoToSkills.Click, _
        btnGoToStatus.Click, btnGoToOptions.Click, btnGoToSave.Click, btnQuitGame.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                frmItems.Show()
                Me.Close()
            Case 2
                frmSkills.Show()
                Me.Close()
            Case 3
                frmStatus.Show()
                Me.Hide()
            Case 4
                frmInGameOptions.Show()
                Me.Hide()
            Case 5
                frmSave.Show()
                Me.Hide()
            Case 6
                Dim result As Integer

                result = MessageBox.Show("Are you sure you want to quit the game and return to title?", "Elysium", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    frmTitle.Show()
                    Me.Hide()
                ElseIf result = DialogResult.No Then
                    Return
                End If
        End Select
    End Sub
End Class