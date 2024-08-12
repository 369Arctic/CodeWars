
namespace Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/556deca17c58da83c00002db/train/csharp
            double[] signature = { 0, 0, 1 };
            int n = 10;
            double[] result = TribonacciSequence(signature, n);
            Console.WriteLine(string.Join(", ", result));
        }

        static double[] TribonacciSequence(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[] { };
            }

            if (n <= 3)
            {
                double[] result = new double[n];
                Array.Copy(signature, result, n);
                return result;
            }

            // Initialize the sequence with the signature
            List<double> sequence = new List<double>(signature);

            // Generate the sequence until it has n elements
            for (int i = 3; i < n; i++)
            {
                double nextValue = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
                sequence.Add(nextValue);
            }

            return sequence.ToArray();
        }
    }
}
