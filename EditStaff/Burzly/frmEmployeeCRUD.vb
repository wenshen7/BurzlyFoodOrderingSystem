Imports System.Text
Imports System.IO
Imports System.Collections

Public Class frmEmployeeCRUD
    Public db As BurzlyDataContext
    Public s As String = Application.ExecutablePath & "\images\"
    Public openFileDialog1 As New OpenFileDialog()
    Friend err2 As New StringBuilder()
    Friend ctr As Control = Nothing

    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.BurzlyDBDataSet.Employee)
        db = New BurzlyDataContext()

        setControlReadOnly(True)

        ' picEmp.Load(Application.StartupPath & "\images\Employee\" & empid.empImageName)
        Dim first = (From emp In db.Employees
                Select emp.empId).Min
        Dim firstEmp = (From emp In db.Employees
                   Where emp.empId = first).ToList()(0)
        'picEmp.Load(Application.StartupPath & "\images\Employee\" & firstEmp.empImageName)

    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If btnAdd.Text = "&Add" Then
            txtPassw.Enabled = True
            picEmp.Image = Nothing

            txtEmpId.Enabled = False
            setControlReadOnly(False)
            EmpDOBDateTimePicker.Enabled = True
            btnAdd.Text = "&Save"



            Dim nextEmpId = (From emp In db.Employees
                            Order By emp.empId Descending
                            Select emp.empId).Max
            Dim startIndex As String = nextEmpId.Substring(0, 1)
            Dim leftIndex As Integer = CInt(nextEmpId.Substring(1, 4))
            Dim addedIndex As Integer = leftIndex + 1
            Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))

            txtEmpId.Text = generatedResult
            txtEmpName.Clear()
            mskEmpIC.Clear()
            txtEmpPassp.Clear()
            txtEmpGender.Clear()
            txtEmpAddr.Clear()
            mskEmpPostcode.Clear()
            txtCountry.Clear()
            txtPhone1.Clear()
            txtPhone2.Clear()
            mskEmail.Clear()
            txtPassw.Clear()
            txtEmpPosition.Clear()
            txtEmpSalary.Clear()
            txtEmpState.Clear()
            txtEmpStatus.Clear()
            txtEmpImageName.Clear()

        Else

            'Add Image
            Dim strFilename As String


            Try
                Dim strBasepath As String
                strFilename = System.IO.Path.GetFileName(openFileDialog1.FileName.ToString())
                strBasepath = Application.StartupPath & "\images\employee"
                If Directory.Exists(strBasepath) = False Then
                    Call Directory.CreateDirectory(strBasepath)
                End If
                'Save Image
                Call picEmp.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch fileException As Exception
            End Try

            If txtEmpId.Text = "" Or IsNumeric(txtEmpId.Text) Then
                err2.AppendLine("Error ID")
                ctr = If(ctr, txtEmpId)
            End If

            If txtEmpName.Text = "" Or IsNumeric(txtEmpName.Text) Then
                err2.AppendLine("Error name")
                ctr = If(ctr, txtEmpName)
            End If

            If Not mskEmpIC.MaskFull Then
                err2.AppendLine("Error IC")
                ctr = If(ctr, mskEmpIC)
            End If

            If IsNumeric(txtEmpGender.Text) Then
                err2.AppendLine("Error Gender")
                ctr = If(ctr, txtEmpGender)
            End If

            If IsNumeric(txtCountry.Text) Then
                err2.AppendLine("Error Country")
                ctr = If(ctr, txtCountry)
            End If

            If IsNumeric(txtPhone1.Text) = False Then
                err2.AppendLine("Error Phone1")
                ctr = If(ctr, txtPhone1)
            End If

            If IsNumeric(txtPhone2.Text) = False Then
                err2.AppendLine("Error Phone2")
                ctr = If(ctr, txtPhone2)
            End If

            If Not mskEmpPostcode.MaskFull Then
                err2.AppendLine("Please Enter Postal Code")
                ctr = If(ctr, mskEmpPostcode)
            End If

            If txtEmpSalary.Text = "" Then
                err2.AppendLine("Please Enter Salary")
                ctr = If(ctr, txtEmpSalary)
            End If

            If txtPassw.Text = "" Then
                err2.AppendLine("Please Enter Password")
                ctr = If(ctr, txtPassw)
            End If

            If IsNumeric(txtEmpPosition.Text) Then
                err2.AppendLine("Error Position")
                ctr = If(ctr, txtEmpPosition)
            End If

            If IsNumeric(txtEmpState.Text) Then
                err2.AppendLine("Error State")
                ctr = If(ctr, txtEmpState)
            End If

            If IsNumeric(txtEmpStatus.Text) Then
                err2.AppendLine("Error Status")
                ctr = If(ctr, txtEmpStatus)
            End If

            If err2.Length > 0 Then
                MessageBox.Show(err2.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err2.Clear()
                ctr.Focus()
                Return

            Else
                btnAdd.Text = "&Add"
                Dim em As New Employee
                Try
                    With em
                        .empId = txtEmpId.Text
                        .empName = txtEmpName.Text
                        .empIC = mskEmpIC.Text
                        .empPassport = txtEmpPassp.Text
                        .empDOB = CType(EmpDOBDateTimePicker.Text, Date?)
                        .empGender = txtEmpGender.Text
                        .empAddress = txtEmpAddr.Text
                        .empPostcode = CType(mskEmpPostcode.Text, Integer?)
                        .empCountry = txtCountry.Text
                        .empPhone1 = txtPhone1.Text
                        .empPhone2 = txtPhone2.Text
                        .empEmail = mskEmail.Text
                        .empPassword = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text))
                        .empPosition = txtEmpPosition.Text
                        .empSalary = CType(txtEmpSalary.Text, Decimal?)
                        .empState = txtEmpState.Text
                        .empStatus = txtEmpStatus.Text

                    End With
                    CheckError(txtEmpId.Text, txtEmpName.Text, mskEmpIC.Text, txtEmpPassp.Text, txtEmpGender.Text, txtEmpAddr.Text, mskEmpPostcode.Text, txtCountry.Text, txtPhone1.Text, txtPhone2.Text, mskEmail.Text, System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text)), txtEmpPosition.Text, txtEmpSalary.Text, txtEmpState.Text, txtEmpStatus.Text)

                    If Not mskEmpIC.MaskFull Then
                        err.SetError(mskEmail, "Please Enter [ IC ] ")
                        err.Tag = If(err.Tag, mskEmail)
                    Else
                        err.SetError(mskEmail, Nothing)
                    End If

                    Dim result As Integer = MessageBox.Show("Confirm save data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        db.Employees.InsertOnSubmit(em)
                        db.SubmitChanges()
                        openFileDialog1.FileName = ""
                        err.Clear()
                        MessageBox.Show("Inseted Data", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        EmployeeBindingSource.EndEdit()

                        setControlReadOnly(True)

                        txtEmpId.Enabled = True
                        db = New BurzlyDataContext()

                    Else
                        openFileDialog1.FileName = ""
                        btnAdd.Text = "&Save"
                        MessageBox.Show("Data not insert", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch
                    Dim ic As String = CStr(em.empIC.Length)
                    CheckError(txtEmpId.Text, txtEmpName.Text, mskEmpIC.Text, txtEmpPassp.Text, txtEmpGender.Text, txtEmpAddr.Text, mskEmpPostcode.Text, txtCountry.Text, txtPhone1.Text, txtPhone2.Text, mskEmail.Text, System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text)), txtEmpPosition.Text, txtEmpSalary.Text, txtEmpState.Text, txtEmpStatus.Text)
                    btnAdd.Text = "&Save"
                    'MessageBox.Show("Employee" & vbNewLine & "-Name " & vbNewLine & "-Postcode " & vbNewLine & "-Salary " & vbNewLine & "-Password" & vbNewLine & "Cannot be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End If

        db = New BurzlyDataContext()

    End Sub




    Private Sub setControlReadOnly(ByVal blnRead As Boolean)
        txtCountry.ReadOnly = blnRead
        txtEmpAddr.ReadOnly = blnRead
        txtEmpGender.ReadOnly = blnRead
        txtEmpPassp.ReadOnly = blnRead
        txtEmpName.ReadOnly = blnRead
        txtEmpPosition.ReadOnly = blnRead
        txtEmpSalary.ReadOnly = blnRead
        txtEmpState.ReadOnly = blnRead
        txtEmpStatus.ReadOnly = blnRead
        txtPassw.ReadOnly = blnRead
        txtPhone1.ReadOnly = blnRead
        txtPhone2.ReadOnly = blnRead
        mskEmail.ReadOnly = blnRead
        mskEmpIC.ReadOnly = blnRead
        mskEmpPostcode.ReadOnly = blnRead
        EmpDOBDateTimePicker.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        EmployeeBindingSource.CancelEdit()
        err.Clear()
        setControlReadOnly(True)
        btnAdd.Text = "&Add"

        btnAdd.Enabled = True
        txtEmpId.Enabled = True

        Dim first = (From emp In db.Employees
                Select emp.empId).Min
        Dim firstEmp = (From emp In db.Employees
                   Where emp.empId = first).ToList()(0)
        'picEmp.Load(Application.StartupPath & "\images\Employee\" & firstEmp.empImageName)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



    Private Sub btnBrowsePic_Click(sender As Object, e As EventArgs) Handles btnBrowsePic.Click

        openFileDialog1.Filter = "Only Image|*.jpg;*.gif"

        openFileDialog1.Title = "Select a file"
        'Dim s As String = Application.ExecutablePath & "\images\"
        openFileDialog1.InitialDirectory = s
        openFileDialog1.ShowDialog()

        If openFileDialog1.CheckFileExists = True Then
            picEmp.ImageLocation = openFileDialog1.FileName.ToString
            picEmp.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            MsgBox("Please Select an Image")
        End If

    End Sub


    Private Sub PublisherBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BurzlyDBDataSet)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        ' Dim searchEmp As String
        Try
            Dim searchEmp = (From emp In db.Employees
                                Where emp.empId = txtEmpId.Text).ToList()(0)
        Catch
            MessageBox.Show("Invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEmpId.Text = "M0001"
            txtEmpName.Clear()
            mskEmpIC.Clear()
            txtEmpPassp.Clear()
            txtEmpGender.Clear()
            txtEmpAddr.Clear()
            mskEmpPostcode.Clear()
            txtCountry.Clear()
            txtPhone1.Clear()
            txtPhone2.Clear()
            mskEmail.Clear()
            txtPassw.Clear()
            txtEmpPosition.Clear()
            txtEmpSalary.Clear()
            txtEmpState.Clear()
            txtEmpStatus.Clear()
        End Try


        Try
            Dim searchEmp = (From emp In db.Employees
                                Where emp.empId = txtEmpId.Text).ToList()(0)
            txtEmpName.Text = searchEmp.empName
            mskEmpIC.Text = searchEmp.empIC
            txtEmpPassp.Text = searchEmp.empPassport
            EmpDOBDateTimePicker.Text = CStr(searchEmp.empDOB)
            txtEmpGender.Text = searchEmp.empGender
            txtEmpAddr.Text = searchEmp.empAddress
            mskEmpPostcode.Text = CStr(searchEmp.empPostcode)
            txtCountry.Text = searchEmp.empCountry
            txtPhone1.Text = searchEmp.empPhone1
            txtPhone2.Text = searchEmp.empPhone2
            mskEmail.Text = searchEmp.empEmail
            txtPassw.Text = searchEmp.empPassword
            txtEmpPosition.Text = searchEmp.empPosition
            txtEmpSalary.Text = CStr(searchEmp.empSalary)
            txtEmpState.Text = searchEmp.empState

            'load image
            picEmp.Load(Application.StartupPath & "\images\Employee\" & searchEmp.empImageName)
            'Console.WriteLine(Application.StartupPath & "\images\Employee\" & searchEmp.empImageName)
        Catch
            picEmp.Load(Application.StartupPath & "\images\Employee\No_Image.jpg")
        End Try
        db.SubmitChanges()
        db = New BurzlyDataContext()
        dgvEmp.DataSource = db.Employees

    End Sub


    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        setControlReadOnly(True)
        db = New BurzlyDataContext()
        Dim first = (From emp In db.Employees
                Select emp.empId).Min

        Dim firstEmp = (From emp In db.Employees
                           Where emp.empId = first).ToList()(0)

        txtEmpId.Text = firstEmp.empId
        txtEmpName.Text = firstEmp.empName
        mskEmpIC.Text = firstEmp.empIC
        txtEmpPassp.Text = firstEmp.empPassport
        EmpDOBDateTimePicker.Text = CStr(firstEmp.empDOB)
        txtEmpGender.Text = firstEmp.empGender
        txtEmpAddr.Text = firstEmp.empAddress
        mskEmpPostcode.Text = CStr(firstEmp.empPostcode)
        txtCountry.Text = firstEmp.empCountry
        txtPhone1.Text = firstEmp.empPhone1
        txtPhone2.Text = firstEmp.empPhone2
        mskEmail.Text = firstEmp.empEmail
        txtPassw.Text = firstEmp.empPassword
        txtEmpPosition.Text = firstEmp.empPosition
        txtEmpSalary.Text = CStr(firstEmp.empSalary)
        txtEmpState.Text = firstEmp.empState
        Try
            picEmp.Load(Application.StartupPath & "\images\Employee\" & firstEmp.empImageName)
        Catch ex As Exception
            picEmp.Load(Application.StartupPath & "\images\Employee\No_Image.jpg")
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click

        setControlReadOnly(True)
        db = New BurzlyDataContext()
        Dim last = (From emp In db.Employees
                Select emp.empId).Max

        Dim lastEmp = (From emp In db.Employees
                           Where emp.empId = last).ToList()(0)

        txtEmpId.Text = lastEmp.empId
        txtEmpName.Text = lastEmp.empName
        mskEmpIC.Text = lastEmp.empIC
        txtEmpPassp.Text = lastEmp.empPassport
        EmpDOBDateTimePicker.Text = CStr(lastEmp.empDOB)
        txtEmpGender.Text = lastEmp.empGender
        txtEmpAddr.Text = lastEmp.empAddress
        mskEmpPostcode.Text = CStr(lastEmp.empPostcode)
        txtCountry.Text = lastEmp.empCountry
        txtPhone1.Text = lastEmp.empPhone1
        txtPhone2.Text = lastEmp.empPhone2
        mskEmail.Text = lastEmp.empEmail
        txtPassw.Text = lastEmp.empPassword
        txtEmpPosition.Text = lastEmp.empPosition
        txtEmpSalary.Text = CStr(lastEmp.empSalary)
        txtEmpState.Text = lastEmp.empState
        txtEmpImageName.Text = lastEmp.empImageName
        Try
            picEmp.Load(Application.StartupPath & "\images\Employee\" & lastEmp.empImageName)
        Catch
            picEmp.Load(Application.StartupPath & "\images\Employee\No_Image.jpg")
        End Try

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        setControlReadOnly(True)
        Try


            btnNext.Enabled = True
            'Dim currentEmpId As String
            'currentEmpId = txtEmpId.Text
            'Dim AlpCurrentId As String = currentEmpId.Substring(0, 1)
            'Dim NumCurrentId As Integer = currentEmpId.Substring(1, 4)
            'Dim addedIndex As Integer = NumCurrentId - 1
            'Dim changedEmpId As String = (AlpCurrentId & addedIndex.ToString("0000"))
            '    Dim previousEmp
            '    previousEmp = (From emp In db.Employees
            '           Where emp.empId = changedEmpId).ToList()(0)

            btnPrevious.Enabled = True
            Dim currentEmpId As String
            currentEmpId = txtEmpId.Text
            Dim AlpCurrentId As String = currentEmpId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentEmpId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId - 1
            Dim changedEmpId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim previousEmp = (From emp In db.Employees
                       Where emp.empId = changedEmpId).ToList()(0)

            txtEmpId.Text = previousEmp.empId
            txtEmpName.Text = previousEmp.empName
            mskEmpIC.Text = previousEmp.empIC
            txtEmpPassp.Text = previousEmp.empPassport
            EmpDOBDateTimePicker.Text = CStr(previousEmp.empDOB)
            txtEmpGender.Text = previousEmp.empGender
            txtEmpAddr.Text = previousEmp.empAddress
            mskEmpPostcode.Text = CStr(previousEmp.empPostcode)
            txtCountry.Text = previousEmp.empCountry
            txtPhone1.Text = previousEmp.empPhone1
            txtPhone2.Text = previousEmp.empPhone2
            mskEmail.Text = previousEmp.empEmail
            txtPassw.Text = previousEmp.empPassword
            txtEmpPosition.Text = previousEmp.empPosition
            txtEmpSalary.Text = CStr(previousEmp.empSalary)
            txtEmpState.Text = previousEmp.empState
            txtEmpImageName.Text = previousEmp.empImageName

            Try
                picEmp.Load(Application.StartupPath & "\images\Employee\" & txtEmpImageName.Text)
            Catch
                picEmp.Load(Application.StartupPath & "\images\Employee\No_Image.jpg")
            End Try

        Catch ex As Exception
            MessageBox.Show("Id Not Found", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        setControlReadOnly(True)
        Try
            btnPrevious.Enabled = True
            Dim currentEmpId As String
            currentEmpId = txtEmpId.Text
            Dim AlpCurrentId As String = currentEmpId.Substring(0, 1)
            Dim NumCurrentId As Integer = CInt(currentEmpId.Substring(1, 4))
            Dim addedIndex As Integer = NumCurrentId + 1
            Dim changedEmpId As String = (AlpCurrentId & addedIndex.ToString("0000"))

            Dim nextEmp = (From emp In db.Employees
                       Where emp.empId = changedEmpId).ToList()(0)

            'Do

            '    currentEmpId = txtEmpId.Text
            '    AlpCurrentId = currentEmpId.Substring(0, 1)
            '    NumCurrentId = currentEmpId.Substring(1, 4)
            '    addedIndex = NumCurrentId - 1
            '    changedEmpId = (AlpCurrentId & addedIndex.ToString("0000"))

            '    nextEmp = (From emp In db.Employees
            '           Where emp.empId = changedEmpId).ToList()(0)
            'Loop While (changedEmpId = "")

            txtEmpId.Text = nextEmp.empId
            txtEmpName.Text = nextEmp.empName
            mskEmpIC.Text = nextEmp.empIC
            txtEmpPassp.Text = nextEmp.empPassport
            EmpDOBDateTimePicker.Text = CStr(nextEmp.empDOB)
            txtEmpGender.Text = nextEmp.empGender
            txtEmpAddr.Text = nextEmp.empAddress
            mskEmpPostcode.Text = CStr(nextEmp.empPostcode)
            txtCountry.Text = nextEmp.empCountry
            txtPhone1.Text = nextEmp.empPhone1
            txtPhone2.Text = nextEmp.empPhone2
            mskEmail.Text = nextEmp.empEmail
            txtPassw.Text = nextEmp.empPassword
            txtEmpPosition.Text = nextEmp.empPosition
            txtEmpSalary.Text = CStr(nextEmp.empSalary)
            txtEmpState.Text = nextEmp.empState
            txtEmpImageName.Text = nextEmp.empImageName

            Try
                picEmp.Load(Application.StartupPath & "\images\Employee\" & txtEmpImageName.Text)
            Catch
                picEmp.Load(Application.StartupPath & "\images\Employee\No_Image.jpg")
            End Try
        Catch
            MessageBox.Show("Id not Found", "Invalid Id", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmpId_TextChanged(sender As Object, e As EventArgs) Handles txtEmpId.TextChanged
        SeacrhData()
    End Sub

    Private Sub SeacrhData()
        Dim db As New BurzlyDataContext()
        Dim rs = From o In db.Employees
                 Where o.empId.Contains(txtEmpId.Text) Or o.empId.Contains(txtEmpId.Text)
        dgvEmp.DataSource = rs
    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "U&pdate"
            btnAdd.Enabled = False

            setControlReadOnly(False)
            EmpDOBDateTimePicker.Enabled = True
            txtEmpId.Enabled = False
            btnChangePassword.Visible = True
            txtPassw.Enabled = False

        Else


            If txtEmpName.Text = "" Or IsNumeric(txtEmpName.Text) Then
                err2.AppendLine("Error name")
                ctr = If(ctr, txtEmpName)
            End If

            If Not mskEmpIC.MaskFull Then
                err2.AppendLine("Error IC")
                ctr = If(ctr, mskEmpIC)
            End If

            If IsNumeric(txtEmpGender.Text) Then
                err2.AppendLine("Error Gender")
                ctr = If(ctr, txtEmpGender)
            End If

            If IsNumeric(txtCountry.Text) Then
                err2.AppendLine("Error Country")
                ctr = If(ctr, txtCountry)
            End If

            If IsNumeric(txtPhone1.Text) = False Then
                err2.AppendLine("Error Phone1")
                ctr = If(ctr, txtPhone1)
            End If

            If IsNumeric(txtPhone2.Text) = False Then
                err2.AppendLine("Error Phone2")
                ctr = If(ctr, txtPhone2)
            End If

            If Not mskEmpPostcode.MaskFull Then
                err2.AppendLine("Please Enter Postal Code")
                ctr = If(ctr, mskEmpPostcode)
            End If

            If txtEmpSalary.Text = "" Then
                err2.AppendLine("Please Enter Salary")
                ctr = If(ctr, txtEmpSalary)
            End If

            If txtPassw.Text = "" Then
                err2.AppendLine("Please Enter Password")
                ctr = If(ctr, txtPassw)
            End If

            If IsNumeric(txtEmpPosition.Text) Then
                err2.AppendLine("Error Position")
                ctr = If(ctr, txtEmpPosition)
            End If

            If IsNumeric(txtEmpState.Text) Then
                err2.AppendLine("Error State")
                ctr = If(ctr, txtEmpState)
            End If

            If IsNumeric(txtEmpStatus.Text) Then
                err2.AppendLine("Error Status")
                ctr = If(ctr, txtEmpStatus)
            End If

            If err2.Length > 0 Then
                MessageBox.Show(err2.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err2.Clear()
                ctr.Focus()
                Return
            Else

                btnEdit.Text = "&Edit"
                Dim strFilename As String

                'Add Image
                Try
                    Dim strBasepath As String
                    strFilename = System.IO.Path.GetFileName(openFileDialog1.FileName.ToString())
                    strBasepath = Application.StartupPath & "\images\employee"
                    If Directory.Exists(strBasepath) = False Then
                        Call Directory.CreateDirectory(strBasepath)
                    End If
                    'Save Image
                    Call picEmp.Image.Save(strBasepath & "\" & strFilename, System.Drawing.Imaging.ImageFormat.Jpeg)
                Catch fileException As Exception
                End Try


                Try

                    'Save other information
                    Dim updateEmp = (From emp In db.Employees
                                     Where emp.empId = txtEmpId.Text).ToList()(0)

                    With updateEmp

                        .empIC = mskEmpIC.Text
                        .empName = txtEmpName.Text
                        .empPassport = txtEmpPassp.Text
                        .empDOB = CType(EmpDOBDateTimePicker.Text, Date?)
                        .empGender = txtEmpGender.Text
                        .empAddress = txtEmpAddr.Text
                        .empPostcode = CType(mskEmpPostcode.Text, Integer?)
                        .empCountry = txtCountry.Text
                        .empPhone1 = txtPhone1.Text
                        .empPhone2 = txtPhone2.Text
                        .empEmail = mskEmail.Text
                        '.empPassword = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text))
                        .empPosition = txtEmpPosition.Text
                        .empSalary = CType(txtEmpSalary.Text, Decimal?)
                        .empState = txtEmpState.Text
                        .empStatus = txtEmpStatus.Text
                    End With

                    If updateEmp.empImageName = " " Or updateEmp.empImageName = "No_Image.jpg" Then
                        updateEmp.empImageName = strFilename
                    Else
                        Dim ImgReplace = MessageBox.Show("Do you Really Want to Replace Image?", "Replace Image", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        If ImgReplace = Windows.Forms.DialogResult.Yes Then
                            updateEmp.empImageName = strFilename
                        Else
                            MessageBox.Show("Image not Changed", "Image No Change", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            updateEmp.empImageName = updateEmp.empImageName
                        End If
                    End If


                    'CheckError(txtEmpId.Text, txtEmpName.Text, mskEmpIC.Text, txtEmpPassp.Text, txtEmpGender.Text, txtEmpAddr.Text, mskEmpPostcode.Text, txtCountry.Text, txtPhone1.Text, txtPhone2.Text, mskEmail.Text, System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text)), txtEmpPosition.Text, txtEmpSalary.Text, txtEmpState.Text, txtEmpStatus.Text)
                    Dim result As Integer = MessageBox.Show("Confirm save data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If result = DialogResult.Yes Then
                        If txtPassw.Enabled = True Then
                            updateEmp.empPassword = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassw.Text))
                        End If
                        db.SubmitChanges()
                        openFileDialog1.FileName = ""
                        err.Clear()
                        MessageBox.Show("Data Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        EmployeeBindingSource.EndEdit()
                        btnAnotherId.Visible = False
                        setControlReadOnly(True)
                        btnDelete.Enabled = True
                        btnEdit.Enabled = True
                        txtEmpId.Enabled = True
                        btnAdd.Enabled = True
                        db = New BurzlyDataContext()
                        dgvEmp.DataSource = db.Employees
                        setControlReadOnly(True)
                        txtEmpId.Enabled = True
                        btnAdd.Enabled = True

                        btnChangePassword.Visible = False
                        txtPassw.Enabled = True
                    Else
                        openFileDialog1.FileName = ""
                        btnEdit.Text = "&Update"
                        MessageBox.Show("Data not update", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If


                    'Save changes
                    'db.SubmitChanges()
                    ' MessageBox.Show("Updated Data", "updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Catch
                    'MessageBox.Show("NO Data Updated", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'btnEdit.Text = "&Update"
                    btnAdd.Enabled = True

                End Try


            End If

        End If
        db = New BurzlyDataContext()
        dgvEmp.DataSource = db.Employees
    End Sub

    Sub CheckError(id As String, name As String, ic As String, passport As String, gender As String, address As String, postcode As String, country As String, phone1 As String, phone2 As String, email As String, password As String, position As String, salary As String, state As String, status As String)

        err.Tag = Nothing

        If id = "" Then
            err.SetError(txtEmpId, "Please Enter [ Id ] ")
            err.Tag = If(err.Tag, txtEmpId)
        Else
            err.SetError(txtEmpId, Nothing)
        End If

        If name = "" Then
            err.SetError(txtEmpName, "Please Enter [ Name ] ")
            err.Tag = If(err.Tag, txtEmpName)
        Else
            err.SetError(txtEmpName, Nothing)
        End If

        If gender = "" Then
            err.SetError(txtEmpGender, "Please Enter [ Gender ] ")
            err.Tag = If(err.Tag, txtEmpGender)
        Else
            err.SetError(txtEmpGender, Nothing)
        End If

        If address = "" Then
            err.SetError(txtEmpAddr, "Please Enter [ Address ] ")
            err.Tag = If(err.Tag, txtEmpAddr)
        Else
            err.SetError(txtEmpAddr, Nothing)
        End If

        If country = "" Then
            err.SetError(txtCountry, "Please Enter [ Country ] ")
            err.Tag = If(err.Tag, txtCountry)
        Else
            err.SetError(txtCountry, Nothing)
        End If

        If position = "" Then
            err.SetError(txtEmpPosition, "Please Enter [ Employee Position ] ")
            err.Tag = If(err.Tag, txtEmpPosition)
        Else
            err.SetError(txtEmpPosition, Nothing)
        End If

        If salary = Nothing Then
            err.SetError(txtEmpSalary, "Please Enter [ Salary ] ")
            err.Tag = If(err.Tag, txtEmpSalary)
        Else
            err.SetError(txtEmpSalary, Nothing)
        End If

        If passport = Nothing Then
            err.SetError(txtEmpPassp, "Please Enter [ Passport ] ")
            err.Tag = If(err.Tag, txtEmpPassp)
        Else
            err.SetError(txtEmpSalary, Nothing)
        End If

        If ic = "" Then
            err.SetError(mskEmpIC, "Please Enter [ IC ] ")
            err.Tag = If(err.Tag, mskEmpIC)
        Else
            err.SetError(mskEmpIC, Nothing)
        End If

        If postcode = Nothing Then
            err.SetError(mskEmpPostcode, "Please Enter [ PostCode ] ")
            err.Tag = If(err.Tag, mskEmpPostcode)
        Else
            err.SetError(mskEmpPostcode, Nothing)
        End If

        If state = Nothing Then
            err.SetError(txtEmpState, "Please Enter [ State ] ")
            err.Tag = If(err.Tag, txtEmpState)
        Else
            err.SetError(txtEmpState, Nothing)
        End If

        If phone1 = Nothing Then
            err.SetError(txtPhone1, "Please Enter [ Phone No. 1 ] ")
            err.Tag = If(err.Tag, txtPhone1)
        Else
            err.SetError(txtPhone1, Nothing)
        End If

        If phone2 = Nothing Then
            err.SetError(txtPhone2, "Please Enter [ Phone No. 2 ] ")
            err.Tag = If(err.Tag, txtPhone2)
        Else
            err.SetError(txtPhone2, Nothing)
        End If

        If email = Nothing Then
            err.SetError(mskEmail, "Please Enter [ Email ] ")
            err.Tag = If(err.Tag, mskEmail)
        Else
            err.SetError(mskEmail, Nothing)
        End If

        If password = Nothing Then
            err.SetError(txtPassw, "Please Enter [ Password ] ")
            err.Tag = If(err.Tag, txtPassw)
        Else
            err.SetError(txtPassw, Nothing)
        End If

        If status = Nothing Then
            err.SetError(txtEmpStatus, "Please Enter [ Status ] ")
            err.Tag = If(err.Tag, txtEmpStatus)
        Else
            err.SetError(txtEmpStatus, Nothing)
        End If

    End Sub





End Class