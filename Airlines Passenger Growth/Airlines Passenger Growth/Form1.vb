' Program Name: Airlines Passenger Growth
' Author:       Aidan J Culley
' Date:         September 26th, 2019 
' Purpose:      Predicts the future amount of airline passengers

Option Strict On
Public Class frmGrowth
    Const decGrowth As Decimal = 0.069D
    Const ulong2017 As ULong = 3800000000

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Calculates the next 10 years of airline passengers

        Dim intYears As Integer = 10
        Dim intStarting As Integer = 2017
        Dim intEntries As Integer = 1
        Dim ulongGrowth As ULong = ulong2017

        lstGrowth.Items.Clear()

        Do Until intEntries > intYears
            intStarting += 1
            intEntries += 1
            ulongGrowth += CULng(ulongGrowth * decGrowth)
            lstGrowth.Items.Add(String.Format("Year {0}: {1}", intStarting.ToString(), ulongGrowth.ToString("N").Substring(0, ulongGrowth.ToString("N").Length - 3)))
        Loop
    End Sub

    Private Sub BtnSpecificCalculate_Click(sender As Object, e As EventArgs) Handles btnSpecificCalculate.Click
        ' calculates a prediction for a certain year within 2017-2027

        Dim strInputMessage As String = "Enter the year you want between (2017-2027)"
        Dim strInputHeading As String = "Growth Prediction"
        Dim strInput As String = InputBox(strInputMessage, strInputHeading, "")
        Dim intFinalYear As Integer

        Do Until Integer.TryParse(strInput, intFinalYear) = True And intFinalYear >= 2018 And intFinalYear <= 2027
            strInput = InputBox(strInputMessage, strInputHeading, "")
        Loop
        lblYear.Visible = True
        lblYear.Text = "In the year " & intFinalYear.ToString() & ","
        lblPrediction.Visible = True
        lblPrediction.Text = "There will be " & growthCalculation(intFinalYear).ToString("N") & " airline passengers"
    End Sub
    Function growthCalculation(ByVal intFinalYear As Integer) As ULong
        Dim intYears As Integer = 2017
        Dim ulongPrediction As ULong = ulong2017
        Do Until intYears = intFinalYear
            intYears += 1
            ulongPrediction += CULng(ulongPrediction * decGrowth)
        Loop
        Return ulongPrediction
    End Function
End Class
