<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMNew_Outpatient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMNew_Outpatient))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChTypeOther = New System.Windows.Forms.CheckBox
        Me.DateFollowUp = New System.Windows.Forms.DateTimePicker
        Me.RadioDolar = New System.Windows.Forms.RadioButton
        Me.RadioRiel = New System.Windows.Forms.RadioButton
        Me.CboDiagnosis = New System.Windows.Forms.ComboBox
        Me.TxtOther = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblLoadData = New System.Windows.Forms.LinkLabel
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.TxtPatientFee = New System.Windows.Forms.TextBox
        Me.TxtReceiptNo = New System.Windows.Forms.TextBox
        Me.TxtSex = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtAge = New System.Windows.Forms.Label
        Me.TxtAddress = New System.Windows.Forms.Label
        Me.TxtPatientName = New System.Windows.Forms.Label
        Me.TxtPatientNo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChPhysical = New System.Windows.Forms.CheckBox
        Me.ChSeeing = New System.Windows.Forms.CheckBox
        Me.ChUnderstand = New System.Windows.Forms.CheckBox
        Me.ChHearing = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChDispensed = New System.Windows.Forms.CheckBox
        Me.ChPrescribed = New System.Windows.Forms.CheckBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.ErrNewOutPatient = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrNewOutPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ChTypeOther)
        Me.GroupBox1.Controls.Add(Me.DateFollowUp)
        Me.GroupBox1.Controls.Add(Me.RadioDolar)
        Me.GroupBox1.Controls.Add(Me.RadioRiel)
        Me.GroupBox1.Controls.Add(Me.CboDiagnosis)
        Me.GroupBox1.Controls.Add(Me.TxtOther)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.LblLoadData)
        Me.GroupBox1.Controls.Add(Me.LblSaveOption)
        Me.GroupBox1.Controls.Add(Me.TxtPatientFee)
        Me.GroupBox1.Controls.Add(Me.TxtReceiptNo)
        Me.GroupBox1.Controls.Add(Me.TxtSex)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtAge)
        Me.GroupBox1.Controls.Add(Me.TxtAddress)
        Me.GroupBox1.Controls.Add(Me.TxtPatientName)
        Me.GroupBox1.Controls.Add(Me.TxtPatientNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Info"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KTGSYS.My.Resources.Resources.Warning
        Me.PictureBox1.Location = New System.Drawing.Point(289, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Khmer OS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(316, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 58)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "សំរាប់កត់ត្រាព័ត៌មានអ្នកជម្ងឺចូល NEW PATIENT BOOK"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ChTypeOther
        '
        Me.ChTypeOther.AutoSize = True
        Me.ChTypeOther.BackColor = System.Drawing.Color.Transparent
        Me.ChTypeOther.Location = New System.Drawing.Point(460, 296)
        Me.ChTypeOther.Name = "ChTypeOther"
        Me.ChTypeOther.Size = New System.Drawing.Size(79, 17)
        Me.ChTypeOther.TabIndex = 13
        Me.ChTypeOther.Text = "Type Other"
        Me.ChTypeOther.UseVisualStyleBackColor = False
        Me.ChTypeOther.Visible = False
        '
        'DateFollowUp
        '
        Me.DateFollowUp.Checked = False
        Me.DateFollowUp.CustomFormat = "dd/MM/yyyy"
        Me.DateFollowUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFollowUp.Location = New System.Drawing.Point(95, 18)
        Me.DateFollowUp.Name = "DateFollowUp"
        Me.DateFollowUp.ShowCheckBox = True
        Me.DateFollowUp.Size = New System.Drawing.Size(184, 26)
        Me.DateFollowUp.TabIndex = 0
        '
        'RadioDolar
        '
        Me.RadioDolar.AutoSize = True
        Me.RadioDolar.Location = New System.Drawing.Point(383, 273)
        Me.RadioDolar.Name = "RadioDolar"
        Me.RadioDolar.Size = New System.Drawing.Size(31, 17)
        Me.RadioDolar.TabIndex = 12
        Me.RadioDolar.Text = "$"
        Me.RadioDolar.UseVisualStyleBackColor = True
        '
        'RadioRiel
        '
        Me.RadioRiel.AutoSize = True
        Me.RadioRiel.Checked = True
        Me.RadioRiel.Location = New System.Drawing.Point(334, 272)
        Me.RadioRiel.Name = "RadioRiel"
        Me.RadioRiel.Size = New System.Drawing.Size(43, 17)
        Me.RadioRiel.TabIndex = 12
        Me.RadioRiel.TabStop = True
        Me.RadioRiel.Text = "Riel"
        Me.RadioRiel.UseVisualStyleBackColor = True
        '
        'CboDiagnosis
        '
        Me.CboDiagnosis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDiagnosis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDiagnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiagnosis.FormattingEnabled = True
        Me.CboDiagnosis.Location = New System.Drawing.Point(92, 304)
        Me.CboDiagnosis.Name = "CboDiagnosis"
        Me.CboDiagnosis.Size = New System.Drawing.Size(235, 28)
        Me.CboDiagnosis.TabIndex = 8
        '
        'TxtOther
        '
        Me.TxtOther.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtOther.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TxtOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOther.FormattingEnabled = True
        Me.TxtOther.Location = New System.Drawing.Point(398, 296)
        Me.TxtOther.Name = "TxtOther"
        Me.TxtOther.Size = New System.Drawing.Size(54, 28)
        Me.TxtOther.TabIndex = 9
        Me.TxtOther.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 312)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Diagnosis:"
        '
        'LblLoadData
        '
        Me.LblLoadData.AutoSize = True
        Me.LblLoadData.Location = New System.Drawing.Point(471, 319)
        Me.LblLoadData.Name = "LblLoadData"
        Me.LblLoadData.Size = New System.Drawing.Size(57, 13)
        Me.LblLoadData.TabIndex = 9
        Me.LblLoadData.TabStop = True
        Me.LblLoadData.Text = "Load Data"
        Me.LblLoadData.Visible = False
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.Location = New System.Drawing.Point(496, 34)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(13, 13)
        Me.LblSaveOption.TabIndex = 5
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'TxtPatientFee
        '
        Me.TxtPatientFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientFee.Location = New System.Drawing.Point(92, 264)
        Me.TxtPatientFee.Name = "TxtPatientFee"
        Me.TxtPatientFee.Size = New System.Drawing.Size(235, 26)
        Me.TxtPatientFee.TabIndex = 7
        Me.TxtPatientFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtReceiptNo
        '
        Me.TxtReceiptNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReceiptNo.Location = New System.Drawing.Point(95, 50)
        Me.TxtReceiptNo.Name = "TxtReceiptNo"
        Me.TxtReceiptNo.Size = New System.Drawing.Size(184, 26)
        Me.TxtReceiptNo.TabIndex = 1
        '
        'TxtSex
        '
        Me.TxtSex.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSex.Location = New System.Drawing.Point(229, 159)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(50, 23)
        Me.TxtSex.TabIndex = 5
        Me.TxtSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(351, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Other"
        Me.Label15.Visible = False
        '
        'TxtAge
        '
        Me.TxtAge.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAge.Location = New System.Drawing.Point(138, 159)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(50, 23)
        Me.TxtAge.TabIndex = 4
        Me.TxtAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(9, 190)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(515, 61)
        Me.TxtAddress.TabIndex = 6
        '
        'TxtPatientName
        '
        Me.TxtPatientName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientName.Font = New System.Drawing.Font("Wat Phnom T3", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(95, 117)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(184, 34)
        Me.TxtPatientName.TabIndex = 3
        Me.TxtPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPatientNo
        '
        Me.TxtPatientNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPatientNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtPatientNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientNo.Location = New System.Drawing.Point(95, 86)
        Me.TxtPatientNo.Name = "TxtPatientNo"
        Me.TxtPatientNo.Size = New System.Drawing.Size(184, 23)
        Me.TxtPatientNo.TabIndex = 2
        Me.TxtPatientNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Patient Fee:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(194, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sex:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Age:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name of patient:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Date FollowUp:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Receipt No:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 369)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(84, 22)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Patient Disability"
        Me.GroupBox4.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChPhysical)
        Me.GroupBox3.Controls.Add(Me.ChSeeing)
        Me.GroupBox3.Controls.Add(Me.ChUnderstand)
        Me.GroupBox3.Controls.Add(Me.ChHearing)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(184, 127)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Defficulty"
        '
        'ChPhysical
        '
        Me.ChPhysical.AutoSize = True
        Me.ChPhysical.Location = New System.Drawing.Point(6, 101)
        Me.ChPhysical.Name = "ChPhysical"
        Me.ChPhysical.Size = New System.Drawing.Size(109, 17)
        Me.ChPhysical.TabIndex = 3
        Me.ChPhysical.Text = "&Physical Disability"
        Me.ChPhysical.UseVisualStyleBackColor = True
        '
        'ChSeeing
        '
        Me.ChSeeing.AutoSize = True
        Me.ChSeeing.Location = New System.Drawing.Point(6, 78)
        Me.ChSeeing.Name = "ChSeeing"
        Me.ChSeeing.Size = New System.Drawing.Size(59, 17)
        Me.ChSeeing.TabIndex = 2
        Me.ChSeeing.Text = "S&eeing"
        Me.ChSeeing.UseVisualStyleBackColor = True
        '
        'ChUnderstand
        '
        Me.ChUnderstand.AutoSize = True
        Me.ChUnderstand.Location = New System.Drawing.Point(6, 53)
        Me.ChUnderstand.Name = "ChUnderstand"
        Me.ChUnderstand.Size = New System.Drawing.Size(173, 17)
        Me.ChUnderstand.TabIndex = 1
        Me.ChUnderstand.Text = "&Understand/Intellculual/Mental"
        Me.ChUnderstand.UseVisualStyleBackColor = True
        '
        'ChHearing
        '
        Me.ChHearing.AutoSize = True
        Me.ChHearing.Location = New System.Drawing.Point(6, 28)
        Me.ChHearing.Name = "ChHearing"
        Me.ChHearing.Size = New System.Drawing.Size(63, 17)
        Me.ChHearing.TabIndex = 0
        Me.ChHearing.Text = "&Hearing"
        Me.ChHearing.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChDispensed)
        Me.GroupBox2.Controls.Add(Me.ChPrescribed)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 127)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Spectacles"
        '
        'ChDispensed
        '
        Me.ChDispensed.AutoSize = True
        Me.ChDispensed.Location = New System.Drawing.Point(6, 54)
        Me.ChDispensed.Name = "ChDispensed"
        Me.ChDispensed.Size = New System.Drawing.Size(76, 17)
        Me.ChDispensed.TabIndex = 1
        Me.ChDispensed.Text = "&Dispensed"
        Me.ChDispensed.UseVisualStyleBackColor = True
        '
        'ChPrescribed
        '
        Me.ChPrescribed.AutoSize = True
        Me.ChPrescribed.Location = New System.Drawing.Point(6, 28)
        Me.ChPrescribed.Name = "ChPrescribed"
        Me.ChPrescribed.Size = New System.Drawing.Size(76, 17)
        Me.ChPrescribed.TabIndex = 0
        Me.ChPrescribed.Text = "Prescri&bed"
        Me.ChPrescribed.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.Location = New System.Drawing.Point(199, 356)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(281, 356)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 35)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'ErrNewOutPatient
        '
        Me.ErrNewOutPatient.ContainerControl = Me
        '
        'FRMNew_Outpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMNew_Outpatient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW PATIENT BOOK"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrNewOutPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatientNo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSex As System.Windows.Forms.Label
    Friend WithEvents TxtAge As System.Windows.Forms.Label
    Friend WithEvents TxtAddress As System.Windows.Forms.Label
    Friend WithEvents TxtPatientName As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents ErrNewOutPatient As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblLoadData As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChUnderstand As System.Windows.Forms.CheckBox
    Friend WithEvents ChHearing As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ChPhysical As System.Windows.Forms.CheckBox
    Friend WithEvents ChSeeing As System.Windows.Forms.CheckBox
    Friend WithEvents CboDiagnosis As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChDispensed As System.Windows.Forms.CheckBox
    Friend WithEvents ChPrescribed As System.Windows.Forms.CheckBox
    Friend WithEvents TxtPatientFee As System.Windows.Forms.TextBox
    Friend WithEvents TxtOther As System.Windows.Forms.ComboBox
    Friend WithEvents RadioDolar As System.Windows.Forms.RadioButton
    Friend WithEvents RadioRiel As System.Windows.Forms.RadioButton
    Friend WithEvents DateFollowUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChTypeOther As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
