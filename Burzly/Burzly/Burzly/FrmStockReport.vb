Public Class FrmStockReport

    Private Sub FrmMonthlyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.BurzlyDBDataSet.Stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class