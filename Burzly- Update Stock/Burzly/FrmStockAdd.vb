Imports System.IO
Imports System.Text
Public Class FrmStockAdd
    Public selectedId As String
    Private db As BurzlyDataContext
    Public OpenFileDialog1 As New OpenFileDialog()
    Friend err2 As New StringBuilder()
    Friend ctr As Control = Nothing
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "&Add" Then
            'add something

            'Auto Generate Supplier ID when add new supplier
            Dim nextStkId = (From st In db.Stocks
                                Order By st.stkID Descending
                                Select st.stkID).Max

            Dim startIndex As String = nextStkId.Substring(0, 1)
            Dim leftIndex As Integer = CInt(nextStkId.Substring(1, 4))
            Dim addedIndex As Integer = leftIndex + 1
            Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))
            txtStkId.Text = generatedResult

            txtStkId.Enabled = False

            btnAdd.Text = "&Save"
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnBrowse.Enabled = True
            btnExit.Enabled = False
            btnReset.Enabled = True
            btnDelete.Text = "&Cancel"
        ElseIf btnAdd.Text = "&Save" Then


            If txtStkQty.Text = "" Then
                err2.AppendLine("Please insert Quantity")
                ctr = If(ctr, txtStkQty)
            End If


            If err2.Length > 0 Then
                MessageBox.Show(err2.ToString(), "Please Enter Stock Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
                err2.Clear()
                ctr.Focus()
            Else
                'save something
                Dim type As String = txtStkType.Text.Trim()
                Dim name As String = txtStkName.Text.Trim()
                Dim Brand As String = txtStkBrand.Text.Trim()
                Dim Bgst As String = txtStkBeforeGST.Text.Trim()
                Dim Agst As String = txtStkAftGST.Text.Trim()
                Dim status As String = cboStkStatus.Text.Trim()
                Dim qty As Integer = CInt(txtStkQty.Text.Trim())

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

                Dim strBasepath As String
                Dim strFilename As String

                Try

                    strFilename = System.IO.Path.GetFileName(OpenFileDialog1.FileName.ToString())
                    strBasepath = Application.StartupPath & "\images\stock"

                    If Directory.Exists(strBasepath) = False Then
                        Call Directory.CreateDirectory(strBasepath)
                    End If

                    Call picStk.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch fileException As Exception

                End Try

                ' STEP (2): Check status ----------------------------------------------
                If err.Tag IsNot Nothing Then
                    CType(err.Tag, Control).Focus()
                    Return

                End If
                Dim st As New Stock
                st.stkID = txtStkId.Text
                st.stkType = txtStkType.Text
                st.stkName = txtStkName.Text
                st.stkDescription = txtStkDesc.Text
                st.stkBrand = txtStkBrand.Text
                st.stkBeforeGst = CType(txtStkBeforeGST.Text, Decimal)
                st.stkAfterGst = CType(txtStkAftGST.Text, Decimal)
                st.stkStatus = cboStkStatus.Text
                st.stkQty = CType(txtStkQty.Text, Integer)
                st.supID = txtSupIDStk.Text
                st.stkImageName = strFilename

                Dim result As Integer = MessageBox.Show("Are you sure want to save this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then
                    'Check Duplicate ID in database
                    Dim isDuplicated As Boolean = db.Stocks.Any(Function(o) o.stkID = st.stkID)

                    If isDuplicated Then
                        MessageBox.Show("ID Duplicate in database.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        db.Stocks.InsertOnSubmit(st)
                        db.SubmitChanges()
                        MessageBox.Show("Data inserted into the database.", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        OpenFileDialog1.FileName = ""
                        Me.Close()

                    End If
                End If
            End If

            resetButtonToDefault()
        ElseIf btnAdd.Text = "&Update" Then
            'Update something
            Dim type As String = txtStkType.Text.Trim()
            Dim name As String = txtStkName.Text.Trim()
            Dim Brand As String = txtStkBrand.Text.Trim()
            Dim Bgst As String = txtStkBeforeGST.Text.Trim()
            Dim Agst As String = txtStkAftGST.Text.Trim()
            Dim status As String = cboStkStatus.Text.Trim()
            Dim qty As Integer = CInt(txtStkQty.Text.Trim())

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

                Call picStk.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch fileException As Exception

            End Try

            Dim db As New BurzlyDataContext()
            Dim st As Stock = db.Stocks.FirstOrDefault(Function(o) o.stkID = selectedId)
            If st Is Nothing Then
                MessageBox.Show("Stock not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            'Dim st As New Stock
            st.stkID = txtStkId.Text
            st.stkType = txtStkType.Text
            st.stkName = txtStkName.Text
            st.stkDescription = txtStkDesc.Text
            st.stkBrand = txtStkBrand.Text
            st.stkBeforeGst = CType(txtStkBeforeGST.Text, Decimal)
            st.stkAfterGst = CType(txtStkAftGST.Text, Decimal)
            st.stkStatus = cboStkStatus.Text
            st.stkQty = CType(txtStkQty.Text, Integer)
            st.stkImageName = txtStkImgPath.Text
            st.supID = txtSupIDStk.Text
            st.stkImageName = strFilename

            Dim result As Integer = MessageBox.Show("Are you sure want to save this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                db.SubmitChanges()
                MessageBox.Show("Stock [ " & st.stkName.ToString() & " ] Deleted", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OpenFileDialog1.FileName = ""
                ClearFrom()
                Me.Close()
            End If

            resetButtonToDefault()

        ElseIf btnAdd.Text = "&Delete" Then
            'Delete something
            Try
                Dim deletestk = (From st In db.Stocks
                      Where st.stkID = txtStkId.Text).ToList()(0)
                db.Stocks.DeleteOnSubmit(deletestk)

                Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then
                    db.SubmitChanges()
                    MessageBox.Show("Data deleted in database", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End If
            Catch
                MessageBox.Show("Stock not found , Database Dint not have this Stock ID & Details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            resetButtonToDefault()
        End If
    End Sub
    Private Sub resetButtonToDefault()
        err.Clear()
        btnAdd.Text = "&Add"
        btnEditID.Enabled = True
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
        btnReset.Enabled = False
        btnBrowse.Enabled = True
        btnExit.Enabled = True
        btnUpdate.Text = "&Update"
        btnDelete.Text = "&Delete"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        err.Clear()
        Try
            txtStkId.Enabled = False
            Dim searchStk = (From st In db.Stocks
                            Where st.stkID = txtStkId.Text).ToList()(0)

            txtStkType.Text = searchStk.stkType
            txtStkName.Text = searchStk.stkName
            txtStkDesc.Text = searchStk.stkDescription
            txtStkBrand.Text = searchStk.stkBrand
            txtStkBeforeGST.Text = CStr(searchStk.stkBeforeGst)
            txtStkAftGST.Text = CStr(searchStk.stkAfterGst)
            cboStkStatus.Text = searchStk.stkStatus
            txtStkQty.Text = CStr(searchStk.stkQty)
            If searchStk.stkImageName = "" Then
                picStk.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
            Else
                picStk.Load(Application.StartupPath & "\images\stock\" & searchStk.stkImageName)
            End If

            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Invalid ID , Database Dint not have this Stock ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStkId.Enabled = False
            ClearFrom()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Cancel" Then
            'Cancel action
            resetButtonToDefault()
        ElseIf btnDelete.Text = "&Delete" Then
            btnAdd.Text = "&Delete"
            btnEditID.Enabled = False
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnReset.Enabled = False
            btnBrowse.Enabled = False
            btnExit.Enabled = False
            btnUpdate.Text = "&Update"
            btnDelete.Text = "&Cancel"
        End If

    End Sub

    Private Sub FrmStockDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetButtonToDefault()
        ClearFrom()
        cboStkStatus.SelectedIndex = -1
        picStk.Image = Nothing
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Stock' table. You can move, or remove it, as needed.
        db = New BurzlyDataContext()
        txtStkId.Enabled = False
        btnReset.Enabled = False
        Dim nextStkID = (From st In db.Stocks
                               Order By st.stkID Descending
                               Select st.stkID).Max

        Dim startIndex As String = nextStkID.Substring(0, 1)
        Dim leftIndex As Integer = CInt(nextStkID.Substring(1, 4))
        Dim addedIndex As Integer = leftIndex + 1
        Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))
        txtStkId.Text = generatedResult
        ClearFrom()

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        OpenFileDialog1.Filter = "only images|*.jpg"
        OpenFileDialog1.Title = "Select a file"
        Dim s As String = Application.ExecutablePath & "\images\"
        OpenFileDialog1.InitialDirectory = s
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.CheckFileExists = True Then
            picStk.ImageLocation = OpenFileDialog1.FileName.ToString
            picStk.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MsgBox("Please Select a Image")
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
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.resetButtonToDefault()
        err.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearFrom()
    End Sub

    Private Sub btnEditID_Click(sender As Object, e As EventArgs) Handles btnEditID.Click
        txtStkId.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            btnAdd.Text = "&Update"
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnBrowse.Enabled = True
            btnExit.Enabled = False
            btnEditID.Enabled = True
            btnReset.Enabled = False
            btnDelete.Text = "&Cancel"
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        db = New BurzlyDataContext()
        Dim first = (From st In db.Stocks
                    Select st.stkID).Min
        Dim firststk = (From stk In db.Stocks
            Where stk.stkID = first).ToList()(0)

        txtStkId.Text = firststk.stkID
        txtStkType.Text = firststk.stkType
        txtStkName.Text = firststk.stkName
        txtStkDesc.Text = firststk.stkDescription
        txtStkBrand.Text = firststk.stkBrand
        txtStkBeforeGST.Text = CStr(firststk.stkBeforeGst)
        txtStkAftGST.Text = CStr(firststk.stkAfterGst)
        cboStkStatus.Text = firststk.stkStatus
        txtStkQty.Text = CStr(firststk.stkQty)
        btnNext.Enabled = True
        btnPrevious.Enabled = False
        If firststk.stkImageName = "" Then
            picStk.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
        Else
            picStk.Load(Application.StartupPath & "\images\stock\" & firststk.stkImageName)
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        btnPrevious.Enabled = True
        btnNext.Enabled = False
        db = New BurzlyDataContext()
        Dim last = (From st In db.Stocks
                    Select st.stkID).Max
        Dim lastStk = (From stk In db.Stocks
            Where stk.stkID = last).ToList()(0)

        txtStkId.Text = lastStk.stkID
        txtStkType.Text = lastStk.stkType
        txtStkName.Text = lastStk.stkName
        txtStkDesc.Text = lastStk.stkDescription
        txtStkBrand.Text = lastStk.stkBrand
        txtStkBeforeGST.Text = CStr(lastStk.stkBeforeGst)
        txtStkAftGST.Text = CStr(lastStk.stkAfterGst)
        cboStkStatus.Text = lastStk.stkStatus
        txtStkQty.Text = CStr(lastStk.stkQty)
        btnPrevious.Enabled = True
        If lastStk.stkImageName = "" Then
            picStk.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
        Else
            picStk.Load(Application.StartupPath & "\images\stock\" & lastStk.stkImageName)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        db = New BurzlyDataContext()
        btnPrevious.Enabled = True
        Try
            Dim currentStkId As String
            currentStkId = txtStkId.Text
            Dim AlpCurrentId As String = currentStkId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentStkId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId + 1
            Dim changedStkId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim nextStk = (From stk In db.Stocks
                       Where stk.stkID = changedStkId).ToList()(0)

            txtStkId.Text = nextStk.stkID
            txtStkType.Text = nextStk.stkType
            txtStkName.Text = nextStk.stkName
            txtStkDesc.Text = nextStk.stkDescription
            txtStkBrand.Text = nextStk.stkBrand
            txtStkBeforeGST.Text = CStr(nextStk.stkBeforeGst)
            txtStkAftGST.Text = CStr(nextStk.stkAfterGst)
            cboStkStatus.Text = nextStk.stkStatus
            txtStkQty.Text = CStr(nextStk.stkQty)
            If nextStk.stkImageName = "" Then
                picStk.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
            Else
                picStk.Load(Application.StartupPath & "\images\stock\" & nextStk.stkImageName)
            End If
        Catch ex As Exception
            btnNext.Enabled = False
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        db = New BurzlyDataContext()
        btnNext.Enabled = True
        Try
            Dim currentStkId As String
            currentStkId = txtStkId.Text
            Dim AlpCurrentId As String = currentStkId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentStkId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId - 1
            Dim changedStkId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim PreviousStk = (From stk In db.Stocks
                       Where stk.stkID = changedStkId).ToList()(0)

            txtStkId.Text = PreviousStk.stkID
            txtStkType.Text = PreviousStk.stkType
            txtStkName.Text = PreviousStk.stkName
            txtStkDesc.Text = PreviousStk.stkDescription
            txtStkBrand.Text = PreviousStk.stkBrand
            txtStkBeforeGST.Text = CStr(PreviousStk.stkBeforeGst)
            txtStkAftGST.Text = CStr(PreviousStk.stkAfterGst)
            cboStkStatus.Text = PreviousStk.stkStatus
            txtStkQty.Text = CStr(PreviousStk.stkQty)
            If PreviousStk.stkImageName = "" Then
                picStk.Load(Application.StartupPath & "\images\stock\Noimg.jpg")
            Else
                picStk.Load(Application.StartupPath & "\images\stock\" & PreviousStk.stkImageName)
            End If
        Catch ex As Exception
            btnPrevious.Enabled = False
        End Try
    End Sub

    Private Sub StkImageNameLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class