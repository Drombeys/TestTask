namespace PerimeterCalculation.Figures;

/// <summary>
/// Geometric figure triangle
/// </summary>
public class Triangle
{
    /// <summary>
    /// Sida A
    /// </summary>
    public double SideA { get; }
    
    /// <summary>
    /// Side B
    /// </summary>
    public double SideB { get; }
    
    /// <summary>
    /// Side C
    /// </summary>
    public double SideC { get; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="sideA">Side A</param>
    /// <param name="sideB">Side B</param>
    /// <param name="sideC">Side C</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        ExceptionHelpers.ThrowArgumentOutOfRange(sideA <= 0, $"{ nameof(sideA) } must be greater than 0");
        ExceptionHelpers.ThrowArgumentOutOfRange(sideB <= 0, $"{ nameof(sideB) } must be greater than 0");
        ExceptionHelpers.ThrowArgumentOutOfRange(sideC <= 0, $"{ nameof(sideC) } must be greater than 0");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// Checking whether a triangle is rectangular
    /// </summary>
    public bool IsRectangular() => 
        (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) ||
        (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) ||
        (Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
}
