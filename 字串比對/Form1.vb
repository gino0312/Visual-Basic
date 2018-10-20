Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", OpenMode.Input)
        FileOpen(2, "out.txt", OpenMode.Output)
        For q = 1 To Val(LineInput(1))
            Dim Data As String = String.Join("", LineInput(1).Split(" ").Select(Function(x) x.ToString))
            Dim Eng As New List(Of String)
            Dim Engcount As New List(Of Integer)
            For i = 1 To Data.Length
                If Eng.IndexOf(Mid(Data, i, 1)) = -1 Then Eng.Add(Mid(Data, i, 1)) : Engcount.Add(1) Else Engcount(Eng.IndexOf(Mid(Data, i, 1))) += 1
            Next
            PrintLine(2, Eng(Engcount.IndexOf(Engcount.Max)).ToString)
        Next
        FileClose()
        Close()
    End Sub
End Class
