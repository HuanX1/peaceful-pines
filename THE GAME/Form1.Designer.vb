<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainGame))
        mainMenu = New GroupBox()
        menuTitle = New TextBox()
        PictureBox1 = New PictureBox()
        exitBtn = New Button()
        loadFileBtn = New Button()
        newFileBtn = New Button()
        newFileGB = New GroupBox()
        newFileExit = New Button()
        newFileLabel2 = New Label()
        characterNameBox = New TextBox()
        newfileRules = New TextBox()
        Label1 = New Label()
        newFileNameBox = New TextBox()
        createNewFileBtn = New Button()
        PlayerTimer = New Timer(components)
        InventoryPanel = New Panel()
        InvBox10 = New PictureBox()
        InvBox9 = New PictureBox()
        exitInvBtn = New Button()
        moneyLbl = New Label()
        Label2 = New Label()
        InvBox8 = New PictureBox()
        InvBox7 = New PictureBox()
        InvBox6 = New PictureBox()
        InvBox5 = New PictureBox()
        InvBox4 = New PictureBox()
        InvBox3 = New PictureBox()
        InvBox2 = New PictureBox()
        InvBox1 = New PictureBox()
        QuestLogBox = New TextBox()
        ActiveBarBox = New Panel()
        Sl3 = New Label()
        Sl2 = New Label()
        Sl1 = New Label()
        ActiveSlot3 = New PictureBox()
        ActiveSlot2 = New PictureBox()
        ActiveSlot1 = New PictureBox()
        InfoPanel = New Panel()
        PlayerNameTitle = New Label()
        WorldTitle = New Label()
        QuestLogPanel = New Panel()
        exitLogbtn = New Button()
        Label3 = New Label()
        Label4 = New Label()
        ActiveQuestPanel = New Panel()
        questdescriptiontext = New Label()
        openMenuButton = New Button()
        sideButtons = New Panel()
        openQuestLogBtn = New Button()
        multipliertext = New Label()
        multipliertitle = New Label()
        TextBox1 = New TextBox()
        controlshelptitle = New Label()
        openInventoryButton = New Button()
        upgradePanel = New Panel()
        playerbalancetitle = New Label()
        upgradecosttitle = New Label()
        upgradeleveltitle = New Label()
        upgradetitle = New Label()
        exitupgbtn = New Button()
        upgradeflowerBtn = New Button()
        mainmoneyLabel = New Label()
        BgTimer = New Timer(components)
        GameMenuPanel = New Panel()
        exitMenubtn = New Button()
        saveGameBtn = New Button()
        resumeGameBtn = New Button()
        DialoguePanel = New Panel()
        DialogueBtn2 = New Button()
        DialogueBtn1 = New Button()
        NameLabel = New Label()
        DialogueTextBox = New TextBox()
        SpeakerImage = New PictureBox()
        MainShopPanel = New Panel()
        storeexitbtn = New Button()
        coffeepanel = New Panel()
        exitCoffeeBtn = New Button()
        StoreInfoLabel = New Label()
        InnerShopPanel = New Panel()
        loadFilePanel = New GroupBox()
        LoadBackToMenu = New Button()
        CheckedListBox1 = New CheckedListBox()
        loadfiletitle = New Label()
        loadfilebtnmain = New Button()
        mainMenu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        newFileGB.SuspendLayout()
        InventoryPanel.SuspendLayout()
        CType(InvBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(InvBox1, ComponentModel.ISupportInitialize).BeginInit()
        ActiveBarBox.SuspendLayout()
        CType(ActiveSlot3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ActiveSlot2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ActiveSlot1, ComponentModel.ISupportInitialize).BeginInit()
        InfoPanel.SuspendLayout()
        QuestLogPanel.SuspendLayout()
        ActiveQuestPanel.SuspendLayout()
        sideButtons.SuspendLayout()
        upgradePanel.SuspendLayout()
        GameMenuPanel.SuspendLayout()
        DialoguePanel.SuspendLayout()
        CType(SpeakerImage, ComponentModel.ISupportInitialize).BeginInit()
        MainShopPanel.SuspendLayout()
        coffeepanel.SuspendLayout()
        loadFilePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainMenu
        ' 
        mainMenu.BackColor = SystemColors.ControlLight
        mainMenu.Controls.Add(menuTitle)
        mainMenu.Controls.Add(PictureBox1)
        mainMenu.Controls.Add(exitBtn)
        mainMenu.Controls.Add(loadFileBtn)
        mainMenu.Controls.Add(newFileBtn)
        mainMenu.Location = New Point(1631, 815)
        mainMenu.Name = "mainMenu"
        mainMenu.Padding = New Padding(0)
        mainMenu.Size = New Size(1280, 960)
        mainMenu.TabIndex = 0
        mainMenu.TabStop = False
        ' 
        ' menuTitle
        ' 
        menuTitle.BackColor = SystemColors.ControlLight
        menuTitle.BorderStyle = BorderStyle.None
        menuTitle.Font = New Font("Ink Free", 32F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        menuTitle.Location = New Point(417, 205)
        menuTitle.Multiline = True
        menuTitle.Name = "menuTitle"
        menuTitle.Size = New Size(496, 52)
        menuTitle.TabIndex = 7
        menuTitle.Text = "PEACEFUL PINES"
        menuTitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(417, 290)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(496, 336)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' exitBtn
        ' 
        exitBtn.BackColor = Color.Transparent
        exitBtn.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        exitBtn.Location = New Point(928, 764)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(255, 98)
        exitBtn.TabIndex = 4
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = False
        ' 
        ' loadFileBtn
        ' 
        loadFileBtn.BackColor = Color.Transparent
        loadFileBtn.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        loadFileBtn.Location = New Point(526, 764)
        loadFileBtn.Name = "loadFileBtn"
        loadFileBtn.Size = New Size(255, 98)
        loadFileBtn.TabIndex = 3
        loadFileBtn.Text = "Load File"
        loadFileBtn.UseVisualStyleBackColor = False
        ' 
        ' newFileBtn
        ' 
        newFileBtn.BackColor = Color.Transparent
        newFileBtn.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        newFileBtn.Location = New Point(121, 764)
        newFileBtn.Name = "newFileBtn"
        newFileBtn.Size = New Size(255, 98)
        newFileBtn.TabIndex = 2
        newFileBtn.Text = "New File"
        newFileBtn.UseVisualStyleBackColor = False
        ' 
        ' newFileGB
        ' 
        newFileGB.BackColor = SystemColors.ControlLight
        newFileGB.BackgroundImage = My.Resources.Resources.newfilebg
        newFileGB.Controls.Add(newFileExit)
        newFileGB.Controls.Add(newFileLabel2)
        newFileGB.Controls.Add(characterNameBox)
        newFileGB.Controls.Add(newfileRules)
        newFileGB.Controls.Add(Label1)
        newFileGB.Controls.Add(newFileNameBox)
        newFileGB.Controls.Add(createNewFileBtn)
        newFileGB.Enabled = False
        newFileGB.Location = New Point(798, 1281)
        newFileGB.Name = "newFileGB"
        newFileGB.Size = New Size(1280, 960)
        newFileGB.TabIndex = 8
        newFileGB.TabStop = False
        newFileGB.Text = "New File"
        newFileGB.Visible = False
        ' 
        ' newFileExit
        ' 
        newFileExit.BackColor = Color.Transparent
        newFileExit.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        newFileExit.Location = New Point(680, 427)
        newFileExit.Name = "newFileExit"
        newFileExit.Size = New Size(255, 98)
        newFileExit.TabIndex = 9
        newFileExit.Text = "Return to Menu"
        newFileExit.UseVisualStyleBackColor = False
        ' 
        ' newFileLabel2
        ' 
        newFileLabel2.AutoSize = True
        newFileLabel2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        newFileLabel2.Location = New Point(382, 302)
        newFileLabel2.Name = "newFileLabel2"
        newFileLabel2.Size = New Size(163, 23)
        newFileLabel2.TabIndex = 8
        newFileLabel2.Text = "Character Name"
        newFileLabel2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' characterNameBox
        ' 
        characterNameBox.BackColor = SystemColors.Info
        characterNameBox.BorderStyle = BorderStyle.FixedSingle
        characterNameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        characterNameBox.Location = New Point(382, 328)
        characterNameBox.MaxLength = 16
        characterNameBox.Name = "characterNameBox"
        characterNameBox.PlaceholderText = "Character Name Here"
        characterNameBox.Size = New Size(410, 29)
        characterNameBox.TabIndex = 7
        ' 
        ' newfileRules
        ' 
        newfileRules.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        newfileRules.BorderStyle = BorderStyle.None
        newfileRules.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        newfileRules.Location = New Point(841, 225)
        newfileRules.Multiline = True
        newfileRules.Name = "newfileRules"
        newfileRules.ReadOnly = True
        newfileRules.Size = New Size(392, 132)
        newfileRules.TabIndex = 6
        newfileRules.Text = "ALPHANUMERIC CHARACTERS ONLY" & vbCrLf & "NO SPACES" & vbCrLf & "NO SYMBOLS" & vbCrLf & "GREEN MEANS IT WILL BE ACCEPTED" & vbCrLf & "RED MEANS IT WILL NOT BE ACCEPTED" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(382, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 23)
        Label1.TabIndex = 5
        Label1.Text = "New File Name"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' newFileNameBox
        ' 
        newFileNameBox.BackColor = SystemColors.Info
        newFileNameBox.BorderStyle = BorderStyle.FixedSingle
        newFileNameBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        newFileNameBox.Location = New Point(382, 232)
        newFileNameBox.MaxLength = 32
        newFileNameBox.Name = "newFileNameBox"
        newFileNameBox.PlaceholderText = "File Name Here"
        newFileNameBox.Size = New Size(410, 29)
        newFileNameBox.TabIndex = 4
        ' 
        ' createNewFileBtn
        ' 
        createNewFileBtn.BackColor = Color.Transparent
        createNewFileBtn.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        createNewFileBtn.Location = New Point(382, 427)
        createNewFileBtn.Name = "createNewFileBtn"
        createNewFileBtn.Size = New Size(255, 98)
        createNewFileBtn.TabIndex = 3
        createNewFileBtn.Text = "New File"
        createNewFileBtn.UseVisualStyleBackColor = False
        ' 
        ' PlayerTimer
        ' 
        PlayerTimer.Enabled = True
        PlayerTimer.Interval = 20
        ' 
        ' InventoryPanel
        ' 
        InventoryPanel.BackColor = SystemColors.GradientInactiveCaption
        InventoryPanel.Controls.Add(InvBox10)
        InventoryPanel.Controls.Add(InvBox9)
        InventoryPanel.Controls.Add(exitInvBtn)
        InventoryPanel.Controls.Add(moneyLbl)
        InventoryPanel.Controls.Add(Label2)
        InventoryPanel.Controls.Add(InvBox8)
        InventoryPanel.Controls.Add(InvBox7)
        InventoryPanel.Controls.Add(InvBox6)
        InventoryPanel.Controls.Add(InvBox5)
        InventoryPanel.Controls.Add(InvBox4)
        InventoryPanel.Controls.Add(InvBox3)
        InventoryPanel.Controls.Add(InvBox2)
        InventoryPanel.Controls.Add(InvBox1)
        InventoryPanel.Location = New Point(1284, 131)
        InventoryPanel.Margin = New Padding(3, 2, 3, 2)
        InventoryPanel.Name = "InventoryPanel"
        InventoryPanel.Size = New Size(475, 248)
        InventoryPanel.TabIndex = 11
        ' 
        ' InvBox10
        ' 
        InvBox10.BackColor = SystemColors.AppWorkspace
        InvBox10.Location = New Point(332, 169)
        InvBox10.Margin = New Padding(3, 2, 3, 2)
        InvBox10.Name = "InvBox10"
        InvBox10.Size = New Size(48, 48)
        InvBox10.TabIndex = 17
        InvBox10.TabStop = False
        ' 
        ' InvBox9
        ' 
        InvBox9.BackColor = SystemColors.AppWorkspace
        InvBox9.Location = New Point(332, 95)
        InvBox9.Margin = New Padding(3, 2, 3, 2)
        InvBox9.Name = "InvBox9"
        InvBox9.Size = New Size(48, 48)
        InvBox9.TabIndex = 16
        InvBox9.TabStop = False
        ' 
        ' exitInvBtn
        ' 
        exitInvBtn.Location = New Point(390, 14)
        exitInvBtn.Name = "exitInvBtn"
        exitInvBtn.Size = New Size(75, 23)
        exitInvBtn.TabIndex = 15
        exitInvBtn.Text = "Exit"
        exitInvBtn.UseVisualStyleBackColor = True
        ' 
        ' moneyLbl
        ' 
        moneyLbl.AutoSize = True
        moneyLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        moneyLbl.Location = New Point(20, 47)
        moneyLbl.Name = "moneyLbl"
        moneyLbl.Size = New Size(114, 21)
        moneyLbl.TabIndex = 9
        moneyLbl.Text = "Money: 0 coins"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Berlin Sans FB", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 33)
        Label2.TabIndex = 8
        Label2.Text = "INVENTORY"
        ' 
        ' InvBox8
        ' 
        InvBox8.BackColor = SystemColors.AppWorkspace
        InvBox8.Location = New Point(259, 169)
        InvBox8.Margin = New Padding(3, 2, 3, 2)
        InvBox8.Name = "InvBox8"
        InvBox8.Size = New Size(48, 48)
        InvBox8.TabIndex = 7
        InvBox8.TabStop = False
        ' 
        ' InvBox7
        ' 
        InvBox7.BackColor = SystemColors.AppWorkspace
        InvBox7.Location = New Point(181, 169)
        InvBox7.Margin = New Padding(3, 2, 3, 2)
        InvBox7.Name = "InvBox7"
        InvBox7.Size = New Size(48, 48)
        InvBox7.TabIndex = 6
        InvBox7.TabStop = False
        ' 
        ' InvBox6
        ' 
        InvBox6.BackColor = SystemColors.AppWorkspace
        InvBox6.Location = New Point(99, 169)
        InvBox6.Margin = New Padding(3, 2, 3, 2)
        InvBox6.Name = "InvBox6"
        InvBox6.Size = New Size(48, 48)
        InvBox6.TabIndex = 5
        InvBox6.TabStop = False
        ' 
        ' InvBox5
        ' 
        InvBox5.BackColor = SystemColors.AppWorkspace
        InvBox5.Location = New Point(20, 169)
        InvBox5.Margin = New Padding(3, 2, 3, 2)
        InvBox5.Name = "InvBox5"
        InvBox5.Size = New Size(48, 48)
        InvBox5.TabIndex = 4
        InvBox5.TabStop = False
        ' 
        ' InvBox4
        ' 
        InvBox4.BackColor = SystemColors.AppWorkspace
        InvBox4.Location = New Point(259, 95)
        InvBox4.Margin = New Padding(3, 2, 3, 2)
        InvBox4.Name = "InvBox4"
        InvBox4.Size = New Size(48, 48)
        InvBox4.TabIndex = 3
        InvBox4.TabStop = False
        ' 
        ' InvBox3
        ' 
        InvBox3.BackColor = SystemColors.AppWorkspace
        InvBox3.Location = New Point(181, 95)
        InvBox3.Margin = New Padding(3, 2, 3, 2)
        InvBox3.Name = "InvBox3"
        InvBox3.Size = New Size(48, 48)
        InvBox3.TabIndex = 2
        InvBox3.TabStop = False
        ' 
        ' InvBox2
        ' 
        InvBox2.BackColor = SystemColors.AppWorkspace
        InvBox2.Location = New Point(99, 95)
        InvBox2.Margin = New Padding(3, 2, 3, 2)
        InvBox2.Name = "InvBox2"
        InvBox2.Size = New Size(48, 48)
        InvBox2.TabIndex = 1
        InvBox2.TabStop = False
        ' 
        ' InvBox1
        ' 
        InvBox1.BackColor = SystemColors.AppWorkspace
        InvBox1.Location = New Point(20, 95)
        InvBox1.Margin = New Padding(3, 2, 3, 2)
        InvBox1.Name = "InvBox1"
        InvBox1.Size = New Size(48, 48)
        InvBox1.TabIndex = 0
        InvBox1.TabStop = False
        ' 
        ' QuestLogBox
        ' 
        QuestLogBox.Enabled = False
        QuestLogBox.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        QuestLogBox.Location = New Point(13, 35)
        QuestLogBox.Margin = New Padding(3, 2, 3, 2)
        QuestLogBox.Multiline = True
        QuestLogBox.Name = "QuestLogBox"
        QuestLogBox.ReadOnly = True
        QuestLogBox.ScrollBars = ScrollBars.Vertical
        QuestLogBox.Size = New Size(568, 280)
        QuestLogBox.TabIndex = 0
        QuestLogBox.TabStop = False
        QuestLogBox.Text = "Empty"
        ' 
        ' ActiveBarBox
        ' 
        ActiveBarBox.BackColor = SystemColors.ActiveCaption
        ActiveBarBox.BackgroundImage = CType(resources.GetObject("ActiveBarBox.BackgroundImage"), Image)
        ActiveBarBox.Controls.Add(Sl3)
        ActiveBarBox.Controls.Add(Sl2)
        ActiveBarBox.Controls.Add(Sl1)
        ActiveBarBox.Controls.Add(ActiveSlot3)
        ActiveBarBox.Controls.Add(ActiveSlot2)
        ActiveBarBox.Controls.Add(ActiveSlot1)
        ActiveBarBox.Location = New Point(280, 12)
        ActiveBarBox.Name = "ActiveBarBox"
        ActiveBarBox.Size = New Size(348, 102)
        ActiveBarBox.TabIndex = 13
        ' 
        ' Sl3
        ' 
        Sl3.AutoSize = True
        Sl3.BackColor = Color.Transparent
        Sl3.Location = New Point(252, 12)
        Sl3.Name = "Sl3"
        Sl3.Size = New Size(36, 15)
        Sl3.TabIndex = 5
        Sl3.Text = "Slot 3"
        ' 
        ' Sl2
        ' 
        Sl2.AutoSize = True
        Sl2.BackColor = Color.Transparent
        Sl2.Location = New Point(156, 12)
        Sl2.Name = "Sl2"
        Sl2.Size = New Size(36, 15)
        Sl2.TabIndex = 4
        Sl2.Text = "Slot 2"
        ' 
        ' Sl1
        ' 
        Sl1.AutoSize = True
        Sl1.BackColor = Color.Transparent
        Sl1.Location = New Point(57, 12)
        Sl1.Name = "Sl1"
        Sl1.Size = New Size(36, 15)
        Sl1.TabIndex = 3
        Sl1.Text = "Slot 1"
        ' 
        ' ActiveSlot3
        ' 
        ActiveSlot3.BackColor = SystemColors.ButtonHighlight
        ActiveSlot3.Location = New Point(242, 30)
        ActiveSlot3.Name = "ActiveSlot3"
        ActiveSlot3.Size = New Size(60, 60)
        ActiveSlot3.TabIndex = 2
        ActiveSlot3.TabStop = False
        ' 
        ' ActiveSlot2
        ' 
        ActiveSlot2.BackColor = SystemColors.ButtonHighlight
        ActiveSlot2.Location = New Point(143, 30)
        ActiveSlot2.Name = "ActiveSlot2"
        ActiveSlot2.Size = New Size(60, 60)
        ActiveSlot2.TabIndex = 1
        ActiveSlot2.TabStop = False
        ' 
        ' ActiveSlot1
        ' 
        ActiveSlot1.BackColor = SystemColors.ButtonHighlight
        ActiveSlot1.Location = New Point(46, 30)
        ActiveSlot1.Name = "ActiveSlot1"
        ActiveSlot1.Size = New Size(60, 60)
        ActiveSlot1.TabIndex = 0
        ActiveSlot1.TabStop = False
        ' 
        ' InfoPanel
        ' 
        InfoPanel.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        InfoPanel.BackgroundImage = My.Resources.Resources.skybanner
        InfoPanel.Controls.Add(PlayerNameTitle)
        InfoPanel.Controls.Add(WorldTitle)
        InfoPanel.Location = New Point(634, 50)
        InfoPanel.Name = "InfoPanel"
        InfoPanel.Size = New Size(366, 64)
        InfoPanel.TabIndex = 14
        ' 
        ' PlayerNameTitle
        ' 
        PlayerNameTitle.AutoSize = True
        PlayerNameTitle.BackColor = Color.Transparent
        PlayerNameTitle.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerNameTitle.Location = New Point(14, 34)
        PlayerNameTitle.Name = "PlayerNameTitle"
        PlayerNameTitle.Size = New Size(119, 19)
        PlayerNameTitle.TabIndex = 1
        PlayerNameTitle.Text = "Player Name"
        ' 
        ' WorldTitle
        ' 
        WorldTitle.AutoSize = True
        WorldTitle.BackColor = Color.Transparent
        WorldTitle.Font = New Font("DengXian", 18F, FontStyle.Bold, GraphicsUnit.Point)
        WorldTitle.Location = New Point(14, 9)
        WorldTitle.Name = "WorldTitle"
        WorldTitle.Size = New Size(150, 25)
        WorldTitle.TabIndex = 0
        WorldTitle.Text = "World Name"
        ' 
        ' QuestLogPanel
        ' 
        QuestLogPanel.Controls.Add(exitLogbtn)
        QuestLogPanel.Controls.Add(Label3)
        QuestLogPanel.Controls.Add(QuestLogBox)
        QuestLogPanel.Location = New Point(648, 919)
        QuestLogPanel.Name = "QuestLogPanel"
        QuestLogPanel.Size = New Size(608, 331)
        QuestLogPanel.TabIndex = 15
        ' 
        ' exitLogbtn
        ' 
        exitLogbtn.Location = New Point(506, 7)
        exitLogbtn.Name = "exitLogbtn"
        exitLogbtn.Size = New Size(75, 23)
        exitLogbtn.TabIndex = 12
        exitLogbtn.Text = "Exit"
        exitLogbtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("DengXian", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(13, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 22)
        Label3.TabIndex = 11
        Label3.Text = "Quest Log"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("DengXian", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(3, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 22)
        Label4.TabIndex = 12
        Label4.Text = "Active Quest"
        ' 
        ' ActiveQuestPanel
        ' 
        ActiveQuestPanel.BackColor = Color.Transparent
        ActiveQuestPanel.Controls.Add(questdescriptiontext)
        ActiveQuestPanel.Controls.Add(Label4)
        ActiveQuestPanel.Location = New Point(1005, 131)
        ActiveQuestPanel.Name = "ActiveQuestPanel"
        ActiveQuestPanel.Size = New Size(215, 161)
        ActiveQuestPanel.TabIndex = 16
        ' 
        ' questdescriptiontext
        ' 
        questdescriptiontext.AutoSize = True
        questdescriptiontext.Font = New Font("DengXian", 12F, FontStyle.Regular, GraphicsUnit.Point)
        questdescriptiontext.Location = New Point(3, 43)
        questdescriptiontext.MaximumSize = New Size(210, 0)
        questdescriptiontext.Name = "questdescriptiontext"
        questdescriptiontext.Size = New Size(209, 34)
        questdescriptiontext.TabIndex = 13
        questdescriptiontext.Text = "Quest DescriptionQuest DescriptionQuest Description"
        ' 
        ' openMenuButton
        ' 
        openMenuButton.BackgroundImage = My.Resources.Resources.sidebutton1
        openMenuButton.Font = New Font("DengXian", 12F, FontStyle.Bold, GraphicsUnit.Point)
        openMenuButton.Location = New Point(6, 55)
        openMenuButton.Name = "openMenuButton"
        openMenuButton.Size = New Size(250, 60)
        openMenuButton.TabIndex = 0
        openMenuButton.TabStop = False
        openMenuButton.Text = "Open Menu"
        openMenuButton.UseVisualStyleBackColor = True
        ' 
        ' sideButtons
        ' 
        sideButtons.Controls.Add(openQuestLogBtn)
        sideButtons.Controls.Add(multipliertext)
        sideButtons.Controls.Add(multipliertitle)
        sideButtons.Controls.Add(TextBox1)
        sideButtons.Controls.Add(controlshelptitle)
        sideButtons.Controls.Add(openInventoryButton)
        sideButtons.Controls.Add(openMenuButton)
        sideButtons.Location = New Point(12, 120)
        sideButtons.Name = "sideButtons"
        sideButtons.Size = New Size(262, 648)
        sideButtons.TabIndex = 0
        ' 
        ' openQuestLogBtn
        ' 
        openQuestLogBtn.BackgroundImage = My.Resources.Resources.sidebutton1
        openQuestLogBtn.Font = New Font("DengXian", 12F, FontStyle.Bold, GraphicsUnit.Point)
        openQuestLogBtn.Location = New Point(6, 219)
        openQuestLogBtn.Name = "openQuestLogBtn"
        openQuestLogBtn.Size = New Size(250, 60)
        openQuestLogBtn.TabIndex = 22
        openQuestLogBtn.TabStop = False
        openQuestLogBtn.Text = "Open Quest Log"
        openQuestLogBtn.UseVisualStyleBackColor = True
        ' 
        ' multipliertext
        ' 
        multipliertext.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        multipliertext.AutoSize = True
        multipliertext.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        multipliertext.Location = New Point(62, 569)
        multipliertext.Name = "multipliertext"
        multipliertext.Size = New Size(119, 23)
        multipliertext.TabIndex = 21
        multipliertext.Text = "x1.13 coins"
        multipliertext.TextAlign = ContentAlignment.TopRight
        ' 
        ' multipliertitle
        ' 
        multipliertitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        multipliertitle.AutoSize = True
        multipliertitle.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point)
        multipliertitle.Location = New Point(44, 548)
        multipliertitle.Name = "multipliertitle"
        multipliertitle.Size = New Size(160, 19)
        multipliertitle.TabIndex = 19
        multipliertitle.Text = "Current Multiplier:"
        multipliertitle.TextAlign = ContentAlignment.TopRight
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(6, 331)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(250, 193)
        TextBox1.TabIndex = 0
        TextBox1.TabStop = False
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' controlshelptitle
        ' 
        controlshelptitle.AutoSize = True
        controlshelptitle.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        controlshelptitle.Location = New Point(6, 309)
        controlshelptitle.Name = "controlshelptitle"
        controlshelptitle.Size = New Size(81, 19)
        controlshelptitle.TabIndex = 19
        controlshelptitle.Text = "Controls"
        ' 
        ' openInventoryButton
        ' 
        openInventoryButton.BackgroundImage = My.Resources.Resources.sidebutton1
        openInventoryButton.Font = New Font("DengXian", 12F, FontStyle.Bold, GraphicsUnit.Point)
        openInventoryButton.Location = New Point(6, 137)
        openInventoryButton.Name = "openInventoryButton"
        openInventoryButton.Size = New Size(250, 60)
        openInventoryButton.TabIndex = 0
        openInventoryButton.TabStop = False
        openInventoryButton.Text = "Open Inventory"
        openInventoryButton.UseVisualStyleBackColor = True
        ' 
        ' upgradePanel
        ' 
        upgradePanel.BackgroundImage = My.Resources.Resources.upgradebg
        upgradePanel.Controls.Add(playerbalancetitle)
        upgradePanel.Controls.Add(upgradecosttitle)
        upgradePanel.Controls.Add(upgradeleveltitle)
        upgradePanel.Controls.Add(upgradetitle)
        upgradePanel.Controls.Add(exitupgbtn)
        upgradePanel.Controls.Add(upgradeflowerBtn)
        upgradePanel.Location = New Point(18, 954)
        upgradePanel.Name = "upgradePanel"
        upgradePanel.Size = New Size(620, 238)
        upgradePanel.TabIndex = 0
        ' 
        ' playerbalancetitle
        ' 
        playerbalancetitle.AutoSize = True
        playerbalancetitle.BackColor = Color.Transparent
        playerbalancetitle.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        playerbalancetitle.Location = New Point(325, 196)
        playerbalancetitle.Name = "playerbalancetitle"
        playerbalancetitle.Size = New Size(145, 19)
        playerbalancetitle.TabIndex = 5
        playerbalancetitle.Text = "Balance: 0 coins"
        playerbalancetitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' upgradecosttitle
        ' 
        upgradecosttitle.AutoSize = True
        upgradecosttitle.BackColor = Color.Transparent
        upgradecosttitle.Font = New Font("DengXian", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        upgradecosttitle.Location = New Point(73, 90)
        upgradecosttitle.Name = "upgradecosttitle"
        upgradecosttitle.Size = New Size(306, 22)
        upgradecosttitle.TabIndex = 4
        upgradecosttitle.Text = "It will cost 20 coins to upgrade"
        ' 
        ' upgradeleveltitle
        ' 
        upgradeleveltitle.AutoSize = True
        upgradeleveltitle.BackColor = Color.Transparent
        upgradeleveltitle.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        upgradeleveltitle.Location = New Point(166, 45)
        upgradeleveltitle.Name = "upgradeleveltitle"
        upgradeleveltitle.Size = New Size(74, 19)
        upgradeleveltitle.TabIndex = 3
        upgradeleveltitle.Text = "Level: 1"
        upgradeleveltitle.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' upgradetitle
        ' 
        upgradetitle.AutoSize = True
        upgradetitle.BackColor = Color.Transparent
        upgradetitle.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        upgradetitle.Location = New Point(60, 26)
        upgradetitle.Name = "upgradetitle"
        upgradetitle.Size = New Size(308, 19)
        upgradetitle.TabIndex = 2
        upgradetitle.Text = "This patch of flowers is currently at"
        ' 
        ' exitupgbtn
        ' 
        exitupgbtn.BackColor = SystemColors.Control
        exitupgbtn.Location = New Point(229, 115)
        exitupgbtn.Name = "exitupgbtn"
        exitupgbtn.Size = New Size(111, 34)
        exitupgbtn.TabIndex = 1
        exitupgbtn.Text = "Exit"
        exitupgbtn.UseVisualStyleBackColor = False
        ' 
        ' upgradeflowerBtn
        ' 
        upgradeflowerBtn.BackColor = SystemColors.Control
        upgradeflowerBtn.Location = New Point(83, 116)
        upgradeflowerBtn.Name = "upgradeflowerBtn"
        upgradeflowerBtn.Size = New Size(140, 34)
        upgradeflowerBtn.TabIndex = 0
        upgradeflowerBtn.Text = "Upgrade"
        upgradeflowerBtn.UseVisualStyleBackColor = False
        ' 
        ' mainmoneyLabel
        ' 
        mainmoneyLabel.AutoSize = True
        mainmoneyLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        mainmoneyLabel.Location = New Point(1046, 311)
        mainmoneyLabel.Name = "mainmoneyLabel"
        mainmoneyLabel.Size = New Size(114, 21)
        mainmoneyLabel.TabIndex = 15
        mainmoneyLabel.Text = "Money: 0 coins"
        ' 
        ' BgTimer
        ' 
        BgTimer.Enabled = True
        BgTimer.Interval = 50
        ' 
        ' GameMenuPanel
        ' 
        GameMenuPanel.BackgroundImage = My.Resources.Resources.menubackground1
        GameMenuPanel.Controls.Add(exitMenubtn)
        GameMenuPanel.Controls.Add(saveGameBtn)
        GameMenuPanel.Controls.Add(resumeGameBtn)
        GameMenuPanel.Location = New Point(1417, 1322)
        GameMenuPanel.Name = "GameMenuPanel"
        GameMenuPanel.Size = New Size(400, 306)
        GameMenuPanel.TabIndex = 0
        ' 
        ' exitMenubtn
        ' 
        exitMenubtn.BackColor = Color.Beige
        exitMenubtn.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        exitMenubtn.Location = New Point(124, 162)
        exitMenubtn.Name = "exitMenubtn"
        exitMenubtn.Size = New Size(145, 40)
        exitMenubtn.TabIndex = 2
        exitMenubtn.Text = "Exit"
        exitMenubtn.UseVisualStyleBackColor = False
        ' 
        ' saveGameBtn
        ' 
        saveGameBtn.BackColor = Color.Beige
        saveGameBtn.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        saveGameBtn.Location = New Point(124, 102)
        saveGameBtn.Name = "saveGameBtn"
        saveGameBtn.Size = New Size(145, 40)
        saveGameBtn.TabIndex = 1
        saveGameBtn.Text = "Save"
        saveGameBtn.UseVisualStyleBackColor = False
        ' 
        ' resumeGameBtn
        ' 
        resumeGameBtn.BackColor = Color.Beige
        resumeGameBtn.Font = New Font("DengXian", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        resumeGameBtn.Location = New Point(124, 36)
        resumeGameBtn.Name = "resumeGameBtn"
        resumeGameBtn.Size = New Size(145, 40)
        resumeGameBtn.TabIndex = 0
        resumeGameBtn.Text = "Resume"
        resumeGameBtn.UseVisualStyleBackColor = False
        ' 
        ' DialoguePanel
        ' 
        DialoguePanel.BackgroundImage = My.Resources.Resources.dialoguebackground
        DialoguePanel.Controls.Add(DialogueBtn2)
        DialoguePanel.Controls.Add(DialogueBtn1)
        DialoguePanel.Controls.Add(NameLabel)
        DialoguePanel.Controls.Add(DialogueTextBox)
        DialoguePanel.Controls.Add(SpeakerImage)
        DialoguePanel.Location = New Point(624, 1322)
        DialoguePanel.Name = "DialoguePanel"
        DialoguePanel.Size = New Size(644, 198)
        DialoguePanel.TabIndex = 17
        ' 
        ' DialogueBtn2
        ' 
        DialogueBtn2.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DialogueBtn2.Location = New Point(356, 141)
        DialogueBtn2.Name = "DialogueBtn2"
        DialogueBtn2.Size = New Size(172, 40)
        DialogueBtn2.TabIndex = 4
        DialogueBtn2.Text = "Button2"
        DialogueBtn2.UseVisualStyleBackColor = True
        ' 
        ' DialogueBtn1
        ' 
        DialogueBtn1.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DialogueBtn1.Location = New Point(134, 141)
        DialogueBtn1.Name = "DialogueBtn1"
        DialogueBtn1.Size = New Size(172, 40)
        DialogueBtn1.TabIndex = 3
        DialogueBtn1.Text = "Button1"
        DialogueBtn1.UseVisualStyleBackColor = True
        ' 
        ' NameLabel
        ' 
        NameLabel.AutoSize = True
        NameLabel.BackColor = Color.Transparent
        NameLabel.Location = New Point(22, 65)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New Size(42, 15)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Jimmy"
        ' 
        ' DialogueTextBox
        ' 
        DialogueTextBox.Font = New Font("DengXian", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DialogueTextBox.Location = New Point(83, 14)
        DialogueTextBox.Multiline = True
        DialogueTextBox.Name = "DialogueTextBox"
        DialogueTextBox.ReadOnly = True
        DialogueTextBox.Size = New Size(537, 112)
        DialogueTextBox.TabIndex = 1
        DialogueTextBox.Text = "Placeholder"
        ' 
        ' SpeakerImage
        ' 
        SpeakerImage.Location = New Point(16, 14)
        SpeakerImage.Name = "SpeakerImage"
        SpeakerImage.Size = New Size(48, 48)
        SpeakerImage.TabIndex = 0
        SpeakerImage.TabStop = False
        ' 
        ' MainShopPanel
        ' 
        MainShopPanel.BackgroundImage = My.Resources.Resources.storebg
        MainShopPanel.Controls.Add(storeexitbtn)
        MainShopPanel.Controls.Add(StoreInfoLabel)
        MainShopPanel.Controls.Add(InnerShopPanel)
        MainShopPanel.Location = New Point(1493, 1111)
        MainShopPanel.Name = "MainShopPanel"
        MainShopPanel.Size = New Size(687, 309)
        MainShopPanel.TabIndex = 18
        ' 
        ' storeexitbtn
        ' 
        storeexitbtn.Location = New Point(636, 0)
        storeexitbtn.Name = "storeexitbtn"
        storeexitbtn.Size = New Size(51, 41)
        storeexitbtn.TabIndex = 2
        storeexitbtn.Text = "Exit"
        storeexitbtn.UseVisualStyleBackColor = True
        ' 
        ' coffeepanel
        ' 
        coffeepanel.BackgroundImage = My.Resources.Resources.coffeebg
        coffeepanel.Controls.Add(exitCoffeeBtn)
        coffeepanel.Location = New Point(12, 1281)
        coffeepanel.Name = "coffeepanel"
        coffeepanel.Size = New Size(532, 396)
        coffeepanel.TabIndex = 19
        ' 
        ' exitCoffeeBtn
        ' 
        exitCoffeeBtn.Location = New Point(422, 183)
        exitCoffeeBtn.Name = "exitCoffeeBtn"
        exitCoffeeBtn.Size = New Size(75, 23)
        exitCoffeeBtn.TabIndex = 0
        exitCoffeeBtn.Text = "Exit"
        exitCoffeeBtn.UseVisualStyleBackColor = True
        ' 
        ' StoreInfoLabel
        ' 
        StoreInfoLabel.AutoSize = True
        StoreInfoLabel.BackColor = Color.Transparent
        StoreInfoLabel.Location = New Point(514, 97)
        StoreInfoLabel.MaximumSize = New Size(160, 0)
        StoreInfoLabel.Name = "StoreInfoLabel"
        StoreInfoLabel.Size = New Size(123, 15)
        StoreInfoLabel.TabIndex = 1
        StoreInfoLabel.Text = "Welcome to the store!"
        ' 
        ' InnerShopPanel
        ' 
        InnerShopPanel.AutoScroll = True
        InnerShopPanel.Location = New Point(13, 21)
        InnerShopPanel.Name = "InnerShopPanel"
        InnerShopPanel.Size = New Size(486, 271)
        InnerShopPanel.TabIndex = 0
        ' 
        ' loadFilePanel
        ' 
        loadFilePanel.BackColor = SystemColors.ControlLight
        loadFilePanel.BackgroundImage = My.Resources.Resources.newfilebg
        loadFilePanel.Controls.Add(LoadBackToMenu)
        loadFilePanel.Controls.Add(CheckedListBox1)
        loadFilePanel.Controls.Add(loadfiletitle)
        loadFilePanel.Controls.Add(loadfilebtnmain)
        loadFilePanel.Enabled = False
        loadFilePanel.Location = New Point(1441, 945)
        loadFilePanel.Name = "loadFilePanel"
        loadFilePanel.Size = New Size(1280, 960)
        loadFilePanel.TabIndex = 10
        loadFilePanel.TabStop = False
        loadFilePanel.Text = "Load File"
        loadFilePanel.Visible = False
        ' 
        ' LoadBackToMenu
        ' 
        LoadBackToMenu.BackColor = Color.Transparent
        LoadBackToMenu.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        LoadBackToMenu.Location = New Point(643, 427)
        LoadBackToMenu.Name = "LoadBackToMenu"
        LoadBackToMenu.Size = New Size(255, 98)
        LoadBackToMenu.TabIndex = 11
        LoadBackToMenu.Text = "Return to Menu"
        LoadBackToMenu.UseVisualStyleBackColor = False
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.CheckOnClick = True
        CheckedListBox1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(382, 244)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.ScrollAlwaysVisible = True
        CheckedListBox1.Size = New Size(454, 172)
        CheckedListBox1.TabIndex = 10
        ' 
        ' loadfiletitle
        ' 
        loadfiletitle.AutoSize = True
        loadfiletitle.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        loadfiletitle.Location = New Point(382, 206)
        loadfiletitle.Name = "loadfiletitle"
        loadfiletitle.Size = New Size(117, 23)
        loadfiletitle.TabIndex = 5
        loadfiletitle.Text = "Saved Files"
        loadfiletitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' loadfilebtnmain
        ' 
        loadfilebtnmain.BackColor = Color.Transparent
        loadfilebtnmain.Font = New Font("Ink Free", 14F, FontStyle.Bold, GraphicsUnit.Point)
        loadfilebtnmain.Location = New Point(382, 427)
        loadfilebtnmain.Name = "loadfilebtnmain"
        loadfilebtnmain.Size = New Size(255, 98)
        loadfilebtnmain.TabIndex = 3
        loadfilebtnmain.Text = "Load File"
        loadfilebtnmain.UseVisualStyleBackColor = False
        ' 
        ' MainGame
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1984, 1421)
        Controls.Add(loadFilePanel)
        Controls.Add(coffeepanel)
        Controls.Add(MainShopPanel)
        Controls.Add(DialoguePanel)
        Controls.Add(GameMenuPanel)
        Controls.Add(mainmoneyLabel)
        Controls.Add(newFileGB)
        Controls.Add(mainMenu)
        Controls.Add(upgradePanel)
        Controls.Add(ActiveQuestPanel)
        Controls.Add(InventoryPanel)
        Controls.Add(QuestLogPanel)
        Controls.Add(InfoPanel)
        Controls.Add(ActiveBarBox)
        Controls.Add(sideButtons)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "MainGame"
        Text = "Peaceful Pines"
        mainMenu.ResumeLayout(False)
        mainMenu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        newFileGB.ResumeLayout(False)
        newFileGB.PerformLayout()
        InventoryPanel.ResumeLayout(False)
        InventoryPanel.PerformLayout()
        CType(InvBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(InvBox1, ComponentModel.ISupportInitialize).EndInit()
        ActiveBarBox.ResumeLayout(False)
        ActiveBarBox.PerformLayout()
        CType(ActiveSlot3, ComponentModel.ISupportInitialize).EndInit()
        CType(ActiveSlot2, ComponentModel.ISupportInitialize).EndInit()
        CType(ActiveSlot1, ComponentModel.ISupportInitialize).EndInit()
        InfoPanel.ResumeLayout(False)
        InfoPanel.PerformLayout()
        QuestLogPanel.ResumeLayout(False)
        QuestLogPanel.PerformLayout()
        ActiveQuestPanel.ResumeLayout(False)
        ActiveQuestPanel.PerformLayout()
        sideButtons.ResumeLayout(False)
        sideButtons.PerformLayout()
        upgradePanel.ResumeLayout(False)
        upgradePanel.PerformLayout()
        GameMenuPanel.ResumeLayout(False)
        DialoguePanel.ResumeLayout(False)
        DialoguePanel.PerformLayout()
        CType(SpeakerImage, ComponentModel.ISupportInitialize).EndInit()
        MainShopPanel.ResumeLayout(False)
        MainShopPanel.PerformLayout()
        coffeepanel.ResumeLayout(False)
        loadFilePanel.ResumeLayout(False)
        loadFilePanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mainMenu As GroupBox
    Friend WithEvents newFileBtn As Button
    Friend WithEvents loadFileBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menuTitle As TextBox
    Friend WithEvents newFileGB As GroupBox
    Friend WithEvents newFileNameBox As TextBox
    Friend WithEvents createNewFileBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents newFileLabel2 As Label
    Friend WithEvents characterNameBox As TextBox
    Friend WithEvents newfileRules As TextBox
    Friend WithEvents newFileExit As Button
    Friend WithEvents PlayerTimer As Timer
    Friend WithEvents InventoryPanel As Panel
    Friend WithEvents moneyLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InvBox8 As PictureBox
    Friend WithEvents InvBox7 As PictureBox
    Friend WithEvents InvBox6 As PictureBox
    Friend WithEvents InvBox5 As PictureBox
    Friend WithEvents InvBox4 As PictureBox
    Friend WithEvents InvBox3 As PictureBox
    Friend WithEvents InvBox2 As PictureBox
    Friend WithEvents InvBox1 As PictureBox
    Friend WithEvents QuestLogBox As TextBox
    Friend WithEvents ActiveBarBox As Panel
    Friend WithEvents Sl3 As Label
    Friend WithEvents Sl2 As Label
    Friend WithEvents Sl1 As Label
    Friend WithEvents ActiveSlot3 As PictureBox
    Friend WithEvents ActiveSlot2 As PictureBox
    Friend WithEvents ActiveSlot1 As PictureBox
    Friend WithEvents InfoPanel As Panel
    Friend WithEvents WorldTitle As Label
    Friend WithEvents PlayerNameTitle As Label
    Friend WithEvents QuestLogPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ActiveQuestPanel As Panel
    Friend WithEvents questdescriptiontext As Label
    Friend WithEvents openMenuButton As Button
    Friend WithEvents sideButtons As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents controlshelptitle As Label
    Friend WithEvents openInventoryButton As Button
    Friend WithEvents multipliertitle As Label
    Friend WithEvents multipliertext As Label
    Friend WithEvents upgradePanel As Panel
    Friend WithEvents playerbalancetitle As Label
    Friend WithEvents upgradecosttitle As Label
    Friend WithEvents upgradeleveltitle As Label
    Friend WithEvents upgradetitle As Label
    Friend WithEvents exitupgbtn As Button
    Friend WithEvents upgradeflowerBtn As Button
    Friend WithEvents mainmoneyLabel As Label
    Friend WithEvents BgTimer As Timer
    Friend WithEvents GameMenuPanel As Panel
    Friend WithEvents exitMenubtn As Button
    Friend WithEvents saveGameBtn As Button
    Friend WithEvents resumeGameBtn As Button
    Friend WithEvents exitInvBtn As Button
    Friend WithEvents InvBox10 As PictureBox
    Friend WithEvents InvBox9 As PictureBox
    Friend WithEvents DialoguePanel As Panel
    Friend WithEvents DialogueBtn2 As Button
    Friend WithEvents DialogueBtn1 As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents DialogueTextBox As TextBox
    Friend WithEvents SpeakerImage As PictureBox
    Friend WithEvents MainShopPanel As Panel
    Friend WithEvents storeexitbtn As Button
    Friend WithEvents StoreInfoLabel As Label
    Friend WithEvents InnerShopPanel As Panel
    Friend WithEvents openQuestLogBtn As Button
    Friend WithEvents coffeepanel As Panel
    Friend WithEvents exitCoffeeBtn As Button
    Friend WithEvents exitLogbtn As Button
    Friend WithEvents loadFilePanel As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents loadfiletitle As Label
    Friend WithEvents loadfilebtnmain As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents LoadBackToMenu As Button
End Class
