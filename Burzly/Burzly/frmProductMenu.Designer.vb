<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductMenu))
        Me.mnuManage = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BurgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnacksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DessertsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.btnBurger = New System.Windows.Forms.Button()
        Me.btnBeverage = New System.Windows.Forms.Button()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnSnack = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.mnuManage.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuManage
        '
        Me.mnuManage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuManage.Location = New System.Drawing.Point(0, 0)
        Me.mnuManage.Name = "mnuManage"
        Me.mnuManage.Size = New System.Drawing.Size(844, 24)
        Me.mnuManage.TabIndex = 81
        Me.mnuManage.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductToolStripMenuItem})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'AddProductToolStripMenuItem
        '
        Me.AddProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BurgerToolStripMenuItem, Me.DrinksToolStripMenuItem, Me.SnacksToolStripMenuItem, Me.DessertsToolStripMenuItem})
        Me.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem"
        Me.AddProductToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddProductToolStripMenuItem.Text = "&Add Product"
        '
        'BurgerToolStripMenuItem
        '
        Me.BurgerToolStripMenuItem.Name = "BurgerToolStripMenuItem"
        Me.BurgerToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.BurgerToolStripMenuItem.Text = "Burgers"
        '
        'DrinksToolStripMenuItem
        '
        Me.DrinksToolStripMenuItem.Name = "DrinksToolStripMenuItem"
        Me.DrinksToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DrinksToolStripMenuItem.Text = "Drinks"
        '
        'SnacksToolStripMenuItem
        '
        Me.SnacksToolStripMenuItem.Name = "SnacksToolStripMenuItem"
        Me.SnacksToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SnacksToolStripMenuItem.Text = "Snacks"
        '
        'DessertsToolStripMenuItem
        '
        Me.DessertsToolStripMenuItem.Name = "DessertsToolStripMenuItem"
        Me.DessertsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DessertsToolStripMenuItem.Text = "Desserts"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'grpProduct
        '
        Me.grpProduct.AutoSize = True
        Me.grpProduct.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.grpProduct.ForeColor = System.Drawing.Color.White
        Me.grpProduct.Location = New System.Drawing.Point(22, 48)
        Me.grpProduct.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(797, 476)
        Me.grpProduct.TabIndex = 5
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Burgers"
        '
        'btnBurger
        '
        Me.btnBurger.BackColor = System.Drawing.Color.Transparent
        Me.btnBurger.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnBurger.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBurger.Location = New System.Drawing.Point(15, 8)
        Me.btnBurger.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBurger.Name = "btnBurger"
        Me.btnBurger.Size = New System.Drawing.Size(90, 38)
        Me.btnBurger.TabIndex = 1
        Me.btnBurger.Text = "Burgers"
        Me.btnBurger.UseVisualStyleBackColor = False
        '
        'btnBeverage
        '
        Me.btnBeverage.BackColor = System.Drawing.Color.Transparent
        Me.btnBeverage.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeverage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBeverage.Location = New System.Drawing.Point(104, 8)
        Me.btnBeverage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBeverage.Name = "btnBeverage"
        Me.btnBeverage.Size = New System.Drawing.Size(90, 38)
        Me.btnBeverage.TabIndex = 2
        Me.btnBeverage.Text = "Drinks"
        Me.btnBeverage.UseVisualStyleBackColor = False
        '
        'btnDesserts
        '
        Me.btnDesserts.BackColor = System.Drawing.Color.Transparent
        Me.btnDesserts.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnDesserts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDesserts.Location = New System.Drawing.Point(282, 8)
        Me.btnDesserts.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(100, 38)
        Me.btnDesserts.TabIndex = 4
        Me.btnDesserts.Text = "Desserts"
        Me.btnDesserts.UseVisualStyleBackColor = False
        '
        'btnSnack
        '
        Me.btnSnack.BackColor = System.Drawing.Color.Transparent
        Me.btnSnack.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnSnack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSnack.Location = New System.Drawing.Point(193, 8)
        Me.btnSnack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSnack.Name = "btnSnack"
        Me.btnSnack.Size = New System.Drawing.Size(90, 38)
        Me.btnSnack.TabIndex = 3
        Me.btnSnack.Text = "Snacks"
        Me.btnSnack.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.lblPay)
        Me.pnlMain.Controls.Add(Me.lblSummary)
        Me.pnlMain.Controls.Add(Me.lblTableNo)
        Me.pnlMain.Controls.Add(Me.btnSnack)
        Me.pnlMain.Controls.Add(Me.btnDesserts)
        Me.pnlMain.Controls.Add(Me.btnBeverage)
        Me.pnlMain.Controls.Add(Me.btnBurger)
        Me.pnlMain.Controls.Add(Me.grpProduct)
        Me.pnlMain.Location = New System.Drawing.Point(0, 24)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(844, 537)
        Me.pnlMain.TabIndex = 83
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.White
        Me.lblPay.Location = New System.Drawing.Point(733, 33)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(54, 13)
        Me.lblPay.TabIndex = 8
        Me.lblPay.Text = "(Payment)"
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.ForeColor = System.Drawing.Color.White
        Me.lblSummary.Location = New System.Drawing.Point(733, 17)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(56, 13)
        Me.lblSummary.TabIndex = 7
        Me.lblSummary.Text = "(Summary)"
        '
        'lblTableNo
        '
        Me.lblTableNo.AutoSize = True
        Me.lblTableNo.ForeColor = System.Drawing.Color.White
        Me.lblTableNo.Location = New System.Drawing.Point(730, 0)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(57, 13)
        Me.lblTableNo.TabIndex = 6
        Me.lblTableNo.Text = "Table No :"
        '
        'frmProductMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(844, 561)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.mnuManage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuManage
        Me.MaximizeBox = False
        Me.Name = "frmProductMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Menu"
        Me.mnuManage.ResumeLayout(False)
        Me.mnuManage.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuManage As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BurgerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SnacksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DessertsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpProduct As System.Windows.Forms.GroupBox
    Friend WithEvents btnBurger As System.Windows.Forms.Button
    Friend WithEvents btnBeverage As System.Windows.Forms.Button
    Friend WithEvents btnDesserts As System.Windows.Forms.Button
    Friend WithEvents btnSnack As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblTableNo As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents lblPay As System.Windows.Forms.Label

End Class
