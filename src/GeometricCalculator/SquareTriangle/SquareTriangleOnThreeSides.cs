using GeometricCalculator.Figures;

namespace GeometricCalculator.SquareTriangle;

/// <summary>
/// Implementation of the calculation of the square of a triangle on three sides
/// </summary>
public sealed class SquareTriangleOnThreeSides : ISquare<Triangle>
{
    /// <summary>
    /// Perimeter calculation interface
    /// </summary>
    private readonly IPerimeter<Triangle> _perimeter;

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="perimeter">Implementation perimeter calculation</param>
    public SquareTriangleOnThreeSides(IPerimeter<Triangle> perimeter)
    {
        _perimeter = perimeter ?? throw new ArgumentNullException(nameof(perimeter));
    }

    /// <summary>
    /// Square triangle calculation
    /// </summary>
    /// <param name="figure">Geometric figure</param>
    /// <returns>Square</returns>
    public double Square(Triangle figure)
    {
        //Triangle semiperimeter
        var p = _perimeter.Perimeter(figure) / 2.0f;
        
        return Math.Sqrt(p * (p - figure.SideA) * (p - figure.SideB) * (p - figure.SideC));
    }
}