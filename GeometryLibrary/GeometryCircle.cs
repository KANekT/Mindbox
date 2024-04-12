namespace GeometryLibrary;

public class GeometryCircle(IReadOnlyList<double> args) :  IGeometryFigure
{
    public void Validate()
    {
        if (args.Count != 1)
        {
            throw new ArgumentException("Это не круг");
        }

        var radius = args.Single();
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус не может быть отрицательным.");
        }
    }

    public double GetSquare()
    {
        return Math.PI * Math.Pow(args.Single(), 2);
    }
}