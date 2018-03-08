Public Class Configuration




	Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

		Dim newFilePath As String = Nothing
		newFilePath = DoThings.AddFilePath()

		If newFilePath IsNot Nothing Then
			lstbx_FilePathToBackup.Items.Add(newFilePath)
		Else
			MessageBox.Show("File path cannot be nothing", "Information")
		End If

		'TODO: Save File Location to XML or SQL...Still thinking about it.

	End Sub
End Class