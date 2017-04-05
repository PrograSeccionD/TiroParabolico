Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f3 As New Form3
        f3.Show()
        Me.Hide()
        'Altura Maxima
        Module1.f2c1 = CheckBox1.Checked
        'Velocidad Inicial
        Module1.f2c2 = CheckBox2.Checked
        'Angulo
        Module1.f2c3 = CheckBox3.Checked
        'Tiempo Total
        Module1.f2c4 = CheckBox4.Checked
        'Altura Maxima
        Module1.f2c5 = CheckBox5.Checked
    End Sub
End Class