using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Cart
{
    public class CartLine
    {
        public MyProduct ProductItem;
        public int Count;

        public CartLine(MyProduct item, int count)
        {
            ProductItem = item;
            Count = count;
        }
    }
}
