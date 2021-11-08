// Суммировать значения по одной из диоганалей матрицы 3х3х3.
using System;

namespace Пример_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] m = new int[3, 3, 3];
            int sum = 0;
            int n = 1;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        m[i, j, k] = n++;
            sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
            Console.WriteLine("Сумма значений по диоганали: " + sum);
        }
    }
}
