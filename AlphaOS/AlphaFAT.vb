Public Class AlphaFAT

    Public Shared Function GetDirContents(Dir As String) As String()

        Dim Files As String()
        Dim Folders As String()
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
        'Dim List As String() = String.Join(Files, Folders)
        'Return List
        Return Files

    End Function

    Public Shared Function ReadFile(FileLocation As String) As String

        Dim FileRead As String() = IO.File.ReadAllLines(FileLocation)
        Return FileRead(4096)

    End Function

End Class
