<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusNorm = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusFC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.导出图片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入图片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.导入数据ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.前景色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.背景色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Norms = New System.Windows.Forms.ToolStripMenuItem()
        Me.Norm12864 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Norm128128 = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.命令集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(4, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(453, 268)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusNorm, Me.StatusFC, Me.StatusBC})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(907, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusNorm
        '
        Me.StatusNorm.Name = "StatusNorm"
        Me.StatusNorm.Size = New System.Drawing.Size(93, 17)
        Me.StatusNorm.Text = "规格：128 x 64"
        '
        'StatusFC
        '
        Me.StatusFC.Name = "StatusFC"
        Me.StatusFC.Size = New System.Drawing.Size(107, 17)
        Me.StatusFC.Text = "前景色：0XFFFFFF"
        '
        'StatusBC
        '
        Me.StatusBC.Name = "StatusBC"
        Me.StatusBC.Size = New System.Drawing.Size(107, 17)
        Me.StatusBC.Text = "背景色：0XFFFFFF"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem6, Me.Norms, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(907, 25)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripSeparator1, Me.ToolStripMenuItem3})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem1.Text = "文件"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem2.Text = "打开"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(97, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripMenuItem3.Text = "退出"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.导出图片ToolStripMenuItem, Me.导入图片ToolStripMenuItem, Me.导入数据ToolStripMenuItem})
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem4.Text = "工具"
        '
        '导出图片ToolStripMenuItem
        '
        Me.导出图片ToolStripMenuItem.Name = "导出图片ToolStripMenuItem"
        Me.导出图片ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.导出图片ToolStripMenuItem.Text = "导出图片..."
        '
        '导入图片ToolStripMenuItem
        '
        Me.导入图片ToolStripMenuItem.Name = "导入图片ToolStripMenuItem"
        Me.导入图片ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.导入图片ToolStripMenuItem.Text = "导入图片..."
        '
        '导入数据ToolStripMenuItem
        '
        Me.导入数据ToolStripMenuItem.Name = "导入数据ToolStripMenuItem"
        Me.导入数据ToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.导入数据ToolStripMenuItem.Text = "导入数据..."
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.前景色ToolStripMenuItem, Me.背景色ToolStripMenuItem})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(44, 21)
        Me.ToolStripMenuItem6.Text = "颜色"
        '
        '前景色ToolStripMenuItem
        '
        Me.前景色ToolStripMenuItem.Name = "前景色ToolStripMenuItem"
        Me.前景色ToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.前景色ToolStripMenuItem.Text = "前景色..."
        '
        '背景色ToolStripMenuItem
        '
        Me.背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem"
        Me.背景色ToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.背景色ToolStripMenuItem.Text = "背景色..."
        '
        'Norms
        '
        Me.Norms.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Norm12864, Me.Norm128128})
        Me.Norms.Name = "Norms"
        Me.Norms.Size = New System.Drawing.Size(44, 21)
        Me.Norms.Text = "规格"
        '
        'Norm12864
        '
        Me.Norm12864.Checked = True
        Me.Norm12864.CheckOnClick = True
        Me.Norm12864.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Norm12864.Name = "Norm12864"
        Me.Norm12864.Size = New System.Drawing.Size(132, 22)
        Me.Norm12864.Text = "128 x 64"
        '
        'Norm128128
        '
        Me.Norm128128.CheckOnClick = True
        Me.Norm128128.Name = "Norm128128"
        Me.Norm128128.Size = New System.Drawing.Size(132, 22)
        Me.Norm128128.Text = "128 x 128"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.命令集ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '命令集ToolStripMenuItem
        '
        Me.命令集ToolStripMenuItem.Name = "命令集ToolStripMenuItem"
        Me.命令集ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.命令集ToolStripMenuItem.Text = "命令集"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 413)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OLED"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 413)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "命令区"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 387)
        Me.Panel1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 429)
        Me.SplitContainer1.SplitterDistance = 556
        Me.SplitContainer1.TabIndex = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "System.Environment.CurrentDirectory"
        Me.OpenFileDialog1.Title = "导入数据"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 476)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OLED模拟器"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusNorm As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents 导出图片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Norms As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents 导入图片ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 导入数据ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents StatusFC As ToolStripStatusLabel
    Friend WithEvents StatusBC As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents 前景色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 背景色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Norm12864 As ToolStripMenuItem
    Friend WithEvents Norm128128 As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents 命令集ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
