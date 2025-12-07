Imports System.Diagnostics.Metrics

Module MapLoad
    Dim gridblocks(15)() As PictureBox
    Dim NpanelsGrid As List(Of Panel) = New List(Of Panel)
    Dim textVersionofMap(2)() As String

    Function initialise(filename As String)
        For n As Integer = 0 To 8 Step 1
            Dim panel = New MapPanel(n)
            NpanelsGrid.Add(panel.returnPanel()) 'creates 9 panels and arranges them in a grid
        Next n
        Dim panelsGrid = NpanelsGrid.ToArray
        Dim mapgrid = MapFile.loadFile(filename)
        Dim initialLoc As Point = New Point(0, 0)

        For n As Integer = 0 To 8 Step 1
            Dim splitgrid = mapgrid(n).Split(vbCrLf)
            For x As Integer = 0 To 14 Step 1 'iterates 15 times
                gridblocks(x) = addrow(initialLoc, splitgrid(x)) 'for each panel, add 15 rows of 15 tiles
                initialLoc = New Point(0, initialLoc.Y + 48) 'each iteration move the row down by the height of the gridbox (so they all leave no gaps)
                panelsGrid(n).Controls.AddRange(gridblocks(x))
            Next x
            initialLoc.Y = 0
        Next n
        Return panelsGrid
    End Function


    Private Function addrow(loc As Point, gridlist As String) 'creates a row of 15 tiles
        Dim array As List(Of PictureBox) = New List(Of PictureBox)
        For X As Integer = 0 To 14 Step 1
            Dim counter As Integer = 0
            Dim tile As New MapTile(gridlist(X), counter)
            tile.setLocation(loc) 'adds the tiles
            array.Add(tile.returnTile()) 'add tile to array, 15 times
            loc = New Point(loc.X + 48, loc.Y)
            counter += 1
        Next X
        Dim finish As PictureBox() = array.ToArray 'makes the final list into an actual picturebox only array
        Return finish
    End Function

    Public Sub assignNPCs(grids)
        Dim counter = 0
        Dim names = Interaction.getNames()
        For n = 0 To 8 Step 1 'for each grid
            Dim currentGrid = grids(n)
            For Each PictureBox In currentGrid.Controls
                If PictureBox.BackColor = Color.Brown And PictureBox.Image Is Nothing Then 'if the tile is an NPC tile
                    Dim NPC As NPC = New NPC(names(counter), PictureBox.Size, PictureBox.Location) 'make a new NPC class and assign it to the tile
                    NPC.getCharacter().BackColor = Color.Brown
                    grids(n).Controls.Remove(PictureBox) 'remove old tile, add NPC
                    grids(n).Controls.Add(NPC.getCharacter())
                    counter += 1
                End If
            Next
        Next
    End Sub



    Public Sub assignMapText(mapAsText As String) 'assign the map in text form
        Dim finalVersion(2)() As String
        Dim tempHolder As String = ""
        Dim tempList As List(Of String) = New List(Of String)
        Dim splitversion = mapAsText.Split(vbCrLf)
        For x = 1 To 9 Step 1
            For n = 15 * (x - 1) To (15 * x) - 1 Step 1 'takes in 9 batches: lines 0-14, lines 15, 29... etc..
                tempHolder += splitversion(n) + vbCrLf
            Next
            tempList.Add(tempHolder)
            tempHolder = ""
            If x Mod 3 = 0 Then 'for every 3 grids, turn them into a row of 3 panels so that the end result is 3x3
                finalVersion((x \ 3) - 1) = tempList.ToArray()
                tempList = New List(Of String)
            End If
        Next
        textVersionofMap = finalVersion 'return the final 2D array
    End Sub

    Public Function returnMapText()
        Return textVersionofMap
    End Function

End Module
