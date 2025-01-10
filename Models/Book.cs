using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Book
    {
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Authors { get; set; }
            public string Publisher { get; set; }
            public int Year { get; set; }
            public string Tags { get; set; }
            public string Description { get; set; }
            public double Rating { get; set; }
            public bool Reading { get; set; }
            public string File { get; set; }
            public string FileName => System.IO.Path.GetFileName(File);
        }

    }
}
