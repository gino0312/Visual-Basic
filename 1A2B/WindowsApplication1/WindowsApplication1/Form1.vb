Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)
        Dim countA As Integer = 0
        Dim countB As Integer = 0
        Dim str() As String = LineInput(1).Split(", ")
        Dim stra As String() = LineInput(1).Split(",")

        For i = 0 To str.Length - 1
            For j = 0 To stra.Length - 1
                If i = j And str(i) = stra(j) Then
                    countA += 1
                ElseIf i <> j And str(i) = stra(j) Then
                    countB += 1
                End If
            Next
        Next
        PrintLine(2, "A:" & countA & vbNewLine & "B:" & countB)
        FileClose()
        Close()
    End Sub
End Class
