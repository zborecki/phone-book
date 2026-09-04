using System.Text.RegularExpressions;

namespace Domain.Shared;

public static partial class RegexPattern
{
    [GeneratedRegex(@"^(?:\+48\s?)?\d{3}\s?\d{3}\s?\d{3}$")]
    public static partial Regex PhoneNumber();
}