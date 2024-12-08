using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_LibraryCatalog
{
    public class Borrowing
    {
        private Stack<Book> borrowing = new Stack<Book>();

        public void Borrow(Book book)
        {
            borrowing.Push(book);
            Console.WriteLine("Borrowed: " + book);
        }

        public void UndoBorrow()
        {
            if (borrowing.Count > 0)
            {
                var lastBorrowed = borrowing.Pop();
                Console.WriteLine("Undid borrow: " + lastBorrowed);
            }
            else
            {
                Console.WriteLine("Nothing to undo");
            }
        }

        public Stack<Book> GetHistory()
        {
            return borrowing;
        }
    }
}
