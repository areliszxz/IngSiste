<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox_logo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_logo
        '
        Me.PictureBox_logo.Image = CType(resources.GetObject("PictureBox_logo.Image"), System.Drawing.Image)
        Me.PictureBox_logo.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox_logo.Name = "PictureBox_logo"
        Me.PictureBox_logo.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_logo.TabIndex = 0
        Me.PictureBox_logo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Los hermanos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nueva venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reporte de ventas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 330)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox_logo)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Los hermanos"
        CType(Me.PictureBox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
