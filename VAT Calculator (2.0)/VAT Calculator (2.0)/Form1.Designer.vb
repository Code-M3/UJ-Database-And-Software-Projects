<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalary
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
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.TxtGross = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.TxtTax = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(317, 46)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 40)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(12, 9)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(109, 16)
        Me.lblSalary.TabIndex = 1
        Me.lblSalary.Text = "Salary Calculator"
        '
        'TxtGross
        '
        Me.TxtGross.Location = New System.Drawing.Point(167, 40)
        Me.TxtGross.Name = "TxtGross"
        Me.TxtGross.Size = New System.Drawing.Size(100, 22)
        Me.TxtGross.TabIndex = 2
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(73, 87)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(71, 16)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax Value:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(73, 131)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(73, 16)
        Me.lblNet.TabIndex = 4
        Me.lblNet.Text = "Net Salary:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(73, 46)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(88, 16)
        Me.lblGross.TabIndex = 5
        Me.lblGross.Text = "Gross Salary:"
        '
        'TxtNet
        '
        Me.TxtNet.Location = New System.Drawing.Point(167, 131)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(100, 22)
        Me.TxtNet.TabIndex = 6
        '
        'TxtTax
        '
        Me.TxtTax.Location = New System.Drawing.Point(167, 81)
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(100, 22)
        Me.TxtTax.TabIndex = 7
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 207)
        Me.Controls.Add(Me.TxtTax)
        Me.Controls.Add(Me.TxtNet)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.TxtGross)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmSalary"
        Me.Text = "Salary Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSalary As Label
    Friend WithEvents TxtGross As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents TxtNet As TextBox
    Friend WithEvents TxtTax As TextBox
End Class
