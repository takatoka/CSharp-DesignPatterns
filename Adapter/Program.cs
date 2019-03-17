using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non Adapter
            var banner = new Banner("Hello Adapter Pattern.");
            banner.ShowWithAster();
            banner.ShowWithParen();
            var banner2 = new Banner2("Hello Adapter Pattern.");
            banner2.ShowWithHyphen();


            // Extend Adapter
            IPrint print = new PrintBannerExtendVer("Hello Ex");
            print.PrintWeak();
            print.PrintStrong();


            // Delegate Adapter
            IPrint printDel = new PrintBannerDelegatesVer("Hello Delegates");
            printDel.PrintWeak();
            printDel.PrintStrong();
            printDel.PrintLine();


            Console.ReadLine();
        }
    }
}
