<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCalculator = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.TxtPrompt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(347, 39)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(96, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCalculator
        '
        Me.lblCalculator.AutoSize = True
        Me.lblCalculator.Location = New System.Drawing.Point(12, 9)
        Me.lblCalculator.Name = "lblCalculator"
        Me.lblCalculator.Size = New System.Drawing.Size(67, 16)
        Me.lblCalculator.TabIndex = 1
        Me.lblCalculator.Text = "Calculator"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(168, 39)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(139, 22)
        Me.TxtNumber.TabIndex = 2
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(73, 102)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(37, 16)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "Sum:"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(73, 74)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(53, 16)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Prompt:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(73, 46)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(58, 16)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Number:"
        '
        'TxtSum
        '
        Me.TxtSum.Location = New System.Drawing.Point(168, 96)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.Size = New System.Drawing.Size(139, 22)
        Me.TxtSum.TabIndex = 6
        '
        'TxtPrompt
        '
        Me.TxtPrompt.Location = New System.Drawing.Point(168, 68)
        Me.TxtPrompt.Name = "TxtPrompt"
        Me.TxtPrompt.Size = New System.Drawing.Size(139, 22)
        Me.TxtPrompt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 145)
        Me.Controls.Add(Me.TxtPrompt)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.lblCalculator)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Sum Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCalculator As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents lblSum As Label
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents TxtPrompt As TextBox
End Class
