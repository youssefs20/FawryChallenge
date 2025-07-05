using FawryEcom.Users;
using FawryEcom.interfaces;
using FawryEcom.Shipping;
using FawryEcom.Cart;
using FawryEcom.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Cart
{
    public class CartCheckout
    {
        const double ShipPrice = 30;

        public static void CheckoutNow(User user, MyCart cart)
        {
            if (cart.IsCartEmpty())
            {
                Console.WriteLine("cart is empty.");
                return;
            }

            double allPrice = 0;
            List<IShippable> itemsToShip = new();

            foreach (var x in cart.GetCartItems())
            {
                var p = x.ProductItem;

                if (p.CheckIfExpired())
                {
                    Console.WriteLine($" product {p.ItemName} is expired.");
                    return;
                }

                if (x.Count > p.ItemCount)
                {
                    Console.WriteLine($" product {p.ItemName} is not enough.");
                    return;
                }

                allPrice += p.ItemPrice * x.Count;

                if (p is IShippable sh)
                {
                    for (int i = 0; i < x.Count; i++)
                        itemsToShip.Add(sh);
                }
            }

            double allKilos = itemsToShip.Sum(x => x.GetKilos());
            double shipping = allKilos > 0 ? ShipPrice : 0;
            double finalTotal = allPrice + shipping;

            if (!user.TryPay(finalTotal))
            {
                Console.WriteLine("you do not have enough funds.");
                return;
            }

            foreach (var x in cart.GetCartItems())
                x.ProductItem.ItemCount -= x.Count;

            ShipHelper.ShipNow(itemsToShip);

            Console.WriteLine("\n** Checkout receipt **");
            foreach (var x in cart.GetCartItems())
                Console.WriteLine($"{x.Count}x {x.ProductItem.ItemName} {x.ProductItem.ItemPrice * x.Count}");

            Console.WriteLine("----------------------");
            Console.WriteLine($"total price {allPrice}");
            Console.WriteLine($"shipping {shipping}");
            Console.WriteLine($"final total {finalTotal}");
            Console.WriteLine($"you have: {user.GetMoney()}");
        }
    }
}
