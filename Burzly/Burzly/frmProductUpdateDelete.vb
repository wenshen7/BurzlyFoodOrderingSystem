Option Explicit On
Option Strict On

Imports System.Text
Imports System.IO

Public Class frmProductUpdateDelete
    Private db As BurzlyDataContext
    Friend proId As String = ""
    Dim tempImageName As String
    Dim ofd As New OpenFileDialog

    Private Sub frmProductManagerUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db = New BurzlyDataContext()
        Dim rs = (From o In db.Products
                 Where o.productID.Equals(proId)).FirstOrDefault

        If System.IO.File.Exists(Application.StartupPath & "/images/" & frmProductMenu.imageProductFolder & rs.productImageName) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(Application.StartupPath & "/images/" & frmProductMenu.imageProductFolder & rs.productImageName, IO.FileMode.Open, IO.FileAccess.Read)
            picProductImage.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()

            'picProductImage.Image = Image.FromFile(Application.StartupPath & "/images/" & frmProductManagerMenu.imageProductFolder & rs.productImageName)
        Else
            picProductImage.Load(Application.StartupPath & "/images/NoImage.gif")
        End If
        lblProductId.Text = rs.productID
        txtProductName.Text = rs.productName
        txtDescription.Text = rs.productDescrip
        cboStatus.SelectedItem = rs.productStatus
        txtDealerPrice.Text = Format(rs.productDealerPrice, "0.00").ToString
        txtPriceBeforeGST.Text = Format(rs.productBeforeGST, "0.00").ToString
        txtPriceAfterGST.Text = Format(rs.productAfterGST, "0.00").ToString
        ofd.FileName = rs.productImageName
        tempImageName = rs.productImageName
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofd.Filter = "Picture Files (*)|*.gif;*.jpg;*.png"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(ofd.FileName, IO.FileMode.Open, IO.FileAccess.Read)
            picProductImage.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        End If
    End Sub

    Dim err As New StringBuilder()
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim productName As String = txtProductName.Text
        Dim description As String = txtDescription.Text
        Dim dealerPrice, price As Decimal
        Dim ctr As Control = Nothing

        If Not IsNumeric(txtDealerPrice.Text) And txtDealerPrice.Text.Length > 0 Then
            err.AppendLine("- Invalid [Dealer Price] input")
        Else
            dealerPrice = Decimal.Parse(txtDealerPrice.Text)
        End If

        If Not IsNumeric(txtPriceBeforeGST.Text) And txtPriceBeforeGST.Text.Length > 0 Then
            err.AppendLine("- Invalid [Price (RM)] input")
        Else
            price = Decimal.Parse(txtPriceBeforeGST.Text)
        End If

        If dealerPrice = Nothing Then
            dealerPrice = 0
        End If

        If price = Nothing Then
            price = 0
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            err.Clear()
            Return
        End If

        If System.IO.Path.GetFileName(ofd.FileName.ToString()).Length = 0 Then
            Dim result As Integer
            result = MessageBox.Show("No image is selected for this product, continue insert without image?", "No Image Selected", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If result = DialogResult.Yes Then
                updateProduct()
            End If
        Else
            If tempImageName <> System.IO.Path.GetFileName(ofd.FileName.ToString()) Then
                validateImage()
            End If
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                Return
            Else
                updateProduct()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Delete product?", "Deleting...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim p As Product = db.Products.FirstOrDefault(Function(o) o.productID = proId)
            Try
                db.Products.DeleteOnSubmit(p)
                db.SubmitChanges()
                If System.IO.File.Exists(Application.StartupPath & "/images/" & frmProductMenu.imageProductFolder & tempImageName) Then
                    System.IO.File.Delete(Application.StartupPath & "/images/" & frmProductMenu.imageProductFolder & tempImageName)
                    Console.WriteLine("Deleted")
                End If
            Catch ex As Exception

            End Try
            MessageBox.Show("Product deleted successfully.", "Successful", MessageBoxButtons.OK)
            Me.Close()
            frmProductMenu.populateProductMenu()
        End If
    End Sub

    Private Sub updateProduct()
        Dim p As Product = db.Products.FirstOrDefault(Function(o) o.productID = proId)
        p.productName = txtProductName.Text
        p.productDescrip = txtDescription.Text
        p.productStatus = cboStatus.SelectedItem.ToString
        p.productDealerPrice = Decimal.Parse(txtDealerPrice.Text)
        p.productBeforeGST = Decimal.Parse(txtPriceBeforeGST.Text)
        p.productAfterGST = Decimal.Parse(txtPriceAfterGST.Text)
        p.productImageName = System.IO.Path.GetFileName(ofd.FileName)

        Try
            db.SubmitChanges()
            MessageBox.Show("Product updated successfully.", "Successful", MessageBoxButtons.OK)
        Catch
            ' Handle exception.
        End Try
    End Sub

    Private Sub validateImage()
        Try
            Dim strFilename As String
            strFilename = System.IO.Path.GetFileName(ofd.FileName.ToString())
            If Directory.Exists(frmProductCreate.imageFolder & frmProductCreate.imageFolderCategory) = False Then
                Call Directory.CreateDirectory(frmProductCreate.imageFolder & frmProductCreate.imageFolderCategory)
            End If
            If strFilename.EndsWith(".png") Then
                Call picProductImage.Image.Save(frmProductCreate.imageFolder & frmProductCreate.imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Png)
            ElseIf strFilename.EndsWith(".jpg") Then
                Call picProductImage.Image.Save(frmProductCreate.imageFolder & frmProductCreate.imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
            ElseIf strFilename.EndsWith(".gif") Then
                Call picProductImage.Image.Save(frmProductCreate.imageFolder & frmProductCreate.imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Gif)
            Else
                err.AppendLine("- Invalid photo format (Only .jpg, .png, .gif)")
            End If

        Catch fileException As Exception
            Throw fileException
        End Try
    End Sub

    Private Sub txtPriceBeforeGST_TextChanged(sender As Object, e As EventArgs) Handles txtPriceBeforeGST.TextChanged
        txtPriceAfterGST.Text = (Decimal.Parse(txtPriceBeforeGST.Text) * 1.06).ToString("0.00")
    End Sub
End Class