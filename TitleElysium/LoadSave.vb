Imports System.IO
Public Class frmLoadSave
    Private saveslot As Integer

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        frmTitle.Show()
        Me.Close()
    End Sub

    Private Sub frmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveslot = 0
        Call ShowData()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Select Case True
            Case rdbSave1.Checked
                saveslot = 1
            Case rdbSave2.Checked
                saveslot = 2
            Case rdbSave3.Checked
                saveslot = 3
            Case Else
                MessageBox.Show("Please select a game file to load!", "Elysium", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
        End Select

        MessageBox.Show("Are you sure you want to load file" & saveslot & "?", "Elysium", MessageBoxButtons.YesNo)
        If DialogResult.Yes = True Then
            ' load the variables and start the game
        End If
    End Sub

    Private Sub ShowData()

        Dim saveData As StreamReader
        Dim str() As String

        If File.Exists("Save 1.txt") Then
            saveData = File.OpenText("Save 1.txt")

            Do Until saveData.Peek = -1
                str = Split(saveData.ReadLine(), ", ")

                lblNameM1.Text = str(0)
                lblLvlM1.Text = "LVL " & str(1)
                lblNameF1.Text = str(2)
                lblLvlF1.Text = "LVL " & str(3)
                lblArea1.Text = "Location: " & str(4)
                lblGold1.Text = "Total Gold: " & str(5)
                picMale1.Visible = True
                picFemale1.Visible = True
                rdbSave1.Visible = True
            Loop

            saveData.Close()
        End If

        If File.Exists("Save 2.txt") Then
            saveData = File.OpenText("Save 2.txt")

            Do Until saveData.Peek = -1
                str = Split(saveData.ReadLine(), ", ")

                lblNameM2.Text = str(0)
                lblLvlM2.Text = "LVL " & str(1)
                lblNameF2.Text = str(2)
                lblLvlF2.Text = "LVL " & str(3)
                lblArea2.Text = "Location: " & str(4)
                lblGold2.Text = "Total Gold: " & str(5)
                picMale2.Visible = True
                picFemale2.Visible = True
                rdbSave2.Visible = True
            Loop

            saveData.Close()
        End If

        If File.Exists("Save 3.txt") Then
            saveData = File.OpenText("Save 3.txt")

            Do Until saveData.Peek = -1
                str = Split(saveData.ReadLine(), ", ")

                lblNameM3.Text = str(0)
                lblLvlM3.Text = "LVL " & str(1)
                lblNameF3.Text = str(2)
                lblLvlF3.Text = "LVL " & str(3)
                lblArea3.Text = "Location: " & str(4)
                lblGold3.Text = "Total Gold: " & str(5)
                picMale3.Visible = True
                picFemale3.Visible = True
                rdbSave3.Visible = True
            Loop

            saveData.Close()
        End If
    End Sub
End Class