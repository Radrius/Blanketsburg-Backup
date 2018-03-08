Public Class DoThings

	Public Shared Function AddFilePath()

		Try
			Dim folderb As FolderBrowserDialog = New FolderBrowserDialog()
			Dim FilePath As String = Nothing

			If folderb.ShowDialog() = DialogResult.OK Then
				FilePath = folderb.SelectedPath.ToString()
			End If

			Return FilePath

		Catch ex As Exception
			'TODO: Log exceptions to SQL server (include computer name)
		End Try

	End Function

	Public Shared Sub SaveBackupFilePath(ByVal FilePath As List(Of String))



	End Sub


End Class
