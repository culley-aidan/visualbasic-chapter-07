﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMAX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.cboShow = New System.Windows.Forms.ComboBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblTotalCost)
        Me.Panel1.Controls.Add(Me.txtTickets)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnCost)
        Me.Panel1.Controls.Add(Me.cboShow)
        Me.Panel1.Controls.Add(Me.lblTickets)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(421, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 454)
        Me.Panel1.TabIndex = 3
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Transparent
        Me.lblTotalCost.Location = New System.Drawing.Point(75, 374)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(221, 25)
        Me.lblTotalCost.TabIndex = 9
        Me.lblTotalCost.Text = "$XX.XX for the tickets"
        Me.lblTotalCost.Visible = False
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(197, 193)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(33, 31)
        Me.txtTickets.TabIndex = 8
        Me.txtTickets.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Transparent
        Me.btnClear.Location = New System.Drawing.Point(135, 300)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(161, 51)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.Transparent
        Me.btnCost.Location = New System.Drawing.Point(135, 243)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(161, 51)
        Me.btnCost.TabIndex = 6
        Me.btnCost.Text = "Ticket Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        Me.btnCost.Visible = False
        '
        'cboShow
        '
        Me.cboShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShow.FormattingEnabled = True
        Me.cboShow.Items.AddRange(New Object() {"Mantinee $16", "Evening $27"})
        Me.cboShow.Location = New System.Drawing.Point(137, 93)
        Me.cboShow.Name = "cboShow"
        Me.cboShow.Size = New System.Drawing.Size(159, 32)
        Me.cboShow.TabIndex = 5
        Me.cboShow.Text = "Select Show:"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.BackColor = System.Drawing.Color.Transparent
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(120, 149)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(192, 25)
        Me.lblTickets.TabIndex = 4
        Me.lblTickets.Text = "Number of Tickets:"
        Me.lblTickets.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(45, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(343, 37)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "IMAX Theatre Tickets"
        '
        'frmIMAX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMAX_Theatre.My.Resources.Resources.imax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmIMAX"
        Me.Text = "IMAX Theatre"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents cboShow As ComboBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents lblTotalCost As Label
End Class
