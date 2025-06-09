Namespace MyPeopleApp.Models

' Define a Job class to represent a person's job
Public Class Job

    ' The title of the job (e.g., "Teacher", "Engineer")
    Public Property Title As String

    ' The name of the company or employer
    Public Property Employer As String

    ' The monthly salary (as a Decimal)
    Public Property Salary As Decimal

    ' Constructor to create a Job with title, employer, and salary
    Public Sub New(title As String, employer As String, salary As Decimal)
        Me.Title = title
        Me.Employer = employer
        Me.Salary = salary
    End Sub

    ' Method to print job details to the console
    Public Sub ShowJobInfo()
        Console.WriteLine("Job: " & Title)
        Console.WriteLine("Employer: " & Employer)
        Console.WriteLine("Salary: $" & Salary)
    End Sub

End Class

End Namespace