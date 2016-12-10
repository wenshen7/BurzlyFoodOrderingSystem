Imports System.Drawing.Imaging
Public Class FrmStockGrid
    Private db As BurzlyDataContext
    Friend supplierID As String

    Public Sub BindData()
        Dim id As String = txtSearch.Text
        Dim st = From stk In db.Stocks Where stk.stkID.Contains(id)

        dgvStock.DataSource = From ds In db.Stocks
                         Select New With {
                           ds.stkID,
                           ds.stkType,
                           ds.stkName,
                           ds.stkDescription,
                           ds.stkBrand,
                           ds.stkBeforeGst,
                           ds.stkAfterGst,
                           ds.stkStatus,
                           ds.stkQty,
                           ds.supID}

        dgvStock.Columns("stkID").HeaderText = "Stock ID"
        dgvStock.Columns("stkType").HeaderText = "Stock Type"
        dgvStock.Columns("stkName").HeaderText = "Stock Name"
        dgvStock.Columns("stkDescription").HeaderText = "Stock Description"
        dgvStock.Columns("stkBrand").HeaderText = "Stock Brand"
        dgvStock.Columns("stkBeforeGst").HeaderText = "Stock Price Before GST"
        dgvStock.Columns("stkAfterGst").HeaderText = "Stock Price After GST"
        dgvStock.Columns("stkStatus").HeaderText = "Stock Status"
        dgvStock.Columns("stkQty").HeaderText = "Stock Quantity"
        dgvStock.Columns("supID").HeaderText = "Supplier ID"

        lblCount.Text = st.Count().ToString("0 record(s)")

    End Sub

    Private Sub FrmStockGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Supplier' table. You can move, or remove it, as needed.
        db = New BurzlyDataContext()
        dgvStock.DataSource = db.Stocks
        BindData()
        txtSearch.Text = ""
    End Sub


    Private Sub dgvstock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStock.CellContentClick
        Dim i As Integer = e.RowIndex
    End Sub

    Private Sub btnstock_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub SeacrhData()

        Dim db As New BurzlyDataContext()
        Dim rs = From o In db.Stocks
                 Where o.stkID.Contains(txtSearch.Text) Or o.stkName.Contains(txtSearch.Text)
        dgvStock.DataSource = rs

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SeacrhData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub
End Class