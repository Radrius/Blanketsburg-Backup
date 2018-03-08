Imports System.Xml
Imports System.Reflection
Public Class Setup


	Public Shared _BackupPath As New List(Of String)
	Public Shared ReadOnly Property BackupFilePath As List(Of String)
		Get
			Return _BackupPath
		End Get
	End Property




	Public Shared Sub Startup()

		Dim dt As New DataTable
		Dim xmlFile As XmlReader
		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Path = New Uri(Path).LocalPath

		xmlFile = XmlReader.Create(Path & "\Config\BackPaths.xml", New XmlReaderSettings())
		dt.ReadXml(xmlFile)

		For Each r As DataRow In dt.Rows
			_BackupPath.Add(r.Item("FilePath"))
		Next

	End Sub


End Class
