Module Menu
    Public Function TextValidate(sender As String)
        Dim pass As Boolean = False 'Assuming TextBoxes have their own character size limits, this will provide an extra check that there are no spaces or symbols in the text
        If (System.Text.RegularExpressions.Regex.IsMatch(sender, "^[a-zA-Z0-0]+$")) Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
End Module
