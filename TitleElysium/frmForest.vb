Public Class frmForest
    Dim collisionArray(53) As Control
    Private Sub UpKey()
        PictureBox1.Top += 5
        PictureBox2.Top += 5
        PictureBox3.Top += 5
        PictureBox4.Top += 5
        intersectUp = True
    End Sub
    Private Sub DownKey()
        PictureBox1.Top -= 5
        PictureBox2.Top -= 5
        PictureBox3.Top -= 5
        PictureBox4.Top -= 5
        intersectDown = True
    End Sub
    Private Sub LeftKey()
        PictureBox1.Left += 5
        PictureBox2.Left += 5
        PictureBox3.Left += 5
        PictureBox4.Left += 5
        intersectLeft = True
    End Sub
    Private Sub RightKey()
        PictureBox1.Left -= 5
        PictureBox2.Left -= 5
        PictureBox3.Left -= 5
        PictureBox4.Left -= 5
        intersectRight = True
    End Sub
    Private Sub CharacterIntialization()
        person7 = False
        person8 = False
        girl6 = False
        If PictureBox1.Bounds.IntersectsWith(Label51.Bounds) Then
            person7 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label56.Bounds) Then
            person8 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label57.Bounds) Then
            girl6 = True
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub frmMainTown_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Up
                Call CharacterIntialization()
                If Not keyPressUp Then
                    keyPressUp = True
                    Call resetTimer()
                    keyPressLeft = False
                    keyPressRight = False
                    keyPressDown = False
                End If

                PictureBox1.Image = My.Resources.hero13
                PictureBox2.Image = My.Resources.hero14
                PictureBox3.Image = My.Resources.hero15
                PictureBox4.Image = My.Resources.hero16
                intersectLeft = False
                intersectRight = False
                intersectDown = False

                If Not intersectUp Then

                    PictureBox1.Top -= 8
                    PictureBox2.Top -= 8
                    PictureBox3.Top -= 8
                    PictureBox4.Top -= 8
                End If
              For count = 0 To collisionArray.Length - 1
                    If PictureBox1.Bounds.IntersectsWith(collisionArray(count).Bounds) Then
                        Call UpKey()
                    End If
                Next
            Case Keys.X
                If girl6 Then
                    DialogBox.Show()
                ElseIf person7 Then
                    DialogBox.Show()
                ElseIf person8 Then
                    DialogBox.Show()
                End If
            Case Keys.Down
                   Call CharacterIntialization
                If Not keyPressDown Then
                    keyPressDown = True
                    Call resetTimer()
                    keyPressLeft = False
                    keyPressRight = False
                    keyPressUp = False
                End If

                PictureBox1.Image = My.Resources.hero1
                PictureBox2.Image = My.Resources.hero2
                PictureBox3.Image = My.Resources.hero3
                PictureBox4.Image = My.Resources.hero4
                intersectPerson = False
                If Not intersectDown Then

                    PictureBox1.Top += 5
                    PictureBox2.Top += 5
                    PictureBox3.Top += 5
                    PictureBox4.Top += 5
                    For count = 0 To collisionArray.Length - 1
                        If PictureBox1.Bounds.IntersectsWith(collisionArray(count).Bounds) Then
                            Call DownKey()
                        End If
                    Next
                End If
            Case Keys.Right
                  Call CharacterIntialization
                If Not keyPressRight Then
                    keyPressRight = True
                    Call resetTimer()
                    keyPressLeft = False
                    keyPressUp = False
                    keyPressDown = False
                End If
                PictureBox1.Image = My.Resources.hero9
                PictureBox2.Image = My.Resources.hero10
                PictureBox3.Image = My.Resources.hero11
                PictureBox4.Image = My.Resources.hero12

                intersectLeft = False
                intersectUp = False
                intersectDown = False
                intersectPerson = False

                If Not intersectRight Then

                    PictureBox1.Left += 5
                    PictureBox2.Left += 5
                    PictureBox3.Left += 5
                    PictureBox4.Left += 5
       For count = 0 To collisionArray.Length - 1
                        If PictureBox1.Bounds.IntersectsWith(collisionArray(count).Bounds) Then
                            Call RightKey()
                        End If
                    Next
                End If
            Case Keys.Left
                If Not keyPressLeft Then
                    keyPressLeft = True
                    Call resetTimer()
                    keyPressUp = False
                    keyPressRight = False
                    keyPressDown = False
                End If
                  Call CharacterIntialization
                PictureBox1.Image = My.Resources.hero5
                PictureBox2.Image = My.Resources.hero6
                PictureBox3.Image = My.Resources.hero7
                PictureBox4.Image = My.Resources.hero8

                intersectUp = False
                intersectRight = False
                intersectDown = False
                intersectPerson = False


                If Not intersectLeft Then
                    PictureBox1.Left -= 5
                    PictureBox2.Left -= 5
                    PictureBox3.Left -= 5
                    PictureBox4.Left -= 5

                 For count = 0 To collisionArray.Length - 1
                        If PictureBox1.Bounds.IntersectsWith(collisionArray(count).Bounds) Then
                            Call LeftKey()
                        End If
                    Next
                End If
            Case Keys.Enter
                Call HiddenForm(area)
                frmInGameMenu.Show()
                Me.Hide()
        End Select
    End Sub
    Private Sub frmMainTown_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Left
                Timer1.Enabled = False
                PictureBox1.Image = My.Resources.hero7
                PictureBox2.Image = My.Resources.hero7
                PictureBox3.Image = My.Resources.hero7
                PictureBox4.Image = My.Resources.hero7
            Case Keys.Right
                Timer1.Enabled = False
                PictureBox1.Image = My.Resources.hero11
                PictureBox2.Image = My.Resources.hero11
                PictureBox3.Image = My.Resources.hero11
                PictureBox4.Image = My.Resources.hero11
            Case Keys.Down
                Timer1.Enabled = False
                PictureBox1.Image = My.Resources.hero1
                PictureBox2.Image = My.Resources.hero2
                PictureBox3.Image = My.Resources.hero3
                PictureBox4.Image = My.Resources.hero4
            Case Keys.Up
                Timer1.Enabled = False
                PictureBox1.Image = My.Resources.hero16
                PictureBox2.Image = My.Resources.hero16
                PictureBox3.Image = My.Resources.hero16
                PictureBox4.Image = My.Resources.hero16
        End Select
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        ElseIf PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox4.Visible = True
        ElseIf PictureBox4.Visible = True Then
            PictureBox4.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub
    Private Sub resetTimer()
        Timer2.Stop()
        randomEncounters = rand.Next(6, 10)
        Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        countSteps += 1
        If countSteps >= randomEncounters Then
            countSteps = 0
            Timer2.Stop()
            DialogBox.Close()
            Me.Hide()
            frmBattleTransition.Show()
        End If
    End Sub
    Private Sub frmForest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        collisionArray(0) = Label1
        collisionArray(1) = Label2
        collisionArray(2) = Label3
        collisionArray(3) = Label4
        collisionArray(4) = Label5
        collisionArray(5) = Label6
        collisionArray(6) = Label7
        collisionArray(7) = Label8
        collisionArray(8) = Label9
        collisionArray(9) = Label10
        collisionArray(10) = Label11
        collisionArray(11) = Label12
        collisionArray(12) = Label13
        collisionArray(13) = Label14
        collisionArray(14) = Label15
        collisionArray(15) = Label16
        collisionArray(16) = Label17
        collisionArray(17) = Label18
        collisionArray(18) = Label19
        collisionArray(19) = Label20
        collisionArray(20) = Label21
        collisionArray(21) = Label22
        collisionArray(22) = Label23
        collisionArray(23) = Label24
        collisionArray(24) = Label25
        collisionArray(25) = Label26
        collisionArray(26) = Label27
        collisionArray(27) = Label28
        collisionArray(28) = Label29
        collisionArray(29) = Label30
        collisionArray(30) = Label31
        collisionArray(31) = Label32
        collisionArray(32) = Label33
        collisionArray(33) = Label34
        collisionArray(34) = Label35
        collisionArray(35) = Label36
        collisionArray(36) = Label37
        collisionArray(37) = Label38
        collisionArray(38) = Label39
        collisionArray(39) = Label40
        collisionArray(40) = Label41
        collisionArray(41) = Label42
        collisionArray(42) = Label43
        collisionArray(43) = Label44
        collisionArray(44) = Label45
        collisionArray(45) = Label47
        collisionArray(46) = Label49
        collisionArray(47) = Label50
        collisionArray(48) = PictureBox11
        collisionArray(49) = PictureBox12
        collisionArray(50) = PictureBox6
        collisionArray(51) = PictureBox8
        collisionArray(52) = PictureBox9
        collisionArray(53) = PictureBox10
        Me.CenterToScreen()
        area = "Forest"
    End Sub
End Class