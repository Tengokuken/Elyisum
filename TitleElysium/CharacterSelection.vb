Public Class frmCharSelect

    Dim named As Boolean
    Dim confirmed As Boolean

    Private Sub frmCharSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call RestartNaming()
    End Sub

    Private Sub tmrChar_Tick(sender As System.Object, e As System.EventArgs) Handles tmrChar.Tick

        If picChar1.Visible = True Then
            picChar1.Visible = False
            picChar2.Visible = True
        ElseIf picChar2.Visible = True Then
            picChar2.Visible = False
            picChar3.Visible = True
        ElseIf picChar3.Visible = True Then
            picChar3.Visible = False
            picChar4.Visible = True
        ElseIf picChar4.Visible = True Then
            picChar4.Visible = False
            picChar1.Visible = True
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged
        If txtName.Text.Trim().Length = 0 Then
            btnConfirm.Enabled = False
        Else
            btnConfirm.Enabled = True
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        Call ConfirmName(named)
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        mLevel = 1
        flevel = 1
        mVit = 11
        mStr = 13
        mInt = 10
        mAgi = 9
        fVit = 9
        fStr = 11
        fInt = 15
        fAgi = 12
        mMaxHP = CalculateHP(mLevel, mVit)
        fMaxHP = CalculateHP(flevel, fVit)
        mCurrHP = mMaxHP
        fCurrHP = fMaxHP
        frmInn.Show()
        Me.Hide()
    End Sub

    Private Sub btnNo_Click(sender As System.Object, e As System.EventArgs) Handles btnNo.Click
        Call RestartNaming()
    End Sub

    Private Sub ConfirmName(ByRef named As Boolean)
        If named = False Then
            maleName = txtName.Text
            txtName.Clear()
            txtName.Focus()
            picChar1.Image = My.Resources.heroine1
            picChar2.Image = My.Resources.heroine2
            picChar3.Image = My.Resources.heroine3
            picChar4.Image = My.Resources.heroine4
            lblName.Text = "Enter the name of the female hero:"
            named = True
        ElseIf named = True Then
            tmrChar.Enabled = False
            femaleName = txtName.Text
            Call FinalConfirm()
        End If
    End Sub

    Private Sub RestartNaming()
        tmrChar.Start()
        lblName.Text = "Enter the name of the male hero:"
        lblMale.Visible = False
        lblFemale.Visible = False
        maleName = ""
        femaleName = ""
        picChar1.Image = My.Resources.hero1
        picChar2.Image = My.Resources.hero2
        picChar3.Image = My.Resources.hero3
        picChar4.Image = My.Resources.hero4
        txtName.Visible = True
        picChar1.Visible = True
        picChar2.Visible = True
        picChar3.Visible = True
        picChar4.Visible = True
        picMale.Visible = False
        picFemale.Visible = False
        btnYes.Visible = False
        btnNo.Visible = False
        btnConfirm.Visible = True
        btnExit.Visible = True
        btnConfirm.Enabled = False
        named = False
    End Sub

    Private Sub FinalConfirm()
        txtName.Clear()
        txtName.Focus()

        tmrChar.Stop()
        lblName.Text = "Are these names correct?"
        lblMale.Text = maleName
        lblFemale.Text = femaleName
        picMale.Image = My.Resources.heroBig
        picFemale.Image = My.Resources.heroineBig
        picMale.Visible = True
        picFemale.Visible = True
        btnYes.Visible = True
        btnNo.Visible = True
        btnConfirm.Visible = False
        btnExit.Visible = False
        picMale.Visible = True
        picFemale.Visible = True
        picChar1.Visible = False
        picChar2.Visible = False
        picChar3.Visible = False
        picChar4.Visible = False
        txtName.Visible = False
        lblMale.Visible = True
        lblFemale.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmTitle.Show()
        Me.Close()
    End Sub
End Class