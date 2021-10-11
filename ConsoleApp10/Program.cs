using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine(tuple.count);
            Console.WriteLine(tuple.sum);
            Console.WriteLine(tuple.proisv);

            Console.Read();
        }
        private static (int sum, int count, int proisv) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0, proisv: 1);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
                result.proisv *= numbers[i];

            }
            return result;
        }
    }
}
