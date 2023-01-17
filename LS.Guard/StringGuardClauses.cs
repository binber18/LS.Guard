using System.Runtime.CompilerServices;

namespace LS.Guard;

public static class StringGuardClauses
{
    public static IGuard NullOrEmpty(this IGuard guard,
                                     in string argument,
                                     [CallerArgumentExpression(nameof(argument))]
                                     string argumentName = "")
    {
        if (string.IsNullOrEmpty(argument))
            throw new ArgumentException("String cannot be null or empty.", argumentName);
        return guard;
    }

    public static IGuard NullOrWhiteSpace(this IGuard guard,
                                          in string argument,
                                          [CallerArgumentExpression(nameof(argument))]
                                          string argumentName = "")
    {
        if (string.IsNullOrWhiteSpace(argument))
            throw new ArgumentException("String cannot be null or white space.", argumentName);
        return guard;
    }
}