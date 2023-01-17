namespace LS.Ensure;

public static class EnsureNullability
{
    public static IEnsure<T> IsNull<T>(this IEnsure<T> ensure) where T : class
    {
        if (ensure.Value is not null)
        {
            throw new EnsureException<T>(ensure, "Value is not null");
        }

        return ensure;
    }
    
    public static IEnsure<T> IsNotNull<T>(this IEnsure<T> ensure) where T : class
    {
        if (ensure.Value is null)
        {
            throw new EnsureException<T>(ensure, "Value is null");
        }

        return ensure;
    }
}