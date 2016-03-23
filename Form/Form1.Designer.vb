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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChooseNetDisk = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseOpacity = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpacityMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Percent_100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent_90 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent_75 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent_50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent_25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IsTopMost = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.OpacityMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label1.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0.0KB/s-0.0KB/s"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseNetDisk, Me.ChooseOpacity, Me.IsTopMost, Me.ToolStripSeparator1, Me.ExitTool})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowCheckMargin = True
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 130)
        '
        'ChooseNetDisk
        '
        Me.ChooseNetDisk.Name = "ChooseNetDisk"
        Me.ChooseNetDisk.Size = New System.Drawing.Size(160, 30)
        Me.ChooseNetDisk.Text = "选择网卡"
        '
        'ChooseOpacity
        '
        Me.ChooseOpacity.DropDown = Me.OpacityMenu
        Me.ChooseOpacity.Name = "ChooseOpacity"
        Me.ChooseOpacity.Size = New System.Drawing.Size(160, 30)
        Me.ChooseOpacity.Text = "透明度"
        '
        'OpacityMenu
        '
        Me.OpacityMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Percent_100, Me.Percent_90, Me.Percent_75, Me.Percent_50, Me.Percent_25})
        Me.OpacityMenu.Name = "OpacityMenu"
        Me.OpacityMenu.Size = New System.Drawing.Size(135, 154)
        '
        'Percent_100
        '
        Me.Percent_100.Name = "Percent_100"
        Me.Percent_100.Size = New System.Drawing.Size(134, 30)
        Me.Percent_100.Tag = "100"
        Me.Percent_100.Text = "100%"
        '
        'Percent_90
        '
        Me.Percent_90.Name = "Percent_90"
        Me.Percent_90.Size = New System.Drawing.Size(134, 30)
        Me.Percent_90.Tag = "90"
        Me.Percent_90.Text = "90%"
        '
        'Percent_75
        '
        Me.Percent_75.Name = "Percent_75"
        Me.Percent_75.Size = New System.Drawing.Size(134, 30)
        Me.Percent_75.Tag = "75"
        Me.Percent_75.Text = "75%"
        '
        'Percent_50
        '
        Me.Percent_50.Name = "Percent_50"
        Me.Percent_50.Size = New System.Drawing.Size(134, 30)
        Me.Percent_50.Tag = "50"
        Me.Percent_50.Text = "50%"
        '
        'Percent_25
        '
        Me.Percent_25.Name = "Percent_25"
        Me.Percent_25.Size = New System.Drawing.Size(134, 30)
        Me.Percent_25.Tag = "25"
        Me.Percent_25.Text = "25%"
        '
        'IsTopMost
        '
        Me.IsTopMost.Name = "IsTopMost"
        Me.IsTopMost.Size = New System.Drawing.Size(160, 30)
        Me.IsTopMost.Text = "窗体置顶"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ExitTool
        '
        Me.ExitTool.Name = "ExitTool"
        Me.ExitTool.Size = New System.Drawing.Size(160, 30)
        Me.ExitTool.Text = "退出"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(223, 40)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.OpacityMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChooseNetDisk As ToolStripMenuItem
    Friend WithEvents IsTopMost As ToolStripMenuItem
    Friend WithEvents ExitTool As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChooseOpacity As ToolStripMenuItem
    Friend WithEvents OpacityMenu As ContextMenuStrip
    Friend WithEvents Percent_100 As ToolStripMenuItem
    Friend WithEvents Percent_90 As ToolStripMenuItem
    Friend WithEvents Percent_75 As ToolStripMenuItem
    Friend WithEvents Percent_50 As ToolStripMenuItem
    Friend WithEvents Percent_25 As ToolStripMenuItem
End Class
