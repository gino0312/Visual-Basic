Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)
        Dim str1 As String = LineInput(1)
        Do Until EOF(1)
            Dim str() As String = LineInput(1).Split(" ")
            Dim n As Integer = Str.Length
            Dim count As Integer = 0
            For i = 0 To n - 1
                count = count + str(i).Length
            Next
            PrintLine(2, count)
        Loop
        FileClose()
        Close()
    End Sub
End Class
