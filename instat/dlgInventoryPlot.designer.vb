﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInventoryPlot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.cmdInventoryPlotOptions = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.grpPlotType = New System.Windows.Forms.GroupBox()
        Me.rdoyear_doy_plot = New System.Windows.Forms.RadioButton()
        Me.rdoDatePlot = New System.Windows.Forms.RadioButton()
        Me.ucrChkDisplayRainDays = New instat.ucrCheck()
        Me.ucrPnlPlotType = New instat.UcrPanel()
        Me.ucrInputFacetBy = New instat.ucrInputComboBox()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrReceiverElements = New instat.ucrReceiverMultiple()
        Me.ucrChkShowNonMissing = New instat.ucrCheck()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkFlipCoordinates = New instat.ucrCheck()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrInventoryPlotSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblGraphTitle = New System.Windows.Forms.Label()
        Me.grpPlotType.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOptions
        '
        Me.cmdOptions.Enabled = False
        Me.cmdOptions.Location = New System.Drawing.Point(10, 222)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Text = "Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(263, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(263, 178)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(91, 13)
        Me.lblStation.TabIndex = 5
        Me.lblStation.Text = "Station (Optional):"
        '
        'cmdInventoryPlotOptions
        '
        Me.cmdInventoryPlotOptions.Enabled = False
        Me.cmdInventoryPlotOptions.Location = New System.Drawing.Point(10, 194)
        Me.cmdInventoryPlotOptions.Name = "cmdInventoryPlotOptions"
        Me.cmdInventoryPlotOptions.Size = New System.Drawing.Size(121, 23)
        Me.cmdInventoryPlotOptions.TabIndex = 7
        Me.cmdInventoryPlotOptions.Text = "Inventory Plot Options"
        Me.cmdInventoryPlotOptions.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(263, 59)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 3
        Me.lblElement.Text = "Element(s):"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.Location = New System.Drawing.Point(215, 278)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 8
        Me.lblFacetBy.Text = "Facet By:"
        '
        'grpPlotType
        '
        Me.grpPlotType.Controls.Add(Me.rdoyear_doy_plot)
        Me.grpPlotType.Controls.Add(Me.rdoDatePlot)
        Me.grpPlotType.Controls.Add(Me.ucrPnlPlotType)
        Me.grpPlotType.Location = New System.Drawing.Point(10, 255)
        Me.grpPlotType.Name = "grpPlotType"
        Me.grpPlotType.Size = New System.Drawing.Size(201, 53)
        Me.grpPlotType.TabIndex = 12
        Me.grpPlotType.TabStop = False
        Me.grpPlotType.Text = "Plot Type"
        '
        'rdoyear_doy_plot
        '
        Me.rdoyear_doy_plot.AutoSize = True
        Me.rdoyear_doy_plot.Location = New System.Drawing.Point(92, 21)
        Me.rdoyear_doy_plot.Name = "rdoyear_doy_plot"
        Me.rdoyear_doy_plot.Size = New System.Drawing.Size(100, 17)
        Me.rdoyear_doy_plot.TabIndex = 2
        Me.rdoyear_doy_plot.TabStop = True
        Me.rdoyear_doy_plot.Text = "Year - DOY Plot"
        Me.rdoyear_doy_plot.UseVisualStyleBackColor = True
        '
        'rdoDatePlot
        '
        Me.rdoDatePlot.AutoSize = True
        Me.rdoDatePlot.Location = New System.Drawing.Point(15, 21)
        Me.rdoDatePlot.Name = "rdoDatePlot"
        Me.rdoDatePlot.Size = New System.Drawing.Size(69, 17)
        Me.rdoDatePlot.TabIndex = 1
        Me.rdoDatePlot.TabStop = True
        Me.rdoDatePlot.Text = "Date Plot"
        Me.rdoDatePlot.UseVisualStyleBackColor = True
        '
        'ucrChkDisplayRainDays
        '
        Me.ucrChkDisplayRainDays.Checked = False
        Me.ucrChkDisplayRainDays.Location = New System.Drawing.Point(10, 340)
        Me.ucrChkDisplayRainDays.Name = "ucrChkDisplayRainDays"
        Me.ucrChkDisplayRainDays.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkDisplayRainDays.TabIndex = 18
        '
        'ucrPnlPlotType
        '
        Me.ucrPnlPlotType.Location = New System.Drawing.Point(6, 13)
        Me.ucrPnlPlotType.Name = "ucrPnlPlotType"
        Me.ucrPnlPlotType.Size = New System.Drawing.Size(189, 33)
        Me.ucrPnlPlotType.TabIndex = 0
        '
        'ucrInputFacetBy
        '
        Me.ucrInputFacetBy.AddQuotesIfUnrecognised = True
        Me.ucrInputFacetBy.IsReadOnly = False
        Me.ucrInputFacetBy.Location = New System.Drawing.Point(274, 274)
        Me.ucrInputFacetBy.Name = "ucrInputFacetBy"
        Me.ucrInputFacetBy.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputFacetBy.TabIndex = 9
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(263, 35)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 2
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(87, 367)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(204, 21)
        Me.ucrInputTitle.TabIndex = 15
        '
        'ucrReceiverElements
        '
        Me.ucrReceiverElements.frmParent = Me
        Me.ucrReceiverElements.Location = New System.Drawing.Point(263, 74)
        Me.ucrReceiverElements.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElements.Name = "ucrReceiverElements"
        Me.ucrReceiverElements.Selector = Nothing
        Me.ucrReceiverElements.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverElements.strNcFilePath = ""
        Me.ucrReceiverElements.TabIndex = 4
        Me.ucrReceiverElements.ucrSelector = Nothing
        '
        'ucrChkShowNonMissing
        '
        Me.ucrChkShowNonMissing.Checked = False
        Me.ucrChkShowNonMissing.Location = New System.Drawing.Point(171, 314)
        Me.ucrChkShowNonMissing.Name = "ucrChkShowNonMissing"
        Me.ucrChkShowNonMissing.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkShowNonMissing.TabIndex = 11
        Me.ucrChkShowNonMissing.Visible = False
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 394)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveGraph.TabIndex = 16
        '
        'ucrChkFlipCoordinates
        '
        Me.ucrChkFlipCoordinates.Checked = False
        Me.ucrChkFlipCoordinates.Location = New System.Drawing.Point(10, 314)
        Me.ucrChkFlipCoordinates.Name = "ucrChkFlipCoordinates"
        Me.ucrChkFlipCoordinates.Size = New System.Drawing.Size(151, 20)
        Me.ucrChkFlipCoordinates.TabIndex = 13
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(263, 193)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrInventoryPlotSelector
        '
        Me.ucrInventoryPlotSelector.bShowHiddenColumns = False
        Me.ucrInventoryPlotSelector.bUseCurrentFilter = True
        Me.ucrInventoryPlotSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrInventoryPlotSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrInventoryPlotSelector.Name = "ucrInventoryPlotSelector"
        Me.ucrInventoryPlotSelector.Size = New System.Drawing.Size(210, 180)
        Me.ucrInventoryPlotSelector.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 421)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 17
        '
        'lblGraphTitle
        '
        Me.lblGraphTitle.AutoSize = True
        Me.lblGraphTitle.Location = New System.Drawing.Point(10, 370)
        Me.lblGraphTitle.Name = "lblGraphTitle"
        Me.lblGraphTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblGraphTitle.TabIndex = 19
        Me.lblGraphTitle.Text = "Graph Title:"
        '
        'dlgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 475)
        Me.Controls.Add(Me.lblGraphTitle)
        Me.Controls.Add(Me.ucrChkDisplayRainDays)
        Me.Controls.Add(Me.grpPlotType)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputFacetBy)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.cmdInventoryPlotOptions)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ucrReceiverElements)
        Me.Controls.Add(Me.ucrChkShowNonMissing)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrChkFlipCoordinates)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrInventoryPlotSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Inventory_Plot"
        Me.Text = "Inventory Plot"
        Me.grpPlotType.ResumeLayout(False)
        Me.grpPlotType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInventoryPlotSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlipCoordinates As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkShowNonMissing As ucrCheck
    Friend WithEvents lblDate As Label
    Friend WithEvents ucrReceiverElements As ucrReceiverMultiple
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents cmdInventoryPlotOptions As Button
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrPnlPlotType As UcrPanel
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputFacetBy As ucrInputComboBox
    Friend WithEvents grpPlotType As GroupBox
    Friend WithEvents rdoyear_doy_plot As RadioButton
    Friend WithEvents rdoDatePlot As RadioButton
    Friend WithEvents ucrChkDisplayRainDays As ucrCheck
    Friend WithEvents lblGraphTitle As Label
End Class
