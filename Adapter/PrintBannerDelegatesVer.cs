using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 委譲を使ったAdapterクラス
    /// Adapteeクラスを継承ではなく内部にオブジェクトとして持っている
    /// 多重継承ができないので、オブジェクトに処理を丸投げする
    /// </summary>
    public class PrintBannerDelegatesVer : IPrint
    {
        private Banner _banner;
        private Banner2 _banner2;

        public PrintBannerDelegatesVer(string str)
        {
            _banner = new Banner(str);
            _banner2 = new Banner2(str);
        }

        public void PrintWeak()
        {
            Console.Write("Delegate version  ");
            _banner.ShowWithParen();
        }

        public void PrintStrong()
        {
            Console.Write("Delegate version  ");
            _banner.ShowWithAster();
        }

        public void PrintLine()
        {
            Console.Write("Delegate version  ");
            _banner2.ShowWithHyphen();
        }
    }
}
