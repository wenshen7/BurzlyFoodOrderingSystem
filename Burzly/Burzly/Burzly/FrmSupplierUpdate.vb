Imports System.IO
Imports System.Text

Public Class FrmSupplierUpdate
    Public selectedId As String
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim db As New BurzlyDataContext()
        Dim sp As Supplier = db.Suppliers.FirstOrDefault(Function(o) o.supId = selectedId)

        If sp Is Nothing Then
            MessageBox.Show("Supplier Details not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return
        End If
        txtSupID.Text = sp.supId
        txtSupName.Text = sp.supName
        txtSupCompanyName.Text = sp.supCompany
        txtSupDesc.Text = sp.supDescription
        txtSupAddr.Text = sp.supAddress
        txtSupState.Text = sp.supState
        mskSupPostcode.Text = CStr(sp.supPostcode)
        txtSupCountry.Text = sp.supCountry
        txtSupPhone1.Text = sp.supPhone1
        txtSupPhone2.Text = sp.supPhone2
        txtSupFax1.Text = sp.supFax1
        txtSupFax2.Text = sp.supFax2
        txtSupEmail.Text = sp.supEmail
        cboSupStatus.Text = sp.supStatus
        If sp.supImageName = "" Then
            PicBox.Load(Application.StartupPath & "\images\Supplier\Noimg.jpg")
        Else
            PicBox.Load(Application.StartupPath & "\images\Supplier\" & sp.supImageName)
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Supplier' table. You can move, or remove it, as needed.
        txtSupID.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim name As String = txtSupName.Text.Trim()
        Dim address As String = txtSupAddr.Text.Trim()
        Dim postcode As Integer = CInt(If(mskSupPostcode.MaskCompleted, mskSupPostcode.Text, "00000"))
        Dim country As String = txtSupCountry.Text.Trim()
        Dim phone As String = txtSupPhone1.Text.Trim()
        Dim status As String = cboSupStatus.Text.Trim()
        'Dim img As New ConnectImage(PicBox.Image)
        'img.Square()
        'img.Resize(150)

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
        s.supImageName = strFilename

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
    End Sub


    Private Sub SupIdLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
