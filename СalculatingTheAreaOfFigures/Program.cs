using AreaOfFiguresLib.Figures;

try
{
    float sideA = 4f;
    float sideB = 5f;
    float sideC = 6f;
    var triangle = Triangle.Create(sideA, sideB, sideC);
    Console.WriteLine($"Создан треугольник со стронами {sideA},{sideB},{sideC}");
    Console.WriteLine($"Площадь = {triangle.GetArea()}");
    Console.WriteLine(triangle.IsRightTriangle() ? "Это прямоугольный треугольник" : "Это не прямоугольный треугольник");
    Console.WriteLine("---------------------------------------------");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("---------------------------------------------");
}

try
{
    float sideA = 6f;
    float sideB = 8f;
    float sideC = 10f;
    var triangle = Triangle.Create(sideA, sideB, sideC);
    Console.WriteLine($"Создан треугольник со стронами {sideA},{sideB},{sideC}");
    Console.WriteLine($"Площадь = {triangle.GetArea()}");
    Console.WriteLine(triangle.IsRightTriangle() ? "Это прямоугольный треугольник" : "Это не прямоугольный треугольник");
    Console.WriteLine("---------------------------------------------");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("---------------------------------------------");
}

try
{
    float sideA = 1f;
    float sideB = 2f;
    float sideC = 6f;
    var triangle = Triangle.Create(sideA, sideB, sideC);
    Console.WriteLine($"Создан треугольник со стронами {sideA},{sideB},{sideC}");
    Console.WriteLine($"Площадь = {triangle.GetArea()}");
    Console.WriteLine(triangle.IsRightTriangle() ? "Это прямоугольный треугольник" : "Это не прямоугольный треугольник");
    Console.WriteLine("---------------------------------------------");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("---------------------------------------------");
}

try
{
    float radius = 4f;
    var circle = Circle.Create(radius);
    Console.WriteLine($"Создан круг радиусом {radius}");
    Console.WriteLine($"Площадь = {circle.GetArea()}");
    Console.WriteLine("---------------------------------------------");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("---------------------------------------------");
}

try
{
    float radius = -4f;
    var circle = Circle.Create(radius);
    Console.WriteLine($"Создан круг радиусом {radius}");
    Console.WriteLine($"Площадь = {circle.GetArea()}");
    Console.WriteLine("---------------------------------------------");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("---------------------------------------------");
}