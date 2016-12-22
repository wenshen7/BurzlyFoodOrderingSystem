Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text
Public Class FrmSupplierAdd
    Public selectedId As String
    Private db As BurzlyDataContext

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetButtonToDefault()
        ClearFrom()
        cboSupStatus.SelectedIndex = -1
        PicBox.Image = Nothing
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Supplier' table. You can move, or remove it, as needed.
        db = New BurzlyDataContext()
        txtSupID.Enabled = False
        btnReset.Enabled = False
        Dim nextSupID = (From sup In db.Suppliers
                               Order By sup.supId Descending
                               Select sup.supId).Max

        Dim startIndex As String = nextSupID.Substring(0, 1)
        Dim leftIndex As Integer = CInt(nextSupID.Substring(1, 4))
        Dim addedIndex As Integer = leftIndex + 1
        Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))
        txtSupID.Text = generatedResult
        ClearFrom()


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "&Add" Then
            'add something

            'Auto Generate Supplier ID when add new supplier
            Dim nextSupID = (From sup In db.Suppliers
                                Order By sup.supId Descending
                                Select sup.supId).Max

            Dim startIndex As String = nextSupID.Substring(0, 1)
            Dim leftIndex As Integer = CInt(nextSupID.Substring(1, 4))
            Dim addedIndex As Integer = leftIndex + 1
            Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))
            txtSupID.Text = generatedResult

            txtSupID.Enabled = False

            btnAdd.Text = "&Save"
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnFirst.Enabled = False
            btnLast.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnReset.Enabled = True
            btnDelete.Text = "&Cancel"
        ElseIf btnAdd.Text = "&Save" Then
            'save something
            Dim name As String = txtSupName.Text.Trim()
            Dim address As String = txtSupAddr.Text.Trim()
            Dim postcode As Integer = CInt(If(mskSupPostcode.MaskCompleted, mskSupPostcode.Text, "00000"))
            Dim country As String = txtSupCountry.Text.Trim()
            Dim phone As String = txtSupPhone1.Text.Trim()
            Dim status As String = cboSupStatus.Text.Trim()


            err.Tag = Nothing

            If name = "" Then
                err.SetError(txtSupName, "Please Enter [ Supplier Name ] ")
                err.Tag = If(err.Tag, txtSupName)
            Else
                err.SetError(txtSupName, Nothing)
            End If

            If address = "" Then
                err.SetError(txtSupAddr, "Please Enter [ Supplier Address ] ")
                err.Tag = If(err.Tag, txtSupAddr)
            Else
                err.SetError(txtSupAddr, Nothing)
            End If

            If postcode = Nothing Then
                err.SetError(mskSupPostcode, "Please Enter [ Postcode Number ]")
                err.Tag = If(err.Tag, mskSupPostcode)
            Else
                err.SetError(mskSupPostcode, Nothing)
            End If

            If country = "" Then
                err.SetError(txtSupCountry, "Please Enter [ Country ] ")
                err.Tag = If(err.Tag, txtSupCountry)
            Else
                err.SetError(txtSupCountry, Nothing)
            End If

            If phone = "" Then
                err.SetError(txtSupPhone1, "Please Enter [ Supplier Phone Number ] ")
                err.Tag = If(err.Tag, txtSupPhone1)
            Else
                err.SetError(txtSupPhone1, Nothing)
            End If

            If status = "" Then
                err.SetError(cboSupStatus, "Please Enter [ Supplier Status ] ")
                err.Tag = If(err.Tag, cboSupStatus)
            Else
                err.SetError(cboSupStatus, Nothing)
            End If

            ' STEP (2): Check status ----------------------------------------------
            If err.Tag IsNot Nothing Then
                CType(err.Tag, Control).Focus()
                Return
            End If

            Dim strBasepath As String
            Dim strFilename As String

            Try

                strFilename = System.IO.Path.GetFileName(OdlgSupPic.FileName.ToString())
                strBasepath = Application.StartupPath & "\images\Supplier"

                If Directory.Exists(strBasepath) = False Then
                    Call Directory.CreateDirectory(strBasepath)
                End If

                Call PicBox.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch fileException As Exception

            End Try
            Dim sp As New Supplier With {
          .supId = txtSupID.Text,
          .supName = txtSupName.Text,
          .supCompany = txtSupCompanyName.Text,
          .supDescription = txtSupDesc.Text,
          .supAddress = txtSupAddr.Text,
          .supState = txtSupState.Text,
          .supPostcode = CType(mskSupPostcode.Text, Integer?),
          .supCountry = txtSupCountry.Text,
          .supPhone1 = txtSupPhone1.Text,
          .supPhone2 = txtSupPhone2.Text,
          .supFax1 = txtSupFax1.Text,
          .supFax2 = txtSupFax2.Text,
          .supEmail = txtSupEmail.Text,
          .supStatus = cboSupStatus.Text,
            .supImageName = strFilename}

            Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                'Check Duplicate ID in database
                Dim isDuplicated As Boolean = db.Suppliers.Any(Function(o) o.supId = sp.supId)

                If isDuplicated Then
                    MessageBox.Show("ID Duplicate in database.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    db.Suppliers.InsertOnSubmit(sp)
                    db.SubmitChanges()
                    MessageBox.Show("Data inserted into the database.", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    FrmSupplierGrids.BindData()
                End If
            End If

            resetButtonToDefault()
        ElseIf btnAdd.Text = "&Update" Then
            'Update something
            Dim name As String = txtSupName.Text.Trim()
            Dim address As String = txtSupAddr.Text.Trim()
            Dim postcode As Integer = CInt(If(mskSupPostcode.MaskCompleted, mskSupPostcode.Text, "00000"))
            Dim country As String = txtSupCountry.Text.Trim()
            Dim phone As String = txtSupPhone1.Text.Trim()
            Dim status As String = cboSupStatus.Text.Trim()

            err.Tag = Nothing

            If name = "" Then
                err.SetError(txtSupName, "Please Enter [ Supplier Name ] ")
                err.Tag = If(err.Tag, txtSupName)
            Else
                err.SetError(txtSupName, Nothing)
            End If

            If address = "" Then
                err.SetError(txtSupAddr, "Please Enter [ Supplier Address ] ")
                err.Tag = If(err.Tag, txtSupAddr)
            Else
                err.SetError(txtSupAddr, Nothing)
            End If

            If postcode = Nothing Then
                err.SetError(mskSupPostcode, "Please Enter [ Postcode Number ]")
                err.Tag = If(err.Tag, mskSupPostcode)
            Else
                err.SetError(mskSupPostcode, Nothing)
            End If

            If country = "" Then
                err.SetError(txtSupCountry, "Please Enter [ Country ] ")
                err.Tag = If(err.Tag, txtSupCountry)
            Else
                err.SetError(txtSupCountry, Nothing)
            End If

            If phone = "" Then
                err.SetError(txtSupPhone1, "Please Enter [ Supplier Phone Number ] ")
                err.Tag = If(err.Tag, txtSupPhone1)
            Else
                err.SetError(txtSupPhone1, Nothing)
            End If

            If status = "" Then
                err.SetError(cboSupStatus, "Please Enter [ Supplier Status ] ")
                err.Tag = If(err.Tag, cboSupStatus)
            Else
                err.SetError(cboSupStatus, Nothing)
            End If

            ' STEP (2): Check status ----------------------------------------------
            If err.Tag IsNot Nothing Then
                CType(err.Tag, Control).Focus()
                Return

            End If

            Dim strBasepath1 As String
            Dim strFilename1 As String

            Try

                strFilename1 = System.IO.Path.GetFileName(OdlgSupPic.FileName.ToString())
                strBasepath1 = Application.StartupPath & "\images\Supplier"

                If Directory.Exists(strBasepath1) = False Then
                    Call Directory.CreateDirectory(strBasepath1)
                End If

                Call PicBox.Image.Save(strBasepath1 & "\" & strFilename1, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch fileException As Exception

            End Try

            Dim db As New BurzlyDataContext()
            Dim s As Supplier = db.Suppliers.FirstOrDefault(Function(o) o.supId = selectedId)
            If s Is Nothing Then
                MessageBox.Show("Supplier not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If

            s.supName = txtSupName.Text
            s.supCompany = txtSupCompanyName.Text
            s.supDescription = txtSupDesc.Text
            s.supAddress = txtSupAddr.Text
            s.supState = txtSupState.Text
            s.supPostcode = CType(mskSupPostcode.Text, Integer?)
            s.supCountry = txtSupCountry.Text
            s.supPhone1 = txtSupPhone1.Text
            s.supPhone2 = txtSupPhone2.Text
            s.supFax1 = txtSupFax1.Text
            s.supFax2 = txtSupFax2.Text
            s.supEmail = txtSupEmail.Text
            s.supStatus = cboSupStatus.Text
            s.supImageName = strFilename1

            Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                db.SubmitChanges()
                MessageBox.Show("Supplier [ " & s.supName.ToString() & " ] Updated", "Data Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FrmSupplierGrids.BindData()
                ClearFrom()
                Me.Close()
            End If

            resetButtonToDefault()

        ElseIf btnAdd.Text = "&Delete" Then
            'Delete something
            Try
                Dim deleteSup = (From sp In db.Suppliers
                      Where sp.supId = txtSupID.Text).ToList()(0)
                db.Suppliers.DeleteOnSubmit(deleteSup)

                Dim result As Integer = MessageBox.Show("Are you sure want to delete this data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then
                    db.SubmitChanges()
                    MessageBox.Show("Data deleted in database", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    FrmSupplierGrids.BindData()
                End If
            Catch
                MessageBox.Show("Supplier not found , Database Dint not have this Supplier ID & Details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            resetButtonToDefault()
        End If
    End Sub
    Private Sub resetButtonToDefault()
        btnAdd.Text = "&Add"
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
        btnFirst.Enabled = True
        btnLast.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnReset.Enabled = False
        btnUpdate.Text = "&Update"
        btnDelete.Text = "&Delete"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            txtSupID.Enabled = False
            Dim searchSup = (From sp In db.Suppliers
                            Where sp.supId = txtSupID.Text).ToList()(0)

            txtSupName.Text = searchSup.supName
            txtSupCompanyName.Text = searchSup.supCompany
            txtSupDesc.Text = searchSup.supDescription
            txtSupAddr.Text = searchSup.supAddress
            txtSupState.Text = searchSup.supState
            mskSupPostcode.Text = CStr(searchSup.supPostcode)
            txtSupCountry.Text = searchSup.supCountry
            txtSupPhone1.Text = searchSup.supPhone1
            txtSupPhone2.Text = searchSup.supPhone2
            txtSupFax1.Text = searchSup.supFax1
            txtSupFax2.Text = searchSup.supFax2
            txtSupEmail.Text = searchSup.supEmail
            cboSupStatus.Text = searchSup.supStatus
            If searchSup.supImageName = "" Then
                PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
            Else
                PicBox.Load(Application.StartupPath & "\images\Supplier\" & searchSup.supImageName)
            End If

            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Invalid ID , Database Dint not have this Supplier ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSupID.Enabled = False
            ClearFrom()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Cancel" Then
            'Cancel action
            resetButtonToDefault()
        ElseIf btnDelete.Text = "&Delete" Then
            btnAdd.Text = "&Delete"
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnFirst.Enabled = False
            btnLast.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnReset.Enabled = False
            btnUpdate.Text = "&Update"
            btnDelete.Text = "&Cancel"
        End If

    End Sub

    Private Sub ClearFrom()
        txtSupName.Text = ""
        txtSupCompanyName.Text = ""
        txtSupDesc.Text = ""
        txtSupAddr.Text = ""
        txtSupState.Text = ""
        mskSupPostcode.Text = ""
        txtSupCountry.Text = ""
        txtSupPhone1.Text = ""
        txtSupPhone2.Text = ""
        txtSupFax1.Text = ""
        txtSupFax2.Text = ""
        txtSupEmail.Text = ""
        cboSupStatus.Text = ""
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "&Update" Then
            btnAdd.Text = "&Update"
            btnUpdate.Enabled = False
            btnSearch.Enabled = False
            btnFirst.Enabled = False
            btnLast.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnReset.Enabled = False
            btnDelete.Text = "&Cancel"
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        db = New BurzlyDataContext()
        Dim first = (From sp In db.Suppliers
                    Select sp.supId).Min
        Dim firstSup = (From sup In db.Suppliers
            Where sup.supId = first).ToList()(0)

        txtSupID.Text = firstSup.supId
        txtSupName.Text = firstSup.supName
        txtSupCompanyName.Text = firstSup.supCompany
        txtSupDesc.Text = firstSup.supDescription
        txtSupAddr.Text = firstSup.supAddress
        txtSupState.Text = firstSup.supState
        mskSupPostcode.Text = CStr(firstSup.supPostcode)
        txtSupCountry.Text = firstSup.supCountry
        txtSupPhone1.Text = firstSup.supPhone1
        txtSupPhone2.Text = firstSup.supPhone2
        txtSupFax1.Text = firstSup.supFax1
        txtSupFax2.Text = firstSup.supFax2
        txtSupEmail.Text = firstSup.supEmail
        cboSupStatus.Text = firstSup.supStatus
        If firstSup.supImageName = "" Then
            PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
        Else
            PicBox.Load(Application.StartupPath & "\images\Supplier\" & firstSup.supImageName)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        db = New BurzlyDataContext()
        btnNext.Enabled = True
        Try
            Dim currentSupId As String
            currentSupId = txtSupID.Text
            Dim AlpCurrentId As String = currentSupId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentSupId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId - 1
            Dim changedSupId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim previousSup = (From sup In db.Suppliers
                       Where sup.supId = changedSupId).ToList()(0)

            txtSupID.Text = previousSup.supId
            txtSupName.Text = previousSup.supName
            txtSupCompanyName.Text = previousSup.supCompany
            txtSupDesc.Text = previousSup.supDescription
            txtSupAddr.Text = previousSup.supAddress
            txtSupState.Text = previousSup.supState
            mskSupPostcode.Text = CStr(previousSup.supPostcode)
            txtSupCountry.Text = previousSup.supCountry
            txtSupPhone1.Text = previousSup.supPhone1
            txtSupPhone2.Text = previousSup.supPhone2
            txtSupFax1.Text = previousSup.supFax1
            txtSupFax2.Text = previousSup.supFax2
            txtSupEmail.Text = previousSup.supEmail
            cboSupStatus.Text = previousSup.supStatus
            If previousSup.supImageName = "" Then
                PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
            Else
                PicBox.Load(Application.StartupPath & "\images\Supplier\" & previousSup.supImageName)
            End If
        Catch ex As Exception
            btnPrevious.Enabled = False
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        db = New BurzlyDataContext()
        btnPrevious.Enabled = True
        Try
            Dim currentSupId As String
            currentSupId = txtSupID.Text
            Dim AlpCurrentId As String = currentSupId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentSupId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId + 1
            Dim changedSupId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim nextSup = (From sup In db.Suppliers
                       Where sup.supId = changedSupId).ToList()(0)

            txtSupID.Text = nextSup.supId
            txtSupName.Text = nextSup.supName
            txtSupCompanyName.Text = nextSup.supCompany
            txtSupDesc.Text = nextSup.supDescription
            txtSupAddr.Text = nextSup.supAddress
            txtSupState.Text = nextSup.supState
            mskSupPostcode.Text = CStr(nextSup.supPostcode)
            txtSupCountry.Text = nextSup.supCountry
            txtSupPhone1.Text = nextSup.supPhone1
            txtSupPhone2.Text = nextSup.supPhone2
            txtSupFax1.Text = nextSup.supFax1
            txtSupFax2.Text = nextSup.supFax2
            txtSupEmail.Text = nextSup.supEmail
            cboSupStatus.Text = nextSup.supStatus
            If nextSup.supImageName = "" Then
                PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
            Else
                PicBox.Load(Application.StartupPath & "\images\Supplier\" & nextSup.supImageName)
            End If
        Catch ex As Exception
            btnNext.Enabled = False
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        db = New BurzlyDataContext()
        Dim last = (From sp In db.Suppliers
                    Select sp.supId).Max
        Dim lastSup = (From sup In db.Suppliers
            Where sup.supId = last).ToList()(0)

        txtSupID.Text = lastSup.supId
        txtSupName.Text = lastSup.supName
        txtSupCompanyName.Text = lastSup.supCompany
        txtSupDesc.Text = lastSup.supDescription
        txtSupAddr.Text = lastSup.supAddress
        txtSupState.Text = lastSup.supState
        mskSupPostcode.Text = CStr(lastSup.supPostcode)
        txtSupCountry.Text = lastSup.supCountry
        txtSupPhone1.Text = lastSup.supPhone1
        txtSupPhone2.Text = lastSup.supPhone2
        txtSupFax1.Text = lastSup.supFax1
        txtSupFax2.Text = lastSup.supFax2
        txtSupEmail.Text = lastSup.supEmail
        cboSupStatus.Text = lastSup.supStatus
        If lastSup.supImageName = "" Then
            PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
        Else
            PicBox.Load(Application.StartupPath & "\images\Supplier\" & lastSup.supImageName)
        End If
    End Sub

    Private Sub btnEditID_Click(sender As Object, e As EventArgs) Handles btnEditID.Click
        txtSupID.Enabled = True
    End Sub

    Private Sub PicBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBox.Click

    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OdlgSupPic.Filter = "only images|*.jpg"
        OdlgSupPic.Title = "Select a file"
        Dim s As String = Application.ExecutablePath & "\images\"
        OdlgSupPic.InitialDirectory = s
        OdlgSupPic.ShowDialog()

        If OdlgSupPic.CheckFileExists = True Then
            PicBox.ImageLocation = OdlgSupPic.FileName.ToString
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MsgBox("Please Select a Image")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.resetButtonToDefault()
        err.Clear()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearFrom()
    End Sub

    Private Sub btnInStock_Click(sender As Object, e As EventArgs) Handles btnInStock.Click
        FrmStockGrid.supplierID = txtSupID.Text
        FrmStockGrid.ShowDialog()
    End Sub

    Private Sub SupIdLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
