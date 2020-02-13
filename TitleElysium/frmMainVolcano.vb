Public Class frmMainVolcano
    Dim collisionArray(23) As Control
    Dim moveGruntLeft As Boolean = False
    Dim moveVillianDown As Boolean = False
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

    Private Sub frmMainVolcano_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If moveGruntLeft Then
            AIGruntLeft()
        ElseIf moveVillianDown Then
            AIVillianDown()
        End If
    End Sub
    Private Sub frmMainTown_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Timer1.Enabled = True
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
                If PictureBox1.Bounds.IntersectsWith(Label23.Bounds) Then
                    AIGruntRight()
                    intersectUp = True

                End If
            Case Keys.Down
                Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero1
                PictureBox2.Image = My.Resources.hero2
                PictureBox3.Image = My.Resources.hero3
                PictureBox4.Image = My.Resources.hero4

                intersectLeft = False
                intersectRight = False
                intersectUp = False
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
                If PictureBox1.Bounds.IntersectsWith(Label22.Bounds) Then
                    Me.Hide()
                    frmVolcano.Show()
                End If
            Case Keys.Right
                Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero9
                PictureBox2.Image = My.Resources.hero10
                PictureBox3.Image = My.Resources.hero11
                PictureBox4.Image = My.Resources.hero12

                intersectLeft = False
                intersectUp = False
                intersectDown = False

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
                Timer1.Enabled = True
                PictureBox1.Image = My.Resources.hero5
                PictureBox2.Image = My.Resources.hero6
                PictureBox3.Image = My.Resources.hero7
                PictureBox4.Image = My.Resources.hero8

                intersectUp = False
                intersectRight = False
                intersectDown = False

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

    Private Sub frmMainVolcano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        collisionArray(21) = PictureBox5
        collisionArray(22) = PictureBox6
        collisionArray(23) = PictureBox7
        area = "Volcano Cavern"

    End Sub
    Private Sub AIGruntRight()
        Dim p As New Point(434, 288)
        '  PictureBox7.Visible = True
        Dim endLoop As Boolean = False
        Do While Not endLoop
            'coming down
            PictureBox7.Location = New Point(PictureBox7.Location.X + 0, PictureBox7.Location.Y + 4)
            PictureBox8.Location = New Point(PictureBox8.Location.X + 0, PictureBox8.Location.Y + 4)
            Me.Refresh()
            If PictureBox7.Location = p Then
                PictureBox7.Visible = False
                PictureBox8.Visible = True
                While Not PictureBox8.Bounds.IntersectsWith(Label23.Bounds)
                    'move left
                    PictureBox8.Location = New Point(PictureBox8.Location.X - 4, PictureBox8.Location.Y + 0)
                    Threading.Thread.Sleep(100)
                    'Timer1.Stop()
                    Me.Refresh()
                    endLoop = True
                End While
            End If
        Loop
        moveGruntLeft = True
        DialogBox.Close()
        Me.Hide()
        frmBattleTransition.Show()
    End Sub
    Private Sub AIGruntLeft()
        Dim p As New Point(183, 288)
        '  PictureBox7.Visible = True
        Dim endLoop As Boolean = False
        Do While Not endLoop
            'coming down
            PictureBox5.Location = New Point(PictureBox5.Location.X + 0, PictureBox5.Location.Y + 4)
            PictureBox9.Location = New Point(PictureBox9.Location.X + 0, PictureBox9.Location.Y + 4)
            Me.Refresh()
            If PictureBox5.Location = p Then
                PictureBox5.Visible = False
                PictureBox9.Visible = True
                ' PictureBox8.Visible = True
                While Not PictureBox9.Bounds.IntersectsWith(Label23.Bounds)
                    'move right
                    PictureBox9.Location = New Point(PictureBox9.Location.X + 4, PictureBox9.Location.Y + 0)
                    Threading.Thread.Sleep(100)
                    'Timer1.Stop()
                    Me.Refresh()
                    endLoop = True
                End While
            End If
        Loop
        moveGruntLeft = False
        moveVillianDown = True
        DialogBox.Close()

        Me.Hide()
        frmBattleTransition.Show()
    End Sub
    Private Sub AIVillianDown()
        Dim endLoop As Boolean = False
        Do While Not endLoop
            'coming down
            PictureBox6.Location = New Point(PictureBox6.Location.X + 0, PictureBox6.Location.Y + 4)
            'PictureBox9.Location = New Point(PictureBox9.Location.X + 0, PictureBox9.Location.Y + 4)
            Me.Refresh()
            If PictureBox6.Bounds.IntersectsWith(Label23.Bounds) Then
                endLoop = True
            End If
            'If PictureBox5.Location = p Then
            '    PictureBox5.Visible = False
            '    PictureBox9.Visible = True
            '    ' PictureBox8.Visible = True
            '    While Not PictureBox9.Bounds.IntersectsWith(Label23.Bounds)
            '        'move right
            '        PictureBox9.Location = New Point(PictureBox9.Location.X + 4, PictureBox9.Location.Y + 0)
            '        Threading.Thread.Sleep(50)
            '        'Timer1.Stop()
            '        Me.Refresh()
            '        endLoop = True
            '    End While
            'End If
        Loop
        moveGruntLeft = False
        moveVillianDown = False
        DialogBox.Close()
        Me.Hide()
        frmBattleTransition.Show()
    End Sub
End Class