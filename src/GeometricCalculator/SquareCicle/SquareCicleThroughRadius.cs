using GeometricCalculator.Figures;

namespace GeometricCalculator.SquareTriangle;

/// <summary>
/// Implementation calculate square cicle through radius
/// </summary>
public sealed class SquareCicleThroughRadius : ISquare<Circle>
{
    /// <summary>
    /// Calculate square cicle through radius
    /// </summary>
    /// <param name="figure">Geometric figure</param>
    /// <returns>Square</returns>
    public double Square(Circle figure) => Math.PI * Math.Pow(figure.Radius, 2);
}