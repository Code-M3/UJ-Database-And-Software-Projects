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
        Me.btnCattle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnWeight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCattle
        '
        Me.btnCattle.Location = New System.Drawing.Point(62, 53)
        Me.btnCattle.Name = "btnCattle"
        Me.btnCattle.Size = New System.Drawing.Size(84, 23)
        Me.btnCattle.TabIndex = 0
        Me.btnCattle.Text = "Input Cattle"
        Me.btnCattle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bullybeef cattle counter"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(174, 130)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 2
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(59, 133)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(103, 16)
        Me.lblAve.TabIndex = 3
        Me.lblAve.Text = "Average weight:"
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(62, 91)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(212, 23)
        Me.btnCal.TabIndex = 4
        Me.btnCal.Text = "Calculate average"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnWeight
        '
        Me.btnWeight.Location = New System.Drawing.Point(188, 53)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.Size = New System.Drawing.Size(86, 23)
        Me.btnWeight.TabIndex = 5
        Me.btnWeight.Text = "Input Weight"
        Me.btnWeight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 200)
        Me.Controls.Add(Me.btnWeight)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCattle)
        Me.Name = "Form1"
        Me.Text = "Bullybeef program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCattle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents lblAve As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnWeight As Button
End Class
