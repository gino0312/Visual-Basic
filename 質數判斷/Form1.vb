Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)
        Dim b As String = LineInput(1)
        Do Until EOF(1)
            Dim c As Boolean = True
            Dim str As Integer = LineInput(1)
            For i = 2 To str - 1
                If str Mod i = 0 Then
                    c = False
                    Exit For
                Else
                    c = True
                End If
            Next
            If c Then
                PrintLine(2, "T")
            Else
                PrintLine(2, "F")
            End If
        Loop
        FileClose()
        Close()
    End Sub
End Class
