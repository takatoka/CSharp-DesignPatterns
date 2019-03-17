using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// クライアントから使用するインターフェース
    /// クライアントが必要をしているもの
    /// </summary>
    public interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
        void PrintLine();
    }
}
