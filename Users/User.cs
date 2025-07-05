using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryEcom.Users
{
    public class User
    {
        public string UserName;
        public double UserMoney;

        public User(string name, double money)
        {
            UserName = name;
            UserMoney = money;
        }

        public bool TryPay(double amount)
        {
            if (amount > UserMoney) return false;

            UserMoney -= amount;
            return true;
        }

        public double GetMoney() => UserMoney;
    }
}
