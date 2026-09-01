using Domain.Guards;

namespace Domain.Entities;

public class Contact : Entity
{
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }

    public Contact(string name, string phoneNumber)
    {
        StringGuard.ThrowIfLengthOutOfRange(name, 2, 32);

        Name = name;
        PhoneNumber = phoneNumber;
    }
}