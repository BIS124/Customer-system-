Public Class frmHome
    Private Sub btnHere_Click(sender As Object, e As EventArgs) Handles btnHere.Click
        'Moving to the next form
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class