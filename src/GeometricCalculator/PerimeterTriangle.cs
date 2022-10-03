using GeometricCalculator.Figures;

namespace GeometricCalculator;

/// <summary>
/// Implementation of the calculation of the perimeter of the triangle
/// </summary>
public sealed class PerimeterTriangle : IPerimeter<Triangle>
{
    /// <summary>
    /// Perimeter triangle calculation
    /// </summary>
    /// <param name="figure">Geometric figure</param>
    /// <returns>Perimeter</returns>
    public double Perimeter(Triangle figure) => figure.SideA + figure.SideB + figure.SideC;
}
