using FawryEcom.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FawryEcom.Shipping
{
    public class ProductCanShip : MyProduct, IShippable
    {
        public double Kilo;

        public ProductCanShip(string name, double price, int count, double kilo)
            : base(name, price, count)
        {
            Kilo = kilo;
        }

        public string GetName() => ItemName;
        public double GetKilos() => Kilo;
    }
}
