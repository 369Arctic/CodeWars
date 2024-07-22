// https://www.codewars.com/kata/546f922b54af40e1e90001da
namespace Replace_With_Alphabet_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
        }

        public static string AlphabetPosition(string text)
        {
            var position = text.ToLower()
                                .Where(char.IsLetter)
                                .Select(c => (c - 'a' + 1).ToString());

            return string.Join(" ", position);
                        
        }
    }
}
