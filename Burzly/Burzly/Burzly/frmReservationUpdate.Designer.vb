<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservationUpdate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservationUpdate))
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblReserveStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mskReserveTime = New System.Windows.Forms.MaskedTextBox()
        Me.txtReserveTable = New System.Windows.Forms.TextBox()
        Me.txtReserveContact = New System.Windows.Forms.TextBox()
        Me.txtReserveName = New System.Windows.Forms.TextBox()
        Me.txtReservePax = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.ReserveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSeacrh = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BurzlyDBDataSet = New Burzly.BurzlyDBDataSet()
        Me.TableAdapterManager = New Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager()
        Me.ReservationTableAdapter = New Burzly.BurzlyDBDataSetTableAdapters.ReservationTableAdapter()
        Me.dgvReservation = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ReserveIdLabel = New System.Windows.Forms.Label()
        ReserveNameLabel = New System.Windows.Forms.Label()
        ReserveContactLabel = New System.Windows.Forms.Label()
        ReserveDateLabel = New System.Windows.Forms.Label()
        ReserveTimeLabel = New System.Windows.Forms.Label()
        ReservePaxLabel = New System.Windows.Forms.Label()
        ReserveTableLabel = New System.Windows.Forms.Label()
        ReserveStatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "reserveTime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Reserve Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "reserveTable"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reserve Table"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "reserveStatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Reserve Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(222, 27)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(65, 21)
        Me.btnSearch.TabIndex = 83
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "reservePax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Reserve Pax"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'lblReserveStatus
        '
        Me.lblReserveStatus.Location = New System.Drawing.Point(131, 175)
        Me.lblReserveStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.lblReserveStatus.Name = "lblReserveStatus"
        Me.lblReserveStatus.Size = New System.Drawing.Size(135, 24)
        Me.lblReserveStatus.TabIndex = 113
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblReserveStatus)
        Me.GroupBox2.Controls.Add(Me.mskReserveTime)
        Me.GroupBox2.Controls.Add(Me.txtReserveTable)
        Me.GroupBox2.Controls.Add(Me.txtReserveContact)
        Me.GroupBox2.Controls.Add(Me.txtReserveName)
        Me.GroupBox2.Controls.Add(Me.txtReservePax)
        Me.GroupBox2.Controls.Add(ReserveIdLabel)
        Me.GroupBox2.Controls.Add(ReserveNameLabel)
        Me.GroupBox2.Controls.Add(ReserveContactLabel)
        Me.GroupBox2.Controls.Add(ReserveDateLabel)
        Me.GroupBox2.Controls.Add(ReserveTimeLabel)
        Me.GroupBox2.Controls.Add(ReservePaxLabel)
        Me.GroupBox2.Controls.Add(ReserveTableLabel)
        Me.GroupBox2.Controls.Add(ReserveStatusLabel)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Controls.Add(Me.ReserveDateDateTimePicker)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(349, 139)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(280, 205)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer's details"
        '
        'mskReserveTime
        '
        Me.mskReserveTime.Location = New System.Drawing.Point(131, 114)
        Me.mskReserveTime.Margin = New System.Windows.Forms.Padding(2)
        Me.mskReserveTime.Mask = "00:00"
        Me.mskReserveTime.Name = "mskReserveTime"
        Me.mskReserveTime.Size = New System.Drawing.Size(135, 24)
        Me.mskReserveTime.TabIndex = 112
        '
        'txtReserveTable
        '
        Me.txtReserveTable.Location = New System.Drawing.Point(131, 154)
        Me.txtReserveTable.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveTable.Name = "txtReserveTable"
        Me.txtReserveTable.Size = New System.Drawing.Size(135, 24)
        Me.txtReserveTable.TabIndex = 111
        '
        'txtReserveContact
        '
        Me.txtReserveContact.Location = New System.Drawing.Point(131, 71)
        Me.txtReserveContact.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveContact.Name = "txtReserveContact"
        Me.txtReserveContact.Size = New System.Drawing.Size(135, 24)
        Me.txtReserveContact.TabIndex = 110
        '
        'txtReserveName
        '
        Me.txtReserveName.Location = New System.Drawing.Point(131, 50)
        Me.txtReserveName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReserveName.Name = "txtReserveName"
        Me.txtReserveName.Size = New System.Drawing.Size(135, 24)
        Me.txtReserveName.TabIndex = 87
        '
        'txtReservePax
        '
        Me.txtReservePax.Location = New System.Drawing.Point(131, 133)
        Me.txtReservePax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReservePax.Name = "txtReservePax"
        Me.txtReservePax.Size = New System.Drawing.Size(135, 24)
        Me.txtReservePax.TabIndex = 109
        '
        'ReserveIdLabel
        '
        ReserveIdLabel.AutoSize = True
        ReserveIdLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveIdLabel.Location = New System.Drawing.Point(21, 29)
        ReserveIdLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveIdLabel.Name = "ReserveIdLabel"
        ReserveIdLabel.Size = New System.Drawing.Size(74, 17)
        ReserveIdLabel.TabIndex = 101
        ReserveIdLabel.Text = "Reserve Id:"
        '
        'ReserveNameLabel
        '
        ReserveNameLabel.AutoSize = True
        ReserveNameLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveNameLabel.Location = New System.Drawing.Point(21, 50)
        ReserveNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveNameLabel.Name = "ReserveNameLabel"
        ReserveNameLabel.Size = New System.Drawing.Size(96, 17)
        ReserveNameLabel.TabIndex = 102
        ReserveNameLabel.Text = "Reserve Name:"
        '
        'ReserveContactLabel
        '
        ReserveContactLabel.AutoSize = True
        ReserveContactLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveContactLabel.Location = New System.Drawing.Point(21, 71)
        ReserveContactLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveContactLabel.Name = "ReserveContactLabel"
        ReserveContactLabel.Size = New System.Drawing.Size(108, 17)
        ReserveContactLabel.TabIndex = 103
        ReserveContactLabel.Text = "Reserve Contact:"
        '
        'ReserveDateLabel
        '
        ReserveDateLabel.AutoSize = True
        ReserveDateLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveDateLabel.Location = New System.Drawing.Point(21, 92)
        ReserveDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveDateLabel.Name = "ReserveDateLabel"
        ReserveDateLabel.Size = New System.Drawing.Size(90, 17)
        ReserveDateLabel.TabIndex = 104
        ReserveDateLabel.Text = "Reserve Date:"
        '
        'ReserveTimeLabel
        '
        ReserveTimeLabel.AutoSize = True
        ReserveTimeLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveTimeLabel.Location = New System.Drawing.Point(21, 112)
        ReserveTimeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveTimeLabel.Name = "ReserveTimeLabel"
        ReserveTimeLabel.Size = New System.Drawing.Size(90, 17)
        ReserveTimeLabel.TabIndex = 105
        ReserveTimeLabel.Text = "Reserve Time:"
        '
        'ReservePaxLabel
        '
        ReservePaxLabel.AutoSize = True
        ReservePaxLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReservePaxLabel.Location = New System.Drawing.Point(21, 133)
        ReservePaxLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReservePaxLabel.Name = "ReservePaxLabel"
        ReservePaxLabel.Size = New System.Drawing.Size(82, 17)
        ReservePaxLabel.TabIndex = 106
        ReservePaxLabel.Text = "Reserve Pax:"
        '
        'ReserveTableLabel
        '
        ReserveTableLabel.AutoSize = True
        ReserveTableLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveTableLabel.Location = New System.Drawing.Point(21, 154)
        ReserveTableLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveTableLabel.Name = "ReserveTableLabel"
        ReserveTableLabel.Size = New System.Drawing.Size(93, 17)
        ReserveTableLabel.TabIndex = 107
        ReserveTableLabel.Text = "Reserve Table:"
        '
        'ReserveStatusLabel
        '
        ReserveStatusLabel.AutoSize = True
        ReserveStatusLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReserveStatusLabel.Location = New System.Drawing.Point(21, 175)
        ReserveStatusLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReserveStatusLabel.Name = "ReserveStatusLabel"
        ReserveStatusLabel.Size = New System.Drawing.Size(100, 17)
        ReserveStatusLabel.TabIndex = 108
        ReserveStatusLabel.Text = "Reserve Status:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(131, 28)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(135, 24)
        Me.txtId.TabIndex = 100
        '
        'ReserveDateDateTimePicker
        '
        Me.ReserveDateDateTimePicker.Location = New System.Drawing.Point(131, 92)
        Me.ReserveDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.ReserveDateDateTimePicker.Name = "ReserveDateDateTimePicker"
        Me.ReserveDateDateTimePicker.Size = New System.Drawing.Size(135, 24)
        Me.ReserveDateDateTimePicker.TabIndex = 91
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSeacrh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 152)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(291, 62)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txtSeacrh
        '
        Me.txtSeacrh.Location = New System.Drawing.Point(77, 27)
        Me.txtSeacrh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSeacrh.Name = "txtSeacrh"
        Me.txtSeacrh.Size = New System.Drawing.Size(135, 24)
        Me.txtSeacrh.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Search:"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(171, 253)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 26)
        Me.btnCancel.TabIndex = 89
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(62, 251)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 26)
        Me.btnUpdate.TabIndex = 88
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "reserveDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Reserve Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BurzlyDBDataSet
        '
        Me.BurzlyDBDataSet.DataSetName = "BurzlyDBDataSet"
        Me.BurzlyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'dgvReservation
        '
        Me.dgvReservation.BackgroundColor = System.Drawing.Color.Tomato
        Me.dgvReservation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReservation.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReservation.GridColor = System.Drawing.Color.Maroon
        Me.dgvReservation.Location = New System.Drawing.Point(12, 14)
        Me.dgvReservation.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReservation.Name = "dgvReservation"
        Me.dgvReservation.RowTemplate.Height = 28
        Me.dgvReservation.Size = New System.Drawing.Size(640, 121)
        Me.dgvReservation.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "reserveId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Reserve ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "reserveName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Reserve Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "reserveContact"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Reserve Contact"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'frmReservationUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(665, 359)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgvReservation)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReservationUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblReserveStatus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents mskReserveTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtReserveTable As System.Windows.Forms.TextBox
    Friend WithEvents txtReserveContact As System.Windows.Forms.TextBox
    Friend WithEvents txtReserveName As System.Windows.Forms.TextBox
    Friend WithEvents txtReservePax As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents ReserveDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeacrh As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BurzlyDBDataSet As Burzly.BurzlyDBDataSet
    Friend WithEvents TableAdapterManager As Burzly.BurzlyDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReservationTableAdapter As Burzly.BurzlyDBDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents dgvReservation As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
