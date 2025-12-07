Imports System.Threading
Imports System.Windows.Forms.Design

Public Class MainGame
    Dim player = New Player("", New Point(40, 40)) 'generates a player box as a global variable
    Dim direction As String = ""
    Dim r As Random = New Random() 'random number generator
    Dim paneldebounce As Boolean = False

    Dim gamefilename As String
    Dim gameplayername As String 'declaring variables
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'runs the following when the form is loading
        Me.Size = New Size(1280, 960)
        Me.BackgroundImage = Image.FromFile("D:\old stuff\gameassets\gamebackground.png") 'sets a background
        mainMenu.Location = New Point(0, 0) 'top left point of location for menu is 0,0
        mainMenu.BringToFront() 'brings menu to front
        PlayerTimer.Enabled = False 'player can move
        enableMainGameBoxes(False)
        LoadBoxes.initialise(Me) 'initialise the loadbox module
        Interaction.initialise() 'initialise the interaction module (append all the items)
        Quests.initialise() 'initialise the quest module (set up all the quests)
    End Sub

    ' --------------- MENU CODE

    Private Sub MenuButtonHover(sender As Object, e As EventArgs) Handles newFileBtn.MouseEnter, exitBtn.MouseEnter, loadFileBtn.MouseEnter, createNewFileBtn.MouseEnter, newFileExit.MouseEnter
        sender.Font = New Font("Ink Free", 18, FontStyle.Bold) 'Makes Text Bigger if hovered
    End Sub

    Private Sub MenuButtonExit(sender As Object, e As EventArgs) Handles newFileBtn.MouseLeave, exitBtn.MouseLeave, loadFileBtn.MouseLeave, createNewFileBtn.MouseLeave, newFileExit.MouseLeave
        sender.Font = New Font("Ink Free", 14, FontStyle.Bold) 'Returns Text to normal size once no longer hovered
    End Sub

    Private Sub MenuButtonClick(sender As Object, e As EventArgs) Handles newFileBtn.Click, loadFileBtn.Click, exitBtn.Click
        Select Case sender.Name 'sender refers to the button that got clicked
            Case "newFileBtn"
                mainMenu.Enabled = False
                Me.Controls.Remove(mainMenu) 'removes the menu control so removes the menu from view in form into memory
                Me.Text = "Peaceful Pines | New File" 'sets form text to that
                Me.Controls.Add(newFileGB) 'adds the newfile groupbox from memory into the form controls
                newFileGB.Visible = True
                newFileGB.Enabled = True
                newFileGB.Location = New Point(0, 0) 'sets the newfile group box to fill the form
            Case "loadFileBtn"
                mainMenu.Enabled = False
                Me.Controls.Remove(mainMenu) 'removes the menu control so removes the menu from view in form into memory
                Me.Text = "Peaceful Pines | Load File"
                Me.Controls.Add(loadFilePanel) 'adds the loadfile groupbox from memory into the form controls
                loadFilePanel.Visible = True
                loadFilePanel.Enabled = True
                loadFilePanel.Location = New Point(0, 0)
                Dim dirinfo = New IO.DirectoryInfo("D:/") 'directory to go to
                Dim files As IO.FileInfo() = dirinfo.GetFiles("old stuff\savefiles")
                For Each file In files
                    CheckedListBox1.Items.Add(file.Name) 'makes a list of the current save files
                Next
            Case "exitBtn"
                Me.Close() 'closes the form
        End Select

    End Sub

    Private Sub newFileNameBox_TextChanged(sender As Object, e As EventArgs) Handles newFileNameBox.TextChanged, characterNameBox.TextChanged
        If (System.Text.RegularExpressions.Regex.IsMatch(sender.Text, "^[a-zA-Z0-0]+$")) Then 'if the text is VALID with NO SYMBOLS OR SPACES
            sender.BackColor = Color.LightGreen 'set background as green
        Else
            sender.BackColor = Color.LightCoral 'otherwise set background as red
        End If
    End Sub

    Private Sub NewFileButtonClick(sender As Object, e As EventArgs) Handles createNewFileBtn.Click, newFileExit.Click
        Select Case sender.Name
            Case "createNewFileBtn"
                If (Menu.TextValidate(newFileNameBox.Text)) Then
                    If (Menu.TextValidate(characterNameBox.Text)) Then
                        gamefilename = newFileNameBox.Text 'sets global variable gamefilename as the game file name
                        gameplayername = characterNameBox.Text 'sets global variable gameplayername as the game player name
                        newFileGB.Visible = False
                        newFileGB.Enabled = False
                        Me.Controls.Remove(newFileGB) 'removes the newfile groupbox, moves it to memory away from view
                        MapFile.NewFile(newFileNameBox.Text, characterNameBox.Text) 'makes a new file in MapFile with the filename and playername
                        Dim grids = MapLoad.initialise(newFileNameBox.Text) 'grids are created
                        MapLoad.assignNPCs(grids) 'MapLoad loads the grids and assigns NPCs to the placeholder tiles
                        Upgrades.loadFlowers(grids) 'The flowers are located and stored from the grid
                        Upgrades.assignFlowers() ' ^^^
                        InitialiseMainGame(grids, characterNameBox.Text) 'open the main game
                        '''THE GRID IS AS SHOWN
                        '''0 1 2
                        '''3 4 5
                        '''6 7 8
                        '''The player always spawns on the bottom left grid.
                    End If
                End If
            Case "newFileExit"
                Me.Controls.Remove(newFileGB) 'exit the new file menu
                Me.Controls.Add(mainMenu) 'go back to the original menu
                mainMenu.Enabled = True
        End Select
    End Sub

    Private Sub checkmouseclick(sender As Object, e As EventArgs) Handles CheckedListBox1.MouseClick
        Dim non, sele As Integer
        sele = CheckedListBox1.SelectedIndex() 'this is the selected box index
        For non = 0 To CheckedListBox1.Items.Count - 1 Step 1 'this is iterating through the checkbox
            If non <> sele Then 'if the index of selected item is not the same as the index of selected items
                CheckedListBox1.SetItemChecked(non, False) 'remove old selected items (meaning only one item is selected at all times)
            Else
                CheckedListBox1.SetItemChecked(sele, True) 'make new item selected
            End If
        Next
    End Sub

    Private Sub loadFileButtonClick(sender As Object, e As EventArgs) Handles loadfilebtnmain.Click
        If CheckedListBox1.CheckedItems.Count > 0 Then
            Dim filename As String = CheckedListBox1.CheckedItems(0) 'get the checked list item name
            filename = filename.Replace(".txt", "") 'get the file name without the file extension
            Dim grids = MapLoad.initialise(filename) 'initialise map, pass the filename in so they know what to load
            gamefilename = filename 'set global game file name as the parsed filename
            loadFilePanel.Visible = False
            loadFilePanel.Enabled = False
            Me.Controls.Remove(loadFilePanel) 'remove the panel which loads the file
            MapLoad.assignNPCs(grids) 'assign the NPCs in the map
            Upgrades.loadFlowers(grids) 'load the flowers in the grid and log them into the upgrades module
            Upgrades.assignFlowers()
            InitialiseMainGame(grids, Inventory.returnName()) 'initialise main game
        End If
    End Sub

    Private Sub closeLoadFile(sender As Object, e As EventArgs) Handles LoadBackToMenu.Click
        Me.Controls.Remove(loadFilePanel) 'remove load file panel into memory
        Me.Controls.Add(mainMenu) 'add the main menu panel back
        mainMenu.Enabled = True
    End Sub

    '----------------------------------------------------
    Sub InitialiseMainGame(map As Object, playerName As String)
        Me.Text = "Peaceful Pines | Main Game" 'set form name as main game
        gameplayername = playerName
        WorldTitle.Text = gamefilename 'set the text in the world title label as the file name
        PlayerNameTitle.Text = gameplayername ' set the text in the player title label as the player name
        enableMainGameBoxes(True) 'enable all relevent boxes (money, side buttons such as menu, etc)
        Collisions.Loadmap(map, 6) 'sets the current grid as the 6th grid (bottom left)
        player.setName(playerName) 'set the player name into the class
        Dim currentChunk = getCurrentChunk()
        Me.Controls.Add(currentChunk) 'display the currentchunk to the form, set it in the centre
        currentChunk.Controls.Add(player.getCharacter()) 'inside the current chunk, add the player as a control
        player.getCharacter().BringToFront() 'bring the player to the front of the chunk
        PlayerTimer.Enabled = True 'player time enabled, allows the player to move
    End Sub


    Private Sub PlayerTimer_Tick(sender As Object, e As EventArgs) Handles PlayerTimer.Tick 'for each player timer tick
        player.movePlayer(direction) 'player moves in specified direction
        Dim tempChunk = getCurrentChunk() 'temporary storage of the chunk, in case the player moves to a new one
        Dim returna = checkBounds(player.getCharacter()) 'check if the player is in a new chunk, it will return the chunk if they are
        If returna IsNot "" Then
            Me.Controls.Remove(tempChunk)
            Me.Controls.Add(returna) 'remove the old chunk, set the new one
        End If
        Collisions.checkCollision(player.getCharacter(), direction) 'use the collisions module to check if the player is colliding with an obstacle
        Collisions.isInteractionColliding(player.getCharacter(), Me) 'use the collisions module to check if the player is near an interactable object
    End Sub
    Private Sub keyPressDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        e.SuppressKeyPress = True 'makes it so there isnt a ding sound when pressing keys
        If e.KeyCode = Keys.W Then
            direction = "W" 'up
        End If
        If e.KeyCode = Keys.S Then
            direction = "S" 'down
        End If
        If e.KeyCode = Keys.A Then
            direction = "A" 'left
        End If
        If e.KeyCode = Keys.D Then
            direction = "D" 'right
        End If
        If e.KeyCode = Keys.D1 Then
            Inventory.changeActiveItem(0) 'set active index as 0
        End If
        If e.KeyCode = Keys.D2 Then
            Inventory.changeActiveItem(1) 'set active index as 1
        End If
        If e.KeyCode = Keys.D3 Then
            Inventory.changeActiveItem(2) 'set active index as 2
        End If
        If e.KeyCode = Keys.E Then
            Dim box = Collisions.getCurrentInteractable() 'get the item off the top of the stack of interactables (if the stack isnt empty)
            If box Is Nothing Then
                LoadBoxes.messagepopup("You are not near any interactable!", player.getCharacter()) 'only loads if there is nothing to interact with (stack is empty)
            ElseIf box.BackColor = Color.Yellow And returnActiveItem() = "Watering Can" Then 'this loads the flower upgrade box, explained in the doc
                PlayerTimer.Stop()
                BgTimer.Stop()
                upgradeflowerBtn.Text = "Upgrade"
                Me.Controls.Add(upgradePanel)
                upgradePanel.Location = New Point(326, 155)
                upgradePanel.BringToFront()
                upgradecosttitle.Text = "It will cost " + CStr(getFlowerLevel(box) * 15) + " coins to upgrade"
                upgradecosttitle.Tag = getFlowerLevel(box) * 15
                upgradeleveltitle.Text = "Level: " + CStr(getFlowerLevel(box))
                playerbalancetitle.Text = "Balance: " + CStr(returnBalance()) + " coins"
            ElseIf box.BackColor = Color.Purple And returnitemdebounce = False Then 'this allows the player to interact with trees, explained in the doc
                If returnActiveItem() = "Axe" Then
                    Threading.Thread.Sleep(100)
                    If returnCooldown() = 12 Then
                        LoadBoxes.messagepopup("You've gathered enough! Take a break!", player.getCharacter()) 'if player hits the cooldown, alert the player
                    Else
                        Chop()
                    End If
                Else
                    If returnCooldown() = 12 Then
                        LoadBoxes.messagepopup("You've gathered enough! Take a break!", player.getCharacter())
                    Else
                        Shake()
                    End If
                End If
            ElseIf box.BackColor = Color.Blue And returnActiveItem = "Fishing Rod" And returnitemdebounce = False Then 'this allows the player to fish, explained in the doc
                PlayerTimer.Stop()
                BgTimer.Stop()
                LoadBoxes.messagepopup("Fishing...", player.getCharacter())
                Fish()
                PlayerTimer.Start()
                BgTimer.Start()
            ElseIf box.BackColor = Color.Brown Then 'this allows the player to talk to NPCs, explained in the doc
                If paneldebounce = False Then
                    PlayerTimer.Stop()
                    BgTimer.Stop()
                    paneldebounce = True
                    Dim openDialogue = Interaction.returnDialogue(box.Name).Split("/")(0) 'splits the dialogue into 2, the opening and closing dialogue. this takes the opening dialogue
                    DialoguePanel.Location = New Point(322, 181)
                    Me.Controls.Add(DialoguePanel)
                    SpeakerImage.Image = box.Image
                    NameLabel.Text = box.Name
                    DialoguePanel.BringToFront()
                    If Inventory.doesItemExist("City Keys") Then 'only applies in the endgame
                        TypeWriter("Oh my god... You have the keys to the city??", DialogueTextBox)
                        DialogueBtn1.Text = "Yeah.. I do"
                        DialogueBtn2.Text = "Talk"
                    Else
                        TypeWriter(openDialogue, DialogueTextBox)
                        DialogueBtn1.Text = "Quest"
                        DialogueBtn2.Text = "Talk"
                    End If
                End If
            ElseIf box.BackColor = Color.Red Then
                paneldebounce = True
                PlayerTimer.Stop()

                Dim allitems = getAllItems() 'grabs all available items in the game
                Dim startingpoint As Point = New Point(15, 20)
                For Each item In allitems 'makes a shopbar out of each item
                    Dim shoppanel = New ShopBar(item, startingpoint)
                    InnerShopPanel.Controls.Add(shoppanel.returnPanel())
                    shoppanel.returnPanel().BringToFront()
                    startingpoint = New Point(startingpoint.X, startingpoint.Y + 50)
                Next
                MainShopPanel.Location = New Point(299, 294)
                Me.Controls.Add(MainShopPanel) 'add the shop panel to the form and make it visible
                MainShopPanel.BringToFront()
            ElseIf box.BackColor = Color.Black Then
                paneldebounce = True
                PlayerTimer.Stop()
                BgTimer.Stop()
                Me.Controls.Add(coffeepanel) 'add the coffee shop panel to the form and make it visible
                coffeepanel.Location = New Point(387, 226)
                coffeepanel.BringToFront()
            End If
        End If
        If e.KeyCode = Keys.R Then
            If paneldebounce = False Then
                paneldebounce = True
                PlayerTimer.Stop()
                Me.Text = "Peaceful Pines | Inventory" 'sets the form text to inventory, allowing the user to know they are on the inventory page
                updateInventory()
                Me.Controls.Add(InventoryPanel) 'adds inventory panel to the form
                InventoryPanel.Location = New Point(411, 175)
                InventoryPanel.BringToFront()
            End If
        End If

        If e.KeyCode = Keys.Q Then
            If paneldebounce = False Then
                paneldebounce = True
                Me.Text = "Peaceful Pines | Paused" 'sets the form text to paused, allowing the user to know they are paused
                Me.Controls.Add(GameMenuPanel) 'adds the paused panel to the form
                GameMenuPanel.Location = New Point(451, 276)
                GameMenuPanel.BringToFront()
                PlayerTimer.Enabled = False
                BgTimer.Enabled = False
            End If
        End If

        If e.KeyCode = Keys.T Then
            If paneldebounce = False Then
                paneldebounce = True
                Me.Controls.Add(QuestLogPanel) 'adds the quest log panel to the form, makes it visible
                QuestLogPanel.Location = New Point(322, 174)
                QuestLogPanel.BringToFront()
                PlayerTimer.Enabled = False
                BgTimer.Enabled = False
            End If
        End If
    End Sub
    Dim tooltip As ToolTip = New ToolTip
    Dim diabtndebounce As Boolean = False
    Public Sub hoverInv(sender As Object, e As EventArgs) Handles InvBox8.MouseHover, InvBox7.MouseHover, InvBox6.MouseHover, InvBox5.MouseHover, InvBox4.MouseHover, InvBox3.MouseHover, InvBox2.MouseHover, InvBox1.MouseHover, InvBox10.MouseHover, InvBox9.MouseHover
        If sender.Tag IsNot Nothing Then
            tooltip.RemoveAll()
            tooltip.SetToolTip(sender, "Count: " + CStr(Inventory.itemInstances(sender.Tag))) 'tooltip displays count of item in slot if hovered over
        End If
    End Sub

    Private Sub coffeeButtonHandler(sender As Object, e As EventArgs) Handles exitCoffeeBtn.Click
        coffeepanel.Controls.Remove(exitCoffeeBtn) 'removes and readds the button, otherwise the form focuses on this and the player wont be able to move
        coffeepanel.Controls.Add(exitCoffeeBtn)
        Me.Controls.Remove(coffeepanel)
        paneldebounce = False
        PlayerTimer.Start()
        BgTimer.Start()
    End Sub

    Private Sub shopButtonHandler(sender As Object, e As EventArgs) Handles storeexitbtn.Click
        Select Case sender.Name
            Case storeexitbtn.Name
                MainShopPanel.Controls.Remove(storeexitbtn)
                MainShopPanel.Controls.Add(storeexitbtn) 'removes and readds the button, otherwise the form focuses on this and the player wont be able to move
                InnerShopPanel.Controls.Clear()
                Me.Controls.Remove(MainShopPanel)
                paneldebounce = False
                PlayerTimer.Start()
        End Select
    End Sub

    Private Sub questButtonHandler(sender As Object, e As EventArgs) Handles exitLogbtn.Click
        QuestLogPanel.Controls.Remove(exitLogbtn)
        QuestLogPanel.Controls.Add(exitLogbtn) 'removes and readds the button, otherwise the form focuses on this and the player wont be able to move
        Me.Controls.Remove(QuestLogPanel)
        paneldebounce = False
        PlayerTimer.Start()
        BgTimer.Start()
    End Sub

    Private Sub dialogueButtonHandler(sender As Object, e As EventArgs) Handles DialogueBtn2.Click, DialogueBtn1.Click
        If diabtndebounce = False Then
            diabtndebounce = True
            Select Case sender.Text
                Case "Quest" 'if the dialogue button clicked was the quest button
                    Dim istrue = checkatTarget(NameLabel.Text)

                    If returnCurrentQuest() = "Q009" Then 'explained in the document
                        Dim splittext = returnCurrentQuestFromCode().Split(" ")
                        Dim amount As Integer = CInt(splittext(1))
                        If amount = 0 Then
                            TypeWriter("Hey, you got all the signatures!", DialogueTextBox)
                            Inventory.addMoney(getReward(returnCurrentQuest()))
                            addToLog()
                            DialogueBtn1.Text = "Exit"
                            DialogueBtn2.Text = "Exit"
                            Exit Select
                        End If

                        TypeWriter("You can have my signature!", DialogueTextBox) 'explained in the document
                        amount -= 1
                        splittext(1) = CStr(amount)
                        changeMissionText(returnCurrentQuest(), splittext(0) + " " + splittext(1) + " " + splittext(2))
                        DialogueBtn1.Text = "Exit"
                        DialogueBtn2.Text = "Exit"
                        Exit Select
                    End If

                    If returnCurrentQuest() = "Q011" And Quests.checkQuestAssignment(NameLabel.Text).Contains(returnCurrentQuest()) Then 'explained in the document
                        If Inventory.doesItemExist("Apple") Then
                            If Inventory.itemInstances("Apple") >= 6 Then
                                For n = 1 To 6 Step 1
                                    Inventory.removeInventory("Apple")
                                Next
                                TypeWriter("Thanks for the apples man, much appreciated!", DialogueTextBox)
                                Inventory.addMoney(getReward(returnCurrentQuest()))
                                addToLog()
                                DialogueBtn1.Text = "Exit"
                                DialogueBtn2.Text = "Exit"
                                Exit Select
                            End If
                        End If
                    ElseIf returnCurrentQuest() = "Q012" And Quests.checkQuestAssignment(NameLabel.Text).Contains(returnCurrentQuest()) Then 'explained in the document
                        If Inventory.doesItemExist("Wood") Then
                            If Inventory.itemInstances("Wood") >= 8 Then
                                For n = 1 To 8 Step 1
                                    Inventory.removeInventory("Wood")
                                Next
                                TypeWriter("Thanks for the wood man, you the best fr!", DialogueTextBox)
                                Inventory.addMoney(getReward(returnCurrentQuest()))
                                addToLog()
                                DialogueBtn1.Text = "Exit"
                                DialogueBtn2.Text = "Exit"
                                Exit Select
                            End If
                        End If
                    ElseIf returnCurrentQuest() = "Q013" And Quests.checkQuestAssignment(NameLabel.Text).Contains(returnCurrentQuest()) Then 'explained in the document
                        If Inventory.doesItemExist("Fish") Then
                            If Inventory.itemInstances("Fish") >= 6 Then
                                For n = 1 To 6 Step 1
                                    Inventory.removeInventory("Fish")
                                Next
                                TypeWriter("Thanks for the fish, I really needed this!", DialogueTextBox)
                                Inventory.addMoney(getReward(returnCurrentQuest()))
                                addToLog()
                                DialogueBtn1.Text = "Exit"
                                DialogueBtn2.Text = "Exit"
                                Exit Select
                            End If
                        End If
                    ElseIf returnCurrentQuest() = "Q014" And Quests.checkQuestAssignment(NameLabel.Text).Contains(returnCurrentQuest()) Then 'explained in the document
                        If Inventory.doesItemExist("Box of coffee") Then
                            If Inventory.itemInstances("Box of coffee") >= 1 Then
                                Inventory.removeInventory("Box of coffee")
                                TypeWriter("Thanks for the coffee, u so cool brah", DialogueTextBox)
                                Inventory.addMoney(getReward(returnCurrentQuest()))
                                addToLog()
                                DialogueBtn1.Text = "Exit"
                                DialogueBtn2.Text = "Exit"
                                Exit Select
                            End If
                        End If
                    ElseIf returnCurrentQuest() = "Q015" And Quests.checkQuestAssignment(NameLabel.Text).Contains(returnCurrentQuest()) Then 'explained in the document
                        If NameLabel.Text = "Sam" Then
                            TypeWriter("Here, a little parting gift of 500 coins. Use it wisely.", DialogueTextBox)
                            Inventory.addMoney(getReward(returnCurrentQuest()))
                            addToLog()
                        End If
                    End If


                    If istrue = True Then 'if the npc is a target of a quest
                        Dim closeDialogue = Interaction.returnDialogue(NameLabel.Text).Split("/")(1)
                        TypeWriter(closeDialogue, DialogueTextBox) 'give the player the closing dialogue
                        DialogueBtn1.Text = "Exit"
                        DialogueBtn2.Text = "Exit"
                        Exit Select
                    End If
                    If returnCurrentQuestFromCode() = "Nothing" Then
                        If returnQuestLogLength() = 15 Then 'this only occurs if the player has finished all the quests
                            TypeWriter("You've completed all the quests bruh. Try upgrading all your flowers and then checking the shop out", DialogueTextBox)
                            DialogueBtn1.Text = "Exit"
                            DialogueBtn2.Text = "Exit"
                        End If
                        If checkQuestAssignment(NameLabel.Text).Contains(returnFullQuestList()(returnQuestLogLength())) Then
                            TypeWriter(Quests.returnDialogue(returnFullQuestList()(returnQuestLogLength())), DialogueTextBox)
                            DialogueBtn1.Text = "Sure"
                            DialogueBtn2.Text = "No Thanks"
                        Else
                            TypeWriter("Sorry man, I aint got any quests for you", DialogueTextBox) 'this happens if this npc does not have the next quest in the order
                            DialogueBtn1.Text = "Exit"
                            DialogueBtn2.Text = "Exit"
                        End If
                    Else
                        TypeWriter("You already have an active quest! Go finish that first!", DialogueTextBox) 'this happens if the player already has a quest
                        DialogueBtn1.Text = "Exit"
                        DialogueBtn2.Text = "Exit"
                    End If
                Case "Talk"
                    TypeWriter(returnRandomDialogue, DialogueTextBox) 'happens if player just wants to talk
                    DialogueBtn1.Text = "Exit"
                    DialogueBtn2.Text = "Exit"
                Case "Sure"
                    Dim closeDialogue = Interaction.returnDialogue(NameLabel.Text).Split("/")(1) 'give the player the closing dialogue
                    assignQuest()
                    TypeWriter(closeDialogue, DialogueTextBox)
                    DialogueBtn1.Text = "Exit"
                    DialogueBtn2.Text = "Exit"
                Case "No Thanks"
                    TypeWriter("Okay. Well im always here if you need me.", DialogueTextBox) 'says this if the player does not want to take on the quest
                    DialogueBtn1.Text = "Exit"
                    DialogueBtn2.Text = "Exit"
                Case "Exit"
                    DialoguePanel.Controls.Remove(DialogueBtn1)
                    DialoguePanel.Controls.Remove(DialogueBtn2)
                    DialoguePanel.Controls.Add(DialogueBtn1)
                    DialoguePanel.Controls.Add(DialogueBtn2) 'removes and readds the button, otherwise the form focuses on this and the player wont be able to move
                    Me.Controls.Remove(DialoguePanel)
                    PlayerTimer.Start()
                    BgTimer.Start()
                    paneldebounce = False
                Case "Yeah.. I do"
                    TypeWriter("You know that means you've completed the game right? There's nothing else for you to do now other than walk around and get more money. At this point, start a new game.", DialogueTextBox)
                    DialogueBtn1.Text = "Exit" 'game is over
                    DialogueBtn2.Text = "Exit"
            End Select
            diabtndebounce = False
        End If
    End Sub

    Private Sub sideButtonHandler(sender As Object, e As EventArgs) Handles openMenuButton.Click, openInventoryButton.Click, openQuestLogBtn.Click
        Select Case sender.Name
            Case openMenuButton.Name 'if the button is the menu button
                If paneldebounce = False Then
                    paneldebounce = True 'panel debounce prevents multiple panels being opened at once by providing a boolean value when a panel is already open
                    Me.Text = "Peaceful Pines | Paused"
                    Me.Controls.Add(GameMenuPanel) 'removes the game menu panel
                    GameMenuPanel.Location = New Point(451, 276)
                    GameMenuPanel.BringToFront()
                    PlayerTimer.Enabled = False
                    BgTimer.Enabled = False
                End If
            Case openInventoryButton.Name 'if the button is the inventory button
                If paneldebounce = False Then
                    paneldebounce = True
                    Me.Text = "Peaceful Pines | Inventory"
                    PlayerTimer.Stop()
                    updateInventory()
                    Me.Controls.Add(InventoryPanel)
                    InventoryPanel.Location = New Point(411, 175)
                    InventoryPanel.BringToFront()
                End If
            Case openQuestLogBtn.Name 'if the button is the quest log button
                If paneldebounce = False Then
                    paneldebounce = True
                    Me.Controls.Add(QuestLogPanel)
                    QuestLogPanel.Location = New Point(322, 174)
                    QuestLogPanel.BringToFront()
                    PlayerTimer.Enabled = False
                    BgTimer.Enabled = False
                End If
        End Select
    End Sub

    Private Sub inventoryButtonHandler(sender As Object, e As EventArgs) Handles exitInvBtn.Click
        Select Case sender.Name
            Case exitInvBtn.Name 'exit inventory
                PlayerTimer.Start()
                InventoryPanel.Controls.Remove(exitInvBtn)
                InventoryPanel.Controls.Add(exitInvBtn)
                Me.Controls.Remove(InventoryPanel)
                paneldebounce = False
                Me.Text = "Peaceful Pines | Main Game"
        End Select
    End Sub

    Private Sub menuButtonHandler(sender As Object, e As EventArgs) Handles exitMenubtn.Click, saveGameBtn.Click, resumeGameBtn.Click
        Select Case sender.Name
            Case "resumeGameBtn" 'exit menu, resume game
                GameMenuPanel.Controls.Remove(resumeGameBtn)
                GameMenuPanel.Controls.Add(resumeGameBtn) 'removes and readds the button, otherwise the form focuses on this and the player wont be able to move
                Me.Controls.Remove(GameMenuPanel)
                GameMenuPanel.Location = New Point(2000, 1200)
                Me.Text = "Peaceful Pines | Main Game"
                PlayerTimer.Enabled = True
                BgTimer.Enabled = True
                paneldebounce = False
                saveGameBtn.Text = "Save"
            Case "saveGameBtn" 'saves the game, calls upon multiple modules to return parsable save file text
                MapFile.writeFile(MapLoad.returnMapText, gamefilename, gameplayername, Quests.returnCurrentQuest(), Quests.returnQuestLog(), CStr(Inventory.returnBalance), Inventory.returnInventory(), Upgrades.returnFlowers())
                sender.Text = "Saved"
            Case "exitMenubtn" 'closes the game
                Me.Close()
        End Select
    End Sub

    Private Sub upgradePanelButtonHandler(sender As Object, e As EventArgs) Handles exitupgbtn.Click, upgradeflowerBtn.Click
        Select Case sender.name
            Case "exitupgbtn" 'exits the upgrade panel
                upgradePanel.Controls.Remove(exitupgbtn)
                upgradePanel.Controls.Add(exitupgbtn)
                Me.Controls.Remove(upgradePanel)
                PlayerTimer.Start()
                BgTimer.Start()
            Case "upgradeflowerBtn" 'upgrades the flower, explained in the document
                If returnBalance() - CInt(upgradecosttitle.Tag) < 0 Then
                    upgradeflowerBtn.Text = "Not enough money!"
                Else
                    If (getFlowerLevel(Collisions.getCurrentInteractable()) < 15) Then
                        Inventory.subtractMoney(CInt(upgradecosttitle.Tag))
                        Upgrades.updateFlowerLevel(Collisions.getCurrentInteractable()) 'resets the text labels with new values after upgrade
                        upgradecosttitle.Text = "It will cost " + CStr(getFlowerLevel(Collisions.getCurrentInteractable()) * 15) + " coins to upgrade"
                        upgradeleveltitle.Text = "Level: " + CStr(getFlowerLevel(Collisions.getCurrentInteractable()))
                        playerbalancetitle.Text = "Balance: " + CStr(Inventory.returnBalance) + " coins"
                        upgradecosttitle.Tag = getFlowerLevel(Collisions.getCurrentInteractable()) * 15
                    End If
                End If
        End Select
    End Sub

    Private Sub keyPressUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp 'when a key is let go of, reset the direction assuming that its a wasd key
        If e.KeyCode = Keys.W And direction = "W" Then
            direction = ""
        End If
        If e.KeyCode = Keys.S And direction = "S" Then
            direction = ""
        End If
        If e.KeyCode = Keys.A And direction = "A" Then
            direction = ""
        End If
        If e.KeyCode = Keys.D And direction = "D" Then
            direction = ""
        End If
    End Sub

    Sub enableMainGameBoxes(val As Boolean)
        If val = False Then 'remove all relevant boxes from the form at the start of the game
            Me.Controls.Remove(ActiveBarBox)
            Me.Controls.Remove(InfoPanel)
            Me.Controls.Remove(QuestLogPanel)
            Me.Controls.Remove(ActiveQuestPanel)
            Me.Controls.Remove(sideButtons)
            Me.Controls.Remove(upgradePanel)
            Me.Controls.Remove(GameMenuPanel)
            Me.Controls.Remove(mainmoneyLabel)
            Me.Controls.Remove(InventoryPanel)
            Me.Controls.Remove(DialoguePanel)
            Me.Controls.Remove(MainShopPanel)
            Me.Controls.Remove(coffeepanel)
            Me.Controls.Remove(newFileGB)
            Me.Controls.Remove(loadFilePanel)
        ElseIf val = True Then 'add all relevant MAIN GAME boxes
            Me.Controls.Add(ActiveBarBox)
            Me.Controls.Add(InfoPanel)
            Me.Controls.Add(ActiveQuestPanel)
            Me.Controls.Add(sideButtons)
            Me.Controls.Add(mainmoneyLabel)
        End If
    End Sub


    Private Sub BgTimer_Tick(sender As Object, e As EventArgs) Handles BgTimer.Tick
        Application.DoEvents()
        mainmoneyLabel.Text = "Money: " + CStr(Inventory.returnBalance()) + " coins" 'updates the following labels per tick
        multipliertext.Text = "x" + CStr(Upgrades.getMultiplier()) + " coins"
        moneyLbl.Text = "Money: " + CStr(Inventory.returnBalance()) + " coins"
        questdescriptiontext.Text = Quests.returnCurrentQuestFromCode()
        If r.Next(1, 1000000) > 9999850 Then 'chance to reduce cooldown, runs 25 times a second so this chance needs to be high
            reducecooldown()
        End If
        If returnQuestLogLength() > 0 Then
            Dim questsa = returnQuestLog().Split(",")
            Dim finalresult As String = ""
            For Each quest In questsa
                finalresult += Quests.returnDialogue(quest) + vbCrLf
            Next
            QuestLogBox.Text = finalresult
        End If
        updateActiveBar() 'updates the active bar if new item selected
    End Sub

    Private Sub updateActiveBar()
        Sl1.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        Sl2.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        Sl3.Font = New Font("Segoe UI", 8, FontStyle.Regular)
        ActiveSlot1.Image = Image.FromFile("D:\old stuff\gameassets\Axe.png")
        ActiveSlot2.Image = Image.FromFile("D:\old stuff\gameassets\Watering Can.png")
        ActiveSlot3.Image = Image.FromFile("D:\old stuff\gameassets\Fishing Rod.png")
        If returnActiveItem() = "Axe" Then 'if active item is axe set axe as active box
            Sl1.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        ElseIf returnActiveItem() = "Watering Can" Then 'if active item is can set can as active box
            Sl2.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        ElseIf returnActiveItem() = "Fishing Rod" Then 'if active item is fishing rod set fishing rod as active box
            Sl3.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        End If
    End Sub

    Private Sub updateInventory()
        Dim arrayofboxes As List(Of PictureBox) = New List(Of PictureBox)
        For Each box In InventoryPanel.Controls 'for every box within the inventory panel
            If box.Name.Contains("InvBox") Then
                arrayofboxes.Add(box) 'add the box to an array of inventory boxes to display items
            End If
        Next
        Inventory.newBoxes(arrayofboxes) 'assign to inventory module
    End Sub
End Class
