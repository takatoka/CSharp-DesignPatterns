using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    /// <summary>
    /// Abstract クラス
    /// 処理の枠組み、処理の流れ、アルゴリズムを記述しておく
    /// 処理の具体的な内容は実装しない
    /// 順番だけ！！！！
    /// </summary>
    public abstract class AbstractDisplay
    {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();
        public void Display()
        {
            Open();
            for (int i = 0; i < 5; i++)
                Print();
            Close();
        }
    }
}
