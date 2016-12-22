<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockUpdate))
        Me.txtSupIDStk = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ofdStkImg = New System.Windows.Forms.OpenFileDialog()
        Me.txtStkQty = New System.Windows.Forms.TextBox()
        Me.txtStkAftGST = New System.Windows.Forms.TextBox()
        Me.txtStkBeforeGST = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboStkStatus = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(115, 280)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(109, 20)
        Label1.TabIndex = 92
        Label1.Text = "Supplier ID :"
        '
        'StkIDLabel
        '
        StkIDLabel.AutoSize = True
        StkIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkIDLabel.Location = New System.Drawing.Point(135, 41)
        StkIDLabel.Name = "StkIDLabel"
        StkIDLabel.Size = New System.Drawing.Size(89, 20)
        StkIDLabel.TabIndex = 66
        StkIDLabel.Text = "Stock ID :"
        '
        'StkTypeLabel
        '
        StkTypeLabel.AutoSize = True
        StkTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkTypeLabel.Location = New System.Drawing.Point(115, 64)
        StkTypeLabel.Name = "StkTypeLabel"
        StkTypeLabel.Size = New System.Drawing.Size(108, 20)
        StkTypeLabel.TabIndex = 68
        StkTypeLabel.Text = "Stock Type :"
        '
        'StkNameLabel
        '
        StkNameLabel.AutoSize = True
        StkNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkNameLabel.Location = New System.Drawing.Point(108, 90)
        StkNameLabel.Name = "StkNameLabel"
        StkNameLabel.Size = New System.Drawing.Size(116, 20)
        StkNameLabel.TabIndex = 70
        StkNameLabel.Text = "Stock Name :"
        '
        'StkDescriptionLabel
        '
        StkDescriptionLabel.AutoSize = True
        StkDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkDescriptionLabel.Location = New System.Drawing.Point(62, 116)
        StkDescriptionLabel.Name = "StkDescriptionLabel"
        StkDescriptionLabel.Size = New System.Drawing.Size(161, 20)
        StkDescriptionLabel.TabIndex = 72
        StkDescriptionLabel.Text = "Stock Description :"
        '
        'StkBrandLabel
        '
        StkBrandLabel.AutoSize = True
        StkBrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkBrandLabel.Location = New System.Drawing.Point(106, 142)
        StkBrandLabel.Name = "StkBrandLabel"
        StkBrandLabel.Size = New System.Drawing.Size(118, 20)
        StkBrandLabel.TabIndex = 74
        StkBrandLabel.Text = "Stock Brand :"
        '
        'StkBeforeGstLabel
        '
        StkBeforeGstLabel.AutoSize = True
        StkBeforeGstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkBeforeGstLabel.Location = New System.Drawing.Point(11, 168)
        StkBeforeGstLabel.Name = "StkBeforeGstLabel"
        StkBeforeGstLabel.Size = New System.Drawing.Size(212, 20)
        StkBeforeGstLabel.TabIndex = 76
        StkBeforeGstLabel.Text = "Stock Before Gst ( RM ) :"
        '
        'StkAfterGstLabel
        '
        StkAfterGstLabel.AutoSize = True
        StkAfterGstLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkAfterGstLabel.Location = New System.Drawing.Point(25, 194)
        StkAfterGstLabel.Name = "StkAfterGstLabel"
        StkAfterGstLabel.Size = New System.Drawing.Size(198, 20)
        StkAfterGstLabel.TabIndex = 77
        StkAfterGstLabel.Text = "Stock After Gst ( RM ) :"
        '
        'StkStatusLabel
        '
        StkStatusLabel.AutoSize = True
        StkStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkStatusLabel.Location = New System.Drawing.Point(100, 220)
        StkStatusLabel.Name = "StkStatusLabel"
        StkStatusLabel.Size = New System.Drawing.Size(123, 20)
        StkStatusLabel.TabIndex = 78
        StkStatusLabel.Text = "Stock Status :"
        '
        'StkQtyLabel
        '
        StkQtyLabel.AutoSize = True
        StkQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkQtyLabel.Location = New System.Drawing.Point(126, 254)
        StkQtyLabel.Name = "StkQtyLabel"
        StkQtyLabel.Size = New System.Drawing.Size(97, 20)
        StkQtyLabel.TabIndex = 79
        StkQtyLabel.Text = "Stock Qty :"
        '
        'StkImageNameLabel
        '
        StkImageNameLabel.AutoSize = True
        StkImageNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StkImageNameLabel.Location = New System.Drawing.Point(446, 15)
        StkImageNameLabel.Name = "StkImageNameLabel"
        StkImageNameLabel.Size = New System.Drawing.Size(110, 20)
        StkImageNameLabel.TabIndex = 80
        StkImageNameLabel.Text = "Stock Image"
        AddHandler StkImageNameLabel.Click, AddressOf Me.StkImageNameLabel_Click
        '
        'txtSupIDStk
        '
        Me.txtSupIDStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupIDStk.Location = New System.Drawing.Point(240, 280)
        Me.txtSupIDStk.Name = "txtSupIDStk"
        Me.txtSupIDStk.Size = New System.Drawing.Size(80, 26)
        Me.txtSupIDStk.TabIndex = 93
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
        'txtStkQty
        '
        Me.txtStkQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkQty.Location = New System.Drawing.Point(240, 254)
        Me.txtStkQty.Name = "txtStkQty"
        Me.txtStkQty.Size = New System.Drawing.Size(80, 26)
        Me.txtStkQty.TabIndex = 91
        '
        'txtStkAftGST
        '
        Me.txtStkAftGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkAftGST.Location = New System.Drawing.Point(240, 194)
        Me.txtStkAftGST.Name = "txtStkAftGST"
        Me.txtStkAftGST.Size = New System.Drawing.Size(121, 26)
        Me.txtStkAftGST.TabIndex = 90
        '
        'txtStkBeforeGST
        '
        Me.txtStkBeforeGST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkBeforeGST.Location = New System.Drawing.Point(240, 168)
        Me.txtStkBeforeGST.Name = "txtStkBeforeGST"
        Me.txtStkBeforeGST.Size = New System.Drawing.Size(121, 26)
        Me.txtStkBeforeGST.TabIndex = 89
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(443, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'cboStkStatus
        '
        Me.cboStkStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStkStatus.FormattingEnabled = True
        Me.cboStkStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cboStkStatus.Location = New System.Drawing.Point(240, 220)
        Me.cboStkStatus.Name = "cboStkStatus"
        Me.cboStkStatus.Size = New System.Drawing.Size(121, 28)
        Me.cboStkStatus.TabIndex = 87
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(481, 272)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 86
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(481, 310)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 85
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(389, 310)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 32)
        Me.btnDelete.TabIndex = 84
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(389, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 32)
        Me.btnUpdate.TabIndex = 83
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(457, 194)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 32)
        Me.btnBrowse.TabIndex = 82
        Me.btnBrowse.Text = "&Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtStkId
        '
        Me.txtStkId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkId.Location = New System.Drawing.Point(240, 38)
        Me.txtStkId.Name = "txtStkId"
        Me.txtStkId.Size = New System.Drawing.Size(80, 26)
        Me.txtStkId.TabIndex = 67
        '
        'txtStkType
        '
        Me.txtStkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkType.Location = New System.Drawing.Point(240, 64)
        Me.txtStkType.Name = "txtStkType"
        Me.txtStkType.Size = New System.Drawing.Size(139, 26)
        Me.txtStkType.TabIndex = 69
        '
        'txtStkName
        '
        Me.txtStkName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkName.Location = New System.Drawing.Point(240, 90)
        Me.txtStkName.Name = "txtStkName"
        Me.txtStkName.Size = New System.Drawing.Size(139, 26)
        Me.txtStkName.TabIndex = 71
        '
        'txtStkDesc
        '
        Me.txtStkDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkDesc.Location = New System.Drawing.Point(240, 116)
        Me.txtStkDesc.Name = "txtStkDesc"
        Me.txtStkDesc.Size = New System.Drawing.Size(195, 26)
        Me.txtStkDesc.TabIndex = 73
        '
        'txtStkBrand
        '
        Me.txtStkBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkBrand.Location = New System.Drawing.Point(240, 142)
        Me.txtStkBrand.Name = "txtStkBrand"
        Me.txtStkBrand.Size = New System.Drawing.Size(139, 26)
        Me.txtStkBrand.TabIndex = 75
        '
        'txtStkImgPath
        '
        Me.txtStkImgPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStkImgPath.Location = New System.Drawing.Point(443, 166)
        Me.txtStkImgPath.Name = "txtStkImgPath"
        Me.txtStkImgPath.Size = New System.Drawing.Size(115, 26)
        Me.txtStkImgPath.TabIndex = 81
        '
        'FrmStockUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(585, 356)
        Me.Controls.Add(Me.txtSupIDStk)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtStkQty)
        Me.Controls.Add(Me.txtStkAftGST)
        Me.Controls.Add(Me.txtStkBeforeGST)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cboStkStatus)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Name = "FrmStockUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Update"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSupIDStk As System.Windows.Forms.TextBox
    Friend WithEvents err As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtStkQty As System.Windows.Forms.TextBox
    Friend WithEvents txtStkAftGST As System.Windows.Forms.TextBox
    Friend WithEvents txtStkBeforeGST As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboStkStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtStkId As System.Windows.Forms.TextBox
    Friend WithEvents txtStkType As System.Windows.Forms.TextBox
    Friend WithEvents txtStkName As System.Windows.Forms.TextBox
    Friend WithEvents txtStkDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtStkBrand As System.Windows.Forms.TextBox
    Friend WithEvents txtStkImgPath As System.Windows.Forms.TextBox
    Friend WithEvents ofdStkImg As System.Windows.Forms.OpenFileDialog
End Class
