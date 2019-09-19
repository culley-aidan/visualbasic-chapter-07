' Program Name: Scuba Expeditions Application
' Author:       Aidan J Culley
' Date:         September 19th, 2019
' Purpose:      The Scuba Epeditions app determins the location and scuba dives available and calculates the total dive team cost.

Option Strict On
Public Class frmScuba

    ' Class variables
    Private _intFourHour As Integer = 4
    Private _intSixHour As Integer = 6
    Private _intEightHour As Integer = 8
    Private _strDive1 As String = "Great Barrier Reef"
    Private _strDive2 As String = "Tiger Shark"
    Private _strDive3 As String = "Fathom Chasm"
    Private _strDive4 As String = "Great Blue Chasm"
    Private _strDive5 As String = "Rainbow reef"
    Private _strDive6 As String = "Namena Sunken Ship"

    Private Sub CboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        ' This event handler allows the user to enter the location choice and then calls subprocedures to place the dive types in the list.
        Dim intLocationChoice As Integer

        intLocationChoice = cboLocation.SelectedIndex
        lstDive.Items.Clear()
        Select Case intLocationChoice
            Case 0
                AustraliaTeam()
            Case 1
                BelizeTeam()
            Case 2
                FijiTeam()
        End Select

        ' Make items visible in the window 
        lblTeam.Visible = True
        txtTeam.Visible = True
        lblSelect.Visible = True
        lstDive.Visible = True
        btnDiveCost.Visible = True
        btnClear.Visible = True
        lblScubaDive.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True
        ' Clear the labels
        lblScubaDive.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        ' Set focus on number in dive team text box
        txtTeam.Focus()
    End Sub

    Private Sub AustraliaTeam()
        ' This procedure fills in the possible dive types offered in australia
        lstDive.Items.Add(_strDive1)
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
    End Sub

    Private Sub BelizeTeam()
        ' This procedure fills in the possible dive types offered in Belize
        lstDive.Items.Add(_strDive4)
        lstDive.Items.Add(_strDive5)
    End Sub

    Private Sub FijiTeam()
        ' This procedure fills in the possible dive types offered in Fiji
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
        lstDive.Items.Add(_strDive6)
    End Sub

    Private Sub BtnDiveCost_Click(sender As Object, e As EventArgs) Handles btnDiveCost.Click

    End Sub
End Class
