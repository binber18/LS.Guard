namespace LS.Ensure;

public static class EnsureEnum
{
    public static IEnsure<T> IsDefined<T>(this IEnsure<T> ensure)
        where T : struct, IComparable, IFormattable, IConvertible
    {
        if (!Enum.IsDefined(typeof(T), ensure.Value))
        {
            ensure.Fail("Value is not defined");
        }

        return ensure;
    }
}