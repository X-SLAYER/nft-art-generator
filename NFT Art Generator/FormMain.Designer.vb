<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.FoldersGroup = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nbSize = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutputImages = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLayers = New System.Windows.Forms.TextBox()
        Me.layersOrderGroup = New System.Windows.Forms.GroupBox()
        Me.IM = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.Telegram = New System.Windows.Forms.LinkLabel()
        Me.Instagram = New System.Windows.Forms.LinkLabel()
        Me.linkedin = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.Lv1 = New NFT_Art_Generator.ListViewCustomReorder.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FoldersGroup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nbSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layersOrderGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'FoldersGroup
        '
        Me.FoldersGroup.Controls.Add(Me.PictureBox1)
        Me.FoldersGroup.Controls.Add(Me.txtPrefix)
        Me.FoldersGroup.Controls.Add(Me.Label4)
        Me.FoldersGroup.Controls.Add(Me.nbSize)
        Me.FoldersGroup.Controls.Add(Me.Label3)
        Me.FoldersGroup.Controls.Add(Me.Button2)
        Me.FoldersGroup.Controls.Add(Me.Label2)
        Me.FoldersGroup.Controls.Add(Me.txtOutputImages)
        Me.FoldersGroup.Controls.Add(Me.Button1)
        Me.FoldersGroup.Controls.Add(Me.Label1)
        Me.FoldersGroup.Controls.Add(Me.txtLayers)
        Me.FoldersGroup.Location = New System.Drawing.Point(12, 13)
        Me.FoldersGroup.Name = "FoldersGroup"
        Me.FoldersGroup.Size = New System.Drawing.Size(368, 252)
        Me.FoldersGroup.TabIndex = 0
        Me.FoldersGroup.TabStop = False
        Me.FoldersGroup.Text = "Folders"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(236, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(68, 195)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(99, 22)
        Me.txtPrefix.TabIndex = 9
        Me.txtPrefix.Text = "SLAYER_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prefix : "
        '
        'nbSize
        '
        Me.nbSize.Location = New System.Drawing.Point(68, 145)
        Me.nbSize.Maximum = New Decimal(New Integer() {1569325055, 23283064, 0, 0})
        Me.nbSize.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nbSize.Name = "nbSize"
        Me.nbSize.Size = New System.Drawing.Size(99, 22)
        Me.nbSize.TabIndex = 7
        Me.nbSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nbSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NFT Size :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 99)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output"
        '
        'txtOutputImages
        '
        Me.txtOutputImages.Location = New System.Drawing.Point(6, 99)
        Me.txtOutputImages.Name = "txtOutputImages"
        Me.txtOutputImages.ReadOnly = True
        Me.txtOutputImages.Size = New System.Drawing.Size(266, 22)
        Me.txtOutputImages.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Layers"
        '
        'txtLayers
        '
        Me.txtLayers.Location = New System.Drawing.Point(6, 43)
        Me.txtLayers.Name = "txtLayers"
        Me.txtLayers.ReadOnly = True
        Me.txtLayers.Size = New System.Drawing.Size(266, 22)
        Me.txtLayers.TabIndex = 0
        '
        'layersOrderGroup
        '
        Me.layersOrderGroup.Controls.Add(Me.Lv1)
        Me.layersOrderGroup.Location = New System.Drawing.Point(398, 13)
        Me.layersOrderGroup.Name = "layersOrderGroup"
        Me.layersOrderGroup.Size = New System.Drawing.Size(283, 294)
        Me.layersOrderGroup.TabIndex = 1
        Me.layersOrderGroup.TabStop = False
        Me.layersOrderGroup.Text = "Layers Order"
        '
        'IM
        '
        Me.IM.ImageStream = CType(resources.GetObject("IM.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IM.TransparentColor = System.Drawing.Color.Transparent
        Me.IM.Images.SetKeyName(0, "layer.png")
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerate.Location = New System.Drawing.Point(12, 271)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(368, 36)
        Me.BtnGenerate.TabIndex = 2
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'Telegram
        '
        Me.Telegram.AutoSize = True
        Me.Telegram.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telegram.Location = New System.Drawing.Point(413, 312)
        Me.Telegram.Name = "Telegram"
        Me.Telegram.Size = New System.Drawing.Size(53, 14)
        Me.Telegram.TabIndex = 3
        Me.Telegram.TabStop = True
        Me.Telegram.Tag = "https://t.me/SLAYERS404"
        Me.Telegram.Text = "Telegram"
        '
        'Instagram
        '
        Me.Instagram.AutoSize = True
        Me.Instagram.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instagram.Location = New System.Drawing.Point(479, 312)
        Me.Instagram.Name = "Instagram"
        Me.Instagram.Size = New System.Drawing.Size(57, 14)
        Me.Instagram.TabIndex = 4
        Me.Instagram.TabStop = True
        Me.Instagram.Tag = "https://www.instagram.com/iiheb_/"
        Me.Instagram.Text = "Instagram"
        '
        'linkedin
        '
        Me.linkedin.AutoSize = True
        Me.linkedin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkedin.Location = New System.Drawing.Point(549, 312)
        Me.linkedin.Name = "linkedin"
        Me.linkedin.Size = New System.Drawing.Size(54, 14)
        Me.linkedin.TabIndex = 5
        Me.linkedin.TabStop = True
        Me.linkedin.Tag = "https://www.facebook.com/iih3b/"
        Me.linkedin.Text = "Facebook"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(616, 312)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(40, 14)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Tag = "https://github.com/X-SLAYER"
        Me.LinkLabel1.Text = "Github"
        '
        'pBar
        '
        Me.pBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBar.Location = New System.Drawing.Point(0, 333)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(692, 20)
        Me.pBar.TabIndex = 7
        '
        'Lv1
        '
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv1.FullRowSelect = True
        Me.Lv1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.Lv1.HideSelection = False
        Me.Lv1.LargeImageList = Me.IM
        Me.Lv1.LineAfter = -1
        Me.Lv1.LineBefore = -1
        Me.Lv1.Location = New System.Drawing.Point(3, 18)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(277, 273)
        Me.Lv1.SmallImageList = Me.IM
        Me.Lv1.TabIndex = 0
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 161
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Count"
        Me.ColumnHeader3.Width = 51
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 353)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.linkedin)
        Me.Controls.Add(Me.Instagram)
        Me.Controls.Add(Me.Telegram)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.layersOrderGroup)
        Me.Controls.Add(Me.FoldersGroup)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NFT Art Generator | By X-SLAYER"
        Me.FoldersGroup.ResumeLayout(False)
        Me.FoldersGroup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nbSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layersOrderGroup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FoldersGroup As GroupBox
    Friend WithEvents txtLayers As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutputImages As TextBox
    Friend WithEvents layersOrderGroup As GroupBox
    Friend WithEvents BtnGenerate As Button
    Friend WithEvents Telegram As LinkLabel
    Friend WithEvents Instagram As LinkLabel
    Friend WithEvents linkedin As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents pBar As ProgressBar
    Friend WithEvents IM As ImageList
    Friend WithEvents Lv1 As ListViewCustomReorder.ListViewEx
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents nbSize As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrefix As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
