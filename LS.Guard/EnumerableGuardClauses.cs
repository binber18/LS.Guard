using System.Runtime.CompilerServices;

namespace LS.Guard;

public static class EnumerableGuardClauses
{
    public static IGuard NullOrEmpty<T>(this IGuard guard,
                                        in IEnumerable<T> argument,
                                        [CallerArgumentExpression(nameof(argument))]
                                        string argumentName = "")
    {
        if (argument == null || !argument.Any())
            throw new ArgumentException("Collection cannot be null or empty.", argumentName);
        return guard;
    }
}