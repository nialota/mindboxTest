using Mindbox.Implementations;

namespace Mindbox.Test;

public class ShapeCalculatorTest
{
    private readonly IShapeCalculator _shapeCalculator;

    public ShapeCalculatorTest()
    {
        _shapeCalculator = new ShapeCalculator();
    }

    [Theory]
    [InlineData(4)]
    public void CalculateCorrectCircleArea(int radius)
    {
        var result = _shapeCalculator.GetArea(radius);
        var roundedValue = Math.Round(result, 2, MidpointRounding.AwayFromZero);
        Assert.Equal(50.27, roundedValue);
    }

    [Theory]
    [InlineData(10, 15, 10, 15)]
    public void CalculateCorrecQuadrangleArea(double a, double b, double c, double d)
    {
        var values = new double[] { a, b, c, d };
        var result = _shapeCalculator.GetArea(values);
        var roundedValue = Math.Round(result, 2, MidpointRounding.AwayFromZero);

        Assert.Equal(150, roundedValue);
    }

    [Theory]
    [InlineData(5, 6, 4)]
    public void CalculateCorrectTriangleArea(double a, double b, double c)
    {
        var result = _shapeCalculator.GetArea(new double[] { a, b, c });
        var roundedValue = Math.Round(result, 2, MidpointRounding.AwayFromZero);
        Assert.Equal(9.92, roundedValue);
    }


    [Theory]
    [InlineData(7, 25, 24)]
    public void CheckIsRightTriangleReturnFalse(double a, double b, double c)
    {
        var result = _shapeCalculator.IsRightTriangle(a, b, c);
        Assert.False(result);
    }

    [Theory]
    [InlineData(1, 4, 3)]
    public void CheckIsRightTriangleReturnTrue(double a, double b, double c)
    {
        var result = _shapeCalculator.IsRightTriangle(a, b, c);
        Assert.True(result);
    }

    [Theory]
    [InlineData(7, 25, 24, 36)]
    public void CheckIsRightTriangleReturnException(double a, double b, double c, double d)
    {
        Assert.Throws<Exception>(() => _shapeCalculator.IsRightTriangle(a, b, c, d));
    }
}