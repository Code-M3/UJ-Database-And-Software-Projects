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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdStore = New UJGrid.UJGrid()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.TxtBest = New System.Windows.Forms.TextBox()
        Me.TxtAve = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(12, 11)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 41)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of products:"
        '
        'grdStore
        '
        Me.grdStore.FixedCols = 1
        Me.grdStore.FixedRows = 1
        Me.grdStore.Location = New System.Drawing.Point(119, 41)
        Me.grdStore.Margin = New System.Windows.Forms.Padding(4)
        Me.grdStore.Name = "grdStore"
        Me.grdStore.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdStore.Size = New System.Drawing.Size(668, 396)
        Me.grdStore.TabIndex = 3
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(300, 12)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 4
        '
        'btnBest
        '
        Me.btnBest.Location = New System.Drawing.Point(12, 128)
        Me.btnBest.Name = "btnBest"
        Me.btnBest.Size = New System.Drawing.Size(75, 23)
        Me.btnBest.TabIndex = 5
        Me.btnBest.Text = "Best"
        Me.btnBest.UseVisualStyleBackColor = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(12, 99)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 6
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(12, 70)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 7
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'TxtBest
        '
        Me.TxtBest.Location = New System.Drawing.Point(12, 345)
        Me.TxtBest.Name = "TxtBest"
        Me.TxtBest.Size = New System.Drawing.Size(100, 22)
        Me.TxtBest.TabIndex = 8
        '
        'TxtAve
        '
        Me.TxtAve.Location = New System.Drawing.Point(12, 275)
        Me.TxtAve.Name = "TxtAve"
        Me.TxtAve.Size = New System.Drawing.Size(100, 22)
        Me.TxtAve.TabIndex = 9
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(12, 198)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotal.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Average:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Best:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtAve)
        Me.Controls.Add(Me.TxtBest)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.btnBest)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.grdStore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "FrmStore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grdStore As UJGrid.UJGrid
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents btnBest As Button
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents TxtBest As TextBox
    Friend WithEvents TxtAve As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
