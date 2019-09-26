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
            lstGrowth.Items.Add(String.Format("Year {0}: {1}", intStarting.ToString(), ulongGrowth.ToString()))
        Loop
    End Sub


End Class
