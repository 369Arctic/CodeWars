using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Parity_Outlier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/csharp

            int[] array1 = { 2, 4, 0, 100, 4, 11, 2602, 36 };
            int[] array2 = { 160, 3, 1719, 19, 11, 13, -21 };
            Console.WriteLine(Find(array1));
            Console.WriteLine(Find(array2));
        }

        private static int Find(int[] ints)
        {
            int evenCount = 0;
            int oddCount = 0;
            int lastEven = 0;
            int lastOdd = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    evenCount += 1;
                    lastEven = ints[i];
                }
                else
                {
                    oddCount += 1;
                    lastOdd = ints[i];
                }
            }

            if (evenCount > 1)
                return lastOdd;
            else
                return lastEven;

        }
        //public static int Find(int[] integers)
        //{
        //    bool firstEven = (integers.Take(3).Count(x => x % 2 == 0) >= 2); // проверяем первые 3 числа для увеличения производительности

        //    foreach (int number in integers)
        //    {
        //        if (firstEven && number % 2 != 0)
        //        {
        //            return number;
        //        }
        //        else if (!firstEven && number % 2 == 0)
        //        {
        //            return number;
        //        }
        //    }

        //    throw new InvalidOperationException("В массиве не найдено лишнего числа.");
        //}

    }
}
