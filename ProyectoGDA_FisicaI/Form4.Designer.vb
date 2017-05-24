<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup4 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(8, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(603, 56)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ejercicios tiro parabólico"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3, Me.NavBarGroup4})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3, Me.NavBarItem4})
        Me.NavBarControl1.Location = New System.Drawing.Point(12, 107)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 599
        Me.NavBarControl1.Size = New System.Drawing.Size(599, 384)
        Me.NavBarControl1.TabIndex = 2
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Ejercicio No. 1"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = ""
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.t1
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "Ejercicio No. 2"
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = ""
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.t2
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = "Ejercicio No. 3"
        Me.NavBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = ""
        Me.NavBarItem3.Name = "NavBarItem3"
        Me.NavBarItem3.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.t3
        '
        'NavBarGroup4
        '
        Me.NavBarGroup4.Caption = "Ejercicio No. 4"
        Me.NavBarGroup4.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem4)})
        Me.NavBarGroup4.Name = "NavBarGroup4"
        '
        'NavBarItem4
        '
        Me.NavBarItem4.Caption = ""
        Me.NavBarItem4.Name = "NavBarItem4"
        Me.NavBarItem4.SmallImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.t4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.ProyectoGDA_FisicaI.My.Resources.Resources.back_arrow
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(467, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 32)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "DEJAR TAREA"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoGDA_FisicaI.My.Resources.Resources.abstract_round_dots_dark_colors_1920x1080
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(633, 503)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup4 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem4 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
End Class
