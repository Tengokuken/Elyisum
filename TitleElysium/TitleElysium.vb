Imports System.Drawing.Text
Public Class frmTitle

    Private Sub frmTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            lblPressEnter.Visible = False
            btnNewGame.Visible = True
            btnLoadGame.Visible = True
            btnOptions.Visible = True
            btnHelp.Visible = True
            btnExit.Visible = True
            tmrFlash.Enabled = False
        End If
    End Sub

    Private Sub frmTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PlayMusic()
        tmrFlash.Enabled = True
    End Sub

    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click, btnLoadGame.Click,
                                                                                                     btnOptions.Click, btnExit.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                frmCharSelect.Show()
            Case 2
                frmLoadSave.Show()
            Case 3
                frmhelp.show()
            Case 4
                frmOptions.Show()
            Case 5
                Application.Exit()
        End Select
        Me.Hide()
    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick
        If lblPressEnter.Visible = True Then
            lblPressEnter.Visible = False
        ElseIf lblPressEnter.Visible = False Then
            lblPressEnter.Visible = True
        End If
    End Sub
End Class
