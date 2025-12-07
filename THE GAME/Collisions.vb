Module Collisions
    Dim map As Object
    Dim currentIndex As Integer
    Dim currentGrid As Panel

    Public Sub Loadmap(grids As Object, index As Integer)
        map = grids
        currentIndex = index
        currentGrid = map(currentIndex)
    End Sub

    Public Function getCurrentChunk()
        Return currentGrid
    End Function

    Public Function checkBounds(player As PictureBox)
        Dim playerRect As Rectangle = New Rectangle(New Point(280 + player.Bounds.X, 120 + player.Bounds.Y), player.Size)
        Dim intersectRect As Rectangle = Rectangle.Intersect(currentGrid.Bounds, playerRect)
        If intersectRect.Size.Width < player.Size.Width Then 'checks if rectangle generated has gotten smaller horizontally (means player has gone out of bound horizontally
            If intersectRect.Location.X > 360 Then 'is player beyond the midpoint of the form horizontally?
                Return changeChunk("Right", player) 'if yes, they are on the right
            Else
                Return changeChunk("Left", player) 'if no, they are on the left
            End If
        ElseIf intersectRect.Size.Height < player.Size.Height Then
            If intersectRect.Bottom < currentGrid.Bottom Then 'is player below the midpoint vertically?
                Return changeChunk("Top", player) 'if no, they are at the top
            Else
                Return changeChunk("Bottom", player) 'if yes, they are at the bottom
            End If
        End If
        Return ""
    End Function

    Public Sub checkCollision(player As PictureBox, direction As String)
        Dim playerRect As Rectangle = New Rectangle(New Point(player.Bounds.X, player.Bounds.Y), player.Size)
        For Each PictureBox In currentGrid.Controls
            If playerRect.IntersectsWith(PictureBox.Bounds) And Not (PictureBox.BackColor = Color.Green) And PictureBox.Name <> player.Name Then 'if picturebox intersects with an obstacle
                Select Case direction 'move player in opposite direction
                    Case "W"
                        player.Top += 12
                    Case "S"
                        player.Top -= 12
                    Case "A"
                        player.Left += 12
                    Case "D"
                        player.Left -= 12
                End Select
            End If
        Next
    End Sub

    Private Function changeChunk(direction As String, player As PictureBox)
        Select Case direction
            Case "Right"
                If currentIndex = 2 Or currentIndex = 5 Or currentIndex = 8 Then 'if player is on right side grids of the whole map
                    Console.WriteLine("Edge of panel") 'dont move to new panel
                    player.Location = New Point(player.Location.X - 24, player.Location.Y)
                Else
                    currentIndex += 1
                    currentGrid.Controls.Remove(player)
                    player.Location = New Point(0, player.Location.Y)
                    currentGrid = map(currentIndex)
                    currentGrid.Controls.Add(player) 'otherwise move the player to the new panel and return the new panel
                    player.BringToFront()
                End If
            Case "Left"
                If currentIndex = 0 Or currentIndex = 3 Or currentIndex = 6 Then 'if player is on left side grids of the whole map
                    Console.WriteLine("Edge of panel")
                    player.Location = New Point(player.Location.X + 24, player.Location.Y)
                Else
                    currentIndex -= 1
                    currentGrid.Controls.Remove(player) 'otherwise move the player to the new panel and return the new panel
                    player.Location = New Point(685, player.Location.Y)
                    currentGrid = map(currentIndex)
                    currentGrid.Controls.Add(player)
                    player.BringToFront()
                End If
            Case "Top"
                If currentIndex - 3 < 0 Then
                    Console.WriteLine("Edge of panel") 'if player is on top side grids of the whole map
                    player.Location = New Point(player.Location.X, player.Location.Y + 24)
                Else
                    currentIndex -= 3
                    currentGrid.Controls.Remove(player)
                    player.Location = New Point(player.Location.X, 675)
                    currentGrid = map(currentIndex) 'otherwise move the player to the new panel and return the new panel
                    currentGrid.Controls.Add(player)
                    player.BringToFront()
                End If
            Case "Bottom"
                If currentIndex + 3 > 8 Then
                    Console.WriteLine("Edge of panel") 'if player is on bottom side grids of the whole map
                    player.Location = New Point(player.Location.X, player.Location.Y - 24)
                Else
                    currentIndex += 3
                    currentGrid.Controls.Remove(player)
                    player.Location = New Point(player.Location.X, 0)
                    currentGrid = map(currentIndex) 'otherwise move the player to the new panel and return the new panel
                    currentGrid.Controls.Add(player)
                    player.BringToFront()
                End If
        End Select

        Return currentGrid
    End Function


    Dim debounce As Boolean = False
    Dim currentBox As Label
    Dim interactableStack As Stack(Of PictureBox) = New Stack(Of PictureBox)
    Public Sub isInteractionColliding(player As PictureBox, form As Form)
        Dim interactRect As Rectangle = New Rectangle(New Point(player.Location.X - 18, player.Location.Y - 18), New Size(68, 68))
        For Each PictureBox In currentGrid.Controls 'for each tile in the grid
            If interactRect.IntersectsWith(PictureBox.Bounds) And Not (PictureBox.BackColor = Color.Green) And PictureBox.Name <> player.Name And debounce = False And Not (interactableStack.Contains(PictureBox)) Then
                interactableStack.Push(PictureBox) 'if interactable item in range, add to stack
                Dim interactBox As Label = LoadBoxes.popupinteract(player, PictureBox)
                currentBox = interactBox
                form.Controls.Add(interactBox) 'prompt user that they can interact
                interactBox.BringToFront()
                debounce = True
                Exit For
            End If
            If interactableStack.Count > 0 Then
                If interactableStack.Peek IsNot PictureBox And debounce = True And interactRect.IntersectsWith(PictureBox.Bounds) And Not (PictureBox.BackColor = Color.Green) Then
                    form.Controls.Remove(currentBox) 'remove interactable item from stack once they leave range
                    interactableStack.Pop() 'make no prompt
                    currentBox = Nothing
                    debounce = False
                End If
            End If
        Next
    End Sub

    Public Function getCurrentInteractable()
        If interactableStack.Count = 0 Then
            Return Nothing
        Else
            Return interactableStack.Peek()
        End If
    End Function
End Module
