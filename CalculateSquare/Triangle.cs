namespace CalculateSquare
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public double Square => CalculateSquare();

        private double CalculateSquare()
        {
            if (IsItRightTriangle())
            {
                double[] sides = { SideA, SideB, SideC };
                Array.Sort(sides);
                return 0.5 * sides[0] * sides[1];
            }
            else
            {
                double p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public bool IsItRightTriangle()
        {
            bool isRightTriangle =
                Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2) ||
                Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2);
            return isRightTriangle;
        }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || double.IsNaN(a) || double.IsInfinity(a))
                throw new ArgumentOutOfRangeException(nameof(a));
            if (b <= 0 || double.IsNaN(b) || double.IsInfinity(b))
                throw new ArgumentOutOfRangeException(nameof(b));
            if (c <= 0 || double.IsNaN(c) || double.IsInfinity(c))
                throw new ArgumentOutOfRangeException(nameof(c));
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Incorrect sides");

            SideA = a;
            SideB = b;
            SideC = c;
        }
    }
}
