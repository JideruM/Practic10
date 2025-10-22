using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10_1
{
    internal class Book 
    {
        private string title; 
        private int pages;
        private bool er_pages;
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
                if (value < 1 || value > 5000)
                {
                    Console.WriteLine("Ошибка. Число не в диапозоне.");
                    er_pages = true;
                }
                else
                {
                    pages = value;
                    er_pages = false;
                }

            }
        }
        
        public Book(string title, int page)
        {
            Title = title;
            Pages = page;

        }
        public Book(string title) : this(title, 100) { } 
        public Book() : this("Без названия", 1) { } 
        public void Read()
        {
            Console.WriteLine($"Читаю  книгу {title}, на стрнанице: {pages} ");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Book book = new Book("Империя вампиров", 744);
                book.Read();
                Book book1 = new Book("Бог злости");
                book1.Read();
                Book book2 = new Book();
                book2.Read();
            }
        }
    }
}
