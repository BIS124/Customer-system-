Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Declaring variables
        Dim strUsername, strPassword As String
        'Putting data into textbox
        strUsername = CStr(txtUser.Text)
        strPassword = CStr(txtPassword.Text)
        'Setting username and password
        'Having  messageboxes appear when logging in
        If strUsername = "manager" And strPassword = "manager" And rdoManager.Checked() Or
            strUsername = "customer" And strPassword = "customer" And rdoCustomer.Checked() Or
            strUsername = "employee" And strPassword = "employee" And rdoEmployee.Checked() Then
            MsgBox("Login successful")
            Me.Hide()
            frmCustomize.Show()
        Else MsgBox("Login unsuccessful, please try again")
            txtUser.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rdoCustomer.Checked() Or rdoEmployee.Checked() Or rdoManager.Checked() Then
            'Hiding and showing different outputs
            lblName.Show()
            lblPassword.Show()
            txtPassword.Show()
            txtUser.Show()
            btnExit.Show()
            btnLogin.Show()
            grpSelect.Hide()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Leaving the form
        Me.Close()

    End Sub



End Class

