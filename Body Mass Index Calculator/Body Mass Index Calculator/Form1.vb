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
        btnCalculate.Enabled = True
        btnClear.Visible = True
        btnClear.Enabled = True
        lblWeight.Text = "Weight "
        Select Case cboUnits.SelectedIndex
            Case 0
                lblHeight.Text = " Height "
                lblWeight.Text += "(kg):"
                lblHeight.Text += "(m):"
            Case 1
                lblHeight.Text = "Height "
                lblWeight.Text += "(lb):"
                lblHeight.Text += "(in):"
        End Select
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' calculate 
        Dim decBMI As Decimal
        Dim strWeightStatus As String
        Dim strHeight As String = txtHeight.Text
        Dim strWeight As String = txtWeight.Text
        Dim decHeight As Decimal
        Dim decWeight As Decimal

        txtHeight.Enabled = False
        txtWeight.Enabled = False
        btnCalculate.Enabled = False

        ' "use trycatch" 
        ' malicious compliance
        If String.IsNullOrWhiteSpace(strHeight) = False And String.IsNullOrWhiteSpace(strWeight) = False Then
            Try
                decHeight = Decimal.Parse(strHeight)
                decWeight = Decimal.Parse(strWeight)

                Select Case cboUnits.SelectedIndex
                    Case 0
                        MetricBMI(decHeight, decWeight, decBMI)
                    Case 1
                        ImperialBMI(decHeight, decWeight, decBMI)
                End Select

                lblBMI.Text += Math.Round(decBMI, 2).ToString()
                lblBMI.Visible = True

                Select Case decBMI
                    Case < 18.5D
                        strWeightStatus = "Underweight"
                    Case 18.5D To 24.9D
                        strWeightStatus = "Normal Weight"
                    Case 25D To 29.9D
                        strWeightStatus = "Overweight"
                    Case > 30D
                        strWeightStatus = "Obese"
                End Select

                lblWeightStatus.Text += strWeightStatus
                lblWeightStatus.Visible = True
            Catch ex As Exception
                MsgBox("Enter a numeric value", , "Error")
            End Try
        Else
            MsgBox("Enter a value", , "Error")
        End If
    End Sub
    Private Sub MetricBMI(ByVal decHeight As Decimal, ByVal decWeight As Decimal, ByRef decBMI As Decimal)
        decBMI = decWeight / (decHeight * decHeight)
    End Sub

    Private Sub ImperialBMI(ByVal decHeight As Decimal, ByVal decWeight As Decimal, ByRef decBMI As Decimal)
        decBMI = (decWeight / (decHeight * decHeight)) * 703
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear function 
        cboUnits.Text = "Measurement System:"
        lblBMI.Text = "Your BMI is: "
        lblWeightStatus.Text = "Your weight status is: "

        lblWeight.Visible = False
        lblHeight.Visible = False

        txtWeight.Visible = False
        txtWeight.Text = ""
        txtWeight.Enabled = True

        txtHeight.Visible = False
        txtHeight.Text = ""
        txtHeight.Enabled = True

        btnCalculate.Visible = False
        btnCalculate.Enabled = False

        btnClear.Visible = False
        btnClear.Enabled = False
    End Sub

    Private Sub FrmBMICalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(2000)
    End Sub
End Class
