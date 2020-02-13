Module MapMovements

    Public intersectLeft As Boolean = False
    Public intersectRight As Boolean = False
    Public intersectUp As Boolean = False
    Public intersectDown As Boolean = False
    Public intersectPerson As Boolean = False
    Public keyPressLeft As Boolean = False
    Public keyPressRight As Boolean = False
    Public keyPressUp As Boolean = False
    Public keyPressDown As Boolean = False
    Public person1 As Boolean = False
    Public grunt1 As Boolean = False
    Public person2 As Boolean = False
    Public grunt2 As Boolean = False
    Public person3 As Boolean = False
    Public girl As Boolean = False
    Public girl2 As Boolean = False
    Public girl3 As Boolean = False
    Public girl4 As Boolean = False
    Public king As Boolean = False
    Public person4 As Boolean = False
    Public girl5 As Boolean = False
    Public person5 As Boolean = False
    Public person6 As Boolean = False
    Public grunt3 As Boolean = False
    Public grunt4 As Boolean = False
    Public grunt5 As Boolean = False
    Public person7 As Boolean = False
    Public person8 As Boolean = False
    Public girl6 As Boolean = False
    Public grunt7 As Boolean = False
    Public grunt6 As Boolean = False
    Public girl7 As Boolean = False
    Public girl8 As Boolean = False
    Public grunt8 As Boolean = False
    Public grunt9 As Boolean = False
    Public grunt10 As Boolean = False
    Public girl9 As Boolean = False
    Public grunt11 As Boolean = False
    Public grunt12 As Boolean = False
    Public grunt13 As Boolean = False
    Public rand As New Random
    Public randomEncounters As Integer
    Public countSteps As Integer
    Public area As String
    Public lastForm() = New Form() {frmMainCastle, frmCastleEntrance, frmDesert, frmForest, frmInn, frmMainTown, frmMainVolcano, _
                                    frmNavalCave, frmWaterRuins, frmVolcano}

    Public Sub HiddenForm(ByVal area As String)
        Dim countArea As Integer

        Select Case area
            Case "Castle"
                countArea = 0
            Case "Castle Entrance"
                countArea = 1
            Case "Desert"
                countArea = 2
            Case "Forest"
                countArea = 3
            Case "Inn"
                countArea = 4
            Case "Town"
                countArea = 5
            Case "Volcano Cavern"
                countArea = 6
            Case "Naval Cave"
                countArea = 7
            Case "Underwater Ruins"
                countArea = 8
            Case "Volcano"
                countArea = 9

        End Select

        If returnToPrev = True Then
            lastForm(countArea).show()
        End If

    End Sub
End Module
