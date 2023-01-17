using System.Runtime.CompilerServices;

namespace LS.Guard;

public static class NullGuardClauses
{
    public static IGuard Null<T>(this IGuard guard,
                                 in T argument,
                                 [CallerArgumentExpression(nameof(argument))]
                                 string argumentName = "")
        where T : class
    {
        if (argument == null)
            throw new ArgumentNullException(argumentName);
        return guard;
    }

    public static IGuard Null<T>(this IGuard guard,
                                 in T? argument,
                                 [CallerArgumentExpression(nameof(argument))]
                                 string argumentName = "")
        where T : struct
    {
        if (argument == null)
            throw new ArgumentNullException(argumentName);
        return guard;
    }
}