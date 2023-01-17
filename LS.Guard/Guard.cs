namespace LS.Guard;

public class Guard : IGuard
{
    
    public static IGuard Against { get; } = new Guard();
}