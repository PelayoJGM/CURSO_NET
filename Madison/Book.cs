using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madison
{
    public class Book : Product
    {
        private string Author;
        private string Isbn;

        public Book(int code, double price, string description, string author, string isbn) : base(code, price, description)

        {
            Author = author;
            Isbn = isbn;

        }
    }
}
