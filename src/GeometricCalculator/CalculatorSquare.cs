namespace GeometricCalculator;

/// <summary>
/// Calculation of the square of figures
/// </summary>
public struct CalculatorSquare
{
    /// <summary>
    /// Unified calculation of the square of figures
    /// </summary>
    /// <typeparam name="T">Type geometric figure</typeparam>
    /// <param name="figure">Geometric figure</param>
    /// <param name="square">Implementation square calculation</param>
    /// <returns>Square</returns>
    public static double Calculate<T>(T figure, ISquare<T> square) => square.Square(figure);
}
