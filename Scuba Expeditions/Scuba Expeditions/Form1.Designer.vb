<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScuba
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstDive = New System.Windows.Forms.ListBox()
        Me.btnDiveCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblScubaDive = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblScubaDive)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnDiveCost)
        Me.Panel1.Controls.Add(Me.lstDive)
        Me.Panel1.Controls.Add(Me.lblSelect)
        Me.Panel1.Controls.Add(Me.txtTeam)
        Me.Panel1.Controls.Add(Me.lblTeam)
        Me.Panel1.Controls.Add(Me.cboLocation)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(430, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 451)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(2, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(417, 34)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Oceanic Scuba Expeditions"
        '
        'cboLocation
        '
        Me.cboLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Items.AddRange(New Object() {"Australia", "Belize", "Fiji"})
        Me.cboLocation.Location = New System.Drawing.Point(130, 72)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(159, 32)
        Me.cboLocation.TabIndex = 1
        Me.cboLocation.Text = "Select Location:"
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(74, 118)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(225, 25)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Number in Dive Team:"
        '
        'txtTeam
        '
        Me.txtTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Location = New System.Drawing.Point(316, 115)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(32, 31)
        Me.txtTeam.TabIndex = 3
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(116, 169)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(194, 25)
        Me.lblSelect.TabIndex = 4
        Me.lblSelect.Text = "Select Scuba Dive:"
        '
        'lstDive
        '
        Me.lstDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDive.FormattingEnabled = True
        Me.lstDive.ItemHeight = 24
        Me.lstDive.Location = New System.Drawing.Point(123, 197)
        Me.lstDive.Name = "lstDive"
        Me.lstDive.Size = New System.Drawing.Size(176, 76)
        Me.lstDive.TabIndex = 5
        '
        'btnDiveCost
        '
        Me.btnDiveCost.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDiveCost.ForeColor = System.Drawing.Color.White
        Me.btnDiveCost.Location = New System.Drawing.Point(53, 293)
        Me.btnDiveCost.Name = "btnDiveCost"
        Me.btnDiveCost.Size = New System.Drawing.Size(131, 45)
        Me.btnDiveCost.TabIndex = 6
        Me.btnDiveCost.Text = "Dive Cost"
        Me.btnDiveCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(233, 293)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 45)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblScubaDive
        '
        Me.lblScubaDive.AutoSize = True
        Me.lblScubaDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScubaDive.Location = New System.Drawing.Point(130, 360)
        Me.lblScubaDive.Name = "lblScubaDive"
        Me.lblScubaDive.Size = New System.Drawing.Size(180, 25)
        Me.lblScubaDive.TabIndex = 8
        Me.lblScubaDive.Text = "XXXXXXXXXXXX"
        '
        'frmScuba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scuba_Expeditions.My.Resources.Resources.scuba
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmScuba"
        Me.Text = "Oceanic Scuba Expeditions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents lstDive As ListBox
    Friend WithEvents btnDiveCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblScubaDive As Label
End Class
