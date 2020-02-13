Public Class frmStatus
    Private fStats As Boolean
    Private Sub frmStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnMale.Text = maleName
        btnFemale.Text = femaleName

        Call ShowStats()
        'calls a little tutorial when you first open the screen
    End Sub

    Private Sub ShowStats()
        If fStats = False Then
            lblVit.Text = "Vitality: " & mVit
            lblStr.Text = "Strength: " & mStr
            lblInt.Text = "Intelligence: " & mInt
            lblAgi.Text = "Agility: " & mAgi
            lblEXP.Text = "EXP: " & EXP
            mMaxHP = CalculateHP(mLevel, mVit)
            lblHP.Text = "HP: " & mCurrHP & " / " & mMaxHP
        ElseIf fStats = True
            lblVit.Text = "Vitality: " & fVit
            lblStr.Text = "Strength: " & fStr
            lblInt.Text = "Intelligence: " & fInt
            lblAgi.Text = "Agility: " & fAgi
            lblEXP.Text = "EXP: " & fEXP
            fMaxHP = CalculateHP(flevel, fVit)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmInGameMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click, btnFemale.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                fStats = False
            Case 2
                fStats = True
        End Select

        Call ShowStats()
    End Sub
End Class