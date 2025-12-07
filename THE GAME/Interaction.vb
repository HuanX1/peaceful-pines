Imports System.Threading

Module Interaction
    Dim Chardialogue As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim Randdialogue As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
    Dim itemtovalue As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)

    Dim fruits As New List(Of String)
    Dim cooldowncount As Integer = 0
    Dim r As Random = New Random()
    Sub initialise() 'initialise all dictionaries and set all information
        Chardialogue.Add("John", "Hello there, general kenobi./Thanks man, knew I could count on you")
        Chardialogue.Add("Tayquon", "Wassup homie, is everything good?/Yo sick dude, you the best")
        Chardialogue.Add("Xandavier", "Hey, whats up?/Honestly such a help, thanks man!")
        Chardialogue.Add("Sam", "Yo, whatchu need?/Thanks, take this for your troubles")
        Chardialogue.Add("Kim", "Hey! Whats up?/Always knew i could count on you man! Thanks!")
        Chardialogue.Add("Donald", "What is popping my glorious citizen?/Amazing dude, you the goat for real.")
        Randdialogue.Add(0, "Fun fact. This game probably only took around 40 hours of coding overall.")
        Randdialogue.Add(1, "Did you know this entire map is made of 9 chunks? How cool is that? It could go bigger, but I dont feel like it.")
        Randdialogue.Add(2, "Sometimes you can get random fruits around the map. Try shaking a tree!")
        Randdialogue.Add(3, "Did you know that if you have a fishing rod, you can press E near a body of water to fish?")
        Randdialogue.Add(4, "I love drinking coffee... I'm so glad we have a coffee shop.")
        Randdialogue.Add(5, "You can sell your items in the shop for money, such as your fish!")
        Randdialogue.Add(6, "Man, I love fruit. mmmm. Fruit. Isn't it crazy how we've managed to genetically modify fruit so much? Made it sweeter, more plump. More nice. So nice.")
        Randdialogue.Add(7, "You know, if you complete quests you get money... How cool is that??? I LOVE MONEY!!!")
        Randdialogue.Add(8, "Dude, if you have an axe equipped you can get wood from trees! There's only a certain chance of getting it tho, so watch out")
        Randdialogue.Add(9, "Don't forget to upgrade your flowers. You know, they increase your multiplier which helps you get more coins from sales and quests!")
        Randdialogue.Add(10, "If you don't have an active quest, go find one! Sooner or later, you'll run into an NPC which has one for you.")
        Randdialogue.Add(11, "No matter what happens to you, never give up! You'll make it there eventually as long as you perservere, so never let go of your dreams!")
        Randdialogue.Add(12, "There's a cooldown when you interact with a tree apparently, if you hit 12 items in a short span of time they'll restrict your ability to get any more.")
        Randdialogue.Add(13, "In order to interact with flowers, you need to select your watering can! Press 2 on your keyboard.")

        itemtovalue.Add("Apple", 3)
        itemtovalue.Add("Pear", 3)
        itemtovalue.Add("Orange", 4)
        itemtovalue.Add("Grapes", 4)
        itemtovalue.Add("Lemon", 4)
        itemtovalue.Add("Fish", 5)
        itemtovalue.Add("Rare Fish", 8)
        itemtovalue.Add("Coffee", 10)
        itemtovalue.Add("Wood", 4)
        itemtovalue.Add("Box of coffee", 150)
        itemtovalue.Add("Shirt", 18)
        itemtovalue.Add("Package", 45)
        itemtovalue.Add("Book", 25)
        itemtovalue.Add("City Keys", 5000)

        fruits.Add("Apple")
        fruits.Add("Pear")
        fruits.Add("Orange")
        fruits.Add("Grapes")
        fruits.Add("Lemon")
    End Sub


    Public Sub Fish()
        Application.DoEvents()
        Dim chance As Integer = r.Next(1, 10)
        If chance > 4 And chance < 8 Then 'theres a chance the player catches a fish
            LoadBoxes.itemaddition("Fish", 1)
            Inventory.addInventory("Fish")
        ElseIf chance >= 8 Then
            'chance of a rare fish
            LoadBoxes.itemaddition("Rare Fish", 1)
            Inventory.addInventory("Rare Fish")
        End If
    End Sub

    Public Sub Chop()
        Dim chance As Integer = r.Next(1, 10) 'theres a chance the player chops some wood
        If chance > 7 Then
            LoadBoxes.itemaddition("Wood", 1)
            Inventory.addInventory("Wood")
            cooldowncount += 1 'add to cooldown
        End If
    End Sub

    Public Sub Shake()
        Dim chance As Integer = r.Next(1, 10)
        Dim choice As Integer = r.Next(0, 4)
        If chance > 6 Then 'theres a chance the player shakes a fruit off
            LoadBoxes.itemaddition(fruits(choice), 1)
            Inventory.addInventory(fruits(choice))
            cooldowncount += 1 'add to cooldown
        End If
    End Sub


    Public Function returnCooldown()
        Return cooldowncount
    End Function

    Public Sub reducecooldown()
        cooldowncount -= 1
    End Sub

    Public Function getNames()
        Return Chardialogue.Keys.ToArray()
    End Function

    Public Function returnDialogue(name As String)
        Return Chardialogue(name)
    End Function

    Public Function returnRandomDialogue()
        Return Randdialogue(r.Next(0, 13))
    End Function

    Public Function getValue(item)
        Return itemtovalue(item)
    End Function

    Public Function getAllItems()
        Return itemtovalue.Keys.ToArray()
    End Function

End Module
