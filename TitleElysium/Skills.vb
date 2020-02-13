'REMINDER: ADD MP COSTS
Public Class frmSkills
    Private fSelect As Boolean
    Private heal As Integer

    Private Sub frmSkills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMale.Text = maleName
        btnFemale.Text = femaleName
        btnTargetMale.Text = maleName
        btnTargetFemale.Text = femaleName
        ShowSkills()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmInGameMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click, btnFemale.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                fSelect = False
            Case 2
                fSelect = True
        End Select
        btnUseSpell.Visible = False
        btnTargetBoth.Visible = False
        btnTargetMale.Visible = False
        btnTargetFemale.Visible = False
        lblDesc.Text = "Skill description"
        lstSkills.Items.Clear()
        Call ShowSkills()
    End Sub

    Private Sub ShowSkills()
        'NOTE: This method will not work in VB2010. Use Dim num() As String{"Protect","Quick Strike","Heavy Blow","Drain","Windslash","Revenge", _ 
        '"Shock Strike","Sear Slash","Demon Slayer","Legend"} instead!
        Dim mSkills = New String() {"Protect", "Quick Strike", "Heavy Blow", "Drain", "Wind Slash", "Revenge",
            "Shock Strike", "Sear Slash", "Demon Slayer", "Legend"}
        Dim fSkills = New String() {"Heal", "Arcana", "Barrier", "Tremors", "Agonize", "Healmore",
            "Glaciate", "Starstorm", "Holy", "Meteor"}

        Dim num As Integer
        Dim level As Integer

        If fSelect = False Then
            level = mLevel
        ElseIf fSelect = True
            level = flevel
        End If

        Select Case level
            Case 1
                num = 1
            Case 2
                num = 2
            Case 3
                num = 3
            Case 4 To 5
                num = 4
            Case 6 To 7
                num = 5
            Case 8 To 11
                num = 6
            Case 12 To 14
                num = 8
            Case 15 To 20
                If ultimateSkillsCheck = True Then
                    num = 10
                Else
                    num = 9
                End If
        End Select

        If fSelect = False Then
            For count As Integer = 0 To num
                lstSkills.Items.Add(mSkills(count))
            Next
        ElseIf fSelect = True Then
            For count As Integer = 0 To num
                lstSkills.Items.Add(fSkills(count))
            Next
        End If
    End Sub

    Private Sub lstSkills_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSkills.SelectedIndexChanged
        Dim selected As String = lstSkills.SelectedItem.ToString()
        Dim strDesc As String

        Select Case selected
            Case "Protect"
                strDesc = maleName & " reduces damage taken by 50% for 5 turns. This effect cannot stack." & vbNewLine & "MP Cost:"
            Case "Quick Strike"
                strDesc = maleName & " attacks with blinding speed. The attack will never miss." & vbNewLine &
                              "Base Power: 75%" & vbNewLine & "MP Cost: "
            Case "Heavy Blow"
                strDesc = maleName & " channels all his strength and attacks with a strong but sluggish blow." & vbNewLine &
                              "Base Power: 200%" & vbNewLine & "Base accuracy: 65%" & vbNewLine & "MP Cost: "
            Case "Drain"
                strDesc = maleName & " saps the life force from the target. 50% of the damage dealt is returned as healing." & vbNewLine &
                              "Base Power: 75%" & vbNewLine & "Base accuracy: 95%" & vbNewLine & "MP Cost: "
            Case "Wind Slash"
                strDesc = maleName & " attacks with the force of fierce winds. Hits all targets." & vbNewLine &
                              "Base Power: 40%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: "
            Case "Revenge"
                strDesc = maleName & " converts his pain into strength. Power increases as health drops." & vbNewLine &
                      "Base Power: ?" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: "
            Case "Shock Strike"
                strDesc = maleName & " charges his weapon with lightning and strikes the target." & vbNewLine &
                      "Base Power: 125%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: "
            Case "Sear Slash"
                strDesc = maleName & " engulfs the weapon with flames and strikes the target." & vbNewLine &
                      "Base Power: 125%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: "
            Case "Demon Slayer"
                strDesc = maleName & " channels divine energy, and strikes the target with radiant energy." & vbNewLine &
              "Base Power: 175%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: "
            Case "Legend"
                strDesc = "This ancient spell was received by the king of Luxendarc." & vbNewLine & maleName &
                               " channels all his energy into one strike and brutally assaults the target with demonic strength." & vbNewLine &
                               "Base Power: 375%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: "
            Case "Heal"
                strDesc = femaleName & " channels rejuvenating energies to heal the wounds of a player." & vbNewLine & "MP Cost:"
            Case "Arcana"
                strDesc = femaleName & " blasts the target with pure, unattuned magic." & vbNewLine &
                              "Base Power: 95%" & vbNewLine & "Base accuracy: 95%" & vbNewLine & "MP Cost: "
            Case "Barrier"
                strDesc = femaleName & " reduces damage taken by 50% for 5 turns. This effect cannot stack." & vbNewLine & "MP Cost:"
            Case "Tremors"
                strDesc = femaleName & " stamps her staff to the ground, magically projecting small tremors underneath the target." & vbNewLine &
                              "Base Power: 100%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: "
            Case "Agonize"
                strDesc = femaleName & " uses dark magic to create a corrosive acid, which is casted on the target." & vbNewLine &
                              "Base Power: 85%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: "
            Case "Healmore"
                strDesc = femaleName & " channels rejuvenating energies to heal the wounds of both players. However, the heal is not as potent as the regular heal spell." & vbNewLine & "MP Cost: "
            Case "Glaciate"
                strDesc = femaleName & " saps the heat within the target's vicinity. The spell chills and freezes the target to the core." & vbNewLine &
                        "Base Power: 140%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: a lot more "
            Case "Starstorm"
                strDesc = femaleName & " calls down asteroids from space to crash on all enemies on the field." & vbNewLine &
                      "Base Power: 120%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: "
            Case "Holy"
                strDesc = femaleName & " sends a prayer to the heavens. The deities above answer her call and smite the target with a pillar of light." & vbNewLine &
              "Base Power: 170%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: "
            Case "Meteor"
                strDesc = "This ancient spell was received by the king of Luxendarc." & vbNewLine & femaleName &
                          " channels all her energy to call forth a giant meteor. This meteor crashes on the target and obliterates them." & vbNewLine & "Base Power: 375%" & vbNewLine & "Base accuracy: 100%" _
                           & vbNewLine & "MP Cost: "
        End Select

        If selected Is "Heal" = True Or selected Is "Healmore" = True Then
            btnUseSpell.Visible = True
        Else
            btnUseSpell.Visible = False
            btnTargetBoth.Visible = False
            btnTargetMale.Visible = False
            btnTargetFemale.Visible = False
        End If
        lblDesc.Text = strDesc
    End Sub

    Private Sub btnUseSpell_Click(sender As Object, e As EventArgs) Handles btnUseSpell.Click

        If fSelect = True Then
            Select Case lstSkills.SelectedIndex
                Case 0
                    heal = fInt * flevel / 4
                    btnTargetMale.Visible = True
                    btnTargetFemale.Visible = True
                Case 5
                    heal = fInt * flevel / 6
                    btnTargetBoth.Visible = True
            End Select
        End If
    End Sub

    Private Sub btnTargetBoth_Click(sender As Object, e As EventArgs) Handles btnTargetBoth.Click, btnTargetMale.Click, btnTargetFemale.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                mCurrHP = mCurrHP + heal
                If mCurrHP >= mMaxHP Then
                    mCurrHP = mMaxHP
                End If
            Case 2
                fCurrHP = fCurrHP + heal
                If fCurrHP >= fMaxHP Then
                    fCurrHP = fMaxHP
                End If
            Case 3
                mCurrHP = mCurrHP + heal
                If mCurrHP >= mMaxHP Then
                    mCurrHP = mMaxHP
                End If

                fCurrHP = fCurrHP + heal
                If fCurrHP >= fMaxHP Then
                    fCurrHP = fMaxHP
                End If
        End Select
        btnTargetBoth.Visible = False
        btnTargetMale.Visible = False
        btnTargetFemale.Visible = False
    End Sub
End Class