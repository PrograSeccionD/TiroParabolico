Public Class Form1
    Dim Desplax As Single 'DISTANCIA RECORRIDA EN EL EJE X
    Dim Tiempo As Single ' TIEMPO TOMADO PARA LOS CALCULOS
    Dim ListaX As New ArrayList ' DATOS DE X EN FUNCION DEL TIEMPO
    Dim ListaY As New ArrayList ' DATOS DE Y EN FUNCION DEL TIEMPO
    Dim Contador As Integer = 0 ' CONTADOR DE PASO DE TIEMPO
    Dim posicionCohete As Integer = 0 'CONTADOR POSICION COHETE
    Dim f3check1 As Boolean = Module1.f3c1 'OBTENER VALOR DE CHECK
    Dim f3check2 As Boolean = Module1.f3c2 'OBTENER VALOR DE CHECK
    Dim f3check3 As Boolean = Module1.f3c3 'OBTENER VALOR DE CHECK
    Dim f3check4 As Boolean = Module1.f3c4 'OBTENER VALOR DE CHECK
    Dim f3check5 As Boolean = Module1.f3c5 'OBTENER VALOR DE CHECK
    Dim f3check6 As Boolean = Module1.f3c6 'OBTENER VALOR DE CHECK


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'HACE LOS CALCULOS Y PONE EN MARCHA EL TIMER
        NavBarGroup1.Visible = f3check1
        NavBarGroup2.Visible = f3check2
        NavBarGroup3.Visible = f3check3
        NavBarGroup4.Visible = f3check4
        NavBarGroup5.Visible = f3check5

        Calculos()
        Timer1.Interval = 500
        Timer1.Enabled = True
        NavBarControl1.Enabled = True
    End Sub
    Public Sub Calculos()
        'LIMPIA LOS ARRAYS Y EL CONTADOR POR SI SE HACEN VARIOS CALCULOS SIN REINICIAR LA APLICACION
        ListaX.Clear()
        ListaY.Clear()
        Contador = 0
        posicionCohete = 0
        Grafica.Image = Nothing
        Dim angulo_in As Single = CSng(txt_angulo.Text)
        Try
            'TOMA DATOS
            Dim ALTURA_INI As Single = CSng(txt_inicio.Text)
            Dim ALTURA_FIN As Single = 0

            If txt_velocidad.Text > 80 Then
                MsgBox("La velocidad debe ser menor de 80")
            Else
                If txt_angulo.Text > 70 Then
                    MsgBox("El angulo maximo es 70")
                Else
                    Dim VELOCIDAD_INI As Single = CSng(txt_velocidad.Text)
                    Dim ANGULO As Single = CSng(txt_angulo.Text)
                    Dim GRAVEDAD As Single = 9.8

                    'CONVERSION GRADOS A RADIANES
                    Dim RADIANES As Single = ANGULO * Math.PI / 180

                    'DETERMINAMOS SENO Y COSENO DEL ANGULO
                    Dim SENO As Single = Math.Sin(RADIANES)
                    Dim COSENO As Single = Math.Cos(RADIANES)

                    'DETERMINAMOS VECTORES VELOCIDAD INICIAL X E Y
                    Dim VECTORY As Single = VELOCIDAD_INI * SENO
                    Dim VECTORX As Single = VELOCIDAD_INI * COSENO


                    'DETERMINAMOS LA DIFERENCIA DE ALTURAS
                    Dim DIFERENCIA_ALTURAS As Single = ALTURA_FIN - ALTURA_INI

                    'SI ANGULO ES MAYOR QUE CERO
                    If ANGULO > 0 Then

                        'DETERMINAMOS LOS DOS POSIBLES TIEMPOS QUE SALEN DE LA ECUACION BICUADRADA APLICANDO (-B +-(B^2-4AC)^0,5)/2A   YA QUE: 1/2 * g* t^2 - Voyt - Yo + Yf = 0
                        Dim TIEMPO1 As Single = (VECTORY + Math.Sqrt((VECTORY ^ 2) - (2 * GRAVEDAD * DIFERENCIA_ALTURAS))) / GRAVEDAD

                        If f3check6 = True Then
                            lb_tiempoTotal.Text = Math.Round(TIEMPO1, 2) & " seg"
                        Else
                            l1.Visible = False
                            lb_tiempoTotal.Visible = False
                        End If


                        Dim TIEMPO2 As Single = (VECTORY - Math.Sqrt((VECTORY ^ 2) - (2 * GRAVEDAD * DIFERENCIA_ALTURAS))) / GRAVEDAD

                        If f3check3 = True Then
                            lb_tiempoAltura.Text = Math.Round(TIEMPO1 / 2, 2) & " seg"
                        Else
                            l2.Visible = False
                            lb_tiempoAltura.Visible = False
                        End If

                        Tiempo = Math.Max(TIEMPO1, TIEMPO2)
                            'LabelTIEMPO.Text = Math.Round(TIEMPO, 2) & " seg"

                            'EN CASO DE QUE EL ANGULO SEA CERO
                        ElseIf ANGULO = 0 Then

                        'DETERMINAMOS LOS DOS POSIBLES TIEMPOS QUE SALEN DE LA ECUACION Yf=Yo-(g*t^2)/2 YA QUE EL VECTOR Y SERA IGUAL A 0 => t=+-(2*(Yo-Yf)/g)^0,5 
                        Dim TIEMPO1 As Single = Math.Sqrt(2 * (ALTURA_INI - ALTURA_FIN) / GRAVEDAD)

                        If f3check6 = True Then
                            lb_tiempoTotal.Text = Math.Round(TIEMPO1, 2) & " seg"
                        Else
                            l1.Visible = False
                            lb_tiempoTotal.Visible = False
                        End If

                        Dim TIEMPO2 As Single = Math.Sqrt(2 * (ALTURA_INI - ALTURA_FIN) / GRAVEDAD) * -1

                        If f3check3 = True Then
                            lb_tiempoAltura.Text = Math.Round(TIEMPO2, 2) & " seg"
                        Else
                            l2.Visible = False
                            lb_tiempoAltura.Visible = False
                        End If

                        'TOMAMOS EL TIEMPO MAYOR DE LOS DOS POSIBLES. EN LA MAYORIA DE LOS EJERCICIOS SERA EL UTIL. AUNQUE NO SIEMPRE
                        Tiempo = Math.Max(TIEMPO1, TIEMPO2)
                            'LabelTIEMPO.Text = Math.Round(TIEMPO, 2) & " seg"

                            'EN CASO DE QUE EL ANGULO SEA NEGATIVO
                        Else
                            MsgBox("REVISA EL VALOR DEL ANGULO")
                    End If

                    'EL DESPLAZAMIENTO EN X ES IGUAL AL VECTORX POR EL TIEMPO
                    Desplax = VECTORX * Tiempo
                    'lb_dezplaX.Text = Math.Round(Desplax, 2) & " m"

                    'CARGAMOS LOS ARRAYS DEL DESPLAZAMIENTO EN X E Y EN FUNCION DEL TIEMPO
                    For I = 0 To Tiempo
                        ListaX.Add(VECTORX * I)
                        ListaY.Add(ALTURA_INI + (VECTORY * I) - ((GRAVEDAD / 2) * I ^ 2))
                        posicionCohete += 1
                    Next

                    ' AÑADE EL RESTO DE LAS MEDIDAS EN CASO DE QUE EL TIEMPO SEA UN NUMERO DECIMAL
                    Dim RESTOX As Single = Desplax - ListaX(Math.Truncate(Tiempo))
                    If RESTOX > 0 Then
                        ListaX.Add(Desplax)
                        ListaY.Add(ALTURA_FIN)
                    End If

                    'CALCULO DE LA ALTURA MAXIMA: EN EL PUNTO DE ALTURA MAXIMA LA VELOCIDAD Y = 0 : VECTORY - GRAVEDAD * TIEMPO = 0 => TIEMPO = VECTORY/GRAVEDAD
                    Dim TIEMPOALTURAMAXIMA As Single = VECTORY / GRAVEDAD

                    'LA ALTURA MAXIMA = ALTURA INICIAL + (VELOCIDAD MEDIA EN Y * TIEMPO EN ALCANZAR LA ALTURA MAXIMA)
                    Dim YALTURAMAXIMA As Single = ALTURA_INI + ((VECTORY / 2) * TIEMPOALTURAMAXIMA)

                    'EL PUNTO EN X EN EL MOMENTO EN QUE LA ALTURA ES MAXIMA = VECTORX * TIEMPOALTURAMAXIMA
                    Dim XALTURAMAXIMA As Single = VECTORX * TIEMPOALTURAMAXIMA

                    If f3check2 = True Then
                        lb_alturaM.Text = Math.Round(YALTURAMAXIMA, 2) & " Y"
                    Else
                        l4.Visible = False
                        lb_alturaM.Visible = False
                    End If

                    'LA VELOCIDAD FINAL EN X SERA LA MISMA QUE LA INCIAL, DADO QUE EN ESTE MOVIMIENTO EL VECTOR X NO VARIA (MOVIMIENTO UNIFORME)

                    If f3check4 = True Then
                        lb_velocidadX.Text = Math.Round(VECTORX, 2) & " m/s"
                    Else
                        l5.Visible = False
                        lb_velocidadX.Visible = False
                    End If

                    ' LA VELOCIDAD FINAL EN Y SERA LA RESULTANTE DE Vf= Vo-(GRAVEDAD * TIEMPO) 
                    If f3check5 = True Then
                        lb_velocidadY.Text = Math.Round(VECTORY - (GRAVEDAD * Tiempo), 2) & " m/s" ' SI TIENE SIGNO NEGATIVO SIGNIFICA QUE ESTA BAJANDO
                    Else
                        l6.Visible = False
                        lb_velocidadY.Visible = False
                    End If
                End If
            End If





        Catch ex As Exception
            MsgBox("REVISA LOS VALORES INICIALES")
        End Try


    End Sub
    Public Sub PINTAR()
        'DEFINIMOS EL AREA DE DIBUJO DENTRO DEL PICTUREBOX: RESERVAREMOS UN MARGEN A CADA LADO PARA QUE SE VEA MEJOR LA GRAFICA
        Dim MARGEN As Integer = 50
        Dim ANCHO As Integer = Grafica.Width - MARGEN
        Dim ALTO As Integer = Grafica.Height - MARGEN
        'DEFINIMOS LOS ELEMENTOS DE DIBUJO
        Dim BM As Bitmap = New Bitmap(Grafica.Width, Grafica.Height)
        Dim DIBUJO As Graphics = Graphics.FromImage(BM)
        DIBUJO.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim LAPIZX As New Pen(Brushes.Cyan, 6)
        Dim LAPIZY As New Pen(Brushes.LightGreen, 6)
        Dim FUENTE As New Font("verdana", 8)
        ' Create image.
        Dim arriba As Image = Image.FromFile("C:\Users\coca_\Desktop\tiro\TiroParabolico\ProyectoGDA_FisicaI\Resources\misil16+.png")
        Dim abajo As Image = Image.FromFile("C:\Users\coca_\Desktop\tiro\TiroParabolico\ProyectoGDA_FisicaI\Resources\misil16-.png")
        Dim tank As Image = Image.FromFile("C:\Users\coca_\Desktop\tiro\TiroParabolico\ProyectoGDA_FisicaI\Resources\tank24.png")

        Try
            'DEFINIMOS EL TRAMO A DIBUJAR EN FUNCION DE LAS DIMENSIONES DEL PICTUREBOX MENOS SUS MARGENES
            Dim TRAMO As Single = (ANCHO - MARGEN) / Desplax  ' RATIO PARA QUE EL DESPLAZAMIENTO TOTAL SEA IGUAL AL ANCHO DE LA ZONA DE DIBUJO
            'DIBUJAMOS X Y SU TEXTO
            For I = 0 To Contador
                DIBUJO.DrawLine(LAPIZX, MARGEN, ALTO, MARGEN + (ListaX(I) * TRAMO), ALTO)
                DIBUJO.DrawString(Math.Round(ListaY(Contador), 2), FUENTE, Brushes.Black, CInt(MARGEN + ListaX(Contador) * TRAMO), CInt(ALTO - MARGEN - (ListaY(Contador) * TRAMO)))
            Next
            DIBUJO.DrawString(Math.Round(ListaX(Contador), 2), FUENTE, Brushes.Black, CInt(MARGEN + ListaX(Contador) * TRAMO), CInt(ALTO))
            If f3check1 = True Then
                lb_dezplaX.Text = Math.Round(ListaX(Contador), 2) & " m"
            Else
                l3.Visible = False
                lb_dezplaX.Visible = False
            End If

            'DIBUJO.DrawString("0", FUENTE, Brushes.Cyan, CInt(MARGEN + ARRAYX(0) * TRAMO), CInt(ALTO))
            'DIBUJAMOS Y Y SU TEXTO
            For I = 0 To Contador - 1
                DIBUJO.DrawLine(LAPIZY, CInt(MARGEN + (ListaX(I) * TRAMO)), CInt(ALTO - (ListaY(I) * TRAMO)), CInt(MARGEN + (ListaX(I + 1) * TRAMO)), CInt(ALTO - (ListaY(I + 1) * TRAMO)))
                If I <= (posicionCohete / 2) - 1 Then
                    If I > 0 Then
                        DIBUJO.DrawImage(arriba, CInt(MARGEN + (ListaX(I) * TRAMO)) - 9, CInt(ALTO - (ListaY(I) * TRAMO)), 20, 20)
                    End If
                Else
                    DIBUJO.DrawImage(abajo, CInt(MARGEN + (ListaX(I) * TRAMO)) - 8, CInt(ALTO - (ListaY(I) * TRAMO)), 20, 20)
                End If
            Next
            'DIBUJO.DrawString(Math.Round(ARRAYY(CONTADOR), 2), FUENTE, Brushes.Black, CInt(MARGEN + ARRAYX(CONTADOR) * TRAMO), CInt(ALTO - MARGEN - (ARRAYY(CONTADOR) * TRAMO)))
            'DIBUJO.DrawString(txt_inicio.Text, FUENTE, Brushes.Red, CInt(MARGEN + ListaX(0) * TRAMO), CInt(ALTO - (ListaY(0) * TRAMO)))
            DIBUJO.DrawImage(tank, CInt(MARGEN + ListaX(0) * TRAMO) - 12, CInt(ALTO - (ListaY(0) * TRAMO)) - 9, 24, 24)
            'MOSTRAMOS LA GRAFICA EN EL PICTUREBOX
            Grafica.Image = BM
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'CONTROLAMOS QUE EL TIMER SOLO ACTUE EL MISMO NUMERO DE VECES QUE LOS ARRAYS
        If Contador < ListaX.Count Then
            PINTAR()
            Contador += 1
        Else
            Timer1.Enabled = False
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.BackgroundImage = My.Resources.cross_circular_button_press
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackgroundImage = My.Resources.cross_circular_button
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim f3 As New Form3
        f3.Show()
        Me.Hide()
    End Sub
End Class
