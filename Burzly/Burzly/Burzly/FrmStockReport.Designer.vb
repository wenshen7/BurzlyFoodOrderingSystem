﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockReport))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BurzlyDBDataSet = New Burzly.BurzlyDBDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Burzly.BurzlyDBDataSetTableAdapters.StockTableAdapter()
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "StockReport"
        ReportDataSource1.Value = Me.StockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Burzly.StockReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(889, 725)
        Me.ReportViewer1.TabIndex = 0
        '
        'BurzlyDBDataSet
        '
        Me.BurzlyDBDataSet.DataSetName = "BurzlyDBDataSet"
        Me.BurzlyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.BurzlyDBDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'FrmStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 725)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStockReport"
        Me.Text = "Monthly Report"
        CType(Me.BurzlyDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BurzlyDBDataSet As Burzly.BurzlyDBDataSet
    Friend WithEvents StockTableAdapter As Burzly.BurzlyDBDataSetTableAdapters.StockTableAdapter
End Class
