<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplierUpdate))
        Me.btnReset = New System.Windows.Forms.Button()
        Me.OdlgSupPic = New System.Windows.Forms.OpenFileDialog()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtImagePath = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.mskSupPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.cboSupStatus = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSupAddr = New System.Windows.Forms.TextBox()
        Me.txtSupState = New System.Windows.Forms.TextBox()
        Me.txtSupCountry = New System.Windows.Forms.TextBox()
        Me.txtSupPhone1 = New System.Windows.Forms.TextBox()
        Me.txtSupPhone2 = New System.Windows.Forms.TextBox()
        Me.txtSupFax1 = New System.Windows.Forms.TextBox()
        Me.txtSupFax2 = New System.Windows.Forms.TextBox()
        Me.txtSupEmail = New System.Windows.Forms.TextBox()
        Me.txtSupID = New System.Windows.Forms.TextBox()
        Me.txtSupName = New System.Windows.Forms.TextBox()
        Me.txtSupCompanyName = New System.Windows.Forms.TextBox()
        Me.txtSupDesc = New System.Windows.Forms.TextBox()
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
        SupStatusLabel1.Location = New System.Drawing.Point(89, 363)
        SupStatusLabel1.Name = "SupStatusLabel1"
        SupStatusLabel1.Size = New System.Drawing.Size(143, 20)
        SupStatusLabel1.TabIndex = 119
        SupStatusLabel1.Text = "Supplier Status :"
        '
        'SupPostcodeLabel1
        '
        SupPostcodeLabel1.AutoSize = True
        SupPostcodeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPostcodeLabel1.Location = New System.Drawing.Point(65, 179)
        SupPostcodeLabel1.Name = "SupPostcodeLabel1"
        SupPostcodeLabel1.Size = New System.Drawing.Size(165, 20)
        SupPostcodeLabel1.TabIndex = 116
        SupPostcodeLabel1.Text = "Supplier Postcode :"
        '
        'SupIdLabel
        '
        SupIdLabel.AutoSize = True
        SupIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupIdLabel.Location = New System.Drawing.Point(123, 21)
        SupIdLabel.Name = "SupIdLabel"
        SupIdLabel.Size = New System.Drawing.Size(109, 20)
        SupIdLabel.TabIndex = 89
        SupIdLabel.Text = "Supplier ID :"
        AddHandler SupIdLabel.Click, AddressOf Me.SupIdLabel_Click
        '
        'SupNameLabel
        '
        SupNameLabel.AutoSize = True
        SupNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupNameLabel.Location = New System.Drawing.Point(96, 50)
        SupNameLabel.Name = "SupNameLabel"
        SupNameLabel.Size = New System.Drawing.Size(136, 20)
        SupNameLabel.TabIndex = 91
        SupNameLabel.Text = "Supplier Name :"
        '
        'SupCompanyLabel
        '
        SupCompanyLabel.AutoSize = True
        SupCompanyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupCompanyLabel.Location = New System.Drawing.Point(17, 73)
        SupCompanyLabel.Name = "SupCompanyLabel"
        SupCompanyLabel.Size = New System.Drawing.Size(215, 20)
        SupCompanyLabel.TabIndex = 93
        SupCompanyLabel.Text = "Supplier Company Name :"
        '
        'SupDescriptionLabel
        '
        SupDescriptionLabel.AutoSize = True
        SupDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupDescriptionLabel.Location = New System.Drawing.Point(51, 99)
        SupDescriptionLabel.Name = "SupDescriptionLabel"
        SupDescriptionLabel.Size = New System.Drawing.Size(181, 20)
        SupDescriptionLabel.TabIndex = 95
        SupDescriptionLabel.Text = "Supplier Description :"
        '
        'SupAddressLabel
        '
        SupAddressLabel.AutoSize = True
        SupAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupAddressLabel.Location = New System.Drawing.Point(76, 125)
        SupAddressLabel.Name = "SupAddressLabel"
        SupAddressLabel.Size = New System.Drawing.Size(156, 20)
        SupAddressLabel.TabIndex = 97
        SupAddressLabel.Text = "Supplier Address :"
        '
        'SupStateLabel
        '
        SupStateLabel.AutoSize = True
        SupStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupStateLabel.Location = New System.Drawing.Point(96, 151)
        SupStateLabel.Name = "SupStateLabel"
        SupStateLabel.Size = New System.Drawing.Size(134, 20)
        SupStateLabel.TabIndex = 99
        SupStateLabel.Text = "Supplier State :"
        '
        'SupCountryLabel
        '
        SupCountryLabel.AutoSize = True
        SupCountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupCountryLabel.Location = New System.Drawing.Point(78, 203)
        SupCountryLabel.Name = "SupCountryLabel"
        SupCountryLabel.Size = New System.Drawing.Size(152, 20)
        SupCountryLabel.TabIndex = 101
        SupCountryLabel.Text = "Supplier Country :"
        '
        'SupPhone1Label
        '
        SupPhone1Label.AutoSize = True
        SupPhone1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPhone1Label.Location = New System.Drawing.Point(74, 229)
        SupPhone1Label.Name = "SupPhone1Label"
        SupPhone1Label.Size = New System.Drawing.Size(156, 20)
        SupPhone1Label.TabIndex = 103
        SupPhone1Label.Text = "Supplier Phone 1 :"
        '
        'SupPhone2Label
        '
        SupPhone2Label.AutoSize = True
        SupPhone2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupPhone2Label.Location = New System.Drawing.Point(74, 255)
        SupPhone2Label.Name = "SupPhone2Label"
        SupPhone2Label.Size = New System.Drawing.Size(156, 20)
        SupPhone2Label.TabIndex = 105
        SupPhone2Label.Text = "Supplier Phone 2 :"
        '
        'SupFax1Label
        '
        SupFax1Label.AutoSize = True
        SupFax1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupFax1Label.Location = New System.Drawing.Point(96, 284)
        SupFax1Label.Name = "SupFax1Label"
        SupFax1Label.Size = New System.Drawing.Size(134, 20)
        SupFax1Label.TabIndex = 107
        SupFax1Label.Text = "Supplier Fax 1 :"
        '
        'SupFax2Label
        '
        SupFax2Label.AutoSize = True
        SupFax2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupFax2Label.Location = New System.Drawing.Point(98, 310)
        SupFax2Label.Name = "SupFax2Label"
        SupFax2Label.Size = New System.Drawing.Size(134, 20)
        SupFax2Label.TabIndex = 109
        SupFax2Label.Text = "Supplier Fax 2 :"
        '
        'SupEmailLabel
        '
        SupEmailLabel.AutoSize = True
        SupEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupEmailLabel.Location = New System.Drawing.Point(98, 336)
        SupEmailLabel.Name = "SupEmailLabel"
        SupEmailLabel.Size = New System.Drawing.Size(134, 20)
        SupEmailLabel.TabIndex = 111
        SupEmailLabel.Text = "Supplier Email :"
        '
        'SupImageNameLabel
        '
        SupImageNameLabel.AutoSize = True
        SupImageNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SupImageNameLabel.Location = New System.Drawing.Point(555, 21)
        SupImageNameLabel.Name = "SupImageNameLabel"
        SupImageNameLabel.Size = New System.Drawing.Size(130, 20)
        SupImageNameLabel.TabIndex = 113
        SupImageNameLabel.Text = "Supplier Image"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(624, 316)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'OdlgSupPic
        '
        Me.OdlgSupPic.FileName = """"""
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(623, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtImagePath
        '
        Me.txtImagePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagePath.Location = New System.Drawing.Point(559, 179)
        Me.txtImagePath.Name = "txtImagePath"
        Me.txtImagePath.Size = New System.Drawing.Size(124, 21)
        Me.txtImagePath.TabIndex = 122
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.err.ContainerControl = Me
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(579, 204)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(86, 30)
        Me.btnBrowse.TabIndex = 14
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(559, 49)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(124, 129)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 118
        Me.PicBox.TabStop = False
        '
        'mskSupPostcode
        '
        Me.mskSupPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskSupPostcode.Location = New System.Drawing.Point(249, 177)
        Me.mskSupPostcode.Mask = "00000"
        Me.mskSupPostcode.Name = "mskSupPostcode"
        Me.mskSupPostcode.Size = New System.Drawing.Size(71, 26)
        Me.mskSupPostcode.TabIndex = 6
        '
        'cboSupStatus
        '
        Me.cboSupStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupStatus.FormattingEnabled = True
        Me.cboSupStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cboSupStatus.Location = New System.Drawing.Point(249, 359)
        Me.cboSupStatus.Name = "cboSupStatus"
        Me.cboSupStatus.Size = New System.Drawing.Size(121, 28)
        Me.cboSupStatus.TabIndex = 13
        '
        'btnDelete
        '
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(527, 357)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 34)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(527, 316)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtSupAddr
        '
        Me.txtSupAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupAddr.Location = New System.Drawing.Point(249, 125)
        Me.txtSupAddr.Name = "txtSupAddr"
        Me.txtSupAddr.Size = New System.Drawing.Size(280, 26)
        Me.txtSupAddr.TabIndex = 4
        '
        'txtSupState
        '
        Me.txtSupState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupState.Location = New System.Drawing.Point(249, 151)
        Me.txtSupState.Name = "txtSupState"
        Me.txtSupState.Size = New System.Drawing.Size(207, 26)
        Me.txtSupState.TabIndex = 5
        '
        'txtSupCountry
        '
        Me.txtSupCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCountry.Location = New System.Drawing.Point(249, 203)
        Me.txtSupCountry.Name = "txtSupCountry"
        Me.txtSupCountry.Size = New System.Drawing.Size(207, 26)
        Me.txtSupCountry.TabIndex = 7
        '
        'txtSupPhone1
        '
        Me.txtSupPhone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupPhone1.Location = New System.Drawing.Point(249, 229)
        Me.txtSupPhone1.Name = "txtSupPhone1"
        Me.txtSupPhone1.Size = New System.Drawing.Size(121, 26)
        Me.txtSupPhone1.TabIndex = 8
        '
        'txtSupPhone2
        '
        Me.txtSupPhone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupPhone2.Location = New System.Drawing.Point(249, 255)
        Me.txtSupPhone2.Name = "txtSupPhone2"
        Me.txtSupPhone2.Size = New System.Drawing.Size(121, 26)
        Me.txtSupPhone2.TabIndex = 9
        '
        'txtSupFax1
        '
        Me.txtSupFax1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupFax1.Location = New System.Drawing.Point(249, 281)
        Me.txtSupFax1.Name = "txtSupFax1"
        Me.txtSupFax1.Size = New System.Drawing.Size(121, 26)
        Me.txtSupFax1.TabIndex = 10
        '
        'txtSupFax2
        '
        Me.txtSupFax2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupFax2.Location = New System.Drawing.Point(249, 307)
        Me.txtSupFax2.Name = "txtSupFax2"
        Me.txtSupFax2.Size = New System.Drawing.Size(121, 26)
        Me.txtSupFax2.TabIndex = 11
        '
        'txtSupEmail
        '
        Me.txtSupEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupEmail.Location = New System.Drawing.Point(249, 333)
        Me.txtSupEmail.Name = "txtSupEmail"
        Me.txtSupEmail.Size = New System.Drawing.Size(207, 26)
        Me.txtSupEmail.TabIndex = 12
        '
        'txtSupID
        '
        Me.txtSupID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupID.Location = New System.Drawing.Point(249, 17)
        Me.txtSupID.Name = "txtSupID"
        Me.txtSupID.Size = New System.Drawing.Size(71, 26)
        Me.txtSupID.TabIndex = 90
        '
        'txtSupName
        '
        Me.txtSupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupName.Location = New System.Drawing.Point(249, 47)
        Me.txtSupName.Name = "txtSupName"
        Me.txtSupName.Size = New System.Drawing.Size(280, 26)
        Me.txtSupName.TabIndex = 1
        '
        'txtSupCompanyName
        '
        Me.txtSupCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupCompanyName.Location = New System.Drawing.Point(249, 73)
        Me.txtSupCompanyName.Name = "txtSupCompanyName"
        Me.txtSupCompanyName.Size = New System.Drawing.Size(280, 26)
        Me.txtSupCompanyName.TabIndex = 2
        '
        'txtSupDesc
        '
        Me.txtSupDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupDesc.Location = New System.Drawing.Point(249, 99)
        Me.txtSupDesc.Name = "txtSupDesc"
        Me.txtSupDesc.Size = New System.Drawing.Size(280, 26)
        Me.txtSupDesc.TabIndex = 3
        '
        'FrmSupplierUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(733, 413)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtImagePath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.mskSupPostcode)
        Me.Controls.Add(SupStatusLabel1)
        Me.Controls.Add(Me.cboSupStatus)
        Me.Controls.Add(SupPostcodeLabel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(SupIdLabel)
        Me.Controls.Add(SupNameLabel)
        Me.Controls.Add(SupCompanyLabel)
        Me.Controls.Add(SupDescriptionLabel)
        Me.Controls.Add(SupAddressLabel)
        Me.Controls.Add(Me.txtSupAddr)
        Me.Controls.Add(SupStateLabel)
        Me.Controls.Add(SupCountryLabel)
        Me.Controls.Add(SupPhone1Label)
        Me.Controls.Add(SupPhone2Label)
        Me.Controls.Add(SupFax1Label)
        Me.Controls.Add(SupFax2Label)
        Me.Controls.Add(SupEmailLabel)
        Me.Controls.Add(SupImageNameLabel)
        Me.Controls.Add(Me.txtSupState)
        Me.Controls.Add(Me.txtSupCountry)
        Me.Controls.Add(Me.txtSupPhone1)
        Me.Controls.Add(Me.txtSupPhone2)
        Me.Controls.Add(Me.txtSupFax1)
        Me.Controls.Add(Me.txtSupFax2)
        Me.Controls.Add(Me.txtSupEmail)
        Me.Controls.Add(Me.txtSupID)
        Me.Controls.Add(Me.txtSupName)
        Me.Controls.Add(Me.txtSupCompanyName)
        Me.Controls.Add(Me.txtSupDesc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSupplierUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Supplier Details"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents OdlgSupPic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtImagePath As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents mskSupPostcode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSupStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtSupAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtSupState As System.Windows.Forms.TextBox
    Friend WithEvents txtSupCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtSupPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupFax1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupFax2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSupEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtSupID As System.Windows.Forms.TextBox
    Friend WithEvents txtSupName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtSupDesc As System.Windows.Forms.TextBox
End Class
