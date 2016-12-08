Imports System.Text
Public Class FrmPayment
    Public Property AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode
    Friend totalPrice As Decimal
    Private db As BurzlyDataContext
    Friend tableNo As String

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        totalPrice = 0

        Dim db As New BurzlyDataContext

        db.SubmitChanges()

        txtDate.Text = CStr(Date.Now.Date())
        txtTime.Text = DateTime.Now.ToShortTimeString()
        txtTime.Enabled = False
        txtDate.Enabled = False
        txtPaymentID.Enabled = False
        txtTable.Enabled = False
        Dim payid = (From pay In db.Payments
                    Order By pay.paymentId Descending
                    Select (pay.paymentId)).FirstOrDefault


        Dim id As Integer = payid + 1
        txtPaymentID.Text = CStr(id)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    
End Class