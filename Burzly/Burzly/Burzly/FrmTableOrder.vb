Public Class FrmTableOrder
    
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        FrmPayment.tableNo = "1"
        FrmPayment.ShowDialog()

    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        FrmPayment.tableNo = "2"
        FrmPayment.ShowDialog()
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        FrmPayment.tableNo = "3"
        FrmPayment.ShowDialog()
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        FrmPayment.tableNo = "4"
        FrmPayment.ShowDialog()
    End Sub


    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        FrmPayment.tableNo = "5"
        FrmPayment.ShowDialog()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        FrmPayment.tableNo = "6"
        FrmPayment.ShowDialog()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        FrmPayment.tableNo = "7"
        FrmPayment.ShowDialog()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        FrmPayment.tableNo = "8"
        FrmPayment.ShowDialog()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        FrmPayment.tableNo = "9"
        FrmPayment.ShowDialog()
    End Sub
End Class