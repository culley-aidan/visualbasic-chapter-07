' Program Name: Body Mass Index Calculator
' Author:       Aidan J Culley
' Date:         September 19th, 2019
' Purpose:      Calculates BMI

Option Strict On
Public Class frmBMICalc
    Private Sub CboUnits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnits.SelectedIndexChanged
        ' updates display

        lblWeight.Visible = True
        lblHeight.Visible = True
        txtWeight.Visible = True
        txtHeight.Visible = True
        btnCalculate.Visible = True
        btnClear.Visible = True
    End Sub

    Private Sub MetricBMI()

    End Sub

    Private Sub ImperialBMI()

    End Sub
End Class
