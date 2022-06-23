Imports System.Threading


Public Class Form1
    Public picbox(9) As PictureBox
    Public ImageName As String = AppDomain.CurrentDomain.BaseDirectory + "\rabbit.png"  'a string to hold the rabbit photo

    Public rndNum As Integer
    Private isThereAbunny As Boolean = False
    Private sound As String = AppDomain.CurrentDomain.BaseDirectory + "\sound.m4a"

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

        For i As Integer = 1 To 9
            '** This is where all the buttons are tied, to a common handler
            AddHandler picbox(i).Click, AddressOf BunnyClicked
        Next



    End Sub
    Private Function GameRandomNumber()
        Dim R As New Random()
        Return R.Next(1, 10)


    End Function



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True


    End Sub
    Private Sub ClearImage()
        For i As Integer = 1 To 9
            picbox(i).ImageLocation = ""
            Timer2.Enabled = False

        Next
    End Sub



    Private Sub loadImage(index As Integer)
        picbox(index).ImageLocation = ImageName


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        rndNum = GameRandomNumber()

        loadImage(rndNum)

        If (rndNum > -1) Then
            isThereAbunny = True


        End If
        If isThereAbunny Then
            Timer2.Enabled = True

        End If




    End Sub
    
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ClearImage()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Protected Sub BunnyClicked(ByVal sender As Object, ByVal e As EventArgs)
        If Timer2.Enabled = False Then
            lblScore.Text += 10
        End If


    End Sub
End Class
