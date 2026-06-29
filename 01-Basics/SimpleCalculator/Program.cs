namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int a =int.TryParse(Console.ReadLine(),out x);
            Console.WriteLine("Enter second number:");
            int b = int.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Enter operation (+, -, *, /):");
            string op = Console.ReadLine();
            switch (op) { 
                case "+":
                    Console.WriteLine($"Addition: {Add(a, b)}");
                    break;
                case "-":
                    Console.WriteLine($"Subtraction: {Subtract(a, b)}");
                    break;
                case "*":
                    Console.WriteLine($"Multiplication: {Multiply(a, b)}");
                    break;
                case "/":
                    int rem;
                    Console.WriteLine($"Division: {Divide(a, b, out rem)}, Remainder: {rem}");
                    break;
            }
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
