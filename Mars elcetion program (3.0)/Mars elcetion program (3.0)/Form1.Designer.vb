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
        Me.btnRegion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRegion = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.TxtVotes = New System.Windows.Forms.TextBox()
        Me.btnAve = New System.Windows.Forms.Button()
        Me.btnVotes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegion
        '
        Me.btnRegion.Location = New System.Drawing.Point(326, 40)
        Me.btnRegion.Name = "btnRegion"
        Me.btnRegion.Size = New System.Drawing.Size(97, 23)
        Me.btnRegion.TabIndex = 0
        Me.btnRegion.Text = "input region"
        Me.btnRegion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vote counter"
        '
        'TxtRegion
        '
        Me.TxtRegion.Location = New System.Drawing.Point(204, 41)
        Me.TxtRegion.Name = "TxtRegion"
        Me.TxtRegion.Size = New System.Drawing.Size(100, 22)
        Me.TxtRegion.TabIndex = 2
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(88, 163)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(98, 16)
        Me.lblAverage.TabIndex = 3
        Me.lblAverage.Text = "Average votes:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(88, 90)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(108, 16)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Number of votes:"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(88, 47)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(54, 16)
        Me.lblRegion.TabIndex = 5
        Me.lblRegion.Text = "Region:"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(204, 157)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 7
        '
        'TxtVotes
        '
        Me.TxtVotes.Location = New System.Drawing.Point(204, 87)
        Me.TxtVotes.Name = "TxtVotes"
        Me.TxtVotes.Size = New System.Drawing.Size(100, 22)
        Me.TxtVotes.TabIndex = 8
        '
        'btnAve
        '
        Me.btnAve.Location = New System.Drawing.Point(91, 123)
        Me.btnAve.Name = "btnAve"
        Me.btnAve.Size = New System.Drawing.Size(332, 23)
        Me.btnAve.TabIndex = 9
        Me.btnAve.Text = "Calculate average"
        Me.btnAve.UseVisualStyleBackColor = True
        '
        'btnVotes
        '
        Me.btnVotes.Location = New System.Drawing.Point(326, 83)
        Me.btnVotes.Name = "btnVotes"
        Me.btnVotes.Size = New System.Drawing.Size(97, 23)
        Me.btnVotes.TabIndex = 10
        Me.btnVotes.Text = "Input votes"
        Me.btnVotes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 223)
        Me.Controls.Add(Me.btnVotes)
        Me.Controls.Add(Me.btnAve)
        Me.Controls.Add(Me.TxtVotes)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.TxtRegion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegion)
        Me.Name = "Form1"
        Me.Text = "The election program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRegion As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents TxtVotes As TextBox
    Friend WithEvents btnAve As Button
    Friend WithEvents btnVotes As Button
End Class
