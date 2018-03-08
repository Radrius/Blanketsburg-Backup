Imports System.Xml
Imports System.Reflection
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

	Public Shared Function RemoveFilePath(ByVal CurrentBackupPaths As DataTable, ByVal PathToRemove As Integer)


		Dim PathToRemovedt As New DataTable
		PathToRemovedt.Columns.Add("FilePath")

		Try

			For Each r As DataRow In CurrentBackupPaths.Rows
				If CurrentBackupPaths.Rows.IndexOf(r) <> PathToRemove Then
					PathToRemovedt.Rows.Add(r.Item("FilePath"))
				End If
			Next


		Catch ex As Exception
			Logging.WriteException(ex.ToString())
		End Try


		Return PathToRemovedt


	End Function

	Public Shared Sub SaveBackupFilePath(ByVal FilePath As List(Of String))

		Dim dt As New DataTable
		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Dim AddToSetup As New Setup

		Try
			dt.TableName = "PathsToBackup"
			dt.Columns.Add("FilePath")

			For Each fp In FilePath
				dt.Rows.Add(fp)
			Next

			Path = New Uri(Path).LocalPath
			dt.WriteXml(Path & "\Config\BackPaths.xml", XmlWriteMode.WriteSchema)
		Catch ex As Exception
			Logging.WriteException(ex.ToString())
		End Try

	End Sub

End Class
