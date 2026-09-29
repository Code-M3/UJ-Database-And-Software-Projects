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
        Me.lblFarmer = New System.Windows.Forms.Label()
        Me.grdMars = New UJGrid.UJGrid()
        Me.TxtFarmer = New System.Windows.Forms.TextBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.TxtPeriod = New System.Windows.Forms.TextBox()
        Me.btnExtra = New System.Windows.Forms.Button()
        Me.btnFarmer = New System.Windows.Forms.Button()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.TxtMinFarmer = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(816, 12)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(133, 23)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblFarmer
        '
        Me.lblFarmer.AutoSize = True
        Me.lblFarmer.Location = New System.Drawing.Point(12, 19)
        Me.lblFarmer.Name = "lblFarmer"
        Me.lblFarmer.Size = New System.Drawing.Size(113, 16)
        Me.lblFarmer.TabIndex = 1
        Me.lblFarmer.Text = "Number of farmer:"
        '
        'grdMars
        '
        Me.grdMars.FixedCols = 1
        Me.grdMars.FixedRows = 1
        Me.grdMars.Location = New System.Drawing.Point(15, 103)
        Me.grdMars.Margin = New System.Windows.Forms.Padding(4)
        Me.grdMars.Name = "grdMars"
        Me.grdMars.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMars.Size = New System.Drawing.Size(794, 334)
        Me.grdMars.TabIndex = 2
        '
        'TxtFarmer
        '
        Me.TxtFarmer.Location = New System.Drawing.Point(131, 16)
        Me.TxtFarmer.Name = "TxtFarmer"
        Me.TxtFarmer.Size = New System.Drawing.Size(100, 22)
        Me.TxtFarmer.TabIndex = 3
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(12, 60)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(114, 16)
        Me.lblPeriod.TabIndex = 4
        Me.lblPeriod.Text = "Number of period:"
        '
        'TxtPeriod
        '
        Me.TxtPeriod.Location = New System.Drawing.Point(131, 54)
        Me.TxtPeriod.Name = "TxtPeriod"
        Me.TxtPeriod.Size = New System.Drawing.Size(100, 22)
        Me.TxtPeriod.TabIndex = 5
        '
        'btnExtra
        '
        Me.btnExtra.Location = New System.Drawing.Point(816, 167)
        Me.btnExtra.Name = "btnExtra"
        Me.btnExtra.Size = New System.Drawing.Size(133, 23)
        Me.btnExtra.TabIndex = 7
        Me.btnExtra.Text = "Extra workers"
        Me.btnExtra.UseVisualStyleBackColor = True
        '
        'btnFarmer
        '
        Me.btnFarmer.Location = New System.Drawing.Point(816, 99)
        Me.btnFarmer.Name = "btnFarmer"
        Me.btnFarmer.Size = New System.Drawing.Size(133, 23)
        Me.btnFarmer.TabIndex = 8
        Me.btnFarmer.Text = "Farmer with min"
        Me.btnFarmer.UseVisualStyleBackColor = True
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(816, 70)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(133, 23)
        Me.btnTA.TabIndex = 9
        Me.btnTA.Text = "Total & Average"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(816, 41)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(133, 23)
        Me.btnInput.TabIndex = 10
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'TxtMinFarmer
        '
        Me.TxtMinFarmer.Location = New System.Drawing.Point(816, 139)
        Me.TxtMinFarmer.Name = "TxtMinFarmer"
        Me.TxtMinFarmer.Size = New System.Drawing.Size(133, 22)
        Me.TxtMinFarmer.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.TxtMinFarmer)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnTA)
        Me.Controls.Add(Me.btnFarmer)
        Me.Controls.Add(Me.btnExtra)
        Me.Controls.Add(Me.TxtPeriod)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.TxtFarmer)
        Me.Controls.Add(Me.grdMars)
        Me.Controls.Add(Me.lblFarmer)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents lblFarmer As Label
    Friend WithEvents grdMars As UJGrid.UJGrid
    Friend WithEvents TxtFarmer As TextBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents TxtPeriod As TextBox
    Friend WithEvents btnExtra As Button
    Friend WithEvents btnFarmer As Button
    Friend WithEvents btnTA As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents TxtMinFarmer As TextBox
End Class
