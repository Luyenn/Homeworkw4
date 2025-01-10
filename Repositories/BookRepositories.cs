using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Repositories
{
    using BookMan.Models;

    public class BookRepository
    {
        private readonly List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Deep Work",
                    Authors = "Cal Newport",
                    Publisher = "Grand Central Publishing",
                    Year = 2016,
                    Tags = "Productivity, Focus, Self-Improvement",
                    Description = "A guide to mastering the skill of deep work in a distracted world.",
                    Rating = 4.5,
                    Reading = false,
                    File = "deep_work.pdf"
                },
                new Book
                {
                    Id = 2,
                    Title = "Atomic Habits",
                    Authors = "James Clear",
                    Publisher = "Penguin Random House",
                    Year = 2018,
                    Tags = "Habits, Self-Improvement, Psychology",
                    Description = "Practical strategies to build good habits and break bad ones.",
                    Rating = 4.8,
                    Reading = true,
                    File = "atomic_habits.pdf"
                },
                new Book
                {
                    Id = 3,
                    Title = "Bến Xe",
                    Authors = "Thương Thái Vi",
                    Publisher = "Văn Việt Books & NXB Văn Học",
                    Year = 2013,
                    Tags = "Romance, Vietnamese Novel, Tragedy",
                    Description = "A poignant love story set in Vietnam.",
                    Rating = 4.2,
                    Reading = false,
                    File = "ben_xe.pdf"
                },
                new Book
                {
                    Id = 4,
                    Title = "3 Người Thầy Vĩ Đại",
                    Authors = "Robin Sharma",
                    Publisher = "NXB Trẻ",
                    Year = 2008,
                    Tags = "Life Lessons, Inspirational, Philosophy",
                    Description = "Life-changing lessons from three great teachers.",
                    Rating = 4.4,
                    Reading = true,
                    File = "3_thay_vi_dai.pdf"
                },
                new Book
                {
                    Id = 5,
                    Title = "The Little Prince",
                    Authors = "Antoine de Saint-Exupéry",
                    Publisher = "Reynal & Hitchcock",
                    Year = 1943,
                    Tags = "Children’s Literature, Philosophy, Classic",
                    Description = "A timeless tale of love and friendship.",
                    Rating = 4.7,
                    Reading = false,
                    File = "the_little_prince.pdf"
                }
            };
        }

        public List<Book> GetAllBooks() => _books;

        public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public void DeleteBook(int id)
        {
            var book = GetBookById(id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
    }
}
