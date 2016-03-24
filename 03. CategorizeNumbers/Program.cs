using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.CategorizeNumbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            float[] numbers = input.Select(float.Parse).ToArray();

            var wholeNumbers = numbers.Where(num => num % 1 == 0).ToList();

            var decimalNumbers = numbers.Where(num => num % 1 != 0).ToList();

            if (decimalNumbers.Count > 0)
            {
                DisplayList(decimalNumbers);
            }

            if (wholeNumbers.Count > 0)
            {
                DisplayList(wholeNumbers);
            }
        }

        private static void DisplayList(List<float> numbers)
        {
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
                string.Join(", ", numbers),
                numbers.Min(),
                numbers.Max(),
                numbers.Sum(),
                numbers.Average()
                );
        }
    }
}
