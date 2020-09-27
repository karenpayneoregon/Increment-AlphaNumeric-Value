Public Class SequenceItem
    Public Property Id() As Integer
    Public Property Value() As String

    Public Overrides Function ToString() As String
        Return Value
    End Function
End Class