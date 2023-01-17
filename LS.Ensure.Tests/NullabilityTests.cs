namespace LS.Ensure.Tests;

public class NullabilityTests
{
    [Fact]
    public void IsNotNull_Should_NotThrow_When_GivenNonNullObject()
    {
        Ensure
           .Value(new object())
           .IsNotNull();
    }
    
    [Fact]
    public void IsNotNull_Should_Throw_When_GivenNullObject()
    {
        Assert.Throws<EnsureException<object>>(
            static () =>
        {
            Ensure
               .Value<object>(null!)
               .IsNotNull();
        });
    }
    
    [Fact]
    public void IsNull_Should_NotThrow_When_GivenNullObject()
    {
        Ensure
           .Value<object>(null)
           .IsNull();
    }
    
    [Fact]
    public void IsNull_Should_Throw_When_GivenNonNullObject()
    {
        Assert.Throws<EnsureException<object>>(
            static () =>
        {
            Ensure
               .Value(new object())
               .IsNull();
        });
    }
}