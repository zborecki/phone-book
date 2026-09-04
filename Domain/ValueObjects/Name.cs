using Domain.Guards;
using Domain.Validators;

namespace Domain.ValueObjects;

public class Name(string value, int minLength = 2, int maxLength = 100)
{
    private string Value { get; set; } = NameValidator.Validate(value, minLength, maxLength);
    
    public void SetValue(string value) => Value =  NameValidator.Validate(value, minLength, maxLength);

    public override string ToString() => Value;
}