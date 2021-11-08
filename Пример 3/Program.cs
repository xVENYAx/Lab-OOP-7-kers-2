// Двухмерный массив ввод массива в файл и вывод масива из файла
using System;
using System.IO;

namespace Пример_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string strValue;
            int[,] iArray1 = new int[3, 4];
            int[,] iArray2 = new int[3, 4];
            StreamReader sRead = new StreamReader("C:\\Users\\t3t3t\\OneDrive\\Рабочий стол\\dat.txt");
            StreamWriter sWrite = new StreamWriter("C:\\Users\\t3t3t\\OneDrive\\Рабочий стол\\res.txt");
            for (i=0;i<3;i++)
            {
                for (j=0; j<4; j++)
                {
                    strValue = sRead.ReadLine();
                    iArray1[i, j] = Convert.ToInt32(strValue);
                    iArray2[i, j] = iArray1[i, j] * 100;
                    strValue = string.Format("\n {0, 4:D} {1, 4:D} {2, 6:D} {3, 6:D}", i, j, iArray1[i, j], iArray2[i, j]);
                    Console.WriteLine(strValue);
                    Console.WriteLine();
                }
            }
            for(i=0;i<3;i++)
            {
                for(j=0;j<4;j++)
                {
                    sWrite.WriteLine(iArray2[i, j]);
                }
            }
            sWrite.Close();
        }
    }
}
