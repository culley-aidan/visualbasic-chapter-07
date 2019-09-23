<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cboShow = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCost)
        Me.Panel1.Controls.Add(Me.cboShow)
        Me.Panel1.Controls.Add(Me.lblTickets)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(421, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 454)
        Me.Panel1.TabIndex = 3
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
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(69, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "IMAX Theatre Tickets"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.Transparent
        Me.btnCost.Location = New System.Drawing.Point(135, 270)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(161, 51)
        Me.btnCost.TabIndex = 6
        Me.btnCost.Text = "Ticket Cost"
        Me.btnCost.UseVisualStyleBackColor = False
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
End Class
