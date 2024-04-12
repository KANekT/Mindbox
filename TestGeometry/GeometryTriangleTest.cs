using GeometryLibrary;
using JetBrains.Annotations;

namespace TestGeometry;

[TestClass]
[TestSubject(typeof(GeometryTriangle))]
public class GeometryTriangleTest
{
    [TestMethod]
    public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;
        double expectedArea = 6;
        
        // Act
        var actualArea = GeometryCalculator.CalculateShape([side1, side2, side3]);

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    
    [TestMethod]
    public void CalculateTriangle_ValidSides_IsRightTriangle()
    {
        // Arrange
        double side1 = 6;
        double side2 = 8;
        double side3 = 10;
        
        // Act
        var geometryIsRightTriangle = new GeometryTriangle([side1, side2, side3]).IsRightTriangle();

        // Assert
        Assert.IsTrue(geometryIsRightTriangle);
    }
    
    [TestMethod]
    public void CalculateTriangleArea_NegativeSide_ThrowsArgumentException()
    {
        // Arrange
        double side1 = 3;
        double side2 = -4;
        double side3 = 5;
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateShape([side1, side2, side3]));
    }
    
    [TestMethod]
    public void CalculateTriangleArea_ZeroSide_ThrowsArgumentException()
    {
        // Arrange
        double side1 = 3;
        double side2 = 0;
        double side3 = 5;
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateShape([side1, side2, side3]));
    }
}