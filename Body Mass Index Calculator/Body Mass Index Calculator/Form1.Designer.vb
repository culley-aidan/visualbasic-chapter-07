﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMICalc
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
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboUnits = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.BackgroundImage = Global.Body_Mass_Index_Calculator.My.Resources.Resources.epic
        Me.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(412, 450)
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblWeight)
        Me.Panel1.Controls.Add(Me.cboUnits)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(410, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 450)
        Me.Panel1.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(378, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Body Mass Index Calculator"
        '
        'cboUnits
        '
        Me.cboUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnits.FormattingEnabled = True
        Me.cboUnits.Items.AddRange(New Object() {"Metric System (m,kg)", "Imperial System (in, lb)"})
        Me.cboUnits.Location = New System.Drawing.Point(88, 62)
        Me.cboUnits.Name = "cboUnits"
        Me.cboUnits.Size = New System.Drawing.Size(211, 32)
        Me.cboUnits.TabIndex = 1
        Me.cboUnits.Text = "Measurement System:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(60, 124)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(133, 25)
        Me.lblWeight.TabIndex = 2
        Me.lblWeight.Text = "Weight (xx): "
        'frmBMICalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picBackground)
        Me.DoubleBuffered = True
        Me.Name = "frmBMICalc"
        Me.Text = "Body Mass Index Calculator"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboUnits As ComboBox
    Friend WithEvents lblWeight As Label
End Class