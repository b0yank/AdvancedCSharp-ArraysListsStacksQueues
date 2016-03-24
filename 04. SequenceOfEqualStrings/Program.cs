using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceOfEqualStrings
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var distinctStrings = input.Distinct().ToArray();

            var output = new string[distinctStrings.Length];

            for (int currentStringIndex = 0; currentStringIndex < distinctStrings.Length; currentStringIndex++)
            {
                var sameStringArray = input.Where(str => str == distinctStrings[currentStringIndex]).ToArray();

                output[currentStringIndex] = string.Join(" ", sameStringArray);
            }

            Array.ForEach(output, Console.WriteLine);
        }
    }
}
