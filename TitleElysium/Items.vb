Imports System.IO
Public Class frmItems
    Private consumables As Boolean
    Private item As Integer
    Private items() As String
    Private healthheal As Integer
    Private inventory As StreamReader

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmInGameMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMale.Text = maleName
        btnFemale.Text = femaleName
    End Sub

    Private Sub lsvItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvItems.SelectedIndexChanged
        Dim selected As String = lsvItems.FocusedItem.Text
        Dim strDesc As String

        If consumables = True Then
            btnUse.Enabled = True
            Select Case selected
                Case "Potion"
                    strDesc = "Standard healing potion. Heals 100 health."
                    item = 1
                Case "Hi-Potion"
                    strDesc = "Advanced healing potion. Heals 200 health."
                    item = 2
                Case "Tonic"
                    strDesc = "Standard healing tonic. Heals 150 health to both members."
                    item = 3
                Case "Max-Potion"
                    strDesc = "Mythical healing potion. Heals the user completely."
                    item = 4
            End Select
        Else

        End If
        lblDesc.Text = strDesc
    End Sub

    Private Sub btnConsumables_Click(sender As Object, e As EventArgs)
        consumables = True
        If File.Exists("iteminventory.txt") Then
            inventory = File.OpenText("iteminventory.txt")

            Do Until inventory.Peek = -1
                items = Split(inventory.ReadLine(), ",")
            Loop
            inventory.Close()
            Call DisplayItems()
        End If
    End Sub

    Private Sub DisplayItems()
        Dim add() As String
        Dim lvi As New ListViewItem
        Dim str() = New String() {"Potion", "Hi-Potion", "Tonic",
         "Max-Potion"}

        lsvItems.Items.Clear()

        Dim count, countitem As Integer
        For count = 0 To str.Count - 1
            countitem += 1
            If items(countitem) <> 0 Then
                add = New String() {str(count), items(countitem)}
                lvi = New ListViewItem(add)
                lsvItems.Items.Add(lvi)
            End If
        Next
    End Sub

    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click

        Select Case item
            Case 1
                healthheal = 100
            Case 2
                healthheal = 200
            Case 3
                healthheal = 150
                mCurrHP = mCurrHP + healthheal
                If mCurrHP >= mMaxHP Then
                    mCurrHP = mMaxHP
                End If
                fCurrHP = fCurrHP + healthheal
                If fCurrHP >= fMaxHP Then
                    fCurrHP = fMaxHP
                End If
                items(item) -= 1
            Case 4
                healthheal = 999
        End Select

        Select Case item
            Case 1, 2, 4
                btnMale.Visible = True
                btnFemale.Visible = True
                lblDesc.Text = "Use on who?"
        End Select
    End Sub

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click, btnFemale.Click
        Dim btnSender As Button = sender

        Select Case btnSender.Tag
            Case 1
                Select Case item
                    Case 1, 2, 4
                        mCurrHP = mCurrHP + healthheal
                        If mCurrHP >= mMaxHP Then
                            mCurrHP = mMaxHP
                        End If
                End Select

            Case 2
                Select Case item
                    Case 1, 2, 4
                        fCurrHP = fCurrHP + healthheal
                        If fCurrHP >= fMaxHP Then
                            fCurrHP = fMaxHP
                        End If
                End Select
        End Select

        items(item) -= 1
        btnMale.Visible = False
        btnFemale.Visible = False
        btnUse.Enabled = False
        Call DisplayItems()
    End Sub
End Class