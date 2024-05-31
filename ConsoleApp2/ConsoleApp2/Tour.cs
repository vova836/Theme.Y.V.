using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tour
    {
        private string namecountry;
        private double price;
        private int kovday;
        
        public Tour()
        {

        }

        public Tour(string namecountry, double price, int kovday)
        {
            this.namecountry = namecountry;
            this.price = price;
            this.kovday = kovday;
        }

        public string Namecountry { get {return namecountry; } set {namecountry = value; } }
        public double Price { get {return price; } set { price = value; } }
        public int Kovday { get {return kovday; } set {kovday = value; } }

        public void TourCalc()
        {
            Console.WriteLine("Минское море, бесплатное");
        }

        public void TourCalc(string namecountry)
        {
            Console.Write("Введите название места куда хотите поехать: ");
            namecountry = Console.ReadLine();
            Namecountry = namecountry;
            Console.WriteLine($"Поездка в {Namecountry}, на 1 день 50 рублей.");
        }

        public void TourCalc(string namecountry, int day)
        {
            Console.Write("Введите название места куда хотите поехать: ");
            namecountry = Console.ReadLine();
            Namecountry = namecountry;
            Console.Write("Введите колличество дней, на которые вы хотите поехать: ");
            day = int.Parse(Console.ReadLine());
            Kovday = day;
            Price = 50 * day;
            Console.WriteLine($"Поездка в {Namecountry}, на {Kovday} дней, составит {Price} рублей.");
        }
    }
}
