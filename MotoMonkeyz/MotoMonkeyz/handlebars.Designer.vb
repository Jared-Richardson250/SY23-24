<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class handlebars
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HandlebarsBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MakeComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EngineBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WheelsBack = New System.Windows.Forms.Button()
        Me.GraphicsBack = New System.Windows.Forms.Button()
        Me.LeversBack = New System.Windows.Forms.Button()
        Me.GripsBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HandlebarsBack
        '
        Me.HandlebarsBack.Location = New System.Drawing.Point(9, 10)
        Me.HandlebarsBack.Margin = New System.Windows.Forms.Padding(2)
        Me.HandlebarsBack.Name = "HandlebarsBack"
        Me.HandlebarsBack.Size = New System.Drawing.Size(56, 19)
        Me.HandlebarsBack.TabIndex = 0
        Me.HandlebarsBack.Text = "Back"
        Me.HandlebarsBack.UseVisualStyleBackColor = True
        Me.HandlebarsBack.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(312, 280)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dirt Bike -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 316)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 39)
        Me.Label2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 327)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 19)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Add To Cart"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MakeComboBox
        '
        Me.MakeComboBox.FormattingEnabled = True
        Me.MakeComboBox.Items.AddRange(New Object() {"Honda", "Kawasaki", "Yamaha", "KTM", "Husqvarna"})
        Me.MakeComboBox.Location = New System.Drawing.Point(364, 278)
        Me.MakeComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MakeComboBox.Name = "MakeComboBox"
        Me.MakeComboBox.Size = New System.Drawing.Size(92, 21)
        Me.MakeComboBox.TabIndex = 5
        Me.MakeComboBox.Text = "Make"
        '
        'ModelComboBox
        '
        Me.ModelComboBox.FormattingEnabled = True
        Me.ModelComboBox.Location = New System.Drawing.Point(364, 302)
        Me.ModelComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelComboBox.Name = "ModelComboBox"
        Me.ModelComboBox.Size = New System.Drawing.Size(92, 21)
        Me.ModelComboBox.TabIndex = 6
        Me.ModelComboBox.Text = "Model"
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004"})
        Me.YearComboBox.Location = New System.Drawing.Point(364, 327)
        Me.YearComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(92, 21)
        Me.YearComboBox.TabIndex = 7
        Me.YearComboBox.Text = "Year"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Red", "Silver", "Orange", "Blue", "White", "Black", "Gold"})
        Me.ComboBox4.Location = New System.Drawing.Point(186, 277)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox4.TabIndex = 8
        Me.ComboBox4.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EngineBack
        '
        Me.EngineBack.Location = New System.Drawing.Point(9, 10)
        Me.EngineBack.Margin = New System.Windows.Forms.Padding(2)
        Me.EngineBack.Name = "EngineBack"
        Me.EngineBack.Size = New System.Drawing.Size(56, 19)
        Me.EngineBack.TabIndex = 10
        Me.EngineBack.Text = "Back"
        Me.EngineBack.UseVisualStyleBackColor = True
        Me.EngineBack.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(146, 24)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'WheelsBack
        '
        Me.WheelsBack.Location = New System.Drawing.Point(9, 11)
        Me.WheelsBack.Margin = New System.Windows.Forms.Padding(2)
        Me.WheelsBack.Name = "WheelsBack"
        Me.WheelsBack.Size = New System.Drawing.Size(56, 19)
        Me.WheelsBack.TabIndex = 11
        Me.WheelsBack.Text = "Back"
        Me.WheelsBack.UseVisualStyleBackColor = True
        Me.WheelsBack.Visible = False
        '
        'GraphicsBack
        '
        Me.GraphicsBack.Location = New System.Drawing.Point(9, 11)
        Me.GraphicsBack.Margin = New System.Windows.Forms.Padding(2)
        Me.GraphicsBack.Name = "GraphicsBack"
        Me.GraphicsBack.Size = New System.Drawing.Size(56, 19)
        Me.GraphicsBack.TabIndex = 12
        Me.GraphicsBack.Text = "Back"
        Me.GraphicsBack.UseVisualStyleBackColor = True
        Me.GraphicsBack.Visible = False
        '
        'LeversBack
        '
        Me.LeversBack.Location = New System.Drawing.Point(9, 11)
        Me.LeversBack.Margin = New System.Windows.Forms.Padding(2)
        Me.LeversBack.Name = "LeversBack"
        Me.LeversBack.Size = New System.Drawing.Size(56, 19)
        Me.LeversBack.TabIndex = 13
        Me.LeversBack.Text = "Back"
        Me.LeversBack.UseVisualStyleBackColor = True
        Me.LeversBack.Visible = False
        '
        'GripsBack
        '
        Me.GripsBack.Location = New System.Drawing.Point(23, 77)
        Me.GripsBack.Margin = New System.Windows.Forms.Padding(2)
        Me.GripsBack.Name = "GripsBack"
        Me.GripsBack.Size = New System.Drawing.Size(56, 19)
        Me.GripsBack.TabIndex = 14
        Me.GripsBack.Text = "Back"
        Me.GripsBack.UseVisualStyleBackColor = True
        Me.GripsBack.Visible = False
        '
        'handlebars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.GripsBack)
        Me.Controls.Add(Me.LeversBack)
        Me.Controls.Add(Me.GraphicsBack)
        Me.Controls.Add(Me.WheelsBack)
        Me.Controls.Add(Me.EngineBack)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.ModelComboBox)
        Me.Controls.Add(Me.MakeComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HandlebarsBack)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "handlebars"
        Me.Text = "handlebars"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HandlebarsBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents MakeComboBox As ComboBox
    Friend WithEvents ModelComboBox As ComboBox
    Friend WithEvents YearComboBox As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EngineBack As Button
    Friend WithEvents WheelsBack As Button
    Friend WithEvents GraphicsBack As Button
    Friend WithEvents LeversBack As Button
    Friend WithEvents GripsBack As Button
End Class
