namespace GeometricCalculator.Tests;

[TestClass]
public class CalculatorSquareTest
{
    [TestMethod]
    public void Triangle_Square_Result_6_Test1()
    {
        var triangle = new Triangle(3, 4, 5);

        IPerimeter<Triangle> perimeter = new PerimeterTriangle();
        ISquare<Triangle> square = new SquareTriangleOnThreeSides(perimeter);

        var result = CalculatorSquare.Calculate(triangle, square);

        Assert.AreEqual(result, 6.0f);
    }

    [TestMethod]
    public void Circle_Square_Result_50_3_Test2()
    {
        ISquare<Circle> square = new SquareCicleThroughRadius();
        var result = CalculatorSquare.Calculate(new Circle(4), square);

        Assert.AreEqual(50.3, Math.Round(result, 1));
    }

    [TestMethod]
    public void Unified_Calculate_Square_Test3()
    {
        var triangle = new Triangle(7, 10, 15);
        ISquare<Triangle> squareTriangle = new SquareTriangleOnThreeSides(new PerimeterTriangle());
        
        var cicle = new Circle(20);
        ISquare<Circle> squareCircle = new SquareCicleThroughRadius();

        var result1 = Math.Round(CalculatorSquare.Calculate(triangle, squareTriangle), 1);
        Assert.AreEqual(result1, 29.4, $"Square Triangle = {result1}");

        var result2 = Math.Round(CalculatorSquare.Calculate(cicle, squareCircle), 1);
        Assert.AreEqual(result2, 1256.6, $"Square Circle = {result2}");
    }
}
