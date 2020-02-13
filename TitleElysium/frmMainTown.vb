Public Class frmMainTown
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
    Private Sub CharacterInitialization()
        person1 = False
        grunt1 = False
        person2 = False
        grunt2 = False
        person3 = False
        girl = False

        If PictureBox1.Bounds.IntersectsWith(Label49.Bounds) Then
            person1 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label50.Bounds) Then
            grunt1 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label51.Bounds) Then
            person2 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label52.Bounds) Then
            grunt2 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(Label53.Bounds) Then
            person3 = True
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            girl = True
        End If

        Timer1.Enabled = True
    End Sub
    Private Sub frmMainTown_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Call CharacterInitialization()

                'If Not keyPressUp Then
                '    keyPressUp = True
                '    Call resetTimer()
                '    keyPressLeft = False
                '    keyPressRight = False
                '    keyPressDown = False
                'End If
                ' Timer1.Enabled = True
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
                If PictureBox1.Bounds.IntersectsWith(Label45.Bounds) Then
                    Me.Hide()
                    frmInn.Show()
                End If
                If PictureBox1.Bounds.IntersectsWith(Label54.Bounds) Then
                    Me.Hide()
                    frmItemShop.Show()
                End If
            Case Keys.X
                If person1 Then
                    DialogBox.Show()
                ElseIf grunt1 Then
                    DialogBox.Show()
                ElseIf person2 Then
                    DialogBox.Show()
                ElseIf grunt2 Then
                    DialogBox.Show()
                ElseIf person3 Then
                    DialogBox.Show()
                ElseIf girl Then
                    DialogBox.Show()
                End If
            Case Keys.Down
                PictureBox8.Visible = True
                Call CharacterInitialization()

                'If Not keyPressDown Then
                '    keyPressDown = True
                '    Call resetTimer()
                '    keyPressLeft = False
                '    keyPressRight = False
                '    keyPressUp = False
                'End If
                ' Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero1
                PictureBox2.Image = My.Resources.hero2
                PictureBox3.Image = My.Resources.hero3
                PictureBox4.Image = My.Resources.hero4
                'intersectPerson = False
                intersectLeft = False
                intersectRight = False
                intersectUp = False

                If Not intersectDown Then
                    PictureBox1.Top += 5
                    PictureBox2.Top += 5
                    PictureBox3.Top += 5
                    PictureBox4.Top += 5
                End If

                For count = 0 To collisionArray.Length - 1
                    If PictureBox1.Bounds.IntersectsWith(collisionArray(count).Bounds) Then
                        Call DownKey()
                    End If
                Next

                If PictureBox1.Bounds.IntersectsWith(Label44.Bounds) Then
                    Me.Hide()
                    frmMap.Show()
                End If

            Case Keys.Right
                Call CharacterInitialization()


                'If Not keyPressRight Then
                '    keyPressRight = True
                '    Call resetTimer()
                '    keyPressLeft = False
                '    keyPressUp = False
                '    keyPressDown = False
                'End If
                'Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero9
                PictureBox2.Image = My.Resources.hero10
                PictureBox3.Image = My.Resources.hero11
                PictureBox4.Image = My.Resources.hero12

                intersectLeft = False
                intersectUp = False
                intersectDown = False
                'intersectPerson = False

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
                Call CharacterInitialization()


                'If Not keyPressLeft Then
                '    keyPressLeft = True
                '    Call resetTimer()
                '    keyPressUp = False
                '    keyPressRight = False
                '    keyPressDown = False
                'End If
                'Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero5
                PictureBox2.Image = My.Resources.hero6
                PictureBox3.Image = My.Resources.hero7
                PictureBox4.Image = My.Resources.hero8

                intersectUp = False
                intersectRight = False
                intersectDown = False
                'intersectPerson = False

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
    Private Sub frmMainTown_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyUp
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
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
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

    Private Sub frmMainTown_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
        collisionArray(43) = Label45
        collisionArray(44) = Label46
        collisionArray(45) = Label47
        collisionArray(47) = Label54
        collisionArray(46) = Label50
        collisionArray(47) = Label51
        collisionArray(48) = Label52
        collisionArray(49) = Label53
        collisionArray(50) = PictureBox8
        collisionArray(51) = PictureBox6
        collisionArray(52) = PictureBox11
        collisionArray(53) = PictureBox10
        Me.CenterToScreen()
        area = "Town"
    End Sub

End Class

