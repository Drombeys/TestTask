namespace GeometricCalculator.Tests.SquareCicle;

[TestClass]
public class SquareCicleThroughRadiusTest
{
    [TestMethod]
    public void Square_Cicle_ThroughRadius_Result_6()
    {
        ISquare<Circle> square = new SquareCicleThroughRadius();
        var result = square.Square(new Circle(4));

        Assert.AreEqual(50.3, Math.Round(result, 1));
    }
}
