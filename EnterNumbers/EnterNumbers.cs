namespace EnterNumbers
{
    using System;
    using System.Linq;



    class EnterNumbers
    {
        static void Main()
        {
            int[] numbers = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                PrintIfSorted(1, 100, numbers);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }

        }

        static void PrintIfSorted(int start, int end, int[] numbers)
        {
            try
            {
                if (!IsSorted(numbers) || numbers.Any(x => x < start) || numbers.Any(x => x > end))
                {
                    throw new ArgumentException();
                }

                Console.WriteLine(start + " < " + string.Join(" < ", numbers) + " < " + end);
            }
            catch (Exception)
            {

                throw;
            }
        }

        static bool IsSorted(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] >= numbers[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
