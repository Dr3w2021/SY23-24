Public Class ClickerControl
    Dim c As New Integer
    Public Property Increment As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.Increment = Increment
        c.Click()
    End Sub
End Class
