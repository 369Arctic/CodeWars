using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            StringBuilder phoneNumber = new StringBuilder();

            phoneNumber.Append("(");
            for (int i = 0; i < 3; i++)
            {
                phoneNumber.Append(numbers[i]);
            }
            phoneNumber.Append(") ");

            for (int i = 3; i < 6; i++)
            {
                phoneNumber.Append(numbers[i]);
            }
            phoneNumber.Append("-");

            for (int i = 6; i < 10; i++)
            {
                phoneNumber.Append(numbers[i]);
            }
            Console.WriteLine(phoneNumber);
        }
    }
}
