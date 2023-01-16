using AreaOfFiguresLib.Figures;

try
{
    Console.WriteLine("Triangle 1 = " + Triangle.Create(6f, 5f, 4f).GetArea());
    Console.WriteLine("Triangle 2 = " + Triangle.Create(2.7f, 5f, 4f).GetArea());
    Console.WriteLine("Triangle 3 = " + Triangle.Create(2f, 5f, 4f).GetArea());
    Console.WriteLine("Triangle 4 = " + Triangle.Create(6.5f, 5f, 4f).GetArea());
    Console.WriteLine("Triangle 5 = " + Triangle.Create(7f, 8f, 9f).GetArea());
    Console.WriteLine("Circle 1 = " + Circle.Create(8f).GetArea());
    Console.WriteLine("Circle 2 = " + Circle.Create(4f).GetArea());
    Console.WriteLine("Circle 3 = " + Circle.Create(2f).GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


