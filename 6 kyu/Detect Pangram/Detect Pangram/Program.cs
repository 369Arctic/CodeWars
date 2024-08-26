
namespace Detect_Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/545cedaa9943f7fe7b000048/train/csharp

            Console.WriteLine(IsPangram("qwerty"));
            Console.WriteLine(IsPangram("qwertyuiop[]asdfghjkl;'zxcvbnm,./"));
        }

        private static bool IsPangram(string input)
        {
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var result = input.ToLower().Where(char.IsLetter).Distinct();
            return alphabet.All(result.Contains);
        }
    }
}
