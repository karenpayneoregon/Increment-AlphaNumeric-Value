Namespace Classes

    Public Class DataOperations
        Public Shared Function GetCustomers() As List(Of CustomerItem)
            Return Mocked.List()
        End Function
        ''' <summary>
        ''' Used to update a customer sequence by customer primary key
        ''' </summary>
        ''' <param name="customerId"></param>
        ''' <param name="customerSequence"></param>
        Public Shared Sub UpdateCustomer(customerId As Integer, customerSequence As String)
            ' TODO
        End Sub
    End Class
End Namespace