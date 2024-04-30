using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача1
            //Console.WriteLine("Введите длину первой стороны прямоугольника:");
            //double side1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите длину второй стороны прямоугольника:");
            //double side2 = double.Parse(Console.ReadLine());

            //Rectangle rectangle = new Rectangle(side1, side2);

            //Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
            //Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
           

            //Задача2 
            string title = "Ионыч";
            string author = "А.П.Чехов";
            string content = "История о молодом враче который сильно изменился из-за влиния города C"; // Здесь может быть мой текст

            Book book = new Book(title, author, content);
            book.Show();
            Console.ReadKey();
        }
    }
}
