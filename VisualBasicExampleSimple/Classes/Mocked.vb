Namespace Classes
    ''' <summary>
    ''' Mocked up data that would be in a database
    ''' </summary>
    Public Class Mocked
        Public Shared Function List() As List(Of CustomerItem)

            Dim customers = New List(Of CustomerItem) From {
                    New CustomerItem() With {.CustomerIdentifier = 1, .CompanyName = "Alfreds Futterkiste", .CurrentSequenceValue = "AF0001", .SequencePreFix = "AF"},
                    New CustomerItem() With {.CustomerIdentifier = 2, .CompanyName = "Around the Horn", .CurrentSequenceValue = "ATH0010", .SequencePreFix = "ATH"},
                    New CustomerItem() With {.CustomerIdentifier = 3, .CompanyName = "Berglunds snabbköp", .CurrentSequenceValue = "", .SequencePreFix = "BS"}
                    }

            Return customers

        End Function
    End Class
End Namespace