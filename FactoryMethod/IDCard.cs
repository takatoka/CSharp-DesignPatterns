using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// Factoryで実際に生成したいクラス
    /// </summary>
    public class IDCard : Product
    {
        private string _owner;
        public string Owner { get; }


        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{_owner}のカードを使います。");
        }
    }
}
