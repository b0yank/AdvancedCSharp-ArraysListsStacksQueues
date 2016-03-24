namespace _07.SortedSubsetSums
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
                .Select(int.Parse)
                .ToArray();

            numbers = numbers.Distinct().ToArray();

            long combinationsCount = 1u << numbers.Length;
            var sequenceCollection = new List<List<int>>();

            for (long i = 0; i < combinationsCount; i++)
            {
                long sum = 0;
                var sequence = new List<int>();


                for (int j = 0; j < numbers.Length; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        sum += numbers[j];

                        sequence.Add(numbers[j]);
                    }
                }

                if (sum == n && sequence.Count > 0)
                {
                    sequence.Sort();
                    sequenceCollection.Add(sequence);
                }
            }

            if (sequenceCollection.Count > 0)
            {
                sequenceCollection = sequenceCollection
                    .OrderBy(sequence => sequence.Count)
                    .ThenBy(sequence => sequence.Min())
                    .ToList();

                foreach (var sequence in sequenceCollection)
                {
                    Console.WriteLine("{0} = {1}", string.Join(" + ", sequence), n);
                }
            }

            else
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}