Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Desplazamiento Horizonal
        Module1.f3c1 = CheckBox1.Checked
        'Altura maxima
        Module1.f3c2 = CheckBox2.Checked
        'Tiempo de subida
        Module1.f3c3 = CheckBox3.Checked
        'Velocidad en x
        Module1.f3c4 = CheckBox4.Checked
        'Velocidad en y
        Module1.f3c5 = CheckBox5.Checked
        'Tiempo Total
        Module1.f3c6 = CheckBox6.Checked
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub
End Class