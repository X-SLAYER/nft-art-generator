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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FoldersGroup = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutputImages = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLayers = New System.Windows.Forms.TextBox()
        Me.layersOrderGroup = New System.Windows.Forms.GroupBox()
        Me.Lv1 = New NFT_Art_Generator.ListViewCustomReorder.ListViewEx()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IM = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnGenerate = New System.Windows.Forms.Button()
        Me.Telegram = New System.Windows.Forms.LinkLabel()
        Me.Instagram = New System.Windows.Forms.LinkLabel()
        Me.linkedin = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FoldersGroup.SuspendLayout()
        Me.layersOrderGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'FoldersGroup
        '
        Me.FoldersGroup.Controls.Add(Me.Button2)
        Me.FoldersGroup.Controls.Add(Me.Label2)
        Me.FoldersGroup.Controls.Add(Me.txtOutputImages)
        Me.FoldersGroup.Controls.Add(Me.Button1)
        Me.FoldersGroup.Controls.Add(Me.Label1)
        Me.FoldersGroup.Controls.Add(Me.txtLayers)
        Me.FoldersGroup.Location = New System.Drawing.Point(12, 13)
        Me.FoldersGroup.Name = "FoldersGroup"
        Me.FoldersGroup.Size = New System.Drawing.Size(368, 191)
        Me.FoldersGroup.TabIndex = 0
        Me.FoldersGroup.TabStop = False
        Me.FoldersGroup.Text = "Folders"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 132)
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
        Me.Label2.Location = New System.Drawing.Point(3, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Layers"
        '
        'txtOutputImages
        '
        Me.txtOutputImages.Location = New System.Drawing.Point(6, 132)
        Me.txtOutputImages.Name = "txtOutputImages"
        Me.txtOutputImages.ReadOnly = True
        Me.txtOutputImages.Size = New System.Drawing.Size(266, 22)
        Me.txtOutputImages.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 58)
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
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Layers"
        '
        'txtLayers
        '
        Me.txtLayers.Location = New System.Drawing.Point(6, 58)
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
        'Lv1
        '
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
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
        Me.ColumnHeader2.Width = 212
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
        Me.BtnGenerate.Location = New System.Drawing.Point(12, 210)
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
        Me.Telegram.Location = New System.Drawing.Point(4, 293)
        Me.Telegram.Name = "Telegram"
        Me.Telegram.Size = New System.Drawing.Size(53, 14)
        Me.Telegram.TabIndex = 3
        Me.Telegram.TabStop = True
        Me.Telegram.Text = "Telegram"
        '
        'Instagram
        '
        Me.Instagram.AutoSize = True
        Me.Instagram.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instagram.Location = New System.Drawing.Point(92, 293)
        Me.Instagram.Name = "Instagram"
        Me.Instagram.Size = New System.Drawing.Size(57, 14)
        Me.Instagram.TabIndex = 4
        Me.Instagram.TabStop = True
        Me.Instagram.Text = "Instagram"
        '
        'linkedin
        '
        Me.linkedin.AutoSize = True
        Me.linkedin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkedin.Location = New System.Drawing.Point(185, 293)
        Me.linkedin.Name = "linkedin"
        Me.linkedin.Size = New System.Drawing.Size(54, 14)
        Me.linkedin.TabIndex = 5
        Me.linkedin.TabStop = True
        Me.linkedin.Text = "Facebook"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(275, 293)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(48, 14)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkedIn"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 322)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(692, 20)
        Me.ProgressBar1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 342)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.linkedin)
        Me.Controls.Add(Me.Instagram)
        Me.Controls.Add(Me.Telegram)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.layersOrderGroup)
        Me.Controls.Add(Me.FoldersGroup)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NFT Art Generator | By X-SLAYER"
        Me.FoldersGroup.ResumeLayout(False)
        Me.FoldersGroup.PerformLayout()
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
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents IM As ImageList
    Friend WithEvents Lv1 As ListViewCustomReorder.ListViewEx
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
