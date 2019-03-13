using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// BookShelf（本棚）クラスはBook（本棚）クラスの集合体クラス
    /// IEnumerableインターフェースを実装することで、IEnumrator(数え上げるクラス)を生成できるようになる
    /// 集合体に対する追加、削除といった操作を実装する
    /// </summary>
    public class BookShelf : IEnumerable<Book>
    {
        private List<Book> _books;
        private int last = 0;

        public BookShelf(int maxSize)
        {
            _books = new List<Book>();
            _books.Capacity = maxSize;
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
            last++;
        }

        public int GetLength()
        {
            return last;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new BookShelfIterator(this);
        }
    }
}
