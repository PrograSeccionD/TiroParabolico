Public Class Form4
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label3.Text = "Cargando " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Dim f2 As New Form2
            f2.Show()
            Me.Hide()
        End If
    End Sub

End Class