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
        Me.lblBullybeef = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.btnCattle = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnWeight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBullybeef
        '
        Me.lblBullybeef.AutoSize = True
        Me.lblBullybeef.Location = New System.Drawing.Point(12, 9)
        Me.lblBullybeef.Name = "lblBullybeef"
        Me.lblBullybeef.Size = New System.Drawing.Size(188, 16)
        Me.lblBullybeef.TabIndex = 0
        Me.lblBullybeef.Text = "Farmer Bullybeef Cattle Ranch"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(156, 44)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 1
        '
        'btnCattle
        '
        Me.btnCattle.Location = New System.Drawing.Point(296, 33)
        Me.btnCattle.Name = "btnCattle"
        Me.btnCattle.Size = New System.Drawing.Size(125, 37)
        Me.btnCattle.TabIndex = 2
        Me.btnCattle.Text = "Input cattle"
        Me.btnCattle.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(43, 176)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(103, 16)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average weight:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(43, 83)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 16)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Weight:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(43, 47)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(107, 16)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Number of cattle:"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(156, 176)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 6
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(156, 77)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(100, 22)
        Me.TxtWeight.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(46, 126)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(375, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnWeight
        '
        Me.btnWeight.Location = New System.Drawing.Point(296, 76)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.Size = New System.Drawing.Size(125, 33)
        Me.btnWeight.TabIndex = 9
        Me.btnWeight.Text = "Input weight"
        Me.btnWeight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 239)
        Me.Controls.Add(Me.btnWeight)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnCattle)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.lblBullybeef)
        Me.Name = "Form1"
        Me.Text = "The Bullybeef program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBullybeef As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCattle As Button
    Friend WithEvents btnWeight As Button
End Class
