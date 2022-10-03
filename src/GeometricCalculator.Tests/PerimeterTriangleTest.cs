namespace GeometricCalculator.Tests;

[TestClass]
public class PerimeterTriangleTest
{
    [TestMethod]
    public void Perimeter_Triangle_Result_38()
    {
        IPerimeter<Triangle> perimeter = new PerimeterTriangle();
        var result = perimeter.Perimeter(new Triangle(13, 20, 5));

        Assert.AreEqual(result, 38.0f, $"Perimeter = {result}");
    }
}
