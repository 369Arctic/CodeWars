// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
namespace Persistence_Bugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(39));
            Console.WriteLine(Persistence(999)); 
            Console.WriteLine(Persistence(4));
        }

        public static int Persistence(long a)
        {
            int count = 0;

            while (a >= 10)
            {
                long n = 1;
                while(a > 0)
                {
                    n *= a % 10;
                    a /= 10;
                }
                a = n;
                count++;
            }
            return count;
        }
    }
}
