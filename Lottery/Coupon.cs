using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class Coupon
    {
        public List<List<int>> CouponList { private get; set; }

        public void AddCoupons(int amountOfCoupons)
        {
            CouponList = new List<List<int>>();
            int amountOfNumbers = 6;
            Random randomNumber = new Random();
            int currentNumber = 0;
            Console.Write("Adding coupons, please wait");
            for (int i = 0; i < amountOfCoupons; i++)
            {
                List<int> coupon = new List<int>(amountOfNumbers);
                if (i % 3000000 == 0) Console.Write(".");
                //Console.Write("Adding coupon nr {0}\r", i); /* fancy stuff but slows down the app by a large margin */

                for (int j = 0; j < amountOfNumbers; j++)
                {
                    while(true)
                    {
                        currentNumber = randomNumber.Next(1, 50);
                        if (!coupon.Contains(currentNumber))
                        {
                            coupon.Add(currentNumber);
                            break;
                        }
                    }
                }

                CouponList.Add(coupon);
                //Console.WriteLine(string.Join(",", coupon));  // Print the numbers, one coupon = one line
            }
            Console.WriteLine("\nCoupons adding finished successfully.");
        }

        public bool CheckWinner(List<int> winningCoupon)
        {
            Console.WriteLine("Checking if you are the winner! Please wait...");
            foreach (var match in CouponList)
            {
                foreach (int elem in winningCoupon)
                {
                    int count = 0;
                    if (match.Contains(elem)) count++;
                    if (count == 6)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
