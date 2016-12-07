<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeCRUD
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
        Dim EmpIdLabel As System.Windows.Forms.Label
        Dim EmpNameLabel As System.Windows.Forms.Label
        Dim EmpICLabel As System.Windows.Forms.Label
        Dim EmpPassportLabel As System.Windows.Forms.Label
        Dim EmpDOBLabel As System.Windows.Forms.Label
        Dim EmpGenderLabel As System.Windows.Forms.Label
        Dim EmpAddressLabel As System.Windows.Forms.Label
        Dim EmpStateLabel As System.Windows.Forms.Label
        Dim EmpPostcodeLabel As System.Windows.Forms.Label
        Dim EmpCountryLabel As System.Windows.Forms.Label
        Dim EmpPhone1Label As System.Windows.Forms.Label
        Dim EmpPhone2Label As System.Windows.Forms.Label
        Dim EmpEmailLabel As System.Windows.Forms.Label
        Dim EmpPasswordLabel As System.Windows.Forms.Label
        Dim EmpPositionLabel As System.Windows.Forms.Label
        Dim EmpSalaryLabel As System.Windows.Forms.Label
        Dim EmpStatusLabel As System.Windows.Forms.Label
        Dim EmpImageNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeCRUD))
        Me.btnBrowsePic = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picEmp = New System.Windows.Forms.PictureBox()
        Me.BurzlyDBDataSet = New Burzly.BurzlyDBDataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Burzly.BurzlyDBDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.mskEmpIC = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmpPassp = New System.Windows.Forms.TextBox()
        Me.EmpDOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpGender = New System.Windows.Forms.TextBox()
        Me.txtEmpAddr = New System.Windows.Forms.TextBox()
        Me.txtEmpState = New System.Windows.Forms.TextBox()
        Me.mskEmpPostcode = New System.Windows.Forms.MaskedTextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtPhone1 = New System.Windows.Forms.TextBox()
        Me.txtPhone2 = New System.Windows.Forms.TextBox()
        Me.mskEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtPassw = New System.Windows.Forms.TextBox()
        Me.txtEmpPosition = New System.Windows.Forms.TextBox()
        Me.txtEmpSalary = New System.Windows.Forms.TextBox()
        Me.txtEmpStatus = New System.Windows.Forms.TextBox()
        Me.txtEmpImageName = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        EmpIdLabel = New System.Windows.Forms.Label()
        EmpNameLabel = New System.Windows.Forms.Label()
        EmpICLabel = New System.Windows.Forms.Label()
        EmpPassportLabel = New System.Windows.Forms.Label()
        EmpDOBLabel = New System.Windows.Forms.Label()
        EmpGenderLabel = New System.Windows.Forms.Label()
        EmpAddressLabel = New System.Windows.Forms.Label()
        EmpStateLabel = New System.Windows.Forms.Label()
        EmpPostcodeLabel = New System.Windows.Forms.Label()
        EmpCountryLabel = New System.Windows.Forms.Label()
        EmpPhone1Label = New System.Windows.Forms.Label()
        EmpPhone2Label = New System.Windows.Forms.Label()
        EmpEmailLabel = New System.Windows.Forms.Label()
        EmpPasswordLabel = New System.Windows.Forms.Label()
        EmpPositionLabel = New System.Windows.Forms.Label()
        EmpSalaryLabel = New System.Windows.Forms.Label()
        EmpStatusLabel = New System.Windows.Forms.Label()
        EmpImageNameLabel = New System.Windows.Forms.Label()
        CType(Me.picEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpIdLabel
        '
        EmpIdLabel.AutoSize = True
        EmpIdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpIdLabel.Location = New System.Drawing.Point(11, 44)
        EmpIdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpIdLabel.Name = "EmpIdLabel"
        EmpIdLabel.Size = New System.Drawing.Size(105, 18)
        EmpIdLabel.TabIndex = 53
        EmpIdLabel.Text = "Employee Id:"
        '
        'EmpNameLabel
        '
        EmpNameLabel.AutoSize = True
        EmpNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpNameLabel.Location = New System.Drawing.Point(11, 80)
        EmpNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpNameLabel.Name = "EmpNameLabel"
        EmpNameLabel.Size = New System.Drawing.Size(136, 18)
        EmpNameLabel.TabIndex = 55
        EmpNameLabel.Text = "Employee Name:"
        '
        'EmpICLabel
        '
        EmpICLabel.AutoSize = True
        EmpICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpICLabel.Location = New System.Drawing.Point(11, 112)
        EmpICLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpICLabel.Name = "EmpICLabel"
        EmpICLabel.Size = New System.Drawing.Size(108, 18)
        EmpICLabel.TabIndex = 57
        EmpICLabel.Text = "Employee IC:"
        '
        'EmpPassportLabel
        '
        EmpPassportLabel.AutoSize = True
        EmpPassportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPassportLabel.Location = New System.Drawing.Point(11, 145)
        EmpPassportLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPassportLabel.Name = "EmpPassportLabel"
        EmpPassportLabel.Size = New System.Drawing.Size(160, 18)
        EmpPassportLabel.TabIndex = 59
        EmpPassportLabel.Text = "Employee Passport:"
        '
        'EmpDOBLabel
        '
        EmpDOBLabel.AutoSize = True
        EmpDOBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpDOBLabel.Location = New System.Drawing.Point(11, 180)
        EmpDOBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpDOBLabel.Name = "EmpDOBLabel"
        EmpDOBLabel.Size = New System.Drawing.Size(128, 18)
        EmpDOBLabel.TabIndex = 61
        EmpDOBLabel.Text = "Employee DOB:"
        '
        'EmpGenderLabel
        '
        EmpGenderLabel.AutoSize = True
        EmpGenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpGenderLabel.Location = New System.Drawing.Point(11, 213)
        EmpGenderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpGenderLabel.Name = "EmpGenderLabel"
        EmpGenderLabel.Size = New System.Drawing.Size(147, 18)
        EmpGenderLabel.TabIndex = 63
        EmpGenderLabel.Text = "Employee Gender:"
        '
        'EmpAddressLabel
        '
        EmpAddressLabel.AutoSize = True
        EmpAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpAddressLabel.Location = New System.Drawing.Point(11, 247)
        EmpAddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpAddressLabel.Name = "EmpAddressLabel"
        EmpAddressLabel.Size = New System.Drawing.Size(153, 18)
        EmpAddressLabel.TabIndex = 65
        EmpAddressLabel.Text = "Employee Address:"
        '
        'EmpStateLabel
        '
        EmpStateLabel.AutoSize = True
        EmpStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpStateLabel.Location = New System.Drawing.Point(11, 281)
        EmpStateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpStateLabel.Name = "EmpStateLabel"
        EmpStateLabel.Size = New System.Drawing.Size(131, 18)
        EmpStateLabel.TabIndex = 67
        EmpStateLabel.Text = "Employee State:"
        '
        'EmpPostcodeLabel
        '
        EmpPostcodeLabel.AutoSize = True
        EmpPostcodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPostcodeLabel.Location = New System.Drawing.Point(11, 315)
        EmpPostcodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPostcodeLabel.Name = "EmpPostcodeLabel"
        EmpPostcodeLabel.Size = New System.Drawing.Size(164, 18)
        EmpPostcodeLabel.TabIndex = 69
        EmpPostcodeLabel.Text = "Employee Postcode:"
        '
        'EmpCountryLabel
        '
        EmpCountryLabel.AutoSize = True
        EmpCountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpCountryLabel.Location = New System.Drawing.Point(11, 349)
        EmpCountryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpCountryLabel.Name = "EmpCountryLabel"
        EmpCountryLabel.Size = New System.Drawing.Size(151, 18)
        EmpCountryLabel.TabIndex = 71
        EmpCountryLabel.Text = "Employee Country:"
        '
        'EmpPhone1Label
        '
        EmpPhone1Label.AutoSize = True
        EmpPhone1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPhone1Label.Location = New System.Drawing.Point(11, 383)
        EmpPhone1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPhone1Label.Name = "EmpPhone1Label"
        EmpPhone1Label.Size = New System.Drawing.Size(149, 18)
        EmpPhone1Label.TabIndex = 73
        EmpPhone1Label.Text = "Employee Phone1:"
        '
        'EmpPhone2Label
        '
        EmpPhone2Label.AutoSize = True
        EmpPhone2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPhone2Label.Location = New System.Drawing.Point(11, 417)
        EmpPhone2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPhone2Label.Name = "EmpPhone2Label"
        EmpPhone2Label.Size = New System.Drawing.Size(149, 18)
        EmpPhone2Label.TabIndex = 75
        EmpPhone2Label.Text = "Employee Phone2:"
        '
        'EmpEmailLabel
        '
        EmpEmailLabel.AutoSize = True
        EmpEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpEmailLabel.Location = New System.Drawing.Point(11, 451)
        EmpEmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpEmailLabel.Name = "EmpEmailLabel"
        EmpEmailLabel.Size = New System.Drawing.Size(134, 18)
        EmpEmailLabel.TabIndex = 77
        EmpEmailLabel.Text = "Employee Email:"
        '
        'EmpPasswordLabel
        '
        EmpPasswordLabel.AutoSize = True
        EmpPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPasswordLabel.Location = New System.Drawing.Point(11, 485)
        EmpPasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPasswordLabel.Name = "EmpPasswordLabel"
        EmpPasswordLabel.Size = New System.Drawing.Size(167, 18)
        EmpPasswordLabel.TabIndex = 79
        EmpPasswordLabel.Text = "Employee Password:"
        '
        'EmpPositionLabel
        '
        EmpPositionLabel.AutoSize = True
        EmpPositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpPositionLabel.Location = New System.Drawing.Point(11, 519)
        EmpPositionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpPositionLabel.Name = "EmpPositionLabel"
        EmpPositionLabel.Size = New System.Drawing.Size(154, 18)
        EmpPositionLabel.TabIndex = 81
        EmpPositionLabel.Text = "Employee Position:"
        '
        'EmpSalaryLabel
        '
        EmpSalaryLabel.AutoSize = True
        EmpSalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpSalaryLabel.Location = New System.Drawing.Point(11, 553)
        EmpSalaryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpSalaryLabel.Name = "EmpSalaryLabel"
        EmpSalaryLabel.Size = New System.Drawing.Size(139, 18)
        EmpSalaryLabel.TabIndex = 83
        EmpSalaryLabel.Text = "Employee Salary:"
        '
        'EmpStatusLabel
        '
        EmpStatusLabel.AutoSize = True
        EmpStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpStatusLabel.Location = New System.Drawing.Point(11, 587)
        EmpStatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpStatusLabel.Name = "EmpStatusLabel"
        EmpStatusLabel.Size = New System.Drawing.Size(140, 18)
        EmpStatusLabel.TabIndex = 85
        EmpStatusLabel.Text = "Employee Status:"
        '
        'EmpImageNameLabel
        '
        EmpImageNameLabel.AutoSize = True
        EmpImageNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpImageNameLabel.Location = New System.Drawing.Point(11, 621)
        EmpImageNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmpImageNameLabel.Name = "EmpImageNameLabel"
        EmpImageNameLabel.Size = New System.Drawing.Size(186, 18)
        EmpImageNameLabel.TabIndex = 87
        EmpImageNameLabel.Text = "Employee Image Name:"
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePic.Location = New System.Drawing.Point(586, 240)
        Me.btnBrowsePic.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(68, 30)
        Me.btnBrowsePic.TabIndex = 40
        Me.btnBrowsePic.Text = "&Browse"
        Me.btnBrowsePic.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(586, 405)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 30)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(586, 519)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 30)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Ca&ncel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(586, 614)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 30)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picEmp
        '
        Me.picEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEmp.Location = New System.Drawing.Point(586, 80)
        Me.picEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.picEmp.Name = "picEmp"
        Me.picEmp.Size = New System.Drawing.Size(137, 151)
        Me.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmp.TabIndex = 52
        Me.picEmp.TabStop = False
        '
        'BurzlyDBDataSet
        '
        Me.BurzlyDBDataSet.DataSetName = "BurzlyDBDataSet"
        Me.BurzlyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.BurzlyDBDataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtEmpId
        '
        Me.txtEmpId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empId", True))
        Me.txtEmpId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpId.Location = New System.Drawing.Point(205, 44)
        Me.txtEmpId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpId.TabIndex = 54
        '
        'txtEmpName
        '
        Me.txtEmpName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empName", True))
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(205, 79)
        Me.txtEmpName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpName.TabIndex = 56
        '
        'mskEmpIC
        '
        Me.mskEmpIC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empIC", True))
        Me.mskEmpIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEmpIC.Location = New System.Drawing.Point(205, 111)
        Me.mskEmpIC.Margin = New System.Windows.Forms.Padding(4)
        Me.mskEmpIC.Mask = "000000-00-0000"
        Me.mskEmpIC.Name = "mskEmpIC"
        Me.mskEmpIC.Size = New System.Drawing.Size(334, 24)
        Me.mskEmpIC.TabIndex = 58
        '
        'txtEmpPassp
        '
        Me.txtEmpPassp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPassport", True))
        Me.txtEmpPassp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpPassp.Location = New System.Drawing.Point(205, 144)
        Me.txtEmpPassp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpPassp.Name = "txtEmpPassp"
        Me.txtEmpPassp.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpPassp.TabIndex = 60
        '
        'EmpDOBDateTimePicker
        '
        Me.EmpDOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "empDOB", True))
        Me.EmpDOBDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDOBDateTimePicker.Location = New System.Drawing.Point(205, 178)
        Me.EmpDOBDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.EmpDOBDateTimePicker.Name = "EmpDOBDateTimePicker"
        Me.EmpDOBDateTimePicker.Size = New System.Drawing.Size(334, 24)
        Me.EmpDOBDateTimePicker.TabIndex = 62
        '
        'txtEmpGender
        '
        Me.txtEmpGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empGender", True))
        Me.txtEmpGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpGender.Location = New System.Drawing.Point(205, 212)
        Me.txtEmpGender.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpGender.Name = "txtEmpGender"
        Me.txtEmpGender.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpGender.TabIndex = 64
        '
        'txtEmpAddr
        '
        Me.txtEmpAddr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empAddress", True))
        Me.txtEmpAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpAddr.Location = New System.Drawing.Point(205, 246)
        Me.txtEmpAddr.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpAddr.Name = "txtEmpAddr"
        Me.txtEmpAddr.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpAddr.TabIndex = 66
        '
        'txtEmpState
        '
        Me.txtEmpState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empState", True))
        Me.txtEmpState.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpState.Location = New System.Drawing.Point(205, 280)
        Me.txtEmpState.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpState.Name = "txtEmpState"
        Me.txtEmpState.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpState.TabIndex = 68
        '
        'mskEmpPostcode
        '
        Me.mskEmpPostcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPostcode", True))
        Me.mskEmpPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEmpPostcode.Location = New System.Drawing.Point(205, 314)
        Me.mskEmpPostcode.Margin = New System.Windows.Forms.Padding(4)
        Me.mskEmpPostcode.Mask = "00000"
        Me.mskEmpPostcode.Name = "mskEmpPostcode"
        Me.mskEmpPostcode.Size = New System.Drawing.Size(334, 24)
        Me.mskEmpPostcode.TabIndex = 70
        '
        'txtCountry
        '
        Me.txtCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empCountry", True))
        Me.txtCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(205, 348)
        Me.txtCountry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(334, 24)
        Me.txtCountry.TabIndex = 72
        '
        'txtPhone1
        '
        Me.txtPhone1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPhone1", True))
        Me.txtPhone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone1.Location = New System.Drawing.Point(205, 382)
        Me.txtPhone1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone1.Name = "txtPhone1"
        Me.txtPhone1.Size = New System.Drawing.Size(334, 24)
        Me.txtPhone1.TabIndex = 74
        '
        'txtPhone2
        '
        Me.txtPhone2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPhone2", True))
        Me.txtPhone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone2.Location = New System.Drawing.Point(205, 416)
        Me.txtPhone2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Size = New System.Drawing.Size(334, 24)
        Me.txtPhone2.TabIndex = 76
        '
        'mskEmail
        '
        Me.mskEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empEmail", True))
        Me.mskEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskEmail.Location = New System.Drawing.Point(205, 450)
        Me.mskEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.mskEmail.Name = "mskEmail"
        Me.mskEmail.Size = New System.Drawing.Size(334, 24)
        Me.mskEmail.TabIndex = 78
        '
        'txtPassw
        '
        Me.txtPassw.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPassword", True))
        Me.txtPassw.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassw.Location = New System.Drawing.Point(205, 484)
        Me.txtPassw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassw.Name = "txtPassw"
        Me.txtPassw.Size = New System.Drawing.Size(334, 24)
        Me.txtPassw.TabIndex = 80
        '
        'txtEmpPosition
        '
        Me.txtEmpPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empPosition", True))
        Me.txtEmpPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpPosition.Location = New System.Drawing.Point(205, 518)
        Me.txtEmpPosition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpPosition.Name = "txtEmpPosition"
        Me.txtEmpPosition.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpPosition.TabIndex = 82
        '
        'txtEmpSalary
        '
        Me.txtEmpSalary.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empSalary", True))
        Me.txtEmpSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpSalary.Location = New System.Drawing.Point(205, 552)
        Me.txtEmpSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpSalary.Name = "txtEmpSalary"
        Me.txtEmpSalary.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpSalary.TabIndex = 84
        '
        'txtEmpStatus
        '
        Me.txtEmpStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empStatus", True))
        Me.txtEmpStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpStatus.Location = New System.Drawing.Point(205, 584)
        Me.txtEmpStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpStatus.Name = "txtEmpStatus"
        Me.txtEmpStatus.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpStatus.TabIndex = 86
        '
        'txtEmpImageName
        '
        Me.txtEmpImageName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "empImageName", True))
        Me.txtEmpImageName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpImageName.Location = New System.Drawing.Point(205, 618)
        Me.txtEmpImageName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpImageName.Name = "txtEmpImageName"
        Me.txtEmpImageName.Size = New System.Drawing.Size(334, 24)
        Me.txtEmpImageName.TabIndex = 88
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'frmEmployeeCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(741, 667)
        Me.Controls.Add(EmpIdLabel)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(EmpNameLabel)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(EmpICLabel)
        Me.Controls.Add(Me.mskEmpIC)
        Me.Controls.Add(EmpPassportLabel)
        Me.Controls.Add(Me.txtEmpPassp)
        Me.Controls.Add(EmpDOBLabel)
        Me.Controls.Add(Me.EmpDOBDateTimePicker)
        Me.Controls.Add(EmpGenderLabel)
        Me.Controls.Add(Me.txtEmpGender)
        Me.Controls.Add(EmpAddressLabel)
        Me.Controls.Add(Me.txtEmpAddr)
        Me.Controls.Add(EmpStateLabel)
        Me.Controls.Add(Me.txtEmpState)
        Me.Controls.Add(EmpPostcodeLabel)
        Me.Controls.Add(Me.mskEmpPostcode)
        Me.Controls.Add(EmpCountryLabel)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(EmpPhone1Label)
        Me.Controls.Add(Me.txtPhone1)
        Me.Controls.Add(EmpPhone2Label)
        Me.Controls.Add(Me.txtPhone2)
        Me.Controls.Add(EmpEmailLabel)
        Me.Controls.Add(Me.mskEmail)
        Me.Controls.Add(EmpPasswordLabel)
        Me.Controls.Add(Me.txtPassw)
        Me.Controls.Add(EmpPositionLabel)
        Me.Controls.Add(Me.txtEmpPosition)
        Me.Controls.Add(EmpSalaryLabel)
        Me.Controls.Add(Me.txtEmpSalary)
        Me.Controls.Add(EmpStatusLabel)
        Me.Controls.Add(Me.txtEmpStatus)
        Me.Controls.Add(EmpImageNameLabel)
        Me.Controls.Add(Me.txtEmpImageName)
        Me.Controls.Add(Me.picEmp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBrowsePic)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEmployeeCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.picEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowsePic As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picEmp As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents BurzlyDBDataSet As Burzly.BurzlyDBDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As Burzly.BurzlyDBDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents mskEmpIC As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmpPassp As System.Windows.Forms.TextBox
    Friend WithEvents EmpDOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmpGender As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpState As System.Windows.Forms.TextBox
    Friend WithEvents mskEmpPostcode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents mskEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPassw As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpImageName As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
End Class
