<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockAdd
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
        Dim Label1 As System.Windows.Forms.Label
        Dim StkIDLabel As System.Windows.Forms.Label
        Dim StkTypeLabel As System.Windows.Forms.Label
        Dim StkNameLabel As System.Windows.Forms.Label
        Dim StkDescriptionLabel As System.Windows.Forms.Label
        Dim StkBrandLabel As System.Windows.Forms.Label
        Dim StkBeforeGstLabel As System.Windows.Forms.Label
        Dim StkAfterGstLabel As System.Windows.Forms.Label
        Dim StkStatusLabel As System.Windows.Forms.Label
        Dim StkQtyLabel As System.Windows.Forms.Label
        Dim StkImageNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockAdd))
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdStkImg = New System.Windows.Forms.OpenFileDialog()
        Me.txtSupIDStk = New System.Windows.Forms.TextBox()
        Me.btnEditID = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtStkQty = New System.Windows.Forms.TextBox()
        Me.txtStkAftGST = New System.Windows.Forms.TextBox()
        Me.txtStkBeforeGST = New System.Windows.Forms.TextBox()
        Me.picStk = New System.Windows.Forms.PictureBox()
        Me.cboStkStatus = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtStkId = New System.Windows.Forms.TextBox()
        Me.txtStkType = New System.Windows.Forms.TextBox()
        Me.txtStkName = New System.Windows.Forms.TextBox()
        Me.txtStkDesc = New System.Windows.Forms.TextBox()
        Me.txtStkBrand = New System.Windows.Forms.TextBox()
        Me.txtStkImgPath = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        StkIDLabel = New System.Windows.Forms.Label()
        StkTypeLabel = New System.Windows.Forms.Label()
        StkNameLabel = New System.Windows.Forms.Label()
        StkDescriptionLabel = New System.Windows.Forms.Label()
        StkBrandLabel = New System.Windows.Forms.Label()
        StkBeforeGstLabel = New System.Windows.Forms.Label()
        StkAfterGstLabel = New System.Windows.Forms.Label()
        StkStatusLabel = New System.Windows.Forms.Label()
        StkQtyLabel = New System.Windows.Forms.Label()
        StkImageNameLabel = New System.Windows.Forms.Label()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(119, 269)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(109, 20)
        Label1.TabIndex = 72
        Label1.Text = "Supplier ID :"
        '
        'StkIDLabel
        '
        StkIDLabel.AutoSize = True
        StkIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkIDLabel.Location = New System.Drawing.Point(138, 35)
        StkIDLabel.Name = "StkIDLabel"
        StkIDLabel.Size = New System.Drawing.Size(89, 20)
        StkIDLabel.TabIndex = 43
        StkIDLabel.Text = "Stock ID :"
        '
        'StkTypeLabel
        '
        StkTypeLabel.AutoSize = True
        StkTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkTypeLabel.Location = New System.Drawing.Point(119, 64)
        StkTypeLabel.Name = "StkTypeLabel"
        StkTypeLabel.Size = New System.Drawing.Size(108, 20)
        StkTypeLabel.TabIndex = 45
        StkTypeLabel.Text = "Stock Type :"
        '
        'StkNameLabel
        '
        StkNameLabel.AutoSize = True
        StkNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkNameLabel.Location = New System.Drawing.Point(111, 87)
        StkNameLabel.Name = "StkNameLabel"
        StkNameLabel.Size = New System.Drawing.Size(116, 20)
        StkNameLabel.TabIndex = 47
        StkNameLabel.Text = "Stock Name :"
        '
        'StkDescriptionLabel
        '
        StkDescriptionLabel.AutoSize = True
        StkDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkDescriptionLabel.Location = New System.Drawing.Point(66, 113)
        StkDescriptionLabel.Name = "StkDescriptionLabel"
        StkDescriptionLabel.Size = New System.Drawing.Size(161, 20)
        StkDescriptionLabel.TabIndex = 49
        StkDescriptionLabel.Text = "Stock Description :"
        '
        'StkBrandLabel
        '
        StkBrandLabel.AutoSize = True
        StkBrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkBrandLabel.Location = New System.Drawing.Point(109, 139)
        StkBrandLabel.Name = "StkBrandLabel"
        StkBrandLabel.Size = New System.Drawing.Size(118, 20)
        StkBrandLabel.TabIndex = 51
        StkBrandLabel.Text = "Stock Brand :"
        '
        'StkBeforeGstLabel
        '
        StkBeforeGstLabel.AutoSize = True
        StkBeforeGstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkBeforeGstLabel.Location = New System.Drawing.Point(15, 165)
        StkBeforeGstLabel.Name = "StkBeforeGstLabel"
        StkBeforeGstLabel.Size = New System.Drawing.Size(212, 20)
        StkBeforeGstLabel.TabIndex = 53
        StkBeforeGstLabel.Text = "Stock Before Gst ( RM ) :"
        '
        'StkAfterGstLabel
        '
        StkAfterGstLabel.AutoSize = True
        StkAfterGstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkAfterGstLabel.Location = New System.Drawing.Point(29, 191)
        StkAfterGstLabel.Name = "StkAfterGstLabel"
        StkAfterGstLabel.Size = New System.Drawing.Size(198, 20)
        StkAfterGstLabel.TabIndex = 54
        StkAfterGstLabel.Text = "Stock After Gst ( RM ) :"
        '
        'StkStatusLabel
        '
        StkStatusLabel.AutoSize = True
        StkStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkStatusLabel.Location = New System.Drawing.Point(104, 217)
        StkStatusLabel.Name = "StkStatusLabel"
        StkStatusLabel.Size = New System.Drawing.Size(123, 20)
        StkStatusLabel.TabIndex = 55
        StkStatusLabel.Text = "Stock Status :"
        '
        'StkQtyLabel
        '
        StkQtyLabel.AutoSize = True
        StkQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkQtyLabel.Location = New System.Drawing.Point(130, 243)
        StkQtyLabel.Name = "StkQtyLabel"
        StkQtyLabel.Size = New System.Drawing.Size(97, 20)
        StkQtyLabel.TabIndex = 56
        StkQtyLabel.Text = "Stock Qty :"
        '
        'StkImageNameLabel
        '
        StkImageNameLabel.AutoSize = True
        StkImageNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkImageNameLabel.Location = New System.Drawing.Point(443, 9)
        StkImageNameLabel.Name = "StkImageNameLabel"
        StkImageNameLabel.Size = New System.Drawing.Size(110, 20)
        StkImageNameLabel.TabIndex = 57
        StkImageNameLabel.Text = "Stock Image"
        AddHandler StkImageNameLabel.Click, AddressOf Me.StkImageNameLabel_Click
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.err.ContainerControl = Me
        '
        'ofdStkImg
        '
        Me.ofdStkImg.FileName = """"""
        '
        'txtSupIDStk
        '
        Me.txtSupIDStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupIDStk.Location = New System.Drawing.Point(234, 269)
        Me.txtSupIDStk.Name = "txtSupIDStk"
        Me.txtSupIDStk.Size = New System.Drawing.Size(61, 26)
        Me.txtSupIDStk.TabIndex = 12
        '
        'btnEditID
        '
        Me.btnEditID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditID.Location = New System.Drawing.Point(337, 35)
        Me.btnEditID.Name = "btnEditID"
        Me.btnEditID.Size = New System.Drawing.Size(64, 26)
        Me.btnEditID.TabIndex = 1
        Me.btnEditID.Text = "&Edit ID"
        Me.btnEditID.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImage = Global.Burzly.My.Resources.Resources.magclass
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(301, 35)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 27)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtStkQty
        '
        Me.txtStkQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkQty.Location = New System.Drawing.Point(234, 243)
        Me.txtStkQty.Name = "txtStkQty"
        Me.txtStkQty.Size = New System.Drawing.Size(80, 26)
        Me.txtStkQty.TabIndex = 11
        '
        'txtStkAftGST
        '
        Me.txtStkAftGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkAftGST.Location = New System.Drawing.Point(234, 191)
        Me.txtStkAftGST.Name = "txtStkAftGST"
        Me.txtStkAftGST.Size = New System.Drawing.Size(121, 26)
        Me.txtStkAftGST.TabIndex = 9
        '
        'txtStkBeforeGST
        '
        Me.txtStkBeforeGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkBeforeGST.Location = New System.Drawing.Point(234, 165)
        Me.txtStkBeforeGST.Name = "txtStkBeforeGST"
        Me.txtStkBeforeGST.Size = New System.Drawing.Size(121, 26)
        Me.txtStkBeforeGST.TabIndex = 8
        '
        'picStk
        '
        Me.picStk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picStk.Location = New System.Drawing.Point(440, 32)
        Me.picStk.Name = "picStk"
        Me.picStk.Size = New System.Drawing.Size(115, 122)
        Me.picStk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStk.TabIndex = 66
        Me.picStk.TabStop = False
        '
        'cboStkStatus
        '
        Me.cboStkStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStkStatus.FormattingEnabled = True
        Me.cboStkStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cboStkStatus.Location = New System.Drawing.Point(234, 217)
        Me.cboStkStatus.Name = "cboStkStatus"
        Me.cboStkStatus.Size = New System.Drawing.Size(121, 28)
        Me.cboStkStatus.TabIndex = 10
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(478, 273)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(77, 32)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(478, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(389, 273)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(83, 32)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(454, 187)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 29)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtStkId
        '
        Me.txtStkId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkId.Location = New System.Drawing.Point(234, 35)
        Me.txtStkId.Name = "txtStkId"
        Me.txtStkId.Size = New System.Drawing.Size(61, 26)
        Me.txtStkId.TabIndex = 2
        '
        'txtStkType
        '
        Me.txtStkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkType.Location = New System.Drawing.Point(234, 61)
        Me.txtStkType.Name = "txtStkType"
        Me.txtStkType.Size = New System.Drawing.Size(139, 26)
        Me.txtStkType.TabIndex = 4
        '
        'txtStkName
        '
        Me.txtStkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkName.Location = New System.Drawing.Point(234, 87)
        Me.txtStkName.Name = "txtStkName"
        Me.txtStkName.Size = New System.Drawing.Size(139, 26)
        Me.txtStkName.TabIndex = 5
        '
        'txtStkDesc
        '
        Me.txtStkDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkDesc.Location = New System.Drawing.Point(234, 113)
        Me.txtStkDesc.Name = "txtStkDesc"
        Me.txtStkDesc.Size = New System.Drawing.Size(195, 26)
        Me.txtStkDesc.TabIndex = 6
        '
        'txtStkBrand
        '
        Me.txtStkBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkBrand.Location = New System.Drawing.Point(234, 139)
        Me.txtStkBrand.Name = "txtStkBrand"
        Me.txtStkBrand.Size = New System.Drawing.Size(139, 26)
        Me.txtStkBrand.TabIndex = 7
        '
        'txtStkImgPath
        '
        Me.txtStkImgPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkImgPath.Location = New System.Drawing.Point(440, 160)
        Me.txtStkImgPath.Name = "txtStkImgPath"
        Me.txtStkImgPath.Size = New System.Drawing.Size(115, 21)
        Me.txtStkImgPath.TabIndex = 58
        '
        'FrmStockAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(573, 361)
        Me.Controls.Add(Me.txtSupIDStk)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnEditID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtStkQty)
        Me.Controls.Add(Me.txtStkAftGST)
        Me.Controls.Add(Me.txtStkBeforeGST)
        Me.Controls.Add(Me.picStk)
        Me.Controls.Add(Me.cboStkStatus)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(StkIDLabel)
        Me.Controls.Add(Me.txtStkId)
        Me.Controls.Add(StkTypeLabel)
        Me.Controls.Add(Me.txtStkType)
        Me.Controls.Add(StkNameLabel)
        Me.Controls.Add(Me.txtStkName)
        Me.Controls.Add(StkDescriptionLabel)
        Me.Controls.Add(Me.txtStkDesc)
        Me.Controls.Add(StkBrandLabel)
        Me.Controls.Add(Me.txtStkBrand)
        Me.Controls.Add(StkBeforeGstLabel)
        Me.Controls.Add(StkAfterGstLabel)
        Me.Controls.Add(StkStatusLabel)
        Me.Controls.Add(StkQtyLabel)
        Me.Controls.Add(StkImageNameLabel)
        Me.Controls.Add(Me.txtStkImgPath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStockAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Details"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtSupIDStk As System.Windows.Forms.TextBox
    Friend WithEvents btnEditID As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtStkQty As System.Windows.Forms.TextBox
    Friend WithEvents txtStkAftGST As System.Windows.Forms.TextBox
    Friend WithEvents txtStkBeforeGST As System.Windows.Forms.TextBox
    Friend WithEvents picStk As System.Windows.Forms.PictureBox
    Friend WithEvents cboStkStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtStkId As System.Windows.Forms.TextBox
    Friend WithEvents txtStkType As System.Windows.Forms.TextBox
    Friend WithEvents txtStkName As System.Windows.Forms.TextBox
    Friend WithEvents txtStkDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtStkBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtStkImgPath As System.Windows.Forms.TextBox
    Friend WithEvents ofdStkImg As System.Windows.Forms.OpenFileDialog
End Class
