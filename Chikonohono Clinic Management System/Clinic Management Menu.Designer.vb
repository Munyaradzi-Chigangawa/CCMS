<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clinic_Management_Menu
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
        Me.btnAddWorkers = New System.Windows.Forms.Button()
        Me.btnViewWorkers = New System.Windows.Forms.Button()
        Me.btnSearchWorkers = New System.Windows.Forms.Button()
        Me.btnEditDeleteWorkers = New System.Windows.Forms.Button()
        Me.lblClinic_Management_Menu = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddWorkers
        '
        Me.btnAddWorkers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWorkers.Location = New System.Drawing.Point(515, 196)
        Me.btnAddWorkers.Name = "btnAddWorkers"
        Me.btnAddWorkers.Size = New System.Drawing.Size(324, 38)
        Me.btnAddWorkers.TabIndex = 0
        Me.btnAddWorkers.Text = "Add Workers"
        Me.btnAddWorkers.UseVisualStyleBackColor = True
        '
        'btnViewWorkers
        '
        Me.btnViewWorkers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewWorkers.Location = New System.Drawing.Point(515, 278)
        Me.btnViewWorkers.Name = "btnViewWorkers"
        Me.btnViewWorkers.Size = New System.Drawing.Size(324, 38)
        Me.btnViewWorkers.TabIndex = 0
        Me.btnViewWorkers.Text = "View Workers"
        Me.btnViewWorkers.UseVisualStyleBackColor = True
        '
        'btnSearchWorkers
        '
        Me.btnSearchWorkers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchWorkers.Location = New System.Drawing.Point(515, 360)
        Me.btnSearchWorkers.Name = "btnSearchWorkers"
        Me.btnSearchWorkers.Size = New System.Drawing.Size(324, 38)
        Me.btnSearchWorkers.TabIndex = 0
        Me.btnSearchWorkers.Text = "Search Workers"
        Me.btnSearchWorkers.UseVisualStyleBackColor = True
        '
        'btnEditDeleteWorkers
        '
        Me.btnEditDeleteWorkers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditDeleteWorkers.Location = New System.Drawing.Point(515, 442)
        Me.btnEditDeleteWorkers.Name = "btnEditDeleteWorkers"
        Me.btnEditDeleteWorkers.Size = New System.Drawing.Size(324, 38)
        Me.btnEditDeleteWorkers.TabIndex = 0
        Me.btnEditDeleteWorkers.Text = "Edit / Delete Workers Records"
        Me.btnEditDeleteWorkers.UseVisualStyleBackColor = True
        '
        'lblClinic_Management_Menu
        '
        Me.lblClinic_Management_Menu.AutoSize = True
        Me.lblClinic_Management_Menu.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinic_Management_Menu.Location = New System.Drawing.Point(447, 60)
        Me.lblClinic_Management_Menu.Name = "lblClinic_Management_Menu"
        Me.lblClinic_Management_Menu.Size = New System.Drawing.Size(461, 42)
        Me.lblClinic_Management_Menu.TabIndex = 9
        Me.lblClinic_Management_Menu.Text = "Clinic Management Menu"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(567, 524)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(221, 38)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Clinic_Management_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 717)
        Me.Controls.Add(Me.lblClinic_Management_Menu)
        Me.Controls.Add(Me.btnEditDeleteWorkers)
        Me.Controls.Add(Me.btnSearchWorkers)
        Me.Controls.Add(Me.btnViewWorkers)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddWorkers)
        Me.Name = "Clinic_Management_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clinic_Management_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddWorkers As System.Windows.Forms.Button
    Friend WithEvents btnViewWorkers As System.Windows.Forms.Button
    Friend WithEvents btnSearchWorkers As System.Windows.Forms.Button
    Friend WithEvents btnEditDeleteWorkers As System.Windows.Forms.Button
    Friend WithEvents lblClinic_Management_Menu As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
