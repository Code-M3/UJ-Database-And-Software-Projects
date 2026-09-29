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
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtShifts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.TxtTot = New System.Windows.Forms.TextBox()
        Me.btnAve = New System.Windows.Forms.Button()
        Me.btnTot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(326, 9)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(100, 23)
        Me.btnInsert.TabIndex = 0
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of shifts:"
        '
        'TxtShifts
        '
        Me.TxtShifts.Location = New System.Drawing.Point(124, 6)
        Me.TxtShifts.Name = "TxtShifts"
        Me.TxtShifts.Size = New System.Drawing.Size(100, 22)
        Me.TxtShifts.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Average number of qualities per shift:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total number of qualities:"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(326, 146)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 5
        '
        'TxtTot
        '
        Me.TxtTot.Location = New System.Drawing.Point(36, 146)
        Me.TxtTot.Name = "TxtTot"
        Me.TxtTot.Size = New System.Drawing.Size(100, 22)
        Me.TxtTot.TabIndex = 6
        '
        'btnAve
        '
        Me.btnAve.Location = New System.Drawing.Point(287, 70)
        Me.btnAve.Name = "btnAve"
        Me.btnAve.Size = New System.Drawing.Size(139, 23)
        Me.btnAve.TabIndex = 7
        Me.btnAve.Text = "Calculate average"
        Me.btnAve.UseVisualStyleBackColor = True
        '
        'btnTot
        '
        Me.btnTot.Location = New System.Drawing.Point(15, 70)
        Me.btnTot.Name = "btnTot"
        Me.btnTot.Size = New System.Drawing.Size(172, 23)
        Me.btnTot.TabIndex = 8
        Me.btnTot.Text = "Calculate total"
        Me.btnTot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 212)
        Me.Controls.Add(Me.btnTot)
        Me.Controls.Add(Me.btnAve)
        Me.Controls.Add(Me.TxtTot)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtShifts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "Form1"
        Me.Text = "FrmLab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtShifts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents TxtTot As TextBox
    Friend WithEvents btnAve As Button
    Friend WithEvents btnTot As Button
End Class
