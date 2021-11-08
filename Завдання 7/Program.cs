using System;

namespace Завдання_7
{
    class Program
    {
        private static void Main()
        {
            int M = 5, N = 4;
            int i, j, temp;
            int[] zero = new int[N];
            int[,] B = new int[M, N];
            Random rnd = new Random();
            string strValue = "\n ----------------------------------------";
            Console.Write("\n  ");
            Console.WriteLine("\n Исходный массив: ");
            Console.WriteLine(strValue);
            // заполнение массива
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    temp = rnd.Next(0, 2);
                    B[i, j] = Convert.ToInt32(temp);
                    Console.Write(" {0}", B[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (j = 0; j < N; j++)
            {
                int k = 0;
                for (i = 0; i < M; i++)
                {
                    if (B[i, j] == 0) k++;
                }
                zero[j] = k;
                Console.Write(" {0}", zero[j]);
            }
            int max = -1;
            int t = 0;

            Console.WriteLine();

            for (j = 0; j < N; j++)
            {
                if (max < zero[j])
                {
                    max = zero[j];
                    t = j;
                }
            }
            Console.WriteLine(" t={0}, max={1}", t, max);
            Console.WriteLine(strValue);
            Console.WriteLine("\n Массив после перестановки: ");
            Console.WriteLine(strValue);
            
            for (i = 0; i < M; i++)
            {
                temp = B[i, t];
                B[i, t] = B[i, 3];
                B[i, 3] = temp;
            }
            
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(" {0}", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(strValue);
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
