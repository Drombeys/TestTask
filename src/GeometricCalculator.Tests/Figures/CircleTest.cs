namespace GeometricCalculator.Tests.Figures;

[TestClass]
public class CircleTest
{
    [TestMethod]
    public void RadiusGreaterThan_0_ThrowsArgumentOutOfRangeException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
    }
}
