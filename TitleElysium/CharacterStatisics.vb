Module BattleScreen

    Public maleName As String
    Public femaleName As String
    Public mLevel As Integer
    Public fLevel As Integer
    Public mMaxHP As Integer
    Public fMaxHP As Integer
    Public mCurrHP As Integer
    Public fCurrHP As Integer
    Public mVit As Integer
    Public mStr As Integer
    Public mInt As Integer
    Public mAgi As Integer
    Public EXP As Integer
    Public EXPNext As Integer
    Public fVit As Integer
    Public fStr As Integer
    Public fInt As Integer
    Public fAgi As Integer
    Public fEXP As Integer
    Public gold As Integer
    Public ultimateSkillsCheck As Boolean
    Public returnToPrev As Boolean
    Public enemy1(4) As Integer
    Public enemy2(4) As Integer
    Public enemy3(4) As Integer
    Public monstersDefeated As Integer
    'Order of elements: vit(health in this case for now), atk, pdef, mdef. use redim to calculate stats at the form load

    Public goldGained As Integer
    Public EXPGained As Integer

    Public Function CalculateHP(ByVal level As Integer, ByVal vit As Integer)
        Return (3 * vit) + (2 * vit * level)
    End Function

    Public Sub PlayMusic()
        'My.Computer.Audio.Play(My.Resources.test.wav,
        'AudioPlayMode.BackgroundLoop)
    End Sub
End Module

