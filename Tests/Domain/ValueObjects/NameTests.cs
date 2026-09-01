using Domain.Guards;
using Domain.ValueObjects;

namespace Tests.Domain.ValueObjects;

public class NameTests
{
    [Fact]
    public void ShouldCreateNameWithValidValue()
    {
        const string value = "Peter";
        var name = new Name(value);
        
        Assert.Equal(value, name.ToString());
    }

    [Fact]
    public void ShouldTrimValue()
    {
        const string value = "   Norbert   ";
        var name = new Name(value);
        
        Assert.Equal("Norbert", name.ToString());
    }

    [Fact]
    public void ShouldThrowExceptionWhenValueIsNull()
    {
        Assert.Throws<ArgumentException>(() => new Name(null!));
    }

    [Fact]
    public void ShouldThrowExceptionWhenValueIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => new Name(string.Empty));
    }

    [Fact]
    public void ShouldThrowExceptionWhenValueContainsOnlyWhiteSpaces()
    {
        Assert.Throws<ArgumentException>(() => new Name("   "));
    }

    [Fact]
    public void ShouldThrowExceptionWhenValueIsTooShort()
    {
        Assert.Throws<ArgumentException>(() => new Name("N"));
    }

    [Fact]
    public void ShouldThrowExceptionWhenValueIsTooLong()
    {
        var value = new string('N', 20);
        
        Assert.Throws<ArgumentException>(() => new Name(value, maxLength: 10));
    }

    [Fact]
    public void ShouldUpdateValueWhenSetValueIsCalled()
    {
        var name = new Name("Norbert");
        name.SetValue("Peter");
        
        Assert.Equal("Peter", name.ToString());
    }

    [Fact]
    public void ShouldThrowExceptionWhenSetValueIsInvalid()
    {
        var name = new Name("Norbert");
        
        Assert.Throws<ArgumentException>(() => name.SetValue("N"));
    }
    
    [Fact]
    public void ShouldReturnValueWhenToStringIsCalled()
    {
        var name = new Name("Norbert");
        var result = name.ToString();
        
        Assert.Equal("Norbert", result);
    }
}