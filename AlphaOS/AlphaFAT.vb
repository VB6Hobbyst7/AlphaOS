Public Class AlphaFAT

    Public Shared Function GetFilesInDir(Dir As String) As String()

        Dim Files(256) As String
        If IO.Directory.GetFiles(Dir) IsNot "" Then

            Return IO.Directory.GetFiles(Dir)

        Else

            Files(0) = "Directory " & Dir & " contains no files."
            Return Files

        End If

    End Function

    Public Shared Function ReadFile(FileLocation As String) As String

        Dim FileRead() As String = IO.File.ReadAllLines(FileLocation)
        Return FileLocation

    End Function

End Class
