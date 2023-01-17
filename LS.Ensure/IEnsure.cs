namespace LS.Ensure;

public interface IEnsure<out T>
{
    T Value { get; }
    string ParamName { get; }
}