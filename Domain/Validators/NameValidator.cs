using Domain.Guards;
using Domain.Interfaces;

namespace Domain.Validators;

public class NameValidator : IValidator
{
    public static bool IsValid(string value)
    {
        throw new NotImplementedException();
    }

    public static string Validate(string value, int minLength, int maxLength)
    {
        StringGuard.ThrowIfNullOrWhiteSpace(value);

        var name = value.Trim();
        StringGuard.ThrowIfLengthOutOfRange(name, minLength, maxLength);

        return name;
    }
}