Class CmdWindow
    Private cmdLine As String
    Private exeRes As String
    Private isRet As Boolean = False   '是否收到执行结果
    Private isInput As Boolean = False '是否收到输入
    Private Declare Function AllocConsole Lib "kernel32" () As Long
    Private Declare Function FreeConsole Lib "kernel32" () As Long
    Private Declare Function GetStdHandle Lib "kernel32" (ByVal nStdHandle As Long) As Long
    Private Const STD_INPUT_HANDLE = -10&   ''返回 input handle
    Private Const TD_OUTPUT_HANDLE = -11&  ''返回 output handle
    Private Const STD_ERROR_HANDLE = -12&   ''返回 error handle
    'Private Declare Function WriteConsole Lib "kernel32" Alias "WriteConsoleA" (ByVal hConsoleoutput As Long， ByVal lpBuffer As Any, ByVal nNumberofCharsTowrite As Long, IpNumberofCharsWritten As Long, lpReserved As Any) As Long
    Public Event EventReceiveData(ByVal data As String)
    Public Shared Sub Main()

    End Sub
    Public Sub Run()
        While True
            Console.Write(">>")
            cmdLine = Console.ReadLine()
            RaiseEvent EventReceiveData("123423423")
            Console.WriteLine("Waiting...")
            'While Not isRet
            'End While
            'isInput = False
            'Console.WriteLine(exeRes)
            'isRet = False
        End While
    End Sub
    Public Function getCmdLine() As String
        If isInput Then
            Return cmdLine
        Else
            Return Nothing
        End If
    End Function
    Public Sub setExeRes(ByVal res As String)
        isRet = True
        exeRes = res
    End Sub
End Class

