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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.l5 = New System.Windows.Forms.Label()
        Me.lb_velocidadX = New System.Windows.Forms.Label()
        Me.l6 = New System.Windows.Forms.Label()
        Me.lb_velocidadY = New System.Windows.Forms.Label()
        Me.l4 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
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
        Me.l2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Grafica = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup5 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.BackColor = System.Drawing.Color.Transparent
        Me.l5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.ForeColor = System.Drawing.Color.White
        Me.l5.Location = New System.Drawing.Point(17, 384)
        Me.l5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(124, 17)
        Me.l5.TabIndex = 53
        Me.l5.Text = "Velocidad Final X:"
        '
        'lb_velocidadX
        '
        Me.lb_velocidadX.AutoSize = True
        Me.lb_velocidadX.BackColor = System.Drawing.Color.Transparent
        Me.lb_velocidadX.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_velocidadX.ForeColor = System.Drawing.Color.White
        Me.lb_velocidadX.Location = New System.Drawing.Point(157, 385)
        Me.lb_velocidadX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_velocidadX.Name = "lb_velocidadX"
        Me.lb_velocidadX.Size = New System.Drawing.Size(23, 16)
        Me.lb_velocidadX.TabIndex = 52
        Me.lb_velocidadX.Text = "---"
        '
        'l6
        '
        Me.l6.AutoSize = True
        Me.l6.BackColor = System.Drawing.Color.Transparent
        Me.l6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l6.ForeColor = System.Drawing.Color.White
        Me.l6.Location = New System.Drawing.Point(17, 413)
        Me.l6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(123, 17)
        Me.l6.TabIndex = 51
        Me.l6.Text = "Velocidad Final Y:"
        '
        'lb_velocidadY
        '
        Me.lb_velocidadY.AutoSize = True
        Me.lb_velocidadY.BackColor = System.Drawing.Color.Transparent
        Me.lb_velocidadY.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_velocidadY.ForeColor = System.Drawing.Color.White
        Me.lb_velocidadY.Location = New System.Drawing.Point(157, 414)
        Me.lb_velocidadY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_velocidadY.Name = "lb_velocidadY"
        Me.lb_velocidadY.Size = New System.Drawing.Size(23, 16)
        Me.lb_velocidadY.TabIndex = 50
        Me.lb_velocidadY.Text = "---"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.BackColor = System.Drawing.Color.Transparent
        Me.l4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.ForeColor = System.Drawing.Color.White
        Me.l4.Location = New System.Drawing.Point(17, 357)
        Me.l4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(105, 17)
        Me.l4.TabIndex = 49
        Me.l4.Text = "Altura Maxima:"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.Color.Transparent
        Me.l3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(19, 331)
        Me.l3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(129, 17)
        Me.l3.TabIndex = 48
        Me.l3.Text = "Desplazamiento X:"
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.l1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(17, 284)
        Me.l1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(94, 17)
        Me.l1.TabIndex = 46
        Me.l1.Text = "Tiempo Total:"
        '
        'lb_alturaM
        '
        Me.lb_alturaM.AutoSize = True
        Me.lb_alturaM.BackColor = System.Drawing.Color.Transparent
        Me.lb_alturaM.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alturaM.ForeColor = System.Drawing.Color.White
        Me.lb_alturaM.Location = New System.Drawing.Point(157, 358)
        Me.lb_alturaM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_alturaM.Name = "lb_alturaM"
        Me.lb_alturaM.Size = New System.Drawing.Size(23, 16)
        Me.lb_alturaM.TabIndex = 45
        Me.lb_alturaM.Text = "---"
        '
        'lb_dezplaX
        '
        Me.lb_dezplaX.AutoSize = True
        Me.lb_dezplaX.BackColor = System.Drawing.Color.Transparent
        Me.lb_dezplaX.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_dezplaX.ForeColor = System.Drawing.Color.White
        Me.lb_dezplaX.Location = New System.Drawing.Point(157, 332)
        Me.lb_dezplaX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_dezplaX.Name = "lb_dezplaX"
        Me.lb_dezplaX.Size = New System.Drawing.Size(23, 16)
        Me.lb_dezplaX.TabIndex = 44
        Me.lb_dezplaX.Text = "---"
        '
        'lb_tiempoAltura
        '
        Me.lb_tiempoAltura.AutoSize = True
        Me.lb_tiempoAltura.BackColor = System.Drawing.Color.Transparent
        Me.lb_tiempoAltura.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tiempoAltura.ForeColor = System.Drawing.Color.White
        Me.lb_tiempoAltura.Location = New System.Drawing.Point(157, 308)
        Me.lb_tiempoAltura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tiempoAltura.Name = "lb_tiempoAltura"
        Me.lb_tiempoAltura.Size = New System.Drawing.Size(23, 16)
        Me.lb_tiempoAltura.TabIndex = 42
        Me.lb_tiempoAltura.Text = "---"
        '
        'lb_tiempoTotal
        '
        Me.lb_tiempoTotal.AutoSize = True
        Me.lb_tiempoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lb_tiempoTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_tiempoTotal.ForeColor = System.Drawing.Color.White
        Me.lb_tiempoTotal.Location = New System.Drawing.Point(157, 285)
        Me.lb_tiempoTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb_tiempoTotal.Name = "lb_tiempoTotal"
        Me.lb_tiempoTotal.Size = New System.Drawing.Size(23, 16)
        Me.lb_tiempoTotal.TabIndex = 41
        Me.lb_tiempoTotal.Text = "---"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(17, 182)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_angulo
        '
        Me.txt_angulo.Location = New System.Drawing.Point(139, 143)
        Me.txt_angulo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_angulo.Name = "txt_angulo"
        Me.txt_angulo.Size = New System.Drawing.Size(50, 20)
        Me.txt_angulo.TabIndex = 37
        Me.txt_angulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Ángulo:"
        '
        'txt_velocidad
        '
        Me.txt_velocidad.Location = New System.Drawing.Point(139, 118)
        Me.txt_velocidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_velocidad.Name = "txt_velocidad"
        Me.txt_velocidad.Size = New System.Drawing.Size(50, 20)
        Me.txt_velocidad.TabIndex = 35
        Me.txt_velocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Velocidad Inicial:"
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(139, 94)
        Me.txt_inicio.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.ReadOnly = True
        Me.txt_inicio.Size = New System.Drawing.Size(50, 20)
        Me.txt_inicio.TabIndex = 31
        Me.txt_inicio.Text = "0"
        Me.txt_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Altura Inicial:"
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.YellowGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(109, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 32)
        Me.Button3.TabIndex = 62
        Me.Button3.Text = "PLAY"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.l2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(17, 307)
        Me.l2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(122, 17)
        Me.l2.TabIndex = 63
        Me.l2.Text = "Tiempo de altura:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(17, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 32)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "STOP"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Grafica
        '
        Me.Grafica.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Grafica.Location = New System.Drawing.Point(242, 94)
        Me.Grafica.Margin = New System.Windows.Forms.Padding(2)
        Me.Grafica.Name = "Grafica"
        Me.Grafica.Size = New System.Drawing.Size(432, 350)
        Me.Grafica.TabIndex = 29
        Me.Grafica.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(159, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 56)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Tiro Parabólico"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.cross_circular_button
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(872, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Enabled = False
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3, Me.NavBarGroup4, Me.NavBarGroup5})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4, Me.NavBarItem5, Me.NavBarItem6, Me.NavBarItem7})
        Me.NavBarControl1.Location = New System.Drawing.Point(694, 118)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 213
        Me.NavBarControl1.Size = New System.Drawing.Size(213, 326)
        Me.NavBarControl1.TabIndex = 66
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "DESPLAZAMIENTO HORIZONTAL"
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = ""
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._3
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "ALTURA MAXIMA"
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem7)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = ""
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._1
        '
        'NavBarItem7
        '
        Me.NavBarItem7.Caption = ""
        Me.NavBarItem7.Name = "NavBarItem7"
        Me.NavBarItem7.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._2
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "TIEMPO SUBIDA"
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = ""
        Me.NavBarItem3.Name = "NavBarItem3"
        Me.NavBarItem3.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._6
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "VELOCIDAD EN X"
        Me.NavBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4)})
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = ""
        Me.NavBarItem4.Name = "NavBarItem4"
        Me.NavBarItem4.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._4
        '
        'NavBarGroup5
        '
        Me.NavBarGroup5.Caption = "VELOCIDAD EN Y"
        Me.NavBarGroup5.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem5)})
        Me.NavBarGroup5.Name = "NavBarGroup5"
        '
        'NavBarItem5
        '
        Me.NavBarItem5.Caption = ""
        Me.NavBarItem5.Name = "NavBarItem5"
        Me.NavBarItem5.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources._5
        '
        'NavBarItem6
        '
        Me.NavBarItem6.Caption = "NavBarItem6"
        Me.NavBarItem6.Name = "NavBarItem6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(694, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "FORMULAS UTILIZADAS"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.ProyectoGDA_FisicaI.My.Resources.Resources.back_arrow
        Me.PictureBox2.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(922, 465)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.lb_velocidadX)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.lb_velocidadY)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiro Parabolico"
        CType(Me.Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l5 As Label
    Friend WithEvents lb_velocidadX As Label
    Friend WithEvents l6 As Label
    Friend WithEvents lb_velocidadY As Label
    Friend WithEvents l4 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l1 As Label
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
    Friend WithEvents l2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup5 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem5 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents Label5 As Label
    Friend WithEvents NavBarItem6 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NavBarItem7 As DevExpress.XtraNavBar.NavBarItem
End Class
