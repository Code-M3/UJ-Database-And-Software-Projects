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
        Me.btnInit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdMars = New UJGrid.UJGrid()
        Me.TxtFarmers = New System.Windows.Forms.TextBox()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(704, 12)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(84, 23)
        Me.btnInit.TabIndex = 0
        Me.btnInit.Text = "Initialise"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of farmer:"
        '
        'grdMars
        '
        Me.grdMars.FixedCols = 1
        Me.grdMars.FixedRows = 1
        Me.grdMars.Location = New System.Drawing.Point(13, 35)
        Me.grdMars.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMars.Name = "grdMars"
        Me.grdMars.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMars.Size = New System.Drawing.Size(665, 402)
        Me.grdMars.TabIndex = 2
        '
        'TxtFarmers
        '
        Me.TxtFarmers.Location = New System.Drawing.Point(136, 6)
        Me.TxtFarmers.Name = "TxtFarmers"
        Me.TxtFarmers.Size = New System.Drawing.Size(100, 22)
        Me.TxtFarmers.TabIndex = 3
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(704, 70)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(84, 23)
        Me.btnTA.TabIndex = 4
        Me.btnTA.Text = "Calculate"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(704, 41)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(84, 23)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read in"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnTA)
        Me.Controls.Add(Me.TxtFarmers)
        Me.Controls.Add(Me.grdMars)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grdMars As UJGrid.UJGrid
    Friend WithEvents TxtFarmers As TextBox
    Friend WithEvents btnTA As Button
    Friend WithEvents btnRead As Button
End Class
