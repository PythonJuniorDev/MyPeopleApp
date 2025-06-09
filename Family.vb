Namespace MyPeopleApp.Models

' Define a Family class that holds multiple Person objects
Public Class Family

    ' A list to store Person objects
    Private Members As New List(Of Person)

    ' Add a Person to the family
    Public Sub AddMember(p As Person)
        Members.Add(p)
    End Sub

    ' Show all members in the family
    Public Sub ShowFamily()
        For Each p As Person In Members
            Console.WriteLine(p.Name & ", Age " & p.Age)
        Next
    End Sub

End Class

End Namespace