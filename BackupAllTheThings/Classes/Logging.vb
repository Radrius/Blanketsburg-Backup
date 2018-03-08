Imports System.IO
Imports System.Reflection
Public Class Logging

	Public Shared Sub WriteException(ByVal exception As String)

		Dim version As String
		Dim _Date As DateTime = DateTime.Now
		Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
		Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")

		version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Path = New Uri(Path).LocalPath

		If Not Directory.Exists(Path & "\Log\") Then
			Directory.CreateDirectory(Path & "\Log\")
		End If

		Dim LogPath As String = Path + "\Log\" & _DateString & "Blanketsburg_Backup.log"


		If Not File.Exists(LogPath) Then
			Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception)
			End Using
		Else
			Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(exception)
			End Using
		End If
	End Sub

	Public Shared Sub SpeedLog(ByVal time As TimeSpan)


		Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10 & ": ")

		Dim version As String
		Dim _Date As DateTime = DateTime.Now
		Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
		Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")

		version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

		Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
		Path = New Uri(Path).LocalPath

		If Not Directory.Exists(Path & "\Log\") Then
			Directory.CreateDirectory(Path & "\Log\")
		End If

		Dim LogPath As String = Path + "\Log\" & _DateString & "_Blanketsburg_BackupSpeed.log"


		If Not File.Exists(LogPath) Then
			Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_SpeedLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(elapsedTime)
			End Using
		Else
			Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_SpeedLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
				writer.WriteLine(elapsedTime)
			End Using
		End If


	End Sub


	Public Shared Sub information(ByVal info As String)


        Dim version As String
        Dim _Date As DateTime = DateTime.Now
        Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
        Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")

        version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

        Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        If Not Directory.Exists(Path & "\Log\") Then
            Directory.CreateDirectory(Path & "\Log\")
        End If

		Dim LogPath As String = Path & "\Log\" + _DateString & "_Blanketsburg_BackupInfo.log"


		If Not File.Exists(LogPath) Then
            Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_InfoLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
                writer.WriteLine(info)
            End Using
        Else
            Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_InfoLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
                writer.WriteLine(info)
            End Using
        End If
    End Sub

    Public Shared Sub ButtonLog(ByVal info As String)


        Dim version As String
        Dim _Date As DateTime = DateTime.Now
        Dim _DateString As String = _Date.ToString("MM-dd-yyyy")
        Dim _DateTimeString As String = _Date.ToString("MM/dd/yyyy HH:mm:ss")

        version = Assembly.GetExecutingAssembly().GetName().Version.ToString()

        Dim Path As String = IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase)
        Path = New Uri(Path).LocalPath

        If Not Directory.Exists(Path & "\Log\") Then
            Directory.CreateDirectory(Path & "\Log\")
        End If

		Dim LogPath As String = Path & "\Log\" + _DateString & "_Blanketsburg_BackupButton.log"


		If Not File.Exists(LogPath) Then
            Using writer As StreamWriter = New StreamWriter(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_ButtonLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
                writer.WriteLine(info)
            End Using
        Else
            Using writer As StreamWriter = File.AppendText(LogPath)
				writer.WriteLine("******************************** Blanketsburg_Backup_ButtonLog " & version & " ********************************")
				writer.WriteLine(_DateTimeString)
                writer.WriteLine(info)
            End Using
        End If
    End Sub
End Class
