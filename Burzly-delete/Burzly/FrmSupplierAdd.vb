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

 
    Private Sub resetButtonToDefault()
        btnSearch.Enabled = True
       
        btnReset.Enabled = False

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
         
            btnSearch.Enabled = False

            btnReset.Enabled = False

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


    Private Sub SupIdLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
