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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdGym = New UJGrid.UJGrid()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(683, 13)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(105, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Number of member:"
        '
        'grdGym
        '
        Me.grdGym.FixedCols = 1
        Me.grdGym.FixedRows = 1
        Me.grdGym.Location = New System.Drawing.Point(13, 71)
        Me.grdGym.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGym.Name = "grdGym"
        Me.grdGym.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdGym.Size = New System.Drawing.Size(663, 367)
        Me.grdGym.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(153, 7)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(100, 22)
        Me.TxtName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of activities:"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(153, 35)
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumber.TabIndex = 5
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(683, 100)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(105, 23)
        Me.btnMax.TabIndex = 6
        Me.btnMax.Text = "Best"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(683, 71)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(105, 23)
        Me.btnTA.TabIndex = 7
        Me.btnTA.Text = "Calculate"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(683, 42)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(105, 23)
        Me.btnInput.TabIndex = 8
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnTA)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.TxtNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.grdGym)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grdGym As UJGrid.UJGrid
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents btnMax As Button
    Friend WithEvents btnTA As Button
    Friend WithEvents btnInput As Button
End Class
