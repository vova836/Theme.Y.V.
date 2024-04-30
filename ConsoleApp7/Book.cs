using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Создаем класс Книга 
    /// </summary>
    class Book
    {
        /// <summary>
        /// Добавляем поля для будищих классов 
        /// </summary>
        private Title title;
        private Author author;
        private Content content;

        /// <summary>
        /// Создаем конструкторы этих классов   
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="content"></param>
        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        /// <summary>
        /// Создаем методы для наших классов которык могут дать различные цвета наших слов 
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            title.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            author.Show();
            Console.ForegroundColor = ConsoleColor.Red;
            content.Show();
            Console.ResetColor();

        }
    }
}
