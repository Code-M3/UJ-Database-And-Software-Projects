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
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblCal = New System.Windows.Forms.Label()
        Me.TxtOriginalPrice = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.lblTotVat = New System.Windows.Forms.Label()
        Me.lblVatAmount = New System.Windows.Forms.Label()
        Me.lblOriginalPrice = New System.Windows.Forms.Label()
        Me.TxtFinalPrice = New System.Windows.Forms.TextBox()
        Me.TxtTotVat = New System.Windows.Forms.TextBox()
        Me.TxtVatAmount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(365, 48)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(86, 53)
        Me.btnCal.TabIndex = 0
        Me.btnCal.Text = "Calculate"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblCal
        '
        Me.lblCal.AutoSize = True
        Me.lblCal.Location = New System.Drawing.Point(12, 9)
        Me.lblCal.Name = "lblCal"
        Me.lblCal.Size = New System.Drawing.Size(99, 16)
        Me.lblCal.TabIndex = 1
        Me.lblCal.Text = "Price calculator"
        '
        'TxtOriginalPrice
        '
        Me.TxtOriginalPrice.Location = New System.Drawing.Point(199, 48)
        Me.TxtOriginalPrice.Name = "TxtOriginalPrice"
        Me.TxtOriginalPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtOriginalPrice.TabIndex = 2
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Location = New System.Drawing.Point(86, 163)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(73, 16)
        Me.lblFinalPrice.TabIndex = 4
        Me.lblFinalPrice.Text = "Final Price:"
        '
        'lblTotVat
        '
        Me.lblTotVat.AutoSize = True
        Me.lblTotVat.Location = New System.Drawing.Point(86, 123)
        Me.lblTotVat.Name = "lblTotVat"
        Me.lblTotVat.Size = New System.Drawing.Size(71, 16)
        Me.lblTotVat.TabIndex = 5
        Me.lblTotVat.Text = "Total VAT:"
        '
        'lblVatAmount
        '
        Me.lblVatAmount.AutoSize = True
        Me.lblVatAmount.Location = New System.Drawing.Point(86, 85)
        Me.lblVatAmount.Name = "lblVatAmount"
        Me.lblVatAmount.Size = New System.Drawing.Size(84, 16)
        Me.lblVatAmount.TabIndex = 6
        Me.lblVatAmount.Text = "VAT amount:"
        '
        'lblOriginalPrice
        '
        Me.lblOriginalPrice.AutoSize = True
        Me.lblOriginalPrice.Location = New System.Drawing.Point(86, 47)
        Me.lblOriginalPrice.Name = "lblOriginalPrice"
        Me.lblOriginalPrice.Size = New System.Drawing.Size(90, 16)
        Me.lblOriginalPrice.TabIndex = 7
        Me.lblOriginalPrice.Text = "Original Price:"
        '
        'TxtFinalPrice
        '
        Me.TxtFinalPrice.Location = New System.Drawing.Point(199, 163)
        Me.TxtFinalPrice.Name = "TxtFinalPrice"
        Me.TxtFinalPrice.Size = New System.Drawing.Size(100, 22)
        Me.TxtFinalPrice.TabIndex = 8
        '
        'TxtTotVat
        '
        Me.TxtTotVat.Location = New System.Drawing.Point(199, 123)
        Me.TxtTotVat.Name = "TxtTotVat"
        Me.TxtTotVat.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotVat.TabIndex = 9
        '
        'TxtVatAmount
        '
        Me.TxtVatAmount.Location = New System.Drawing.Point(199, 85)
        Me.TxtVatAmount.Name = "TxtVatAmount"
        Me.TxtVatAmount.Size = New System.Drawing.Size(100, 22)
        Me.TxtVatAmount.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 227)
        Me.Controls.Add(Me.TxtVatAmount)
        Me.Controls.Add(Me.TxtTotVat)
        Me.Controls.Add(Me.TxtFinalPrice)
        Me.Controls.Add(Me.lblOriginalPrice)
        Me.Controls.Add(Me.lblVatAmount)
        Me.Controls.Add(Me.lblTotVat)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.TxtOriginalPrice)
        Me.Controls.Add(Me.lblCal)
        Me.Controls.Add(Me.btnCal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCal As Button
    Friend WithEvents lblCal As Label
    Friend WithEvents TxtOriginalPrice As TextBox
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents lblTotVat As Label
    Friend WithEvents lblVatAmount As Label
    Friend WithEvents lblOriginalPrice As Label
    Friend WithEvents TxtFinalPrice As TextBox
    Friend WithEvents TxtTotVat As TextBox
    Friend WithEvents TxtVatAmount As TextBox
End Class
