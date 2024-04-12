namespace GeometryLibrary;

public class GeometryRectangle(IReadOnlyList<double> args) : IGeometryFigure
{
    public void Validate()
    {
        if (args.Count != 2)
        {
            throw new ArgumentException("Это не прямоугольник");
        }

        var sidesWithError = args.Where(x => x <= 0);
        if (sidesWithError.Any())
        {
            throw new ArgumentException("Стороны прямоугольника должны быть положительными числами.");
        }
    }

    public double GetSquare()
    {
        return args[0] * args[1];
    }

    public bool IsSquare() => args[0] == args[1];
}