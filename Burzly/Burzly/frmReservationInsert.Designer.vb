<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationInsert
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
        Dim ReserveIdLabel As System.Windows.Forms.Label
        Dim ReserveNameLabel As System.Windows.Forms.Label
        Dim ReserveContactLabel As System.Windows.Forms.Label
        Dim ReserveDateLabel As System.Windows.Forms.Label
        Dim ReserveTimeLabel As System.Windows.Forms.Label
        Dim ReservePaxLabel As System.Windows.Forms.Label
        Dim ReserveTableLabel As System.Windows.Forms.Label
        Dim ReserveStatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservationInsert))
        Me.radTable7 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.radTable8 = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radTable6 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radTable5 = New System.Windows.Forms.RadioButton()
        Me.radTable4 = New System.Windows.Forms.RadioButton()
        Me.lblReserveTable = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnModifty = New System.Windows.Forms.Button()
        Me.radTable3 = New System.Windows.Forms.RadioButton()
        Me.radTable = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radTable2 = New System.Windows.Forms.RadioButton()
        Me.lblReserveStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskReserveTime = New System.Windows.Forms.MaskedTextBox()
        Me.ReservationTableAdapter = New Burzly.BurzlyDBDataSetTableAdapters.ReservationTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableAdapterManager = New Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BurzlyDBDataSet = New Burzly.BurzlyDBDataSet()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtReserveId = New System.Windows.Forms.TextBox()
        Me.txtReserveName = New System.Windows.Forms.TextBox()
        Me.txtReserveContact = New System.Windows.Forms.TextBox()
        Me.ReserveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtReservePax = New System.Windows.Forms.TextBox()
        Me.btnAddSave = New System.Windows.Forms.Button()
        ReserveIdLabel = New System.Windows.Forms.Label()
        ReserveNameLabel = New System.Windows.Forms.Label()
        ReserveContactLabel = New System.Windows.Forms.Label()
        ReserveDateLabel = New System.Windows.Forms.Label()
        ReserveTimeLabel = New System.Windows.Forms.Label()
        ReservePaxLabel = New System.Windows.Forms.Label()
        ReserveTableLabel = New System.Windows.Forms.Label()
        ReserveStatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radTable7
        '
        Me.radTable7.AutoSize = True
        Me.radTable7.Location = New System.Drawing.Point(117, 85)
        Me.radTable7.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable7.Name = "radTable7"
        Me.radTable7.Size = New System.Drawing.Size(14, 13)
        Me.radTable7.TabIndex = 93
        Me.radTable7.TabStop = True
        Me.radTable7.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(115, 57)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 17)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 109)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "7"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(140, 57)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 17)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "4"
        '
        'radTable8
        '
        Me.radTable8.AutoSize = True
        Me.radTable8.Location = New System.Drawing.Point(143, 85)
        Me.radTable8.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable8.Name = "radTable8"
        Me.radTable8.Size = New System.Drawing.Size(14, 13)
        Me.radTable8.TabIndex = 92
        Me.radTable8.TabStop = True
        Me.radTable8.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 109)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 17)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "6"
        '
        'radTable6
        '
        Me.radTable6.AutoSize = True
        Me.radTable6.Location = New System.Drawing.Point(91, 85)
        Me.radTable6.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable6.Name = "radTable6"
        Me.radTable6.Size = New System.Drawing.Size(14, 13)
        Me.radTable6.TabIndex = 91
        Me.radTable6.TabStop = True
        Me.radTable6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 109)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 17)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "5"
        '
        'radTable5
        '
        Me.radTable5.AutoSize = True
        Me.radTable5.Location = New System.Drawing.Point(66, 85)
        Me.radTable5.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable5.Name = "radTable5"
        Me.radTable5.Size = New System.Drawing.Size(14, 13)
        Me.radTable5.TabIndex = 90
        Me.radTable5.TabStop = True
        Me.radTable5.UseVisualStyleBackColor = True
        '
        'radTable4
        '
        Me.radTable4.AutoSize = True
        Me.radTable4.Location = New System.Drawing.Point(143, 36)
        Me.radTable4.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable4.Name = "radTable4"
        Me.radTable4.Size = New System.Drawing.Size(14, 13)
        Me.radTable4.TabIndex = 89
        Me.radTable4.TabStop = True
        Me.radTable4.UseVisualStyleBackColor = True
        '
        'lblReserveTable
        '
        Me.lblReserveTable.BackColor = System.Drawing.SystemColors.Window
        Me.lblReserveTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReserveTable.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserveTable.Location = New System.Drawing.Point(414, 188)
        Me.lblReserveTable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReserveTable.Name = "lblReserveTable"
        Me.lblReserveTable.Size = New System.Drawing.Size(135, 21)
        Me.lblReserveTable.TabIndex = 107
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 57)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 17)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(140, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 17)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "8"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(88, 57)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 17)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "2"
        '
        'btnModifty
        '
        Me.btnModifty.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifty.Location = New System.Drawing.Point(552, 61)
        Me.btnModifty.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModifty.Name = "btnModifty"
        Me.btnModifty.Size = New System.Drawing.Size(78, 21)
        Me.btnModifty.TabIndex = 108
        Me.btnModifty.Text = "&Modify Id"
        Me.btnModifty.UseVisualStyleBackColor = True
        '
        'radTable3
        '
        Me.radTable3.AutoSize = True
        Me.radTable3.Location = New System.Drawing.Point(117, 36)
        Me.radTable3.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable3.Name = "radTable3"
        Me.radTable3.Size = New System.Drawing.Size(14, 13)
        Me.radTable3.TabIndex = 88
        Me.radTable3.TabStop = True
        Me.radTable3.UseVisualStyleBackColor = True
        '
        'radTable
        '
        Me.radTable.AutoSize = True
        Me.radTable.Location = New System.Drawing.Point(66, 36)
        Me.radTable.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable.Name = "radTable"
        Me.radTable.Size = New System.Drawing.Size(14, 13)
        Me.radTable.TabIndex = 86
        Me.radTable.TabStop = True
        Me.radTable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.radTable7)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.radTable8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.radTable6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.radTable5)
        Me.GroupBox2.Controls.Add(Me.radTable4)
        Me.GroupBox2.Controls.Add(Me.radTable3)
        Me.GroupBox2.Controls.Add(Me.radTable)
        Me.GroupBox2.Controls.Add(Me.radTable2)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 54)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(230, 153)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Table"
        '
        'radTable2
        '
        Me.radTable2.AutoSize = True
        Me.radTable2.Location = New System.Drawing.Point(91, 36)
        Me.radTable2.Margin = New System.Windows.Forms.Padding(2)
        Me.radTable2.Name = "radTable2"
        Me.radTable2.Size = New System.Drawing.Size(14, 13)
        Me.radTable2.TabIndex = 87
        Me.radTable2.TabStop = True
        Me.radTable2.UseVisualStyleBackColor = True
        '
        'lblReserveStatus
        '
        Me.lblReserveStatus.BackColor = System.Drawing.SystemColors.Window
        Me.lblReserveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReserveStatus.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReserveStatus.Location = New System.Drawing.Point(414, 207)
        Me.lblReserveStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReserveStatus.Name = "lblReserveStatus"
        Me.lblReserveStatus.Size = New System.Drawing.Size(134, 23)
        Me.lblReserveStatus.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(560, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "*24-hour format"
        '
        'mskReserveTime
        '
        Me.mskReserveTime.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskReserveTime.Location = New System.Drawing.Point(415, 148)
        Me.mskReserveTime.Margin = New System.Windows.Forms.Padding(2)
        Me.mskReserveTime.Mask = "00:00"
        Me.mskReserveTime.Name = "mskReserveTime"
        Me.mskReserveTime.Size = New System.Drawing.Size(135, 24)
        Me.mskReserveTime.TabIndex = 105
        '
        'ReserveIdLabel
        '
        ReserveIdLabel.AutoSize = True
        ReserveIdLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveIdLabel.Location = New System.Drawing.Point(298, 62)
        ReserveIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveIdLabel.Name = "ReserveIdLabel"
        ReserveIdLabel.Size = New System.Drawing.Size(74, 17)
        ReserveIdLabel.TabIndex = 90
        ReserveIdLabel.Text = "Reserve Id:"
        '
        'ReserveNameLabel
        '
        ReserveNameLabel.AutoSize = True
        ReserveNameLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveNameLabel.Location = New System.Drawing.Point(298, 89)
        ReserveNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveNameLabel.Name = "ReserveNameLabel"
        ReserveNameLabel.Size = New System.Drawing.Size(96, 17)
        ReserveNameLabel.TabIndex = 92
        ReserveNameLabel.Text = "Reserve Name:"
        '
        'ReserveContactLabel
        '
        ReserveContactLabel.AutoSize = True
        ReserveContactLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveContactLabel.Location = New System.Drawing.Point(298, 110)
        ReserveContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveContactLabel.Name = "ReserveContactLabel"
        ReserveContactLabel.Size = New System.Drawing.Size(108, 17)
        ReserveContactLabel.TabIndex = 94
        ReserveContactLabel.Text = "Reserve Contact:"
        '
        'ReserveDateLabel
        '
        ReserveDateLabel.AutoSize = True
        ReserveDateLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveDateLabel.Location = New System.Drawing.Point(298, 131)
        ReserveDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveDateLabel.Name = "ReserveDateLabel"
        ReserveDateLabel.Size = New System.Drawing.Size(90, 17)
        ReserveDateLabel.TabIndex = 96
        ReserveDateLabel.Text = "Reserve Date:"
        '
        'ReserveTimeLabel
        '
        ReserveTimeLabel.AutoSize = True
        ReserveTimeLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveTimeLabel.Location = New System.Drawing.Point(298, 151)
        ReserveTimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveTimeLabel.Name = "ReserveTimeLabel"
        ReserveTimeLabel.Size = New System.Drawing.Size(90, 17)
        ReserveTimeLabel.TabIndex = 98
        ReserveTimeLabel.Text = "Reserve Time:"
        '
        'ReservePaxLabel
        '
        ReservePaxLabel.AutoSize = True
        ReservePaxLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReservePaxLabel.Location = New System.Drawing.Point(298, 172)
        ReservePaxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReservePaxLabel.Name = "ReservePaxLabel"
        ReservePaxLabel.Size = New System.Drawing.Size(82, 17)
        ReservePaxLabel.TabIndex = 99
        ReservePaxLabel.Text = "Reserve Pax:"
        '
        'ReserveTableLabel
        '
        ReserveTableLabel.AutoSize = True
        ReserveTableLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveTableLabel.Location = New System.Drawing.Point(298, 193)
        ReserveTableLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveTableLabel.Name = "ReserveTableLabel"
        ReserveTableLabel.Size = New System.Drawing.Size(93, 17)
        ReserveTableLabel.TabIndex = 101
        ReserveTableLabel.Text = "Reserve Table:"
        '
        'ReserveStatusLabel
        '
        ReserveStatusLabel.AutoSize = True
        ReserveStatusLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveStatusLabel.Location = New System.Drawing.Point(298, 214)
        ReserveStatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveStatusLabel.Name = "ReserveStatusLabel"
        ReserveStatusLabel.Size = New System.Drawing.Size(100, 17)
        ReserveStatusLabel.TabIndex = 102
        ReserveStatusLabel.Text = "Reserve Status:"
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.StockTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "Reservation"
        Me.ReservationBindingSource1.DataSource = Me.BurzlyDBDataSet
        '
        'BurzlyDBDataSet
        '
        Me.BurzlyDBDataSet.DataSetName = "BurzlyDBDataSet"
        Me.BurzlyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(433, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 30)
        Me.btnCancel.TabIndex = 104
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtReserveId
        '
        Me.txtReserveId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource1, "reserveId", True))
        Me.txtReserveId.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserveId.Location = New System.Drawing.Point(415, 61)
        Me.txtReserveId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveId.Name = "txtReserveId"
        Me.txtReserveId.Size = New System.Drawing.Size(134, 24)
        Me.txtReserveId.TabIndex = 91
        '
        'txtReserveName
        '
        Me.txtReserveName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource1, "reserveName", True))
        Me.txtReserveName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserveName.Location = New System.Drawing.Point(415, 88)
        Me.txtReserveName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveName.Name = "txtReserveName"
        Me.txtReserveName.Size = New System.Drawing.Size(135, 24)
        Me.txtReserveName.TabIndex = 93
        '
        'txtReserveContact
        '
        Me.txtReserveContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource1, "reserveContact", True))
        Me.txtReserveContact.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserveContact.Location = New System.Drawing.Point(415, 108)
        Me.txtReserveContact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveContact.Name = "txtReserveContact"
        Me.txtReserveContact.Size = New System.Drawing.Size(135, 24)
        Me.txtReserveContact.TabIndex = 95
        '
        'ReserveDateDateTimePicker
        '
        Me.ReserveDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservationBindingSource1, "reserveDate", True))
        Me.ReserveDateDateTimePicker.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveDateDateTimePicker.Location = New System.Drawing.Point(415, 129)
        Me.ReserveDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.ReserveDateDateTimePicker.Name = "ReserveDateDateTimePicker"
        Me.ReserveDateDateTimePicker.Size = New System.Drawing.Size(135, 24)
        Me.ReserveDateDateTimePicker.TabIndex = 97
        '
        'txtReservePax
        '
        Me.txtReservePax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource1, "reservePax", True))
        Me.txtReservePax.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReservePax.Location = New System.Drawing.Point(415, 169)
        Me.txtReservePax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReservePax.Name = "txtReservePax"
        Me.txtReservePax.Size = New System.Drawing.Size(135, 24)
        Me.txtReservePax.TabIndex = 100
        '
        'btnAddSave
        '
        Me.btnAddSave.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSave.Location = New System.Drawing.Point(340, 252)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(86, 30)
        Me.btnAddSave.TabIndex = 103
        Me.btnAddSave.Text = "&Add"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'frmReservationInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(665, 336)
        Me.Controls.Add(Me.lblReserveTable)
        Me.Controls.Add(Me.btnModifty)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblReserveStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskReserveTime)
        Me.Controls.Add(ReserveIdLabel)
        Me.Controls.Add(ReserveNameLabel)
        Me.Controls.Add(ReserveContactLabel)
        Me.Controls.Add(ReserveDateLabel)
        Me.Controls.Add(ReserveTimeLabel)
        Me.Controls.Add(ReservePaxLabel)
        Me.Controls.Add(ReserveTableLabel)
        Me.Controls.Add(ReserveStatusLabel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtReserveId)
        Me.Controls.Add(Me.txtReserveName)
        Me.Controls.Add(Me.txtReserveContact)
        Me.Controls.Add(Me.ReserveDateDateTimePicker)
        Me.Controls.Add(Me.txtReservePax)
        Me.Controls.Add(Me.btnAddSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservationInsert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radTable7 As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents radTable8 As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents radTable6 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents radTable5 As System.Windows.Forms.RadioButton
    Friend WithEvents radTable4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblReserveTable As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnModifty As System.Windows.Forms.Button
    Friend WithEvents radTable3 As System.Windows.Forms.RadioButton
    Friend WithEvents radTable As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radTable2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblReserveStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskReserveTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ReservationTableAdapter As Burzly.BurzlyDBDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableAdapterManager As Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ReservationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BurzlyDBDataSet As Burzly.BurzlyDBDataSet
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtReserveId As System.Windows.Forms.TextBox
    Friend WithEvents txtReserveName As System.Windows.Forms.TextBox
    Friend WithEvents txtReserveContact As System.Windows.Forms.TextBox
    Friend WithEvents ReserveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReservePax As System.Windows.Forms.TextBox
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
End Class
