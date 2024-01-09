Imports System.IO

Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        TextBox1.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim OutFile As New IO.StreamWriter("Out.txt")
        OutFile.WriteLine(TextBox1.Text)
        OutFile.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If (IO.File.Exists("Out.txt")) Then
            Dim Infile As New IO.StreamReader("Out.txt")
            TextBox1.Text = Infile.ReadToEnd
            Infile.Close()
        End If
    End Sub
End Class
