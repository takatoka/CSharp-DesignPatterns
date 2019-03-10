using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // max size 4の本棚を生成
            BookShelf bookShelf = new BookShelf(4);

            bookShelf.AppendBook(new Book("CSharp Book"));
            bookShelf.AppendBook(new Book("VB Book"));
            bookShelf.AppendBook(new Book("Java Book"));
            bookShelf.AppendBook(new Book("Ruby Book"));

            IEnumerator iterator = bookShelf.GetEnumerator();
            Console.WriteLine("----------Loop BookShelf----------");
            while(iterator.MoveNext())
            {
                Book book = (Book)(iterator.Current);
                Console.WriteLine(book.Name);
            }

            Console.WriteLine("----------Reset Iterator----------");
            iterator.Reset();
            while (iterator.MoveNext())
            {
                Book book = (Book)(iterator.Current);
                Console.WriteLine(book.Name);
            }
            Console.ReadLine();
        }
    }
}
