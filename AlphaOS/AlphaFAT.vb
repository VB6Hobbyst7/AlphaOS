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

End Class
