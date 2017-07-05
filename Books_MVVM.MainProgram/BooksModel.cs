using Books_MVVM.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_MVVM.MainProgram
{
    public class BooksModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public BooksModel(DataService dataService)
        {
            Books = new ObservableCollection<Book>();
            foreach (Book book in dataService.GetBooks())
            {
                Books.Add(book);
            }
        }


    }
}
