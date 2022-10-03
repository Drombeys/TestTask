namespace GeometricCalculator;

/// <summary>
/// Perimeter calculation interface
/// </summary>
/// <typeparam name="T">Geometric figure</typeparam>
public interface IPerimeter<T>
{
    /// <summary>
    /// Perimeter calculation
    /// </summary>
    /// <param name="figure">Geometric figure</param>
    /// <returns>Perimeter</returns>
    double Perimeter(T figure);
}