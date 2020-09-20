Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Class CustomerItem
        Implements INotifyPropertyChanged

        Private _currentSequenceValue1 As String
        Public Property CustomerIdentifier() As Integer
        Public Property CompanyName() As String

        Public Property CurrentSequenceValue() As String
            Get
                Return _currentSequenceValue1
            End Get
            Set
                _currentSequenceValue1 = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property SequencePreFix() As String

        Public Overrides Function ToString() As String
            Return CompanyName
        End Function
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace