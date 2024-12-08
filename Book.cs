using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_LibraryCatalog
{
    public class Book
    {
        private static int NextId = 1;
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int Copies { get; set; }
        public int OriginalCopies { get; private set; }
        public int Id { get; set; }
       

        public Book(string title, string author, string isbn, int copies)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Copies = copies;
            this.OriginalCopies = copies;
            this.Id = NextId++;
            
        }
        public override string ToString()
        {
            return $"Title: {Title} \n by: {Author} \n ISBN: {ISBN} \n Copies: {Copies}";
        }

        

    }
}
