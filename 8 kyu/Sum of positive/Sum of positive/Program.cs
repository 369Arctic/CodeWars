using System;

public class Kata
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Подсчет суммы положительных чисел\nВведите числа через пробел");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                numbers[i] = int.Parse(inputArray[i]);
            }
            int result = PositiveSum(numbers);
            Console.WriteLine($"Сумма положительных чисел: {result}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Некорректный ввод. Можно ввести только числа");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int PositiveSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                sum += arr[i];
            }
        }
        return sum;
    }

    //public static int PositiveSum(int[] arr)
    //{
    //  return arr.Where(u => u > 0).Sum();
    //}
}