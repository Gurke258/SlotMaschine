Module Variablen

    '*********** LoginForm *****************************
    'Benutzerdaten

    Public Benutzer(500) As String
    Public Passwort(500) As String
    Public Guthaben(500) As Decimal
    Public Level(500) As Integer
    Public Levelpunkte(500) As Integer

    Public Loginname As String
    Public Loginpasswort As String
    Public LoginGuthaben As Decimal

    Public Loginmoeglich As Boolean
    Public Logindrawing As Graphics


    '************** HauptForm **************************
    'Zeichnen
    Public linie As Graphics = FrmHaupt.CreateGraphics()
    Public RedLine As New Pen(Color.Red, 5)
    Public BlueLine As New Pen(Color.Blue, 5)
    Public GreenLine As New Pen(Color.Green, 5)
    Public YellowLine As New Pen(Color.Yellow, 5)
    Public PurpleLine As New Pen(Color.Purple, 5)
    Public Black As New Pen(Color.Black, 3)
    Public Pinsel As New SolidBrush(Color.Red)
    Public Pinsel1 As New SolidBrush(Color.Blue)
    Public LinesOfHaupt(4) As Boolean


    'Geld
    Public Einsatz As Double

    'Level
    Public Playerlevel As Integer
    Public Levelscore As Double



    '************* Funktionen.vb ************************
    'Gewinn
    Public GewinnGesamt As Double
    Public Früchte As Integer
    Public Lines As Integer


    'FelderHauptform
    Public Feld1, Feld2, Feld3 As Integer
    Public Feld4, Feld5, Feld6 As Integer
    Public Feld7, Feld8, Feld9 As Integer


    'Zuordnung der Resources
    Public Slotbilder() As Bitmap = {My.Resources.favorite_153144, My.Resources.kiwi_2673038_1920, My.Resources.bananas_311788, My.Resources.coconuts_575780, My.Resources.cherry_105141,
                                    My.Resources.citron_154449, My.Resources.pears_1990797_1920, My.Resources.strawberry_34066,
                                    My.Resources.pineapple_300038, My.Resources.apple_336015}


End Module

Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function IsOneOf(Of T)(ActualValue As T, ParamArray ListOfPossibleValues As T()) As Boolean
        Return ListOfPossibleValues.Contains(ActualValue)
    End Function
End Module