﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigurationToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'ConfigurationToolStripMenuItem
		'
		Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
		Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
		Me.ConfigurationToolStripMenuItem.Text = "Configuration"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(485, 167)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(806, 463)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MainForm"
		Me.Text = "Form1"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ConfigurationToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Button1 As Button
End Class
