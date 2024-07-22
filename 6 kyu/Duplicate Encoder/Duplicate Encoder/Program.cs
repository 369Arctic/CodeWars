// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
namespace Duplicate_Encoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncode("din"));
            Console.WriteLine(DuplicateEncode("recede"));
            Console.WriteLine(DuplicateEncode("Success"));
        }

        public static string DuplicateEncode(string word)
        {
            string wordToLower = word.ToLower();
            var charCount = wordToLower.GroupBy(u => u)
                                       .ToDictionary(u => u.Key, u => u.Count());

            var encodedString = wordToLower.Select(u => charCount[u] > 1 ? ')' : '(');
            return new string(encodedString.ToArray());
        }
    }
}
