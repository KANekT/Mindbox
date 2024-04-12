using GeometryLibrary;

var sides = args.Select(x =>
        double.TryParse(x, out var s)
            ? s
            : throw new ArgumentException("Задайте параметры для фигуры")
    )
    .ToArray();

var shape = GeometryCalculator.CalculateShape(sides);
Console.WriteLine($"Площадь {shape}");