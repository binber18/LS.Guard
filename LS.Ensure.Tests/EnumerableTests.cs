namespace LS.Ensure.Tests;

public class EnumerableTests
{
    private static readonly IEnumerable<object> _empty = Enumerable.Empty<object>();
    private static readonly IEnumerable<object> _nonEmpty = new[] { new object() };
    
    [Fact]
    public void IsEmpty_Should_NotThrow_When_GivenEmptyEnumerable()
    {
        Ensure
           .Value(_empty)
           .IsEmpty();
    }
    
    [Fact]
    public void IsEmpty_Should_Throw_When_GivenNonEmptyEnumerable()
    {
        Assert.Throws<EnsureException<IEnumerable<object>>>(
            static () =>
            {
                Ensure
                   .Value(_nonEmpty)
                   .IsEmpty();
            });
    }
    
    [Fact]
    public void IsNotEmpty_Should_NotThrow_When_GivenNonEmptyEnumerable()
    {
        Ensure
           .Value(_nonEmpty)
           .IsNotEmpty();
    }
    
    [Fact]
    public void IsNotEmpty_Should_Throw_When_GivenEmptyEnumerable()
    {
        Assert.Throws<EnsureException<IEnumerable<object>>>(
            static () =>
            {
                Ensure
                   .Value(_empty)
                   .IsNotEmpty();
            });
    }
    
    [Fact]
    public void IsNotNullOrEmpty_Should_NotThrow_When_GivenNonEmptyEnumerable()
    {
        Ensure
           .Value(_nonEmpty)
           .IsNotNullOrEmpty();
    }
    
    [Fact]
    public void IsNotNullOrEmpty_Should_Throw_When_GivenEmptyEnumerable()
    {
        Assert.Throws<EnsureException<IEnumerable<object>>>(
            static () =>
            {
                Ensure
                   .Value(_empty)
                   .IsNotNullOrEmpty();
            });
    }
    
    [Fact]
    public void IsNotNullOrEmpty_Should_Throw_When_GivenNullEnumerable()
    {
        Assert.Throws<EnsureException<IEnumerable<object>>>(
            static () =>
            {
                Ensure
                   .Value<IEnumerable<object>>(null)
                   .IsNotNullOrEmpty();
            });
    }
}