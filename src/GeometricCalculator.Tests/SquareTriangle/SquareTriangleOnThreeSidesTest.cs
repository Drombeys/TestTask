using GeometricCalculator.SquareTriangle;

namespace GeometricCalculator.Tests.SquareTriangle;

[TestClass]
public class SquareTriangleOnThreeSidesTest
{
    [TestMethod]
    public void Square_Triangle_Result_6()
    {
        var triangle = new Triangle(3, 4, 5);

        IPerimeter<Triangle> perimeter = new PerimeterTriangle();
        ISquare<Triangle> square = new SquareTriangleOnThreeSides(perimeter);
        var result = square.Square(triangle);

        Assert.AreEqual(result, 6.0f, $"Square = {result}");
    }
}
