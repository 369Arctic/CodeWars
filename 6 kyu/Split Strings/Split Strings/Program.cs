
namespace Split_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/515de9ae9dcfc28eb6000001
            string[] array1 = SplitStrings("abc");
            Console.WriteLine(string.Join(", ", array1));
        }

        private static string[] SplitStrings(string str)
        {
            var list = new List<string>();

            for(int i = 0; i < str.Length; i += 2)
            {
                if (i + 1 < str.Length)
                {
                    list.Add(str.Substring(i, 2));
                }
                else
                {
                    list.Add(str[i] + "_");
                }

            }
            return list.ToArray();
        }
    }
}
