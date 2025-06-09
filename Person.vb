Namespace MyPeopleApp.Models

' Define a public class named Person
Public Class Person

    ' Declare a public property to hold the person's name
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As Address

    ' A property that holds a Job object for the person
    ' This allows each person to have job info like title, employer, and salary
    Public Property Job As Job

    ' Constructor to set the name when a new Person is created
    ' Sub stands for Subroutine
    ' It defines a block of code that performs an action — but does not return a value
    ' Sub --> A method that does not return a value
    Public Sub New(name As String, age As Integer, job As Job)
        Me.Name = name
        Me.Age = age
        Me.Job = job
    End Sub

    ' Method to print a greeting message to the console
    Public Sub Greet()
        Console.WriteLine("Hello, my name is " & Name & " and my age is " & Age)
    End Sub

End Class

End Namespace



' 🔧 How is the constructor called?
' When you write New Person("Alice"), VB.NET automatically looks for a Sub New inside the Person class that matches the given argument.
' ➡️ This is the constructor — a special Sub that runs automatically when you use New.
' Public Sub New(name As String)
'     Me.Name = name
' End Sub