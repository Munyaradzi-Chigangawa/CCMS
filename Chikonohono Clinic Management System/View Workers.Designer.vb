<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Workers
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
        Me.lblWorkers_Records = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Back = New System.Windows.Forms.Button()
        Me.date_of_birth = New System.Windows.Forms.DateTimePicker()
        Me.RB_Female = New System.Windows.Forms.RadioButton()
        Me.RB_Male = New System.Windows.Forms.RadioButton()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWorkers_Records
        '
        Me.lblWorkers_Records.AutoSize = True
        Me.lblWorkers_Records.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkers_Records.Location = New System.Drawing.Point(528, 9)
        Me.lblWorkers_Records.Name = "lblWorkers_Records"
        Me.lblWorkers_Records.Size = New System.Drawing.Size(299, 42)
        Me.lblWorkers_Records.TabIndex = 10
        Me.lblWorkers_Records.Text = "Workers Records"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 527)
        Me.DataGridView1.TabIndex = 11
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(612, 613)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(131, 38)
        Me.Back.TabIndex = 12
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'date_of_birth
        '
        Me.date_of_birth.CustomFormat = "dd/MM/yyyy"
        Me.date_of_birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_of_birth.Location = New System.Drawing.Point(1063, 271)
        Me.date_of_birth.Name = "date_of_birth"
        Me.date_of_birth.Size = New System.Drawing.Size(181, 26)
        Me.date_of_birth.TabIndex = 117
        '
        'RB_Female
        '
        Me.RB_Female.AutoSize = True
        Me.RB_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Female.Location = New System.Drawing.Point(1172, 335)
        Me.RB_Female.Name = "RB_Female"
        Me.RB_Female.Size = New System.Drawing.Size(72, 20)
        Me.RB_Female.TabIndex = 113
        Me.RB_Female.TabStop = True
        Me.RB_Female.Text = "Female"
        Me.RB_Female.UseVisualStyleBackColor = True
        '
        'RB_Male
        '
        Me.RB_Male.AutoSize = True
        Me.RB_Male.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Male.Location = New System.Drawing.Point(1063, 335)
        Me.RB_Male.Name = "RB_Male"
        Me.RB_Male.Size = New System.Drawing.Size(57, 21)
        Me.RB_Male.TabIndex = 112
        Me.RB_Male.TabStop = True
        Me.RB_Male.Text = "Male"
        Me.RB_Male.UseVisualStyleBackColor = True
        '
        'txtContact_Number
        '
        Me.txtContact_Number.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact_Number.Location = New System.Drawing.Point(1063, 508)
        Me.txtContact_Number.Multiline = True
        Me.txtContact_Number.Name = "txtContact_Number"
        Me.txtContact_Number.ReadOnly = True
        Me.txtContact_Number.Size = New System.Drawing.Size(192, 25)
        Me.txtContact_Number.TabIndex = 116
        '
        'txtProfession
        '
        Me.txtProfession.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfession.Location = New System.Drawing.Point(1063, 392)
        Me.txtProfession.Multiline = True
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.ReadOnly = True
        Me.txtProfession.Size = New System.Drawing.Size(181, 25)
        Me.txtProfession.TabIndex = 114
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(1063, 450)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(181, 25)
        Me.txtAddress.TabIndex = 115
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(1063, 218)
        Me.txtSurname.Multiline = True
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(181, 25)
        Me.txtSurname.TabIndex = 111
        '
        'txtFirst_Name
        '
        Me.txtFirst_Name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst_Name.Location = New System.Drawing.Point(1063, 160)
        Me.txtFirst_Name.Multiline = True
        Me.txtFirst_Name.Name = "txtFirst_Name"
        Me.txtFirst_Name.ReadOnly = True
        Me.txtFirst_Name.Size = New System.Drawing.Size(181, 25)
        Me.txtFirst_Name.TabIndex = 107
        '
        'txtNational_id
        '
        Me.txtNational_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNational_id.Location = New System.Drawing.Point(1063, 102)
        Me.txtNational_id.Multiline = True
        Me.txtNational_id.Name = "txtNational_id"
        Me.txtNational_id.ReadOnly = True
        Me.txtNational_id.Size = New System.Drawing.Size(181, 25)
        Me.txtNational_id.TabIndex = 105
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(900, 334)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(66, 20)
        Me.lblGender.TabIndex = 109
        Me.lblGender.Text = "Gender"
        '
        'lblDate_Of_Birth
        '
        Me.lblDate_Of_Birth.AutoSize = True
        Me.lblDate_Of_Birth.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate_Of_Birth.Location = New System.Drawing.Point(900, 276)
        Me.lblDate_Of_Birth.Name = "lblDate_Of_Birth"
        Me.lblDate_Of_Birth.Size = New System.Drawing.Size(102, 20)
        Me.lblDate_Of_Birth.TabIndex = 110
        Me.lblDate_Of_Birth.Text = "Date Of Birth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(900, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Profession"
        '
        'lblContact_Number
        '
        Me.lblContact_Number.AutoSize = True
        Me.lblContact_Number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Number.Location = New System.Drawing.Point(900, 508)
        Me.lblContact_Number.Name = "lblContact_Number"
        Me.lblContact_Number.Size = New System.Drawing.Size(132, 20)
        Me.lblContact_Number.TabIndex = 104
        Me.lblContact_Number.Text = "Contact Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(900, 450)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 20)
        Me.lblAddress.TabIndex = 102
        Me.lblAddress.Text = "Address"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(900, 218)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(72, 20)
        Me.lblSurname.TabIndex = 101
        Me.lblSurname.Text = "Surname"
        '
        'lblFirst_Name
        '
        Me.lblFirst_Name.AutoSize = True
        Me.lblFirst_Name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst_Name.Location = New System.Drawing.Point(900, 160)
        Me.lblFirst_Name.Name = "lblFirst_Name"
        Me.lblFirst_Name.Size = New System.Drawing.Size(83, 20)
        Me.lblFirst_Name.TabIndex = 108
        Me.lblFirst_Name.Text = "First Name"
        '
        'lblNational_id
        '
        Me.lblNational_id.AutoSize = True
        Me.lblNational_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNational_id.Location = New System.Drawing.Point(900, 102)
        Me.lblNational_id.Name = "lblNational_id"
        Me.lblNational_id.Size = New System.Drawing.Size(94, 20)
        Me.lblNational_id.TabIndex = 106
        Me.lblNational_id.Text = "National I.D"
        '
        'View_Workers
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
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblWorkers_Records)
        Me.Name = "View_Workers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View_Workers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWorkers_Records As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Back As System.Windows.Forms.Button
    Private WithEvents date_of_birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RB_Female As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Male As System.Windows.Forms.RadioButton
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
End Class
