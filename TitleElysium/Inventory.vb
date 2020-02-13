Imports System.IO
Module Inventory
    Public crystalsSaved As Integer
    Public items(8) As Integer

    Public Sub LoadItemInventory()
        Dim inventory As StreamReader
        Dim num(8) As String

        If File.Exists("iteminventory.txt") Then
            inventory = File.OpenText("iteminventory.txt")
            Do Until inventory.Peek = -1
                num = Split(inventory.ReadLine(), ",")
                items(1) = num(1)
                items(2) = num(2)
                items(3) = num(3)
                items(4) = num(4)
                items(5) = num(5)
                items(6) = num(6)
                items(7) = num(7)
                items(8) = num(8)
            Loop

            inventory.Close()
        End If
    End Sub

    Public Sub SaveItemInventory(ByVal num() As String)
        Dim inventory As StreamWriter

        inventory = File.CreateText("iteminventory.txt")
        inventory.WriteLine(gold & "," & items(1) & "," & items(2) & "," & items(3) & "," & items(4) & "," & items(5) _
                   & "," & items(6) & "," & items(7) & "," & items(8))
        inventory.Close()
    End Sub
End Module
