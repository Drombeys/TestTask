namespace PerimeterCalculation.Tests.Figures;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void IsRectangular_Result_True_Test1()
    {
        var triangle = new Triangle(13, 12, 5);
        Assert.IsTrue(triangle.IsRectangular());
    }

    [TestMethod]
    public void IsRectangular_Result_False_Test2()
    {
        var triangle = new Triangle(20, 20, 20);
        Assert.IsFalse(triangle.IsRectangular());
    }

    [TestMethod]
    public void SideGreaterThan_0_ThrowsArgumentOutOfRangeException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 20, 20));
    }
}
