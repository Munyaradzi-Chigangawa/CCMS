<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients_Registration_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patients_Registration_Form))
        Me.lblPatient_Registration = New System.Windows.Forms.Label()
        Me.btnAdd_Patient = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.CB_Bloodgp = New System.Windows.Forms.ComboBox()
        Me.txtRegistration_Number = New System.Windows.Forms.Label()
        Me.RB_Female = New System.Windows.Forms.RadioButton()
        Me.RB_Male = New System.Windows.Forms.RadioButton()
        Me.txtContact_Number = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.txtReg_No = New System.Windows.Forms.TextBox()
        Me.txtNational_id = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDate_Of_Birth = New System.Windows.Forms.Label()
        Me.lblContact_Number = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirst_Name = New System.Windows.Forms.Label()
        Me.lblNational_id = New System.Windows.Forms.Label()
        Me.date_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPatient_Registration
        '
        Me.lblPatient_Registration.AutoSize = True
        Me.lblPatient_Registration.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Registration.Location = New System.Drawing.Point(504, 36)
        Me.lblPatient_Registration.Name = "lblPatient_Registration"
        Me.lblPatient_Registration.Size = New System.Drawing.Size(347, 42)
        Me.lblPatient_Registration.TabIndex = 6
        Me.lblPatient_Registration.Text = "Patient Registration"
        '
        'btnAdd_Patient
        '
        Me.btnAdd_Patient.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd_Patient.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_Patient.Location = New System.Drawing.Point(445, 629)
        Me.btnAdd_Patient.Name = "btnAdd_Patient"
        Me.btnAdd_Patient.Size = New System.Drawing.Size(117, 36)
        Me.btnAdd_Patient.TabIndex = 9
        Me.btnAdd_Patient.Text = "Add Patient"
        Me.btnAdd_Patient.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(620, 629)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 36)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(793, 629)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 36)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(889, 408)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Remarks.Size = New System.Drawing.Size(192, 40)
        Me.txt_Remarks.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(726, 410)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Remarks"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(726, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 23)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Blood Group"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(726, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 23)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Doctor"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(726, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Disease"
        '
        'txtDisease
        '
        Me.txtDisease.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisease.Location = New System.Drawing.Point(889, 356)
        Me.txtDisease.Multiline = True
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(192, 25)
        Me.txtDisease.TabIndex = 80
        '
        'CB_Bloodgp
        '
        Me.CB_Bloodgp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Bloodgp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Bloodgp.Items.AddRange(New Object() {"A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-"})
        Me.CB_Bloodgp.Location = New System.Drawing.Point(889, 227)
        Me.CB_Bloodgp.Name = "CB_Bloodgp"
        Me.CB_Bloodgp.Size = New System.Drawing.Size(192, 25)
        Me.CB_Bloodgp.TabIndex = 77
        '
        'txtRegistration_Number
        '
        Me.txtRegistration_Number.AutoSize = True
        Me.txtRegistration_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegistration_Number.Location = New System.Drawing.Point(273, 158)
        Me.txtRegistration_Number.Name = "txtRegistration_Number"
        Me.txtRegistration_Number.Size = New System.Drawing.Size(156, 20)
        Me.txtRegistration_Number.TabIndex = 84
        Me.txtRegistration_Number.Text = "Registration Number"
        '
        'RB_Female
        '
        Me.RB_Female.AutoSize = True
        Me.RB_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Female.Location = New System.Drawing.Point(545, 474)
        Me.RB_Female.Name = "RB_Female"
        Me.RB_Female.Size = New System.Drawing.Size(72, 20)
        Me.RB_Female.TabIndex = 74
        Me.RB_Female.TabStop = True
        Me.RB_Female.Text = "Female"
        Me.RB_Female.UseVisualStyleBackColor = True
        '
        'RB_Male
        '
        Me.RB_Male.AutoSize = True
        Me.RB_Male.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Male.Location = New System.Drawing.Point(436, 473)
        Me.RB_Male.Name = "RB_Male"
        Me.RB_Male.Size = New System.Drawing.Size(57, 21)
        Me.RB_Male.TabIndex = 73
        Me.RB_Male.TabStop = True
        Me.RB_Male.Text = "Male"
        Me.RB_Male.UseVisualStyleBackColor = True
        '
        'txtContact_Number
        '
        Me.txtContact_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_Number.Location = New System.Drawing.Point(889, 158)
        Me.txtContact_Number.Multiline = True
        Me.txtContact_Number.Name = "txtContact_Number"
        Me.txtContact_Number.Size = New System.Drawing.Size(192, 25)
        Me.txtContact_Number.TabIndex = 76
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(436, 534)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 25)
        Me.txtAddress.TabIndex = 75
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(436, 356)
        Me.txtSurname.Multiline = True
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(181, 25)
        Me.txtSurname.TabIndex = 71
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(436, 291)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(181, 25)
        Me.txtFirst_Name.TabIndex = 70
        '
        'txtReg_No
        '
        Me.txtReg_No.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReg_No.Location = New System.Drawing.Point(436, 158)
        Me.txtReg_No.Multiline = True
        Me.txtReg_No.Name = "txtReg_No"
        Me.txtReg_No.Size = New System.Drawing.Size(181, 25)
        Me.txtReg_No.TabIndex = 68
        '
        'txtNational_id
        '
        Me.txtNational_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational_id.Location = New System.Drawing.Point(436, 225)
        Me.txtNational_id.Multiline = True
        Me.txtNational_id.Name = "txtNational_id"
        Me.txtNational_id.Size = New System.Drawing.Size(181, 25)
        Me.txtNational_id.TabIndex = 69
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(273, 472)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 20)
        Me.lblGender.TabIndex = 76
        Me.lblGender.Text = "Gender"
        '
        'lblDate_Of_Birth
        '
        Me.lblDate_Of_Birth.AutoSize = True
        Me.lblDate_Of_Birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_Of_Birth.Location = New System.Drawing.Point(273, 416)
        Me.lblDate_Of_Birth.Name = "lblDate_Of_Birth"
        Me.lblDate_Of_Birth.Size = New System.Drawing.Size(102, 20)
        Me.lblDate_Of_Birth.TabIndex = 77
        Me.lblDate_Of_Birth.Text = "Date Of Birth"
        '
        'lblContact_Number
        '
        Me.lblContact_Number.AutoSize = True
        Me.lblContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Number.Location = New System.Drawing.Point(726, 158)
        Me.lblContact_Number.Name = "lblContact_Number"
        Me.lblContact_Number.Size = New System.Drawing.Size(132, 20)
        Me.lblContact_Number.TabIndex = 71
        Me.lblContact_Number.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(273, 534)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 20)
        Me.lblAddress.TabIndex = 70
        Me.lblAddress.Text = "Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(273, 356)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 20)
        Me.lblSurname.TabIndex = 69
        Me.lblSurname.Text = "Surname"
        '
        'lblFirst_Name
        '
        Me.lblFirst_Name.AutoSize = True
        Me.lblFirst_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst_Name.Location = New System.Drawing.Point(273, 296)
        Me.lblFirst_Name.Name = "lblFirst_Name"
        Me.lblFirst_Name.Size = New System.Drawing.Size(83, 20)
        Me.lblFirst_Name.TabIndex = 75
        Me.lblFirst_Name.Text = "First Name"
        '
        'lblNational_id
        '
        Me.lblNational_id.AutoSize = True
        Me.lblNational_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNational_id.Location = New System.Drawing.Point(273, 227)
        Me.lblNational_id.Name = "lblNational_id"
        Me.lblNational_id.Size = New System.Drawing.Size(94, 20)
        Me.lblNational_id.TabIndex = 73
        Me.lblNational_id.Text = "National I.D"
        '
        'date_of_birth
        '
        Me.date_of_birth.CustomFormat = "dd/MM/yyyy"
        Me.date_of_birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_birth.Location = New System.Drawing.Point(436, 415)
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.Size = New System.Drawing.Size(181, 26)
        Me.date_of_birth.TabIndex = 72
        '
        'txtDoctor
        '
        Me.txtDoctor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctor.Location = New System.Drawing.Point(889, 296)
        Me.txtDoctor.Multiline = True
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(192, 25)
        Me.txtDoctor.TabIndex = 78
        '
        'Patients_Registration_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.date_of_birth)
        Me.Controls.Add(Me.txtRegistration_Number)
        Me.Controls.Add(Me.RB_Female)
        Me.Controls.Add(Me.RB_Male)
        Me.Controls.Add(Me.txtContact_Number)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtDoctor)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirst_Name)
        Me.Controls.Add(Me.txtReg_No)
        Me.Controls.Add(Me.txtNational_id)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDate_Of_Birth)
        Me.Controls.Add(Me.lblContact_Number)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblFirst_Name)
        Me.Controls.Add(Me.lblNational_id)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDisease)
        Me.Controls.Add(Me.CB_Bloodgp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd_Patient)
        Me.Controls.Add(Me.lblPatient_Registration)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Patients_Registration_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patients Registration Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatient_Registration As System.Windows.Forms.Label
    Friend WithEvents btnAdd_Patient As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDisease As System.Windows.Forms.TextBox
    Friend WithEvents CB_Bloodgp As System.Windows.Forms.ComboBox
    Friend WithEvents txtRegistration_Number As System.Windows.Forms.Label
    Friend WithEvents RB_Female As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Male As System.Windows.Forms.RadioButton
    Friend WithEvents txtContact_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtReg_No As System.Windows.Forms.TextBox
    Friend WithEvents txtNational_id As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDate_Of_Birth As System.Windows.Forms.Label
    Friend WithEvents lblContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirst_Name As System.Windows.Forms.Label
    Friend WithEvents lblNational_id As System.Windows.Forms.Label
    Private WithEvents date_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDoctor As System.Windows.Forms.TextBox
End Class
