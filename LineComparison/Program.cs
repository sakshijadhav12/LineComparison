namespace LineComparison
{
    class Line
    {
        // method with parameters
        public double CalculateLength(double x1, double x2, double y1, double y2)
        {
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return length;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to class Comparison Computation Program");

            // First line
            double x1, x2, y1, y2;
            Console.WriteLine("First Line:");
            Console.WriteLine("Please enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line line1 = new Line();
            double line1Length = line1.CalculateLength(x1, x2, y1, y2);

            // Second line
            Console.WriteLine("\nSecond Line:");
            Console.WriteLine("Please enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Line line2 = new Line();
            double line2Length = line2.CalculateLength(x1, x2, y1, y2);

            Console.WriteLine("\nLength of the first line is: " + line1Length);
            Console.WriteLine("Length of the second line is: " + line2Length);
            //comparing 
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
    }
}
