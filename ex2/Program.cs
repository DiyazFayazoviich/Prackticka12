using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[,] { { 3, 4, 6 }, { 9, -12, 8 }, { 0, 4, 12 } };
            int n = 3;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(mass[i, j] + " ");
                        sum += mass[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов квадратной матрицы, выделенных черным цветом = {sum}");
        
        }
    }
}
