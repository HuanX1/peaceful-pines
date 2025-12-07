Public Class NPC
    Inherits Character


    Public Sub New(name As String, newsize As Size, position As Point)
        MyBase.New(name, position)
        MyBase.getCharacter().Size = newsize
        MyBase.changeIcon(Image.FromFile("D:\old stuff\gameassets\" + name + ".png"))
    End Sub


End Class
