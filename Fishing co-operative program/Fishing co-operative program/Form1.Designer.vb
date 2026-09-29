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
        Me.btnDays = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.TxtNumDay = New System.Windows.Forms.TextBox()
        Me.lblAveSales = New System.Windows.Forms.Label()
        Me.lblTotSales = New System.Windows.Forms.Label()
        Me.TxtAveSales = New System.Windows.Forms.TextBox()
        Me.TxtTotSales = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDays
        '
        Me.btnDays.Location = New System.Drawing.Point(376, 22)
        Me.btnDays.Name = "btnDays"
        Me.btnDays.Size = New System.Drawing.Size(94, 33)
        Me.btnDays.TabIndex = 0
        Me.btnDays.Text = "Input days"
        Me.btnDays.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(38, 36)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(105, 16)
        Me.lblNumber.TabIndex = 1
        Me.lblNumber.Text = "Number of days:"
        '
        'TxtNumDay
        '
        Me.TxtNumDay.Location = New System.Drawing.Point(149, 33)
        Me.TxtNumDay.Name = "TxtNumDay"
        Me.TxtNumDay.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumDay.TabIndex = 2
        '
        'lblAveSales
        '
        Me.lblAveSales.AutoSize = True
        Me.lblAveSales.Location = New System.Drawing.Point(291, 179)
        Me.lblAveSales.Name = "lblAveSales"
        Me.lblAveSales.Size = New System.Drawing.Size(98, 16)
        Me.lblAveSales.TabIndex = 3
        Me.lblAveSales.Text = "Average sales:"
        '
        'lblTotSales
        '
        Me.lblTotSales.AutoSize = True
        Me.lblTotSales.Location = New System.Drawing.Point(40, 179)
        Me.lblTotSales.Name = "lblTotSales"
        Me.lblTotSales.Size = New System.Drawing.Size(77, 16)
        Me.lblTotSales.TabIndex = 4
        Me.lblTotSales.Text = "Total sales:"
        '
        'TxtAveSales
        '
        Me.TxtAveSales.Location = New System.Drawing.Point(395, 173)
        Me.TxtAveSales.Name = "TxtAveSales"
        Me.TxtAveSales.Size = New System.Drawing.Size(100, 22)
        Me.TxtAveSales.TabIndex = 5
        '
        'TxtTotSales
        '
        Me.TxtTotSales.Location = New System.Drawing.Point(123, 176)
        Me.TxtTotSales.Name = "TxtTotSales"
        Me.TxtTotSales.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotSales.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(43, 121)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(471, 31)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate "
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(43, 71)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(471, 31)
        Me.btnSales.TabIndex = 8
        Me.btnSales.Text = "Input sales amount"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 254)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TxtTotSales)
        Me.Controls.Add(Me.TxtAveSales)
        Me.Controls.Add(Me.lblTotSales)
        Me.Controls.Add(Me.lblAveSales)
        Me.Controls.Add(Me.TxtNumDay)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnDays)
        Me.Name = "Form1"
        Me.Text = "Fishing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDays As Button
    Friend WithEvents lblNumber As Label
    Friend WithEvents TxtNumDay As TextBox
    Friend WithEvents lblAveSales As Label
    Friend WithEvents lblTotSales As Label
    Friend WithEvents TxtAveSales As TextBox
    Friend WithEvents TxtTotSales As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSales As Button
End Class
