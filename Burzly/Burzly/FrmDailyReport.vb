﻿Public Class FrmDailyReport

    Private Sub FrmDailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.BurzlyDBDataSet.Payment)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class