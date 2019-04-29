using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class IDCardFactory : Factory
    {
        private List<IDCard> _owners = new List<IDCard>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add((IDCard)product);
        }
    }
}
