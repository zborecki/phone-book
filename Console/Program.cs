// Create a console application that simulates the behavior of a phone contacts application.
// A contact consists of a name and a phone number.
//
// The application should:
// - Add a new contact.
// - Find a contact by phone number & name.
// - Display all contacts.

using Domain.ValueObjects;

var name = new Name("Pioter");
Console.WriteLine(name);
name.SetValue("Roman");
Console.WriteLine(name);