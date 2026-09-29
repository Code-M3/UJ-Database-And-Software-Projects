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
        Me.BtnRegion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRegion = New System.Windows.Forms.TextBox()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.lblvotes = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRegion
        '
        Me.BtnRegion.Location = New System.Drawing.Point(315, 41)
        Me.BtnRegion.Name = "BtnRegion"
        Me.BtnRegion.Size = New System.Drawing.Size(108, 23)
        Me.BtnRegion.TabIndex = 0
        Me.BtnRegion.Text = "Input region"
        Me.BtnRegion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mars election program"
        '
        'TxtRegion
        '
        Me.TxtRegion.Location = New System.Drawing.Point(195, 38)
        Me.TxtRegion.Name = "TxtRegion"
        Me.TxtRegion.Size = New System.Drawing.Size(100, 22)
        Me.TxtRegion.TabIndex = 2
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(75, 161)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(98, 16)
        Me.lblAve.TabIndex = 3
        Me.lblAve.Text = "Average votes:"
        '
        'lblvotes
        '
        Me.lblvotes.AutoSize = True
        Me.lblvotes.Location = New System.Drawing.Point(75, 74)
        Me.lblvotes.Name = "lblvotes"
        Me.lblvotes.Size = New System.Drawing.Size(108, 16)
        Me.lblvotes.TabIndex = 4
        Me.lblvotes.Text = "Number of votes:"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(75, 41)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(54, 16)
        Me.lblRegion.TabIndex = 5
        Me.lblRegion.Text = "Region:"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(195, 74)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 6
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(195, 155)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(78, 113)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(345, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(315, 71)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(108, 23)
        Me.btnNumber.TabIndex = 9
        Me.btnNumber.Text = "Input number"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 209)
        Me.Controls.Add(Me.btnNumber)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblvotes)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.TxtRegion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegion)
        Me.Name = "Form1"
        Me.Text = "Election Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegion As TextBox
    Friend WithEvents lblAve As Label
    Friend WithEvents lblvotes As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNumber As Button
End Class
