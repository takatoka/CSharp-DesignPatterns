using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 製品を表す抽象クラス
    /// Factoryで生成したいクラスの親クラスになる
    /// </summary>
    public abstract class Product
    {
        public abstract void Use();
    }
}
