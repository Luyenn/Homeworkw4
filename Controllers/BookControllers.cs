using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controllers
{
    internal class BookControllers
    {
namespace BookMan.Controllers
    {
        using BookMan.Models;
        using BookMan.Repositories;
        using BookMan.Views;
        using global::BookMan.Repositories;
        using System;
        using System.Linq;
        using static BookManagement.Views.BookViews;

        public class BookController
        {
            private readonly BookRepository _repository;

            public BookController()
            {
                _repository = new BookRepository();
            }

            public void Single(int id)
            {
                var book = _repository.GetBookById(id);
                if (book != null)
                {
                    var view = new BookSingleView(book);
                    view.Render();
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }

            public void List()
            {
                var books = _repository.GetAllBooks();
                var view = new BookListView(books);
                view.Render();
            }

            public void Delete(int id)
            {
                _repository.DeleteBook(id);
                Console.WriteLine($"Book with ID {id} deleted.");
            }

            public void Search(string keyword)
            {
                var books = _repository.GetAllBooks();
                var results = books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                                b.Authors.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();

                if (results.Any())
                {
                    var view = new BookListView(results);
                    view.Render();
                }
                else
                {
                    Console.WriteLine("No books found matching the keyword.");
                }
            }
        }
    }
}
}
