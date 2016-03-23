Public Class Form1
    Private MyAdapters() As NetworkAdapter
    Private MyMonitor As NetworkMonitor
    Private SelectedIndex As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitMenu()
        MenuPercent_Click(Percent_75, Nothing)
        MenuIsTopMost_Click(Nothing, Nothing)
        Me.Top = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tempAdapter As NetworkAdapter = MyAdapters(SelectedIndex)
        Label1.Text = tempAdapter.DownloadSpeedString & "-" & tempAdapter.UploadSpeedString
    End Sub

    Dim OldX, OldY, OldFormX, OldFormY As Integer
    Dim oldLocation As Point
    Dim IsMouseDown As Boolean
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        IsMouseDown = True
        OldFormX = Me.Location.X
        OldFormY = Me.Location.Y
        OldX = Cursor.Position.X
        OldY = Cursor.Position.Y
    End Sub
    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        IsMouseDown = False
        If Me.Top < My.Computer.Screen.WorkingArea.Size.Height / 2 Then
            Me.Top = 0
        Else
            Me.Top = My.Computer.Screen.WorkingArea.Size.Height - Label1.Height
        End If
        If Me.Left < 0 Then
            Me.Left = 0
        ElseIf Me.Left > My.Computer.Screen.WorkingArea.Width - Me.Width Then
            Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        End If
        If e.Button = MouseButtons.Right Then
            Label1.ContextMenuStrip.Show()
        End If
    End Sub
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If IsMouseDown Then
            Me.Location = New Point(OldFormX + Cursor.Position.X - OldX, OldFormY + Cursor.Position.Y - OldY)
        End If
    End Sub

    Private Sub InitMenu()
        MyMonitor = New NetworkMonitor
        MyAdapters = MyMonitor.Adapters
        Dim TempMenuStrip As ToolStripMenuItem = ContextMenuStrip1.Items(0)
        If MyAdapters.Count > 0 Then
            For i = 0 To MyAdapters.Count - 1
                TempMenuStrip.DropDownItems.Add(MyAdapters(i).ToString)
                AddHandler TempMenuStrip.DropDownItems(i).Click, AddressOf MenuNetDisk_Click
            Next
        End If
        ChangeSelectedIndex(-1)
    End Sub
    Private Sub ChangeSelectedIndex(NewIndex As Integer)
        If NewIndex = -1 Then
            For i = 0 To MyAdapters.Count - 1
                If Mid(MyAdapters(i).ToString, 1, 7) = "Realtek" Then
                    'SelectedIndex = i
                    Dim TempMenuStrip As ToolStripMenuItem = ContextMenuStrip1.Items(0)
                    MenuNetDisk_Click(TempMenuStrip.DropDownItems(i), New EventArgs)
                    Exit Sub
                End If
            Next
            If SelectedIndex = -1 Then Exit Sub
        Else
            SelectedIndex = NewIndex
        End If
        MyMonitor.StopMonitoring()
        MyMonitor.StartMonitoring(MyAdapters(SelectedIndex))
        Timer1.Start()
    End Sub

    Private Sub MenuNetDisk_Click(sender As ToolStripMenuItem, e As EventArgs)
        Dim TempMenuStrip As ToolStripMenuItem = ContextMenuStrip1.Items(0)
        For Each SubItem In TempMenuStrip.DropDownItems
            SubItem.checked = False
        Next
        sender.Checked = True
        ChangeSelectedIndex(TempMenuStrip.DropDownItems.IndexOf(sender))
    End Sub
    Private Sub MenuPercent_Click(sender As ToolStripMenuItem, e As EventArgs) Handles Percent_25.Click, Percent_50.Click, Percent_75.Click, Percent_90.Click, Percent_100.Click
        For Each SubItem In OpacityMenu.Items
            SubItem.checked = False
        Next
        sender.Checked = True
        Me.Opacity = sender.Tag / 100
    End Sub
    Private Sub MenuIsTopMost_Click(sender As Object, e As EventArgs) Handles IsTopMost.Click
        IsTopMost.Checked = Not IsTopMost.Checked
        Me.TopMost = IsTopMost.Checked
    End Sub
    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub
End Class
