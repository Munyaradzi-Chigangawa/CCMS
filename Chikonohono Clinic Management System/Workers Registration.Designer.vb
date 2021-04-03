<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workers_Registration
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd_Worker = New System.Windows.Forms.Button()
        Me.date_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.RB_Female = New System.Windows.Forms.RadioButton()
        Me.RB_Male = New System.Windows.Forms.RadioButton()
        Me.txtContact_Number = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.txtNational_id = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDate_Of_Birth = New System.Windows.Forms.Label()
        Me.lblContact_Number = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirst_Name = New System.Windows.Forms.Label()
        Me.lblNational_id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPatient_Registration
        '
        Me.lblPatient_Registration.AutoSize = True
        Me.lblPatient_Registration.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Registration.Location = New System.Drawing.Point(498, 38)
        Me.lblPatient_Registration.Name = "lblPatient_Registration"
        Me.lblPatient_Registration.Size = New System.Drawing.Size(359, 42)
        Me.lblPatient_Registration.TabIndex = 10
        Me.lblPatient_Registration.Text = "Workers Registration"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(793, 610)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 36)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(620, 610)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(117, 36)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd_Worker
        '
        Me.btnAdd_Worker.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd_Worker.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_Worker.Location = New System.Drawing.Point(445, 610)
        Me.btnAdd_Worker.Name = "btnAdd_Worker"
        Me.btnAdd_Worker.Size = New System.Drawing.Size(117, 36)
        Me.btnAdd_Worker.TabIndex = 12
        Me.btnAdd_Worker.Text = "Add Worker"
        Me.btnAdd_Worker.UseVisualStyleBackColor = True
        '
        'date_of_birth
        '
        Me.date_of_birth.CustomFormat = "dd/MM/yyyy"
        Me.date_of_birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_birth.Location = New System.Drawing.Point(668, 295)
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.Size = New System.Drawing.Size(181, 26)
        Me.date_of_birth.TabIndex = 96
        '
        'RB_Female
        '
        Me.RB_Female.AutoSize = True
        Me.RB_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Female.Location = New System.Drawing.Point(777, 359)
        Me.RB_Female.Name = "RB_Female"
        Me.RB_Female.Size = New System.Drawing.Size(72, 20)
        Me.RB_Female.TabIndex = 97
        Me.RB_Female.TabStop = True
        Me.RB_Female.Text = "Female"
        Me.RB_Female.UseVisualStyleBackColor = True
        '
        'RB_Male
        '
        Me.RB_Male.AutoSize = True
        Me.RB_Male.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Male.Location = New System.Drawing.Point(668, 359)
        Me.RB_Male.Name = "RB_Male"
        Me.RB_Male.Size = New System.Drawing.Size(57, 21)
        Me.RB_Male.TabIndex = 96
        Me.RB_Male.TabStop = True
        Me.RB_Male.Text = "Male"
        Me.RB_Male.UseVisualStyleBackColor = True
        '
        'txtContact_Number
        '
        Me.txtContact_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_Number.Location = New System.Drawing.Point(668, 532)
        Me.txtContact_Number.Multiline = True
        Me.txtContact_Number.Name = "txtContact_Number"
        Me.txtContact_Number.Size = New System.Drawing.Size(192, 25)
        Me.txtContact_Number.TabIndex = 99
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(668, 474)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 25)
        Me.txtAddress.TabIndex = 98
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(668, 242)
        Me.txtSurname.Multiline = True
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(181, 25)
        Me.txtSurname.TabIndex = 95
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(668, 184)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(181, 25)
        Me.txtFirst_Name.TabIndex = 91
        '
        'txtNational_id
        '
        Me.txtNational_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational_id.Location = New System.Drawing.Point(668, 126)
        Me.txtNational_id.Multiline = True
        Me.txtNational_id.Name = "txtNational_id"
        Me.txtNational_id.Size = New System.Drawing.Size(181, 25)
        Me.txtNational_id.TabIndex = 89
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(505, 358)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 20)
        Me.lblGender.TabIndex = 93
        Me.lblGender.Text = "Gender"
        '
        'lblDate_Of_Birth
        '
        Me.lblDate_Of_Birth.AutoSize = True
        Me.lblDate_Of_Birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_Of_Birth.Location = New System.Drawing.Point(505, 300)
        Me.lblDate_Of_Birth.Name = "lblDate_Of_Birth"
        Me.lblDate_Of_Birth.Size = New System.Drawing.Size(102, 20)
        Me.lblDate_Of_Birth.TabIndex = 94
        Me.lblDate_Of_Birth.Text = "Date Of Birth"
        '
        'lblContact_Number
        '
        Me.lblContact_Number.AutoSize = True
        Me.lblContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Number.Location = New System.Drawing.Point(505, 532)
        Me.lblContact_Number.Name = "lblContact_Number"
        Me.lblContact_Number.Size = New System.Drawing.Size(132, 20)
        Me.lblContact_Number.TabIndex = 88
        Me.lblContact_Number.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(505, 474)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 20)
        Me.lblAddress.TabIndex = 87
        Me.lblAddress.Text = "Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(505, 242)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 20)
        Me.lblSurname.TabIndex = 86
        Me.lblSurname.Text = "Surname"
        '
        'lblFirst_Name
        '
        Me.lblFirst_Name.AutoSize = True
        Me.lblFirst_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst_Name.Location = New System.Drawing.Point(505, 184)
        Me.lblFirst_Name.Name = "lblFirst_Name"
        Me.lblFirst_Name.Size = New System.Drawing.Size(83, 20)
        Me.lblFirst_Name.TabIndex = 92
        Me.lblFirst_Name.Text = "First Name"
        '
        'lblNational_id
        '
        Me.lblNational_id.AutoSize = True
        Me.lblNational_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNational_id.Location = New System.Drawing.Point(505, 126)
        Me.lblNational_id.Name = "lblNational_id"
        Me.lblNational_id.Size = New System.Drawing.Size(94, 20)
        Me.lblNational_id.TabIndex = 90
        Me.lblNational_id.Text = "National I.D"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Profession"
        '
        'txtProfession
        '
        Me.txtProfession.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfession.Location = New System.Drawing.Point(668, 416)
        Me.txtProfession.Multiline = True
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(181, 25)
        Me.txtProfession.TabIndex = 98
        '
        'Workers_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 717)
        Me.Controls.Add(Me.date_of_birth)
        Me.Controls.Add(Me.RB_Female)
        Me.Controls.Add(Me.RB_Male)
        Me.Controls.Add(Me.txtContact_Number)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtFirst_Name)
        Me.Controls.Add(Me.txtNational_id)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDate_Of_Birth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblContact_Number)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblFirst_Name)
        Me.Controls.Add(Me.lblNational_id)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd_Worker)
        Me.Controls.Add(Me.lblPatient_Registration)
        Me.Name = "Workers_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workers_Registration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatient_Registration As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd_Worker As System.Windows.Forms.Button
    Private WithEvents date_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB_Female As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Male As System.Windows.Forms.RadioButton
    Friend WithEvents txtContact_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtNational_id As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDate_Of_Birth As System.Windows.Forms.Label
    Friend WithEvents lblContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirst_Name As System.Windows.Forms.Label
    Friend WithEvents lblNational_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
End Class
