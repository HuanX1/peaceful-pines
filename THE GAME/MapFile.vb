Imports System.Text.RegularExpressions

Module MapFile
    Dim gridarr As List(Of String) = New List(Of String)
    'Dim splitGrid = grid.Split(vbCrLf)
    Dim r As Random = New Random
    Dim grids(2)() As String
    Sub NewFile(filename As String, playerName As String)
        For n As Integer = 0 To 2 Step 1 'creates a 3x3 of plain text grids
            'For x As Integer = 0 To 2 Step 1
            gridarr.AddRange(
  {"###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############",
"###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############",
"###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############
###############"})
            'Next x
            Dim newarr As String() = gridarr.ToArray
            grids(n) = newarr
            gridarr = New List(Of String)
        Next n
        Dim direction As Integer
        Dim previousRow, previousColumn, row, col As Integer 'Declaring the indexes we will use to call array grids
        row = 2
        col = 0
        previousRow = row
        previousColumn = col
        direction = 0 '0 = straight, 1 = turn
        Dim riverStartIndex As Integer = r.Next(3, 11)
        Dim riverStartRow As Integer = 14
        Dim finish As Boolean = False
        While finish = False 'While the river hasnt fully generated, do the following
            Dim turn As Integer = r.Next(1, 2)
            Dim Limiter As Integer
            Dim turnRow As Integer 'index of which the row turned
            If turn = 1 Then
                Limiter = r.Next(3, 11)
                direction = 1
            Else
                Limiter = 15 'box is 15x15, doesnt matter which way this is assigned
                direction = 0
            End If
            Dim currentGrid = grids(row)(col).Split(vbCrLf)
            If col = previousColumn Then
                If direction = 0 Then 'go straight upwards
                    currentGrid = verticalTraversal(riverStartIndex, riverStartRow, currentGrid, Limiter)
                    If row = 0 Then
                        finish = True
                        row += 1
                    End If
                    previousRow = row
                    previousColumn = col
                    row -= 1
                Else
                    currentGrid = verticalTraversal(riverStartIndex, riverStartRow, currentGrid, Limiter)
                    Dim rowRemains As Integer = rowRemainder(riverStartIndex)
                    currentGrid = horizontalTraversal(riverStartIndex, 14 - Limiter, currentGrid, rowRemains)
                    If col = 2 Then 'will do a turn partway through
                        finish = True
                        col -= 1
                    End If
                    previousRow = row
                    previousColumn = col
                    col += 1
                    turnRow = 14 - Limiter
                End If
            ElseIf row = previousRow Then
                If direction = 0 Then ' go straight on right
                    currentGrid = horizontalTraversal(2, turnRow, currentGrid, Limiter) 'it ALWAYS starts going up, therefore turnRow will ALWAYS have an assignment when this iscalled
                    If col = 2 Then
                        finish = True
                        col -= 1
                    End If
                    previousRow = row
                    previousColumn = col
                    col += 1
                Else
                    currentGrid = horizontalTraversal(2, turnRow, currentGrid, Limiter)
                    riverStartRow = turnRow - 1
                    riverStartIndex = Limiter 'will do a turn upwards
                    currentGrid = verticalTraversal(riverStartIndex, riverStartRow, currentGrid, rowRemainder(Limiter))
                    If row = 0 Then
                        finish = True
                        row += 1
                    End If
                    previousRow = row
                    previousColumn = col
                    row -= 1
                End If
            End If
            grids(previousRow)(previousColumn) = String.Join(vbCrLf, currentGrid)
        End While
        grids = generateOthers(grids)
        writeFile(grids, filename, playerName, "None", "Empty", 10, "Axe:1,Watering Can:1,Fishing Rod:1", "1,1,1,1,1,1,1,1") 'base of all new files
    End Sub

    Sub writeFile(grids, filename, playerName, currentQuest, questLog, money, inventory, flowerlevels)
        Dim objReader As New System.IO.StreamWriter("D:\old stuff\gameassets\" + CStr(filename) + ".txt") 'writes the new file in the same format as the way it was loaded
        For x As Integer = 0 To 2 Step 1
            objReader.WriteLine(grids(x)(0))
            objReader.WriteLine()
            objReader.WriteLine(grids(x)(1))
            objReader.WriteLine()
            objReader.WriteLine(grids(x)(2))
            objReader.WriteLine()
        Next x
        objReader.WriteLine(playerName)
        objReader.WriteLine(currentQuest)
        objReader.WriteLine(questLog)
        objReader.WriteLine(money)
        objReader.WriteLine(inventory)
        objReader.WriteLine(flowerlevels)
        objReader.Close()
    End Sub

    Function loadFile(filename As String)
        Dim objReader As New System.IO.StreamReader("D:\old stuff\gameassets\" + filename + ".txt")
        Dim grids = objReader.ReadToEnd()
        Dim newgrid As String = Regex.Replace(grids, "^\s+$[\r\n]*", "", RegexOptions.Multiline) 'regular expression to replace blank lines
        Dim splitgrid As String() = newgrid.Split(vbCrLf)
        Dim linelist As List(Of String) = New List(Of String) 'after splitting the read text, make a new (empty) list to append lines into to form a text block
        Dim finishedarray(9) As String
        For n As Integer = 0 To 134 Step 1
            linelist.Add(splitgrid(n))
            If (n + 1) Mod 15 = 0 Then
                Console.WriteLine(String.Join(vbCrLf, linelist.ToArray))
                finishedarray(n \ 15) = String.Join(vbCrLf, linelist.ToArray) 'at the index of whichever chunk we are at, join the list of lines into a long string
                linelist = New List(Of String)
            End If
        Next
        Inventory.setName(splitgrid(135)) 'assign each module their respective information
        Quests.LoadQuestLog(splitgrid(137), splitgrid(136))
        Inventory.loadInvAndMoney(splitgrid(139), splitgrid(138))
        Upgrades.assignstring(splitgrid(140))
        MapLoad.assignMapText(String.Join(vbCrLf, finishedarray))
        Return finishedarray
    End Function

    Function verticalTraversal(startingIndex As Integer, startingRow As Integer, gridd As Array, limit As Integer) 'recursive...
        If startingRow >= 0 And limit >= 0 Then
            gridd(startingRow) = Replace(gridd(startingRow), "#", "RR", startingIndex, 1) 'this removes all tags before the count through therefore:
            gridd(startingRow) = gridd(startingRow).Insert(0, New String("#", (startingIndex - 2)))
            Console.WriteLine(gridd(startingRow))
            startingRow -= 1
            limit -= 1
            Console.WriteLine(limit)
            Return verticalTraversal(startingIndex, startingRow, gridd, limit)
        Else
            Return gridd
        End If
    End Function

    Function horizontalTraversal(startingIndex As Integer, startingRow As Integer, gridd As Array, limit As Integer)
        If startingIndex <= 14 Then
            gridd(startingRow) = Replace(gridd(startingRow), "#", "R", startingIndex - 1, limit) 'replaces the strings from the index onwards with R
            gridd(startingRow) = gridd(startingRow).Insert(0, New String("#", (startingIndex - 2))) 'replaces the strings behind with #
            gridd(startingRow + 1) = Replace(gridd(startingRow + 1), "#", "R", startingIndex - 1, limit)
            gridd(startingRow + 1) = gridd(startingRow + 1).Insert(0, New String("#", (startingIndex - 2)))
            Return gridd
        Else
            Return gridd
        End If
    End Function

    Function rowRemainder(index As Integer)
        Return 17 - index
    End Function

    Function generateOthers(grid As Array)
        Dim limits As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        limits.Add("T", 12)
        limits.Add("N", 6)
        limits.Add("F", 8)
        limits.Add("C", 1)
        limits.Add("S", 1)
        'How many of each item will be produced in map generation ^
        'Dim row As Integer = 0
        Dim indexing As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
        indexing.Add(0, "T")
        indexing.Add(1, "N")
        indexing.Add(2, "F")
        indexing.Add(3, "C")
        indexing.Add(4, "S")
        'Indexes for choosing tile
        Dim newGrid(2) As String
        While getResults(limits) > 0
            For M As Integer = 0 To 2 Step 1 'for each grid row
                Dim gridx = grid(M)
                Dim newlist As List(Of String) = New List(Of String)
                For x As Integer = 0 To 2 Step 1 'for each grid IN the row
                    Dim gridd = Split(gridx(x), vbCrLf)
                    For row = 0 To 13 Step 1 'for each actual row in the grid (leaves a row out for collision purposes)
                        For col = 1 To 13 Step 1 'for each column (leaves 2 columns out for generation purposes)
                            Dim index As Integer = r.Next(0, 100)
                            If index < 3 Then 'if the tile is not a shop
                                If gridd(row)(col) = "#" And limits(indexing(index)) > 0 Then
                                    Dim subst = gridd(row).Substring(0, col - 1)
                                    gridd(row) = Replace(gridd(row), "#", indexing(index), col, 1)
                                    gridd(row) = gridd(row).Insert(0, subst)
                                    limits(indexing(index)) -= 1
                                End If
                            End If
                            If index >= 3 And index < 5 Then 'if tile is coffeesho pro shop, explained in the document
                                If gridd(row)(col) = "#" And gridd(row)(col + 1) = "#" And limits(indexing(index)) > 0 Then
                                    Dim subst = gridd(row).Substring(0, col - 1)
                                    gridd(row) = Replace(gridd(row), "#", indexing(index), col, 2)
                                    gridd(row) = gridd(row).Insert(0, subst)
                                    limits(indexing(index)) -= 1
                                End If
                            End If
                        Next col
                    Next row
                    newlist.Add(String.Join(vbCrLf, gridd))
                Next x
                grid(M) = newlist.ToArray() 'turns the new list into an actual array
            Next M
        End While
        Return grid
    End Function

    Function getResults(limits As Dictionary(Of String, Integer))
        Dim result As Integer = 0
        For Each Kvp As KeyValuePair(Of String, Integer) In limits
            result += Kvp.Value 'adds the limits left of each feature to load
        Next
        Return result
    End Function
End Module
