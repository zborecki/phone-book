// Create a console application that simulates the behavior of a phone contacts application.
// A contact consists of a name and a phone number.
//
// The application should:
// - Add a new contact.
// - Find a contact by phone number & name.
// - Display all contacts.

using Domain.Entities;

var contact = new Contact("Norbert", "+48 000 999 222");
Console.WriteLine(contact.GetId());