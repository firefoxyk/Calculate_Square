using CalculateSquare;

Console.Write("Вычиляем площадь круга(1) или треугольника(0)?");
if (Console.ReadLine() == "1")
{
    Console.Write("Введите радиус круга: ");
    IFigure circle = new Circle(Convert.ToDouble(Console.ReadLine()));
    Console.WriteLine(circle.Square);
}
else
{
    Console.Write("Введите первую сторону треугольника: "); double SideA = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите вторую сторону треугольника: "); double SideB = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите третью сторону треугольника: "); double SideC = Convert.ToDouble(Console.ReadLine());
    IFigure triangle = new Triangle(SideA,SideB, SideC);
    Console.WriteLine(triangle.Square);
}
