namespace _08.LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] firstArray = TakeInputArray(n);
            int[][] secondArray = TakeInputArray(n, true);

            int resultantRowLength = firstArray[0].Length + secondArray[0].Length;

            int[][] resultArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i].Length + secondArray[i].Length != resultantRowLength)
                {
                    var cellsNumber = 0;

                    for (int row = 0; row < n; row++)
                    {
                        cellsNumber += firstArray[row].Length + secondArray[row].Length;
                    }

                    Console.WriteLine("The total number of cells is: {0}", cellsNumber);

                    return;
                }

                var currentRow = new int[resultantRowLength];

                var firstArrayRow = firstArray[i];
                var secondArrayRow = secondArray[i];

                Array.Copy(firstArrayRow, currentRow, firstArrayRow.Length);
                Array.Copy(secondArrayRow, 0, currentRow, firstArrayRow.Length, secondArrayRow.Length);

                resultArray[i] = new int[resultantRowLength];
                Array.Copy(currentRow, resultArray[i], resultantRowLength);
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", resultArray[row]));
            }
        }

        private static int[][] TakeInputArray(int n, bool shouldReverse = false)
        {
            int[][] array = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (shouldReverse)
                {
                    row = row.Reverse().ToArray();
                }

                array[i] = row;
            }

            return array;
        }
    }
}
