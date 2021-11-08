// Заполнить двухмерный массив и организовать вывод на экран.
// ВВод массива в файл и вывод массива из файла.
using System;
using System.IO;

namespace Пример_4
{
    class Program
    {
        static void Main()
        {
            int i, j, num;
            double x = 0;
            string strValue;
            double[,] iArray1 = new double[10, 3];
            double[,] iArray2 = new double[10, 3];
            Random rnd = new Random();
            StreamWriter sWrite = new StreamWriter("C:\\Users\\t3t3t\\OneDrive\\Рабочий стол\\res3.txt");
            Console.WriteLine("\n -------------------------------------");
            for (i=0; i<10; i++)
            {
                num = rnd.Next(1, 51);
                iArray1[i, 0] = Convert.ToDouble(num);
                num = (rnd.Next(1, 101) - 50) / 10;
                iArray1[i, 1] = Convert.ToDouble(num);
                iArray1[i, 2] = Math.Sin(x);
                x = x + 0.314159;
                strValue = string.Format("\n {0, 4:D} {1, 10:F0} {2, 10:F2} {3, 10:F2}", i, iArray1[i, 0], iArray1[i, 1], iArray1[i, 2]);
                Console.WriteLine(strValue);
            }
            Console.WriteLine("\n -------------------------------------");
            for (i=0; i<10; i++)
            {
                for(j=0;j<3;j++)
                {
                    iArray2[i, j] = iArray1[i, j] * 100;
                    sWrite.WriteLine(iArray2[i, j]);
                }
            }
            num = iArray2.Length;
            Array.Copy(iArray2, iArray1, num);
            for (i=0;i<10;i++)
            {
                strValue = string.Format("\n {0, 4:D} {1, 10:F0} {2, 10:F2} {3, 10:F2}", i, iArray2[i, 0], iArray2[i, 1], iArray2[i, 2]);
                Console.WriteLine(strValue);
            }
            Console.WriteLine("\n -------------------------------------");
            sWrite.Close();
        }
    }
}
