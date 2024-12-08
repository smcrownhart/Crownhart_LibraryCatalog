using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_LibraryCatalog
{
    public class BookTree
    {
        private bNode root;

        public BookTree()
        {
            root = null;
        }

        public void AddBook(Book book)
        {
            if (root == null)
            {
                root = new bNode(book);
            }
            else
            {
                RecursiveAddBook(root, book);
            }
        }

        private void RecursiveAddBook(bNode node, Book book)
        {
            if (node == null) return;
            if (book.Id < node.BookData.Id) 
            {
                if (node.Left == null)
                {
                    node.Left = new bNode(book);
                }
                else
                {
                    RecursiveAddBook(node.Left, book);
                }
            }
            else
            {
                if(node.Right == null)
                {
                    node.Right = new bNode(book);
                }
                else
                {
                    RecursiveAddBook(node.Right, book);
                }
                
            }

        }

        private Book SearchByIdRecursive(bNode node, int id)
        {
            if(node == null)
            {
                return null;
            }

            if(node.BookData.Id == id)
            {
                return node.BookData;
            }

            if(id < node.BookData.Id)
            {
                return SearchByIdRecursive(node.Left, id);
            }
            else
            {
                return SearchByIdRecursive(node.Right, id);
            }
        }
        public Book bookSearchISBN(string isbn)
        {
            return bookSearchRecursiveISBN(root, isbn);
        }

        

        private Book bookSearchRecursiveISBN(bNode node, string isbn)
        {
            if (node == null)
            {
                return null;
            }

            if (node.BookData.ISBN == isbn)
            {
                return node.BookData;
            }

            if (string.Compare(isbn, node.BookData.ISBN) < 0)
            {
                return bookSearchRecursiveISBN(node.Left, isbn);
            }
            else
            {
                return bookSearchRecursiveISBN(node.Right, isbn);
            }
        }

       public Book SearchByTitleOrISBN(string titleOrISBN)
        {
            return SearchByTitleOrISBNRecursive (root, titleOrISBN);
        }

        private Book SearchByTitleOrISBNRecursive(bNode node, string titleOrISBN)
        {
            if (node == null)
            {
                return null;
            }

            if(node.BookData.Title.Equals(titleOrISBN, StringComparison.OrdinalIgnoreCase))
            {
                return node.BookData;
            }

            if(node.BookData.ISBN.Equals(titleOrISBN, StringComparison.OrdinalIgnoreCase))
            {
                return node.BookData;
            }

            var leftResult = SearchByTitleOrISBNRecursive(node.Left, titleOrISBN);

            if (leftResult != null)
            {
                return leftResult;
            }

            return SearchByTitleOrISBNRecursive(node.Right, titleOrISBN);
        }

    }
}
