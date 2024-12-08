using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_LibraryCatalog
{
    public class Catalog
    {
        public LinkedList<Book> Library = new LinkedList<Book>();

        public void AddBook(Book book)
        {
            Library.AddLast(book);
        }

        public void RemoveBook(Book book)
        {
            Library.Remove(book);
        }

        public LinkedList<Book> GetLibrary()
        {
            return Library;
        }
    }
}
