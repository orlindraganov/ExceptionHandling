namespace SquareRoot
{
    using System;
    using System.Globalization;
    using System.Threading;

    class SquareRoot
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            try
            {
                double number = GetPositiveNumber();
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        static double GetPositiveNumber()
        {
            double number;
            try
            {
                number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid number");
            }
            catch (ArgumentNullException)
            {
                throw new FormatException("Invalid number");
            }
        }

    }
}
