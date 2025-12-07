Imports System.Runtime.Intrinsics.X86

Module Upgrades
    Dim flowersLevel As New Dictionary(Of PictureBox, Integer)
    Dim maxLevel As Integer = 15
    Dim levelsarray As String

    Public Sub loadFlowers(grids) 'get flowers from grid
        For n = 0 To 8 Step 1
            Dim currentGrid = grids(n)
            For Each PictureBox In currentGrid.Controls
                If PictureBox.BackColor = Color.Yellow Then
                    flowersLevel.Add(PictureBox, 1)
                End If 'append each flowers level in order
            Next 'into the dictionary
        Next
    End Sub

    Public Sub assignFlowers() 'for file loading
        Dim splitlevels = levelsarray.Split(",")
        Dim keys = flowersLevel.Keys.ToArray()
        For k = 0 To splitlevels.Length - 1 Step 1
            If splitlevels(k) > flowersLevel(keys(k)) Then
                flowersLevel(keys(k)) = splitlevels(k)
            End If
        Next 'if the flower level from the file is larger than the default level
    End Sub 'then overwrite with the new level

    Public Function returnFlowers() As String 'For file saving
        Dim levellist As List(Of String) = New List(Of String)
        Dim values = flowersLevel.Values.ToArray()
        For Each value In values
            levellist.Add(CStr(value))
        Next
        Return String.Join(",", levellist.ToArray())
    End Function

    Public Sub assignstring(levels)
        levelsarray = levels
    End Sub

    Public Function getFlowerLevel(flower As PictureBox) As Integer
        Return flowersLevel(flower)
    End Function

    Public Sub updateFlowerLevel(flower As PictureBox)
        flowersLevel(flower) += 1
    End Sub

    Public Function getMultiplier() As Decimal 'gets multiplier
        Dim multi As Decimal = 0
        Dim values = flowersLevel.Values.ToArray()
        For Each value In values
            multi += value ^ 2 'gets sum of squares
        Next
        multi = multi / 8 'gets mean of squares
        multi = Math.Sqrt(multi) 'square roots result
        multi = Math.Round(multi, 2)
        Return multi
    End Function
End Module
