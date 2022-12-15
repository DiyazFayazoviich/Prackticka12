using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prackticka12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 4;
            int count = 0;
            int quality = 0;
            int[,] mass = new int[x,y];
            Random random = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = random.Next(0, 6);
                    if (mass[i, j] == 0)
                    {
                        count++;


                        break;
                    }
                }
            }
                    for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i,j] + "\t");
                }
                Console.WriteLine();
            }
            quality = x - count;
            int max = 0, kol = 0;
            bool flag = false;
            do
            {
                max = mass[0, 0];
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 4; j++)
                        if (max < mass[i, j])
                            max = mass[i, j];
                kol = 0;
                for (int i = 0; i < 6; i++)
                    for (int j = 0; j < 4; j++)
                        if (mass[i, j] == max)
                            kol++;
                if (kol > 1)
                    flag = true;
                else
                    for (int i = 0; i < 6; i++)
                        for (int j = 0; j < 4; j++)
                            if (mass[i, j] == max)
                                mass[i, j] = int.MinValue;
            } while (!flag);
            Console.WriteLine("Кол-во строк без нулей:" + quality);
            Console.WriteLine("Максимальное из чисел, встречающихся в заданной матрице более одного раза:" + max);
            Console.ReadKey();
            
            
        }
    }
}
