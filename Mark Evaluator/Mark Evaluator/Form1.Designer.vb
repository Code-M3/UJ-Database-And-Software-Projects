<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMark
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
        Me.btnDete = New System.Windows.Forms.Button()
        Me.lblEvaluator = New System.Windows.Forms.Label()
        Me.TxtMark = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDete
        '
        Me.btnDete.Location = New System.Drawing.Point(294, 36)
        Me.btnDete.Name = "btnDete"
        Me.btnDete.Size = New System.Drawing.Size(75, 23)
        Me.btnDete.TabIndex = 0
        Me.btnDete.Text = "Determine"
        Me.btnDete.UseVisualStyleBackColor = True
        '
        'lblEvaluator
        '
        Me.lblEvaluator.AutoSize = True
        Me.lblEvaluator.Location = New System.Drawing.Point(12, 9)
        Me.lblEvaluator.Name = "lblEvaluator"
        Me.lblEvaluator.Size = New System.Drawing.Size(97, 16)
        Me.lblEvaluator.TabIndex = 1
        Me.lblEvaluator.Text = "Mark Evaluator"
        '
        'TxtMark
        '
        Me.TxtMark.Location = New System.Drawing.Point(150, 37)
        Me.TxtMark.Name = "TxtMark"
        Me.TxtMark.Size = New System.Drawing.Size(100, 22)
        Me.TxtMark.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(84, 87)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 16)
        Me.lblStatus.TabIndex = 3
        Me.lblStatus.Text = "Status:"
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(84, 43)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(40, 16)
        Me.lblMark.TabIndex = 4
        Me.lblMark.Text = "Mark:"
        '
        'TxtStatus
        '
        Me.TxtStatus.Location = New System.Drawing.Point(150, 87)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(100, 22)
        Me.TxtStatus.TabIndex = 5
        '
        'frmMark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 148)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.TxtMark)
        Me.Controls.Add(Me.lblEvaluator)
        Me.Controls.Add(Me.btnDete)
        Me.Name = "frmMark"
        Me.Text = "Marking program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDete As Button
    Friend WithEvents lblEvaluator As Label
    Friend WithEvents TxtMark As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblMark As Label
    Friend WithEvents TxtStatus As TextBox
End Class
