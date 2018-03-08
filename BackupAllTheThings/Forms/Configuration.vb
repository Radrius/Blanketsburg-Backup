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

End Class