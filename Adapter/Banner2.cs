using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Bannerクラスと似たクラス
    /// 誰かが実装してしまったものとする
    /// Bannerクラスと一緒にラップしたい
    /// </summary>
    public class Banner2
    {
        private string _string;
        public Banner2(string str)
        {
            _string = str;
        }

        public void ShowWithHyphen()
        {
            Console.WriteLine($" ---{_string}--- ");
        }
    }
}
