Imports System.Drawing.Imaging
Public Class FrmSupplierGrids
    Private db As BurzlyDataContext

    Public Sub BindData()
        Dim id As String = txtSearch.Text
        Dim sp = From sup In db.Suppliers Where sup.supId.Contains(id)

        dgvSupplier.DataSource = From ds In db.Suppliers
                         Select New With {
                             ds.supId,
                             ds.supName,
                             ds.supCompany,
                             ds.supDescription,
                             ds.supAddress,
                             ds.supState,
                             ds.supPostcode,
                             ds.supCountry,
                             ds.supPhone1,
                             ds.supPhone2,
                             ds.supFax1,
                             ds.supFax2,
                             ds.supEmail,
                             ds.supStatus}

        dgvSupplier.Columns("supId").HeaderText = "Supplier ID"
        dgvSupplier.Columns("supName").HeaderText = "Supplier Name"
        dgvSupplier.Columns("supCompany").HeaderText = "Supplier Company"
        dgvSupplier.Columns("supDescription").HeaderText = "Supplier Description"
        dgvSupplier.Columns("supAddress").HeaderText = "Supplier Address"
        dgvSupplier.Columns("supState").HeaderText = "Supplier State"
        dgvSupplier.Columns("supPostcode").HeaderText = "Supplier Postcode"
        dgvSupplier.Columns("supCountry").HeaderText = "Supplier Country"
        dgvSupplier.Columns("supPhone1").HeaderText = "Supplier Phone 1"
        dgvSupplier.Columns("supPhone2").HeaderText = "Supplier Phone 2"
        dgvSupplier.Columns("supFax1").HeaderText = "Supplier Fax 1"
        dgvSupplier.Columns("supFax2").HeaderText = "Supplier Fax 2"
        dgvSupplier.Columns("supEmail").HeaderText = "Supplier Email"
        dgvSupplier.Columns("supStatus").HeaderText = "Supplier Status"

        lblCount.Text = sp.Count().ToString("0 record(s)")

    End Sub

    Private Sub FrmSupplierGrids_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Supplier' table. You can move, or remove it, as needed.
        db = New BurzlyDataContext()
        dgvSupplier.DataSource = db.Suppliers
        BindData()
        txtSearch.Text = ""
    End Sub

    Private Sub dgvSupplier_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellContentClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgvSupplier.Rows(i).Cells(0).Value)
            FrmSupplierUpdate.selectedId = id
            FrmSupplierUpdate.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        FrmSupplierAdd.ShowDialog()
    End Sub

    Private Sub SeacrhData()

        Dim db As New BurzlyDataContext()
        Dim rs = From o In db.Suppliers
                 Where o.supId.Contains(txtSearch.Text) Or o.supName.Contains(txtSearch.Text)
        dgvSupplier.DataSource = rs

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SeacrhData()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMenuManager.Show()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        FrmStockGrid.Show()
    End Sub
End Class