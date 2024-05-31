using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tovar
    {
        /// <summary>
        /// Поле name
        /// </summary>
        private string name;

        /// <summary>
        /// Поле price
        /// </summary>
        private int price;

        /// <summary>
        /// Поле kvo
        /// </summary>
        private int kvo;

        /// <summary>
        /// Свойство Name
        /// </summary>
        public string Name { get { return name; } set {name = value; } }

        /// <summary>
        /// Свойство Price
        /// </summary>
        public int Price 
        { 
          get {return price; } 
          set 
            { 
                if (price > 0 && price <= 20)
                {
                    price = value;
                }

                else if (price < 1 && price > 20)
                {
                    Console.WriteLine($"Количество не может быть больше/или меньше 1 до 20 ");
                }
            } 
        }

        /// <summary>
        /// Свойство Kvo
        /// </summary>
        public int Kvo 
        { 
            get {return kvo; } 
            set 
            { 
                if (kvo >= 0 && kvo <= 10)
                {
                    kvo = value;
                }

                else if(kvo < 0 || kvo > 10)
                {
                    Console.WriteLine($"Количество не может быть больше/меньше 0 до 10");
                }
            } 
        }

        public Tovar()
        {

        }

        public Tovar(string name, int price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }

        public static Tovar InfoTovar()
        {
            Console.Write("Введите название товара: ");
            string name = Console.ReadLine();
            Console.Write("Введите колличество товара: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Введите цену товаров: ");
            int price = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Название: {name}, Цена: {price}, Кол-во товаров: {kvo}\n");
            return new Tovar(name, price, kvo);
        }

        public int Sum()
        {
            return Price * Kvo;
        }
    }
}
