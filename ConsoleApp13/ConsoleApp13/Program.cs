using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для вывода:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Выберите цвет:");
            foreach (var color in Enum.GetValues(typeof(AvailableColors)))
            {
                Console.WriteLine($"{(int)color}. {color}");
            }

            int colorChoice;
            while (!int.TryParse(Console.ReadLine(), out colorChoice) || !Enum.IsDefined(typeof(AvailableColors), colorChoice))
            {
                Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 0 до 15.");
            }

            AvailableColors selectedColor = (AvailableColors)colorChoice;

            ConsolePrinter.Print(inputString, (ConsoleColor)selectedColor);

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
