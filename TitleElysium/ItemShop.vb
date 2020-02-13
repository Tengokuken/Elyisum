Imports System.IO
Public Class frmItemShop

    Private buyItems As Boolean = False
    Private cost As Integer
    Private str() = New String() {"Potion", "Hi-Potion", "Tonic", "Max-Potion"}
    Private quantity As String
    Private selected As String

    Private Sub frmItemShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescription.Text = "Welcome to the item shop! How may I serve you?"

        Call ShowItems()
        Call LoadItemInventory()
        lblGold.Text = gold & "G"
    End Sub

    Private Sub lblBuy_Click(sender As Object, e As EventArgs) Handles lblBuy.Click
        lstItems.Items.Clear()
        buyItems = True
        lblDescription.Text = "What would you like to buy?"
        btnBuy.Visible = True
        btnBuy.Enabled = False
        Call ShowItems()
    End Sub

    Private Sub lblSell_Click(sender As Object, e As EventArgs) Handles lblSell.Click
        lstItems.Items.Clear()
        buyItems = True
        lblDescription.Text = "What would you like to sell?"
        btnSell.Visible = True
        btnSell.Enabled = False
        Call ShowItems()
    End Sub

    Private Sub ShowItems()
        Dim items As String

        lstItems.Items.Clear()
        If buyItems = False Then
            lblBuy.Visible = True
            lblSell.Visible = True
            lblExit.Visible = True
            lstItems.Visible = False
            btnBuy.Visible = False
            btnSell.Visible = False
            btnExit.Visible = False
        Else
            lblBuy.Visible = False
            lblSell.Visible = False
            lblExit.Visible = False
            lstItems.Visible = True
            btnExit.Visible = True

            Select Case crystalsSaved
                Case 0
                    items = 0
                Case 1
                    items = 1
                Case 2
                    items = 2
                Case 3
                    items = 3
            End Select

            For count As Integer = 0 To items
                lstItems.Items.Add(str(count))
            Next
        End If
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        Dim purchased As String
        Dim totalCost As Integer

        selected = lstItems.SelectedItem.ToString()
        Do
            purchased = InputBox("How many would you like to buy?")

            If IsNumeric(purchased) = False Then
                MessageBox.Show("Enter a numerical value from 1 to 99.")
            ElseIf purchased < 1 Or purchased > 99
                MessageBox.Show("Enter a numerical value from 1 to 99.")
            Else
                Exit Do
            End If
        Loop

        If totalCost > gold Then
            MessageBox.Show("You have insufficient funds!")
        Else
            totalCost = cost * purchased
            Select Case selected
                Case "Potion"
                    items(1) += purchased
                Case "Hi-Potion"
                    items(2) += purchased
                Case "Tonic"
                    items(3) += purchased
                Case "Max-Potion"
                    items(4) += purchased
            End Select

            gold = gold - totalCost
            lblGold.Text = gold & "G"
            Call ShowInformation()
        End If
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim selling As String
        Dim totalSell As Integer

        selected = lstItems.SelectedItem.ToString()
        Do
            selling = InputBox("How many would you like to sell?")

            If IsNumeric(selling) = False Then
                MessageBox.Show("Enter a numerical value from 1 to 99.")
            ElseIf selling < 1 Or selling > 99
                MessageBox.Show("Enter a numerical value from 1 to 99.")
            Else
                Exit Do
            End If
        Loop

        If quantity < selling Then
            MessageBox.Show("You don't have enough of that item!")
        Else
            totalSell = (cost / 2) * selling
            Select Case selected
                Case "Potion"
                    items(1) -= selling
                Case "Hi-Potion"
                    items(2) -= selling
                Case "Tonic"
                    items(3) -= selling
                Case "Max-Potion"
                    items(4) -= selling
            End Select
        End If
        gold = gold + totalSell
        lblGold.Text = gold & "G"
        Call ShowInformation()
    End Sub

    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged
        quantity = lstItems.SelectedItem.ToString()
        btnBuy.Enabled = True
        btnSell.Enabled = True
        Call ShowInformation()
    End Sub

    Private Sub ShowInformation()
        Dim strDesc As String

        selected = lstItems.SelectedItem.ToString()
        Select Case selected
            Case "Potion"
                quantity = items(1)
                strDesc = "Standard healing potion. Heals 100 health." & vbNewLine & "Cost: 100G"
                cost = 100
            Case "Ether"
                quantity = items(2)
                strDesc = "Standard mana regen potion. Restores 50 mana." & vbNewLine & "Cost: 150G"
                cost = 150
            Case "Resurrect"
                quantity = items(3)
                strDesc = "One-use resurrection scroll. Revives party member with half their max health." & vbNewLine & "Cost: 400G"
                cost = 400
            Case "Hi-Potion"
                quantity = items(4)
                strDesc = "Advanced healing potion. Heals 200 health." & vbNewLine & "Cost: 300G"
                cost = 300
            Case "Tonic"
                quantity = items(5)
                strDesc = "Standard healing tonic. Heals 150 health to both members." & vbNewLine & "Cost: 500G"
                cost = 500
            Case "Ether of Queens"
                quantity = items(6)
                strDesc = "Advanced mana regen potion. Restores 100 mana." & vbNewLine & "Cost: 400G"
                cost = 400
            Case "Max-Potion"
                quantity = items(7)
                strDesc = "Mythical healing potion. Heals the user completely." & vbNewLine & "Cost: 700G"
                cost = 700
            Case "Ether of Kings"
                quantity = items(8)
                strDesc = "Mythical mana regen potion. Completely restores the user's mana." & vbNewLine & "Cost: 900G"
                cost = 900
        End Select

        lblQuantity.Text = "Quantity = " & quantity
        lblDescription.Text = strDesc
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Call SaveItemInventory(str)
        frmMainTown.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        lblQuantity.Text = ""
        buyItems = False
        lblDescription.Text = "Would you like to do anything else?"
        Call ShowItems()
    End Sub
End Class