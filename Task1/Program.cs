using System;

namespace Task1
{
    class Program
    {
        public static string PrintDiamond(int n)
        {
            // Проверка на четность или отрицательность числа
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            string diamond = "";


            for (int i = 0; i < n; i++)
            {
                // Количество пробелов перед звездами
                int spaces = Math.Abs((n - 1) / 2 - i);

                // Количество звезд в строке
                int stars = n - spaces * 2;

                // Добавление пробелов и звезд в строку
                diamond += new string(' ', spaces) + new string('*', stars) + "\n";
            }



            return diamond;
        }

        public static void Main(string[] args)
        {
            int n = 9; // Размер ромба
            string diamond = PrintDiamond(n);
            Console.WriteLine(diamond);
            Console.Write("Нажмите на любую кнопку на клавиатуре, чтобы закрыть программу:");
            Console.ReadKey();
        }
    }
}
