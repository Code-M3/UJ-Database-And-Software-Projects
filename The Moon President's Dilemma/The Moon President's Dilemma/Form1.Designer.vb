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
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lblMoon = New System.Windows.Forms.Label()
        Me.TxtMonth = New System.Windows.Forms.TextBox()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.lblDi = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblProivnce = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grdMoon = New UJGrid.UJGrid()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtProvince = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(99, 139)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(472, 23)
        Me.btnRead.TabIndex = 0
        Me.btnRead.Text = "Read in data"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lblMoon
        '
        Me.lblMoon.AutoSize = True
        Me.lblMoon.Location = New System.Drawing.Point(12, 9)
        Me.lblMoon.Name = "lblMoon"
        Me.lblMoon.Size = New System.Drawing.Size(160, 16)
        Me.lblMoon.TabIndex = 1
        Me.lblMoon.Text = "Moon Immigrations Office "
        '
        'TxtMonth
        '
        Me.TxtMonth.Location = New System.Drawing.Point(99, 89)
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.Size = New System.Drawing.Size(73, 22)
        Me.TxtMonth.TabIndex = 2
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(19, 245)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(41, 16)
        Me.lblRows.TabIndex = 3
        Me.lblRows.Text = "Rows"
        '
        'lblDi
        '
        Me.lblDi.AutoSize = True
        Me.lblDi.Location = New System.Drawing.Point(243, 194)
        Me.lblDi.Name = "lblDi"
        Me.lblDi.Size = New System.Drawing.Size(60, 16)
        Me.lblDi.TabIndex = 4
        Me.lblDi.Text = "Coloums"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(513, 54)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(58, 16)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Number:"
        '
        'lblProivnce
        '
        Me.lblProivnce.AutoSize = True
        Me.lblProivnce.Location = New System.Drawing.Point(299, 54)
        Me.lblProivnce.Name = "lblProivnce"
        Me.lblProivnce.Size = New System.Drawing.Size(63, 16)
        Me.lblProivnce.TabIndex = 6
        Me.lblProivnce.Text = "Proivnce:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(111, 54)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(46, 16)
        Me.lblMonth.TabIndex = 7
        Me.lblMonth.Text = "Month:"
        '
        'grdMoon
        '
        Me.grdMoon.FixedCols = 1
        Me.grdMoon.FixedRows = 1
        Me.grdMoon.Location = New System.Drawing.Point(67, 214)
        Me.grdMoon.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMoon.Name = "grdMoon"
        Me.grdMoon.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMoon.Size = New System.Drawing.Size(543, 185)
        Me.grdMoon.TabIndex = 8
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(499, 89)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(72, 22)
        Me.TxtNumber.TabIndex = 9
        '
        'TxtProvince
        '
        Me.TxtProvince.Location = New System.Drawing.Point(280, 89)
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.Size = New System.Drawing.Size(106, 22)
        Me.TxtProvince.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 450)
        Me.Controls.Add(Me.TxtProvince)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.grdMoon)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblProivnce)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblDi)
        Me.Controls.Add(Me.lblRows)
        Me.Controls.Add(Me.TxtMonth)
        Me.Controls.Add(Me.lblMoon)
        Me.Controls.Add(Me.btnRead)
        Me.Name = "Form1"
        Me.Text = "Moon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRead As Button
    Friend WithEvents lblMoon As Label
    Friend WithEvents TxtMonth As TextBox
    Friend WithEvents lblRows As Label
    Friend WithEvents lblDi As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblProivnce As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents grdMoon As UJGrid.UJGrid
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtProvince As TextBox
End Class
