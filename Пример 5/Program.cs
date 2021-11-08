// Заполнить двухмерный массив случайными числами.
// Вычислить сумму и среднеарифметическое свех элементов.
using System;
using System.IO;

namespace Пример_5
{
    class Program
    {
        static void Main()
        {
            int i, j;
            int num, sum = 0;
            int[,] iArray = new int[5, 6];
            int[] iA = new int[6];
            Random rnd = new Random();
            string strValue = "\n -----------------------------------";
            Console.Write("\n  ");
            // номера столбцов
            for (j = 0; j < 6; j++)
                Console.Write("{0, 5}", j);
            Console.WriteLine(strValue);
            // Заполненияе массива; сумма и среднеарифметическое всех элементов
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    num = rnd.Next(1, 101);
                    iArray[i, j] = Convert.ToInt32(num);
                    iA[j] = iArray[i, j];
                    sum = sum + iArray[i, j];
                }
            }
            //вывод массива
            for (i = 0; i < 5; i++)
            {
                // номер строки
                Console.Write("\n " + i);
                for (j = 0; j < 6; j++)
                {
                    // элементы строки
                    Console.Write("{0, 5}", iArray[i,j]);
                }
            }
            Console.WriteLine(strValue);
            Console.WriteLine();
            Console.WriteLine(" Сумма элементов массива:  " + sum);
            Console.WriteLine(" Среднеарифметическое:       " + sum / 30);
            Console.WriteLine();
        }
    }
}
