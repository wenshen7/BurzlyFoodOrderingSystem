Option Explicit On
Option Strict On

Imports System.Globalization

Public Class frmProductOrder
    Friend proId As String
    Private db As BurzlyDataContext
    Dim imageFolder As String = Application.StartupPath & "/images/"
    Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-MY")
    Dim productPrice As Decimal

    Private Sub frmCustomerProductOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New BurzlyDataContext()
        cboQuantity.SelectedIndex = 0
        Dim result = (From b In db.Products
                     Where b.productID = proId).FirstOrDefault
        Dim fullImagePath = imageFolder & frmProductMenu.imageProductFolder & result.productImageName

        lblFoodName.Text = result.productName
        lblDescription.Text = result.productDescrip
        Dim tempPrice As Decimal = CDec(result.productAfterGST)
        productPrice = tempPrice
        lblPrice.Text = tempPrice.ToString("c2", culture)
        lblTotalPrice.Text = tempPrice.ToString("c2", culture)
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(fullImagePath, IO.FileMode.Open, IO.FileAccess.Read)
        picBurger.Image = System.Drawing.Image.FromStream(fs)
        fs.Close()
    End Sub

    Private Sub cboQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboQuantity.SelectedIndexChanged
        If cboQuantity.SelectedIndex <> -1 Then
            Dim quantity As Integer = CInt(cboQuantity.SelectedItem)
            Dim total As Decimal = productPrice * quantity
            lblTotalPrice.Text = total.ToString("c2", culture)
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim o As New Order()
        'MessageBox.Show(lblFoodName.Text & vbTab & lblPrice.Text & vbNewLine &
        '                cboQuantity.SelectedItem & vbNewLine &
        '                lblTotalPrice.Text & vbNewLine &
        '                frmProductMenu.tableNumber & vbNewLine &
        '                "confirm")
        Dim result As Integer = MessageBox.Show("Confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            o.ordID = autoIncrementOrderId()
            o.productID = proId
            o.ordQty = CInt(cboQuantity.SelectedItem)
            o.tableNo = frmProductMenu.tableNumber
            db.Orders.InsertOnSubmit(o)
            db.SubmitChanges()
            MessageBox.Show("Order succesful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        cboQuantity.SelectedIndex = -1
        lblTotalPrice.Text = ""
        'add into db
        Me.Close()
    End Sub

    Private Function autoIncrementOrderId() As Integer
        Dim rs = (From o In db.Orders
                  Order By o.ordID Descending
                 Select o.ordID).FirstOrDefault
        If rs < 0 Then
            Return 1
        Else
            Return rs + 1
        End If
    End Function
    Private Sub frmProductOrder_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        cboQuantity.SelectedIndex = -1
        lblTotalPrice.Text = ""
    End Sub
End Class