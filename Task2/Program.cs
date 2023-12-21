using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем массив со строками из условия
            string[] strings = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            //Сортируем по длине строки при помощи метода SortStringByLenght
            string[] sortedStrings = SortStringsByLength(strings);
            Console.WriteLine(string.Join(", ", sortedStrings));
            Console.Write("Нажмите на любую кнопку на клавиатуре, чтобы закрыть программу:");
            Console.ReadKey();
        }

        static string[] SortStringsByLength(string[] strings)
        {
            return strings.OrderBy(s => s.Length).ToArray();
        }
    }
}
