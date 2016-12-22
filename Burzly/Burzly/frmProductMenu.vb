Option Explicit On
Option Strict On

Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class frmProductMenu
    Private db As BurzlyDataContext
    Dim buttonCounter As Integer = 0
    Dim intLocationX As Integer = 15, intLocationY As Integer = 30
    Dim intBtnWidth As Integer = 180, intButtonHeight As Integer = 200
    Dim imageFolder As String = Application.StartupPath & "/images/"
    Friend imageProductFolder As String = "burger/"
    Friend productIDFirstCharacter As String = "B"

    'get position and tablenumber
    Friend userTitle As String = "customer"
    Friend tableNumber As String = "2"

    Private Sub FoodMenuManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTableNo.Text = "Table No :" & tableNumber
        If userTitle.ToLower <> "manager" Then
            mnuEdit.Visible = False
        End If
        If userTitle.ToLower <> "staff" And userTitle.ToLower <> "manager" Then
            lblPay.Visible = False
        End If
        db = New BurzlyDataContext()
        populateProductMenu()
    End Sub

    Private Sub btnBurger_Click(sender As Object, e As EventArgs) Handles btnBurger.Click
        grpProduct.Text = btnBurger.Text
        imageProductFolder = "burger/"
        resetValueBackToDefault()
        grpProduct.Controls.Clear()
        productIDFirstCharacter = "B"
        populateProductMenu()
    End Sub

    Private Sub btnBeverage_Click(sender As Object, e As EventArgs) Handles btnBeverage.Click
        grpProduct.Text = btnBeverage.Text
        imageProductFolder = "beverage/"
        resetValueBackToDefault()
        grpProduct.Controls.Clear()
        productIDFirstCharacter = "D"
        populateProductMenu()
    End Sub

    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        grpProduct.Text = btnSnack.Text
        imageProductFolder = "snack/"
        resetValueBackToDefault()
        grpProduct.Controls.Clear()
        productIDFirstCharacter = "S"
        populateProductMenu()
    End Sub

    Private Sub btnDesserts_Click(sender As Object, e As EventArgs) Handles btnDesserts.Click
        grpProduct.Text = btnDesserts.Text
        imageProductFolder = "dessert/"
        resetValueBackToDefault()
        grpProduct.Controls.Clear()
        productIDFirstCharacter = "A"
        populateProductMenu()
    End Sub

    Private Sub BurgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BurgerToolStripMenuItem.Click
        Dim tempProductIdFirstCharacter As String = productIDFirstCharacter
        Dim tempImageProductFolder As String = imageProductFolder
        productIDFirstCharacter = "B"
        imageProductFolder = "burger/"
        frmProductCreate.productId = autoIncrementProductId(productIDFirstCharacter)
        frmProductCreate.ShowDialog()
        productIDFirstCharacter = tempProductIdFirstCharacter
        imageProductFolder = tempImageProductFolder
        populateProductMenu()
    End Sub

    Private Sub DrinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrinksToolStripMenuItem.Click
        Dim tempProductIdFirstCharacter As String = productIDFirstCharacter
        Dim tempImageProductFolder As String = imageProductFolder
        productIDFirstCharacter = "D"
        imageProductFolder = "beverage/"
        frmProductCreate.productId = autoIncrementProductId(productIDFirstCharacter)
        frmProductCreate.ShowDialog()
        productIDFirstCharacter = tempProductIdFirstCharacter
        imageProductFolder = tempImageProductFolder
        populateProductMenu()
    End Sub

    Private Sub SnacksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SnacksToolStripMenuItem.Click
        Dim tempProductIdFirstCharacter As String = productIDFirstCharacter
        Dim tempImageProductFolder As String = imageProductFolder
        productIDFirstCharacter = "S"
        imageProductFolder = "snack/"
        frmProductCreate.productId = autoIncrementProductId(productIDFirstCharacter)
        frmProductCreate.ShowDialog()
        productIDFirstCharacter = tempProductIdFirstCharacter
        imageProductFolder = tempImageProductFolder
        populateProductMenu()
    End Sub

    Private Sub DessertsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DessertsToolStripMenuItem.Click
        Dim tempProductIdFirstCharacter As String = productIDFirstCharacter
        Dim tempImageProductFolder As String = imageProductFolder
        productIDFirstCharacter = "A"
        imageProductFolder = "dessert/"
        frmProductCreate.productId = autoIncrementProductId(productIDFirstCharacter)
        frmProductCreate.ShowDialog()
        productIDFirstCharacter = tempProductIdFirstCharacter
        imageProductFolder = tempImageProductFolder
        populateProductMenu()
    End Sub

    Public Sub populateProductMenu()
        db = New BurzlyDataContext()
        resetValueBackToDefault()
        grpProduct.Controls.Clear()
        For Each s In db.Products ' Loop through the result set
            If s.productID.Substring(0, 1) = productIDFirstCharacter Then
                createButton(s.productID, s.productName, CDec(s.productAfterGST), s.productImageName, s.productStatus)
            End If
        Next
    End Sub

    Private Sub createButton(productId As String, productName As String, productPrice As Decimal, productPicName As String, productStatus As String)
        Dim imageNotAvailable As Image = Image.FromFile(Application.StartupPath & "/images/NoImage.gif")
        If buttonCounter = 4 Then
            intLocationX = 15
            buttonCounter = 0
            intLocationY += 210
        End If

        Dim btnProduct As New Button
        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-MY")
        'button style & location
        btnProduct.Tag = productId 'store id into button tag
        btnProduct.Width = intBtnWidth
        btnProduct.Height = intButtonHeight
        btnProduct.FlatStyle = FlatStyle.Flat
        intLocationX = CInt((15 + (btnProduct.Width * buttonCounter)) * 1.065)
        btnProduct.Location = New Point(intLocationX, intLocationY)

        btnProduct.BackColor = Color.NavajoWhite
        'button image
        Dim fullImagePath As String = imageFolder & imageProductFolder & productPicName
        If System.IO.File.Exists(fullImagePath) Then
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(fullImagePath, IO.FileMode.Open, IO.FileAccess.Read)
            btnProduct.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
        Else
            btnProduct.Image = imageNotAvailable
        End If
        btnProduct.ImageAlign = ContentAlignment.TopCenter

        'button text & style
        btnProduct.Text = productName & vbNewLine & productPrice.ToString("c2", culture)
        btnProduct.TextAlign = ContentAlignment.BottomCenter
        btnProduct.Font = New Font("Microsoft Sans Serif", 14.25)
        btnProduct.ForeColor = Color.Black

        Dim pb As New PictureBox
        pb.Width = 47 'or whatever
        pb.Height = 47
        pb.BackColor = Color.Transparent
        pb.Top = CInt(btnProduct.Height * 0.2) 'or whatever
        pb.Left = CInt(btnProduct.Width * 0.7)
        pb.ImageLocation = imageFolder & "icon_sold_out.png"
        If productStatus.ToLower = "unavailable" And userTitle.ToLower <> "manager" Then
            btnProduct.Enabled = False
            btnProduct.Controls.Add(pb)
        ElseIf productStatus.ToLower = "unavailable" Then
            btnProduct.Controls.Add(pb)
        End If

        'Assign event handler
        AddHandler btnProduct.Click, AddressOf btnProduct_Click
        grpProduct.Controls.Add(btnProduct)
        buttonCounter += 1
    End Sub


    Private Sub btnProduct_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim btn As Button
        btn = CType(sender, Button)
        If userTitle.ToLower = "manager" Then
            frmProductUpdateDelete.proId = btn.Tag.ToString
            frmProductUpdateDelete.ShowDialog()
        End If
        If userTitle.ToLower <> "manager" Then
            frmProductOrder.proId = btn.Tag.ToString
            frmProductOrder.ShowDialog()
        End If
        populateProductMenu()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmed by Chan Chun Weng", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Function autoIncrementProductId(firstChar As String) As String
        Dim q = (From n In db.Products
                 Order By n.productID Descending
                Where n.productID.StartsWith(firstChar) Select n.productID).FirstOrDefault
        If q Is Nothing Then
            q = "0"
        End If
        Dim number As String = Regex.Replace(q, "[^0-9]", "")
        Return firstChar & Format(Integer.Parse(CStr(CDbl(number) + 1)), "0000")
    End Function

    Private Sub resetValueBackToDefault()
        intLocationX = 15
        intLocationY = 30
        buttonCounter = 0
    End Sub

    Private Sub lblSummary_Click(sender As Object, e As EventArgs) Handles lblSummary.Click
        Dim culture As CultureInfo = CultureInfo.CreateSpecificCulture("en-MY")
        Dim sb As New StringBuilder
        Dim result = (From o In db.Orders
                        Join p In db.Products On o.productID Equals p.productID
                     Where o.tableNo = tableNumber).ToList
        If result.Count = 0 Then
            MessageBox.Show("No item has been ordered yet.", "No item", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim seperator As String = "----------------------------------------"
            Dim totalPrice As Decimal

            For Each r In result
                Dim priceAfterGST As Decimal = CDec(r.p.productAfterGST)
                Dim price As Decimal = CDec(priceAfterGST * r.o.ordQty)
                totalPrice += price
                sb.Append("[" & r.p.productName & "]" & vbNewLine & "[" & (priceAfterGST).ToString("c2", culture) & " x " & r.o.ordQty & " = " & (price).ToString("c2", culture) & "]" & vbNewLine & vbNewLine)
            Next
            sb.Append(seperator & vbNewLine & "Total Price (6% GST) : " & (totalPrice).ToString("c2", culture))
            MessageBox.Show("[Food Name]" & vbNewLine & "[Price x Quantity = Total]" & vbNewLine & seperator & vbNewLine & vbNewLine & sb.ToString &
                            vbNewLine, "Summary", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lblPay_Click(sender As Object, e As EventArgs) Handles lblPay.Click
        FrmTableOrder.ShowDialog()
    End Sub
End Class