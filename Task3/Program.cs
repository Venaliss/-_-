using System;
using System.Linq;


namespace Task3
{
    using System.Linq;

    public static class ArrayExtensions
    {
        public static int[] Square(this int[] arr)
        {
            return arr.Select(x => x * x).ToArray();
        }

        public static int[] Cube(this int[] arr)
        {
            return arr.Select(x => x * x * x).ToArray();
        }

        public static double Average(this int[] arr)
        {
            if (arr.Length == 0)
                return double.NaN;

            double sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }

        public static int Sum(this int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        public static int[] Even(this int[] arr)
        {
            return arr.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] Odd(this int[] arr)
        {
            return arr.Where(x => x % 2 != 0).ToArray();
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ", numbers.Square())); 
            Console.WriteLine(string.Join(", ", numbers.Cube())); 
            Console.WriteLine(numbers.Average()); 
            Console.WriteLine(numbers.Sum()); 
            Console.WriteLine(string.Join(", ", numbers.Even())); 
            Console.WriteLine(string.Join(", ", numbers.Odd()));

            Console.Write("Нажмите на любую кнопку на клавиатуре, чтобы закрыть программу:");
            Console.ReadKey();
        }
    }
}
