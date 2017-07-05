using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_MVVM.DataAccess
{
    public class DataService
    {
        public IList<Book> GetBooks()
        {
            List<Book> books = new List<Book>()
            {
                new Book { Title = "The book thief", Author = "Markus Zusak", Year = 2006},
                new Book { Title = "The Collector", Author = "John Fowles", Year = 1963},
                new Book { Title = "Three Comrades", Author = "Erich Maria Remarque", Year = 1937},
                new Book { Title = "All Quiet on the Western Front", Author = "Erich Maria Remarque", Year = 1929},
                new Book { Title = "The Da Vinci Code", Author = "Dan Brown", Year = 2003},
            };
            return books;
        }
    }
}
