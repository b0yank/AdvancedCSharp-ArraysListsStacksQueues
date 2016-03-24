using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsStacksQueues
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var numbersAsString = input.Split(' ');

            var numbers = numbersAsString.Select(int.Parse).ToArray();

            Array.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
