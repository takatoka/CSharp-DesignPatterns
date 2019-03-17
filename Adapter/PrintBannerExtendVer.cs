using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// 継承を利用したAdapterクラス
    /// </summary>
    public class PrintBannerExtendVer : Banner, IPrint
    {
        public PrintBannerExtendVer(string str) : base(str)
        {
        }

        public void PrintWeak()
        {
            Console.Write("Extend version  ");
            ShowWithParen();
        }

        public void PrintStrong()
        {
            Console.Write("Extend version  ");
            ShowWithAster();
        }

        public void PrintLine()
        {
            Console.WriteLine("Print Line is not extended.");
        }
    }
}
