using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// BookShelf（本棚）クラスはBook（本）クラスの集合体
    /// 集合体の作成に必要なので書いてる
    /// </summary>
    public class Book
    {
        private string _name;
        public string Name { get { return _name; } }

        public Book(string name)
        {
            _name = name;
        }
    }
}
