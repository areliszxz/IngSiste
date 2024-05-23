<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Refresco Coca Cola $15"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Refresco Pepsi $15"}, 10, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Café americano $15"}, 5, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Café expreso $15"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Agua $20"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dona de chocolate $15"}, 9, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Dona de vainilla $15"}, 8, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Panini $25"}, 7, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Brownies $30"}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Galletas de chocolate $10"}, 6, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bebidasView = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AlimentosView = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Nmesa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Nmesero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button_total = New System.Windows.Forms.Button()
        Me.ListBox_cuenta = New System.Windows.Forms.ListBox()
        Me.TextBox_total = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nmesa)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nmesero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 558)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bebidasView)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(413, 54)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(393, 494)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Menú bebidas"
        '
        'bebidasView
        '
        Me.bebidasView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15})
        Me.bebidasView.LargeImageList = Me.ImageList1
        Me.bebidasView.Location = New System.Drawing.Point(6, 25)
        Me.bebidasView.MultiSelect = False
        Me.bebidasView.Name = "bebidasView"
        Me.bebidasView.Size = New System.Drawing.Size(371, 447)
        Me.bebidasView.SmallImageList = Me.ImageList1
        Me.bebidasView.TabIndex = 1
        Me.bebidasView.TileSize = New System.Drawing.Size(300, 44)
        Me.bebidasView.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "agua.png")
        Me.ImageList1.Images.SetKeyName(1, "americano.png")
        Me.ImageList1.Images.SetKeyName(2, "botella.png")
        Me.ImageList1.Images.SetKeyName(3, "brownies.png")
        Me.ImageList1.Images.SetKeyName(4, "duende.png")
        Me.ImageList1.Images.SetKeyName(5, "expresso.png")
        Me.ImageList1.Images.SetKeyName(6, "galletas.png")
        Me.ImageList1.Images.SetKeyName(7, "panini.png")
        Me.ImageList1.Images.SetKeyName(8, "rosquilla(1).png")
        Me.ImageList1.Images.SetKeyName(9, "rosquilla.png")
        Me.ImageList1.Images.SetKeyName(10, "soda.png")
        Me.ImageList1.Images.SetKeyName(11, "marca-de-verificacion.png")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AlimentosView)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 494)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Menú alimentos"
        '
        'AlimentosView
        '
        Me.AlimentosView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        Me.AlimentosView.LargeImageList = Me.ImageList1
        Me.AlimentosView.Location = New System.Drawing.Point(6, 25)
        Me.AlimentosView.MultiSelect = False
        Me.AlimentosView.Name = "AlimentosView"
        Me.AlimentosView.Size = New System.Drawing.Size(371, 447)
        Me.AlimentosView.SmallImageList = Me.ImageList1
        Me.AlimentosView.TabIndex = 1
        Me.AlimentosView.TileSize = New System.Drawing.Size(300, 44)
        Me.AlimentosView.UseCompatibleStateImageBehavior = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 435)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 12
        '
        'TextBox_Nmesa
        '
        Me.TextBox_Nmesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nmesa.Location = New System.Drawing.Point(296, 17)
        Me.TextBox_Nmesa.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Nmesa.Name = "TextBox_Nmesa"
        Me.TextBox_Nmesa.Size = New System.Drawing.Size(77, 32)
        Me.TextBox_Nmesa.TabIndex = 9
        Me.TextBox_Nmesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mesero:"
        '
        'TextBox_Nmesero
        '
        Me.TextBox_Nmesero.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nmesero.Location = New System.Drawing.Point(85, 14)
        Me.TextBox_Nmesero.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Nmesero.Name = "TextBox_Nmesero"
        Me.TextBox_Nmesero.Size = New System.Drawing.Size(76, 32)
        Me.TextBox_Nmesero.TabIndex = 7
        Me.TextBox_Nmesero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Numero de mesa:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(925, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 18)
        Me.Label6.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button_total)
        Me.GroupBox2.Controls.Add(Me.ListBox_cuenta)
        Me.GroupBox2.Controls.Add(Me.TextBox_total)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(842, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 442)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuenta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 405)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 24)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "$"
        '
        'Button_total
        '
        Me.Button_total.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_total.Location = New System.Drawing.Point(6, 400)
        Me.Button_total.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_total.Name = "Button_total"
        Me.Button_total.Size = New System.Drawing.Size(71, 36)
        Me.Button_total.TabIndex = 15
        Me.Button_total.Text = "Total"
        Me.Button_total.UseVisualStyleBackColor = False
        '
        'ListBox_cuenta
        '
        Me.ListBox_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_cuenta.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ListBox_cuenta.FormattingEnabled = True
        Me.ListBox_cuenta.ItemHeight = 16
        Me.ListBox_cuenta.Location = New System.Drawing.Point(5, 25)
        Me.ListBox_cuenta.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_cuenta.Name = "ListBox_cuenta"
        Me.ListBox_cuenta.ScrollAlwaysVisible = True
        Me.ListBox_cuenta.Size = New System.Drawing.Size(239, 356)
        Me.ListBox_cuenta.TabIndex = 16
        '
        'TextBox_total
        '
        Me.TextBox_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_total.Location = New System.Drawing.Point(134, 404)
        Me.TextBox_total.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.ReadOnly = True
        Me.TextBox_total.Size = New System.Drawing.Size(110, 28)
        Me.TextBox_total.TabIndex = 17
        Me.TextBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(988, 526)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 36)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Enviar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1103, 583)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Restaurante ""Los hermanos"""
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Nmesero As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Nmesa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents AlimentosView As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bebidasView As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button_total As System.Windows.Forms.Button
    Friend WithEvents ListBox_cuenta As System.Windows.Forms.ListBox
    Friend WithEvents TextBox_total As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
