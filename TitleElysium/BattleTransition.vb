Public Class frmBattleTransition
    Private treant() As Integer = {20, 2, 1, 0, 1}
    Private metamorph() As Integer = {15, 3, 1, 0, 2}
    Private scorpio() As Integer = {45, 7, 3, 1, 4}
    Private sandSnake() As Integer = {40, 9, 6, 7, 5}
    Private blooper() As Integer = {100, 11, 4, 2, 6}
    Private slime() As Integer = {120, 15, 6, 2, 7}
    Private hotHead() As Integer = {200, 20, 14, 16, 9}
    Private fireDemon() As Integer = {200, 25, 17, 15, 11}
    Private monsters As Integer

    Public enemy1(4) As Integer
    Public enemy2(4) As Integer
    Public enemy3(4) As Integer

    Private Sub frmBattleTransition_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        tmrTransition.Enabled = True
        monsters = GenerateRandFormation()
        Call BattleAreaCheck(area)
    End Sub

    Private Sub tmrTransition_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrTransition.Tick
        Static seconds As Integer
        If seconds = 2 Then
            frmBattleScreen.Show()
            Me.Hide()
            tmrTransition.Enabled = False
        Else
            seconds += 1
        End If
    End Sub

    Private Sub BattleAreaCheck(ByVal area As String)
        Select Case area
            Case "Forest"
                frmBattleScreen.BackgroundImage = My.Resources.Forestback
                Select Case monsters
                    Case 1
                        frmBattleScreen.picEnemy1.Image = My.Resources.treant
                        enemy1 = treant
                        frmBattleScreen.picEnemy2.Image = My.Resources.treant
                        enemy2 = treant
                        frmBattleScreen.picEnemy3.Image = My.Resources.treant
                        enemy3 = treant
                    Case 2
                        frmBattleScreen.picEnemy1.Image = My.Resources.metamorph
                        enemy1 = metamorph
                        frmBattleScreen.picEnemy2.Image = My.Resources.metamorph
                        enemy2 = metamorph
                        frmBattleScreen.picEnemy3.Image = My.Resources.metamorph
                        enemy3 = metamorph
                    Case 3
                        frmBattleScreen.picEnemy1.Image = My.Resources.treant
                        enemy1 = treant
                        frmBattleScreen.picEnemy2.Image = My.Resources.metamorph
                        enemy2 = metamorph
                        frmBattleScreen.picEnemy3.Image = My.Resources.metamorph
                        enemy3 = metamorph
                End Select
            Case "Desert"
                frmBattleScreen.BackgroundImage = My.Resources.desertback
                Select Case monsters
                    Case 1
                        frmBattleScreen.picEnemy1.Image = My.Resources.Scorpio
                        enemy1 = scorpio
                        frmBattleScreen.picEnemy2.Image = My.Resources.Scorpio
                        enemy2 = scorpio
                        frmBattleScreen.picEnemy3.Image = My.Resources.Scorpio
                        enemy3 = scorpio
                    Case 2
                        frmBattleScreen.picEnemy1.Image = My.Resources.sandsnake
                        enemy1 = sandSnake
                        frmBattleScreen.picEnemy2.Image = My.Resources.sandsnake
                        enemy2 = sandSnake
                        frmBattleScreen.picEnemy3.Image = My.Resources.sandsnake
                        enemy3 = sandSnake
                    Case 3
                        frmBattleScreen.picEnemy1.Image = My.Resources.Scorpio
                        enemy1 = scorpio
                        frmBattleScreen.picEnemy2.Image = My.Resources.sandsnake
                        enemy2 = sandSnake
                        frmBattleScreen.picEnemy3.Image = My.Resources.sandsnake
                        enemy3 = sandSnake
                End Select
            Case "Underwater Ruins"
                frmBattleScreen.BackgroundImage = My.Resources.seaback
                Select Case monsters
                    Case 1
                        frmBattleScreen.picEnemy1.Image = My.Resources.slime_animation_by_neslug
                        enemy1 = slime
                        frmBattleScreen.picEnemy2.Image = My.Resources.slime_animation_by_neslug
                        enemy2 = slime
                        frmBattleScreen.picEnemy3.Image = My.Resources.slime_animation_by_neslug
                        enemy3 = slime
                    Case 2
                        frmBattleScreen.picEnemy1.Image = My.Resources.blooper
                        enemy1 = blooper
                        frmBattleScreen.picEnemy2.Image = My.Resources.blooper
                        enemy2 = blooper
                        frmBattleScreen.picEnemy3.Image = My.Resources.blooper
                        enemy3 = blooper
                    Case 3
                        frmBattleScreen.picEnemy1.Image = My.Resources.blooper
                        enemy1 = blooper
                        frmBattleScreen.picEnemy2.Image = My.Resources.slime_animation_by_neslug
                        enemy2 = slime
                        frmBattleScreen.picEnemy3.Image = My.Resources.slime_animation_by_neslug
                        enemy3 = slime
                End Select
            Case "Volcano"
                frmBattleScreen.BackgroundImage = My.Resources.volcanoback
                Select Case monsters
                    Case 1
                        frmBattleScreen.picEnemy1.Image = My.Resources.DemonFire
                        enemy1 = fireDemon
                        frmBattleScreen.picEnemy2.Image = My.Resources.DemonFire
                        enemy2 = fireDemon
                        frmBattleScreen.picEnemy3.Image = My.Resources.DemonFire
                        enemy3 = fireDemon
                    Case 2
                        frmBattleScreen.picEnemy1.Image = My.Resources.hothead
                        enemy1 = hotHead
                        frmBattleScreen.picEnemy2.Image = My.Resources.hothead
                        enemy2 = hotHead
                        frmBattleScreen.picEnemy3.Image = My.Resources.hothead
                        enemy3 = hotHead
                    Case 3
                        frmBattleScreen.picEnemy1.Image = My.Resources.DemonFire
                        enemy1 = fireDemon
                        frmBattleScreen.picEnemy2.Image = My.Resources.hothead
                        enemy2 = hotHead
                        frmBattleScreen.picEnemy3.Image = My.Resources.hothead
                        enemy3 = hotHead
                End Select
        End Select
    End Sub

    Private Function GenerateRandFormation()
        Dim rand As New Random
        Dim num As Integer

        Return rand.Next(1, 4)

    End Function
End Class