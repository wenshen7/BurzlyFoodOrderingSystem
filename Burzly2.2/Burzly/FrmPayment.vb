Imports System.Text
Public Class FrmPayment
    Public Property AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode
    Friend totalPrice As Decimal
    Private db As BurzlyDataContext
    Friend tableNo As String

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        totalPrice = 0

        Dim db As New BurzlyDataContext

        txtTable.Text = tableNo
        Dim result = (From ord In db.Orders
                         Where ord.tableNo = tableNo
                         Join pro In db.Products On ord.productID Equals pro.productID
                        Select pro.productID, pro.productName, ord.ordQty, pro.productAfterGST)
        dgvPayment.DataSource = result

        dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        dgvPayment.Columns("productID").HeaderText = "Food ID"
        dgvPayment.Columns("productName").HeaderText = "Food Name"
        dgvPayment.Columns("ordQty").HeaderText = "Quantity"
        dgvPayment.Columns("productAfterGST").HeaderText = "Unit Price"
        dgvPayment.Columns("ordQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPayment.Columns("productID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPayment.Columns("productAfterGST").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvPayment.Columns("productAfterGST").DefaultCellStyle.Format = "c"

        'Dim grandTotal As Decimal
        For Each p In result.ToList()
            totalPrice = CDec(totalPrice + (p.productAfterGST * p.ordQty))
        Next
        Console.WriteLine(totalPrice)

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

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        For x As Integer = 1 To 150

            ProgressBar1.PerformStep()
        Next

    End Sub

    
End Class