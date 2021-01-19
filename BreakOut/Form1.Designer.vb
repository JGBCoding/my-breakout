<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pb_barra = New System.Windows.Forms.PictureBox()
        Me.pb_block1 = New System.Windows.Forms.PictureBox()
        Me.pb_bola = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pb_deathzone = New System.Windows.Forms.PictureBox()
        Me.pb_block2 = New System.Windows.Forms.PictureBox()
        Me.pb_block4 = New System.Windows.Forms.PictureBox()
        Me.pb_block3 = New System.Windows.Forms.PictureBox()
        Me.pb_block5 = New System.Windows.Forms.PictureBox()
        CType(Me.pb_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_block1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_bola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_deathzone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_block2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_block4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_block3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_block5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_barra
        '
        Me.pb_barra.Image = CType(resources.GetObject("pb_barra.Image"), System.Drawing.Image)
        Me.pb_barra.Location = New System.Drawing.Point(327, 393)
        Me.pb_barra.Name = "pb_barra"
        Me.pb_barra.Size = New System.Drawing.Size(113, 16)
        Me.pb_barra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_barra.TabIndex = 0
        Me.pb_barra.TabStop = False
        '
        'pb_block1
        '
        Me.pb_block1.Image = CType(resources.GetObject("pb_block1.Image"), System.Drawing.Image)
        Me.pb_block1.Location = New System.Drawing.Point(338, 130)
        Me.pb_block1.Name = "pb_block1"
        Me.pb_block1.Size = New System.Drawing.Size(66, 16)
        Me.pb_block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_block1.TabIndex = 1
        Me.pb_block1.TabStop = False
        '
        'pb_bola
        '
        Me.pb_bola.Image = CType(resources.GetObject("pb_bola.Image"), System.Drawing.Image)
        Me.pb_bola.Location = New System.Drawing.Point(370, 366)
        Me.pb_bola.Name = "pb_bola"
        Me.pb_bola.Size = New System.Drawing.Size(23, 21)
        Me.pb_bola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_bola.TabIndex = 2
        Me.pb_bola.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pb_deathzone
        '
        Me.pb_deathzone.Image = CType(resources.GetObject("pb_deathzone.Image"), System.Drawing.Image)
        Me.pb_deathzone.Location = New System.Drawing.Point(-1, 415)
        Me.pb_deathzone.Name = "pb_deathzone"
        Me.pb_deathzone.Size = New System.Drawing.Size(803, 12)
        Me.pb_deathzone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_deathzone.TabIndex = 4
        Me.pb_deathzone.TabStop = False
        '
        'pb_block2
        '
        Me.pb_block2.Image = CType(resources.GetObject("pb_block2.Image"), System.Drawing.Image)
        Me.pb_block2.Location = New System.Drawing.Point(468, 130)
        Me.pb_block2.Name = "pb_block2"
        Me.pb_block2.Size = New System.Drawing.Size(66, 16)
        Me.pb_block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_block2.TabIndex = 5
        Me.pb_block2.TabStop = False
        '
        'pb_block4
        '
        Me.pb_block4.Image = CType(resources.GetObject("pb_block4.Image"), System.Drawing.Image)
        Me.pb_block4.Location = New System.Drawing.Point(289, 41)
        Me.pb_block4.Name = "pb_block4"
        Me.pb_block4.Size = New System.Drawing.Size(66, 16)
        Me.pb_block4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_block4.TabIndex = 6
        Me.pb_block4.TabStop = False
        '
        'pb_block3
        '
        Me.pb_block3.Image = CType(resources.GetObject("pb_block3.Image"), System.Drawing.Image)
        Me.pb_block3.Location = New System.Drawing.Point(613, 41)
        Me.pb_block3.Name = "pb_block3"
        Me.pb_block3.Size = New System.Drawing.Size(66, 16)
        Me.pb_block3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_block3.TabIndex = 7
        Me.pb_block3.TabStop = False
        '
        'pb_block5
        '
        Me.pb_block5.Image = CType(resources.GetObject("pb_block5.Image"), System.Drawing.Image)
        Me.pb_block5.Location = New System.Drawing.Point(112, 149)
        Me.pb_block5.Name = "pb_block5"
        Me.pb_block5.Size = New System.Drawing.Size(66, 16)
        Me.pb_block5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_block5.TabIndex = 8
        Me.pb_block5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 465)
        Me.Controls.Add(Me.pb_block5)
        Me.Controls.Add(Me.pb_block3)
        Me.Controls.Add(Me.pb_block4)
        Me.Controls.Add(Me.pb_block2)
        Me.Controls.Add(Me.pb_deathzone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pb_bola)
        Me.Controls.Add(Me.pb_block1)
        Me.Controls.Add(Me.pb_barra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_barra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_block1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_bola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_deathzone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_block2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_block4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_block3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_block5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_barra As PictureBox
    Friend WithEvents pb_block1 As PictureBox
    Friend WithEvents pb_bola As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents pb_deathzone As PictureBox
    Friend WithEvents pb_block2 As PictureBox
    Friend WithEvents pb_block4 As PictureBox
    Friend WithEvents pb_block3 As PictureBox
    Friend WithEvents pb_block5 As PictureBox
End Class
