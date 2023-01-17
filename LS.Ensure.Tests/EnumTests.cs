namespace LS.Ensure.Tests;

public class EnumTests
{
    [Fact]
    public void IsDefined_Should_NotThrow_When_GivenDefinedEnumValue()
    {
        Ensure
           .Value(DayOfWeek.Monday)
           .IsDefined();
    }
    
    [Fact]
    public void IsDefined_Should_Throw_When_GivenUndefinedEnumValue()
    {
        Assert.Throws<EnsureException<DayOfWeek>>(
            static () =>
            {
                Ensure
                   .Value((DayOfWeek)7)
                   .IsDefined();
            });
    }
}