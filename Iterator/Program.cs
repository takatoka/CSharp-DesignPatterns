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

            //IEnumerator iterator = bookShelf.GetEnumerator();
            Console.WriteLine("----------Loop BookShelf----------");
            // IEnumerableインターフェースを実装しているとforeachが使える
            // foreach中ではiterator.MoveNext()とiterator.Currentの2つを自動で行ってくれる
            // ↓と同じことをしていることになる
            //var iterator = bookShelf.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    Console.Write(iterator.Current);
            //}
            foreach(var book in bookShelf)
            {
                Console.WriteLine(book.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Iterator is initialized");
            //iterator.Reset();
            foreach (var book in bookShelf)
            {
                Console.WriteLine(book.Name);
            }
            Console.ReadLine();
        }
    }
}
