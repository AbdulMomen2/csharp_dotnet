using MyApp.Services;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculatorService();
            calculator.Start();
        }
    }
}
