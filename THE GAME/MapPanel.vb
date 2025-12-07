Public Class MapPanel
    Dim averageGrid As New Panel

    Public Sub New(counter As Integer)
        averageGrid.Size = New Size(720, 720)
        averageGrid.Enabled = True
        averageGrid.Visible = True
        averageGrid.Location = New Point(280, 120)
        averageGrid.BackColor = Color.LightGray
        averageGrid.Name = "P" + Str(counter)
    End Sub

    Public Function returnPanel() As Panel
        Return averageGrid
    End Function
End Class
