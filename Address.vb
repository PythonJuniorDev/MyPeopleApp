Namespace MyPeopleApp.Models

' Define a class to hold address information
Public Class Address
    ' Property for the street name and number
    Public Property Street As String

    ' Property for the city name
    Public Property City As String

    ' Property for the postal code
    Public Property ZipCode As String

    ' Property for person
    Public Property Person As Person

    ' Constructor to initialize the address properties
    Public Sub New(street As String, city As String, zipcode As String)
        Me.Street = street
        Me.City = city
        Me.ZipCode = zipcode
    End Sub

    ' Method to display the full address in the console
    Public Sub ShowAddress()
        Console.WriteLine(Street & ", " & City & ", " & ZipCode)
    End Sub
End Class

End Namespace