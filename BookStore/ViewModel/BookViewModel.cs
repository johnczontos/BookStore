using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using BookStore.Model;

namespace BookStore.ViewModel
{
    class BookViewModel
    {
        private IList<Book> _BooksList;

        public BookViewModel()
        {
            _BooksList = new List<Book>
            {
                new Book{ISBN = 0099598167,Title="Zen and the Art of Motorcycle Maintenance",Author="Robert Pirsig",Year=2014,Status="Reserved"},
                new Book{ISBN = 9780262033848,Title="Introduction to Algorithms, 3rd Edition",Author=" Thomas H. Cormen",Year=2009,Status="In"},
                new Book{ISBN = 9780201896831,Title="The Art of Computer Programming, Volume 1: Fundamental Algorithms",Author="Donald Knuth",Year=1968,Status="Out"},
                new Book{ISBN = 9780201896848,Title="The Art of Computer Programming, Volume 2: Seminumerical Algorithms",Author="Donald Knuth",Year=1969,Status="Out"},
                new Book{ISBN = 9780201896831,Title="The Art of Computer Programming, Volume 3: Sorting and Searching",Author="Donald Knuth",Year=1973,Status="Out"}
            };
        }
        public IList<Book> Books
        {
            get { return _BooksList; }
            set { _BooksList = value; }
        }
        public void AddBook(long isbn, string title, string author, int year, string status)
        {
            Book b = new Book { ISBN = isbn, Title = title, Author = author, Year = year, Status = status};
            _BooksList.Add(b);
        }
        Book _selectedBook;
        public Book SelectedProject
        {
            get { return _selectedBook; }
            set
            {
                _selectedBook = value;
            }
        }

        // public ICommand DeleteCommand => new Command(RemoveBook());

        public void RemoveBook(Book b)
        {

            if (b != null)
            {
                _BooksList.Remove(b);
            }
        }
    }
}
