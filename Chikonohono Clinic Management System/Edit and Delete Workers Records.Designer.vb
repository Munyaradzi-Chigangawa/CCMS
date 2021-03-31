<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_and_Delete_Workers_Records
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GrpBoxResults = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.date_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.txtContact_Number = New System.Windows.Forms.TextBox()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtFirst_Name = New System.Windows.Forms.TextBox()
        Me.txtNational_id = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDate_Of_Birth = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblContact_Number = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblFirst_Name = New System.Windows.Forms.Label()
        Me.lblNational_id = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete_Record = New System.Windows.Forms.Button()
        Me.lblEdit_Workers_Records = New System.Windows.Forms.Label()
        Me.GrpBoxResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(768, 632)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(175, 43)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GrpBoxResults
        '
        Me.GrpBoxResults.Controls.Add(Me.ComboBoxGender)
        Me.GrpBoxResults.Controls.Add(Me.date_of_birth)
        Me.GrpBoxResults.Controls.Add(Me.txtContact_Number)
        Me.GrpBoxResults.Controls.Add(Me.txtProfession)
        Me.GrpBoxResults.Controls.Add(Me.txtAddress)
        Me.GrpBoxResults.Controls.Add(Me.txtSurname)
        Me.GrpBoxResults.Controls.Add(Me.txtFirst_Name)
        Me.GrpBoxResults.Controls.Add(Me.txtNational_id)
        Me.GrpBoxResults.Controls.Add(Me.lblGender)
        Me.GrpBoxResults.Controls.Add(Me.lblDate_Of_Birth)
        Me.GrpBoxResults.Controls.Add(Me.Label1)
        Me.GrpBoxResults.Controls.Add(Me.lblContact_Number)
        Me.GrpBoxResults.Controls.Add(Me.lblAddress)
        Me.GrpBoxResults.Controls.Add(Me.lblSurname)
        Me.GrpBoxResults.Controls.Add(Me.lblFirst_Name)
        Me.GrpBoxResults.Controls.Add(Me.lblNational_id)
        Me.GrpBoxResults.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxResults.Location = New System.Drawing.Point(187, 151)
        Me.GrpBoxResults.Name = "GrpBoxResults"
        Me.GrpBoxResults.Size = New System.Drawing.Size(981, 475)
        Me.GrpBoxResults.TabIndex = 17
        Me.GrpBoxResults.TabStop = False
        Me.GrpBoxResults.Text = "Results"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(476, 248)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(181, 28)
        Me.ComboBoxGender.TabIndex = 137
        '
        'date_of_birth
        '
        Me.date_of_birth.CustomFormat = "dd/MM/yyyy"
        Me.date_of_birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_birth.Location = New System.Drawing.Point(476, 188)
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.Size = New System.Drawing.Size(181, 26)
        Me.date_of_birth.TabIndex = 134
        '
        'txtContact_Number
        '
        Me.txtContact_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_Number.Location = New System.Drawing.Point(476, 425)
        Me.txtContact_Number.Multiline = True
        Me.txtContact_Number.Name = "txtContact_Number"
        Me.txtContact_Number.Size = New System.Drawing.Size(192, 25)
        Me.txtContact_Number.TabIndex = 133
        '
        'txtProfession
        '
        Me.txtProfession.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfession.Location = New System.Drawing.Point(476, 309)
        Me.txtProfession.Multiline = True
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(181, 25)
        Me.txtProfession.TabIndex = 131
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(476, 367)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 25)
        Me.txtAddress.TabIndex = 132
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(476, 135)
        Me.txtSurname.Multiline = True
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(181, 25)
        Me.txtSurname.TabIndex = 128
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(476, 77)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.Size = New System.Drawing.Size(181, 25)
        Me.txtFirst_Name.TabIndex = 124
        '
        'txtNational_id
        '
        Me.txtNational_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational_id.Location = New System.Drawing.Point(476, 19)
        Me.txtNational_id.Multiline = True
        Me.txtNational_id.Name = "txtNational_id"
        Me.txtNational_id.Size = New System.Drawing.Size(181, 25)
        Me.txtNational_id.TabIndex = 122
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(313, 251)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 20)
        Me.lblGender.TabIndex = 126
        Me.lblGender.Text = "Gender"
        '
        'lblDate_Of_Birth
        '
        Me.lblDate_Of_Birth.AutoSize = True
        Me.lblDate_Of_Birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_Of_Birth.Location = New System.Drawing.Point(313, 193)
        Me.lblDate_Of_Birth.Name = "lblDate_Of_Birth"
        Me.lblDate_Of_Birth.Size = New System.Drawing.Size(102, 20)
        Me.lblDate_Of_Birth.TabIndex = 127
        Me.lblDate_Of_Birth.Text = "Date Of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Profession"
        '
        'lblContact_Number
        '
        Me.lblContact_Number.AutoSize = True
        Me.lblContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Number.Location = New System.Drawing.Point(313, 425)
        Me.lblContact_Number.Name = "lblContact_Number"
        Me.lblContact_Number.Size = New System.Drawing.Size(132, 20)
        Me.lblContact_Number.TabIndex = 121
        Me.lblContact_Number.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(313, 367)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 20)
        Me.lblAddress.TabIndex = 119
        Me.lblAddress.Text = "Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(313, 135)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 20)
        Me.lblSurname.TabIndex = 118
        Me.lblSurname.Text = "Surname"
        '
        'lblFirst_Name
        '
        Me.lblFirst_Name.AutoSize = True
        Me.lblFirst_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst_Name.Location = New System.Drawing.Point(313, 77)
        Me.lblFirst_Name.Name = "lblFirst_Name"
        Me.lblFirst_Name.Size = New System.Drawing.Size(83, 20)
        Me.lblFirst_Name.TabIndex = 125
        Me.lblFirst_Name.Text = "First Name"
        '
        'lblNational_id
        '
        Me.lblNational_id.AutoSize = True
        Me.lblNational_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNational_id.Location = New System.Drawing.Point(313, 19)
        Me.lblNational_id.Name = "lblNational_id"
        Me.lblNational_id.Size = New System.Drawing.Size(94, 20)
        Me.lblNational_id.TabIndex = 123
        Me.lblNational_id.Text = "National I.D"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(473, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 27)
        Me.TextBox1.TabIndex = 16
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(727, 85)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(151, 56)
        Me.btnsearch.TabIndex = 15
        Me.btnsearch.Text = "Search" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by Name"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate_record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(590, 632)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(158, 44)
        Me.btnUpdate_record.TabIndex = 19
        Me.btnUpdate_record.Text = "Update Record"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete_Record
        '
        Me.btnDelete_Record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete_Record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete_Record.Location = New System.Drawing.Point(412, 632)
        Me.btnDelete_Record.Name = "btnDelete_Record"
        Me.btnDelete_Record.Size = New System.Drawing.Size(158, 44)
        Me.btnDelete_Record.TabIndex = 20
        Me.btnDelete_Record.Text = "Delete Record"
        Me.btnDelete_Record.UseVisualStyleBackColor = True
        '
        'lblEdit_Workers_Records
        '
        Me.lblEdit_Workers_Records.AutoSize = True
        Me.lblEdit_Workers_Records.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit_Workers_Records.Location = New System.Drawing.Point(492, 20)
        Me.lblEdit_Workers_Records.Name = "lblEdit_Workers_Records"
        Me.lblEdit_Workers_Records.Size = New System.Drawing.Size(371, 42)
        Me.lblEdit_Workers_Records.TabIndex = 21
        Me.lblEdit_Workers_Records.Text = "Edit Workers Records"
        '
        'Edit_and_Delete_Workers_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.lblEdit_Workers_Records)
        Me.Controls.Add(Me.btnUpdate_record)
        Me.Controls.Add(Me.btnDelete_Record)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GrpBoxResults)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Name = "Edit_and_Delete_Workers_Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit_and_Delete_Workers_Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpBoxResults.ResumeLayout(False)
        Me.GrpBoxResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents GrpBoxResults As System.Windows.Forms.GroupBox
    Private WithEvents date_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtContact_Number As System.Windows.Forms.TextBox
    Friend WithEvents txtProfession As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtNational_id As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDate_Of_Birth As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblContact_Number As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblFirst_Name As System.Windows.Forms.Label
    Friend WithEvents lblNational_id As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnUpdate_record As System.Windows.Forms.Button
    Friend WithEvents btnDelete_Record As System.Windows.Forms.Button
    Friend WithEvents lblEdit_Workers_Records As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGender As System.Windows.Forms.ComboBox
End Class
