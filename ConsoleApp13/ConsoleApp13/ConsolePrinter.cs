using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public static class ConsolePrinter
    {
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    public enum AvailableColors
    {
        Black,
        Blue,
        Green,
        Yellow,
        Red,
        Magenta,
        Cyan,
        White
    }
}
