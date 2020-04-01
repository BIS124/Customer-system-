<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvoice
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
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.lblProvided = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtProvided = New System.Windows.Forms.TextBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lstDescription = New System.Windows.Forms.ListBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblModelType = New System.Windows.Forms.Label()
        Me.lblQuater = New System.Windows.Forms.Label()
        Me.lblVamp = New System.Windows.Forms.Label()
        Me.lblEyestyle = New System.Windows.Forms.Label()
        Me.lblLaces = New System.Windows.Forms.Label()
        Me.lblBackCounter = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(62, 36)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(58, 17)
        Me.lblOrderID.TabIndex = 0
        Me.lblOrderID.Text = "OrderID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(62, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(113, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Customer Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(61, 83)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(128, 17)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Customer Address:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(61, 111)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(126, 17)
        Me.lblNumber.TabIndex = 3
        Me.lblNumber.Text = "Customer Number:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(61, 139)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(87, 17)
        Me.lblModel.TabIndex = 4
        Me.lblModel.Text = "Shoe Model:"
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Location = New System.Drawing.Point(63, 167)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(44, 17)
        Me.lblLogo.TabIndex = 5
        Me.lblLogo.Text = "Logo:"
        '
        'lblProvided
        '
        Me.lblProvided.AutoSize = True
        Me.lblProvided.Location = New System.Drawing.Point(61, 198)
        Me.lblProvided.Name = "lblProvided"
        Me.lblProvided.Size = New System.Drawing.Size(167, 17)
        Me.lblProvided.TabIndex = 6
        Me.lblProvided.Text = "Provided when ordering*:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(63, 226)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(175, 17)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Customization Description:"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Location = New System.Drawing.Point(68, 353)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(39, 17)
        Me.lblsize.TabIndex = 8
        Me.lblsize.Text = "Size:"
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(61, 383)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(150, 17)
        Me.lblCharge.TabIndex = 9
        Me.lblCharge.Text = "Customization Charge:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(327, 573)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(61, 17)
        Me.lblQuantity.TabIndex = 10
        Me.lblQuantity.Text = "Quantity"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(575, 35)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 22)
        Me.txtDate.TabIndex = 11
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(325, 348)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.ReadOnly = True
        Me.txtSize.Size = New System.Drawing.Size(350, 22)
        Me.txtSize.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(492, 573)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(183, 22)
        Me.TextBox4.TabIndex = 14
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(325, 139)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(350, 22)
        Me.txtModel.TabIndex = 15
        '
        'txtProvided
        '
        Me.txtProvided.Location = New System.Drawing.Point(325, 198)
        Me.txtProvided.Name = "txtProvided"
        Me.txtProvided.ReadOnly = True
        Me.txtProvided.Size = New System.Drawing.Size(350, 22)
        Me.txtProvided.TabIndex = 16
        '
        'txtLogo
        '
        Me.txtLogo.Location = New System.Drawing.Point(325, 167)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.Size = New System.Drawing.Size(350, 22)
        Me.txtLogo.TabIndex = 17
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(325, 31)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.ReadOnly = True
        Me.txtOrderID.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderID.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(325, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(350, 22)
        Me.txtName.TabIndex = 19
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(325, 83)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(350, 22)
        Me.txtAddress.TabIndex = 21
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(325, 111)
        Me.MaskedTextBox1.Mask = "(999) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.ReadOnly = True
        Me.MaskedTextBox1.Size = New System.Drawing.Size(350, 22)
        Me.MaskedTextBox1.TabIndex = 22
        '
        'lstDescription
        '
        Me.lstDescription.FormattingEnabled = True
        Me.lstDescription.ItemHeight = 16
        Me.lstDescription.Location = New System.Drawing.Point(325, 226)
        Me.lstDescription.Name = "lstDescription"
        Me.lstDescription.Size = New System.Drawing.Size(350, 116)
        Me.lstDescription.TabIndex = 23
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(459, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 17)
        Me.lblDate.TabIndex = 24
        Me.lblDate.Text = "Date:"
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(325, 383)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(34, 17)
        Me.lblItem.TabIndex = 25
        Me.lblItem.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = " "
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(507, 383)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(69, 17)
        Me.lblUnitPrice.TabIndex = 27
        Me.lblUnitPrice.Text = "Unit Price"
        '
        'lblModelType
        '
        Me.lblModelType.AutoSize = True
        Me.lblModelType.Location = New System.Drawing.Point(325, 404)
        Me.lblModelType.Name = "lblModelType"
        Me.lblModelType.Size = New System.Drawing.Size(46, 17)
        Me.lblModelType.TabIndex = 28
        Me.lblModelType.Text = "Model"
        '
        'lblQuater
        '
        Me.lblQuater.AutoSize = True
        Me.lblQuater.Location = New System.Drawing.Point(325, 425)
        Me.lblQuater.Name = "lblQuater"
        Me.lblQuater.Size = New System.Drawing.Size(52, 17)
        Me.lblQuater.TabIndex = 29
        Me.lblQuater.Text = "Quater"
        '
        'lblVamp
        '
        Me.lblVamp.AutoSize = True
        Me.lblVamp.Location = New System.Drawing.Point(325, 446)
        Me.lblVamp.Name = "lblVamp"
        Me.lblVamp.Size = New System.Drawing.Size(44, 17)
        Me.lblVamp.TabIndex = 30
        Me.lblVamp.Text = "Vamp"
        '
        'lblEyestyle
        '
        Me.lblEyestyle.AutoSize = True
        Me.lblEyestyle.Location = New System.Drawing.Point(325, 471)
        Me.lblEyestyle.Name = "lblEyestyle"
        Me.lblEyestyle.Size = New System.Drawing.Size(61, 17)
        Me.lblEyestyle.TabIndex = 31
        Me.lblEyestyle.Text = "Eyestyle"
        '
        'lblLaces
        '
        Me.lblLaces.AutoSize = True
        Me.lblLaces.Location = New System.Drawing.Point(325, 488)
        Me.lblLaces.Name = "lblLaces"
        Me.lblLaces.Size = New System.Drawing.Size(46, 17)
        Me.lblLaces.TabIndex = 32
        Me.lblLaces.Text = "Laces"
        '
        'lblBackCounter
        '
        Me.lblBackCounter.AutoSize = True
        Me.lblBackCounter.Location = New System.Drawing.Point(325, 509)
        Me.lblBackCounter.Name = "lblBackCounter"
        Me.lblBackCounter.Size = New System.Drawing.Size(93, 17)
        Me.lblBackCounter.TabIndex = 33
        Me.lblBackCounter.Text = "Back Counter"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(325, 530)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(35, 17)
        Me.lblText.TabIndex = 34
        Me.lblText.Text = "Text"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(492, 404)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 22)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(492, 433)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(183, 22)
        Me.TextBox2.TabIndex = 36
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(492, 461)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(183, 22)
        Me.TextBox3.TabIndex = 37
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(492, 489)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(183, 22)
        Me.TextBox5.TabIndex = 38
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(492, 520)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(183, 22)
        Me.TextBox6.TabIndex = 39
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(328, 594)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(136, 17)
        Me.lblTotalPrice.TabIndex = 40
        Me.lblTotalPrice.Text = "Total Due(incl. VAT)"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(492, 602)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(183, 22)
        Me.TextBox7.TabIndex = 41
        '
        'FrmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 644)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblBackCounter)
        Me.Controls.Add(Me.lblLaces)
        Me.Controls.Add(Me.lblEyestyle)
        Me.Controls.Add(Me.lblVamp)
        Me.Controls.Add(Me.lblQuater)
        Me.Controls.Add(Me.lblModelType)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lstDescription)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.txtLogo)
        Me.Controls.Add(Me.txtProvided)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblCharge)
        Me.Controls.Add(Me.lblsize)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblProvided)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblOrderID)
        Me.Name = "FrmInvoice"
        Me.Text = "Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblProvided As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblsize As Label
    Friend WithEvents lblCharge As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtProvided As TextBox
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lstDescription As ListBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblModelType As Label
    Friend WithEvents lblQuater As Label
    Friend WithEvents lblVamp As Label
    Friend WithEvents lblEyestyle As Label
    Friend WithEvents lblLaces As Label
    Friend WithEvents lblBackCounter As Label
    Friend WithEvents lblText As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents TextBox7 As TextBox
End Class
