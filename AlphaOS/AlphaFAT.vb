Public Class AlphaFAT

    Public Shared Function GetDirContents(Dir As String) As String()

        Dim Files(256) As String
        Dim Folders(256) As String
        If IO.Directory.GetFiles(Dir).Length > 0 Then
            Files = IO.Directory.GetFiles(Dir)
        Else
            Files(0) = "Directory """ & Dir & " contains no files."""
        End If
        If IO.Directory.GetDirectories(Dir).Length > 0 Then
            Folders = IO.Directory.GetDirectories(Dir)
        Else
            Folders(0) = "Directory """ & Dir & " contains no other directories."""
        End If
        Return Files

    End Function

    Public Shared Function ReadFile(FileLocation As String) As String

        Dim FileRead() As String = IO.File.ReadAllLines(FileLocation)
        Return FileLocation

    End Function

End Class
