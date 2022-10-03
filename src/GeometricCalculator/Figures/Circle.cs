namespace GeometricCalculator.Figures;

/// <summary>
/// Geometric figure circle
/// </summary>
public class Circle
{
    /// <summary>
    /// Radius
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="radius">Circle radius</param>
    public Circle(double radius)
    {
        ExceptionHelpers.ThrowArgumentOutOfRange(radius <= 0, "Circle radius must be greater than 0");

        Radius = radius;
    }
}
