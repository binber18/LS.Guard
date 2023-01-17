namespace LS.Ensure;

public static class EnsureEnumerable
{
    public static IEnsure<IEnumerable<T>> IsEmpty<T>(this IEnsure<IEnumerable<T>> ensure)
    {
        if (!ensure.Value.Any())
        {
            throw new EnsureException<IEnumerable<T>>(ensure, "Value is not empty");
        }

        return ensure;
    }
    
    
    
}