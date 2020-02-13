Imports System.Threading
Public Class frmBattleScreen
    Private target As Integer
    Private spell As Integer
    Private regAttack As Boolean
    Private eDead1, eDead2, eDead3 As Boolean
    Private mDead, fDead As Boolean
    Private currEnemyHp1, currEnemyHp2, currEnemyHp3 As Integer
    Private accuracy As Integer
    Private damage As Integer
    Private base As Single
    Private turn As Integer = 1
    Private statChance As Integer
    Private defBuff As Boolean
    Private enemyHp As Integer
    Private showitems As Boolean
    Private mCoolDown(9), fCoolDown(9) As Boolean
    Private mPDefense As Integer = 22
    Private fPDefense As Integer = 20

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblMaleHP.Text = maleName & "'s HP: " & mCurrHP & " / " & mMaxHP
        lblFemaleHP.Text = femaleName & "'s HP: " & fCurrHP & " / " & fMaxHP
        btnMale.Text = maleName
        btnFemale.Text = femaleName
        btnMale.Visible = False
        btnFemale.Visible = False
        lblActionTaken.Visible = False
        lblDamageDealt.Visible = False
        btnConfirm.Visible = False
        Call WhosTurn()
        Call DisplayHP(enemyHp, damage, target, mCurrHP)
    End Sub

    Private Sub WhosTurn()

        Select Case turn
            Case 1
                grpBattle.Text = maleName & "'s Turn"
            Case 2
                grpBattle.Text = femaleName & "'s Turn"
            Case 3
                Call EnemyTurn()
            Case 4
                Call EnemyTurn()
            Case 5
                Call EnemyTurn()
        End Select
    End Sub

    Private Sub btnAttack_Click(sender As System.Object, e As System.EventArgs) Handles btnAttack.MouseClick, btnProtect.MouseClick,
                btnQuickStrike.MouseClick, btnHeavyBlow.MouseClick, btnDrain.MouseClick, btnWindSlash.MouseClick, btnRevenge.MouseClick,
                btnShockStrike.MouseClick, btnSearSlash.MouseClick, btnDemonSlayer.MouseClick, btnLegend.MouseClick, btnHeal.MouseClick,
                btnArcana.MouseClick, btnBarrier.MouseClick, btnTremor.MouseClick, btnAgonize.MouseClick, btnHealmore.MouseClick, btnGlaciate.MouseClick,
                btnStarstorm.MouseClick, btnHoly.MouseClick, btnMeteor.MouseClick

        Dim btnSender As Button = sender
        Dim strOut As String = Nothing
        Dim p As Single

        btnMale.Visible = False
        btnFemale.Visible = False

        Select Case btnSender.Tag
            Case 0
                spell = 0
                regAttack = True
                base = 1
                accuracy = 95
                Call SelectTarget()
                showitems = False
                Call DisplayItems(showitems)
            Case 1
                spell = 1
                mCoolDown(0) = True
                defBuff = True
            Case 2
                spell = 2
                mCoolDown(1) = True
                base = 0.75
                regAttack = True
                Call SelectTarget()
            Case 3
                spell = 3
                mCoolDown(2) = True
                base = 2
                accuracy = 65
                regAttack = True
                Call SelectTarget()
            Case 4
                spell = 4
                mCoolDown(3) = True
                base = 0.75
                accuracy = 95
                regAttack = True
                Call SelectTarget()
            Case 5
                spell = 5
                mCoolDown(4) = True
                base = 0.4
                target = 4
                accuracy = 90
                damage = AttackCommand(target, mlevel, mStr)
                Call DisplayHP(enemyHp, damage, target, mCurrHP)
                Call DisplayActionDone()
                Call CheckDead()
                Call WhosTurn()

            Case 6
                spell = 6
                mCoolDown(5) = True
                p = (48 * mCurrHP) / mMaxHP
                Select Case p
                    Case 32 To 48
                        base = 1
                    Case 17 To 32
                        base = 1.25
                    Case 10 To 16
                        base = 1.5
                    Case 5 To 9
                        base = 2
                    Case 2 To 4
                        base = 3
                    Case 0 To 1
                        base = 4
                End Select
                accuracy = 100
                regAttack = True
                Call SelectTarget()
            Case 7
                spell = 7
                mCoolDown(6) = True
                base = 1.25
                accuracy = 85
                statChance = 50
                regAttack = True
                Call SelectTarget()
            Case 8
                spell = 8
                mCoolDown(7) = True
                base = 1.25
                accuracy = 85
                regAttack = True
                Call SelectTarget()
            Case 9
                spell = 9
                mCoolDown(8) = True
                base = 2.2
                accuracy = 90
                regAttack = False
                Call SelectTarget()
            Case 10
                spell = 10
                mCoolDown(9) = True
                base = 3.75
                accuracy = 100
                regAttack = True
                Call SelectTarget()
            Case 11
                spell = 11
                mCoolDown(10) = True
                Call SelectTarget()
            Case 12
                spell = 12
                mCoolDown(11) = True
                base = 0.95
                accuracy = 95
                regAttack = False
                Call SelectTarget()
            Case 13
                spell = 13
                mCoolDown(12) = True
                defBuff = True
            Case 14
                spell = 14
                mCoolDown(13) = True
                base = 1
                accuracy = 85
                regAttack = False
                Call SelectTarget()
            Case 15
                spell = 15
                mCoolDown(14) = True
                base = 0.85
                accuracy = 100
                regAttack = False
                Call SelectTarget()
            Case 16
                spell = 16
                mCoolDown(15) = True
                target = 6
                Call HealingSpell(target)
            Case 17
                spell = 17
                mCoolDown(16) = True
                base = 1.1
                regAttack = False
                Call SelectTarget()
            Case 18
                spell = 18
                mCoolDown(17) = True
                base = 1.2
                target = 4
                accuracy = 90
                damage = SpellCommand(target, flevel, fInt)
                regAttack = False
                Call DisplayHP(enemyHp, damage, target, mCurrHP)
                Call DisplayActionDone()
                Call CheckDead()
                Call WhosTurn()
            Case 19
                spell = 19
                mCoolDown(18) = True
                base = 1.7
                accuracy = 85
                regAttack = False
                Call SelectTarget()
            Case 20
                spell = 20
                mCoolDown(19) = True
                base = 3
                accuracy = 100
                regAttack = False
                Call SelectTarget()
        End Select

        Call HideSpells()
        If turn = 1 Then
            Call mCheckCoolDowns()
        ElseIf turn = 2 Then
            Call fCheckCoolDowns()
        End If

    End Sub

    Private Sub btnSpells_Click(sender As Object, e As EventArgs) Handles btnSpells.Click
        lblTarget.Text = "Select a spell:"
        btnMale.Visible = False
        btnFemale.Visible = False
        showitems = False
        Call DisplayItems(showitems)
        Call ShowSpells()
    End Sub

    Private Sub ShowSpells()
        Dim btnMSpells() As Button = {btnProtect, btnQuickStrike, btnHeavyBlow, btnDrain, btnWindSlash, btnRevenge, btnSearSlash,
                                    btnShockStrike, btnDemonSlayer, btnLegend}
        Dim btnFSpells() As Button = {btnHeal, btnArcana, btnBarrier, btnTremor, btnAgonize, btnHealmore, btnGlaciate, btnStarstorm,
                                    btnHoly, btnMeteor}
        Dim i As Integer
        Dim spellcount As Integer
        Select Case turn
            Case 1
                Select Case mlevel
                    Case 1
                        spellcount = 0
                    Case 2
                        spellcount = 1
                    Case 3
                        spellcount = 2
                    Case 4 To 5
                        spellcount = 3
                    Case 6 To 7
                        spellcount = 4
                    Case 8 To 11
                        spellcount = 5
                    Case 12 To 14
                        spellcount = 7
                    Case 15 To 20
                        If ultimateSkillsCheck = True Then
                            spellcount = 9
                        Else
                            spellcount = 8
                        End If
                End Select

                For i = 0 To spellcount

                    btnMSpells(i).Visible = True
                Next
            Case 2
                Select Case flevel
                    Case 1
                        spellcount = 0
                    Case 2
                        spellcount = 1
                    Case 3
                        spellcount = 2
                    Case 4 To 5
                        spellcount = 3
                    Case 6 To 7
                        spellcount = 4
                    Case 8 To 11
                        spellcount = 5
                    Case 12 To 14
                        spellcount = 7
                    Case 15 To 20
                        If ultimateSkillsCheck = True Then
                            spellcount = 9
                        Else
                            spellcount = 8
                        End If
                End Select

                For i = 0 To spellcount

                    btnFSpells(i).Visible = True
                Next
        End Select
    End Sub

    Private Sub HideSpells()
        Dim btnMSpells() As Button = {btnDemonSlayer, btnDrain, btnHeavyBlow, btnLegend, btnProtect, btnQuickStrike, btnRevenge,
                                    btnSearSlash, btnShockStrike, btnWindSlash}
        Dim btnFSpells() As Button = {btnHeal, btnArcana, btnBarrier, btnTremor, btnAgonize, btnHealmore, btnGlaciate, btnStarstorm,
                                    btnHoly, btnMeteor}
        Dim i As Integer
        Select Case turn
            Case 1
                For i = 0 To 9
                    btnMSpells(i).Visible = False
                Next
            Case 2
                For i = 0 To 9
                    btnFSpells(i).Visible = False
                Next
        End Select
    End Sub

    Private Sub btnItems_Click(sender As System.Object, e As System.EventArgs) Handles btnItems.Click
        Call HideSpells()
        showitems = True
        Call DisplayItems(showitems)
    End Sub

    Private Sub DisplayItems(ByVal showitems As Boolean)
        Dim consumables() As Button = {btnPotion, btnEther, btnResurrect, btnHiPotion, btnTonic, btnEtherQueen, btnMaxPotion,
                                    btnEtherKing}
        Dim i As Integer

        If showitems = True Then
            For i = 0 To 7
                lblTarget.Text = "Select an item:"
                consumables(i).Visible = True
            Next
        ElseIf showitems = False Then
            For i = 0 To 7
                consumables(i).Visible = False
            Next
        End If
    End Sub

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        returnToPrev = True
        Call HiddenForm(area)
        returnToPrev = False
        Me.Hide()
    End Sub

    Private Sub btnAttack_MouseHover(sender As Object, e As EventArgs) Handles btnAttack.MouseHover, btnProtect.MouseHover, btnQuickStrike.MouseHover,
                btnHeavyBlow.MouseHover, btnDrain.MouseHover, btnWindSlash.MouseHover, btnRevenge.MouseHover, btnShockStrike.MouseHover,
                btnSearSlash.MouseHover, btnDemonSlayer.MouseHover, btnLegend.MouseHover, btnHeal.MouseHover, btnArcana.MouseHover,
                btnBarrier.MouseHover, btnTremor.MouseHover, btnAgonize.MouseHover, btnHealmore.MouseHover, btnGlaciate.MouseHover,
                btnStarstorm.MouseHover, btnHoly.MouseHover, btnMeteor.MouseHover

        Dim btnSender As Button = sender
        Dim strOut As String = Nothing

        Select Case btnSender.Tag
            Case 0
                tltDesc.Show("Attack with a standard blow." & vbNewLine & "Base Power: 100%" & vbNewLine &
                             "Base accuracy: 100%", btnAttack)
            Case 1
                tltDesc.Show("Raises party defense by 50% for 5 turns." & vbNewLine &
                      "MP Cost: ", btnProtect)
            Case 2
                tltDesc.Show("Attacks with blinding speed. The attack will never miss." & vbNewLine &
                      "Base Power: 75%" & vbNewLine & "MP Cost: ", btnQuickStrike)
            Case 3
                tltDesc.Show("Attack with a strong but sluggish blow." & vbNewLine &
                      "Base Power: 200%" & vbNewLine & "Base accuracy: 65%" & vbNewLine & "MP Cost: ", btnHeavyBlow)
            Case 4
                tltDesc.Show("An attack that saps the enemy's power. Heals user for 50% of the damage dealt." & vbNewLine &
                      "Base Power: 75%" & vbNewLine & "Base accuracy: 95%" & vbNewLine & "MP Cost: ", btnDrain)
            Case 5
                tltDesc.Show("A physical attack that hits all targets." & vbNewLine &
                "Base Power: 40%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: ", btnWindSlash)
            Case 6
                tltDesc.Show("Power increases as health drops." & vbNewLine &
                "Base Power: ?" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: ", btnRevenge)
            Case 7
                tltDesc.Show("Charges at the target with an energized blade. May paralyze the target." & vbNewLine &
                "Base Power: 125%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: " & vbNewLine &
                "Paralyze chance: 50%", btnShockStrike)
            Case 8
                tltDesc.Show("Rushes at the target with a burning blade. May burn the target." & vbNewLine &
                "Base Power: 125%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: " & vbNewLine &
                "Burn chance: 50%", btnSearSlash)
            Case 9
                tltDesc.Show("Channels divine energy, and strikes the target. This does damage based on INT instead of STR." & vbNewLine &
                "Base Power: 175%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: ", btnDemonSlayer)
            Case 10
                tltDesc.Show("The ultimate spell. Brutally assaults the enemy with demonic strength." & vbNewLine &
                "Base Power: 375%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: ", btnLegend)
            Case 11
                tltDesc.Show("Heals one player." & vbNewLine & "MP Cost: ", btnHeal)
            Case 12
                tltDesc.Show("Blasts the target with arcane energy." & vbNewLine &
                      "Base Power: 95%" & vbNewLine & "Base accuracy: 95%" & vbNewLine & "MP Cost: ", btnArcana)
            Case 13
                tltDesc.Show("Raises the party's magic defense by 50%." & vbNewLine &
                            "MP Cost: ", btnBarrier)
            Case 14
                tltDesc.Show("Magically projects small tremors underneath the target." & vbNewLine &
                "Base Power: 100%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: ", btnTremor)
            Case 15
                tltDesc.Show("Assaults the target with corrosive magic." & vbNewLine &
                      "Base Power: 85%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: ", btnAgonize)
            Case 16
                tltDesc.Show("Heals both players." & vbNewLine &
                             "MP Cost: ", btnHealmore)
            Case 17
                tltDesc.Show("Saps the heat from the target." & vbNewLine &
                "Base Power: 110%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: a lot more ", btnGlaciate)
            Case 18
                tltDesc.Show("Summons small asteroids to attack all targets." & vbNewLine &
                "Base Power: 120%" & vbNewLine & "Base accuracy: 85%" & vbNewLine & "MP Cost: ", btnStarstorm)
            Case 19
                tltDesc.Show("Summons a beam of light from the heavens to smite the target." & vbNewLine &
                "Base Power: 170%" & vbNewLine & "Base accuracy: 90%" & vbNewLine & "MP Cost: ", btnHoly)
            Case 20
                tltDesc.Show("The ultimate spell. Calls down an enormous meteor to obliterate the enemy." & vbNewLine &
                "Base Power: 300%" & vbNewLine & "Base accuracy: 100%" & vbNewLine & "MP Cost: ", btnMeteor)
        End Select

    End Sub

    Private Sub SelectTarget()
        lblTarget.Text = "Target who?"

        If currEnemyHp1 <= 0 Then
            picEnemy1.Enabled = False
        Else
            picEnemy1.Enabled = True
        End If

        If currEnemyHp2 <= 0 Then
            picEnemy2.Enabled = False
        Else
            picEnemy2.Enabled = True
        End If

        If currEnemyHp3 <= 0 Then
            picEnemy3.Enabled = False
        Else
            picEnemy3.Enabled = True
        End If

        If spell = 11 Then
            btnMale.Visible = True
            btnFemale.Visible = True
        End If
    End Sub

    Private Function AttackCommand(ByVal target As Integer, ByVal level As Integer, ByVal strength As Integer)

        Dim attack As Integer
        Dim pDefense As Integer
        Dim rand As New Random
        Dim random As Decimal
        Dim crit As Boolean
        Dim attackConnected As Boolean

        attackConnected = CheckAccuracy()
        If attackConnected = False Then
            Return 0
        Else
            random = rand.Next(85, 101)
            random = random / 100

            attack = strength + (2 * level)

            Select Case target
                Case 1
                    pDefense = enemy1(2)
                Case 2
                    pDefense = enemy2(2)
                Case 3
                    pDefense = enemy3(2)
                Case 4
                    pDefense = (enemy1(2) + enemy2(2) + enemy2(2)) / 3
            End Select

            If turn = 1 Then
                crit = CheckCrit(mAgi)
            ElseIf turn = 2 Then
                crit = CheckCrit(fAgi)
            End If

            If crit = True Then
                Return (((attack - pDefense) * (level / 5) * base * random) * 1.5)
            Else
                Return ((attack - pDefense) * (level / 5) * base * random)
            End If
        End If
    End Function

    Private Function SpellCommand(ByVal target As Integer, ByVal level As Integer, ByVal int As Integer)

        Dim magAttack As Integer
        Dim magDefense As Integer

        Dim rand As New Random
        Dim random As Decimal
        Dim crit As Boolean
        Dim attackConnected As Boolean

        attackConnected = CheckAccuracy()
        If attackConnected = False Then
            Return 0
        Else
            random = rand.Next(85, 101)
            random = random / 100

            magAttack = int + (2 * level)

            Select Case target
                Case 1
                    magDefense = enemy1(3)
                Case 2
                    magDefense = enemy2(3)
                Case 3
                    magDefense = enemy3(3)
                Case 4
                    magDefense = (enemy1(3) + enemy2(3) + enemy3(3)) / 3

            End Select

            If turn = 1 Then
                crit = CheckCrit(mAgi)
            ElseIf turn = 2 Then
                crit = CheckCrit(fAgi)
            End If

            If crit = True Then
                Return (((magAttack - magDefense) * (level / 5) * base * random) * 1.5)
            Else
                Return ((magAttack - magDefense) * (level / 5) * base * random)
            End If
        End If
    End Function

    'This sub calculates the amount of power of the healing spell and adds that integer to the target's health. Note: the variable
    '"damage" is used because of the procedure DisplayActionDone(), just to make things easier for coding.
    Private Sub HealingSpell(ByVal target As Integer)
        Dim rand As New Random
        Dim random As Decimal

        random = rand.Next(85, 101)
        random = random / 100

        Select Case spell
            Case 11
                damage = fInt * flevel / 4 * random
            Case 16
                damage = fInt * flevel / 7 * random
        End Select

        Select Case target
            Case 5
                mCurrHP = mCurrHP + damage
                If mCurrHP >= mMaxHP Then
                    mCurrHP = mMaxHP
                End If
                lblMaleHP.Text = maleName & "'s HP: " & mCurrHP & " / " & mMaxHP
            Case 6
                fCurrHP = fCurrHP + damage
                If fCurrHP >= fMaxHP Then
                    fCurrHP = fMaxHP
                End If
                lblFemaleHP.Text = femaleName & "'s HP: " & fCurrHP & " / " & fMaxHP
            Case 7
                mCurrHP = mCurrHP + damage
                If mCurrHP >= mMaxHP Then
                    mCurrHP = mMaxHP
                End If
                fCurrHP = fCurrHP + damage
                If fCurrHP >= fMaxHP Then
                    fCurrHP = fMaxHP
                End If
                lblMaleHP.Text = maleName & "'s HP: " & mCurrHP & " / " & mMaxHP
                lblFemaleHP.Text = femaleName & "'s HP: " & fCurrHP & " / " & fMaxHP
        End Select
        btnMale.Visible = False
        btnFemale.Visible = False
        lblTarget.Text = ""
        Call DisplayActionDone()
        Call WhosTurn()
        Call EnemyTurn()
    End Sub

    Private Sub mCheckCoolDowns()
        Static mCooldownCounter(9) As Integer
        Dim mCooldownTimer() As Integer = {8, 2, 4, 3, 3, 2, 4, 4, 5, 11}

        If mCoolDown(0) = True Then
            btnProtect.Enabled = False
            mCooldownCounter(0) += 1
            If mCooldownCounter(0) = mCooldownTimer(0) Then
                btnProtect.Enabled = True
                mCoolDown(0) = False
                mCooldownCounter(0) = 0
            End If
        End If

        If mCoolDown(1) = True Then
            btnQuickStrike.Enabled = False
            mCooldownCounter(1) += 1
            If mCooldownCounter(1) = mCooldownTimer(1) Then
                btnQuickStrike.Enabled = True
                mCoolDown(1) = False
                mCooldownCounter(1) = 0
            End If
        End If
        If mCoolDown(2) = True Then
            btnHeavyBlow.Enabled = False
            mCooldownCounter(2) += 1
            If mCooldownCounter(2) = mCooldownTimer(2) Then
                btnHeavyBlow.Enabled = True
                mCoolDown(2) = False
                mCooldownCounter(2) = 0
            End If
        End If

        If mCoolDown(3) = True Then
            btnDrain.Enabled = False
            mCooldownCounter(3) += 1
            If mCooldownCounter(3) = mCooldownTimer(3) Then
                btnDrain.Enabled = True
                mCoolDown(3) = False
                mCooldownCounter(3) = 0
            End If
        End If
        If mCoolDown(4) = True Then
            btnWindSlash.Enabled = False
            mCooldownCounter(4) += 1
            If mCooldownCounter(4) = mCooldownTimer(4) Then
                btnWindSlash.Enabled = True
                mCoolDown(4) = False
                mCooldownCounter(4) = 0
            End If
        End If
        If mCoolDown(5) = True Then
            btnRevenge.Enabled = False
            mCooldownCounter(5) += 1
            If mCooldownCounter(5) = mCooldownTimer(5) Then
                btnRevenge.Enabled = True
                mCoolDown(5) = False
                mCooldownCounter(5) = 0
            End If
        End If
        If mCoolDown(6) = True Then
            btnShockStrike.Enabled = False
            mCooldownCounter(6) += 1
            If mCooldownCounter(6) = mCooldownTimer(6) Then
                btnShockStrike.Enabled = True
                mCoolDown(6) = False
                mCooldownCounter(6) = 0
            End If
        End If
        If mCoolDown(7) = True Then
            btnSearSlash.Enabled = False
            mCooldownCounter(7) += 1
            If mCooldownCounter(1) = mCooldownTimer(7) Then
                btnSearSlash.Enabled = True
                mCoolDown(7) = False
                mCooldownCounter(7) = 0
            End If
        End If
        If mCoolDown(8) = True Then
            btnDemonSlayer.Enabled = False
            mCooldownCounter(8) += 1
            If mCooldownCounter(8) = mCooldownTimer(8) Then
                btnDemonSlayer.Enabled = True
                mCoolDown(8) = False
                mCooldownCounter(8) = 0
            End If
        End If
        If mCoolDown(9) = True Then
            btnLegend.Enabled = False
            mCooldownCounter(9) += 1
            If mCooldownCounter(9) = mCooldownTimer(9) Then
                btnLegend.Enabled = True
                mCoolDown(9) = False
                mCooldownCounter(9) = 0
            End If
        End If


    End Sub

    Private Sub fCheckCoolDowns()

        Static fCooldownCounter(9) As Integer
        Dim fCooldownTimer() As Integer = {2, 3, 8, 4, 3, 4, 5, 5, 7, 11}

        If fCoolDown(0) = True Then
            btnHeal.Enabled = False
            fCooldownCounter(0) += 1
            If fCooldownCounter(0) = fCooldownTimer(0) Then
                btnHeal.Enabled = True
                fCoolDown(0) = False
                fCooldownCounter(0) = 0
            End If
        End If

        If fCoolDown(1) = True Then
            btnArcana.Enabled = False
            fCooldownCounter(1) += 1
            If fCooldownCounter(1) = fCooldownTimer(1) Then
                btnArcana.Enabled = True
                fCoolDown(1) = False
                fCooldownCounter(1) = 0
            End If
        End If
        If fCoolDown(2) = True Then
            btnBarrier.Enabled = False
            fCooldownCounter(2) += 1
            If fCooldownCounter(2) = fCooldownTimer(2) Then
                btnBarrier.Enabled = True
                fCoolDown(2) = False
                fCooldownCounter(2) = 0
            End If
        End If

        If fCoolDown(3) = True Then
            btnTremor.Enabled = False
            fCooldownCounter(3) += 1
            If fCooldownCounter(3) = fCooldownTimer(3) Then
                btnTremor.Enabled = True
                fCoolDown(3) = False
                fCooldownCounter(3) = 0
            End If
        End If
        If fCoolDown(4) = True Then
            btnAgonize.Enabled = False
            fCooldownCounter(4) += 1
            If fCooldownCounter(4) = fCooldownTimer(4) Then
                btnAgonize.Enabled = True
                fCoolDown(4) = False
                fCooldownCounter(4) = 0
            End If
        End If
        If fCoolDown(5) = True Then
            btnHealmore.Enabled = False
            fCooldownCounter(5) += 1
            If fCooldownCounter(5) = fCooldownTimer(5) Then
                btnHealmore.Enabled = True
                fCoolDown(5) = False
                fCooldownCounter(5) = 0
            End If
        End If
        If fCoolDown(6) = True Then
            btnGlaciate.Enabled = False
            fCooldownCounter(6) += 1
            If fCooldownCounter(6) = fCooldownTimer(6) Then
                btnGlaciate.Enabled = True
                fCoolDown(6) = False
                fCooldownCounter(6) = 0
            End If
        End If
        If fCoolDown(7) = True Then
            btnStarstorm.Enabled = False
            fCooldownCounter(7) += 1
            If fCooldownCounter(1) = fCooldownTimer(7) Then
                btnStarstorm.Enabled = True
                fCoolDown(7) = False
                fCooldownCounter(7) = 0
            End If
        End If
        If fCoolDown(8) = True Then
            btnHoly.Enabled = False
            fCooldownCounter(8) += 1
            If fCooldownCounter(8) = fCooldownTimer(8) Then
                btnHoly.Enabled = True
                fCoolDown(8) = False
                fCooldownCounter(8) = 0
            End If
        End If
        If fCoolDown(9) = True Then
            btnMeteor.Enabled = False
            fCooldownCounter(9) += 1
            If fCooldownCounter(9) = fCooldownTimer(9) Then
                btnMeteor.Enabled = True
                fCoolDown(9) = False
                fCooldownCounter(9) = 0
            End If
        End If
    End Sub

    Private Sub DisplayHP(ByVal enemyHp As Integer, ByVal damage As Integer, ByVal target As Integer, ByVal mCurrHP As Integer)
        Select Case target
            Case 1
                currEnemyHp1 = currEnemyHp1 - damage
            Case 2
                currEnemyHp2 = currEnemyHp2 - damage
            Case 3
                currEnemyHp3 = currEnemyHp3 - damage
            Case 4
                currEnemyHp1 = currEnemyHp1 - damage
                currEnemyHp2 = currEnemyHp2 - damage
                currEnemyHp3 = currEnemyHp3 - damage
            Case Else
                currEnemyHp1 = enemy1(0)
                currEnemyHp2 = enemy2(0)
                currEnemyHp3 = enemy3(0)
        End Select

        lblHealth1.Text = currEnemyHp1 & " / " & enemy1(0) & "HP"
        lblHealth2.Text = currEnemyHp2 & " / " & enemy2(0) & "HP"
        lblHealth3.Text = currEnemyHp3 & " / " & enemy3(0) & "HP"
        lblTarget.Text = ""


        If currEnemyHp1 <= 0 Then
            picEnemy1.Visible = False
            lblHealth1.Visible = False
            eDead1 = True
        End If

        If currEnemyHp2 <= 0 Then
            picEnemy2.Visible = False
            lblHealth2.Visible = False
            eDead2 = True
        End If

        If currEnemyHp3 <= 0 Then
            picEnemy3.Visible = False
            lblHealth3.Visible = False
            eDead3 = True
        End If

        If spell = 4 Then
            lblMaleHP.Text = maleName & "'s HP: " & mCurrHP & " / " & mMaxHP
        End If
    End Sub

    Private Sub DisplayActionDone()
        Dim strAction(2) As String

        Select Case turn
            Case 1
                strAction(0) = maleName
            Case 2
                strAction(0) = femaleName
            Case 3
                strAction(0) = "Enemy 1"
            Case 4
                strAction(0) = "Enemy 2"
            Case 5
                strAction(0) = "Enemy 3"
        End Select

        Select Case spell
            Case 11, 16
                strAction(1) = " healed "
            Case Else
                strAction(1) = " dealt "
        End Select

        Select Case target
            Case 1 To 3
                strAction(2) = "enemy " & target
            Case 4
                strAction(2) = "all enemies"
            Case 5
                strAction(2) = maleName
            Case 6
                strAction(2) = femaleName
            Case 7
                strAction(2) = "both heroes"
        End Select
        btnConfirm.Visible = True
        btnConfirm.Focus()
        lblActionTaken.Visible = True
        lblDamageDealt.Visible = True
        If damage = 0 Then
            lblDamageDealt.Text = String.Concat(strAction(0) & " missed their attack on " & strAction(2) & ".")
        Else
            lblDamageDealt.Text = String.Concat(strAction(0) & strAction(1) & damage & "HP to " & strAction(2) & ".")
        End If
    End Sub

    Private Function CheckAccuracy()
        Dim rand As New Random
        Dim num As Integer

        If spell = 2 Then
            Return True
        End If

        num = rand.Next(1, 101)
        If num <= accuracy Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckCrit(ByVal agl As Integer)
        Dim rand As New Random
        Dim num As Integer

        num = rand.Next(1, 1025)
        If num + agl = (6 * agl) >= 960 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub CheckDead()
        If eDead1 = True And eDead2 = True And eDead3 = True Then
            MessageBox.Show("You won!")
            MessageBox.Show("EXP Gained: " & EXPGained & vbNewLine &
                            "Gold Gained: $" & goldGained)
            EXP = EXP + EXPGained
            Call CheckLevelUp()
            Me.Close()
        End If
    End Sub

    Private Sub CheckLevelUp()
        monstersDefeated += 1
        If monstersDefeated = 5 Then
            MessageBox.Show("Level up!" & vbNewLine & maleName & " grew to level " & mLevel & vbNewLine & femaleName & " grew to level " & fLevel)
            mVit = mVit + 1
            mStr = mStr + 1
            mInt = mInt + 1
            mAgi = mAgi + 1
            fVit = fVit + 1
            fStr = fStr + 1
            fInt = fInt + 1
            fAgi = fAgi + 1
            monstersDefeated = 0
        End If

            returnToPrev = True
            Call HiddenForm(area)
            returnToPrev = False
            Me.Hide()
    End Sub

    Private Sub picEnemy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEnemy1.Click

        target = 1
        Call ClickedTarget(target)

        picEnemy1.Enabled = False
        picEnemy2.Enabled = False
        picEnemy3.Enabled = False
        Call DisplayActionDone()
        Call HideSpells()
        Call CheckDead()
    End Sub

    Private Sub picEnemy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEnemy2.Click
        target = 2
        Call ClickedTarget(target)

        picEnemy1.Enabled = False
        picEnemy2.Enabled = False
        picEnemy3.Enabled = False
        Call DisplayActionDone()
        Call HideSpells()
        Call CheckDead()
    End Sub

    Private Sub picEnemy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picEnemy3.Click
        target = 3
        Call ClickedTarget(target)

        picEnemy1.Enabled = False
        picEnemy2.Enabled = False
        picEnemy3.Enabled = False
        Call DisplayActionDone()
        Call HideSpells()
        Call CheckDead()
    End Sub

    Private Sub ClickedTarget(ByVal target As Integer)
        If turn = 1 Then
            If regAttack = True Then
                damage = AttackCommand(target, mLevel, mStr)
                Select Case spell
                    Case 4
                        mCurrHP = mCurrHP + (damage / 2)
                        If mCurrHP >= mMaxHP Then
                            mCurrHP = mMaxHP
                        End If
                End Select
                Call DisplayHP(enemyHp, damage, target, mCurrHP)
            Else
                damage = SpellCommand(target, mLevel, mInt)
                Call DisplayHP(enemyHp, damage, target, mCurrHP)
            End If
            Call HideSpells()

        ElseIf turn = 2 Then
            If regAttack = True Then
                damage = AttackCommand(target, flevel, fStr)
                Call DisplayHP(enemyHp, damage, target, fCurrHP)
            Else
                damage = SpellCommand(target, flevel, fInt)
                Call DisplayHP(enemyHp, damage, target, fCurrHP)
            End If
            Call HideSpells()
        End If


    End Sub

    Private Sub btnMale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMale.Click
        target = 5
        Call HealingSpell(target)
    End Sub

    Private Sub btnFemale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFemale.Click
        target = 6
        Call HealingSpell(target)
    End Sub

    Private Sub EnemyTurn()

        Dim rand As New Random

        spell = 0
        If turn = 3 Then
            base = 1
            accuracy = 95
            target = rand.Next(5, 7)
            damage = EnemyAttack(target, enemy1(4), enemy1(1))
            Call EnemyDamage()
            Call DisplayActionDone()
        ElseIf turn = 4 Then
            base = 1
            accuracy = 95
            target = rand.Next(5, 7)
            damage = EnemyAttack(target, enemy2(4), enemy2(1))
            Call EnemyDamage()
            Call DisplayActionDone()
        ElseIf turn = 5 Then
            base = 1
            accuracy = 95
            target = rand.Next(5, 7)
            damage = EnemyAttack(target, enemy3(4), enemy3(1))
            Call EnemyDamage()
            Call DisplayActionDone()
        End If
    End Sub

    Private Function EnemyAttack(ByVal target As Integer, ByVal level As Integer, ByVal strength As Integer)
        Dim attack As Integer
        Dim pDefense As Integer
        Dim rand As New Random
        Dim random As Decimal
        Dim crit As Boolean
        Dim attackConnected As Boolean
        Dim resist As Integer

        attack = strength + (2 * level)

        attackConnected = CheckAccuracy()
        If attackConnected = False Then
            Return 0
        Else
            random = rand.Next(85, 101)
            random = random / 100

            Select Case target
                Case 5
                    pDefense = mPDefense
                Case 6
                    pDefense = fPDefense
            End Select

            If defBuff = True Then
                resist = 0.5
            Else
                resist = 1
            End If

            If crit = True Then
                Return (((attack - pDefense) * (level / 5) * base * random) * 1.5 * resist)
            Else
                Return ((attack - pDefense) * (level / 5) * base * random * resist)
            End If
        End If
    End Function

    Private Sub EnemyDamage()
        Select Case target
            Case 5
                mCurrHP = mCurrHP - damage
            Case 6
                fCurrHP = fCurrHP - damage
        End Select

        lblMaleHP.Text = maleName & "'s HP: " & mCurrHP & " / " & mMaxHP
        lblFemaleHP.Text = femaleName & "'s HP: " & fCurrHP & " / " & fMaxHP

        If mCurrHP <= 0 Then
            mDead = True
            lblMaleHP.Visible = False
        End If

        If fCurrHP <= 0 Then
            fDead = True
            lblFemaleHP.Visible = False
        End If

    End Sub

    Private Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click

        lblActionTaken.Visible = False
        lblDamageDealt.Visible = False
        btnConfirm.Visible = False

        Select Case turn
            Case 1
                turn = 2
                If fDead = True Then
                    turn = 3
                End If
            Case 2
                If eDead1 = True Then
                    turn = 4
                ElseIf eDead1 = True And eDead2 = True Then
                    turn = 5
                End If
                turn = 3

            Case 3
                If eDead2 = True And eDead3 = False Then
                    turn = 5
                ElseIf eDead2 = True And eDead3 = True Then
                    turn = 1
                Else
                    turn = 4
                End If
            Case 4
                If eDead3 = True Then
                    turn = 1
                Else
                    turn = 5
                End If
            Case 5
                turn = 1
                If mDead = True Then
                    turn = 2
                End If
        End Select

        Call WhosTurn()

        If mDead = True And fDead = True Then
            MessageBox.Show("You have failed your quest to save Luxenburg. Returning to main menu. ", "GAME OVER")
                frmTitle.Show()
                Me.Hide()
            End If
   End Sub
End Class