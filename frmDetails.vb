Public Class frmDetails
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        ' Validtion making sure all the boxes are full
        If txtTitle.Text = "" Then
            MessageBox.Show("Please fill in your title", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtFirstname.Text = "" Then
            MessageBox.Show("Please fill in your Name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtSurname.Text = "" Then
            MessageBox.Show("Please fill in your Last Name", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf mskDOB.Text = "" Then
            MessageBox.Show("Please fill in your Date of Birth", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtStreet.Text = "" Then
            MessageBox.Show("Please fill in your Street", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtTown.Text = "" Then
            MessageBox.Show("Please fill in your Town", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cboCounty.SelectedItem = "" Then
            MessageBox.Show("Please fill in the county you live in", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf mskPhone.Text = "" Then
            MessageBox.Show("Please fill in your Phone Number", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Please fill in your Email", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If



        'making the group box with the payment details visable when the continue button is checked 
        gpbPayment.Visible = True


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        gpbPayment.Visible = False
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Hide()
        frmInvoice.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FrmBreakdown.Show()
    End Sub
End Class