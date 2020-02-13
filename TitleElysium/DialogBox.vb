Public Class DialogBox

    Private Sub DialogBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.Close()
            Case Keys.Left
                Me.Close()
            Case Keys.Right
                Me.Close()
            Case Keys.Down
                Me.Close()
        End Select
    End Sub
    Private Sub DialogBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If person1 Then
            Label1.Text = "Bob: Uhhh, I can't find my keys!!"
            person1 = False
        ElseIf grunt1 Then
            Label1.Text = "Grunt: This is a prohibited area. You're not allowed in here. Leave!"
            grunt1 = False
        ElseIf person2 Then
            Label1.Text = "Dave: I have a feeling something bad is about to happen..."
            person2 = False
        ElseIf grunt2 Then
            Label1.Text = "Grunt: Its only a matter of time before...HAHAHAHA!"
            grunt2 = False
        ElseIf person3 Then
            Label1.Text = "Casey: Our king lives in a very large castle. I wish I can go into it one day.."
            person3 = False
        ElseIf girl Then
            Label1.Text = "We should go to the King's castle as soon as possible."
            girl = False
        ElseIf girl2 Then
            Label1.Text = "I wonder what the king wants from us.."
            girl2 = False
        ElseIf person4 Then
            Label1.Text = "The king has requested to meet you. You should go to the castle as soon as possible. Its important!"
            person4 = False
        ElseIf girl3 Then
            Label1.Text = "I have mystical powers, I can get to places very fast!"
            girl3 = False
        ElseIf girl4 Then
            Label1.Text = "This is horrible..."
            girl4 = False
        ElseIf king Then
            Label1.Text = "[Insert text here]"
            king = False
        ElseIf girl5 Then
            Label1.Text = "We need to find the crystals. Be careful."
            girl5 = False
        ElseIf person5 Then
            Label1.Text = "[Insert text here]"
            person5 = False
        ElseIf person6 Then
            Label1.Text = "[Insert text here]"
            person6 = False
        ElseIf girl6 Then
            Label1.Text = "We need to find the crystals. Be careful."
            girl6 = False
        ElseIf person7 Then
            Label1.Text = "I heard a scream. I wonder what it could be..."
            person7 = False
        ElseIf person8 Then
            Label1.Text = "Thank you for saving me! The crystal is safe here. Go ahead and stop these people."
            person8 = False
        ElseIf girl7 Then
            Label1.Text = "We should go inside the cave."
            girl7 = False
        ElseIf girl8 Then
            Label1.Text = "We need to find the crystals. Be careful."
            girl8 = False
        ElseIf girl9 Then
            Label1.Text = "We need to find the crystals. Be careful."
            girl8 = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class