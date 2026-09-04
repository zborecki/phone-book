using Domain.ValueObjects;

namespace Tests.Domain.ValueObjects;

public class PhoneNumberTests
{
    [Theory]
    [InlineData("+48 000 111 222")]
    [InlineData("+48000111222")]
    [InlineData("000 111 222")]
    [InlineData("000111222")]
    public void ShouldCreatePhoneNumberWithValidValue(string value)
    {
        var phoneNumber = new PhoneNumber(value);
        
        Assert.Equal(value, phoneNumber.ToString());
    }
    
    [Theory]
    [InlineData("   ")]
    [InlineData("")]
    [InlineData("+48")]
    [InlineData("Norbert")]
    public void ShouldNotCreatePhoneNumberWithInvalidValue(string value)
    {
        Assert.Throws<ArgumentException>(() => new PhoneNumber(value));
    }

    [Fact]
    public void ShouldUpdatePhoneNumberWithValidValue()
    {
        const string initialValue = "+48 000 111 222";
        const string newValue = "+48 999 888 222";
        
        var phoneNumber = new PhoneNumber(initialValue);
        phoneNumber.SetValue(newValue);
        
        Assert.Equal(newValue, phoneNumber.ToString());
    }

    [Theory]
    [InlineData("   ")]
    [InlineData("")]
    [InlineData("+48")]
    [InlineData("Norbert")]
    public void ShouldNotUpdatePhoneNumberWithInvalidValue(string value)
    {
        const string initialValue = "+48 000 111 222";
        var phoneNumber = new PhoneNumber(initialValue);
        
        Assert.Throws<ArgumentException>(() => phoneNumber.SetValue(value));
        
        Assert.Equal(initialValue, phoneNumber.ToString());
    }
}