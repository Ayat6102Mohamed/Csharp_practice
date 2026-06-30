namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid first number.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid second number.");
                return;
            }

            Console.Write("Enter operation (+, -, *, /): ");
            string op = Console.ReadLine();

            switch (op)
            {
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
                    Console.WriteLine($"Division: {Divide(a, b, out rem)}");
                    Console.WriteLine($"Remainder: {rem}");
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
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
                throw new DivideByZeroException("Cannot divide by zero.");

            rem = a % b;
            return a / b;
        }
    }
}
