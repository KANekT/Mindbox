using GeometryLibrary;
using JetBrains.Annotations;

namespace TestGeometry;

[TestClass]
[TestSubject(typeof(GeometryCircle))]
public class GeometryCircleTest
{
    [TestMethod]
    public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 5;
        var expectedArea = 78.539816339744831;
        
        // Act
        var actualArea = GeometryCalculator.CalculateShape([radius]);

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    [TestMethod]
    public void CalculateCircleArea_ZeroRadius_ThrowsArgumentException()
    {
        // Arrange
        double radius = 0;
        
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => GeometryCalculator.CalculateShape([radius]));
    }
}