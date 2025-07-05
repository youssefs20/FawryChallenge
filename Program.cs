using FawryEcom.Users;
using FawryEcom.Cart;
using FawryEcom.Products;
using FawryEcom.Shipping;

namespace FawryEcom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var cheese = new ProductBoth("chesse", 100, 5, DateTime.Now.AddDays(3), 0.2);
            var biscuits = new ProductBoth("biscuits", 150, 2, DateTime.Now.AddDays(5), 0.7);
            var tv = new ProductCanShip("TV", 5000, 3, 10);
            var scratch = new MyProduct("Mobile card", 50, 10);

            var user = new User("Youssef", 1000);
            var cart = new MyCart();

            cart.PutToCart(cheese, 2);
            cart.PutToCart(biscuits, 1);
            cart.PutToCart(scratch, 1);

            CartCheckout.CheckoutNow(user, cart);
        }
    }
}
