using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortNumbersArrayUsingSelectionSort
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var numbersAsString = input.Split(' ');

            var numbers = numbersAsString.Select(int.Parse).ToArray();

            for (int sortedNumbersCount = 0; sortedNumbersCount < numbers.Length - 1; sortedNumbersCount++)
            {
                int smallestNumberIndex = sortedNumbersCount;

                for (int j = sortedNumbersCount + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smallestNumberIndex])
                    {
                        smallestNumberIndex = j;
                    }
                }

                if (sortedNumbersCount != smallestNumberIndex)
                {
                    Swap(numbers, sortedNumbersCount, smallestNumberIndex);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Swap(int[] numbers, int sortedNumbersCount, int smallestNumberIndex)
        {
            var temporaryValue = numbers[sortedNumbersCount];
            numbers[sortedNumbersCount] = numbers[smallestNumberIndex];
            numbers[smallestNumberIndex] = temporaryValue;
        }
    }
}
