Namespace MyPeopleApp.Models

' Define a public class named Hobby
Public Class Hobby

    ' Property to store the name of the hobby
    Public Property Name As String

    ' Property to describe how often the person does this hobby
    Public Property Frequency As String

    ' Property to store a reference to the person who has this hobby
    Public Property Person As Person

    ' Constructor to create a Hobby with a name and frequency
    Public Sub New(name As String, frequency As String)
        Me.Name = name             ' Set the hobby name
        Me.Frequency = frequency   ' Set how often the hobby is done
    End Sub

    ' Method to describe the hobby in a sentence
    Public Sub Describe()
        Console.WriteLine("I enjoy " & Name & " " & Frequency & ".")
    End Sub

End Class

End Namespace