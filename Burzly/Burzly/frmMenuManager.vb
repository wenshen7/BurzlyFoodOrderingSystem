Public Class frmMenuManager


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmProductMenu.ShowDialog()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        FrmViewReport.ShowDialog()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        FrmTableOrder.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        frmReservationRead.ShowDialog()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FrmSupplierGrids.ShowDialog()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmEmployeeCRUD.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Me.Visible = False
        'frmLogin.txtUserId.Clear()
        'frmLogin.txtPassword.Clear()
        Me.Close()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUserId.Clear()
        frmLogin.ShowDialog()
    End Sub
End Class