using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Products
{
    public class ProductCanExpire : MyProduct
    {
        public DateTime EndDate;

        public ProductCanExpire(string name, double price, int count, DateTime end)
            : base(name, price, count)
        {
            EndDate = end;
        }

        public override bool CheckIfExpired()
        {
            return DateTime.Now > EndDate;
        }
    }

}
