using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Adapteeクラス
    /// 提供されているクラス
    /// このクラスをラップしてやる必要がある
    /// </summary>
    public class Banner
    {
        private string _string;
        public Banner(string str)
        {
            _string = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($" ((({_string}))) ");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($" ***{_string}*** ");
        }
    }
}
