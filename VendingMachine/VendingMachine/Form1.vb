Public Class Form1
    Dim cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.InsertNickel()
        Label1.Text = cs.Total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.InsertDime()
        Label1.Text = cs.Total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.InsertQuarter()
        Label1.Text = cs.Total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.InsertDollar()
        Label1.Text = cs.Total
    End Sub
End Class
