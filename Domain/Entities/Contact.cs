using Domain.Shared;
using Domain.ValueObjects;

namespace Domain.Entities;

public class Contact(string name, string phoneNumber) : Entity
{
    private readonly Name _name = new (name);
    private readonly PhoneNumber _phoneNumber = new (phoneNumber);

    public void ChangeName(string value)
    {
        _name.SetValue(value);
    }

    public void ChangePhoneNumber(string value)
    {
        _phoneNumber.SetValue(value);
    }

    public string GetName() => _name.ToString();

    public string GetPhoneNumber() => _phoneNumber.ToString();

    public override string ToString()
    {
        return string.Join(", ", _name, _phoneNumber);
    }
}