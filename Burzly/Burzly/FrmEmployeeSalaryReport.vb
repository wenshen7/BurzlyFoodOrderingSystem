Public Class FrmEmployeeSalaryReport

    Private Sub FrmEmployeeSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.BurzlyDBDataSet.Employee)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class