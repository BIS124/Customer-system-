Public Class FrmBreakdown
    Public DecSum As Decimal
    Dim DecTotalPer As Decimal
    Dim DecGrandTotal As Decimal
    Dim intQuantity As Integer
    Dim DecVat As Decimal
    Private Sub FrmBreakdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'connecting varables to previous form 
        DecSum = frmCustomize.DecSum
        intQuantity = frmCustomize.intQuantity


        'Calculatioms needed 
        DecVat = DecSum * 0.23
        DecTotalPer = DecSum + DecVat
        DecGrandTotal = DecTotalPer * intQuantity

        'Conerting all decimlas to string for the textbox
        txtPrice.Text = DecSum.ToString("N")
        txtVat.Text = DecVat.ToString("N")
        txtQuantity.Text = intQuantity.ToString("N")
        txtTotalPer.Text = DecTotalPer.ToString("N")
        txtTotal.Text = DecGrandTotal.ToString("C")
    End Sub
End Class