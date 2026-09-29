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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtDays = New System.Windows.Forms.TextBox()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.TxtTotPages = New System.Windows.Forms.TextBox()
        Me.lblTotPages = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDays
        '
        Me.btnDays.Location = New System.Drawing.Point(373, 27)
        Me.btnDays.Name = "btnDays"
        Me.btnDays.Size = New System.Drawing.Size(107, 23)
        Me.btnDays.TabIndex = 0
        Me.btnDays.Text = "Input Days"
        Me.btnDays.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Metropolitan Records"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(466, 446)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TxtDays
        '
        Me.TxtDays.Location = New System.Drawing.Point(248, 28)
        Me.TxtDays.Name = "TxtDays"
        Me.TxtDays.Size = New System.Drawing.Size(100, 22)
        Me.TxtDays.TabIndex = 3
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(73, 182)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(270, 16)
        Me.lblAve.TabIndex = 4
        Me.lblAve.Text = "Average number of pages scanned per day:"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(73, 35)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(105, 16)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Number of days:"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(349, 176)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(131, 22)
        Me.TxtAve.TabIndex = 7
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(76, 138)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(404, 23)
        Me.btnCal.TabIndex = 9
        Me.btnCal.Text = "Calculate average"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(373, 84)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(107, 29)
        Me.btnTotal.TabIndex = 10
        Me.btnTotal.Text = "Calculate total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'TxtTotPages
        '
        Me.TxtTotPages.Location = New System.Drawing.Point(248, 85)
        Me.TxtTotPages.Name = "TxtTotPages"
        Me.TxtTotPages.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotPages.TabIndex = 8
        '
        'lblTotPages
        '
        Me.lblTotPages.AutoSize = True
        Me.lblTotPages.Location = New System.Drawing.Point(73, 91)
        Me.lblTotPages.Name = "lblTotPages"
        Me.lblTotPages.Size = New System.Drawing.Size(145, 16)
        Me.lblTotPages.TabIndex = 5
        Me.lblTotPages.Text = "Total number of pages:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 246)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.TxtTotPages)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblTotPages)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.TxtDays)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnDays)
        Me.Name = "Form1"
        Me.Text = "Metropolitan program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDays As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtDays As TextBox
    Friend WithEvents lblAve As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents btnCal As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents TxtTotPages As TextBox
    Friend WithEvents lblTotPages As Label
End Class
