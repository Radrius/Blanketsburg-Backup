Public Class MainForm
	Dim StartUp As New Setup
	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

		Setup.Startup()


	End Sub

	Private Sub ConfigurationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationToolStripMenuItem.Click

		Dim Config As New Configuration
		Config.Show()

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

		For i As Integer = 0 To Setup.BackupFilePath.Count - 1
			MessageBox.Show(Setup.BackupFilePath.Item(i).ToString())
		Next


	End Sub
End Class
