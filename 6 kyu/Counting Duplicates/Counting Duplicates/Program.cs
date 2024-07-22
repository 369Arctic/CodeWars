//https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
namespace Counting_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcde";
            int duplicates = CountDuplicates(str);
            Console.WriteLine(duplicates);
        }

        private static int CountDuplicates(string str)
        {
            return str.ToLower()
                       .GroupBy(u => u)
                       .Where(u => u.Count() > 1)
                       .Count();
        }
    }
}
