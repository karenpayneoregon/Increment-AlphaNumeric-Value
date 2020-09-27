Imports System.IO
Imports InvoiceNumerLibrary

Public Class NonDatabaseForm

    Private ReadOnly _sequenceList As New List(Of String)
    Private ReadOnly _sequenceItemList As New List(Of SequenceItem)
    Private _fileName As String = "Sequence.txt"

    Private Async Sub GenerateButton1_Click(sender As Object, e As EventArgs) Handles GenerateButton1.Click
        _sequenceList.Add(SequenceTextBox.Text)

        For index As Integer = 0 To 1000
            SequenceTextBox.Text = Generator.IncrementAlphaNumericValue(SequenceTextBox.Text)
            _sequenceList.Add(SequenceTextBox.Text)
            Await Task.Delay(1)
        Next

        File.WriteAllLines(_fileName, _sequenceList.ToArray())

        Process.Start(_fileName)

        _sequenceList.Clear()

    End Sub

    Private Sub GenerateButton2_Click(sender As Object, e As EventArgs) Handles GenerateButton2.Click
        Dim SequenceValue As String = SequenceTextBox.Text

        DataGridView1.DataSource = Nothing
        _sequenceItemList.Clear()

        _sequenceItemList.Add(New SequenceItem() With {.Id = 1, .Value = SequenceValue})

        For index As Integer = 2 To 500000
            SequenceValue = Generator.IncrementAlphaNumericValue(SequenceValue)
            _sequenceItemList.Add(New SequenceItem() With {.Id = index, .Value = SequenceValue})
        Next


        DataGridView1.DataSource = _sequenceItemList

    End Sub

    Private Sub NonDatabaseForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.AutoGenerateColumns = False
    End Sub
End Class