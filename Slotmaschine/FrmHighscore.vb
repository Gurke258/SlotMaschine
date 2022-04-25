Imports System.Linq
Public Class FrmHighscore

    Private LblPlayers() As Label
    Private LblMoney() As Label
    'Private WithEvents cs As New ClassHighscore(10)    'Klasse mit der Anzahl der maximalen Einträge Instanziere
    Private Sub Highscore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblPlayers = New Label() {LblPlayer1, LblPlayer2, LblPlayer3, LblPlayer4, LblPlayer5, LblPlayer6, LblPlayer7, LblPlayer8, LblPlayer9, LblPlayer10}
        LblMoney = New Label() {LblMoney1, LblMoney2, LblMoney3, LblMoney4, LblMoney5, LblMoney6, LblMoney7, LblMoney8, LblMoney9, LblMoney10}

        Dim i As Integer
        Dim dictionary = New Dictionary(Of String, Double)
        Dim user(0) As String
        Dim money(0) As Double

        For i = 0 To 9

            If Not String.IsNullOrEmpty(CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine", "Benutzer" & i, Benutzer(i)), String)) Then

                dictionary.Add(CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine", "Benutzer" & i, Benutzer(i)), String), Convert.ToDouble(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine", "Guthaben" & i, Guthaben(i))))

            End If

        Next

        Dim items = From pair In dictionary Order By pair.Value Descending Select pair


        For Each pair As KeyValuePair(Of String, Double) In items

            'highscorelist.ToList()
            ReDim Preserve user(user.Length)
            user(user.Length - 1) = pair.Key

            ReDim Preserve money(money.Length)
            money(money.Length - 1) = pair.Value

        Next


        For i = 1 To Math.Min(LblPlayers.Count(), user.Length) - 1

            If String.IsNullOrEmpty(user(i)) Then
                Exit For
            Else
                'LblPlayers(i) = New Label
                LblPlayers(i - 1).Text = user(i).ToString()
                LblMoney(i - 1).Text = Convert.ToString(money(i)) & " €"
            End If
        Next

        For i = 0 To 9

            If String.IsNullOrEmpty(LblPlayers(i).Text) Then

                LblPlayers(i).Text = ""
                LblMoney(i).Text = ""
            End If

        Next

    End Sub
End Class