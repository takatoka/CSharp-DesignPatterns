﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// BookShelfクラスのスキャンを行うクラス
    /// IEnumeratorを実装すると、集合体に対する操作が提供できるようになる
    /// 集合体に対するアクセス、インデックスの管理をする
    /// </summary>
    public class BookShelfIterator : IEnumerator<Book>
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = -1;
        }

        public Book Current => _bookShelf.GetBookAt(_index);

        object IEnumerator.Current => (object)Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _bookShelf.GetLength();
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
