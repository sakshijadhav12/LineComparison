namespace LineComparison
{
    class Line
    {
        protected double x1, x2, y1, y2;

        public Line(double x1, double x2, double y1, double y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public virtual double CalculateLength()
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }

    class EqualLengthLine : Line
    {
        public EqualLengthLine(double x1, double x2, double y1, double y2) : base(x1, x2, y1, y2)
        {
        }

        public override double CalculateLength()
        {
            return base.CalculateLength();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to class Comparison Computation Program");

            // First line
            Console.WriteLine("First Line:");
            Line line1 = GetLineFromUser();

            // Second line
            Console.WriteLine("\nSecond Line:");
            Line line2 = GetLineFromUser();

            double line1Length = line1.CalculateLength();
            double line2Length = line2.CalculateLength();

            Console.WriteLine("\nLength of the first line is: " + line1Length);
            Console.WriteLine("Length of the second line is: " + line2Length);

            // Comparing
            int comparisonResult = line1Length.CompareTo(line2Length);

            if (comparisonResult == 0)
            {
                Console.WriteLine("The lines are equal.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("The first line is greater than the second line.");
            }
            else
            {
                Console.WriteLine("The first line is less than the second line.");
            }
        }

        static Line GetLineFromUser()
        {
            double x1, x2, y1, y2;
            Console.WriteLine("Please enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            return new EqualLengthLine(x1, x2, y1, y2);
        }
    }
}