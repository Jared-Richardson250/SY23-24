<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2DPlatformer
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
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.TmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New PlatformerGame.Mover()
        Me.Mover2 = New PlatformerGame.Mover()
        Me.Mover3 = New PlatformerGame.Mover()
        Me.Mover4 = New PlatformerGame.Mover()
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.Color.Crimson
        Me.PicPlayer.Location = New System.Drawing.Point(1, 340)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(77, 66)
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'PicAir
        '
        Me.PicAir.BackColor = System.Drawing.Color.SkyBlue
        Me.PicAir.Location = New System.Drawing.Point(1, 0)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(1093, 406)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.LawnGreen
        Me.PicGround.Location = New System.Drawing.Point(1, 412)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(1093, 80)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'TmrRight
        '
        Me.TmrRight.Interval = 20
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 20
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 20
        '
        'TmrGameLogic
        '
        Me.TmrGameLogic.Interval = 20
        '
        'TmrGravity
        '
        Me.TmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PictureBox1.Location = New System.Drawing.Point(688, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Restart"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox2.Location = New System.Drawing.Point(98, 181)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "Collectable"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox3.Location = New System.Drawing.Point(39, 237)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(229, 34)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "Bounds"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox4.Location = New System.Drawing.Point(524, 181)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(229, 34)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "Bounds"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox5.Location = New System.Drawing.Point(39, 62)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(229, 34)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "Bounds"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Black
        Me.Mover1.ForeColor = System.Drawing.Color.Transparent
        Me.Mover1.Interval = 500
        Me.Mover1.Location = New System.Drawing.Point(344, 220)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(29, 28)
        Me.Mover1.Speed = 10
        Me.Mover1.Sprite = Nothing
        Me.Mover1.TabIndex = 8
        Me.Mover1.Tag = "Sprite"
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Black
        Me.Mover2.ForeColor = System.Drawing.Color.Transparent
        Me.Mover2.Interval = 500
        Me.Mover2.Location = New System.Drawing.Point(460, 242)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(29, 28)
        Me.Mover2.Speed = 10
        Me.Mover2.Sprite = Nothing
        Me.Mover2.TabIndex = 9
        Me.Mover2.Tag = "Sprite"
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Black
        Me.Mover3.ForeColor = System.Drawing.Color.Transparent
        Me.Mover3.Interval = 500
        Me.Mover3.Location = New System.Drawing.Point(607, 262)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(29, 28)
        Me.Mover3.Speed = 10
        Me.Mover3.Sprite = Nothing
        Me.Mover3.TabIndex = 10
        Me.Mover3.Tag = "Sprite"
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Black
        Me.Mover4.ForeColor = System.Drawing.Color.Transparent
        Me.Mover4.Interval = 500
        Me.Mover4.Location = New System.Drawing.Point(784, 287)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(29, 28)
        Me.Mover4.Speed = 10
        Me.Mover4.Sprite = Nothing
        Me.Mover4.TabIndex = 11
        Me.Mover4.Tag = "Sprite"
        '
        'Form2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 450)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PicPlayer)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PicAir)
        Me.Name = "Form2DPlatformer"
        Me.Text = "Platformer Game"
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents TmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents TmrGameLogic As Timer
    Friend WithEvents TmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents Mover2 As Mover
    Friend WithEvents Mover3 As Mover
    Friend WithEvents Mover4 As Mover
End Class
