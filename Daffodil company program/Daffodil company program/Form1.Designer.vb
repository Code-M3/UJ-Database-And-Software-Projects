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
        Me.btnIni = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grdBulb = New UJGrid.UJGrid()
        Me.TxtBSB = New System.Windows.Forms.TextBox()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.BtnTA = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIni
        '
        Me.btnIni.Location = New System.Drawing.Point(12, 12)
        Me.btnIni.Name = "btnIni"
        Me.btnIni.Size = New System.Drawing.Size(107, 23)
        Me.btnIni.TabIndex = 0
        Me.btnIni.Text = "Initialize"
        Me.btnIni.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(12, 394)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 16)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Best selling bulb at best selling school:"
        '
        'grdBulb
        '
        Me.grdBulb.FixedCols = 1
        Me.grdBulb.FixedRows = 1
        Me.grdBulb.Location = New System.Drawing.Point(16, 71)
        Me.grdBulb.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBulb.Name = "grdBulb"
        Me.grdBulb.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdBulb.Size = New System.Drawing.Size(1328, 268)
        Me.grdBulb.TabIndex = 2
        '
        'TxtBSB
        '
        Me.TxtBSB.Location = New System.Drawing.Point(254, 391)
        Me.TxtBSB.Name = "TxtBSB"
        Me.TxtBSB.Size = New System.Drawing.Size(709, 22)
        Me.TxtBSB.TabIndex = 3
        '
        'btnBest
        '
        Me.btnBest.Location = New System.Drawing.Point(16, 346)
        Me.btnBest.Name = "btnBest"
        Me.btnBest.Size = New System.Drawing.Size(75, 33)
        Me.btnBest.TabIndex = 4
        Me.btnBest.Text = "Best"
        Me.btnBest.UseVisualStyleBackColor = True
        '
        'BtnTA
        '
        Me.BtnTA.Location = New System.Drawing.Point(1351, 305)
        Me.BtnTA.Name = "BtnTA"
        Me.BtnTA.Size = New System.Drawing.Size(75, 34)
        Me.BtnTA.TabIndex = 5
        Me.BtnTA.Text = "Total"
        Me.BtnTA.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 41)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(107, 23)
        Me.btnRead.TabIndex = 6
        Me.btnRead.Text = "Read in"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 419)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.BtnTA)
        Me.Controls.Add(Me.btnBest)
        Me.Controls.Add(Me.TxtBSB)
        Me.Controls.Add(Me.grdBulb)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnIni)
        Me.Name = "Form1"
        Me.Text = "frmDaf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIni As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents grdBulb As UJGrid.UJGrid
    Friend WithEvents TxtBSB As TextBox
    Friend WithEvents btnBest As Button
    Friend WithEvents BtnTA As Button
    Friend WithEvents btnRead As Button
End Class
