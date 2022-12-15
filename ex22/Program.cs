using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double firstSum = 0, secondSum = 0;

            int[] firstValues = { -4, -3, 0, 6, -4, 3, 5, 8, 7 };
            double[] secondValues = { 10, -4, 6, 3.3, 5, -3.6, 17 };


            for (int i = 0; i < firstValues.Length; i++)
            {
                if (firstValues[i] > 0)
                {
                    for (int j = i + 1; j < firstValues.Length; j++)
                    {
                        if (firstValues[j] < 0) firstSum += firstValues[j];
                        else
                        {
                            j = firstValues.Length;
                            i = firstValues.Length;
                        }
                    }
                }
            }
            Console.WriteLine($"Cумма элементов массива, расположенных между первым и вторым положительными элементами для первого массива = {firstSum}");

            for (int i = 0; i < secondValues.Length; i++)
            {
                if (secondValues[i] > 0)
                {
                    for (int j = i + 1; j < secondValues.Length; j++)
                    {
                        if (secondValues[j] < 0) secondSum += secondValues[j];
                        else
                        {
                            j = firstValues.Length;
                            i = secondValues.Length;
                        }
                    }
                }
            }
            Console.WriteLine($"Cумма элементов массива, расположенных между первым и вторым положительными элементами для второго массива = {secondSum}");
            Console.ReadKey();
        }
    }
}
