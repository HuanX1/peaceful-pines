Module LoadBoxes
    Dim colortothing As Dictionary(Of Color, String) = New Dictionary(Of Color, String)
    Dim textbox As Label = New Label
    Dim activeform As Form
    Dim WithEvents loadTimer As Timer = New Timer
    Dim boxes As List(Of Label) = New List(Of Label)
    Dim boxeslimit As List(Of Integer) = New List(Of Integer)

    Public Sub initialise(form As Form) 'initialise and set all dictionaries and relevant variables
        colortothing.Add(Color.Brown, "NPC")
        colortothing.Add(Color.Blue, "river")
        colortothing.Add(Color.Purple, "tree")
        colortothing.Add(Color.Yellow, "flowers")
        colortothing.Add(Color.Red, "the shop")
        colortothing.Add(Color.Black, "the coffee shop")
        activeform = form
        loadTimer.Enabled = True
        loadTimer.Interval = 50
    End Sub
    Public Function popupinteract(player As PictureBox, sender As PictureBox) As Label
        textbox.Enabled = True
        textbox.Visible = True
        textbox.Text = "Press E to interact with " + colortothing(sender.BackColor) 'provides pop up of interacting with a specific item
        textbox.AutoSize = True
        textbox.BackColor = Color.LightCoral
        textbox.Location = New Point(player.Location.X + 280, player.Location.Y + 45 + 120)
        textbox.BringToFront()
        Return textbox
    End Function

    Public Sub removepopupinteract()
        textbox.Enabled = False
        textbox.Visible = False
    End Sub

    Public Sub itemaddition(item As String, amount As Integer) 'when adding item to inventory, this pops up
        Dim talkingstring As String = "+" + CStr(amount) + " " + item + " added to inventory."
        Dim notifier As Label = New Label
        notifier.Location = New Point(20, 856)
        notifier.Text = talkingstring
        notifier.BackColor = Color.Beige
        notifier.AutoSize = True
        notifier.ForeColor = Color.Green
        notifier.Font = New Font("Tahoma", 12, FontStyle.Bold)
        activeform.Controls.Add(notifier)
        boxes.Add(notifier) 'adds it to the array of boxes which move up per tick
        boxeslimit.Add(50)
        itemdebounce = True
    End Sub

    Dim itemdebounce As Boolean = False
    Dim messagedebounce As Boolean = False
    Public Sub messagepopup(messager As String, player As PictureBox)
        If messagedebounce = False Then
            Dim message As Label = New Label
            message.Enabled = True
            message.Visible = True
            message.Text = messager
            message.AutoSize = True
            message.BackColor = Color.White
            message.Location = New Point(player.Location.X + 280, player.Location.Y + 30 + 120) 'this makes it appear just under the player
            activeform.Controls.Add(message)
            boxes.Add(message)
            boxeslimit.Add(15) 'adds it to the array of boxes with move up per tick
            message.BringToFront()
            messagedebounce = True
        End If
    End Sub

    Public Function returnitemdebounce()
        Return itemdebounce
    End Function

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles loadTimer.Tick
        If boxes.Count > 0 Then
            For k = 0 To boxes.Count - 1 Step 1
                Application.DoEvents()
                Try 'for each tick
                    If boxeslimit(k) <= 0 Then
                        If boxes(k).BackColor = Color.White Then 'if the box has hit the limit set their debounces back
                            messagedebounce = False
                        End If
                        If boxes(k).BackColor = Color.Beige Then
                            itemdebounce = False
                        End If
                        activeform.Controls.Remove(boxes(k)) 'and remove the box. otherwise
                        boxes.RemoveAt(k)
                        boxeslimit.RemoveAt(k)
                    Else
                        boxes(k).Top -= 1 'move the boxes up
                        boxeslimit(k) -= 1
                    End If
                Catch
                    Console.WriteLine("Out of range - K boxes") 'this bit is explained in the document
                End Try
            Next
        End If
    End Sub
End Module
