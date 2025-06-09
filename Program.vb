Imports System

Namespace MyPeopleApp.Models

' The main module that runs when the app starts
Module Program

    ' Main procedure — the entry point of the application
    Sub Main(args As String())

        Dim job1 As New Job("Developer", "IBM", 3000.00)
        Dim job2 As New Job("Bartender", "Stan&Co", 2700.00)

        Dim hobby1 As New Hobby("Cycling", "every weekend")
        Dim hobby2 As New Hobby("Chess", "every Friday")

        ' Create a new Person object with the name "Alice"
        ' Dim means “declare a variable” in VB.NET
        ' Declares a new variable named p
        ' Creates a new object of the class Person, and calls its constructor, passing "Alice" as the name
        ' So p now refers to a new Person object whose Name property is "Alice"
        Dim person1 As New Person("Alice", 29, job1)
        Dim person2 As New Person("Peter", 32, job2)

        Console.WriteLine(job1.title)
        Console.WriteLine(hobby1.name)
        Console.WriteLine(hobby1.frequency)
        hobby1.Describe()
        hobby1.Person = person1
        hobby1.Describe()

        Console.WriteLine(job2.title)
        Console.WriteLine(hobby2.name)
        Console.WriteLine(hobby2.frequency)
        hobby2.Describe()
        hobby2.Person = person2
        hobby2.Describe()
        Console.WriteLine(hobby2.Person.Name)
        Console.WriteLine(hobby2.Person.Age)
        Console.WriteLine(hobby2.Person.Job.Title)
        Console.WriteLine(hobby2.Person.Job.Salary)


    End Sub

End Module

End Namespace
