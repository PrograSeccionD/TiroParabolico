Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f5 As New Form5
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub
End Class