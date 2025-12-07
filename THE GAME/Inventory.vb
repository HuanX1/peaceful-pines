Module Inventory
    Dim Pinventory As New Dictionary(Of String, Integer)
    Dim activeBar(2) As String
    Dim activeIndex As Integer = 0
    Dim itemdefs As New Dictionary(Of String, String)
    Dim money As Integer = 0
    Dim playername As String
    Public Sub loadInvAndMoney(inventory, moneyin) 'load inventory items and money from the file
        Dim invList = inventory.Split(",")
        money = moneyin
        For x = 0 To invList.Length - 1 Step 1
            Dim invEntry = invList(x).Split(":") 'colon separator
            Pinventory.Add(invEntry(0), CInt(invEntry(1)))
        Next 'add item as key and amount of item as value
        loadActive(Pinventory.Keys.ToArray)
    End Sub

    Public Sub loadActive(inventory) 'load the active items from the loaded inventory file
        For x = 0 To 2 Step 1
            activeBar(x) = inventory(x)
            Pinventory.Remove(inventory(x))
        Next
    End Sub

    Public Sub addInventory(item) 'add item to inventory
        Dim currentitems = Pinventory.Keys
        If currentitems.Contains(item) Then
            Pinventory(item) += 1
        Else
            If currentitems.Count < 10 Then 'as long as current items are under length of 10 overall then run
                Pinventory.Add(item, 1)
            End If
        End If
    End Sub

    Public Sub removeInventory(item As String)
        Dim currentitems = Pinventory.Keys
        If currentitems.Contains(item) Then
            If Pinventory(item) = 1 Then 'if only one instance of item, remove entire item
                Pinventory.Remove(item)
            Else
                Pinventory(item) -= 1 'otherwise just remove one instance
            End If
        End If
    End Sub

    Public Sub newBoxes(ByRef boxes As List(Of PictureBox))
        Dim items = Pinventory.Keys.ToArray
        For k = 0 To items.Length - 1 Step 1
            boxes(k).Image = Image.FromFile("D:\old stuff\gameassets\" + items(k) + ".png") 'first time load boxes with the images from file
            boxes(k).Tag = items(k)
        Next
    End Sub

    Public Sub updateBoxes(ByRef item As String, boxes As List(Of PictureBox))
        For Each box In boxes
            If box.Tag = item Then
                Exit Sub
            End If
        Next
        For Each box In boxes
            If box.Tag Is Nothing Then
                box.Image = Image.FromFile("E:/gameassets/" + item + ".png") 'update boxes with new items if they exist
                box.Tag = item
                Exit Sub
            End If
        Next
    End Sub

    Public Sub changeActiveItem(index) 'changes index of active item
        activeIndex = index
    End Sub

    Public Sub subtractMoney(amount As Integer)
        money -= amount
    End Sub

    Public Sub addMoney(amount As Integer)
        money += Math.Floor(amount * getMultiplier()) 'adds money and times it by the multiplier the player has.
    End Sub

    Public Sub setName(playernamea)
        playername = playernamea
    End Sub

    '------------------ SUB ^ FUNCTION v

    Public Function returnInventory()
        Dim finalList As List(Of String) = New List(Of String)
        For x = 0 To 2 Step 1
            finalList.Add(activeBar(x) + ":1") 'explained in document
        Next
        If Pinventory.Keys.ToArray().Length > 0 Then
            For n = 0 To Pinventory.Keys.ToArray().Length - 1 Step 1
                finalList.Add(Pinventory.Keys.ToArray()(n) + ":" + CStr(Pinventory.Values.ToArray()(n)))
            Next
        End If
        Dim finalString As String = String.Join(",", finalList)
        Return finalString
    End Function

    Public Function returnName()
        Return playername
    End Function
    Public Function returnInventoryLength()
        Return Pinventory.Keys.ToArray.Count
    End Function

    Public Function doesItemExist(item As String) 'returns if item exists boolean
        Return Pinventory.Keys.Contains(item)
    End Function
    Public Function returnActiveItem()
        Return activeBar(activeIndex)
    End Function

    Public Function returnBalance()
        Return money
    End Function

    Public Function itemInstances(item As String) 'Assuming that the invoking script has done the correct validation, we wont need to
        Return Pinventory(item)
    End Function
End Module
