Public Class ShopBar
    Dim shoppanel As Panel = New Panel
    Dim toplabel As Label = New Label
    Dim bottomlabel As Label = New Label
    Dim WithEvents buylabel As Label = New Label
    Dim WithEvents selllabel As Label = New Label


    Public Sub New(item As String, loc As Point)
        shoppanel.Name = item
        shoppanel.Location = loc 'this entire section is just setting labels and boxes
        shoppanel.Size = New Size(435, 60)
        toplabel.Text = item
        toplabel.Location = New Point(8, 9)
        toplabel.Font = New Font("Segoe UI", 11.25, FontStyle.Bold)
        bottomlabel.Location = New Point(8, 29)
        bottomlabel.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        If Inventory.doesItemExist(item) Then
            bottomlabel.Text = "You have: " + CStr(Inventory.itemInstances(item))
        Else
            bottomlabel.Text = "You have: 0"
        End If
        buylabel.ForeColor = Color.Green
        buylabel.Text = "BUY FOR " + CStr(getValue(item) + 9)
        buylabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        buylabel.Location = New Point(114, 29)
        selllabel.ForeColor = Color.Red
        selllabel.Text = "SELL FOR " + CStr(getValue(item))
        selllabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        selllabel.Location = New Point(114, 9)
        toplabel.AutoSize = True
        bottomlabel.AutoSize = True
        buylabel.AutoSize = True
        selllabel.AutoSize = True
        shoppanel.Controls.Add(toplabel)
        shoppanel.Controls.Add(bottomlabel)
        shoppanel.Controls.Add(buylabel)
        shoppanel.Controls.Add(selllabel)
    End Sub

    Function returnPanel()
        Return shoppanel
    End Function

    Sub updatelabels(item)
        If Inventory.doesItemExist(item) Then
            bottomlabel.Text = "You have: " + CStr(Inventory.itemInstances(item)) 'updates label
        Else
            bottomlabel.Text = "You have: 0"
        End If
    End Sub

    Sub btnClick(sender As Object, e As EventArgs) Handles buylabel.Click
        Dim parentitem As String = shoppanel.Name
        If parentitem = "City Keys" Then
            If returnQuestLogLength() = 15 Then 'if player has completed all quests
                If getMultiplier() = 15 Then 'if player has maxed all flowers
                    If Inventory.returnBalance - (getValue(parentitem) + 9) >= 0 Then
                        Inventory.subtractMoney(getValue(parentitem) + 9)
                        Inventory.addInventory(parentitem) 'give the city keys to the player
                        LoadBoxes.itemaddition(parentitem, 1)
                        updatelabels(parentitem)
                        Exit Sub
                    End If
                Else
                    buylabel.Text = "You need to max out all flower levels to buy this..."
                    buylabel.AutoSize = True
                End If
            Else
                buylabel.Text = "You need to complete all the quests to access this..."
                buylabel.AutoSize = True
            End If
        End If
        If Inventory.returnBalance - (getValue(parentitem) + 9) >= 0 Then 'else just do the ordinary procedure
            Inventory.subtractMoney(getValue(parentitem) + 9)
            Inventory.addInventory(parentitem)
            LoadBoxes.itemaddition(parentitem, 1)
            updatelabels(parentitem)
        End If
    End Sub
    Sub btnClick2(sender As Object, e As EventArgs) Handles selllabel.Click 'if item exists then sell item
        Dim parentitem As String = shoppanel.Name
        If Inventory.doesItemExist(parentitem) Then
            Inventory.addMoney(getValue(parentitem))
            Inventory.removeInventory(parentitem)
            updatelabels(parentitem)
        End If
    End Sub
End Class
