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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.p9 = New System.Windows.Forms.PictureBox()
        Me.p8 = New System.Windows.Forms.PictureBox()
        Me.p7 = New System.Windows.Forms.PictureBox()
        Me.p6 = New System.Windows.Forms.PictureBox()
        Me.p5 = New System.Windows.Forms.PictureBox()
        Me.p4 = New System.Windows.Forms.PictureBox()
        Me.p3 = New System.Windows.Forms.PictureBox()
        Me.p2 = New System.Windows.Forms.PictureBox()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.p9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.p9)
        Me.Panel1.Controls.Add(Me.p8)
        Me.Panel1.Controls.Add(Me.p7)
        Me.Panel1.Controls.Add(Me.p6)
        Me.Panel1.Controls.Add(Me.p5)
        Me.Panel1.Controls.Add(Me.p4)
        Me.Panel1.Controls.Add(Me.p3)
        Me.Panel1.Controls.Add(Me.p2)
        Me.Panel1.Controls.Add(Me.p1)
        Me.Panel1.Location = New System.Drawing.Point(25, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 416)
        Me.Panel1.TabIndex = 0
        '
        'p9
        '
        Me.p9.Location = New System.Drawing.Point(410, 262)
        Me.p9.Name = "p9"
        Me.p9.Size = New System.Drawing.Size(144, 112)
        Me.p9.TabIndex = 8
        Me.p9.TabStop = False
        '
        'p8
        '
        Me.p8.Location = New System.Drawing.Point(213, 262)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(144, 112)
        Me.p8.TabIndex = 7
        Me.p8.TabStop = False
        '
        'p7
        '
        Me.p7.Location = New System.Drawing.Point(20, 262)
        Me.p7.Name = "p7"
        Me.p7.Size = New System.Drawing.Size(144, 112)
        Me.p7.TabIndex = 6
        Me.p7.TabStop = False
        '
        'p6
        '
        Me.p6.Location = New System.Drawing.Point(410, 144)
        Me.p6.Name = "p6"
        Me.p6.Size = New System.Drawing.Size(144, 112)
        Me.p6.TabIndex = 5
        Me.p6.TabStop = False
        '
        'p5
        '
        Me.p5.Location = New System.Drawing.Point(213, 144)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(144, 112)
        Me.p5.TabIndex = 4
        Me.p5.TabStop = False
        '
        'p4
        '
        Me.p4.Location = New System.Drawing.Point(20, 144)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(144, 112)
        Me.p4.TabIndex = 3
        Me.p4.TabStop = False
        '
        'p3
        '
        Me.p3.Location = New System.Drawing.Point(410, 26)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(144, 112)
        Me.p3.TabIndex = 2
        Me.p3.TabStop = False
        '
        'p2
        '
        Me.p2.Location = New System.Drawing.Point(213, 26)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(144, 112)
        Me.p2.TabIndex = 1
        Me.p2.TabStop = False
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(20, 26)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(144, 112)
        Me.p1.TabIndex = 0
        Me.p1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(162, 517)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(84, 26)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(28, 22)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(42, 46)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 555)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.p9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents p9 As System.Windows.Forms.PictureBox
    Friend WithEvents p8 As System.Windows.Forms.PictureBox
    Friend WithEvents p7 As System.Windows.Forms.PictureBox
    Friend WithEvents p6 As System.Windows.Forms.PictureBox
    Friend WithEvents p5 As System.Windows.Forms.PictureBox
    Friend WithEvents p4 As System.Windows.Forms.PictureBox
    Friend WithEvents p3 As System.Windows.Forms.PictureBox
    Friend WithEvents p2 As System.Windows.Forms.PictureBox
    Friend WithEvents p1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
