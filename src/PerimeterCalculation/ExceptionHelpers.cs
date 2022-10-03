namespace PerimeterCalculation;

internal static class ExceptionHelpers
{
    internal static void ThrowArgumentOutOfRange(in bool condition, string message)
    {
        if (condition)
        {
            throw new ArgumentOutOfRangeException(message);
        }
    }
}
