// Заполнить двумерный массив непосредственно вводом с клавиатуры
using System;

namespace Пример_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string strValue;
            int[,] iArray = new int[3, 4];
            int[,] jArray = new int[3, 4];
            for (i = 0; i < 3; ++i)
            {
                for(j=0;j<4;++j)
                {
                    //ввод и присваивание значений
                    strValue = Console.ReadLine();
                    iArray[i, j] = Convert.ToInt32(strValue);
                }
            }
            // вывод значений массива iArray на экран
            for (i = 0; i < 3; ++i)
            {
                for (j = 0; j < 4; ++j)
                {
                    Console.WriteLine(" jArray[" + i + ", " + j + "] = " + iArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // вывод значений массива jArray на экран
            for (i=0; i<3;++i)
            {
                for (j=0; j<4; ++j)
                {
                    jArray[i, j] = iArray[i, j] * 10;
                    Console.WriteLine(" jArray[" + i + ", " + j + "] = " + jArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
