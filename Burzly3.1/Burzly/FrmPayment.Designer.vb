<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayment))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPaymentID = New System.Windows.Forms.TextBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnCreadit = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.lblDisplayPrice = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(118, 448)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(478, 17)
        Me.ProgressBar1.TabIndex = 36
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Document = Me.doc
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.Visible = False
        '
        'txtTable
        '
        Me.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTable.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTable.Location = New System.Drawing.Point(96, 117)
        Me.txtTable.Name = "txtTable"
        Me.txtTable.Size = New System.Drawing.Size(100, 19)
        Me.txtTable.TabIndex = 7
        Me.txtTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTime
        '
        Me.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTime.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTime.Location = New System.Drawing.Point(96, 82)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 19)
        Me.txtTime.TabIndex = 6
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate
        '
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDate.Location = New System.Drawing.Point(96, 48)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 19)
        Me.txtDate.TabIndex = 5
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaymentID
        '
        Me.txtPaymentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentID.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtPaymentID.Location = New System.Drawing.Point(96, 16)
        Me.txtPaymentID.Name = "txtPaymentID"
        Me.txtPaymentID.Size = New System.Drawing.Size(100, 19)
        Me.txtPaymentID.TabIndex = 4
        Me.txtPaymentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(9, 117)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(95, 20)
        Me.lblTable.TabIndex = 3
        Me.lblTable.Text = "Table No : "
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(34, 85)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(62, 20)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time : "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(38, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(58, 20)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date :"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(24, 16)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(75, 20)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "ID No. : "
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(9, 433)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 32)
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtGrandTotal.Location = New System.Drawing.Point(724, 233)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtGrandTotal.TabIndex = 32
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtTotalPrice.Location = New System.Drawing.Point(724, 204)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalPrice.TabIndex = 30
        Me.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(501, 236)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(217, 20)
        Me.lblGrandTotal.TabIndex = 29
        Me.lblGrandTotal.Text = "Grand Total ( 6 % GST ) : "
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(609, 207)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(109, 20)
        Me.lblTotalPrice.TabIndex = 27
        Me.lblTotalPrice.Text = "Total Price : "
        '
        'btnCreadit
        '
        Me.btnCreadit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreadit.Location = New System.Drawing.Point(718, 431)
        Me.btnCreadit.Name = "btnCreadit"
        Me.btnCreadit.Size = New System.Drawing.Size(110, 34)
        Me.btnCreadit.TabIndex = 26
        Me.btnCreadit.Text = "Cr&edit Card"
        Me.btnCreadit.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(602, 433)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(110, 34)
        Me.btnCash.TabIndex = 25
        Me.btnCash.Text = "&Cash"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToDeleteRows = False
        Me.dgvPayment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPayment.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPayment.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvPayment.Location = New System.Drawing.Point(9, 172)
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.Size = New System.Drawing.Size(469, 150)
        Me.dgvPayment.TabIndex = 23
        '
        'lblDisplayPrice
        '
        Me.lblDisplayPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblDisplayPrice.Location = New System.Drawing.Point(233, 24)
        Me.lblDisplayPrice.Name = "lblDisplayPrice"
        Me.lblDisplayPrice.Size = New System.Drawing.Size(591, 136)
        Me.lblDisplayPrice.TabIndex = 22
        Me.lblDisplayPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTable)
        Me.GroupBox1.Controls.Add(Me.txtTime)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtPaymentID)
        Me.GroupBox1.Controls.Add(Me.lblTable)
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblPayment)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 148)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 477)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnCreadit)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.dgvPayment)
        Me.Controls.Add(Me.lblDisplayPrice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sales"
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dlgPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtTable As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentID As System.Windows.Forms.TextBox
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents btnCreadit As System.Windows.Forms.Button
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents lblDisplayPrice As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
