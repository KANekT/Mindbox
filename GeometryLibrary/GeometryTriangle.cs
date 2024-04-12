namespace GeometryLibrary;

public class GeometryTriangle(IReadOnlyList<double> args) : IGeometryFigure
{
    public void Validate()
    {
        if (args.Count != 3)
        {
            throw new ArgumentException("Это не треугольник");
        }

        var sidesWithError = args.Where(x => x <= 0);
        if (sidesWithError.Any())
        {
            throw new ArgumentException("Стороны треугольника должны быть положительными числами.");
        }
    }

    public double GetSquare()
    {
        // Используем формулу Герона для вычисления площади треугольника
        var s = args.Sum() / 2;
        return Math.Sqrt(s * (s - args[0]) * (s - args[1]) * (s - args[2]));
    }
    
    public bool IsRightTriangle()
    {
        var sideA = args[0];
        var sideB = args[1];
        var sideC = args[2];

        var longestSide = Math.Max(Math.Max(sideA, sideB), sideC);

        if (longestSide == sideA)
        {
            return Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
        }

        if (longestSide == sideB)
        {
            return Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2);
        }

        return Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
    }
}