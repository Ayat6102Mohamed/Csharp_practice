namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Addition: {Add(a, b)}");
            Console.WriteLine($"Subtraction: {Subtract(a, b)}");
            Console.WriteLine($"Multiplication: {Multiply(a, b)}");
            int rem;
            Console.WriteLine($"Division: {Divide(a, b, out rem)}, Remainder: {rem}");

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b, out int rem)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            rem = a % b;
            return a / b;
        }

    }
}
