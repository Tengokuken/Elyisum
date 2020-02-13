Public Class frmVolcano
    Dim collisionArray(20) As Control
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
        girl9 = False
        If PictureBox1.Bounds.IntersectsWith(Label25.Bounds) Then
            girl9 = True
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub frmMainTown_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                PictureBox6.Visible = True
                PictureBox5.Visible = True
                PictureBox7.Visible = True
                Call CharacterIntialization()
                PictureBox1.Image = My.Resources.hero13
                PictureBox2.Image = My.Resources.hero14
                PictureBox3.Image = My.Resources.hero15
                PictureBox4.Image = My.Resources.hero16
                intersectLeft = False
                intersectRight = False
                intersectDown = False

                If PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Then
                    ' battling
                    PictureBox6.Visible = False
                ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Then
                    ' battling
                    PictureBox5.Visible = False
                ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox7.Bounds) Then
                    ' battling
                    PictureBox7.Visible = False
                End If
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
                If PictureBox1.Bounds.IntersectsWith(Label22.Bounds) Then
                    Me.Hide()
                    frmMainVolcano.Show()
                End If
            Case Keys.Down
                Call CharacterIntialization()
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
                If PictureBox1.Bounds.IntersectsWith(Label23.Bounds) Then
                    Me.Hide()
                    frmDesert.Show()
                End If
            Case Keys.Right
                Call CharacterIntialization()
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
            Case Keys.Space
                If girl9 Then
                    DialogBox.Show()
                End If
            Case Keys.Left
                Call CharacterIntialization()
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
    Private Sub frmVolcano_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
        area = "Volcano"
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        countSteps += 1
        If countSteps >= randomEncounters Then
            countSteps = 0
            Timer2.Stop()
            DialogBox.Close()
            Me.Hide()
            frmBattleTransition.Show()
        End If
    End Sub

    Private Sub resetTimer()
        Timer2.Stop()
        randomEncounters = rand.Next(6, 10)
        Timer2.Start()
    End Sub
End Class