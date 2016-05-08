using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Coupon ListOfCoupons = new Coupon();
            List<int> winningCoupon = new List<int>(6) { 4, 6, 16, 17, 21, 28 };
            ListOfCoupons.AddCoupons(20);
            //ListOfCoupons.CheckWinner(winningCoupon);

            Console.ReadKey();
        }
    }
}
