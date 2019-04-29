using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// 「製品」を作る手順をもつクラス
    /// 必要なのは製品を作るための順番
    /// 具体的な生成方法、newする際のことは考えない
    /// 具体的なことはサブクラスにお任せ
    /// TemplateMethodパターンのAbstractに相当
    /// </summary>
    public abstract class Factory
    {
        protected abstract Product CreateProduct(string owner);
        protected abstract void RegisterProduct(Product product);

        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
    }
}
