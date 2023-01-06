using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_notebooks
{
    internal class Book
    {
        public string book_name;
        public string book_create_by;

        static public Book[] getBook()
        {
            return new Book[]
            {
                new Book {book_name = "test1" , book_create_by =  "test1"},
                new Book {book_name = "test2" , book_create_by =  "test2"},
                new Book {book_name = "test3" , book_create_by =  "test3"},
            };
        }  

    }
}
