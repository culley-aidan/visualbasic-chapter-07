' Program Name: IMAX Theatre Tickets
' Author:       Aidan J Culley
' Date:         September 23rd, 2019
' Purpose:      This application calculates total cost of tickets based off of IMAX show

Option Strict On
Public Class frmIMAX
    Private Sub CboShow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShow.SelectedIndexChanged
        ' allows show choice, updates display

        lblTickets.Visible = True
        txtTickets.Visible = True
        btnCost.Visible = True
        btnClear.Visible = True
        txtTickets.Focus()
    End Sub


End Class
