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
        Me.btnSet = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grdisplay = New UJGrid.UJGrid()
        Me.TxtNumfarmer = New System.Windows.Forms.TextBox()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lblAve = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(650, 12)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(148, 23)
        Me.btnSet.TabIndex = 0
        Me.btnSet.Text = "Setup"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Number of farmers:"
        '
        'grdisplay
        '
        Me.grdisplay.FixedCols = 1
        Me.grdisplay.FixedRows = 1
        Me.grdisplay.Location = New System.Drawing.Point(15, 38)
        Me.grdisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grdisplay.Name = "grdisplay"
        Me.grdisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdisplay.Size = New System.Drawing.Size(613, 280)
        Me.grdisplay.TabIndex = 2
        '
        'TxtNumfarmer
        '
        Me.TxtNumfarmer.Location = New System.Drawing.Point(138, 6)
        Me.TxtNumfarmer.Name = "TxtNumfarmer"
        Me.TxtNumfarmer.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumfarmer.TabIndex = 3
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(650, 70)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(147, 23)
        Me.btnTA.TabIndex = 4
        Me.btnTA.Text = "Totals and Averages"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(650, 41)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(148, 23)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lblAve
        '
        Me.lblAve.AutoSize = True
        Me.lblAve.Location = New System.Drawing.Point(647, 202)
        Me.lblAve.Name = "lblAve"
        Me.lblAve.Size = New System.Drawing.Size(62, 16)
        Me.lblAve.TabIndex = 6
        Me.lblAve.Text = "Average:"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.Location = New System.Drawing.Point(647, 142)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(41, 16)
        Me.lblTot.TabIndex = 7
        Me.lblTot.Text = "Total:"
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(650, 221)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 8
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(649, 161)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 368)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblAve)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnTA)
        Me.Controls.Add(Me.TxtNumfarmer)
        Me.Controls.Add(Me.grdisplay)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSet)
        Me.Name = "Form1"
        Me.Text = "Mars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSet As Button
    Friend WithEvents lblName As Label
    Friend WithEvents grdisplay As UJGrid.UJGrid
    Friend WithEvents TxtNumfarmer As TextBox
    Friend WithEvents btnTA As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents lblAve As Label
    Friend WithEvents lblTot As Label
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents TxtTotal As TextBox
End Class
