<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_and_Delete_Medication_Records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_and_Delete_Medication_Records))
        Me.lblPatient_Registration = New System.Windows.Forms.Label()
        Me.DTPExpiry_Date = New System.Windows.Forms.DateTimePicker()
        Me.DTPManufacture_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHandler = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.btnUpdate_record = New System.Windows.Forms.Button()
        Me.btnDelete_Record = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPatient_Registration
        '
        Me.lblPatient_Registration.AutoSize = True
        Me.lblPatient_Registration.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Registration.Location = New System.Drawing.Point(364, 38)
        Me.lblPatient_Registration.Name = "lblPatient_Registration"
        Me.lblPatient_Registration.Size = New System.Drawing.Size(626, 42)
        Me.lblPatient_Registration.TabIndex = 8
        Me.lblPatient_Registration.Text = "Edit And Update Medication Details"
        '
        'DTPExpiry_Date
        '
        Me.DTPExpiry_Date.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPExpiry_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPExpiry_Date.Location = New System.Drawing.Point(632, 570)
        Me.DTPExpiry_Date.Name = "DTPExpiry_Date"
        Me.DTPExpiry_Date.Size = New System.Drawing.Size(226, 23)
        Me.DTPExpiry_Date.TabIndex = 21
        '
        'DTPManufacture_date
        '
        Me.DTPManufacture_date.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPManufacture_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPManufacture_date.Location = New System.Drawing.Point(632, 504)
        Me.DTPManufacture_date.Name = "DTPManufacture_date"
        Me.DTPManufacture_date.Size = New System.Drawing.Size(226, 23)
        Me.DTPManufacture_date.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(496, 576)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Expiry Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 510)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Manufacture Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Handler"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Code"
        '
        'txtHandler
        '
        Me.txtHandler.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHandler.Location = New System.Drawing.Point(632, 444)
        Me.txtHandler.Name = "txtHandler"
        Me.txtHandler.Size = New System.Drawing.Size(226, 26)
        Me.txtHandler.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(632, 385)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(226, 26)
        Me.txtDescription.TabIndex = 10
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(632, 326)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(226, 26)
        Me.txtQuantity.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(632, 266)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 26)
        Me.txtName.TabIndex = 12
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(632, 205)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(226, 26)
        Me.txtCode.TabIndex = 13
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate_record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Location = New System.Drawing.Point(602, 626)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(158, 46)
        Me.btnUpdate_record.TabIndex = 25
        Me.btnUpdate_record.Text = "Update Record"
        Me.btnUpdate_record.UseVisualStyleBackColor = True
        '
        'btnDelete_Record
        '
        Me.btnDelete_Record.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete_Record.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete_Record.Location = New System.Drawing.Point(422, 626)
        Me.btnDelete_Record.Name = "btnDelete_Record"
        Me.btnDelete_Record.Size = New System.Drawing.Size(158, 46)
        Me.btnDelete_Record.TabIndex = 24
        Me.btnDelete_Record.Text = "Delete Record"
        Me.btnDelete_Record.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(782, 626)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 46)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(461, 126)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(233, 27)
        Me.TextBox1.TabIndex = 115
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(715, 120)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(170, 40)
        Me.btnsearch.TabIndex = 114
        Me.btnsearch.Text = "Search " & Global.Microsoft.VisualBasic.ChrW(13)
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Edit_and_Delete_Medication_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnUpdate_record)
        Me.Controls.Add(Me.btnDelete_Record)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DTPExpiry_Date)
        Me.Controls.Add(Me.DTPManufacture_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHandler)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblPatient_Registration)
        Me.Name = "Edit_and_Delete_Medication_Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit and Delete Medication_Records"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPatient_Registration As System.Windows.Forms.Label
    Friend WithEvents DTPExpiry_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPManufacture_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHandler As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate_record As System.Windows.Forms.Button
    Friend WithEvents btnDelete_Record As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
End Class
