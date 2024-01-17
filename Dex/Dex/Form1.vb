Imports System.IO

Public Class Form1
    Dim Records(50) As String
    Dim Count As Integer
    Dim Current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Clear()
        Field2.Clear()
        Field3.Clear()
        Field4.Clear()
        Field5.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim OutFile As New IO.StreamWriter("Data.txt")
        OutFile.Write(Field1.Text)
        OutFile.Write("|")
        OutFile.Write(Field2.Text)
        OutFile.Write("|")
        OutFile.Write(Field3.Text)
        OutFile.Write("|")
        OutFile.Write(Field4.Text)
        OutFile.Write("|")
        OutFile.Write(Field5.Text)
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
            While Not infile.EndOfStream
                Records(Current) = infile.ReadLine
                Count = Count + 1
            End While
            infile.Close()
            Showrecord(0)
        End If
    End Sub

    Public Sub Showrecord(Index As Integer)
        Dim Fields() As String
        If Records(Index) <> Nothing Then
            Fields = Records(Index).Split("|")
            Field1.Text = Fields(0)
            Field2.Text = Fields(1)
            Field3.Text = Fields(2)
            Field4.Text = Fields(3)
            Field5.Text = Fields(4)
            If File.Exists(Fields(5)) Then
                PictureBox1.Load(Fields(5))
            End If
        End If
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Current = 0
        Showrecord(Current)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Current = Count - 1
        Showrecord(Current)
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        If Current > 0 Then
            Current = Current - 1
            Showrecord(Current)
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If Current < Count - 1 Then
            Current = Current + 1
            Showrecord(Current)
        End If
    End Sub
End Class
