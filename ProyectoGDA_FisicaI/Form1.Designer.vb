<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lb_velocidadX = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lb_velocidadY = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_alturaM = New System.Windows.Forms.Label()
        Me.lb_dezplaX = New System.Windows.Forms.Label()
        Me.lb_tiempoAltura = New System.Windows.Forms.Label()
        Me.lb_tiempoTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_angulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_velocidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_inicio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Grafica = New System.Windows.Forms.PictureBox()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 301)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Velocidad Final X:"
        '
        'lb_velocidadX
        '
        Me.lb_velocidadX.AutoSize = True
        Me.lb_velocidadX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_velocidadX.ForeColor = System.Drawing.Color.Black
        Me.lb_velocidadX.Location = New System.Drawing.Point(127, 301)
        Me.lb_velocidadX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_velocidadX.Name = "lb_velocidadX"
        Me.lb_velocidadX.Size = New System.Drawing.Size(19, 13)
        Me.lb_velocidadX.TabIndex = 52
        Me.lb_velocidadX.Text = "---"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(11, 330)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Velocidad Final Y:"
        '
        'lb_velocidadY
        '
        Me.lb_velocidadY.AutoSize = True
        Me.lb_velocidadY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_velocidadY.ForeColor = System.Drawing.Color.Black
        Me.lb_velocidadY.Location = New System.Drawing.Point(127, 330)
        Me.lb_velocidadY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_velocidadY.Name = "lb_velocidadY"
        Me.lb_velocidadY.Size = New System.Drawing.Size(19, 13)
        Me.lb_velocidadY.TabIndex = 50
        Me.lb_velocidadY.Text = "---"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(11, 274)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Altura Maxima:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 248)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Desplazamiento X:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 201)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Tiempo Total:"
        '
        'lb_alturaM
        '
        Me.lb_alturaM.AutoSize = True
        Me.lb_alturaM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alturaM.ForeColor = System.Drawing.Color.Black
        Me.lb_alturaM.Location = New System.Drawing.Point(127, 274)
        Me.lb_alturaM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_alturaM.Name = "lb_alturaM"
        Me.lb_alturaM.Size = New System.Drawing.Size(19, 13)
        Me.lb_alturaM.TabIndex = 45
        Me.lb_alturaM.Text = "---"
        '
        'lb_dezplaX
        '
        Me.lb_dezplaX.AutoSize = True
        Me.lb_dezplaX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dezplaX.ForeColor = System.Drawing.Color.Black
        Me.lb_dezplaX.Location = New System.Drawing.Point(127, 248)
        Me.lb_dezplaX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_dezplaX.Name = "lb_dezplaX"
        Me.lb_dezplaX.Size = New System.Drawing.Size(19, 13)
        Me.lb_dezplaX.TabIndex = 44
        Me.lb_dezplaX.Text = "---"
        '
        'lb_tiempoAltura
        '
        Me.lb_tiempoAltura.AutoSize = True
        Me.lb_tiempoAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tiempoAltura.ForeColor = System.Drawing.Color.Black
        Me.lb_tiempoAltura.Location = New System.Drawing.Point(127, 224)
        Me.lb_tiempoAltura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tiempoAltura.Name = "lb_tiempoAltura"
        Me.lb_tiempoAltura.Size = New System.Drawing.Size(19, 13)
        Me.lb_tiempoAltura.TabIndex = 42
        Me.lb_tiempoAltura.Text = "---"
        '
        'lb_tiempoTotal
        '
        Me.lb_tiempoTotal.AutoSize = True
        Me.lb_tiempoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tiempoTotal.ForeColor = System.Drawing.Color.Black
        Me.lb_tiempoTotal.Location = New System.Drawing.Point(127, 201)
        Me.lb_tiempoTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tiempoTotal.Name = "lb_tiempoTotal"
        Me.lb_tiempoTotal.Size = New System.Drawing.Size(19, 13)
        Me.lb_tiempoTotal.TabIndex = 41
        Me.lb_tiempoTotal.Text = "---"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(11, 99)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_angulo
        '
        Me.txt_angulo.Location = New System.Drawing.Point(103, 60)
        Me.txt_angulo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_angulo.Name = "txt_angulo"
        Me.txt_angulo.Size = New System.Drawing.Size(71, 20)
        Me.txt_angulo.TabIndex = 37
        Me.txt_angulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Angulo:"
        '
        'txt_velocidad
        '
        Me.txt_velocidad.Location = New System.Drawing.Point(103, 35)
        Me.txt_velocidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_velocidad.Name = "txt_velocidad"
        Me.txt_velocidad.Size = New System.Drawing.Size(71, 20)
        Me.txt_velocidad.TabIndex = 35
        Me.txt_velocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Velocidad Inicial:"
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(103, 11)
        Me.txt_inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(71, 20)
        Me.txt_inicio.TabIndex = 31
        Me.txt_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Altura Inicial:"
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "PLAY"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 224)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Tiempo de altura:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(14, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Grafica
        '
        Me.Grafica.BackColor = System.Drawing.Color.DarkGray
        Me.Grafica.Location = New System.Drawing.Point(236, 11)
        Me.Grafica.Margin = New System.Windows.Forms.Padding(2)
        Me.Grafica.Name = "Grafica"
        Me.Grafica.Size = New System.Drawing.Size(432, 350)
        Me.Grafica.TabIndex = 29
        Me.Grafica.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 371)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lb_velocidadX)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lb_velocidadY)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lb_alturaM)
        Me.Controls.Add(Me.lb_dezplaX)
        Me.Controls.Add(Me.lb_tiempoAltura)
        Me.Controls.Add(Me.lb_tiempoTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_angulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_velocidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_inicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grafica)
        Me.Name = "Form1"
        Me.Text = "Tiro Parabolico"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents lb_velocidadX As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lb_velocidadY As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lb_alturaM As Label
    Friend WithEvents lb_dezplaX As Label
    Friend WithEvents lb_tiempoAltura As Label
    Friend WithEvents lb_tiempoTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_angulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_velocidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_inicio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Grafica As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
End Class
