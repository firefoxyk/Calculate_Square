namespace CalculateSquare
{
    public class Circle : IFigure
    {
        public double Radius { get; }
        public double Square => CalculateSquare();

        public Circle(double radius)
        {
            if (radius <= 0 || double.IsNaN(radius) || double.IsInfinity(radius))
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Invalid radius value");
            }

            Radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}