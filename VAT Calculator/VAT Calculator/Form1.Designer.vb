<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVAT
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
        Me.lblCalculating = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TxtVat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(321, 56)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 68)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCalculating
        '
        Me.lblCalculating.AutoSize = True
        Me.lblCalculating.Location = New System.Drawing.Point(12, 9)
        Me.lblCalculating.Name = "lblCalculating"
        Me.lblCalculating.Size = New System.Drawing.Size(103, 16)
        Me.lblCalculating.TabIndex = 1
        Me.lblCalculating.Text = "Calculating VAT"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(166, 50)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtPrice.TabIndex = 2
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Location = New System.Drawing.Point(78, 108)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(37, 16)
        Me.lblVat.TabIndex = 3
        Me.lblVat.Text = "VAT:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(78, 56)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(41, 16)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Price:"
        '
        'TxtVat
        '
        Me.TxtVat.Location = New System.Drawing.Point(166, 112)
        Me.TxtVat.Name = "TxtVat"
        Me.TxtVat.Size = New System.Drawing.Size(100, 22)
        Me.TxtVat.TabIndex = 5
        '
        'frmVAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 176)
        Me.Controls.Add(Me.TxtVat)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.lblCalculating)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmVAT"
        Me.Text = "Calculator Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCalculating As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents lblVat As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents TxtVat As TextBox
End Class
