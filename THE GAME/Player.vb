Public Class Player
    Inherits Character
    Dim playerSpeed As Integer = 12
    Dim playerImage As Image = Image.FromFile("D:\old stuff\gameassets\player.png")

    Public Sub New(name As String, loc As Point)
        MyBase.New(name, loc)
        MyBase.changeIcon(playerImage)
    End Sub

    Public Sub movePlayer(direct As String)
        Select Case direct 'move player in direction stated with the player speed
            Case "W"
                MyBase.getCharacter().Top -= playerSpeed
            Case "S"
                MyBase.getCharacter().Top += playerSpeed
            Case "A"
                MyBase.getCharacter().Left -= playerSpeed
            Case "D"
                MyBase.getCharacter().Left += playerSpeed
            Case Else

        End Select
    End Sub

    Public Function getSpeed()
        Return playerSpeed

    End Function



End Class
