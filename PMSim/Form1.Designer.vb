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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.VL = New System.Windows.Forms.Label()
        Me.VV = New System.Windows.Forms.Panel()
        Me.XYcoord = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.PictureBox()
        Me.Tools = New System.Windows.Forms.Panel()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Th = New System.Windows.Forms.TextBox()
        Me.AccG = New System.Windows.Forms.TextBox()
        Me.V = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.XYcoord.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResetButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tools.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.VL)
        Me.Panel2.Controls.Add(Me.VV)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 472)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.ListBox3)
        Me.Panel4.Controls.Add(Me.ListBox2)
        Me.Panel4.Controls.Add(Me.ListBox1)
        Me.Panel4.Location = New System.Drawing.Point(365, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(431, 393)
        Me.Panel4.TabIndex = 2
        Me.Panel4.Visible = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(15, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(49, 155)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(340, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(200, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(91, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "T"
        '
        'ListBox3
        '
        Me.ListBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ListBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(285, 35)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(134, 299)
        Me.ListBox3.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(147, 35)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(132, 299)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(70, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(71, 299)
        Me.ListBox1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Location = New System.Drawing.Point(0, 294)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(26, 26)
        Me.Panel3.TabIndex = 1
        '
        'VL
        '
        Me.VL.AutoSize = True
        Me.VL.Location = New System.Drawing.Point(35, 294)
        Me.VL.Name = "VL"
        Me.VL.Size = New System.Drawing.Size(54, 13)
        Me.VL.TabIndex = 4
        Me.VL.Text = "50 ua / ut"
        '
        'VV
        '
        Me.VV.BackColor = System.Drawing.SystemColors.MenuText
        Me.VV.Location = New System.Drawing.Point(35, 310)
        Me.VV.Name = "VV"
        Me.VV.Size = New System.Drawing.Size(200, 2)
        Me.VV.TabIndex = 3
        '
        'XYcoord
        '
        Me.XYcoord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XYcoord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.XYcoord.BackgroundImage = CType(resources.GetObject("XYcoord.BackgroundImage"), System.Drawing.Image)
        Me.XYcoord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XYcoord.Controls.Add(Me.PictureBox1)
        Me.XYcoord.Controls.Add(Me.L1)
        Me.XYcoord.Controls.Add(Me.ResetButton)
        Me.XYcoord.Location = New System.Drawing.Point(602, 0)
        Me.XYcoord.Name = "XYcoord"
        Me.XYcoord.Size = New System.Drawing.Size(194, 44)
        Me.XYcoord.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(45, 4)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(100, 27)
        Me.L1.TabIndex = 1
        Me.L1.Text = "X :    Y :    "
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.Transparent
        Me.ResetButton.BackgroundImage = CType(resources.GetObject("ResetButton.BackgroundImage"), System.Drawing.Image)
        Me.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ResetButton.Location = New System.Drawing.Point(13, 4)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(26, 27)
        Me.ResetButton.TabIndex = 0
        Me.ResetButton.TabStop = False
        '
        'Tools
        '
        Me.Tools.BackColor = System.Drawing.Color.LightGray
        Me.Tools.Controls.Add(Me.TrackBar1)
        Me.Tools.Controls.Add(Me.Label1)
        Me.Tools.Controls.Add(Me.Th)
        Me.Tools.Controls.Add(Me.AccG)
        Me.Tools.Controls.Add(Me.V)
        Me.Tools.Controls.Add(Me.Label4)
        Me.Tools.Controls.Add(Me.Label3)
        Me.Tools.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tools.Location = New System.Drawing.Point(0, 475)
        Me.Tools.Margin = New System.Windows.Forms.Padding(0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(796, 45)
        Me.Tools.TabIndex = 1
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TrackBar1.Location = New System.Drawing.Point(679, 3)
        Me.TrackBar1.Maximum = 4
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(114, 39)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(595, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Time Speed"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Th
        '
        Me.Th.Location = New System.Drawing.Point(288, 13)
        Me.Th.Name = "Th"
        Me.Th.Size = New System.Drawing.Size(73, 20)
        Me.Th.TabIndex = 6
        Me.Th.Text = "0"
        '
        'AccG
        '
        Me.AccG.Location = New System.Drawing.Point(194, 13)
        Me.AccG.Name = "AccG"
        Me.AccG.Size = New System.Drawing.Size(73, 20)
        Me.AccG.TabIndex = 5
        Me.AccG.Text = "9.8"
        '
        'V
        '
        Me.V.Location = New System.Drawing.Point(73, 13)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(73, 20)
        Me.V.TabIndex = 4
        Me.V.Text = "50"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 45)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "G : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 45)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Velocity : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(796, 520)
        Me.Controls.Add(Me.XYcoord)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "PMSim - Projectile Motion Calculator and Simulator"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.XYcoord.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResetButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents XYcoord As Panel
    Friend WithEvents Tools As Panel
    Friend WithEvents ResetButton As PictureBox
    Friend WithEvents L1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AccG As TextBox
    Friend WithEvents V As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Th As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents VV As Panel
    Friend WithEvents VL As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
End Class
