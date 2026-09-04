using Domain.Guards;
using Domain.Validators;

namespace Domain.ValueObjects;

public class PhoneNumber(string value)
{
    private string Value  { get; set; } = PhoneNumberValidator.Validate(value);
    
    public void SetValue(string value) => Value =  PhoneNumberValidator.Validate(value);

    public override string ToString() => Value;
}