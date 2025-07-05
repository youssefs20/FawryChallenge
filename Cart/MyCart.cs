using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Cart
{
    public class MyCart
    {
        private List<CartLine> Items = new();

        public void PutToCart(MyProduct item, int count)
        {
            if (count <= 0 || count > item.ItemCount)
            {
                Console.WriteLine($"❌ not allowed to add {count} from {item.ItemName}، quantity is not enough.");
                return;
            }

            Items.Add(new CartLine(item, count));
            Console.WriteLine($" added {count} × {item.ItemName} in cart.");
        }

        public List<CartLine> GetCartItems() => Items;
        public bool IsCartEmpty() => Items.Count == 0;
    }
}
