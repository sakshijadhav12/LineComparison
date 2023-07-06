namespace LineComparison
{
    class Line
    {    //variable
        double length = 0;
        // method
        public void CalculateLength()
        {
           Console.WriteLine("  please enter x1 ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("  please enter x2 ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("  please enter y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("  please enter y2 ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("lenght of line is :"+ length);

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to class Camparison Computation Program");
            Line line = new Line();
            line.CalculateLength();// calling a method
        }
    }
}