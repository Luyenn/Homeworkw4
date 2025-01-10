using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Views
{
    internal class BookViews
    {
        public interface IView
        {
            void Render();
        }

        public class BookSingleView : IView
        {
            private readonly Book _model;

            public BookSingleView(Book model)
            {
                _model = model;
            }

            public void Render()
            {
                Console.WriteLine("Book Details:");
                Console.WriteLine($"ID:          {_model.Id}");
                Console.WriteLine($"Title:       {_model.Title}");
                Console.WriteLine($"Authors:     {_model.Authors}");
                Console.WriteLine($"Publisher:   {_model.Publisher}");
                Console.WriteLine($"Year:        {_model.Year}");
                Console.WriteLine($"Tags:        {_model.Tags}");
                Console.WriteLine($"Description: {_model.Description}");
                Console.WriteLine($"Rating:      {_model.Rating}");
                Console.WriteLine($"Reading:     {_model.Reading}");
                Console.WriteLine($"File Name:   {_model.FileName}");
            }
        }

        public class BookListView : IView
        {
            private readonly List<Book> _models;

            public BookListView(List<Book> models)
            {
                _models = models;
            }

            public void Render()
            {
                Console.WriteLine("Book List:");
                foreach (var book in _models)
                {
                    Console.WriteLine($"[{book.Id}] {book.Title} by {book.Authors}");
                }
            }
        }

    }
}
