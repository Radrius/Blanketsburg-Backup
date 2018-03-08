<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
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
		Me.lstbx_FilePathToBackup = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btn_Add = New System.Windows.Forms.Button()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.btn_RemoveFilePath = New System.Windows.Forms.Button()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lstbx_FilePathToBackup
		'
		Me.lstbx_FilePathToBackup.FormattingEnabled = True
		Me.lstbx_FilePathToBackup.Location = New System.Drawing.Point(6, 19)
		Me.lstbx_FilePathToBackup.Name = "lstbx_FilePathToBackup"
		Me.lstbx_FilePathToBackup.Size = New System.Drawing.Size(224, 303)
		Me.lstbx_FilePathToBackup.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 3)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(104, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "File Path To Backup"
		'
		'btn_Add
		'
		Me.btn_Add.Location = New System.Drawing.Point(9, 328)
		Me.btn_Add.Name = "btn_Add"
		Me.btn_Add.Size = New System.Drawing.Size(75, 23)
		Me.btn_Add.TabIndex = 2
		Me.btn_Add.Text = "Add"
		Me.btn_Add.UseVisualStyleBackColor = True
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(7, 6)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(564, 461)
		Me.TabControl1.TabIndex = 3
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
		Me.TabPage1.Controls.Add(Me.btn_RemoveFilePath)
		Me.TabPage1.Controls.Add(Me.Label1)
		Me.TabPage1.Controls.Add(Me.btn_Add)
		Me.TabPage1.Controls.Add(Me.lstbx_FilePathToBackup)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(556, 435)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		'
		'TabPage2
		'
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(556, 435)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'btn_RemoveFilePath
		'
		Me.btn_RemoveFilePath.Location = New System.Drawing.Point(90, 328)
		Me.btn_RemoveFilePath.Name = "btn_RemoveFilePath"
		Me.btn_RemoveFilePath.Size = New System.Drawing.Size(75, 23)
		Me.btn_RemoveFilePath.TabIndex = 3
		Me.btn_RemoveFilePath.Text = "Remove"
		Me.btn_RemoveFilePath.UseVisualStyleBackColor = True
		'
		'Configuration
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(583, 479)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Configuration"
		Me.Text = "Configuration"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lstbx_FilePathToBackup As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents btn_Add As Button
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents btn_RemoveFilePath As Button
End Class
