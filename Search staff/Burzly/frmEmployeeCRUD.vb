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