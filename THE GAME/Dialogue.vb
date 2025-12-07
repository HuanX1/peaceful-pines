Module Dialogue

    Public Sub TypeWriter(text As String, textbox As TextBox)
        Dim startstring As String = ""
        For n = 0 To text.Length - 1 Step 1 'for each character, append it to the text
            textbox.Text = startstring 'and display the text every 10 milliseconds (giving off a typewriter effect)
            Threading.Thread.Sleep(10)
            Application.DoEvents()
            startstring += text(n)
        Next
    End Sub
End Module
