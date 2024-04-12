namespace GeometryLibrary;

public static class GeometryCalculator
{
    public static double CalculateShape(double[] sides)
    {
        IGeometryFigure f = sides.Length switch
        {
            < 0 => throw new ArgumentException("Задайте параметры для фигуры"),
            1 => new GeometryCircle(sides),
            2 => new GeometryRectangle(sides),
            3 => new GeometryTriangle(sides),
            _ => throw new ArgumentException("Фигура не определена")
        };

        f.Validate();
        return f.GetSquare();
    }
}