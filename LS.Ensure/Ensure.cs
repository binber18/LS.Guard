namespace LS.Ensure;

public readonly record struct Ensure<T>(T Value) : IEnsure<T>;