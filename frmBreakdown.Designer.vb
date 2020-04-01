<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBreakdown
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
        Me.lblTotalPerShoe = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblTotalPer = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtTotalPer = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lstDesign = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalPerShoe
        '
        Me.lblTotalPerShoe.AutoSize = True
        Me.lblTotalPerShoe.Location = New System.Drawing.Point(102, 46)
        Me.lblTotalPerShoe.Name = "lblTotalPerShoe"
        Me.lblTotalPerShoe.Size = New System.Drawing.Size(106, 17)
        Me.lblTotalPerShoe.TabIndex = 0
        Me.lblTotalPerShoe.Text = "Price per Shoe:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Location = New System.Drawing.Point(105, 76)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(79, 17)
        Me.lblVat.TabIndex = 1
        Me.lblVat.Text = "Vat @ 23%"
        '
        'lblTotalPer
        '
        Me.lblTotalPer.AutoSize = True
        Me.lblTotalPer.Location = New System.Drawing.Point(102, 108)
        Me.lblTotalPer.Name = "lblTotalPer"
        Me.lblTotalPer.Size = New System.Drawing.Size(103, 17)
        Me.lblTotalPer.TabIndex = 2
        Me.lblTotalPer.Text = "Total Per Shoe"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(102, 141)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(118, 17)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity Ordered"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(105, 174)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(122, 17)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Amount Due"
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Location = New System.Drawing.Point(108, 213)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(52, 17)
        Me.lblDesign.TabIndex = 5
        Me.lblDesign.Text = "Design"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(266, 43)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(184, 22)
        Me.txtPrice.TabIndex = 6
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(266, 76)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(184, 22)
        Me.txtVat.TabIndex = 7
        '
        'txtTotalPer
        '
        Me.txtTotalPer.Location = New System.Drawing.Point(266, 108)
        Me.txtTotalPer.Name = "txtTotalPer"
        Me.txtTotalPer.ReadOnly = True
        Me.txtTotalPer.Size = New System.Drawing.Size(184, 22)
        Me.txtTotalPer.TabIndex = 8
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(266, 141)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(184, 22)
        Me.txtQuantity.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(266, 174)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(184, 22)
        Me.txtTotal.TabIndex = 10
        '
        'lstDesign
        '
        Me.lstDesign.FormattingEnabled = True
        Me.lstDesign.ItemHeight = 16
        Me.lstDesign.Location = New System.Drawing.Point(266, 213)
        Me.lstDesign.Name = "lstDesign"
        Me.lstDesign.Size = New System.Drawing.Size(184, 132)
        Me.lstDesign.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(40, 378)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(574, 378)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 13
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'FrmBreakdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstDesign)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtTotalPer)
        Me.Controls.Add(Me.txtVat)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblTotalPer)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblTotalPerShoe)
        Me.Name = "FrmBreakdown"
        Me.Text = "Breakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalPerShoe As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblTotalPer As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDesign As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtTotalPer As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lstDesign As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnContinue As Button
End Class
