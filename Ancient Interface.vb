Public Class Form1
    Dim purplecount As Integer = 0
    Dim goldencount As Integer = 0
    Dim greencount As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If purplecount = 1 And goldencount = 1 And greencount = 8 Then
            Label1.Text = "The Crevice has been opened"
            Me.Refresh()
        Else
            Close()

        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles greensquare.Click
        greencount = greencount + 1
        greensquarebox.Text = greencount.ToString
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles goldenrhombus.Click
        goldencount = goldencount + 1
        goldenrhombusbox.Text = goldencount.ToString
    End Sub

    Private Sub purplesquare_Click(sender As Object, e As EventArgs) Handles purplesquare.Click
        purplecount = purplecount + 1
        purplesquarebox.Text = purplecount.ToString




    End Sub
End Class
