<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrowth
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSpecificCalculate = New System.Windows.Forms.Button()
        Me.lstGrowth = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(46, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(435, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Airlines' Passenger Growth"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(46, 308)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(162, 61)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Predict the next ten years"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSpecificCalculate
        '
        Me.btnSpecificCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpecificCalculate.Location = New System.Drawing.Point(319, 308)
        Me.btnSpecificCalculate.Name = "btnSpecificCalculate"
        Me.btnSpecificCalculate.Size = New System.Drawing.Size(162, 61)
        Me.btnSpecificCalculate.TabIndex = 2
        Me.btnSpecificCalculate.Text = "Predict a certain year"
        Me.btnSpecificCalculate.UseVisualStyleBackColor = True
        '
        'lstGrowth
        '
        Me.lstGrowth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrowth.FormattingEnabled = True
        Me.lstGrowth.ItemHeight = 24
        Me.lstGrowth.Location = New System.Drawing.Point(46, 58)
        Me.lstGrowth.Name = "lstGrowth"
        Me.lstGrowth.Size = New System.Drawing.Size(435, 244)
        Me.lstGrowth.TabIndex = 3
        '
        'frmGrowth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 450)
        Me.Controls.Add(Me.lstGrowth)
        Me.Controls.Add(Me.btnSpecificCalculate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmGrowth"
        Me.Text = "Airline Passenger Growth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSpecificCalculate As Button
    Friend WithEvents lstGrowth As ListBox
End Class
