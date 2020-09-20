Imports InvoiceNumerLibrary
Imports VisualBasicExampleSimple.Classes

Public Class Form1
    Private ReadOnly bindingSource As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bindingSource.DataSource = DataOperations.GetCustomers()
        ListBox1.DataSource = bindingSource

        CurrentSequenceTextBox.DataBindings.Add(
            "Text",
            bindingSource,
            "CurrentSequenceValue")

    End Sub
    Private Sub IncrementButton_Click(sender As Object, e As EventArgs) Handles IncrementButton.Click
        Dim newSequence = ""
        ' get current customer
        Dim current = CType(bindingSource.Current, CustomerItem)

        ' get last sequence
        Dim currentSequence = current.CurrentSequenceValue
        If String.IsNullOrWhiteSpace(currentSequence) Then
            ' first time
            current.CurrentSequenceValue = $"{current.SequencePreFix}0001"
            newSequence = current.CurrentSequenceValue
        Else
            ' create new sequence
            newSequence = Generator.IncrementAlphaNumericValue(currentSequence)

        End If
        ' assign new sequence
        current.CurrentSequenceValue = newSequence
        ' update database
        DataOperations.UpdateCustomer(current.CustomerIdentifier, newSequence)
    End Sub
End Class
