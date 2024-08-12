
namespace Unique_In_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/54e6533c92449cc251001667/csharp
            var stringResult = UniqueInOrder("AAAABBBCCDAABBB");
            Console.WriteLine(string.Join(", ", stringResult));  // Вывод: A, B, C, D, A, B

            var charListResult = UniqueInOrder("ABBCcAD");
            Console.WriteLine(string.Join(", ", charListResult));  // Вывод: A, B, C, c, A, D

            var numberListResult = UniqueInOrder(new List<int> { 1, 2, 2, 3, 3 });
            Console.WriteLine(string.Join(", ", numberListResult));  // Вывод: 1, 2, 3
        }

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null || !iterable.Any())
            {
                return Enumerable.Empty<T>();
            }

            List<T> result = new List<T>();

            T previous = default(T);
            foreach (T current in iterable)
            {
                if (!EqualityComparer<T>.Default.Equals(current, previous))
                {
                    result.Add(current);
                    previous = current;
                }
            }

            return result;
        }
    }
}
