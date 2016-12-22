Public Class frmMenuStaff

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        frmProductMenu.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Me.Visible = False
        'frmLogin.txtUserId.Clear()
        'frmLogin.txtPassword.Clear()
        frmLogin.txtUserId.Focus()
        frmLogin.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        FrmTableOrder.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        frmReservationRead.ShowDialog()
    End Sub
End Class