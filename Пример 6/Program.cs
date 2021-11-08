// Заполнить двухмерный массив A(M,N) случайными числами.
// Переставить в этом массиве строки 2 и М - 2
using System;

namespace Пример_6
{
    class Program
    {
        static void Main()
        {
            int M = 6, N = 8;
            int i, j, temp;
            int[,] iArray1 = new int[M, N];
            int[,] iArray2 = new int[M, N];
            int[] iArray3 = new int[N];
            Random rnd = new Random();
            string strValue = "\n ----------------------------------------";
            Console.Write("\n  ");
            Console.WriteLine("\n Исходный массив: ");
            Console.WriteLine(strValue);
            // заполнение массива
            for (i=0; i<M; i++)
            {
                for (j=0; j<N; j++)
                {
                    temp = rnd.Next(1, 101);
                    iArray1[i, j] = Convert.ToInt32(temp);
                    iArray2[i, j] = Convert.ToInt32(temp);
                    iArray3[j] = iArray1[i, j];
                }
                foreach (int jj in iArray3)
                {
                    Console.Write("{0, 5}", jj);
                }
                Console.Write("\n");
            }
            Console.WriteLine(strValue);
            Console.WriteLine("\n Массив после перестановки: ");
            Console.WriteLine(strValue);
            for(j=0;j<N;j++)
            {
                temp = iArray2[2, j];
                iArray2[2, j] = iArray2[M - 2, j];
                iArray2[M - 2, j] = temp;
            }
            for (i=0; i<M; i++)
            {
                for (j=0;j<N;j++)
                {
                    iArray3[j] = iArray2[i, j];
                }
                foreach (int jj in iArray3)
                {
                    Console.Write("{0, 5}", jj);
                }
                Console.Write("\n");
            }
            Console.WriteLine(strValue);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
