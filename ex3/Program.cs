using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random randint = new Random();
            int[,] matrix = new int[randint.Next(3, 5), randint.Next(3, 5)];
            int[] numbersR = { };
            int[] numbersC = { };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowNumbers = { };

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int number = randint.Next(0, 6);
                    matrix[i, j] = number;

                    rowNumbers = rowNumbers.Append(number).ToArray();
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowNumbers = { };

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowNumbers = rowNumbers.Append(matrix[i, j]).ToArray();
                }

                Array.Sort(rowNumbers);
                int minRowNumber = rowNumbers[0];

                int[] colNumbers = { };

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int number = matrix[i, j];

                    if (number == minRowNumber)
                    {
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            colNumbers = colNumbers.Append(matrix[k, j]).ToArray();
                        }

                        Array.Sort(colNumbers);
                        Array.Reverse(colNumbers);
                        int maxColNumber = colNumbers[0];

                        if (minRowNumber >= maxColNumber)
                        {
                            numbersR = numbersR.Append(i).ToArray();
                            numbersC = numbersC.Append(j).ToArray();
                        }
                    }
                }
            }
            for (int i = 0; i < numbersR.Length; i++)
            {
                Console.WriteLine($"Седловая точка в строке {numbersR[i]} и столбце {numbersC[i]}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}




