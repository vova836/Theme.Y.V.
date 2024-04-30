using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /// <summary>
    /// Создаем класс Автор 
    /// </summary>
    class Author
    {
        /// <summary>
        /// Создаем поле автора 
        /// </summary>
        private string author;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="author"></param>
        public Author(string author)
        {
            this.author = author;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Автор: {author}");
        }
    }
}
