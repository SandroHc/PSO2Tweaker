﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOptions
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOptions))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.CMBStyle = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.ComboItem2 = New DevComponents.Editors.ComboItem()
        Me.ComboItem3 = New DevComponents.Editors.ComboItem()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.ComboItem29 = New DevComponents.Editors.ComboItem()
        Me.ComboItem30 = New DevComponents.Editors.ComboItem()
        Me.cmbLanguage = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem5 = New DevComponents.Editors.ComboItem()
        Me.ComboItem9 = New DevComponents.Editors.ComboItem()
        Me.ComboItem6 = New DevComponents.Editors.ComboItem()
        Me.ComboItem10 = New DevComponents.Editors.ComboItem()
        Me.ComboItem11 = New DevComponents.Editors.ComboItem()
        Me.ComboItem7 = New DevComponents.Editors.ComboItem()
        Me.ComboItem8 = New DevComponents.Editors.ComboItem()
        Me.ComboItem14 = New DevComponents.Editors.ComboItem()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.CheckBoxX1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.cmbBackupPreference = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem37 = New DevComponents.Editors.ComboItem()
        Me.ComboItem38 = New DevComponents.Editors.ComboItem()
        Me.ComboItem39 = New DevComponents.Editors.ComboItem()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.cmbStoryOverride = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem31 = New DevComponents.Editors.ComboItem()
        Me.ComboItem32 = New DevComponents.Editors.ComboItem()
        Me.ComboItem33 = New DevComponents.Editors.ComboItem()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.cmbENOverride = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem34 = New DevComponents.Editors.ComboItem()
        Me.ComboItem36 = New DevComponents.Editors.ComboItem()
        Me.ComboItem35 = New DevComponents.Editors.ComboItem()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.cmbLargeFilesOverride = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem41 = New DevComponents.Editors.ComboItem()
        Me.ComboItem42 = New DevComponents.Editors.ComboItem()
        Me.ComboItem40 = New DevComponents.Editors.ComboItem()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.btnPSO2Override = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.chkAutoRemoveCensor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.cmbPredownload = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem15 = New DevComponents.Editors.ComboItem()
        Me.ComboItem17 = New DevComponents.Editors.ComboItem()
        Me.CheckBoxX2 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkUseIcsHost = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorPickerButton1 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.ColorPickerButton2 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.ColorPickerButton3 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.ColorPickerButton4 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.btnChooseOrb = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxX3 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX4 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.ColorPickerButton5 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.cpbFill1 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.cpbFill2 = New DevComponents.DotNetBar.ColorPickerButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBoxX6 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.CheckBoxX7 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.Name = "LabelX1"
        '
        'CMBStyle
        '
        Me.CMBStyle.DisplayMember = "Text"
        Me.CMBStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBStyle.FormattingEnabled = True
        Me.CMBStyle.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem29, Me.ComboItem30})
        resources.ApplyResources(Me.CMBStyle, "CMBStyle")
        Me.CMBStyle.Name = "CMBStyle"
        Me.CMBStyle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem1
        '
        resources.ApplyResources(Me.ComboItem1, "ComboItem1")
        '
        'ComboItem2
        '
        resources.ApplyResources(Me.ComboItem2, "ComboItem2")
        '
        'ComboItem3
        '
        resources.ApplyResources(Me.ComboItem3, "ComboItem3")
        '
        'ComboItem4
        '
        resources.ApplyResources(Me.ComboItem4, "ComboItem4")
        '
        'ComboItem29
        '
        resources.ApplyResources(Me.ComboItem29, "ComboItem29")
        '
        'ComboItem30
        '
        resources.ApplyResources(Me.ComboItem30, "ComboItem30")
        '
        'cmbLanguage
        '
        Me.cmbLanguage.DisplayMember = "Text"
        Me.cmbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLanguage.FormattingEnabled = True
        resources.ApplyResources(Me.cmbLanguage, "cmbLanguage")
        Me.cmbLanguage.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem9, Me.ComboItem6, Me.ComboItem10, Me.ComboItem11, Me.ComboItem7, Me.ComboItem8, Me.ComboItem14})
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem5
        '
        resources.ApplyResources(Me.ComboItem5, "ComboItem5")
        '
        'ComboItem9
        '
        resources.ApplyResources(Me.ComboItem9, "ComboItem9")
        '
        'ComboItem6
        '
        resources.ApplyResources(Me.ComboItem6, "ComboItem6")
        '
        'ComboItem10
        '
        resources.ApplyResources(Me.ComboItem10, "ComboItem10")
        '
        'ComboItem11
        '
        resources.ApplyResources(Me.ComboItem11, "ComboItem11")
        '
        'ComboItem7
        '
        resources.ApplyResources(Me.ComboItem7, "ComboItem7")
        '
        'ComboItem8
        '
        resources.ApplyResources(Me.ComboItem8, "ComboItem8")
        '
        'ComboItem14
        '
        resources.ApplyResources(Me.ComboItem14, "ComboItem14")
        '
        'LabelX2
        '
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.Name = "LabelX2"
        '
        'LabelX4
        '
        resources.ApplyResources(Me.LabelX4, "LabelX4")
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.Name = "LabelX4"
        '
        'CheckBoxX1
        '
        Me.CheckBoxX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX1.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX1, "CheckBoxX1")
        Me.CheckBoxX1.Name = "CheckBoxX1"
        Me.CheckBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX6
        '
        resources.ApplyResources(Me.LabelX6, "LabelX6")
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.Name = "LabelX6"
        '
        'cmbBackupPreference
        '
        Me.cmbBackupPreference.DisplayMember = "Text"
        Me.cmbBackupPreference.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBackupPreference.FormattingEnabled = True
        Me.cmbBackupPreference.Items.AddRange(New Object() {Me.ComboItem37, Me.ComboItem38, Me.ComboItem39})
        resources.ApplyResources(Me.cmbBackupPreference, "cmbBackupPreference")
        Me.cmbBackupPreference.Name = "cmbBackupPreference"
        Me.cmbBackupPreference.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem37
        '
        resources.ApplyResources(Me.ComboItem37, "ComboItem37")
        '
        'ComboItem38
        '
        resources.ApplyResources(Me.ComboItem38, "ComboItem38")
        '
        'ComboItem39
        '
        resources.ApplyResources(Me.ComboItem39, "ComboItem39")
        '
        'LabelX7
        '
        resources.ApplyResources(Me.LabelX7, "LabelX7")
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.Name = "LabelX7"
        '
        'cmbStoryOverride
        '
        Me.cmbStoryOverride.DisplayMember = "Text"
        Me.cmbStoryOverride.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbStoryOverride.FormattingEnabled = True
        Me.cmbStoryOverride.Items.AddRange(New Object() {Me.ComboItem31, Me.ComboItem32, Me.ComboItem33})
        resources.ApplyResources(Me.cmbStoryOverride, "cmbStoryOverride")
        Me.cmbStoryOverride.Name = "cmbStoryOverride"
        Me.cmbStoryOverride.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem31
        '
        resources.ApplyResources(Me.ComboItem31, "ComboItem31")
        '
        'ComboItem32
        '
        resources.ApplyResources(Me.ComboItem32, "ComboItem32")
        '
        'ComboItem33
        '
        resources.ApplyResources(Me.ComboItem33, "ComboItem33")
        '
        'LabelX8
        '
        resources.ApplyResources(Me.LabelX8, "LabelX8")
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.Name = "LabelX8"
        '
        'cmbENOverride
        '
        Me.cmbENOverride.DisplayMember = "Text"
        Me.cmbENOverride.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbENOverride.FormattingEnabled = True
        Me.cmbENOverride.Items.AddRange(New Object() {Me.ComboItem34, Me.ComboItem36, Me.ComboItem35})
        resources.ApplyResources(Me.cmbENOverride, "cmbENOverride")
        Me.cmbENOverride.Name = "cmbENOverride"
        Me.cmbENOverride.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem34
        '
        resources.ApplyResources(Me.ComboItem34, "ComboItem34")
        '
        'ComboItem36
        '
        resources.ApplyResources(Me.ComboItem36, "ComboItem36")
        '
        'ComboItem35
        '
        resources.ApplyResources(Me.ComboItem35, "ComboItem35")
        '
        'LabelX9
        '
        resources.ApplyResources(Me.LabelX9, "LabelX9")
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.Name = "LabelX9"
        '
        'cmbLargeFilesOverride
        '
        Me.cmbLargeFilesOverride.DisplayMember = "Text"
        Me.cmbLargeFilesOverride.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLargeFilesOverride.FormattingEnabled = True
        Me.cmbLargeFilesOverride.Items.AddRange(New Object() {Me.ComboItem41, Me.ComboItem42, Me.ComboItem40})
        resources.ApplyResources(Me.cmbLargeFilesOverride, "cmbLargeFilesOverride")
        Me.cmbLargeFilesOverride.Name = "cmbLargeFilesOverride"
        Me.cmbLargeFilesOverride.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem41
        '
        resources.ApplyResources(Me.ComboItem41, "ComboItem41")
        '
        'ComboItem42
        '
        resources.ApplyResources(Me.ComboItem42, "ComboItem42")
        '
        'ComboItem40
        '
        resources.ApplyResources(Me.ComboItem40, "ComboItem40")
        '
        'LabelX10
        '
        resources.ApplyResources(Me.LabelX10, "LabelX10")
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.Name = "LabelX10"
        '
        'btnPSO2Override
        '
        Me.btnPSO2Override.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPSO2Override.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnPSO2Override, "btnPSO2Override")
        Me.btnPSO2Override.Name = "btnPSO2Override"
        Me.btnPSO2Override.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX11
        '
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.LabelX11, "LabelX11")
        Me.LabelX11.Name = "LabelX11"
        '
        'LabelX12
        '
        resources.ApplyResources(Me.LabelX12, "LabelX12")
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.Name = "LabelX12"
        '
        'chkAutoRemoveCensor
        '
        Me.chkAutoRemoveCensor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkAutoRemoveCensor.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.chkAutoRemoveCensor, "chkAutoRemoveCensor")
        Me.chkAutoRemoveCensor.Name = "chkAutoRemoveCensor"
        Me.chkAutoRemoveCensor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX14
        '
        resources.ApplyResources(Me.LabelX14, "LabelX14")
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.Class = ""
        Me.LabelX14.Name = "LabelX14"
        '
        'cmbPredownload
        '
        Me.cmbPredownload.DisplayMember = "Text"
        Me.cmbPredownload.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPredownload.FormattingEnabled = True
        Me.cmbPredownload.Items.AddRange(New Object() {Me.ComboItem15, Me.ComboItem17})
        resources.ApplyResources(Me.cmbPredownload, "cmbPredownload")
        Me.cmbPredownload.Name = "cmbPredownload"
        Me.cmbPredownload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ComboItem15
        '
        resources.ApplyResources(Me.ComboItem15, "ComboItem15")
        '
        'ComboItem17
        '
        resources.ApplyResources(Me.ComboItem17, "ComboItem17")
        '
        'CheckBoxX2
        '
        Me.CheckBoxX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX2.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX2, "CheckBoxX2")
        Me.CheckBoxX2.Name = "CheckBoxX2"
        Me.CheckBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkUseIcsHost
        '
        '
        '
        '
        Me.chkUseIcsHost.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.chkUseIcsHost, "chkUseIcsHost")
        Me.chkUseIcsHost.Name = "chkUseIcsHost"
        Me.chkUseIcsHost.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.ButtonX2, "ButtonX2")
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ColorPickerButton1
        '
        Me.ColorPickerButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton1.Image = CType(resources.GetObject("ColorPickerButton1.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.ColorPickerButton1, "ColorPickerButton1")
        Me.ColorPickerButton1.Name = "ColorPickerButton1"
        Me.ColorPickerButton1.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ColorPickerButton2
        '
        Me.ColorPickerButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton2.Image = CType(resources.GetObject("ColorPickerButton2.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.ColorPickerButton2, "ColorPickerButton2")
        Me.ColorPickerButton2.Name = "ColorPickerButton2"
        Me.ColorPickerButton2.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ColorPickerButton3
        '
        Me.ColorPickerButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton3.Image = CType(resources.GetObject("ColorPickerButton3.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.ColorPickerButton3, "ColorPickerButton3")
        Me.ColorPickerButton3.Name = "ColorPickerButton3"
        Me.ColorPickerButton3.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ColorPickerButton4
        '
        Me.ColorPickerButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton4.Image = CType(resources.GetObject("ColorPickerButton4.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.ColorPickerButton4, "ColorPickerButton4")
        Me.ColorPickerButton4.Name = "ColorPickerButton4"
        Me.ColorPickerButton4.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnChooseOrb
        '
        Me.btnChooseOrb.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnChooseOrb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnChooseOrb, "btnChooseOrb")
        Me.btnChooseOrb.Name = "btnChooseOrb"
        Me.btnChooseOrb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'CheckBoxX3
        '
        Me.CheckBoxX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX3.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX3, "CheckBoxX3")
        Me.CheckBoxX3.Name = "CheckBoxX3"
        Me.CheckBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'CheckBoxX4
        '
        Me.CheckBoxX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX4.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX4, "CheckBoxX4")
        Me.CheckBoxX4.Name = "CheckBoxX4"
        Me.CheckBoxX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        Me.LabelX3.Name = "LabelX3"
        '
        'ColorPickerButton5
        '
        Me.ColorPickerButton5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ColorPickerButton5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ColorPickerButton5.Image = CType(resources.GetObject("ColorPickerButton5.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.ColorPickerButton5, "ColorPickerButton5")
        Me.ColorPickerButton5.Name = "ColorPickerButton5"
        Me.ColorPickerButton5.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.ColorPickerButton5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'LabelX13
        '
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.LabelX13, "LabelX13")
        Me.LabelX13.Name = "LabelX13"
        '
        'cpbFill1
        '
        Me.cpbFill1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cpbFill1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cpbFill1.Image = CType(resources.GetObject("cpbFill1.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.cpbFill1, "cpbFill1")
        Me.cpbFill1.Name = "cpbFill1"
        Me.cpbFill1.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.cpbFill1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'cpbFill2
        '
        Me.cpbFill2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cpbFill2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cpbFill2.Image = CType(resources.GetObject("cpbFill2.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.cpbFill2, "cpbFill2")
        Me.cpbFill2.Name = "cpbFill2"
        Me.cpbFill2.SelectedColorImageRectangle = New System.Drawing.Rectangle(2, 2, 12, 12)
        Me.cpbFill2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'CheckBoxX6
        '
        Me.CheckBoxX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX6.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX6, "CheckBoxX6")
        Me.CheckBoxX6.Name = "CheckBoxX6"
        Me.CheckBoxX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'CheckBoxX7
        '
        Me.CheckBoxX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckBoxX7.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.CheckBoxX7, "CheckBoxX7")
        Me.CheckBoxX7.Name = "CheckBoxX7"
        Me.CheckBoxX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.ButtonX1, "ButtonX1")
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'FrmOptions
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.CheckBoxX7)
        Me.Controls.Add(Me.CheckBoxX6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cpbFill2)
        Me.Controls.Add(Me.LabelX13)
        Me.Controls.Add(Me.cpbFill1)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.ColorPickerButton5)
        Me.Controls.Add(Me.CheckBoxX4)
        Me.Controls.Add(Me.CheckBoxX3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChooseOrb)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.chkUseIcsHost)
        Me.Controls.Add(Me.chkAutoRemoveCensor)
        Me.Controls.Add(Me.CheckBoxX1)
        Me.Controls.Add(Me.CheckBoxX2)
        Me.Controls.Add(Me.LabelX14)
        Me.Controls.Add(Me.cmbPredownload)
        Me.Controls.Add(Me.LabelX11)
        Me.Controls.Add(Me.ColorPickerButton3)
        Me.Controls.Add(Me.LabelX12)
        Me.Controls.Add(Me.ColorPickerButton4)
        Me.Controls.Add(Me.btnPSO2Override)
        Me.Controls.Add(Me.cmbLargeFilesOverride)
        Me.Controls.Add(Me.LabelX10)
        Me.Controls.Add(Me.cmbENOverride)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.cmbStoryOverride)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.cmbBackupPreference)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.ColorPickerButton2)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.ColorPickerButton1)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.CMBStyle)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOptions"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CMBStyle As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents cmbLanguage As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem29 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem30 As DevComponents.Editors.ComboItem
    Friend WithEvents ColorPickerButton1 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CheckBoxX1 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColorPickerButton2 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents cmbBackupPreference As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem37 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem38 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem39 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbStoryOverride As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem31 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem32 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem33 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbENOverride As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem34 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem36 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbLargeFilesOverride As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem41 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem42 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem35 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem40 As DevComponents.Editors.ComboItem
    Friend WithEvents btnPSO2Override As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColorPickerButton3 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColorPickerButton4 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents chkAutoRemoveCensor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbPredownload As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents CheckBoxX2 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkUseIcsHost As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnChooseOrb As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxX3 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX4 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ColorPickerButton5 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cpbFill1 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents cpbFill2 As DevComponents.DotNetBar.ColorPickerButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxX6 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CheckBoxX7 As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
End Class
