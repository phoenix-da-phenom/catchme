Public Class Form1
    Public picbox(9) As PictureBox
    Public ImageName As String = AppDomain.CurrentDomain.BaseDirectory + "\rabbit.png"  'a string to hold the rabbit photo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picbox(1) = p1
        picbox(2) = p2
        picbox(3) = p3

        picbox(4) = p4
        picbox(5) = p5
        picbox(6) = p6
        picbox(7) = p7
        picbox(8) = p8
        picbox(9) = p9


      

    End Sub
    Private Function GameRandomNumber()
        Dim R As New Random()
        Return R.Next(1, 10)


    End Function



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim rndNum As Integer
        rndNum = GameRandomNumber()
        MsgBox(rndNum)
        loadImage(rndNum)


    End Sub

    Private Sub loadImage(index As Integer)
        picbox(index).ImageLocation = ImageName


    End Sub
End Class
