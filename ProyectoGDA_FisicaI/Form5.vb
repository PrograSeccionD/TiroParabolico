Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        verPDF.LoadFile("C:\Users\coca_\Desktop\PROYECTO\TiroParabolico\ProyectoGDA_FisicaI\Tarea_Tiro_Parabolico.pdf")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f4 As New Form4
        f4.Show()
        Me.Hide()
    End Sub
End Class