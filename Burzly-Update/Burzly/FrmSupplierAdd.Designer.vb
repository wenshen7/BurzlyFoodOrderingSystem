<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SupStatusLabel1 As System.Windows.Forms.Label
        Dim SupPostcodeLabel1 As System.Windows.Forms.Label
        Dim SupIdLabel As System.Windows.Forms.Label
        Dim SupNameLabel As System.Windows.Forms.Label
        Dim SupCompanyLabel As System.Windows.Forms.Label
        Dim SupDescriptionLabel As System.Windows.Forms.Label
        Dim SupAddressLabel As System.Windows.Forms.Label
        Dim SupStateLabel As System.Windows.Forms.Label
        Dim SupCountryLabel As System.Windows.Forms.Label
        Dim SupPhone1Label As System.Windows.Forms.Label
        Dim SupPhone2Label As System.Windows.Forms.Label
        Dim SupFax1Label As System.Windows.Forms.Label
        Dim SupFax2Label As System.Windows.Forms.Label
        Dim SupEmailLabel As System.Windows.Forms.Label
        Dim SupImageNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplierAdd))
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OdlgSupPic = New System.Windows.Forms.OpenFileDialog()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.mskSupPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.cboSupStatus = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSupID = New System.Windows.Forms.TextBox()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.txtSupCompanyName = New System.Windows.Forms.TextBox()
        Me.txtSupDesc = New System.Windows.Forms.TextBox()
        Me.txtSupAddr = New System.Windows.Forms.TextBox()
        Me.txtSupState = New System.Windows.Forms.TextBox()
        Me.txtSupCountry = New System.Windows.Forms.TextBox()
        Me.txtSupPhone1 = New System.Windows.Forms.TextBox()
        Me.txtSupPhone2 = New System.Windows.Forms.TextBox()
        Me.txtSupFax1 = New System.Windows.Forms.TextBox()
        Me.txtSupFax2 = New System.Windows.Forms.TextBox()
        Me.txtSupEmail = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEditID = New System.Windows.Forms.Button()
        SupStatusLabel1 = New System.Windows.Forms.Label()
        SupPostcodeLabel1 = New System.Windows.Forms.Label()
        SupIdLabel = New System.Windows.Forms.Label()
        SupNameLabel = New System.Windows.Forms.Label()
        SupCompanyLabel = New System.Windows.Forms.Label()
        SupDescriptionLabel = New System.Windows.Forms.Label()
        SupAddressLabel = New System.Windows.Forms.Label()
        SupStateLabel = New System.Windows.Forms.Label()
        SupCountryLabel = New System.Windows.Forms.Label()
        SupPhone1Label = New System.Windows.Forms.Label()
        SupPhone2Label = New System.Windows.Forms.Label()
        SupFax1Label = New System.Windows.Forms.Label()
        SupFax2Label = New System.Windows.Forms.Label()
        SupEmailLabel = New System.Windows.Forms.Label()
        SupImageNameLabel = New System.Windows.Forms.Label()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupStatusLabel1
        '
        SupStatusLabel1.AutoSize = True
        SupStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupStatusLabel1.Location = New System.Drawing.Point(118, 562)
        SupStatusLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupStatusLabel1.Name = "SupStatusLabel1"
        SupStatusLabel1.Size = New System.Drawing.Size(205, 29)
        SupStatusLabel1.TabIndex = 86
        SupStatusLabel1.Text = "Supplier Status :"
        '
        'SupPostcodeLabel1
        '
        SupPostcodeLabel1.AutoSize = True
        SupPostcodeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPostcodeLabel1.Location = New System.Drawing.Point(86, 278)
        SupPostcodeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupPostcodeLabel1.Name = "SupPostcodeLabel1"
        SupPostcodeLabel1.Size = New System.Drawing.Size(243, 29)
        SupPostcodeLabel1.TabIndex = 84
        SupPostcodeLabel1.Text = "Supplier Postcode :"
        '
        'SupIdLabel
        '
        SupIdLabel.AutoSize = True
        SupIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupIdLabel.Location = New System.Drawing.Point(171, 40)
        SupIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupIdLabel.Name = "SupIdLabel"
        SupIdLabel.Size = New System.Drawing.Size(165, 29)
        SupIdLabel.TabIndex = 50
        SupIdLabel.Text = "Supplier ID : "
        '
        'SupNameLabel
        '
        SupNameLabel.AutoSize = True
        SupNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupNameLabel.Location = New System.Drawing.Point(129, 78)
        SupNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupNameLabel.Name = "SupNameLabel"
        SupNameLabel.Size = New System.Drawing.Size(202, 29)
        SupNameLabel.TabIndex = 52
        SupNameLabel.Text = "Supplier Name :"
        '
        'SupCompanyLabel
        '
        SupCompanyLabel.AutoSize = True
        SupCompanyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupCompanyLabel.Location = New System.Drawing.Point(10, 115)
        SupCompanyLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupCompanyLabel.Name = "SupCompanyLabel"
        SupCompanyLabel.Size = New System.Drawing.Size(318, 29)
        SupCompanyLabel.TabIndex = 54
        SupCompanyLabel.Text = "Supplier Company Name :"
        '
        'SupDescriptionLabel
        '
        SupDescriptionLabel.AutoSize = True
        SupDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupDescriptionLabel.Location = New System.Drawing.Point(62, 157)
        SupDescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupDescriptionLabel.Name = "SupDescriptionLabel"
        SupDescriptionLabel.Size = New System.Drawing.Size(266, 29)
        SupDescriptionLabel.TabIndex = 56
        SupDescriptionLabel.Text = "Supplier Description :"
        '
        'SupAddressLabel
        '
        SupAddressLabel.AutoSize = True
        SupAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupAddressLabel.Location = New System.Drawing.Point(99, 197)
        SupAddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupAddressLabel.Name = "SupAddressLabel"
        SupAddressLabel.Size = New System.Drawing.Size(229, 29)
        SupAddressLabel.TabIndex = 58
        SupAddressLabel.Text = "Supplier Address :"
        '
        'SupStateLabel
        '
        SupStateLabel.AutoSize = True
        SupStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupStateLabel.Location = New System.Drawing.Point(132, 237)
        SupStateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupStateLabel.Name = "SupStateLabel"
        SupStateLabel.Size = New System.Drawing.Size(193, 29)
        SupStateLabel.TabIndex = 60
        SupStateLabel.Text = "Supplier State :"
        '
        'SupCountryLabel
        '
        SupCountryLabel.AutoSize = True
        SupCountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupCountryLabel.Location = New System.Drawing.Point(105, 317)
        SupCountryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupCountryLabel.Name = "SupCountryLabel"
        SupCountryLabel.Size = New System.Drawing.Size(222, 29)
        SupCountryLabel.TabIndex = 62
        SupCountryLabel.Text = "Supplier Country :"
        '
        'SupPhone1Label
        '
        SupPhone1Label.AutoSize = True
        SupPhone1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPhone1Label.Location = New System.Drawing.Point(99, 357)
        SupPhone1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupPhone1Label.Name = "SupPhone1Label"
        SupPhone1Label.Size = New System.Drawing.Size(229, 29)
        SupPhone1Label.TabIndex = 64
        SupPhone1Label.Text = "Supplier Phone 1 :"
        '
        'SupPhone2Label
        '
        SupPhone2Label.AutoSize = True
        SupPhone2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPhone2Label.Location = New System.Drawing.Point(99, 397)
        SupPhone2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupPhone2Label.Name = "SupPhone2Label"
        SupPhone2Label.Size = New System.Drawing.Size(229, 29)
        SupPhone2Label.TabIndex = 66
        SupPhone2Label.Text = "Supplier Phone 2 :"
        '
        'SupFax1Label
        '
        SupFax1Label.AutoSize = True
        SupFax1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupFax1Label.Location = New System.Drawing.Point(132, 437)
        SupFax1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupFax1Label.Name = "SupFax1Label"
        SupFax1Label.Size = New System.Drawing.Size(196, 29)
        SupFax1Label.TabIndex = 68
        SupFax1Label.Text = "Supplier Fax 1 :"
        '
        'SupFax2Label
        '
        SupFax2Label.AutoSize = True
        SupFax2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupFax2Label.Location = New System.Drawing.Point(132, 477)
        SupFax2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupFax2Label.Name = "SupFax2Label"
        SupFax2Label.Size = New System.Drawing.Size(196, 29)
        SupFax2Label.TabIndex = 70
        SupFax2Label.Text = "Supplier Fax 2 :"
        '
        'SupEmailLabel
        '
        SupEmailLabel.AutoSize = True
        SupEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupEmailLabel.Location = New System.Drawing.Point(132, 517)
        SupEmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupEmailLabel.Name = "SupEmailLabel"
        SupEmailLabel.Size = New System.Drawing.Size(199, 29)
        SupEmailLabel.TabIndex = 72
        SupEmailLabel.Text = "Supplier Email :"
        '
        'SupImageNameLabel
        '
        SupImageNameLabel.AutoSize = True
        SupImageNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupImageNameLabel.Location = New System.Drawing.Point(792, 29)
        SupImageNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SupImageNameLabel.Name = "SupImageNameLabel"
        SupImageNameLabel.Size = New System.Drawing.Size(191, 29)
        SupImageNameLabel.TabIndex = 74
        SupImageNameLabel.Text = "Supplier Image"
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.err.ContainerControl = Me
        '
        'OdlgSupPic
        '
        Me.OdlgSupPic.FileName = """"""
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(644, 620)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(138, 49)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'mskSupPostcode
        '
        Me.mskSupPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSupPostcode.Location = New System.Drawing.Point(351, 277)
        Me.mskSupPostcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mskSupPostcode.Mask = "00000"
        Me.mskSupPostcode.Name = "mskSupPostcode"
        Me.mskSupPostcode.Size = New System.Drawing.Size(96, 35)
        Me.mskSupPostcode.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(824, 618)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 51)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtImagePath
        '
        Me.txtImagePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Location = New System.Drawing.Point(801, 278)
        Me.txtImagePath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Size = New System.Drawing.Size(184, 28)
        Me.txtImagePath.TabIndex = 89
        '
        'cboSupStatus
        '
        Me.cboSupStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupStatus.FormattingEnabled = True
        Me.cboSupStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cboSupStatus.Location = New System.Drawing.Point(351, 557)
        Me.cboSupStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSupStatus.Name = "cboSupStatus"
        Me.cboSupStatus.Size = New System.Drawing.Size(180, 37)
        Me.cboSupStatus.TabIndex = 13
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(828, 312)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(135, 42)
        Me.btnBrowse.TabIndex = 24
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(801, 78)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(185, 197)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 85
        Me.PicBox.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(575, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(112, 42)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(299, 618)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 54)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.CausesValidation = False
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(123, 620)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 49)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSupID
        '
        Me.txtSupID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupID.Location = New System.Drawing.Point(351, 31)
        Me.txtSupID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupID.Name = "txtSupID"
        Me.txtSupID.Size = New System.Drawing.Size(96, 35)
        Me.txtSupID.TabIndex = 51
        '
        'txtSupName
        '
        Me.txtSupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupName.Location = New System.Drawing.Point(351, 77)
        Me.txtSupName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(418, 35)
        Me.txtSupName.TabIndex = 1
        '
        'txtSupCompanyName
        '
        Me.txtSupCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCompanyName.Location = New System.Drawing.Point(351, 117)
        Me.txtSupCompanyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupCompanyName.Name = "txtSupCompanyName"
        Me.txtSupCompanyName.Size = New System.Drawing.Size(418, 35)
        Me.txtSupCompanyName.TabIndex = 2
        '
        'txtSupDesc
        '
        Me.txtSupDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupDesc.Location = New System.Drawing.Point(351, 157)
        Me.txtSupDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupDesc.Name = "txtSupDesc"
        Me.txtSupDesc.Size = New System.Drawing.Size(418, 35)
        Me.txtSupDesc.TabIndex = 3
        '
        'txtSupAddr
        '
        Me.txtSupAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupAddr.Location = New System.Drawing.Point(351, 197)
        Me.txtSupAddr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupAddr.Name = "txtSupAddr"
        Me.txtSupAddr.Size = New System.Drawing.Size(418, 35)
        Me.txtSupAddr.TabIndex = 4
        '
        'txtSupState
        '
        Me.txtSupState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupState.Location = New System.Drawing.Point(351, 237)
        Me.txtSupState.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupState.Name = "txtSupState"
        Me.txtSupState.Size = New System.Drawing.Size(308, 35)
        Me.txtSupState.TabIndex = 5
        '
        'txtSupCountry
        '
        Me.txtSupCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCountry.Location = New System.Drawing.Point(351, 317)
        Me.txtSupCountry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupCountry.Name = "txtSupCountry"
        Me.txtSupCountry.Size = New System.Drawing.Size(308, 35)
        Me.txtSupCountry.TabIndex = 7
        '
        'txtSupPhone1
        '
        Me.txtSupPhone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupPhone1.Location = New System.Drawing.Point(351, 357)
        Me.txtSupPhone1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupPhone1.Name = "txtSupPhone1"
        Me.txtSupPhone1.Size = New System.Drawing.Size(180, 35)
        Me.txtSupPhone1.TabIndex = 8
        '
        'txtSupPhone2
        '
        Me.txtSupPhone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupPhone2.Location = New System.Drawing.Point(351, 397)
        Me.txtSupPhone2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupPhone2.Name = "txtSupPhone2"
        Me.txtSupPhone2.Size = New System.Drawing.Size(180, 35)
        Me.txtSupPhone2.TabIndex = 9
        '
        'txtSupFax1
        '
        Me.txtSupFax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupFax1.Location = New System.Drawing.Point(351, 437)
        Me.txtSupFax1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupFax1.Name = "txtSupFax1"
        Me.txtSupFax1.Size = New System.Drawing.Size(180, 35)
        Me.txtSupFax1.TabIndex = 10
        '
        'txtSupFax2
        '
        Me.txtSupFax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupFax2.Location = New System.Drawing.Point(351, 477)
        Me.txtSupFax2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupFax2.Name = "txtSupFax2"
        Me.txtSupFax2.Size = New System.Drawing.Size(180, 35)
        Me.txtSupFax2.TabIndex = 11
        '
        'txtSupEmail
        '
        Me.txtSupEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupEmail.Location = New System.Drawing.Point(351, 517)
        Me.txtSupEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupEmail.Name = "txtSupEmail"
        Me.txtSupEmail.Size = New System.Drawing.Size(308, 35)
        Me.txtSupEmail.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(472, 618)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 52)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEditID
        '
        Me.btnEditID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditID.Location = New System.Drawing.Point(455, 27)
        Me.btnEditID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditID.Name = "btnEditID"
        Me.btnEditID.Size = New System.Drawing.Size(112, 42)
        Me.btnEditID.TabIndex = 90
        Me.btnEditID.Text = "&Edit ID"
        Me.btnEditID.UseVisualStyleBackColor = True
        '
        'FrmSupplierAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1060, 758)
        Me.Controls.Add(Me.btnEditID)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.mskSupPostcode)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(SupStatusLabel1)
        Me.Controls.Add(Me.cboSupStatus)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(SupPostcodeLabel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(SupIdLabel)
        Me.Controls.Add(Me.txtSupID)
        Me.Controls.Add(SupNameLabel)
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(SupCompanyLabel)
        Me.Controls.Add(Me.txtSupCompanyName)
        Me.Controls.Add(SupDescriptionLabel)
        Me.Controls.Add(Me.txtSupDesc)
        Me.Controls.Add(SupAddressLabel)
        Me.Controls.Add(Me.txtSupAddr)
        Me.Controls.Add(SupStateLabel)
        Me.Controls.Add(Me.txtSupState)
        Me.Controls.Add(SupCountryLabel)
        Me.Controls.Add(Me.txtSupCountry)
        Me.Controls.Add(SupPhone1Label)
        Me.Controls.Add(Me.txtSupPhone1)
        Me.Controls.Add(SupPhone2Label)
        Me.Controls.Add(Me.txtSupPhone2)
        Me.Controls.Add(SupFax1Label)
        Me.Controls.Add(Me.txtSupFax1)
        Me.Controls.Add(SupFax2Label)
        Me.Controls.Add(Me.txtSupFax2)
        Me.Controls.Add(SupEmailLabel)
        Me.Controls.Add(Me.txtSupEmail)
        Me.Controls.Add(SupImageNameLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSupplierAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Details"
        CType(Me.err,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicBox,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents mskSupPostcode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtImagePath As System.Windows.Forms.TextBox
    Friend WithEvents cboSupStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSupID As System.Windows.Forms.TextBox
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtSupAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtSupState As System.Windows.Forms.TextBox
    Friend WithEvents txtSupCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtSupPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupFax1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupFax2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupEmail As System.Windows.Forms.TextBox
    Friend WithEvents OdlgSupPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEditID As System.Windows.Forms.Button
End Class
