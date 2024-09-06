namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int diff = a - b;
            int prod = a * b;
            int quot = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}+{b} = {sum}");
            Console.WriteLine($"{a}-{b} = {diff}");
            Console.WriteLine($"{a}*{b} = {prod}");
            Console.WriteLine($"{a}/{b} = {quot}");
            Console.WriteLine($"{a}/{b} is {quot} remainder {remainder}");

            Console.WriteLine("Please input value for radius of circle");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle according to radius provided is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
