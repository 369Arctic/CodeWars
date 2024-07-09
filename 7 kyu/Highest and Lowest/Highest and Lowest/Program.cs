using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highest_and_Lowest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/554b4ac871d6813a03000035/csharp

           string numbers = "-1 1 111 11 12 17 -500";

           var numbersChar = numbers.Split(' ');

           int[] numbersInt = new int[numbersChar.Length]; 

           for(int i = 0; i < numbersChar.Length; i++)
           {
               int a = int.Parse(numbersChar[i]);
               numbersInt[i] = a;
           }

           Array.Sort(numbersInt);

           int min = Convert.ToInt32(numbersInt[0]);
           int max = Convert.ToInt32(numbersInt.Last());
           Console.WriteLine($"min = {min}");
           Console.WriteLine($"max = {max}");


          string result = string.Join( " ", min, max );
           Console.WriteLine($"result str = {result}");


           //var parsed = numbers.Split().Select(int.Parse);
           //return parsed.Max() + " " + parsed.Min();

        }
    }
}
