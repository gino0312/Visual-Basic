Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)
        Do Until EOF(1)
            Dim str11 As String = LineInput(1)
            Dim ans As Boolean = True

            If str11.Length = 5 Then
                Dim d As Integer = 0
                For i = 1 To str11.Length
                    If Mid(str11, 1, 1) = "." Or Mid(str11, str11.Length, 1) = "." Then
                        ans = False
                        Exit For
                    ElseIf Asc(Mid(str11, i, 1)) >= 48 And Asc(Mid(str11, i, 1)) <= 57 Then
                        ans = True
                    ElseIf Mid(str11, i, 1) = "." Then
                        d = d + 1
                        If d > 1 Then
                            ans = False
                            Exit For
                        Else
                            ans = True
                        End If
                    Else
                        ans = False
                    End If
                Next
            Else
                ans = False
            End If
            If ans = True Then
                PrintLine(2, "T")
            Else
                PrintLine(2, "F")
            End If
        Loop
        FileClose()
        Close()
    End Sub
End Class
