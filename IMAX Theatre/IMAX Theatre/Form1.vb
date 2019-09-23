' Program Name: IMAX Theatre Tickets
' Author:       Aidan J Culley
' Date:         September 23rd, 2019
' Purpose:      This application calculates total cost of tickets based off of IMAX show

Option Strict On
Public Class frmIMAX

    Dim intMatineeCost As Integer = 16
    Dim intEveningCost As Integer = 27

    Private Sub CboShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShow.SelectedIndexChanged
        ' allows show choice, updates display

        lblTickets.Visible = True
        txtTickets.Visible = True
        btnCost.Visible = True
        btnClear.Visible = True
        txtTickets.Focus()
    End Sub

    Private Sub BtnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' calculates cost 

        Dim intShowChoice As Integer = cboShow.SelectedIndex
        Dim intTotalTickets As Integer
        Dim intRate As Integer
        Dim intTotalCost As Integer

        If IsNumeric(txtTickets.Text) Then
            intTotalTickets = Convert.ToInt32(txtTickets.Text)
            Select Case intShowChoice
                Case 0
                    intRate = intMatineeCost
                Case 1
                    intRate = intEveningCost
            End Select
            intTotalCost = intRate * intTotalTickets
            lblTotalCost.Text = String.Format("{0} for the tickets", intTotalCost.ToString("C"))
            lblTotalCost.Visible = True
        Else
            MsgBox("Enter a valid number", , "Error")
        End If
    End Sub

    Private Sub FrmIMAX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' users feel validated when it has a slow loading time, i watched a video about it 
        Threading.Thread.Sleep(4000)
    End Sub
End Class
