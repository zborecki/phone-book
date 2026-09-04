using Domain.Guards;
using Domain.Interfaces;
using Domain.Shared;

namespace Domain.Validators;

public class PhoneNumberValidator : IValidator
{
    public static bool IsValid(string value)
    {
        StringGuard.ThrowIfNullOrWhiteSpace(value);
        
        return RegexPattern.PhoneNumber().IsMatch(value);
    }

    public static string Validate(string value)
    {
        return !IsValid(value) ? throw new ArgumentException("Invalid phone number.") : value.Trim();
    }
}