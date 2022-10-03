namespace GeometricCalculator;

/// <summary>
/// Square calculation interface
/// </summary>
/// <typeparam name="T">Geometric figure</typeparam>
public interface ISquare<T>
{
    /// <summary>
    /// Square calculation
    /// </summary>
    /// <param name="figure">Geometric figure</param>
    /// <returns>Square</returns>
    double Square(T figure);
}