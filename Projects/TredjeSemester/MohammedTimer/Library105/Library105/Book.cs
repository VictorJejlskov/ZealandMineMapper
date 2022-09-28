using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library105
{
    public class Book
    {
        public string ISN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(string iSN, string title, string author, int price)
        {
            ISN = iSN;
            Title = title;
            Author = author;
            Price = price;
        }

    }
}
