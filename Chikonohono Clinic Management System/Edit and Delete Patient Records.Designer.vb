<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_and_Update_Patient_Records
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
        Me.lblPatient_Registration = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete_Record = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.GrpBoxResults = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.date_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.Registration_Number = New System.Windows.Forms.Label()
        Me.txtContact_Number = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.txtRegistration_Number = New System.Windows.Forms.TextBox()
        Me.txtNational_id = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDate_Of_Birth = New System.Windows.Forms.Label()
        Me.lblContact_Number = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirst_Name = New System.Windows.Forms.Label()
        Me.lblNational_id = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.CB_Bloodgp = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.GrpBoxResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPatient_Registration
        '
        Me.lblPatient_Registration.AutoSize = True
        Me.lblPatient_Registration.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Registration.Location = New System.Drawing.Point(499, 24)
        Me.lblPatient_Registration.Name = "lblPatient_Registration"
        Me.lblPatient_Registration.Size = New System.Drawing.Size(359, 42)
        Me.lblPatient_Registration.TabIndex = 8
        Me.lblPatient_Registration.Text = "Edit Patient Records"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(782, 645)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 46)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete_Record
        '
        Me.btnDelete_Record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete_Record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete_Record.Location = New System.Drawing.Point(422, 645)
        Me.btnDelete_Record.Name = "btnDelete_Record"
        Me.btnDelete_Record.Size = New System.Drawing.Size(158, 46)
        Me.btnDelete_Record.TabIndex = 13
        Me.btnDelete_Record.Text = "Delete Record"
        Me.btnDelete_Record.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate_record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(602, 645)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(158, 46)
        Me.btnUpdate_record.TabIndex = 13
        Me.btnUpdate_record.Text = "Update Record"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'GrpBoxResults
        '
        Me.GrpBoxResults.Controls.Add(Me.ComboBoxGender)
        Me.GrpBoxResults.Controls.Add(Me.date_of_birth)
        Me.GrpBoxResults.Controls.Add(Me.Registration_Number)
        Me.GrpBoxResults.Controls.Add(Me.txtContact_Number)
        Me.GrpBoxResults.Controls.Add(Me.txtAddress)
        Me.GrpBoxResults.Controls.Add(Me.txtDoctor)
        Me.GrpBoxResults.Controls.Add(Me.txtSurname)
        Me.GrpBoxResults.Controls.Add(Me.txtFirst_Name)
        Me.GrpBoxResults.Controls.Add(Me.txtRegistration_Number)
        Me.GrpBoxResults.Controls.Add(Me.txtNational_id)
        Me.GrpBoxResults.Controls.Add(Me.lblGender)
        Me.GrpBoxResults.Controls.Add(Me.lblDate_Of_Birth)
        Me.GrpBoxResults.Controls.Add(Me.lblContact_Number)
        Me.GrpBoxResults.Controls.Add(Me.lblAddress)
        Me.GrpBoxResults.Controls.Add(Me.lblSurname)
        Me.GrpBoxResults.Controls.Add(Me.lblFirst_Name)
        Me.GrpBoxResults.Controls.Add(Me.lblNational_id)
        Me.GrpBoxResults.Controls.Add(Me.txt_Remarks)
        Me.GrpBoxResults.Controls.Add(Me.Label10)
        Me.GrpBoxResults.Controls.Add(Me.Label9)
        Me.GrpBoxResults.Controls.Add(Me.Label8)
        Me.GrpBoxResults.Controls.Add(Me.Label7)
        Me.GrpBoxResults.Controls.Add(Me.txtDisease)
        Me.GrpBoxResults.Controls.Add(Me.CB_Bloodgp)
        Me.GrpBoxResults.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxResults.Location = New System.Drawing.Point(12, 149)
        Me.GrpBoxResults.Name = "GrpBoxResults"
        Me.GrpBoxResults.Size = New System.Drawing.Size(1330, 459)
        Me.GrpBoxResults.TabIndex = 114
        Me.GrpBoxResults.TabStop = False
        Me.GrpBoxResults.Text = "Results"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(424, 340)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(181, 28)
        Me.ComboBoxGender.TabIndex = 136
        '
        'date_of_birth
        '
        Me.date_of_birth.CustomFormat = "dd/MM/yyyy"
        Me.date_of_birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_birth.Location = New System.Drawing.Point(424, 286)
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.Size = New System.Drawing.Size(181, 26)
        Me.date_of_birth.TabIndex = 135
        '
        'Registration_Number
        '
        Me.Registration_Number.AutoSize = True
        Me.Registration_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration_Number.Location = New System.Drawing.Point(261, 29)
        Me.Registration_Number.Name = "Registration_Number"
        Me.Registration_Number.Size = New System.Drawing.Size(156, 20)
        Me.Registration_Number.TabIndex = 134
        Me.Registration_Number.Text = "Registration Number"
        '
        'txtContact_Number
        '
        Me.txtContact_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_Number.Location = New System.Drawing.Point(877, 29)
        Me.txtContact_Number.Multiline = True
        Me.txtContact_Number.Name = "txtContact_Number"
        Me.txtContact_Number.Size = New System.Drawing.Size(192, 25)
        Me.txtContact_Number.TabIndex = 133
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(424, 405)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 25)
        Me.txtAddress.TabIndex = 132
        '
        'txtDoctor
        '
        Me.txtDoctor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(877, 167)
        Me.txtDoctor.Multiline = True
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(192, 25)
        Me.txtDoctor.TabIndex = 128
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(424, 227)
        Me.txtSurname.Multiline = True
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(181, 25)
        Me.txtSurname.TabIndex = 129
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(424, 162)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(181, 25)
        Me.txtFirst_Name.TabIndex = 124
        '
        'txtRegistration_Number
        '
        Me.txtRegistration_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistration_Number.Location = New System.Drawing.Point(424, 29)
        Me.txtRegistration_Number.Multiline = True
        Me.txtRegistration_Number.Name = "txtRegistration_Number"
        Me.txtRegistration_Number.Size = New System.Drawing.Size(181, 25)
        Me.txtRegistration_Number.TabIndex = 118
        '
        'txtNational_id
        '
        Me.txtNational_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational_id.Location = New System.Drawing.Point(424, 96)
        Me.txtNational_id.Multiline = True
        Me.txtNational_id.Name = "txtNational_id"
        Me.txtNational_id.Size = New System.Drawing.Size(181, 25)
        Me.txtNational_id.TabIndex = 122
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(261, 343)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 20)
        Me.lblGender.TabIndex = 126
        Me.lblGender.Text = "Gender"
        '
        'lblDate_Of_Birth
        '
        Me.lblDate_Of_Birth.AutoSize = True
        Me.lblDate_Of_Birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_Of_Birth.Location = New System.Drawing.Point(261, 287)
        Me.lblDate_Of_Birth.Name = "lblDate_Of_Birth"
        Me.lblDate_Of_Birth.Size = New System.Drawing.Size(102, 20)
        Me.lblDate_Of_Birth.TabIndex = 127
        Me.lblDate_Of_Birth.Text = "Date Of Birth"
        '
        'lblContact_Number
        '
        Me.lblContact_Number.AutoSize = True
        Me.lblContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Number.Location = New System.Drawing.Point(714, 29)
        Me.lblContact_Number.Name = "lblContact_Number"
        Me.lblContact_Number.Size = New System.Drawing.Size(132, 20)
        Me.lblContact_Number.TabIndex = 121
        Me.lblContact_Number.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(261, 405)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 20)
        Me.lblAddress.TabIndex = 120
        Me.lblAddress.Text = "Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(261, 227)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 20)
        Me.lblSurname.TabIndex = 119
        Me.lblSurname.Text = "Surname"
        '
        'lblFirst_Name
        '
        Me.lblFirst_Name.AutoSize = True
        Me.lblFirst_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst_Name.Location = New System.Drawing.Point(261, 167)
        Me.lblFirst_Name.Name = "lblFirst_Name"
        Me.lblFirst_Name.Size = New System.Drawing.Size(83, 20)
        Me.lblFirst_Name.TabIndex = 125
        Me.lblFirst_Name.Text = "First Name"
        '
        'lblNational_id
        '
        Me.lblNational_id.AutoSize = True
        Me.lblNational_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNational_id.Location = New System.Drawing.Point(261, 98)
        Me.lblNational_id.Name = "lblNational_id"
        Me.lblNational_id.Size = New System.Drawing.Size(94, 20)
        Me.lblNational_id.TabIndex = 123
        Me.lblNational_id.Text = "National I.D"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(877, 279)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Remarks.Size = New System.Drawing.Size(192, 40)
        Me.txt_Remarks.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(714, 281)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Remarks"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(714, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 23)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Blood Group"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(714, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 23)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Doctor"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(714, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Disease"
        '
        'txtDisease
        '
        Me.txtDisease.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(877, 227)
        Me.txtDisease.Multiline = True
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(192, 25)
        Me.txtDisease.TabIndex = 111
        '
        'CB_Bloodgp
        '
        Me.CB_Bloodgp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Bloodgp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Bloodgp.Items.AddRange(New Object() {"A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-"})
        Me.CB_Bloodgp.Location = New System.Drawing.Point(877, 98)
        Me.CB_Bloodgp.Name = "CB_Bloodgp"
        Me.CB_Bloodgp.Size = New System.Drawing.Size(192, 25)
        Me.CB_Bloodgp.TabIndex = 112
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(476, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 27)
        Me.TextBox1.TabIndex = 113
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(730, 80)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(170, 55)
        Me.btnsearch.TabIndex = 112
        Me.btnsearch.Text = "Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by Name"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Edit_and_Update_Patient_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.GrpBoxResults)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnUpdate_record)
        Me.Controls.Add(Me.btnDelete_Record)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblPatient_Registration)
        Me.Name = "Edit_and_Update_Patient_Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_and_Update_Patient_Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxResults.ResumeLayout(False)
        Me.GrpBoxResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatient_Registration As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnDelete_Record As System.Windows.Forms.Button
    Friend WithEvents btnUpdate_record As System.Windows.Forms.Button
    Friend WithEvents GrpBoxResults As System.Windows.Forms.GroupBox
    Private WithEvents date_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Registration_Number As System.Windows.Forms.Label
    Friend WithEvents txtContact_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtDoctor As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtRegistration_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtNational_id As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDate_Of_Birth As System.Windows.Forms.Label
    Friend WithEvents lblContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirst_Name As System.Windows.Forms.Label
    Friend WithEvents lblNational_id As System.Windows.Forms.Label
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDisease As System.Windows.Forms.TextBox
    Friend WithEvents CB_Bloodgp As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents ComboBoxGender As System.Windows.Forms.ComboBox
End Class
