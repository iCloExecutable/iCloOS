<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ayarlar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ayarlar))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AyarlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCHakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GüncelleVeyaSıfırlaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeNotWorkingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(586, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PC Hakkında"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(511, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Güncelle veya sıfırla"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyarlarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AyarlarToolStripMenuItem
        '
        Me.AyarlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PCHakkındaToolStripMenuItem, Me.GüncelleVeyaSıfırlaToolStripMenuItem, Me.OtherSettingsToolStripMenuItem})
        Me.AyarlarToolStripMenuItem.Name = "AyarlarToolStripMenuItem"
        Me.AyarlarToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AyarlarToolStripMenuItem.Text = "Ayarlar"
        '
        'PCHakkındaToolStripMenuItem
        '
        Me.PCHakkındaToolStripMenuItem.Name = "PCHakkındaToolStripMenuItem"
        Me.PCHakkındaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PCHakkındaToolStripMenuItem.Text = "PC Hakkında"
        '
        'GüncelleVeyaSıfırlaToolStripMenuItem
        '
        Me.GüncelleVeyaSıfırlaToolStripMenuItem.Name = "GüncelleVeyaSıfırlaToolStripMenuItem"
        Me.GüncelleVeyaSıfırlaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GüncelleVeyaSıfırlaToolStripMenuItem.Text = "Güncelle veya sıfırla"
        '
        'OtherSettingsToolStripMenuItem
        '
        Me.OtherSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeNotWorkingToolStripMenuItem})
        Me.OtherSettingsToolStripMenuItem.Name = "OtherSettingsToolStripMenuItem"
        Me.OtherSettingsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.OtherSettingsToolStripMenuItem.Text = "Other Settings"
        '
        'TimeNotWorkingToolStripMenuItem
        '
        Me.TimeNotWorkingToolStripMenuItem.Name = "TimeNotWorkingToolStripMenuItem"
        Me.TimeNotWorkingToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TimeNotWorkingToolStripMenuItem.Text = "Time not working"
        '
        'ayarlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ayarlar"
        Me.Text = "Ayarlar"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AyarlarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PCHakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GüncelleVeyaSıfırlaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeNotWorkingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
