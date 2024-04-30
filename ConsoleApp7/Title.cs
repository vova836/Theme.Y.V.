using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Создаем класс Рассказ
    /// </summary>
    class Title
    {
        /// <summary>
        /// Создаем поле нашего рассказа 
        /// </summary>
        private string title;

        /// <summary>
        /// Добавляем конструктор рассказа
        /// </summary>
        /// <param name="title"></param>
        public Title(string title)
        {
            this.title = title;
        }

        /// <summary>
        /// Создаем метод вывода информации Show() рассказа
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Название книги: {title}");
        }
    }
}
