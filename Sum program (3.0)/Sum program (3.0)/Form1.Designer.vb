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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.lblprogram = New System.Windows.Forms.Label()
        Me.TxtSum = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(63, 42)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(147, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lblprogram
        '
        Me.lblprogram.AutoSize = True
        Me.lblprogram.Location = New System.Drawing.Point(12, 9)
        Me.lblprogram.Name = "lblprogram"
        Me.lblprogram.Size = New System.Drawing.Size(88, 16)
        Me.lblprogram.TabIndex = 1
        Me.lblprogram.Text = "Sum program"
        '
        'TxtSum
        '
        Me.TxtSum.Location = New System.Drawing.Point(110, 71)
        Me.TxtSum.Name = "TxtSum"
        Me.TxtSum.Size = New System.Drawing.Size(100, 22)
        Me.TxtSum.TabIndex = 2
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(60, 77)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(44, 16)
        Me.lblSum.TabIndex = 3
        Me.lblSum.Text = "Sum ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 130)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.TxtSum)
        Me.Controls.Add(Me.lblprogram)
        Me.Controls.Add(Me.btnRun)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRun As Button
    Friend WithEvents lblprogram As Label
    Friend WithEvents TxtSum As TextBox
    Friend WithEvents lblSum As Label
End Class
