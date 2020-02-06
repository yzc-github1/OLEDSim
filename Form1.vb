'作者：YZC
'时间：2020.2.7.1:03
'描述：OLED模拟器
'要点：
'1.将CMD窗体嵌入到界面中，还需要对CMD做进一步的控制
'2.将16进制的数组数据显示显示到OLED上
'
Imports System.ComponentModel
Imports System.Threading
Public Class Form1

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Private Declare Function GetConsoleWindow Lib "Kernel32" Alias "GetConsoleWindow" () As IntPtr
    Private Declare Function SetParent Lib "user32" Alias "SetParent" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Int32
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32
    Private Declare Function DestroyWindow Lib "user32.dll" Alias "DestroyWindow" (ByVal hwnd As IntPtr) As Boolean
    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As IntPtr, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Int32) As Int32
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As IntPtr, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As IntPtr, ByVal nIndex As Int32, ByVal dwNewLong As Integer) As Integer
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As IntPtr, ByVal nIndex As Int32) As Integer

    Private Const WM_SYSCOMMAND As Int32 = &H112
    Private Const SC_MAXIMIZE As Int32 = &HF030
    Private Const SC_MINIMIZE As Int32 = &HF020
    Private Const SC_RESTORE As Int32 = &HF120
    Public Const SW_HIDE = 0
    Public Const SW_SHOW = 5
    Public Const GWL_STYLE As Int32 = -16
    Public Const WS_CAPTION As Integer = &HC00000
    '定义OLED相关变量
    Dim WNumMax As UInt32 = 256
    Dim HNumMax As UInt32 = 256
    Dim DotW As UInt32 = 4 ' OLED的点的宽度， 单位：像素
    Dim DotH As UInt32 = 4 ' OLED的点的高度， 单位：像素
    Dim WNum As UInt32 = 128 '  OLED的点的列数
    Dim HNum As UInt32 = 64 ' OLED的点的行数
    Dim WSize As UInt32 'OLED的实际宽度
    Dim HSize As UInt32 'OLED的实际高度
    Dim XSpace As UInt32 = 0 'X方向Dot的间隔
    Dim YSpace As UInt32 = 0 'Y方向Dot的间隔
    Dim BorderW As UInt32 = 10
    Dim DotColor As Color = Color.Blue 'Dot的颜色
    Dim BorderColor As Color = Color.Black 'Dot的边界的颜色
    '绘图变量
    Dim dirXPoint(2 * WNum + 1) As Point '每个dot的X方向分界线
    Dim dirYPoint(2 * HNum + 1) As Point '每个Dot的Y方向分界线
    Dim DotValue(HNum - 1, WNum - 1) As UInt32 'Dot的矩阵数组
    Dim DotHexValue(8 - 1, 128 - 1) As UInt32 'Dot的16进制数组
    '画布
    Dim myG As Graphics
    Dim myPen As Pen
    Dim myBrush As SolidBrush
    '
    Dim hwndCmd As IntPtr
    Dim pCmd As New Process
    '临时变量
    Dim i, j, k, m, n, p As UInt32

    Private Sub 导入数据ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 导入数据ToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fs = New IO.StreamReader(OpenFileDialog1.FileName)
            Dim st As String
            Dim n As UInt32 = 0
            Dim sts() As String
            While True
                st = fs.ReadLine()
                If st = Nothing Then
                    Exit While
                End If
                st = st.Replace(" ", "").Replace("0x", "").Replace("0X", "")
                sts = st.Split(",")
                For Each x As String In sts
                    If (x <> Nothing) Then
                        DotHexValue(n \ 128, n Mod 128) = Convert.ToUInt32(x, 16)
                        n += 1
                    End If
                Next
            End While
            fs.Close()
            parseData()
            PictureBox1.Invalidate()
        End If
    End Sub
    Private Sub 前景色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 前景色ToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        DotColor = ColorDialog1.Color
        myBrush.Color = DotColor
        PictureBox1.Invalidate()
        StatusFC.ForeColor = DotColor
        StatusFC.Text = "前景色：" & ColorToString(DotColor)
    End Sub

    Private Sub 背景色ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 背景色ToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        BorderColor = ColorDialog1.Color
        PictureBox1.BackColor = BorderColor
        PictureBox1.Invalidate()
        StatusBC.ForeColor = BorderColor
        StatusBC.Text = "背景色：" & ColorToString(BorderColor)
    End Sub

    Private Sub Norm12864_Click(sender As Object, e As EventArgs) Handles Norm12864.Click
        Norm12864.Checked = True
        Norm128128.Checked = False
        StatusNorm.Text = "规格：128 x 64"
    End Sub

    Private Sub Norm128128_Click(sender As Object, e As EventArgs) Handles Norm128128.Click
        Norm128128.Checked = True
        Norm12864.Checked = False
        StatusNorm.Text = "规格：128 x 128"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '界面初始化
        If Norm12864.Checked = True Then
            StatusNorm.Text = "规格：128 x 64"
        ElseIf Norm128128.Checked = True Then
            StatusNorm.Text = "规格：128 x 128"
        Else
            StatusNorm.Text = "规格：错误！！！"
        End If
        StatusFC.ForeColor = DotColor
        StatusFC.Text = "前景色：" & ColorToString(DotColor)
        StatusBC.ForeColor = BorderColor
        StatusBC.Text = "背景色：" & ColorToString(BorderColor)
        '变量初始化
        WSize = DotW * WNum + XSpace * (WNum + 1) + 2 * BorderW
        HSize = DotH * HNum + YSpace * (HNum + 1) + 2 * BorderW
        '画布初始化
        myPen = New Pen(BorderColor, XSpace)
        myBrush = New SolidBrush(DotColor)
        PictureBox1.Size = New Size(WSize, HSize)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        '运行变量初始化
        'ShellExecute(Me.Panel1.Handle, "open", "c:\windows\system32\cmd.exe", Nothing, ".", SW_HIDE)
        'hwndCmd = FindWindow(Nothing, "c:\windows\system32\cmd.exe")
        'While hwndCmd = 0

        'End While
        'Console.WriteLine(hwndCmd)
        pCmd.StartInfo.FileName = "cmd.exe"
        pCmd.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Dim x As UInt32 = 0
        While pCmd.Start() = False
        End While
        While pCmd.MainWindowHandle = 0
        End While
        hwndCmd = pCmd.MainWindowHandle
        SetParent(hwndCmd, Me.Panel1.Handle)
        SendMessage(hwndCmd, WM_SYSCOMMAND, SC_MAXIMIZE, 0)
        SetWindowLong(hwndCmd, GWL_STYLE, GetWindowLong(hwndCmd, GWL_STYLE) And (Not WS_CAPTION))

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        myG = e.Graphics
        For i = 0 To HNum - 1
            For j = 0 To WNum - 1
                If DotValue(i, j) = 1 Then
                    myG.FillRectangle(myBrush, BorderW - 1 + m + j * (DotW + XSpace), BorderW - 1 + m + i * (DotH + YSpace), DotW, DotH)
                End If
            Next
        Next
        'myG.DrawLines(myPen, dirXPoint)
        'myG.DrawLines(myPen, dirYPoint)
        'myG.DrawEllipse(myPen, 0, 0, 50, 50)
        'myPen.Width = 50
        'myG.DrawLine(myPen, 0, 50, 100, 50)

    End Sub

    Private Function parseData() '将DotHexValue解析为DotValue
        For i As UInt32 = 0 To 7
            For j As UInt32 = 0 To 127
                For k As UInt32 = 0 To 7
                    If (DotHexValue(i, j) And (1 << k)) Then
                        DotValue(i * 8 + k, j) = 1
                    Else
                        DotValue(i * 8 + k, j) = 0
                    End If
                Next
            Next
        Next
    End Function
    Private Function CodeData() '将DotValue编码为DotHexValue

    End Function
    Private Function ColorToString(c As Color) As String
        Dim x, y As String
        x = Convert.ToString(c.A, 16)
        If Len(x) = 1 Then
            x += "0"
        End If
        y += x
        x = Convert.ToString(c.R, 16)
        If Len(x) = 1 Then
            x += "0"
        End If
        y += x
        x = Convert.ToString(c.G, 16)
        If Len(x) = 1 Then
            x += "0"
        End If
        y += x
        x = Convert.ToString(c.B, 16)
        If Len(x) = 1 Then
            x += "0"
        End If
        y += x
        y = y.ToUpper
        Return y

    End Function

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If pCmd.HasExited = False Then
            pCmd.Kill()
        End If
    End Sub

    Private Sub Panel1_Resize(sender As Object, e As EventArgs) Handles Panel1.Resize
        'SetWindowPos(hwndCmd, 0, 0, 0, 0, 0, 1)
    End Sub
End Class
