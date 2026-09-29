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
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.lblBullybeef = New System.Windows.Forms.Label()
        Me.txtAve = New System.Windows.Forms.TextBox()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.btnWeights = New System.Windows.Forms.Button()
        Me.btnAve = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(69, 45)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(80, 23)
        Me.btnNumber.TabIndex = 0
        Me.btnNumber.Text = "Input Cattle"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'lblBullybeef
        '
        Me.lblBullybeef.AutoSize = True
        Me.lblBullybeef.Location = New System.Drawing.Point(12, 9)
        Me.lblBullybeef.Name = "lblBullybeef"
        Me.lblBullybeef.Size = New System.Drawing.Size(188, 16)
        Me.lblBullybeef.TabIndex = 1
        Me.lblBullybeef.Text = "Farmer Bullybeef Cattle Ranch"
        '
        'txtAve
        '
        Me.txtAve.Location = New System.Drawing.Point(197, 123)
        Me.txtAve.Name = "txtAve"
        Me.txtAve.Size = New System.Drawing.Size(100, 22)
        Me.txtAve.TabIndex = 2
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(66, 129)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(107, 16)
        Me.lblAve.TabIndex = 3
        Me.lblAve.Text = "Average Weight:"
        '
        'btnWeights
        '
        Me.btnWeights.Location = New System.Drawing.Point(209, 45)
        Me.btnWeights.Name = "btnWeights"
        Me.btnWeights.Size = New System.Drawing.Size(88, 23)
        Me.btnWeights.TabIndex = 4
        Me.btnWeights.Text = "Input Weight"
        Me.btnWeights.UseVisualStyleBackColor = True
        '
        'btnAve
        '
        Me.btnAve.Location = New System.Drawing.Point(69, 85)
        Me.btnAve.Name = "btnAve"
        Me.btnAve.Size = New System.Drawing.Size(228, 23)
        Me.btnAve.TabIndex = 5
        Me.btnAve.Text = "Calculate Average Weight"
        Me.btnAve.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 188)
        Me.Controls.Add(Me.btnAve)
        Me.Controls.Add(Me.btnWeights)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.txtAve)
        Me.Controls.Add(Me.lblBullybeef)
        Me.Controls.Add(Me.btnNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumber As Button
    Friend WithEvents lblBullybeef As Label
    Friend WithEvents txtAve As TextBox
    Friend WithEvents lblAve As Label
    Friend WithEvents btnWeights As Button
    Friend WithEvents btnAve As Button
End Class
