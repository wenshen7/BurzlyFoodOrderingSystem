Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text

Public Class frmProductCreate
    Friend productId As String
    Friend imageFolder As String = Application.StartupPath & "\images\"
    Dim firstChar As String = frmProductMenu.productIDFirstCharacter
    Friend imageFolderCategory As String = frmProductMenu.imageProductFolder
    Dim ofd As New OpenFileDialog

    Private Sub frmProductManagerCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProductId.Text = productId
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofd.Filter = "Picture Files (*)|*.gif;*.jpg;*.png"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            picProductImage.Load(ofd.FileName)
        End If
    End Sub

    Dim err As New StringBuilder()
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim productName As String = txtProductName.Text
        Dim description As String = txtDescription.Text
        Dim dealerPrice, price As Decimal
        Dim ctr As Control = Nothing

        If Not IsNumeric(txtDealerPrice.Text) And txtDealerPrice.Text.Length > 0 Then
            err.AppendLine("- Invalid dealer price input")
        Else
            dealerPrice = Decimal.Parse(txtDealerPrice.Text)
        End If

        If Not IsNumeric(txtPriceBeforeGST.Text) And txtPriceBeforeGST.Text.Length > 0 Then
            err.AppendLine("- Invalid price input")
        Else
            price = Decimal.Parse(txtPriceBeforeGST.Text)
        End If

        If cboStatus.SelectedIndex = -1 Then
            err.AppendLine("- Please select status")
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
                addNewProduct()
                productId = frmProductMenu.autoIncrementProductId(lblProductId.Text.Substring(0, 1))
            End If
        Else
            validateImage()
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                Return
            Else
                addNewProduct()
                productId = frmProductMenu.autoIncrementProductId(lblProductId.Text.Substring(0, 1))
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    Private Sub resetForm()
        lblProductId.Text = frmProductMenu.autoIncrementProductId(firstChar)
        txtProductName.Clear()
        txtDescription.Clear()
        txtDealerPrice.Text = "0"
        txtPriceBeforeGST.Text = "0"
        cboStatus.SelectedIndex = -1
        picProductImage.Image = Nothing
    End Sub

    Private Sub validateImage()
        Try
            Dim strFilename As String
            strFilename = System.IO.Path.GetFileName(ofd.FileName.ToString())
            If Directory.Exists(imageFolder & imageFolderCategory) = False Then
                Call Directory.CreateDirectory(imageFolder & imageFolderCategory)
            End If
            If Not File.Exists(imageFolder & imageFolderCategory & strFilename) Then
                If strFilename.EndsWith(".png") Then
                    Call picProductImage.Image.Save(imageFolder & imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Png)
                ElseIf strFilename.EndsWith(".jpg") Then
                    Call picProductImage.Image.Save(imageFolder & imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf strFilename.EndsWith(".gif") Then
                    Call picProductImage.Image.Save(imageFolder & imageFolderCategory & strFilename, System.Drawing.Imaging.ImageFormat.Gif)
                Else
                    err.AppendLine("- Invalid photo format (Only .jpg, .png, .gif)")
                End If
            End If
        Catch fileException As Exception
            Throw fileException
        End Try
    End Sub

    Private Sub addNewProduct()
        Dim p As New Product()
        p.productID = productId
        p.productName = txtProductName.Text
        p.productDescrip = txtDescription.Text
        p.productStatus = cboStatus.SelectedItem.ToString()
        p.productDealerPrice = Decimal.Parse(txtDealerPrice.Text)
        p.productBeforeGST = Decimal.Parse(txtPriceBeforeGST.Text)
        p.productAfterGST = CType(Decimal.Parse(txtPriceBeforeGST.Text) * 1.06, Decimal?)
        p.productImageName = System.IO.Path.GetFileName(ofd.FileName)

        Dim db As New BurzlyDataContext()
        db.Products.InsertOnSubmit(p)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            Console.WriteLine(ex)
            MessageBox.Show(ex.ToString, "Database Error", MessageBoxButtons.OK)
        End Try
        MessageBox.Show("Product added successfully.", "Successful", MessageBoxButtons.OK)
        resetForm()
    End Sub

End Class