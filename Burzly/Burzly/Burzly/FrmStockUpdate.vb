Imports System.IO
Imports System.Text

Public Class FrmStockUpdate
    Public selectedId As String
    Private Sub FrmStockUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim db As New BurzlyDataContext()
        Dim st As Stock = db.Stocks.FirstOrDefault(Function(o) o.stkID = selectedId)

        If st Is Nothing Then
            MessageBox.Show("Stock Details not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If
        txtStkId.Text = st.stkID
        txtStkType.Text = st.stkType
        txtStkName.Text = st.stkName
        txtStkDesc.Text = st.stkDescription
        txtStkBrand.Text = st.stkBrand
        txtStkBeforeGST.Text = CStr(st.stkBeforeGst)
        txtStkAftGST.Text = CStr(st.stkAfterGst)
        cboStkStatus.Text = st.stkStatus
        txtStkQty.Text = CStr(st.stkQty)
        txtSupIDStk.Text = st.supID
        If st.stkImageName = "" Then
            PictureBox1.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
        Else
            PictureBox1.Load(Application.StartupPath & "\images\stock\" & st.stkImageName)
        End If

    End Sub
    Private Sub FrmStockUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Supplier' table. You can move, or remove it, as needed.
        txtStkId.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim type As String = txtStkType.Text.Trim()
        Dim name As String = txtStkName.Text.Trim()
        Dim Brand As String = txtStkBrand.Text.Trim()
        Dim Bgst As String = txtStkBeforeGST.Text.Trim()
        Dim Agst As String = txtStkAftGST.Text.Trim()
        Dim status As String = cboStkStatus.Text.Trim()
        Dim qty As Integer = CInt(txtStkQty.Text.Trim())
        'Dim img As New ConnectImage(PicBox.Image)
        'img.Square()
        'img.Resize(150)

        err.Tag = Nothing

        If type = "" Then
            err.SetError(txtStkType, "Please Enter [ Stock Type ] ")
            err.Tag = If(err.Tag, txtStkType)
        Else
            err.SetError(txtStkType, Nothing)
        End If

        If name = "" Then
            err.SetError(txtStkName, "Please Enter [ Stock Name ] ")
            err.Tag = If(err.Tag, txtStkName)
        Else
            err.SetError(txtStkName, Nothing)
        End If

        If Brand = "" Then
            err.SetError(txtStkBrand, "Please Enter [ Stock Brand ] ")
            err.Tag = If(err.Tag, txtStkBrand)
        Else
            err.SetError(txtStkBrand, Nothing)
        End If

        If Bgst = "" Then
            err.SetError(txtStkBeforeGST, "Please Enter [ Stock Before GST ] ")
            err.Tag = If(err.Tag, txtStkBeforeGST)
        Else
            err.SetError(txtStkBeforeGST, Nothing)
        End If

        If Agst = "" Then
            err.SetError(txtStkAftGST, "Please Enter [ Stock After GST ] ")
            err.Tag = If(err.Tag, txtStkAftGST)
        Else
            err.SetError(txtStkAftGST, Nothing)
        End If

        If status = "" Then
            err.SetError(cboStkStatus, "Please Enter [ Stock Status ] ")
            err.Tag = If(err.Tag, cboStkStatus)
        Else
            err.SetError(cboStkStatus, Nothing)
        End If

        If qty = Nothing Then
            err.SetError(txtStkQty, "Please Enter [ Stock Quantity ] ")
            err.Tag = If(err.Tag, txtStkQty)
        Else
            err.SetError(txtStkQty, Nothing)
        End If

        ' STEP (2): Check status ----------------------------------------------
        If err.Tag IsNot Nothing Then
            CType(err.Tag, Control).Focus()
            Return

        End If

        Dim strBasepath As String
        Dim strFilename As String

        Try

            strFilename = System.IO.Path.GetFileName(ofdStkImg.FileName.ToString())
            strBasepath = Application.StartupPath & "\images\stock"

            If Directory.Exists(strBasepath) = False Then
                Call Directory.CreateDirectory(strBasepath)
            End If

            Call PictureBox1.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
        Catch fileException As Exception

        End Try

        Dim db As New BurzlyDataContext()
        Dim st As Stock = db.Stocks.FirstOrDefault(Function(o) o.stkID = selectedId)
        If st Is Nothing Then
            MessageBox.Show("Stock not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        st.stkID = txtStkId.Text
        st.stkType = txtStkType.Text
        st.stkName = txtStkName.Text
        st.stkDescription = txtStkDesc.Text
        st.stkBrand = txtStkBrand.Text
        st.stkBeforeGst = CType(txtStkBeforeGST.Text, Decimal?)
        st.stkAfterGst = CType(txtStkAftGST.Text, Decimal?)
        st.stkStatus = cboStkStatus.Text
        st.stkQty = CType(txtStkQty.Text, Integer?)
        st.supID = txtSupIDStk.Text
        st.stkImageName = strFilename

        Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            db.SubmitChanges()
            MessageBox.Show("Stock [ " & st.stkName.ToString() & " ] Updated", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmStockGrid.BindData()
            ClearFrom()
            Me.Close()
        End If


    End Sub

    Private Sub ClearFrom()

        txtStkType.Text = ""
        txtStkName.Text = ""
        txtStkDesc.Text = ""
        txtStkBrand.Text = ""
        txtStkBeforeGST.Text = ""
        txtStkAftGST.Text = ""
        cboStkStatus.Text = ""
        txtStkQty.Text = ""
        txtStkImgPath.Text = ""

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim result As DialogResult = ofdStkImg.ShowDialog(Me)

        ' If an image is selected
        If result = DialogResult.OK Then

        End If
        ' 1. Get and display the file path
        Dim path As String = ofdStkImg.FileName

        txtStkImgPath.Text = path

        ' 2. Load image into picture box
        PictureBox1.Load(path)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ClearFrom()
        Me.Close()
        err.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearFrom()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New BurzlyDataContext()
        Try
            Dim deleteStk = (From st In db.Stocks
                     Where st.stkID = txtStkId.Text).ToList()(0)
            db.Stocks.DeleteOnSubmit(deleteStk)

            Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                db.SubmitChanges()
                MessageBox.Show("Data deleted in database", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                FrmStockGrid.BindData()
            End If
        Catch
            MessageBox.Show("Stock not found , Database Dint not have this Stock ID & Details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub StkImageNameLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
