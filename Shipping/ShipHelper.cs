using FawryEcom.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Shipping
{
    public class ShipHelper
    {
        public static void ShipNow(List<IShippable> items)
        {
            if (items.Count == 0) return;

            Console.WriteLine("\n**notification**");
            double totalKilos = 0;
            foreach (var x in items)
            {
                Console.WriteLine($"{x.GetName()} {x.GetKilos() * 1000}g");
                totalKilos += x.GetKilos();
            }
            Console.WriteLine($"total weight {totalKilos}kg");
        }
    }
}
