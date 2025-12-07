Public Class MapTile
    Dim tile As New PictureBox
    Dim r As Random = New Random
    Public Sub New(type As String, counter As Integer)
        tile.Name = "Tile" + ToString(counter)
        tile.Size = New Size(48, 48)
        tile.Enabled = True
        tile.Visible = True
        Select Case type
            Case "#"
                tile.BackColor = Color.Green
            Case "R"
                tile.BackColor = Color.Blue
            Case "T"
                tile.BackColor = Color.Purple
                tile.Image = Image.FromFile("D:\old stuff\gameassets\Tree.png")
            Case "N"
                tile.BackColor = Color.Brown
            Case "F"
                tile.BackColor = Color.Yellow
            Case "S"
                tile.BackColor = Color.Red
                tile.Image = Image.FromFile("D:\old stuff\gameassets\Shop.png")
            Case "C"
                tile.BackColor = Color.Black
                tile.Image = Image.FromFile("D:\old stuff\gameassets\CoffeeShop.png")
        End Select
    End Sub


    Public Sub setLocation(location As Point)
        tile.Location = location
    End Sub

    Public Function returnTile() As PictureBox
        Return tile
    End Function
End Class
