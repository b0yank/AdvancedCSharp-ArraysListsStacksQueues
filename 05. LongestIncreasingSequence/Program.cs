namespace _05.LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var sequences = new List<List<int>>();

            for (int sequenceStart = 0; sequenceStart < input.Length - 1; sequenceStart++)
            {
                int sequenceEnd = sequenceStart;

                while (sequenceEnd + 1 < input.Length &&
                    input[sequenceEnd + 1] > input[sequenceEnd])
                {
                    sequenceEnd++;
                }


                var newIntegerList = new List<int>();

                for (int newSequenceIndex = sequenceStart; newSequenceIndex <= sequenceEnd; newSequenceIndex++)
                {
                    newIntegerList.Add(input[newSequenceIndex]);
                }

                sequenceStart = sequenceEnd;

                sequences.Add(newIntegerList);

            }

            int maxSequenceLength = sequences.Select(sequence => sequence.Count).Max();

            var maxSequence = sequences.First(sequence => sequence.Count == maxSequenceLength);

            foreach (var sequence in sequences)
            {
                Console.WriteLine(string.Join(" ", sequence));
            }

            Console.WriteLine("Longest: {0}", string.Join(" ", maxSequence));
        }
    }
}
