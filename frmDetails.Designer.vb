<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetails
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.gpbPayment = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskExpiryDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSecurityDate = New System.Windows.Forms.Label()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.radAmEx = New System.Windows.Forms.RadioButton()
        Me.radLaser = New System.Windows.Forms.RadioButton()
        Me.radVisa = New System.Windows.Forms.RadioButton()
        Me.radMasterCard = New System.Windows.Forms.RadioButton()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.mskDOB = New System.Windows.Forms.MaskedTextBox()
        Me.mskBirthday = New System.Windows.Forms.Label()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.cboCounty = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblOffers = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.gpbPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(161, -42)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(489, 21)
        Me.lblInstructions.TabIndex = 54
        Me.lblInstructions.Text = "Please enter all the customers relevant details below"
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.MintCream
        Me.btnContinue.Location = New System.Drawing.Point(190, 459)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(108, 33)
        Me.btnContinue.TabIndex = 53
        Me.btnContinue.Text = "&Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(229, 22)
        Me.DateTimePicker1.TabIndex = 52
        '
        'gpbPayment
        '
        Me.gpbPayment.Controls.Add(Me.MaskedTextBox1)
        Me.gpbPayment.Controls.Add(Me.mskExpiryDate)
        Me.gpbPayment.Controls.Add(Me.mskCardNumber)
        Me.gpbPayment.Controls.Add(Me.btnConfirm)
        Me.gpbPayment.Controls.Add(Me.btnCancel)
        Me.gpbPayment.Controls.Add(Me.txtName)
        Me.gpbPayment.Controls.Add(Me.lblSecurityDate)
        Me.gpbPayment.Controls.Add(Me.lblExpiryDate)
        Me.gpbPayment.Controls.Add(Me.lblName)
        Me.gpbPayment.Controls.Add(Me.lblNumber)
        Me.gpbPayment.Controls.Add(Me.radAmEx)
        Me.gpbPayment.Controls.Add(Me.radLaser)
        Me.gpbPayment.Controls.Add(Me.radVisa)
        Me.gpbPayment.Controls.Add(Me.radMasterCard)
        Me.gpbPayment.Controls.Add(Me.lblPaymentType)
        Me.gpbPayment.Location = New System.Drawing.Point(392, 5)
        Me.gpbPayment.Name = "gpbPayment"
        Me.gpbPayment.Size = New System.Drawing.Size(375, 436)
        Me.gpbPayment.TabIndex = 51
        Me.gpbPayment.TabStop = False
        Me.gpbPayment.Text = "Payment Details "
        Me.gpbPayment.Visible = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(132, 285)
        Me.MaskedTextBox1.Mask = "000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox1.TabIndex = 17
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'mskExpiryDate
        '
        Me.mskExpiryDate.Location = New System.Drawing.Point(132, 241)
        Me.mskExpiryDate.Mask = "00/00"
        Me.mskExpiryDate.Name = "mskExpiryDate"
        Me.mskExpiryDate.Size = New System.Drawing.Size(100, 22)
        Me.mskExpiryDate.TabIndex = 16
        Me.mskExpiryDate.ValidatingType = GetType(Date)
        '
        'mskCardNumber
        '
        Me.mskCardNumber.Location = New System.Drawing.Point(132, 158)
        Me.mskCardNumber.Mask = "00000000"
        Me.mskCardNumber.Name = "mskCardNumber"
        Me.mskCardNumber.Size = New System.Drawing.Size(100, 22)
        Me.mskCardNumber.TabIndex = 15
        Me.mskCardNumber.ValidatingType = GetType(Integer)
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.MintCream
        Me.btnConfirm.Location = New System.Drawing.Point(230, 368)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 29)
        Me.btnConfirm.TabIndex = 14
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MintCream
        Me.btnCancel.Location = New System.Drawing.Point(47, 368)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(130, 200)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 10
        '
        'lblSecurityDate
        '
        Me.lblSecurityDate.AutoSize = True
        Me.lblSecurityDate.Location = New System.Drawing.Point(7, 285)
        Me.lblSecurityDate.Name = "lblSecurityDate"
        Me.lblSecurityDate.Size = New System.Drawing.Size(96, 17)
        Me.lblSecurityDate.TabIndex = 8
        Me.lblSecurityDate.Text = "Security Code"
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Location = New System.Drawing.Point(7, 246)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(80, 17)
        Me.lblExpiryDate.TabIndex = 7
        Me.lblExpiryDate.Text = "Expiry Date"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 203)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(99, 17)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name on Card"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(7, 163)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(62, 17)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Number:"
        '
        'radAmEx
        '
        Me.radAmEx.AutoSize = True
        Me.radAmEx.Location = New System.Drawing.Point(130, 124)
        Me.radAmEx.Name = "radAmEx"
        Me.radAmEx.Size = New System.Drawing.Size(64, 21)
        Me.radAmEx.TabIndex = 4
        Me.radAmEx.TabStop = True
        Me.radAmEx.Text = "AmEx"
        Me.radAmEx.UseVisualStyleBackColor = True
        '
        'radLaser
        '
        Me.radLaser.AutoSize = True
        Me.radLaser.Location = New System.Drawing.Point(130, 96)
        Me.radLaser.Name = "radLaser"
        Me.radLaser.Size = New System.Drawing.Size(95, 21)
        Me.radLaser.TabIndex = 3
        Me.radLaser.TabStop = True
        Me.radLaser.Text = "LaserCard"
        Me.radLaser.UseVisualStyleBackColor = True
        '
        'radVisa
        '
        Me.radVisa.AutoSize = True
        Me.radVisa.Location = New System.Drawing.Point(130, 68)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(56, 21)
        Me.radVisa.TabIndex = 2
        Me.radVisa.TabStop = True
        Me.radVisa.Text = "Visa"
        Me.radVisa.UseVisualStyleBackColor = True
        '
        'radMasterCard
        '
        Me.radMasterCard.AutoSize = True
        Me.radMasterCard.Location = New System.Drawing.Point(130, 40)
        Me.radMasterCard.Name = "radMasterCard"
        Me.radMasterCard.Size = New System.Drawing.Size(102, 21)
        Me.radMasterCard.TabIndex = 1
        Me.radMasterCard.TabStop = True
        Me.radMasterCard.Text = "MasterCard"
        Me.radMasterCard.UseVisualStyleBackColor = True
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(7, 38)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(99, 17)
        Me.lblPaymentType.TabIndex = 0
        Me.lblPaymentType.Text = "Paymnet Type"
        '
        'mskDOB
        '
        Me.mskDOB.Location = New System.Drawing.Point(190, 169)
        Me.mskDOB.Mask = "00/00/0000"
        Me.mskDOB.Name = "mskDOB"
        Me.mskDOB.Size = New System.Drawing.Size(121, 22)
        Me.mskDOB.TabIndex = 50
        '
        'mskBirthday
        '
        Me.mskBirthday.AutoSize = True
        Me.mskBirthday.Location = New System.Drawing.Point(49, 172)
        Me.mskBirthday.Name = "mskBirthday"
        Me.mskBirthday.Size = New System.Drawing.Size(87, 17)
        Me.mskBirthday.TabIndex = 49
        Me.mskBirthday.Text = "Date of Birth"
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(190, 340)
        Me.mskPhone.Mask = "(999) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(121, 22)
        Me.mskPhone.TabIndex = 48
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.MintCream
        Me.btnBack.Location = New System.Drawing.Point(36, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(106, 33)
        Me.btnBack.TabIndex = 47
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(264, 429)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(47, 21)
        Me.radNo.TabIndex = 46
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(190, 429)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(53, 21)
        Me.radYes.TabIndex = 45
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(190, 380)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 22)
        Me.txtEmail.TabIndex = 44
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(190, 206)
        Me.txtStreet.MaxLength = 50
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(121, 22)
        Me.txtStreet.TabIndex = 43
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(190, 246)
        Me.txtTown.MaxLength = 15
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(121, 22)
        Me.txtTown.TabIndex = 42
        '
        'cboCounty
        '
        Me.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCounty.FormattingEnabled = True
        Me.cboCounty.Items.AddRange(New Object() {"Cork", "Galway", "Mayo", "Donegal", "Kerry", "Tipperary", "Clare", "Tyrone", "Antrim", "Limerick", "Roscommon", "Down", "Wexford", "Meath", "Kilkenny", "Derry", "Wicklow", "Offaly", "Cavan", "Waterford", "Westmeath", "Sligo", "Laois", "Kildare", "Fermanagh", "Leitrim", "Armagh", "Monaghan", "Longford", "Dublin", "Carlow", "Louth"})
        Me.cboCounty.Location = New System.Drawing.Point(190, 290)
        Me.cboCounty.Name = "cboCounty"
        Me.cboCounty.Size = New System.Drawing.Size(121, 24)
        Me.cboCounty.TabIndex = 41
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(190, 47)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(121, 22)
        Me.txtTitle.TabIndex = 40
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(190, 126)
        Me.txtSurname.MaxLength = 20
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(121, 22)
        Me.txtSurname.TabIndex = 39
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(190, 87)
        Me.txtFirstname.MaxLength = 20
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(121, 22)
        Me.txtFirstname.TabIndex = 38
        '
        'lblOffers
        '
        Me.lblOffers.AutoSize = True
        Me.lblOffers.Location = New System.Drawing.Point(33, 429)
        Me.lblOffers.Name = "lblOffers"
        Me.lblOffers.Size = New System.Drawing.Size(118, 17)
        Me.lblOffers.TabIndex = 37
        Me.lblOffers.Text = "Companies Offer:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(49, 380)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(102, 17)
        Me.lblEmail.TabIndex = 36
        Me.lblEmail.Text = "Email Address:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(50, 345)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(53, 17)
        Me.lblPhone.TabIndex = 35
        Me.lblPhone.Text = "Phone:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(55, 211)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(64, 17)
        Me.lblAddress.TabIndex = 34
        Me.lblAddress.Text = "Address:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(50, 126)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(69, 17)
        Me.lblSurname.TabIndex = 33
        Me.lblSurname.Text = "Surname:"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(49, 92)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(80, 17)
        Me.lblFirstname.TabIndex = 32
        Me.lblFirstname.Text = "First Name:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(49, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 17)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Title:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(50, 10)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(42, 17)
        Me.lbldate.TabIndex = 30
        Me.lbldate.Text = "Date:"
        '
        'frmDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.gpbPayment)
        Me.Controls.Add(Me.mskDOB)
        Me.Controls.Add(Me.mskBirthday)
        Me.Controls.Add(Me.mskPhone)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.radNo)
        Me.Controls.Add(Me.radYes)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtTown)
        Me.Controls.Add(Me.cboCounty)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblOffers)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lbldate)
        Me.Name = "frmDetails"
        Me.Text = "Customer Details"
        Me.gpbPayment.ResumeLayout(False)
        Me.gpbPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents gpbPayment As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents mskExpiryDate As MaskedTextBox
    Friend WithEvents mskCardNumber As MaskedTextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblSecurityDate As Label
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents radAmEx As RadioButton
    Friend WithEvents radLaser As RadioButton
    Friend WithEvents radVisa As RadioButton
    Friend WithEvents radMasterCard As RadioButton
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents mskDOB As MaskedTextBox
    Friend WithEvents mskBirthday As Label
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents cboCounty As ComboBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblOffers As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lbldate As Label
End Class
