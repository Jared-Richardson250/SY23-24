Imports System.IO

Public Class Form1
    Dim Records(50) As String
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Feild1.Clear()
        Feild2.Clear()
        Feild3.Clear()
        Feild4.Clear()
        Feild5.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim OutFile As New IO.StreamWriter("Data.txt")
        OutFile.Write(Feild1.Text)
        OutFile.Write("|")
        OutFile.Write(Feild2.Text)
        OutFile.Write("|")
        OutFile.Write(Feild3.Text)
        OutFile.Write("|")
        OutFile.Write(Feild4.Text)
        OutFile.Write("|")
        OutFile.Write(Feild5.Text)
        OutFile.Write("|")
        OutFile.WriteLine(PictureBox1.ImageLocation)
        OutFile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim infile As New StreamReader("Data.txt")
            Dim R = infile.ReadLine
            Records(0) = infile.ReadLine
            Records(1) = infile.ReadLine
            infile.Close()
        End If
    End Sub
End Class
