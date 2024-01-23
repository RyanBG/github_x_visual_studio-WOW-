Imports System.Deployment.Application
'EZZZZZ
Public Class Form1
    Dim strPictures() As String = {"848082__mystic-tien-fighting_p.jpg", "download (1).jpg",
        "download (2).jpg", "download.jpg", "mysticerlangshen-mystic-tenshinhan-would-it-really-disrupt-v0-elv842bb921b1.jpg",
        "qpi4hw60td7a1.jpg"}
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i = i + 1
        If strPictures.Length = i Then
            i = 0
        End If
        PictureBox1.Image = Image.FromFile("C:\Users\20230925\Desktop\awesome\" + strPictures(i))
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        PictureBox1.Image = Image.FromFile("C:\Users\20230925\Desktop\awesome\" + strPictures(0))
        AxWindowsMediaPlayer1.URL = "C:\Users\20230925\Downloads\Three Days Grace - I Hate Everything About You (Official Video).mp4"
        'tryin to see how this github shit works
    End Sub





    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Timer1.Enabled = False
        i = i + 1
        If strPictures.Length = i Then
            i = 0
        End If
        PictureBox1.Image = Image.FromFile("C:\Users\20230925\Desktop\awesome\" + strPictures(i))
        Timer1.Enabled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Timer1.Enabled = False
        If i = 0 Then
            i = strPictures.Length
        End If
        i = i - 1

        PictureBox1.Image = Image.FromFile("C:\Users\20230925\Desktop\awesome\" + strPictures(i))
        Timer1.Enabled = True
        'shits fire
    End Sub

End Class
