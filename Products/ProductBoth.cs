using FawryEcom.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Products
{
    public class ProductBoth : ProductCanExpire, IShippable
    {
        public double Kilo;

        public ProductBoth(string name, double price, int count, DateTime end, double kilo)
            : base(name, price, count, end)
        {
            Kilo = kilo;
        }

        public string GetName() => ItemName;
        public double GetKilos() => Kilo;
    }
}
