Module Quests
    Dim IDToQuest As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim QuestDialogue As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim QuestToReward As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim QuestAssignment As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim playerQuestLog As List(Of String) = New List(Of String)
    Dim currentQuest As String
    Public Sub initialise()
        IDToQuest.Add("Q001", "Deliver the coffee to Xandavier") 'sets all the quest ids to quest descriptions
        IDToQuest.Add("Q002", "Deliver the package to Sam")
        IDToQuest.Add("Q003", "Deliver the coffee to Donald")
        IDToQuest.Add("Q004", "Deliver the package to Kim")
        IDToQuest.Add("Q005", "Deliver the book to Tayquon")
        IDToQuest.Add("Q006", "Deliver the package to John")
        IDToQuest.Add("Q007", "Deliver the shirt to Kim")
        IDToQuest.Add("Q008", "Deliver the book to John")
        IDToQuest.Add("Q009", "Get 3 signatures")
        IDToQuest.Add("Q010", "Deliver the book to Sam")
        IDToQuest.Add("QO11", "Gather 6 apples and send them to Donald")
        IDToQuest.Add("Q012", "Gather 8 pieces of wood and send them to Xandavier")
        IDToQuest.Add("Q013", "Gather 6 fish and send them to Kim")
        IDToQuest.Add("Q014", "Buy a box of coffee and send them to Tayquon")
        IDToQuest.Add("Q015", "Head to Sam for your final reward")

        QuestDialogue.Add("Q001", "Yo, are you able to send these coffee beans to Xandavier?") 'sets all the quest ids to quest dialogues
        QuestDialogue.Add("Q002", "Could you help send this package to Sam please?")
        QuestDialogue.Add("Q003", "Have you seen? There's tons of flowers around the town recently. That's cool but thats not what im on about. Anyway, can you send these coffee beans to Donald? Thanks.")
        QuestDialogue.Add("Q004", "Hey, can you help send this package to Kim please?")
        QuestDialogue.Add("Q005", "I forgot to return this book to Tayquon, could you help send this back to him for me please?")
        QuestDialogue.Add("Q006", "I need to deliver this package to John, could you help me?")
        QuestDialogue.Add("Q007", "I borrowed this shirt off Kim recently, but I forgot I had to hand it back. Could you help send it back to her for me please?")
        QuestDialogue.Add("Q008", "Could you help me real quick? John left this book at my house last night, are you able to help return it to him? Thanks in advance!")
        QuestDialogue.Add("Q009", "Thanks... In fact, I need 3 signatures from people around the town in this book. Could you help me?")
        QuestDialogue.Add("Q010", "Sam is organising this event, could you send the form to her?")
        QuestDialogue.Add("Q011", "Hey, could you gather 6 apples for me please? It's for the event we're having!")
        QuestDialogue.Add("Q012", "I kinda need some firewood... Would you happen to help get me 8 pieces of wood?")
        QuestDialogue.Add("Q013", "I need to go fishing but I have had no time to do so recently... You wouldn't happen to be able to go fishing for me would you? I need 6 pieces!")
        QuestDialogue.Add("Q014", "I have a favour to ask you.. I'm kinda skint right now so but I need to prep for the event.. Could you help buy me a box of coffee?")
        QuestDialogue.Add("Q015", "Thank you so much! Thanks to you, we have improved our lifestyle and town for the better! Hopefully you'll have a great endeavour in your future too, and once again, thank you! (No more quests)")

        QuestAssignment.Add("John", "Q001,Q003,Q015") 'sets NPCs to quest ids
        QuestAssignment.Add("Tayquon", "Q002,Q010,Q014")
        QuestAssignment.Add("Xandavier", "Q005,Q007,Q012")
        QuestAssignment.Add("Sam", "Q004,Q006,Q009")
        QuestAssignment.Add("Kim", "Q008,Q013")
        QuestAssignment.Add("Donald", "Q011")

        QuestToReward.Add("Q001", 15)
        QuestToReward.Add("Q002", 15) 'sets reward per completed quest
        QuestToReward.Add("Q003", 15)
        QuestToReward.Add("Q004", 15)
        QuestToReward.Add("Q005", 15)
        QuestToReward.Add("Q006", 20)
        QuestToReward.Add("Q007", 20)
        QuestToReward.Add("Q008", 20)
        QuestToReward.Add("Q009", 30)
        QuestToReward.Add("Q010", 20)
        QuestToReward.Add("Q011", 50)
        QuestToReward.Add("Q012", 50)
        QuestToReward.Add("Q013", 50)
        QuestToReward.Add("Q014", 50)
        QuestToReward.Add("Q015", 500)
    End Sub

    Public Sub LoadQuestLog(inputquests, currentQuestfile) 'loads the quest log from the file
        Dim questlog
        If inputquests <> "Empty" Then 'if the quest log is empty then just make a new array, otherwise append the current quests already logged
            questlog = New List(Of String)
            For Each quest In inputquests.Split(",")
                questlog.Add(quest)
            Next
        Else
            questlog = New List(Of String)
        End If

        If questlog.Count > 0 Then
            For Each quest In questlog
                playerQuestLog.Add(quest)
            Next 'add each quest player has completed
        End If
        currentQuest = currentQuestfile
    End Sub

    Public Function hasQuestBeenDone(questcode As String) 'checks if quest is already done
        If playerQuestLog.Contains(questcode) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function returnCurrentQuest()
        Return currentQuest
    End Function

    Public Function returnCurrentQuestFromCode()
        If currentQuest Is Nothing Or currentQuest = "None" Then
            Return "Nothing"
        Else
            Return IDToQuest(currentQuest)
        End If
    End Function

    Public Function returnDialogue(questcode)
        Return QuestDialogue(questcode)
    End Function

    Public Function getReward(questcode)
        Return QuestToReward(questcode)
    End Function

    Public Function returnQuestLog()
        If playerQuestLog.Count = 0 Then
            Return "Empty"
        Else
            Return String.Join(",", playerQuestLog)
        End If
    End Function

    Public Function returnQuestLogLength()
        Return playerQuestLog.Count
    End Function

    Public Sub addToLog()
        playerQuestLog.Add(currentQuest)
        currentQuest = "None"
    End Sub

    Public Sub assignQuest()
        Dim lengthofarray = playerQuestLog.Count
        currentQuest = IDToQuest.Keys.ToArray()(lengthofarray) 'assign the next quest in the array off the length of already completed quests
        gothroughQuest(currentQuest)
    End Sub

    Private Sub gothroughQuest(currentQuesta)
        Dim desc = returnCurrentQuestFromCode()
        If Array.IndexOf(returnFullQuestList, currentQuest) < 8 Or Array.IndexOf(returnFullQuestList, currentQuest) = 9 Then
            Dim splitdesc = desc.Split(" ") 'get the target from this quest and item needed to pass
            Dim item As String = splitdesc(2)
            Dim target As String = splitdesc(4)
            If Inventory.returnInventoryLength() < 10 Then
                Inventory.addInventory(item)
                LoadBoxes.itemaddition(item, 1) 'give the player the item they need
            End If
        End If
    End Sub

    Public Function checkatTarget(speaker As String) 'is player at a target npc?
        Dim desc = returnCurrentQuestFromCode()
        If desc = "Nothing" Then
            Return False
        End If
        If Array.IndexOf(returnFullQuestList, currentQuest) < 8 Or Array.IndexOf(returnFullQuestList, currentQuest) = 9 Then
            Dim splitdesc = desc.Split(" ")
            Dim item As String = splitdesc(2)
            Dim target As String = splitdesc(4)
            If target = speaker Then
                If doesItemExist(item) Then
                    Inventory.addMoney(getReward(currentQuest))
                    Inventory.removeInventory(item) 'give the item to the npc, remove it from the players inventory and get the reward
                    addToLog() 'adds to log
                    Return True
                End If
            End If
            Return False
        End If
    End Function

    Public Function returnFullQuestList() As Array
        Return IDToQuest.Keys.ToArray()
    End Function

    Public Function checkQuestAssignment(name As String)
        Return QuestAssignment(name)
    End Function

    Public Sub changeMissionText(code As String, newtext As String)
        IDToQuest(code) = newtext
    End Sub
End Module
