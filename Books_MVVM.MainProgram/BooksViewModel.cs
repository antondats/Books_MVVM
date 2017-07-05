using Books_MVVM.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_MVVM.MainProgram
{
    public class BooksViewModel
    {
        private BooksModel model;
        private RelayCommand addCommand;
        private Book addedBook = new Book();

        public ObservableCollection<Book> Books
        {
            get { return model.Books; }
        }

        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        if (addedBook.Title != null)
                        {
                            Book book = new Book();
                            book.Title = addedBook.Title;
                            book.Author = addedBook.Author;
                            book.Year = addedBook.Year;
                            Books.Insert(0, book);
                        }
                    }));
            }
        }

        public Book AddedBook
        {
            get { return addedBook; }
        }

        public BooksViewModel(BooksModel _model)
        {
            model = _model;
        }
    }
}
