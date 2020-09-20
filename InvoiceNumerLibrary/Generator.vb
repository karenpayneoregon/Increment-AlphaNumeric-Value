Imports System.Text.RegularExpressions

Public Class Generator
    Public Shared Function IncrementAlphaNumericValue(value As String) As String
        If String.IsNullOrWhiteSpace(value) Then
            Return ""
        End If

        If Regex.IsMatch(value, "^[a-zA-Z0-9]+$") = False Then
            Throw New Exception("Invalid Character: Must be a-Z or 0-9")
        End If

        Dim characterArray = value.ToCharArray()

        For characterIndex = characterArray.Length - 1 To 0 Step -1
            Dim characterValue = Convert.ToInt32(characterArray(characterIndex))

            If characterValue <> 57 AndAlso characterValue <> 90 AndAlso characterValue <> 122 Then
                characterArray(characterIndex) = ChrW(AscW(characterArray(characterIndex)) + 1)

                For resetIndex As Integer = characterIndex + 1 To characterArray.Length - 1
                    characterValue = Convert.ToInt32(characterArray(resetIndex))
                    If characterValue >= 65 AndAlso characterValue <= 90 Then
                        characterArray(resetIndex) = "A"c
                    ElseIf characterValue >= 97 AndAlso characterValue <= 122 Then
                        characterArray(resetIndex) = "a"c
                    ElseIf characterValue >= 48 AndAlso characterValue <= 57 Then
                        characterArray(resetIndex) = "0"c
                    End If
                Next resetIndex

                Return New String(characterArray)

            End If
        Next characterIndex

        'If we got through the Character Loop and were not able to
        'increment anything, we return a NULL string. 
        Return Nothing
    End Function

End Class
