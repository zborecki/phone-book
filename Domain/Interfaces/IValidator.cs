namespace Domain.Interfaces;

public interface IValidator
{
    static abstract bool IsValid(string value);
}