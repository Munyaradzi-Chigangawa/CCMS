<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispensary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispensary))
        Me.Back = New System.Windows.Forms.Button()
        Me.lblPatient_Registration = New System.Windows.Forms.Label()
        Me.btnAdd_Medicine = New System.Windows.Forms.Button()
        Me.btnView_Medication_Available = New System.Windows.Forms.Button()
        Me.btnEdit_Medication_Records = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(525, 439)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(305, 36)
        Me.Back.TabIndex = 3
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'lblPatient_Registration
        '
        Me.lblPatient_Registration.AutoSize = True
        Me.lblPatient_Registration.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatient_Registration.Location = New System.Drawing.Point(577, 58)
        Me.lblPatient_Registration.Name = "lblPatient_Registration"
        Me.lblPatient_Registration.Size = New System.Drawing.Size(201, 42)
        Me.lblPatient_Registration.TabIndex = 7
        Me.lblPatient_Registration.Text = "Dispensary"
        '
        'btnAdd_Medicine
        '
        Me.btnAdd_Medicine.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd_Medicine.Location = New System.Drawing.Point(525, 228)
        Me.btnAdd_Medicine.Name = "btnAdd_Medicine"
        Me.btnAdd_Medicine.Size = New System.Drawing.Size(305, 38)
        Me.btnAdd_Medicine.TabIndex = 0
        Me.btnAdd_Medicine.Text = "Add Medication"
        Me.btnAdd_Medicine.UseVisualStyleBackColor = True
        '
        'btnView_Medication_Available
        '
        Me.btnView_Medication_Available.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView_Medication_Available.Location = New System.Drawing.Point(525, 300)
        Me.btnView_Medication_Available.Name = "btnView_Medication_Available"
        Me.btnView_Medication_Available.Size = New System.Drawing.Size(305, 38)
        Me.btnView_Medication_Available.TabIndex = 1
        Me.btnView_Medication_Available.Text = "View Medication Available"
        Me.btnView_Medication_Available.UseVisualStyleBackColor = True
        '
        'btnEdit_Medication_Records
        '
        Me.btnEdit_Medication_Records.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit_Medication_Records.Location = New System.Drawing.Point(525, 372)
        Me.btnEdit_Medication_Records.Name = "btnEdit_Medication_Records"
        Me.btnEdit_Medication_Records.Size = New System.Drawing.Size(305, 38)
        Me.btnEdit_Medication_Records.TabIndex = 2
        Me.btnEdit_Medication_Records.Text = "Edit  / Delete Medication Records"
        Me.btnEdit_Medication_Records.UseVisualStyleBackColor = True
        '
        'Dispensary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 716)
        Me.Controls.Add(Me.btnView_Medication_Available)
        Me.Controls.Add(Me.btnEdit_Medication_Records)
        Me.Controls.Add(Me.btnAdd_Medicine)
        Me.Controls.Add(Me.lblPatient_Registration)
        Me.Controls.Add(Me.Back)
        Me.Name = "Dispensary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispensary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents lblPatient_Registration As System.Windows.Forms.Label
    Friend WithEvents btnAdd_Medicine As System.Windows.Forms.Button
    Friend WithEvents btnView_Medication_Available As System.Windows.Forms.Button
    Friend WithEvents btnEdit_Medication_Records As System.Windows.Forms.Button
End Class
