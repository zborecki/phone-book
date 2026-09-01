using Domain.Guards;

namespace Domain.ValueObjects;

public class Name(string value, int minLength = 2, int maxLength = 100)
{
    private string Value { get; set; } = ValidateName(value, minLength, maxLength);
    
    public void SetValue(string value) => Value =  ValidateName(value, minLength, maxLength);

    private static string ValidateName(string value, int minLength, int maxLength)
    {
        StringGuard.ThrowIfNullOrWhiteSpace(value);
        
        var name = value.Trim();
        StringGuard.ThrowIfLengthOutOfRange(name, minLength, maxLength);

        return name;
    }

    public override string ToString()
    {
        return Value;
    }
}