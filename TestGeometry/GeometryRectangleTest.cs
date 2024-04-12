using GeometryLibrary;
using JetBrains.Annotations;

namespace TestGeometry;

[TestClass]
[TestSubject(typeof(GeometryRectangle))]
public class GeometryRectangleTest
{
    [TestMethod]
    public void CalculateRectangleArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        double side1 = 3;
        double side2 = 4;
        double expectedArea = 12;
        
        // Act
        var actualArea = GeometryCalculator.CalculateShape([side1, side2]);

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void CalculateRectangle_ValidSides_IsSquare()
    {
        // Arrange
        double side1 = 3;
        double side2 = 3;
        
        // Act
        var geometryIsSquare = new GeometryRectangle([side1, side2]).IsSquare();

        // Assert
        Assert.IsTrue(geometryIsSquare);
    }
    
    
    [TestMethod]
    public void CalculateRectangleArea_NegativeSide_ThrowsArgumentException()
    {
        // Arrange
        double side1 = 3;
        double side2 = -4;
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateShape([side1, side2]));
    }
       
    [TestMethod]
    public void CalculateRectangleArea_ZeroSide_ThrowsArgumentException()
    {
        // Arrange
        double side1 = 3;
        double side2 = 0;
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateShape([side1, side2]));
    }
}