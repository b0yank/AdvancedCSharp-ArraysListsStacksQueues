namespace _06.SubsetSums
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
            bool matchingSequenceExists = false;            

            for (long i = 0; i < combinationsCount; i++)
            {
                long sum = 0;
                var sequence = new List<int>(numbers.Length);
                bool sequenceWasModified = false;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if ((i & (1 << j)) > 0)
                    {
                        sum += numbers[j];

                        sequence.Add(numbers[j]);

                        sequenceWasModified = true;
                    }
                }

                if (sum == n && sequenceWasModified)
                {
                    Console.WriteLine("{0} = {1}", string.Join(" + ", sequence), n);

                    matchingSequenceExists = true;
                }
            }

            if (!matchingSequenceExists)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
