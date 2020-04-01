Public Class frmCustomize
    'Declaring variables in public as they have to be used in other forms
    Public DecSum, DecQuantity As Decimal


    Private Sub chkLaces_CheckedChanged(sender As Object, e As EventArgs) Handles chkLaces.CheckedChanged
        'Showing colour options
        If chkLaces.Checked Then
            grpLaces.Visible = True
            rdoRedl.Checked = True
        Else
            grpLaces.Visible = False
        End If
    End Sub



    Private Sub chkVamp_CheckedChanged(sender As Object, e As EventArgs) Handles chkVamp.CheckedChanged
        'Showing colour options
        If chkVamp.Checked Then
            grpVamp.Visible = True
            rdoRedv.Checked = True
        Else
            grpVamp.Visible = False
        End If
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCost.Click

        'Validating if the Data entered into the text used to specify quantity is Numeric 
        If IsNumeric(txtQuantity.Text) Then
            intQuantity = Integer.Parse(txtQuantity.Text)
        Else MessageBox.Show("This must be an Numeric Value")
        End If

        'Calculating total price of shoe
        Dim sum As Double
        If rdoClassic.Checked Then
            sum += 54.49
        End If
        If rdoVintage.Checked Then
            sum += 44.99
        End If
        If rdoRetro.Checked Then
            sum += 49.5
        End If
        If chkQuarter.Checked Then
            If rdoRedq.Checked Or rdoBlackq.Checked Or rdoYellowq.Checked Or rdoBlueq.Checked Or rdoGreenq.Checked Then
                sum += 8.99
            ElseIf rdoWhiteq.Checked Then
                sum += 0
            End If
        End If

        If chkCounter.Checked Then
            If rdoRedc.Checked Or rdoBlackc.Checked Or rdoYellowc.Checked Or rdoBluec.Checked Or rdoGreenc.Checked Then
                sum += 6.49
            ElseIf rdoWhitec.Checked Then
                sum += 0
            End If
        End If

        If chkVamp.Checked Then
            If rdoRedv.Checked Or rdoBlackv.Checked Or rdoYellowv.Checked Or rdoBluev.Checked Or rdoGreenv.Checked Then
                sum += 14.99
            ElseIf rdoWhitev.Checked Then
                sum += 0
            End If
        End If

        If chkLaces.Checked Then
            If rdoRedl.Checked Or rdoBlackl.Checked Or rdoYellowl.Checked Or rdoBluel.Checked Or rdoGreenl.Checked Then
                sum += 4
            ElseIf rdoWhitel.Checked Then
                sum += 0
            End If
        End If

        If chkEyestay.Checked Then
            If rdoRede.Checked Or rdoBlacke.Checked Or rdoYellowe.Checked Or rdoBluee.Checked Or rdoGreene.Checked Then
                sum += 5
            ElseIf rdoWhitee.Checked Then
                sum += 0
            End If
        End If

        If chkTab.Checked Then
            If rdoRedh.Checked Or rdoBlackh.Checked Or rdoYellowh.Checked Or rdoBlueh.Checked Or rdoGreenh.Checked Then
                sum += 4.99
            ElseIf rdoWhiteh.Checked Then
                sum += 0
            End If
        End If

        If chkText.Checked Then
            sum += 0.45
        End If
        txtCost.Text = sum.ToString("C")

        'moving onto the next form 
        Me.Hide()
        FrmBreakdown.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If rdoClassic.Checked Or rdoRetro.Checked Or rdoVintage.Checked Then
            'Hiding and showing outputs
            chkQuarter.Show()
            chkTab.Show()
            chkText.Show()
            chkVamp.Show()
            chkLogo.Show()
            chkLaces.Show()
            chkEyestay.Show()
            chkCounter.Show()
            grpType.Hide()
            btnCost.Show()
            txtCost.Show()

        End If
    End Sub

    Private Sub chkQuarter_CheckedChanged(sender As Object, e As EventArgs) Handles chkQuarter.CheckedChanged
        'Showing colour options
        If chkQuarter.Checked Then
            grpQuarter.Visible = True
            rdoRedq.Checked = True
        Else
            grpQuarter.Visible = False
        End If
    End Sub

    Private Sub chkCounter_CheckedChanged(sender As Object, e As EventArgs) Handles chkCounter.CheckedChanged
        'Showing colour options
        If chkCounter.Checked Then
            grpCounter.Visible = True
            rdoRedc.Checked = True
        Else
            grpCounter.Visible = False
        End If
    End Sub

    Private Sub chkEyestay_CheckedChanged(sender As Object, e As EventArgs) Handles chkEyestay.CheckedChanged
        'Showing colour options
        If chkEyestay.Checked Then
            grpEye.Visible = True
            rdoRede.Checked = True
        Else
            grpEye.Visible = False
        End If
    End Sub

    Private Sub chkTab_CheckedChanged(sender As Object, e As EventArgs) Handles chkTab.CheckedChanged
        'Showing colour options
        If chkTab.Checked Then
            grpHeel.Visible = True
            rdoRedh.Checked = True
        Else
            grpHeel.Visible = False
        End If
    End Sub

    Private Sub chkText_CheckedChanged(sender As Object, e As EventArgs) Handles chkText.CheckedChanged
        'Showing outputs
        If chkText.Checked Then
            txtText.Visible = True
        End If
    End Sub

    Dim intQuantity As Integer
End Class