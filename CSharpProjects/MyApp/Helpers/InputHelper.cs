namespace MyApp.Helpers
{
    public static class InputHelper
    {
        public static int GetInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        public static double GetDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }
    }
}
