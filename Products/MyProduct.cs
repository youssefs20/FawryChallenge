using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom
{
    public class MyProduct
    {
        public string ItemName;
        public double ItemPrice;
        public int ItemCount;

        public MyProduct(string name, double price, int count)
        {
            ItemName = name;
            ItemPrice = price;
            ItemCount = count;
        }

        public virtual bool CheckIfExpired()
        {
            return false;
        }
    }
}
