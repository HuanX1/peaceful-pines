Public Class Character
    Dim character As New PictureBox

    Public Sub New(name As String, loc As Point)
        character.Name = name
        character.Size = New Size(32, 32)
        character.Enabled = True
        character.Visible = True
        character.Location = loc
    End Sub

    Public Function getIcon() As Image
        Return character.Image
    End Function

    Public Sub changeIcon(image As Image)
        character.Image = image
    End Sub

    Public Sub changeLocation(loc As Point)
        character.Location = loc
    End Sub

    Public Function getLocation() As Point
        Return character.Location
    End Function

    Public Function getCharacter() As PictureBox
        Return character
    End Function

    Public Function getName() As String
        Return character.Name
    End Function

    Public Sub setName(playername)
        character.Name = playername
    End Sub
End Class
