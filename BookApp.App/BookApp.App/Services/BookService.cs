using BookApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.App.Services
{
    public class BookService
    {
        private Book[] _books;

        public Book[] Books { get => _books; }
        public BookService()
        {
            _books= new Book[0];
        }
       
        public void CreateBook(string name,double price)
        {
         Book book =new Book(name,price);
         Array.Resize(ref _books,    _books.Length + 1);
         _books[_books.Length - 1] = book;
        }
        public void ShowBooks()
        {
            if (_books.Length>0)
            {
                foreach (Book book in _books)
                {
                    Console.WriteLine($"Name:{book.Name} Price:{book.Price}");
                }
            }
            Console.WriteLine("Book empty");
        }
    }
}
