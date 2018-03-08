Public Class Configuration

	'################## Start Global Variables ##############################

	'################## End Global Variables   ##############################




	Private Sub Configuration_Load(sender As Object, e As EventArgs) Handles Me.Load
		Try
			If Setup.BackupFilePath.Count > 0 Then
				For i As Integer = 0 To Setup.BackupFilePath.Count - 1
					lstbx_FilePathToBackup.Items.Add(Setup.BackupFilePath.Item(i))
				Next
			End If
		Catch ex As Exception
			Logging.WriteException(ex.ToString())
		End Try
	End Sub

	Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

		Dim newFilePath As String = Nothing
		Dim BackupPaths As List(Of String)

		newFilePath = DoThings.AddFilePath()
		Try
			If newFilePath IsNot Nothing Then
				lstbx_FilePathToBackup.Items.Add(newFilePath)
			Else
				MessageBox.Show("File path cannot be nothing", "Information")
			End If

			BackupPaths = New List(Of String)
			For i As Integer = 0 To lstbx_FilePathToBackup.Items.Count - 1
				BackupPaths.Add(lstbx_FilePathToBackup.Items.Item(i).ToString())
			Next
			DoThings.SaveBackupFilePath(BackupPaths)
		Catch ex As Exception
			Logging.WriteException(ex.ToString())
		End Try

	End Sub

	Private Sub btn_RemoveFilePath_Click(sender As Object, e As EventArgs) Handles btn_RemoveFilePath.Click

		Dim dt As New DataTable
		Dim dt2 As New DataTable
		Dim pathToRemove As Integer
		Dim BackupPaths As New List(Of String)

		dt.Columns.Add("FilePath")
		Try
			For i As Integer = 0 To Setup.BackupFilePath.Count - 1
				dt.Rows.Add(Setup.BackupFilePath.Item(i))
			Next

			If lstbx_FilePathToBackup.SelectedIndex > 0 Then
				pathToRemove = lstbx_FilePathToBackup.SelectedIndex
				dt2 = DoThings.RemoveFilePath(dt, pathToRemove)
				If dt2.Rows.Count > 0 Then
					lstbx_FilePathToBackup.Items.Clear()
					For Each r As DataRow In dt2.Rows
						lstbx_FilePathToBackup.Items.Add(r.Item("FilePath"))
						BackupPaths.Add(r.Item("FilePath"))
					Next
					DoThings.SaveBackupFilePath(BackupPaths)
				End If

			End If
		Catch ex As Exception
			Logging.WriteException(ex.ToString())
		End Try

	End Sub
End Class