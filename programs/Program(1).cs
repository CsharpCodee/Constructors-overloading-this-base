using System;

namespace Practic10
{
    class Book
    {
        private string title;
        private int pages;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0 && value <= 5000)
                { pages = value; }
                else
                { Console.WriteLine("Страниц должно быть от 1 до 5000!"); }
            }
        }

        public Book(string title, int pages)
        {
            this.title = title;
            Pages = pages;
        }
        public Book(string title)
        {
            this.title = title;
            this.pages = 100;
        }
        public Book()
        {
            this.title = "Без названия";
            this.pages = 1;
        }

        public void Read()
        {
            Console.WriteLine($"Читаю книгу {title}, страниц: {pages}.");
        }
        static void Main(string[] args)
        {
            Book book = new Book("Мастер и Маргарита", 0);
            book.Read();

            Book book1 = new Book("Маленький принц");
            book1.Read();

            Book book2 = new Book();
            book2.Read();
        }
    }
}
