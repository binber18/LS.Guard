namespace LS.Ensure;

public class EnsureException<T> : ArgumentException
{
    public EnsureException(IEnsure<T> ensure, string message) : base(message, ensure.ParamName) { }
}