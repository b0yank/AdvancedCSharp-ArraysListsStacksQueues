namespace _09.StuckNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var stuckNumbersList = new List<string>();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    stuckNumbersList.Add(numbers[i] + '|' + numbers[j]);
                    stuckNumbersList.Add(numbers[j] + '|' + numbers[i]);
                }
            }

            var totalCombinations = stuckNumbersList.Count;
            for (int currentIndex = 0; currentIndex < totalCombinations; currentIndex++)
            {
                var matchingNumbers = stuckNumbersList
                    .Where(str => str.Replace("|", "") == stuckNumbersList[currentIndex].Replace("|", "") &&
                        stuckNumbersList.IndexOf(str) != currentIndex)
                    .ToArray();

                if (matchingNumbers.Length == 0)
                {
                    Console.WriteLine("No");

                    return;
                }

                foreach (var match in matchingNumbers)
                {
                    Console.WriteLine("{0}=={1}", stuckNumbersList[currentIndex], match);
                }
            }
        }
    }
}
