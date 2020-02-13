Imports System.IO
Public Class frmSave
    Private saveslot As Integer
    Private Sub frmSave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveslot = 0
        Call ShowData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Select Case True
            Case rdbSave1.Checked
                saveslot = 1
                Call SavingData()
            Case rdbSave2.Checked
                saveslot = 2
                Call SavingData()
            Case rdbSave3.Checked
                saveslot = 3
                Call SavingData()
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmInGameMenu.Show()
        Me.Close()
    End Sub

    Private Sub SavingData()
        Dim saveData As StreamWriter

        saveData = File.CreateText("Save " & saveslot & ".txt")

        saveData.Write(maleName & ", ")
        saveData.Write(mLevel & ", ")
        saveData.Write(femaleName & ", ")
        saveData.Write(flevel & ", ")
        saveData.Write(area & ", ")
        saveData.Write(gold & ", ")
        saveData.WriteLine()

        saveData.Close()

        Call ShowData()
        MessageBox.Show("File " & saveslot & " successfully saved.", "Elysium", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'have stuff appear here
    End Sub
    'Try to use a loop, find out how to change the destination labels using a counter variable
    Private Sub ShowData()

        Dim saveData As StreamReader
        Dim str() As String
        ' Dim fileNo As String
        'Dim count As Integer

        'For count = 1 To 3
        'fileNo = CStr(count)

        Select Case saveslot
            Case 1
                lblNameM.Text = maleName
                lblNameF.Text = femaleName
                lblLvlM.Text = "LVL " & mLevel
                lblLvlF.Text = "LVL " & flevel
                lblArea.Text = "Location: " & area
                lblGold.Text = "Total Gold: " & gold
            Case 2
                lblNameM2.Text = maleName
                lblNameF2.Text = femaleName
                lblLvlM2.Text = "LVL " & mLevel
                lblLvlF2.Text = "LVL " & flevel
                lblArea2.Text = "Location: " & area
                lblGold2.Text = "Total Gold: " & gold
            Case 3
                lblNameM3.Text = maleName
                lblNameF3.Text = femaleName
                lblLvlM3.Text = "LVL " & mLevel
                lblLvlF3.Text = "LVL " & flevel
                lblArea3.Text = "Location: " & area
                lblGold3.Text = "Total Gold: " & gold
            Case 0
                If File.Exists("Save 1.txt") Then
                    saveData = File.OpenText("Save 1.txt")

                    Do Until saveData.Peek = -1
                        str = Split(saveData.ReadLine(), ", ")

                        lblNameM.Text = str(0)
                        lblLvlM.Text = "LVL " & str(1)
                        lblNameF.Text = str(2)
                        lblLvlF.Text = "LVL " & str(3)
                        lblArea.Text = "Location: " & str(4)
                        lblGold.Text = "Total Gold: " & str(5)
                        picMale.Visible = True
                        picFemale.Visible = True
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
                    Loop

                    saveData.Close()
                End If
        End Select
    End Sub
End Class