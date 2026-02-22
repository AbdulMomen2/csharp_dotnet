using MyApp.Helpers;

namespace MyApp.Services
{
    public class CalculatorService
    {
        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Simple Calculator =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                int choice = InputHelper.GetInt("Choose an option: ");

                switch (choice)
                {
                    case 1:
                        PerformOperation((a, b) => a + b);
                        break;

                    case 2:
                        PerformOperation((a, b) => a - b);
                        break;

                    case 3:
                        PerformOperation((a, b) => a * b);
                        break;

                    case 4:
                        PerformDivision();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            double num1 = InputHelper.GetDouble("Enter first number: ");
            double num2 = InputHelper.GetDouble("Enter second number: ");

            double result = operation(num1, num2);

            Console.WriteLine($"Result: {result}");
        }

        private void PerformDivision()
        {
            double num1 = InputHelper.GetDouble("Enter first number: ");
            double num2 = InputHelper.GetDouble("Enter second number: ");

            if (num2 == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return;
            }

            Console.WriteLine($"Result: {num1 / num2}");
        }
    }
}
