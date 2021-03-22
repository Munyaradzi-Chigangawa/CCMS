<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Records_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Records_Menu))
        Me.Back = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.viewrecords = New System.Windows.Forms.Button()
        Me.btnEdit_or_Delete_patient_record = New System.Windows.Forms.Button()
        Me.lblPatient_Records = New System.Windows.Forms.Label()
        Me.btnGenerate_Report = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(552, 486)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(250, 36)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(552, 274)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(250, 38)
        Me.Search.TabIndex = 2
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'viewrecords
        '
        Me.viewrecords.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewrecords.Location = New System.Drawing.Point(552, 204)
        Me.viewrecords.Name = "viewrecords"
        Me.viewrecords.Size = New System.Drawing.Size(250, 38)
        Me.viewrecords.TabIndex = 1
        Me.viewrecords.Text = "Existing Records"
        Me.viewrecords.UseVisualStyleBackColor = True
        '
        'btnEdit_or_Delete_patient_record
        '
        Me.btnEdit_or_Delete_patient_record.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_or_Delete_patient_record.Location = New System.Drawing.Point(552, 414)
        Me.btnEdit_or_Delete_patient_record.Name = "btnEdit_or_Delete_patient_record"
        Me.btnEdit_or_Delete_patient_record.Size = New System.Drawing.Size(250, 40)
        Me.btnEdit_or_Delete_patient_record.TabIndex = 3
        Me.btnEdit_or_Delete_patient_record.Text = "Edit / Delete Patient Record"
        Me.btnEdit_or_Delete_patient_record.UseVisualStyleBackColor = True
        '
        'lblPatient_Records
        '
        Me.lblPatient_Records.AutoSize = True
        Me.lblPatient_Records.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Records.Location = New System.Drawing.Point(481, 42)
        Me.lblPatient_Records.Name = "lblPatient_Records"
        Me.lblPatient_Records.Size = New System.Drawing.Size(393, 42)
        Me.lblPatient_Records.TabIndex = 7
        Me.lblPatient_Records.Text = "Patient Records Menu"
        '
        'btnGenerate_Report
        '
        Me.btnGenerate_Report.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate_Report.Location = New System.Drawing.Point(552, 344)
        Me.btnGenerate_Report.Name = "btnGenerate_Report"
        Me.btnGenerate_Report.Size = New System.Drawing.Size(250, 38)
        Me.btnGenerate_Report.TabIndex = 2
        Me.btnGenerate_Report.Text = "Generate Report"
        Me.btnGenerate_Report.UseVisualStyleBackColor = True
        '
        'Patient_Records_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.lblPatient_Records)
        Me.Controls.Add(Me.btnEdit_or_Delete_patient_record)
        Me.Controls.Add(Me.viewrecords)
        Me.Controls.Add(Me.btnGenerate_Report)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Back)
        Me.Name = "Patient_Records_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Records Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.Button
    Friend WithEvents viewrecords As System.Windows.Forms.Button
    Friend WithEvents btnEdit_or_Delete_patient_record As System.Windows.Forms.Button
    Friend WithEvents lblPatient_Records As System.Windows.Forms.Label
    Friend WithEvents btnGenerate_Report As System.Windows.Forms.Button
End Class
